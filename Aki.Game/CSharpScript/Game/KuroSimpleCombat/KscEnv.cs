using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.KuroSimpleCombat
{
	// Token: 0x02006FB9 RID: 28601
	[NullableContext(2)]
	[Nullable(0)]
	public class KscEnv : Singleton
	{
		// Token: 0x17009B7D RID: 39805
		// (get) Token: 0x0604580E RID: 284686 RVA: 0x0113E1DC File Offset: 0x0113C3DC
		public UKSC_World KscWorld
		{
			get
			{
				return this.KscWorldInternal;
			}
		}

		// Token: 0x17009B7E RID: 39806
		// (get) Token: 0x0604580F RID: 284687 RVA: 0x0113E1E4 File Offset: 0x0113C3E4
		public int KscWorldHandle
		{
			get
			{
				return this.KscWorldHandleInternal;
			}
		}

		// Token: 0x17009B7F RID: 39807
		// (get) Token: 0x06045810 RID: 284688 RVA: 0x0113E1EC File Offset: 0x0113C3EC
		public UKuroSimpleCombatSubsystem KscSubsystem
		{
			get
			{
				return USubsystemBlueprintLibrary.GetGameInstanceSubsystem(GlobalData.GameInstance, UKuroSimpleCombatSubsystem.StaticClass()) as UKuroSimpleCombatSubsystem;
			}
		}

		// Token: 0x06045811 RID: 284689 RVA: 0x0113E208 File Offset: 0x0113C408
		public void Start(UClass worldClass = null)
		{
			if (this.Started)
			{
				return;
			}
			this.Started = true;
			KscLog.Info(KscLog.EModule.Common, ELogAuthor.PZ, this.KscWorld, "KscEnv启动", default(ReadOnlySpan<ValueTuple<string, object>>));
			UKuroSimpleCombatSubsystem kscSubsystem = this.KscSubsystem;
			if (((kscSubsystem != null) ? kscSubsystem.GetKSCWorld() : null) == null)
			{
				UKuroSimpleCombatSubsystem kscSubsystem2 = this.KscSubsystem;
				if (kscSubsystem2 != null)
				{
					kscSubsystem2.CreateWorld(worldClass);
				}
				int num = this.KscWorldHandleInternal + 1;
				this.KscWorldHandleInternal = num;
				KscUtil.SetKscWorldHandle(num);
				UKuroSimpleCombatSubsystem kscSubsystem3 = this.KscSubsystem;
				this.KscWorldInternal = ((kscSubsystem3 != null) ? kscSubsystem3.GetKSCWorld() : null);
				this.SetupBounds();
			}
			else
			{
				UKuroSimpleCombatSubsystem kscSubsystem4 = this.KscSubsystem;
				this.KscWorldInternal = ((kscSubsystem4 != null) ? kscSubsystem4.GetKSCWorld() : null);
			}
			if (Info.Instance.IsBuildDevelopmentOrDebug)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "ksc.log.Buff 1", null);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "ksc.log.Damage 1", null);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "ksc.log.Attr 1", null);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "ksc.log.Skill 1", null);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "ksc.log.Move 0", null);
			}
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "bullet.kfc.enable 1", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "ksc.entity.kfc.enable 1", null);
			this.OnStart();
			if (this.WorldKillZ != null)
			{
				UKSC_World kscWorld = this.KscWorld;
				if (kscWorld != null)
				{
					kscWorld.SetWorldAttr(EKSC_WorldAttrType.WorldKillZ, (int)this.WorldKillZ.Value);
				}
				this.WorldKillZ = null;
			}
			if (this.ObstacleSegments != null)
			{
				UKSC_World kscWorld2 = this.KscWorld;
				if (kscWorld2 != null)
				{
					kscWorld2.SetObstacleSegments(this.ObstacleSegments);
				}
				this.ObstacleSegments = null;
			}
		}

		// Token: 0x06045812 RID: 284690 RVA: 0x0113E39C File Offset: 0x0113C59C
		private unsafe void SetupBounds()
		{
			if (this.KscWorldInternal == null)
			{
				KscLog.Info(KscLog.EModule.Load, ELogAuthor.HCW, this.KscWorldInternal, "KscWorld 为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			int curLevelId = SurvivorsRogueModel.Instance.CurLevelId;
			if (curLevelId == 0)
			{
				KscLog.EModule flag = KscLog.EModule.Load;
				ELogAuthor author = ELogAuthor.HCW;
				UObject kscWorldInternal = this.KscWorldInternal;
				string log = "不在幸存者关卡内";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("LevelId", curLevelId);
				KscLog.Info(flag, author, kscWorldInternal, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.KscWorldInternal.SetWorldBounds(null);
				return;
			}
			SurvivorsLevel? survivorsLevel = SurvivorsRogueConfig.Instance.GetSurvivorsLevel(curLevelId);
			if (survivorsLevel == null)
			{
				KscLog.EModule flag2 = KscLog.EModule.Load;
				ELogAuthor author2 = ELogAuthor.HCW;
				UObject kscWorldInternal2 = this.KscWorldInternal;
				string log2 = "找不到对应的关卡配置";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("LevelId", curLevelId);
				KscLog.Error(flag2, author2, kscWorldInternal2, log2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				this.KscWorldInternal.SetWorldBounds(null);
				return;
			}
			if (string.IsNullOrEmpty(survivorsLevel.Value.BoundsPath))
			{
				KscLog.EModule flag3 = KscLog.EModule.Load;
				ELogAuthor author3 = ELogAuthor.HCW;
				UObject kscWorldInternal3 = this.KscWorldInternal;
				string log3 = "BoundsPath 为空";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("LevelId", curLevelId);
				KscLog.Info(flag3, author3, kscWorldInternal3, log3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				this.KscWorldInternal.SetWorldBounds(null);
				return;
			}
			UKSC_DA_WorldBounds uksc_DA_WorldBounds = ResourceSystem.Instance.Load<UKSC_DA_WorldBounds>(survivorsLevel.Value.BoundsPath, "js_undefined");
			if (uksc_DA_WorldBounds == null || !uksc_DA_WorldBounds.IsValid())
			{
				KscLog.EModule flag4 = KscLog.EModule.Load;
				ELogAuthor author4 = ELogAuthor.HCW;
				UObject kscWorldInternal4 = this.KscWorldInternal;
				string log4 = "加载不到对应的DA";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Path", survivorsLevel.Value.BoundsPath);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("LevelId", curLevelId);
				KscLog.Error(flag4, author4, kscWorldInternal4, log4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.KscWorldInternal.SetWorldBounds(null);
				return;
			}
			this.KscWorldInternal.SetWorldBounds(uksc_DA_WorldBounds);
		}

		// Token: 0x06045813 RID: 284691 RVA: 0x0113E568 File Offset: 0x0113C768
		private void OnStart()
		{
			UKSC_World kscWorld = this.KscWorld;
			if (kscWorld != null)
			{
				FOnKSCBatchRemoveAfter fonKSCBatchRemoveAfter = DelegateUtils.ToManualReleaseDelegate<FOnKSCBatchRemoveAfter>(new <>A{00000003}<TArray<FKSC_RemoveContext>>(this.BatchRemove));
				kscWorld.AssignBatchRemoveDelegate(fonKSCBatchRemoveAfter);
			}
			UKSC_World kscWorld2 = this.KscWorld;
			if (kscWorld2 == null)
			{
				return;
			}
			FOnKSCLandFireSpawn fonKSCLandFireSpawn = DelegateUtils.ToManualReleaseDelegate<FOnKSCLandFireSpawn>(new <>A{00000003}<TArray<FKSC_LandFireContext>>(this.LandFireSpawn));
			kscWorld2.AssignLandFireSpawnDelegate(fonKSCLandFireSpawn);
		}

		// Token: 0x06045814 RID: 284692 RVA: 0x0113E5BE File Offset: 0x0113C7BE
		[NullableContext(1)]
		public void BatchRemove(in TArray<FKSC_RemoveContext> contexts)
		{
			if (!this.Started)
			{
				return;
			}
			KuroSimpleCombatController.Instance.BatchRemove(contexts);
		}

		// Token: 0x06045815 RID: 284693 RVA: 0x0113E5D5 File Offset: 0x0113C7D5
		[NullableContext(1)]
		public void LandFireSpawn(in TArray<FKSC_LandFireContext> contexts)
		{
			if (!this.Started)
			{
				return;
			}
			KuroSimpleCombatController.Instance.LandFireSpawn(contexts);
		}

		// Token: 0x06045816 RID: 284694 RVA: 0x0113E5EC File Offset: 0x0113C7EC
		public void Stop()
		{
			if (!this.Started)
			{
				return;
			}
			this.Started = false;
			KscLog.Info(KscLog.EModule.Common, ELogAuthor.PZ, this.KscWorld, "KscEnv停止", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.OnStop();
			UKuroSimpleCombatSubsystem kscSubsystem = this.KscSubsystem;
			if (kscSubsystem != null)
			{
				kscSubsystem.DestroyWorld();
			}
			int num = this.KscWorldHandleInternal + 1;
			this.KscWorldHandleInternal = num;
			KscUtil.SetKscWorldHandle(num);
			this.KscWorldInternal = null;
		}

		// Token: 0x06045817 RID: 284695 RVA: 0x0113E659 File Offset: 0x0113C859
		private void OnStop()
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new <>A{00000003}<TArray<FKSC_RemoveContext>>(this.BatchRemove));
			DelegateUtils.ReleaseManualReleaseDelegate(new <>A{00000003}<TArray<FKSC_LandFireContext>>(this.LandFireSpawn));
		}

		// Token: 0x06045818 RID: 284696 RVA: 0x0113E67D File Offset: 0x0113C87D
		public void CacheWorldKillZ(float killZ)
		{
			this.WorldKillZ = new float?(killZ);
		}

		// Token: 0x06045819 RID: 284697 RVA: 0x0113E68B File Offset: 0x0113C88B
		[NullableContext(1)]
		public void CacheObstacleSegments(TArray<FKSC_Segment> inObstacleSegments)
		{
			this.ObstacleSegments = inObstacleSegments;
		}

		// Token: 0x17009B80 RID: 39808
		// (get) Token: 0x0604581A RID: 284698 RVA: 0x0113E694 File Offset: 0x0113C894
		[Nullable(1)]
		public static KscEnv Instance
		{
			[NullableContext(1)]
			get
			{
				if (KscEnv._instance == null)
				{
					KscEnv._instance = new KscEnv();
					KscEnv._instance.OnInit();
				}
				return KscEnv._instance;
			}
		}

		// Token: 0x0604581B RID: 284699 RVA: 0x0113E6B7 File Offset: 0x0113C8B7
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604581C RID: 284700 RVA: 0x0113E6B9 File Offset: 0x0113C8B9
		public static void ResetStaticDefaultValue()
		{
			KscEnv instance = KscEnv._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			KscEnv._instance = null;
		}

		// Token: 0x0604581D RID: 284701 RVA: 0x0113E6D2 File Offset: 0x0113C8D2
		static KscEnv()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(KscEnv.CreateStaticDefaultValue), new Action(KscEnv.ResetStaticDefaultValue));
		}

		// Token: 0x04024444 RID: 148548
		public bool Started;

		// Token: 0x04024445 RID: 148549
		private float? WorldKillZ;

		// Token: 0x04024446 RID: 148550
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKSC_Segment> ObstacleSegments;

		// Token: 0x04024447 RID: 148551
		private UKSC_World KscWorldInternal;

		// Token: 0x04024448 RID: 148552
		private int KscWorldHandleInternal;

		// Token: 0x04024449 RID: 148553
		private static KscEnv _instance;
	}
}
