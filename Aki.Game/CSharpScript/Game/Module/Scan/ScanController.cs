using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Effect.BluePrint.BP_FX_Common;
using CSharpScript.Core.Framework;
using CSharpScript.Game.LevelGamePlay.Common;
using UnrealEngine;

namespace CSharpScript.Game.Module.Scan
{
	// Token: 0x02003C44 RID: 15428
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class ScanController : ControllerBase
	{
		// Token: 0x0602785D RID: 161885 RVA: 0x00B16560 File Offset: 0x00B14760
		public void StartScan()
		{
			LevelGamePlayConfig instance = LevelGamePlayConfig.Instance;
			float scanMaxDistance = (float)(((instance != null) ? instance.ScanMaxDistance : 0) * 100);
			LevelGamePlayConfig instance2 = LevelGamePlayConfig.Instance;
			ScanData scanData = new ScanData(scanMaxDistance, (float)(((instance2 != null) ? instance2.ScanShowInteractionEffectMaxDistance : 0) * 100));
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity == null)
			{
				Log.Instance.Warn(ELogModule.LevelPlay, ELogAuthor.CH, "ScanController.StartScan:当前编队实体为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			WorldEntity entity = getCurrentEntity.Entity;
			BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
			if (baseActorComponent == null)
			{
				Log.Instance.Warn(ELogModule.LevelPlay, ELogAuthor.CH, "ScanController.StartScan:当前角色组件为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			AActor aactor = ActorSystem.Instance.Spawn(BP_Fx_Scanning_C.StaticClass(), baseActorComponent.ActorTransform, baseActorComponent.Owner);
			if (aactor == null)
			{
				Log.Instance.Warn(ELogModule.LevelPlay, ELogAuthor.CH, "ScanController.StartScan:扫描特效Actor为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			aactor.D_K2_SetActorLocation(baseActorComponent.ActorLocation, false, ref WorldGlobal.SweepHitResult, false);
			scanData.ScanningEffectActor = (aactor as BP_Fx_Scanning_C);
			scanData.ScanningEffectActor.StartScanEffect();
			scanData.FindNearbyEntities();
			this.ScanDataCache[scanData.Id] = scanData;
		}

		// Token: 0x0602785E RID: 161886 RVA: 0x00B16680 File Offset: 0x00B14880
		private bool ScanEffectTick(float delta, int id)
		{
			ScanData scanData;
			if (!this.ScanDataCache.TryGetValue(id, out scanData))
			{
				return false;
			}
			if (!scanData.UpdateScanRadius((float)((double)delta * TimeUtil.Instance.Millisecond * (double)CharacterModel.Instance.InverseSelfCenteredTimeDilation)))
			{
				return true;
			}
			if (!scanData.IsScanComplete())
			{
				scanData.ProcessNearbyEntities();
				return true;
			}
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity == null)
			{
				return false;
			}
			TsGameplayBlueprintFunctionLibrary.SendScanSkillUseLogData(getCurrentEntity.Id, scanData.HasTarget);
			scanData.EndScan();
			return false;
		}

		// Token: 0x0602785F RID: 161887 RVA: 0x00B166FC File Offset: 0x00B148FC
		protected override void OnTick(float delta)
		{
			List<int> list = new List<int>();
			foreach (ScanData scanData in this.ScanDataCache.Values)
			{
				if (!this.ScanEffectTick(delta, scanData.Id))
				{
					list.Add(scanData.Id);
				}
			}
			foreach (int key in list)
			{
				this.ScanDataCache.Remove(key);
			}
		}

		// Token: 0x170050AD RID: 20653
		// (get) Token: 0x06027860 RID: 161888 RVA: 0x00B167B4 File Offset: 0x00B149B4
		public static ScanController Instance
		{
			get
			{
				return ScanController._Instance;
			}
		}

		// Token: 0x06027861 RID: 161889 RVA: 0x00B167BB File Offset: 0x00B149BB
		public static ScanController GetOrCreateInstance()
		{
			if (ScanController._Instance == null)
			{
				ScanController.CreateInstance();
			}
			return ScanController._Instance;
		}

		// Token: 0x06027862 RID: 161890 RVA: 0x00B167CF File Offset: 0x00B149CF
		public static bool CreateInstance()
		{
			if (ScanController._Instance != null)
			{
				return true;
			}
			ScanController._Instance = new ScanController();
			return true;
		}

		// Token: 0x06027863 RID: 161891 RVA: 0x00B167E5 File Offset: 0x00B149E5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06027864 RID: 161892 RVA: 0x00B167E7 File Offset: 0x00B149E7
		public static void ResetStaticDefaultValue()
		{
			ScanController._Instance = null;
		}

		// Token: 0x06027865 RID: 161893 RVA: 0x00B167EF File Offset: 0x00B149EF
		static ScanController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ScanController.CreateStaticDefaultValue), new Action(ScanController.ResetStaticDefaultValue));
		}

		// Token: 0x040158EB RID: 88299
		private readonly Dictionary<int, ScanData> ScanDataCache = new Dictionary<int, ScanData>();

		// Token: 0x040158EC RID: 88300
		private readonly Stat SpawnStat = Stat.Create("ScanController.StartScan", "", "");

		// Token: 0x040158ED RID: 88301
		private readonly Stat TickStat = Stat.Create("ScanController.Tick", "", "");

		// Token: 0x040158EE RID: 88302
		[Nullable(2)]
		private static ScanController _Instance;
	}
}
