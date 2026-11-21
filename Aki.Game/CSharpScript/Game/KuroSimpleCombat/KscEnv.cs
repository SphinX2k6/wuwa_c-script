using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.KuroSimpleCombat
{
	// Token: 0x0200613A RID: 24890
	[NullableContext(2)]
	[Nullable(0)]
	public class KscEnv : Singleton
	{
		// Token: 0x170070BD RID: 28861
		// (get) Token: 0x0603B9BE RID: 244158 RVA: 0x010E8008 File Offset: 0x010E6208
		public UKSC_World KscWorld
		{
			get
			{
				return this.KscWorldInternal;
			}
		}

		// Token: 0x170070BE RID: 28862
		// (get) Token: 0x0603B9BF RID: 244159 RVA: 0x010E8010 File Offset: 0x010E6210
		public int KscWorldHandle
		{
			get
			{
				return this.KscWorldHandleInternal;
			}
		}

		// Token: 0x170070BF RID: 28863
		// (get) Token: 0x0603B9C0 RID: 244160 RVA: 0x010E8018 File Offset: 0x010E6218
		public UKuroSimpleCombatSubsystem KscSubsystem
		{
			get
			{
				return USubsystemBlueprintLibrary.GetGameInstanceSubsystem(GlobalData.GameInstance, UKuroSimpleCombatSubsystem.StaticClass()) as UKuroSimpleCombatSubsystem;
			}
		}

		// Token: 0x0603B9C1 RID: 244161 RVA: 0x010E8034 File Offset: 0x010E6234
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

		// Token: 0x0603B9C2 RID: 244162 RVA: 0x010E816C File Offset: 0x010E636C
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

		// Token: 0x0603B9C3 RID: 244163 RVA: 0x010E8338 File Offset: 0x010E6538
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

		// Token: 0x0603B9C4 RID: 244164 RVA: 0x010E838E File Offset: 0x010E658E
		[NullableContext(1)]
		public void BatchRemove(in TArray<FKSC_RemoveContext> contexts)
		{
			if (!this.Started)
			{
				return;
			}
			KuroSimpleCombatController.Instance.BatchRemove(contexts);
		}

		// Token: 0x0603B9C5 RID: 244165 RVA: 0x010E83A5 File Offset: 0x010E65A5
		[NullableContext(1)]
		public void LandFireSpawn(in TArray<FKSC_LandFireContext> contexts)
		{
			if (!this.Started)
			{
				return;
			}
			KuroSimpleCombatController.Instance.LandFireSpawn(contexts);
		}

		// Token: 0x0603B9C6 RID: 244166 RVA: 0x010E83BC File Offset: 0x010E65BC
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

		// Token: 0x0603B9C7 RID: 244167 RVA: 0x010E8429 File Offset: 0x010E6629
		private void OnStop()
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new <>A{00000003}<TArray<FKSC_RemoveContext>>(this.BatchRemove));
			DelegateUtils.ReleaseManualReleaseDelegate(new <>A{00000003}<TArray<FKSC_LandFireContext>>(this.LandFireSpawn));
		}

		// Token: 0x0603B9C8 RID: 244168 RVA: 0x010E844D File Offset: 0x010E664D
		public void CacheWorldKillZ(float killZ)
		{
			this.WorldKillZ = new float?(killZ);
		}

		// Token: 0x0603B9C9 RID: 244169 RVA: 0x010E845B File Offset: 0x010E665B
		[NullableContext(1)]
		public void CacheObstacleSegments(TArray<FKSC_Segment> inObstacleSegments)
		{
			this.ObstacleSegments = inObstacleSegments;
		}

		// Token: 0x170070C0 RID: 28864
		// (get) Token: 0x0603B9CA RID: 244170 RVA: 0x010E8464 File Offset: 0x010E6664
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

		// Token: 0x0603B9CB RID: 244171 RVA: 0x010E8487 File Offset: 0x010E6687
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B9CC RID: 244172 RVA: 0x010E8489 File Offset: 0x010E6689
		public static void ResetStaticDefaultValue()
		{
			KscEnv instance = KscEnv._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			KscEnv._instance = null;
		}

		// Token: 0x0603B9CD RID: 244173 RVA: 0x010E84A2 File Offset: 0x010E66A2
		static KscEnv()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(KscEnv.CreateStaticDefaultValue), new Action(KscEnv.ResetStaticDefaultValue));
		}

		// Token: 0x0401F6F9 RID: 128761
		public bool Started;

		// Token: 0x0401F6FA RID: 128762
		private float? WorldKillZ;

		// Token: 0x0401F6FB RID: 128763
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKSC_Segment> ObstacleSegments;

		// Token: 0x0401F6FC RID: 128764
		private UKSC_World KscWorldInternal;

		// Token: 0x0401F6FD RID: 128765
		private int KscWorldHandleInternal;

		// Token: 0x0401F6FE RID: 128766
		private static KscEnv _instance;
	}
}
