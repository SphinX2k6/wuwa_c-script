using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Effect.BluePrint.BP_FX_Common;
using CSharpScript.Core.Framework;
using CSharpScript.Game.LevelGamePlay.Common;
using UnrealEngine;

namespace CSharpScript.Game.Module.Scan
{
	// Token: 0x02004C93 RID: 19603
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class ScanController : ControllerBase
	{
		// Token: 0x06032AAA RID: 207530 RVA: 0x00BD18FC File Offset: 0x00BCFAFC
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

		// Token: 0x06032AAB RID: 207531 RVA: 0x00BD1A1C File Offset: 0x00BCFC1C
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

		// Token: 0x06032AAC RID: 207532 RVA: 0x00BD1A98 File Offset: 0x00BCFC98
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

		// Token: 0x17007D03 RID: 32003
		// (get) Token: 0x06032AAD RID: 207533 RVA: 0x00BD1B50 File Offset: 0x00BCFD50
		public static ScanController Instance
		{
			get
			{
				return ScanController._Instance;
			}
		}

		// Token: 0x06032AAE RID: 207534 RVA: 0x00BD1B57 File Offset: 0x00BCFD57
		public static ScanController GetOrCreateInstance()
		{
			if (ScanController._Instance == null)
			{
				ScanController.CreateInstance();
			}
			return ScanController._Instance;
		}

		// Token: 0x06032AAF RID: 207535 RVA: 0x00BD1B6B File Offset: 0x00BCFD6B
		public static bool CreateInstance()
		{
			if (ScanController._Instance != null)
			{
				return true;
			}
			ScanController._Instance = new ScanController();
			return true;
		}

		// Token: 0x06032AB0 RID: 207536 RVA: 0x00BD1B81 File Offset: 0x00BCFD81
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06032AB1 RID: 207537 RVA: 0x00BD1B83 File Offset: 0x00BCFD83
		public static void ResetStaticDefaultValue()
		{
			ScanController._Instance = null;
		}

		// Token: 0x06032AB2 RID: 207538 RVA: 0x00BD1B8B File Offset: 0x00BCFD8B
		static ScanController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ScanController.CreateStaticDefaultValue), new Action(ScanController.ResetStaticDefaultValue));
		}

		// Token: 0x0401AF8E RID: 110478
		private readonly Dictionary<int, ScanData> ScanDataCache = new Dictionary<int, ScanData>();

		// Token: 0x0401AF8F RID: 110479
		private readonly Stat SpawnStat = Stat.Create("ScanController.StartScan", "", "");

		// Token: 0x0401AF90 RID: 110480
		private readonly Stat TickStat = Stat.Create("ScanController.Tick", "", "");

		// Token: 0x0401AF91 RID: 110481
		[Nullable(2)]
		private static ScanController _Instance;
	}
}
