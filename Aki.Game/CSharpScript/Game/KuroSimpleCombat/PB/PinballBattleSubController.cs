using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using AkiClient.Game.Aki.Data.SimpleCombat._3_3Pinball.GameBase.SpawnObj;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.KuroSimpleCombat.PB
{
	// Token: 0x02006FC0 RID: 28608
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballBattleSubController : KscSubControllerBase, IStaticVariableResetter
	{
		// Token: 0x06045853 RID: 284755 RVA: 0x01140108 File Offset: 0x0113E308
		static PinballBattleSubController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PinballBattleSubController.CreateStaticDefaultValue), new Action(PinballBattleSubController.ResetStaticDefaultValue));
		}

		// Token: 0x06045854 RID: 284756 RVA: 0x01140127 File Offset: 0x0113E327
		public static void CreateStaticDefaultValue()
		{
			PinballBattleSubController.PlayerEntityKeys = new int[]
			{
				5001,
				4001,
				4017
			};
			PinballBattleSubController.UpdateStat = Stat.Create("PinballBattleSubController.Update", "", "");
			PinballBattleSubController.EnableSpineParallelUpdate = false;
			PinballBattleSubController.EnableSpineShadow = true;
		}

		// Token: 0x06045855 RID: 284757 RVA: 0x01140164 File Offset: 0x0113E364
		public static void ResetStaticDefaultValue()
		{
			PinballBattleSubController.PlayerEntityKeys = null;
			PinballBattleSubController.UpdateStat = null;
			PinballBattleSubController.EnableSpineParallelUpdate = false;
			PinballBattleSubController.EnableSpineShadow = false;
		}

		// Token: 0x17009B81 RID: 39809
		// (get) Token: 0x06045856 RID: 284758 RVA: 0x01140180 File Offset: 0x0113E380
		private bool IsFormationTestMode
		{
			get
			{
				CreatureModel instance = CreatureModel.Instance;
				return ((instance != null) ? new int?(instance.GetInstanceId()) : null).GetValueOrDefault() == 9801;
			}
		}

		// Token: 0x06045857 RID: 284759 RVA: 0x011401BA File Offset: 0x0113E3BA
		protected override void CreateModel()
		{
			this.SubModel = new PinballBattleSubModel();
		}

		// Token: 0x06045858 RID: 284760 RVA: 0x011401C7 File Offset: 0x0113E3C7
		public PinballBattleSubModel GetModel()
		{
			return this.SubModel as PinballBattleSubModel;
		}

		// Token: 0x06045859 RID: 284761 RVA: 0x011401D4 File Offset: 0x0113E3D4
		public override bool IsTargetMap(int instSubType)
		{
			return instSubType == 45;
		}

		// Token: 0x0604585A RID: 284762 RVA: 0x011401DB File Offset: 0x0113E3DB
		[NullableContext(2)]
		protected override UClass GetKscWorldClass()
		{
			return UKSC_Shape2D_World.StaticClass().ToWeakClass();
		}

		// Token: 0x0604585B RID: 284763 RVA: 0x011401EC File Offset: 0x0113E3EC
		protected override KscCollisionAlgorithmConfig? GetCollisionAlgorithmConfig()
		{
			return new KscCollisionAlgorithmConfig?(new KscCollisionAlgorithmConfig
			{
				AlgorithmClass = UKuroFastCollisionAlgorithm_PhysicalGrid.StaticClass().ToWeakClass(),
				TickEnabled = false
			});
		}

		// Token: 0x0604585C RID: 284764 RVA: 0x01140228 File Offset: 0x0113E428
		protected override void OnInitMap()
		{
			FDamageConfig fdamageConfig = new FDamageConfig();
			fdamageConfig.AtkDamageId = 331;
			fdamageConfig.SpecialElement1DamageId = 331;
			fdamageConfig.SpecialElement2DamageId = 332;
			fdamageConfig.SpecialElement3DamageId = 333;
			fdamageConfig.SpecialElement4DamageId = 334;
			fdamageConfig.SpecialElement5DamageId = 335;
			fdamageConfig.CureDamageId = 336;
			fdamageConfig.ShieldDamageId = 337;
			fdamageConfig.EnableCompactNumberFormat = true;
			fdamageConfig.DamageFormatType = EDamageFormatType.Pinball;
			DamageUiController.Instance.SetUeDamageConfig(fdamageConfig, false);
		}

		// Token: 0x0604585D RID: 284765 RVA: 0x011402AD File Offset: 0x0113E4AD
		protected override void OnMapLoaded()
		{
			this.IsMapLoadFinish = true;
			this.InitBulletWorld();
			this.InitLevelConfig();
			this.AddTreeListener();
			this.TryInitShapeWorld();
		}

		// Token: 0x0604585E RID: 284766 RVA: 0x011402D0 File Offset: 0x0113E4D0
		private void InitLevelConfig()
		{
			int curLevelId = PinballModel.Instance.CurLevelId;
			if (curLevelId == 0)
			{
				Log.Instance.Error(ELogModule.PinballBattle, ELogAuthor.LJ, "PinballBattleSubController OnWorldDone levelId is 0", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			PinballBattleSubModel model = this.GetModel();
			PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(curLevelId);
			if (pinballLevelConfigById.Value.Type == 2)
			{
				model.SetLevelScoreTargetList((from k in pinballLevelConfigById.Value.ScoreLevelReward().Keys
				select (float)k).ToList<float>());
			}
			model.SetLevelConfig(pinballLevelConfigById);
		}

		// Token: 0x0604585F RID: 284767 RVA: 0x0114037C File Offset: 0x0113E57C
		protected override void OnWorldDone()
		{
			this.PlayerHpHandle.Init();
			KscHeadStateData kscPlayerHeadStateData = this.GetModel().KscPlayerHeadStateData;
			if (kscPlayerHeadStateData != null)
			{
				this.PlayerHpHandle.OnPlayerHpChange(kscPlayerHeadStateData);
			}
			this.InitAttrBounds();
			this.InitDamageConfigsNew();
			if (this.IsFormationTestMode)
			{
				this.TempInitKscEntities();
			}
			this.TempInitCamera(null);
			this.InitBackgroundMaterial();
			this.RefreshCameraFov();
			this.SetShapeWorldReady();
			this.CachedShowFlagTonemapper = UKismetSystemLibrary.GetConsoleVariableIntValue("r.Kuro.KuroBloomEnable");
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.KuroBloomEnable 0", null);
			this.CachedScreenSizeCullRatioFactor = UKismetSystemLibrary.GetConsoleVariableIntValue("r.ScreenSizeCullRatioFactor");
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.ScreenSizeCullRatioFactor 0", null);
			this.CachedAntiAliasing = UKismetSystemLibrary.GetConsoleVariableIntValue("r.DefaultFeature.AntiAliasing");
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.DefaultFeature.AntiAliasing 0", null);
			InputExtraShowCursorCenter.Instance.RegisterExtraRefreshData("PinballBattleInstanceForceShowCursor", new PinballBattleSubController.AlwaysShowCursor());
			this.CreateLaunchController();
			TArray<int> tarray = new TArray<int>();
			int[] pinballBroadcastBuffIdAll = PinballConfig.Instance.GetPinballBroadcastBuffIdAll();
			if (pinballBroadcastBuffIdAll != null)
			{
				foreach (int value in pinballBroadcastBuffIdAll)
				{
					tarray.Add(value);
				}
			}
			UKSC_Shape2D_World shapeWorld = this.ShapeWorld;
			if (shapeWorld == null)
			{
				return;
			}
			shapeWorld.SetBroadcastBuffIdList(tarray);
		}

		// Token: 0x06045860 RID: 284768 RVA: 0x011404B0 File Offset: 0x0113E6B0
		protected override void OnWorldReset()
		{
			this.ClearBulletWorld();
			this.KscEntityLeftBar = null;
			this.KscEntityRightBar = null;
			PinballBattlePlayerBarController leftBarController = this.LeftBarController;
			if (leftBarController != null)
			{
				leftBarController.Destroy();
			}
			PinballBattlePlayerBarController rightBarController = this.RightBarController;
			if (rightBarController != null)
			{
				rightBarController.Destroy();
			}
			this.LeftBarController = null;
			this.RightBarController = null;
			PinballBattleFeverBarController feverBarController = this.FeverBarController;
			if (feverBarController != null)
			{
				feverBarController.Destroy();
			}
			this.FeverBarController = null;
			BP_Fever_Bar_C feverBar = this.FeverBar;
			if (feverBar != null)
			{
				feverBar.K2_DestroyActor();
			}
			this.FeverBar = null;
			this.FeverBarMaterial = null;
			this.KscTeamPlayer = null;
			this.KscPlayerEntities = Array.Empty<AKSC_Shape2D_Entity_Player>();
			this.RemoveTreeListener();
			this.PlayerHpHandle.Clear();
			this.DamageInfo = null;
			this.PendingLoadBuffs = null;
			if (this.KscEntitySummonDelegateRef != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new <>A{00000018}<FTransformDouble, TArray<FKSC_SpawnEntity>, int>(this.OnKscEntitySummon));
				this.KscEntitySummonDelegateRef = null;
			}
			if (this.RelaunchPlayerDelegateRef != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.OnRelaunchPlayer));
				this.RelaunchPlayerDelegateRef = null;
			}
			if (this.TeamAllDeadDelegateRef != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.OnTeamAllDead));
				this.TeamAllDeadDelegateRef = null;
			}
			if (this.WorldUpdateOnceDelegateRef != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.OnWorldUpdateOnce));
				this.WorldUpdateOnceDelegateRef = null;
			}
			this.ClearTotalDelegateList();
			UKSC_Shape2D_World shapeWorld = this.ShapeWorld;
			if (shapeWorld != null)
			{
				shapeWorld.ClearDamageInfo();
			}
			UKSC_Shape2D_World shapeWorld2 = this.ShapeWorld;
			if (shapeWorld2 != null)
			{
				shapeWorld2.ClearDamageTotalInfo();
			}
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.Kuro.KuroBloomEnable ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.CachedShowFlagTonemapper);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			UObject world2 = GlobalData.World;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.ScreenSizeCullRatioFactor ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.CachedScreenSizeCullRatioFactor);
			UKismetSystemLibrary.ExecuteConsoleCommand(world2, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			UObject world3 = GlobalData.World;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.DefaultFeature.AntiAliasing ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.CachedAntiAliasing);
			UKismetSystemLibrary.ExecuteConsoleCommand(world3, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			this.StopAllTimerTask();
			this.LastSyncRealTimeMs = 0.0;
			this.IsInitKscPlayerEntities = false;
			this.IsFormationDataReady = false;
			this.IsShapeWorldReady = false;
			PinballBattleLaunchPhaseController launchPhaseController = this.LaunchPhaseController;
			if (launchPhaseController != null)
			{
				launchPhaseController.Destroy();
			}
			this.LaunchPhaseController = null;
			UiPanelBase launchBallItem = this.LaunchBallItem;
			if (launchBallItem != null)
			{
				launchBallItem.Destroy(null);
			}
			this.LaunchBallItem = null;
			PinballBattleLaunchDirectionController launchDirectionController = this.LaunchDirectionController;
			if (launchDirectionController != null)
			{
				launchDirectionController.Destroy();
			}
			this.LaunchDirectionController = null;
			PinballBattleLaunchDirectionItem launchDirectionItem = this.LaunchDirectionItem;
			if (launchDirectionItem != null)
			{
				launchDirectionItem.Destroy(null);
			}
			this.LaunchDirectionItem = null;
			this.AlreadyRequestBonusWin = false;
			this.IsInFixCamera = false;
			this.IsInitShapeWorld = false;
			this.IsPreloadFinish = false;
			this.IsMapLoadFinish = false;
			this.ShapeWorld = null;
			InputExtraShowCursorCenter.Instance.UnRegisterExtraRefreshData("PinballBattleInstanceForceShowCursor");
			UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("PinballPreReset");
		}

		// Token: 0x06045861 RID: 284769 RVA: 0x01140784 File Offset: 0x0113E984
		protected override void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.UIViewPortSizeChanged, new Action(this.RefreshCameraFov));
			EventSystem.Instance.Add<int>(EEventName.OnPinballScoreChanged, new Action<int>(this.OnScoreChanged));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		}

		// Token: 0x06045862 RID: 284770 RVA: 0x011407E0 File Offset: 0x0113E9E0
		protected override void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.UIViewPortSizeChanged, new Action(this.RefreshCameraFov));
			EventSystem.Instance.Remove<int>(EEventName.OnPinballScoreChanged, new Action<int>(this.OnScoreChanged));
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		}

		// Token: 0x06045863 RID: 284771 RVA: 0x0114083C File Offset: 0x0113EA3C
		protected override void OnTick(float delta)
		{
			this.UpdateDamageInfo();
			this.UpdateDamageTotalInfo();
			this.UpdateCombo();
			PinballBattlePlayerBarController leftBarController = this.LeftBarController;
			if (leftBarController != null)
			{
				leftBarController.Update();
			}
			PinballBattlePlayerBarController rightBarController = this.RightBarController;
			if (rightBarController != null)
			{
				rightBarController.Update();
			}
			PinballBattleLaunchPhaseController launchPhaseController = this.LaunchPhaseController;
			if (launchPhaseController != null)
			{
				launchPhaseController.Tick(delta);
			}
			PinballBattleLaunchDirectionController launchDirectionController = this.LaunchDirectionController;
			if (launchDirectionController == null)
			{
				return;
			}
			launchDirectionController.Update(this.KscEntityLeftBar, this.KscEntityRightBar);
		}

		// Token: 0x06045864 RID: 284772 RVA: 0x011408AC File Offset: 0x0113EAAC
		public override UniTask PreloadAsync()
		{
			PinballBattleSubController.<PreloadAsync>d__90 <PreloadAsync>d__;
			<PreloadAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadAsync>d__.<>4__this = this;
			<PreloadAsync>d__.<>1__state = -1;
			<PreloadAsync>d__.<>t__builder.Start<PinballBattleSubController.<PreloadAsync>d__90>(ref <PreloadAsync>d__);
			return <PreloadAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06045865 RID: 284773 RVA: 0x011408F0 File Offset: 0x0113EAF0
		private void TryInitShapeWorld()
		{
			if (!this.IsPreloadFinish || !this.IsMapLoadFinish || this.IsInitShapeWorld)
			{
				return;
			}
			UKSC_Shape2D_World uksc_Shape2D_World = KscEnv.Instance.KscWorld as UKSC_Shape2D_World;
			if (uksc_Shape2D_World == null)
			{
				KscLog.Error(KscLog.EModule.Common, ELogAuthor.WWJ, KscEnv.Instance.KscWorld, "TryInitShapeWorld 初始化失败, World不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.IsInitShapeWorld = true;
			this.ShapeWorld = uksc_Shape2D_World;
			GameModeModel instance = GameModeModel.Instance;
			FVectorDouble? fvectorDouble = (instance != null) ? instance.BornLocation : null;
			if (fvectorDouble != null)
			{
				this.WorldOrigin.FromConfigVector(fvectorDouble);
				this.WorldOriginTransform.SetLocation(this.WorldOrigin);
			}
			UKSC_Shape2D_World uksc_Shape2D_World2 = uksc_Shape2D_World;
			FVectorDouble fvectorDouble2 = this.WorldOrigin.ToUeVector(false);
			uksc_Shape2D_World2.SetWorldOrigin(fvectorDouble2);
			UKSC_DA_Shape2D_World shapeWorldDa = this.GetModel().ShapeWorldDa;
			if (shapeWorldDa != null)
			{
				uksc_Shape2D_World.SetShape2DWorldDA(shapeWorldDa);
				this.InitLocation.X = (double)shapeWorldDa.InitLocation.X + this.WorldOrigin.X;
				this.InitLocation.Y = (double)shapeWorldDa.InitLocation.Y + this.WorldOrigin.Y;
			}
			UKSC_DA_Shape2D_WorldBounds shapeWorldBoundsDa = this.GetModel().ShapeWorldBoundsDa;
			if (shapeWorldBoundsDa != null)
			{
				uksc_Shape2D_World.SetWorldBounds(shapeWorldBoundsDa);
				this.GroundPositionZ = shapeWorldBoundsDa.GroundPositionZ + (float)this.WorldOrigin.Z;
				this.InitLocation.Z = (double)this.GroundPositionZ;
				global::Vector location = this.WorldOriginTransform.GetLocation();
				location.Z = (double)this.GroundPositionZ;
				this.WorldOriginTransform.SetLocation(location);
			}
			this.BornTransform.SetLocation(this.InitLocation);
			UDataTable shapeMaterialDt = this.GetModel().ShapeMaterialDt;
			if (shapeMaterialDt != null)
			{
				uksc_Shape2D_World.SetShapeMaterialDT(shapeMaterialDt);
			}
			UDataTable bulletDataTable = this.GetModel().BulletDataTable;
			BulletModel instance2 = BulletModel.Instance;
			UBulletWorld ubulletWorld = (instance2 != null) ? instance2.GetKuroBulletWorld() : null;
			if (ubulletWorld != null && bulletDataTable != null)
			{
				ubulletWorld.AddCommonBulletDataTable(bulletDataTable);
			}
			foreach (KeyValuePair<int, UKSC_DA_Buff> keyValuePair in this.GetModel().LoadedBuffDaMap)
			{
				int num;
				UKSC_DA_Buff uksc_DA_Buff;
				keyValuePair.Deconstruct(out num, out uksc_DA_Buff);
				int value = num;
				UKSC_DA_Buff key = uksc_DA_Buff;
				uksc_Shape2D_World.LoadedBuffDa.Add(key, value);
			}
			this.KscEntitySummonDelegateRef = DelegateUtils.ToManualReleaseDelegate<FOnKSCEntitySummon>(new <>A{00000018}<FTransformDouble, TArray<FKSC_SpawnEntity>, int>(this.OnKscEntitySummon));
			this.RelaunchPlayerDelegateRef = DelegateUtils.ToManualReleaseDelegate<FOnRelaunchPlayer>(new Action(this.OnRelaunchPlayer));
			this.TeamAllDeadDelegateRef = DelegateUtils.ToManualReleaseDelegate<FOnTeamAllDead>(new Action(this.OnTeamAllDead));
			uksc_Shape2D_World.AssignKSCEntitySummon(this.KscEntitySummonDelegateRef);
			uksc_Shape2D_World.AssignRelaunchPlayer(this.RelaunchPlayerDelegateRef);
			uksc_Shape2D_World.AssignTeamAllDead(this.TeamAllDeadDelegateRef);
		}

		// Token: 0x06045866 RID: 284774 RVA: 0x01140BA8 File Offset: 0x0113EDA8
		protected UniTask LoadBulletDt()
		{
			PinballBattleSubController.<LoadBulletDt>d__92 <LoadBulletDt>d__;
			<LoadBulletDt>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadBulletDt>d__.<>4__this = this;
			<LoadBulletDt>d__.<>1__state = -1;
			<LoadBulletDt>d__.<>t__builder.Start<PinballBattleSubController.<LoadBulletDt>d__92>(ref <LoadBulletDt>d__);
			return <LoadBulletDt>d__.<>t__builder.Task;
		}

		// Token: 0x06045867 RID: 284775 RVA: 0x01140BEC File Offset: 0x0113EDEC
		protected UniTask LoadShapeWorldDa()
		{
			PinballBattleSubController.<LoadShapeWorldDa>d__93 <LoadShapeWorldDa>d__;
			<LoadShapeWorldDa>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadShapeWorldDa>d__.<>4__this = this;
			<LoadShapeWorldDa>d__.<>1__state = -1;
			<LoadShapeWorldDa>d__.<>t__builder.Start<PinballBattleSubController.<LoadShapeWorldDa>d__93>(ref <LoadShapeWorldDa>d__);
			return <LoadShapeWorldDa>d__.<>t__builder.Task;
		}

		// Token: 0x06045868 RID: 284776 RVA: 0x01140C30 File Offset: 0x0113EE30
		protected UniTask LoadShapeWorldBoundsDa()
		{
			PinballBattleSubController.<LoadShapeWorldBoundsDa>d__94 <LoadShapeWorldBoundsDa>d__;
			<LoadShapeWorldBoundsDa>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadShapeWorldBoundsDa>d__.<>4__this = this;
			<LoadShapeWorldBoundsDa>d__.<>1__state = -1;
			<LoadShapeWorldBoundsDa>d__.<>t__builder.Start<PinballBattleSubController.<LoadShapeWorldBoundsDa>d__94>(ref <LoadShapeWorldBoundsDa>d__);
			return <LoadShapeWorldBoundsDa>d__.<>t__builder.Task;
		}

		// Token: 0x06045869 RID: 284777 RVA: 0x01140C74 File Offset: 0x0113EE74
		protected UniTask LoadShapeMaterialDt()
		{
			PinballBattleSubController.<LoadShapeMaterialDt>d__95 <LoadShapeMaterialDt>d__;
			<LoadShapeMaterialDt>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadShapeMaterialDt>d__.<>4__this = this;
			<LoadShapeMaterialDt>d__.<>1__state = -1;
			<LoadShapeMaterialDt>d__.<>t__builder.Start<PinballBattleSubController.<LoadShapeMaterialDt>d__95>(ref <LoadShapeMaterialDt>d__);
			return <LoadShapeMaterialDt>d__.<>t__builder.Task;
		}

		// Token: 0x0604586A RID: 284778 RVA: 0x01140CB8 File Offset: 0x0113EEB8
		protected UniTask LoadShowBuffDa()
		{
			PinballBattleSubController.<LoadShowBuffDa>d__96 <LoadShowBuffDa>d__;
			<LoadShowBuffDa>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadShowBuffDa>d__.<>4__this = this;
			<LoadShowBuffDa>d__.<>1__state = -1;
			<LoadShowBuffDa>d__.<>t__builder.Start<PinballBattleSubController.<LoadShowBuffDa>d__96>(ref <LoadShowBuffDa>d__);
			return <LoadShowBuffDa>d__.<>t__builder.Task;
		}

		// Token: 0x0604586B RID: 284779 RVA: 0x01140CFC File Offset: 0x0113EEFC
		protected UniTask LoadSummonBuffDa()
		{
			PinballBattleSubController.<LoadSummonBuffDa>d__97 <LoadSummonBuffDa>d__;
			<LoadSummonBuffDa>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadSummonBuffDa>d__.<>4__this = this;
			<LoadSummonBuffDa>d__.<>1__state = -1;
			<LoadSummonBuffDa>d__.<>t__builder.Start<PinballBattleSubController.<LoadSummonBuffDa>d__97>(ref <LoadSummonBuffDa>d__);
			return <LoadSummonBuffDa>d__.<>t__builder.Task;
		}

		// Token: 0x0604586C RID: 284780 RVA: 0x01140D40 File Offset: 0x0113EF40
		protected UniTask LoadRoleBornBuffDa()
		{
			PinballBattleSubController.<LoadRoleBornBuffDa>d__98 <LoadRoleBornBuffDa>d__;
			<LoadRoleBornBuffDa>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadRoleBornBuffDa>d__.<>4__this = this;
			<LoadRoleBornBuffDa>d__.<>1__state = -1;
			<LoadRoleBornBuffDa>d__.<>t__builder.Start<PinballBattleSubController.<LoadRoleBornBuffDa>d__98>(ref <LoadRoleBornBuffDa>d__);
			return <LoadRoleBornBuffDa>d__.<>t__builder.Task;
		}

		// Token: 0x0604586D RID: 284781 RVA: 0x01140D84 File Offset: 0x0113EF84
		private bool AddLoadBuffTask(int buffId, List<UniTask> outTasks)
		{
			if (this.PendingLoadBuffs == null)
			{
				this.PendingLoadBuffs = new HashSet<int>();
			}
			else if (this.PendingLoadBuffs.Contains(buffId))
			{
				return false;
			}
			KSCBuff? kscbuff;
			string text = (ConfigKSCBuffById.GetConfig(buffId, true) != null) ? kscbuff.GetValueOrDefault().AssetPath : null;
			if (string.IsNullOrEmpty(text))
			{
				return false;
			}
			CustomPromise promise = new CustomPromise();
			ResourceSystem.Instance.LoadAsync<UKSC_DA_Buff>(text, delegate([Nullable(2)] UKSC_DA_Buff daBuff, string _)
			{
				if (daBuff != null)
				{
					this.GetModel().LoadedBuffDaMap[buffId] = daBuff;
				}
				promise.SetResult();
			}, 100, "js_undefined");
			outTasks.Add(promise.Promise);
			this.PendingLoadBuffs.Add(buffId);
			return true;
		}

		// Token: 0x0604586E RID: 284782 RVA: 0x01140E50 File Offset: 0x0113F050
		private UniTask LoadLaunchCurves()
		{
			PinballBattleSubController.<LoadLaunchCurves>d__100 <LoadLaunchCurves>d__;
			<LoadLaunchCurves>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadLaunchCurves>d__.<>4__this = this;
			<LoadLaunchCurves>d__.<>1__state = -1;
			<LoadLaunchCurves>d__.<>t__builder.Start<PinballBattleSubController.<LoadLaunchCurves>d__100>(ref <LoadLaunchCurves>d__);
			return <LoadLaunchCurves>d__.<>t__builder.Task;
		}

		// Token: 0x0604586F RID: 284783 RVA: 0x01140E94 File Offset: 0x0113F094
		private UniTask LoadLaunchBall()
		{
			PinballBattleSubController.<LoadLaunchBall>d__101 <LoadLaunchBall>d__;
			<LoadLaunchBall>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadLaunchBall>d__.<>4__this = this;
			<LoadLaunchBall>d__.<>1__state = -1;
			<LoadLaunchBall>d__.<>t__builder.Start<PinballBattleSubController.<LoadLaunchBall>d__101>(ref <LoadLaunchBall>d__);
			return <LoadLaunchBall>d__.<>t__builder.Task;
		}

		// Token: 0x06045870 RID: 284784 RVA: 0x01140ED8 File Offset: 0x0113F0D8
		protected UniTask LoadFeverBarClass()
		{
			PinballBattleSubController.<LoadFeverBarClass>d__102 <LoadFeverBarClass>d__;
			<LoadFeverBarClass>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadFeverBarClass>d__.<>1__state = -1;
			<LoadFeverBarClass>d__.<>t__builder.Start<PinballBattleSubController.<LoadFeverBarClass>d__102>(ref <LoadFeverBarClass>d__);
			return <LoadFeverBarClass>d__.<>t__builder.Task;
		}

		// Token: 0x06045871 RID: 284785 RVA: 0x01140F14 File Offset: 0x0113F114
		protected UniTask LoadFeverBarMaterial()
		{
			PinballBattleSubController.<LoadFeverBarMaterial>d__103 <LoadFeverBarMaterial>d__;
			<LoadFeverBarMaterial>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadFeverBarMaterial>d__.<>4__this = this;
			<LoadFeverBarMaterial>d__.<>1__state = -1;
			<LoadFeverBarMaterial>d__.<>t__builder.Start<PinballBattleSubController.<LoadFeverBarMaterial>d__103>(ref <LoadFeverBarMaterial>d__);
			return <LoadFeverBarMaterial>d__.<>t__builder.Task;
		}

		// Token: 0x06045872 RID: 284786 RVA: 0x01140F58 File Offset: 0x0113F158
		private UniTask LoadDirectionItem()
		{
			PinballBattleSubController.<LoadDirectionItem>d__104 <LoadDirectionItem>d__;
			<LoadDirectionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadDirectionItem>d__.<>4__this = this;
			<LoadDirectionItem>d__.<>1__state = -1;
			<LoadDirectionItem>d__.<>t__builder.Start<PinballBattleSubController.<LoadDirectionItem>d__104>(ref <LoadDirectionItem>d__);
			return <LoadDirectionItem>d__.<>t__builder.Task;
		}

		// Token: 0x06045873 RID: 284787 RVA: 0x01140F9C File Offset: 0x0113F19C
		public unsafe override void OnEntityRemoved(KscRemoveContext context, Dictionary<long, SimpleCombatEntityDieContext> protoContexts)
		{
			KscEntityHandle kscEntityHandle = this.GetModel().GetKscEntityHandle(context.CreatureDataId);
			if (((kscEntityHandle != null) ? kscEntityHandle.KscEntity : null) != null)
			{
				this.SetSpineCompTickEnabled(kscEntityHandle.KscEntity, false);
			}
			if (this.GetModel().GetEntity((int)context.CreatureDataId) == null)
			{
				return;
			}
			SimpleCombatEntityDieContext simpleCombatEntityDieContext = SimpleCombatEntityDieContext.Create();
			Aki.Protocol.Vector vector = Aki.Protocol.Vector.Create();
			vector.X = (float)context.Location.X;
			vector.Y = (float)context.Location.Y;
			vector.Z = (float)context.Location.Z;
			simpleCombatEntityDieContext.DiePos = vector;
			if (FNameUtil.GetDynamicFName(context.ReasonName.ToString()) == KscEntityRemoveReason.Dead)
			{
				this.TryTriggerDeathrattle((int)context.CreatureDataId);
				PinballEntityKilledCtxPb pinballEntityKilledCtxPb = PinballEntityKilledCtxPb.Create();
				pinballEntityKilledCtxPb.EntityId = context.KillerId;
				simpleCombatEntityDieContext.PinballEntityKilledCtx = pinballEntityKilledCtxPb;
				protoContexts[context.CreatureDataId] = simpleCombatEntityDieContext;
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PinballBattle;
			ELogAuthor author = ELogAuthor.LJ;
			string message = "移除星弹奇游实体失败: 未处理移除原因";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("creatureDataId", context.CreatureDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reasonName", context.ReasonName);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x06045874 RID: 284788 RVA: 0x01141114 File Offset: 0x0113F314
		public override void InitPropertyConfigs()
		{
			if (this.GetModel() == null)
			{
				return;
			}
			IReadOnlyList<PinballAttr> allAttrConfigs = PinballBattleConfig.Instance.GetAllAttrConfigs();
			if (allAttrConfigs != null)
			{
				foreach (PinballAttr value in allAttrConfigs)
				{
					this.GetModel().PinballPropertyConfigs[value.Id] = value;
				}
			}
			this.GetModel().InitMonsterAttrConfigs();
		}

		// Token: 0x06045875 RID: 284789 RVA: 0x01141190 File Offset: 0x0113F390
		public override Dictionary<EKSC_AttrType, float> GetAttrsDefault(int propertyId)
		{
			Dictionary<EKSC_AttrType, float> dictionary = new Dictionary<EKSC_AttrType, float>();
			PinballAttr attrConfig;
			if (this.GetModel().PinballPropertyConfigs.TryGetValue(propertyId, out attrConfig))
			{
				this.GetModel().GetCommonAttrs(dictionary, attrConfig);
				return dictionary;
			}
			Dictionary<EKSC_AttrType, float> result;
			if (this.GetModel().PinballMonsterAttrConfigs.TryGetValue(propertyId, out result))
			{
				return result;
			}
			return dictionary;
		}

		// Token: 0x06045876 RID: 284790 RVA: 0x011411DF File Offset: 0x0113F3DF
		public override void InitDamageConfigs()
		{
		}

		// Token: 0x06045877 RID: 284791 RVA: 0x011411E4 File Offset: 0x0113F3E4
		private void InitDamageConfigsNew()
		{
			UKSC_Shape2D_World shapeWorld = this.ShapeWorld;
			if (shapeWorld == null)
			{
				KscLog.Error(KscLog.EModule.Load, ELogAuthor.WWJ, KscEnv.Instance.KscWorld, "InitDamageConfigsNew failed, No World", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			IReadOnlyList<PinballDamage> allDamageConfigs = PinballBattleConfig.Instance.GetAllDamageConfigs();
			if (allDamageConfigs == null)
			{
				KscLog.Error(KscLog.EModule.Load, ELogAuthor.WWJ, KscEnv.Instance.KscWorld, "InitDamageConfigsNew failed, No Configs", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			UKSC_DamageId damageData = shapeWorld.DamageData;
			if (damageData == null || !damageData.IsValid())
			{
				KscLog.Error(KscLog.EModule.Load, ELogAuthor.WWJ, KscEnv.Instance.KscWorld, "InitDamageIdConfig failed, No DamageData", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			shapeWorld.SetDamageHandler(UKSC_DamageHandler_WF.StaticClass());
			Dictionary<int, FKSCDamage> damageIds = base.Model.DamageIds;
			foreach (PinballDamage pinballDamage in allDamageConfigs)
			{
				FKSCDamage fkscdamage = new FKSCDamage();
				fkscdamage.DamageID = (int)pinballDamage.Id;
				fkscdamage.CalculateType = (EKSC_CalculateType)pinballDamage.CalculateType;
				fkscdamage.Element = (EKSC_Element)pinballDamage.Element;
				fkscdamage.Amplify = (float)pinballDamage.Amplify * 0.0001f;
				fkscdamage.RelatedProperty = (EKSC_AttrType)pinballDamage.RelatedProperty;
				damageIds[(int)pinballDamage.Id] = fkscdamage;
				damageData.AddDamageData((int)pinballDamage.Id, fkscdamage);
				FKSC_Shape2D_DamageEffect fksc_Shape2D_DamageEffect = new FKSC_Shape2D_DamageEffect(pinballDamage.IsRecordedCombo == 1, (float)pinballDamage.RecoverSkillEnergy, (float)pinballDamage.RecoverSprintEnergy, (float)pinballDamage.RecoverFeverEnergy, pinballDamage.IsRecoverTeamSkillEnergy == 1);
				shapeWorld.AddDamageEffectData((int)pinballDamage.Id, fksc_Shape2D_DamageEffect);
			}
		}

		// Token: 0x06045878 RID: 284792 RVA: 0x01141398 File Offset: 0x0113F598
		protected override void InitEntityAndSkillDt()
		{
			KscUtil.LoadDt<FKSCEntityTableRow>(KscEnv.Instance.KscWorld, this.GetModel().GetEntityDtPath(), this.GetModel().EntityDataDt);
		}

		// Token: 0x06045879 RID: 284793 RVA: 0x011413C0 File Offset: 0x0113F5C0
		private void InitAttrBounds()
		{
			TMap<EKSC_AttrType, EKSC_AttrType> attributeIdsWithMax = KscEnv.Instance.KscWorld.AttributeIdsWithMax;
			attributeIdsWithMax.Add(EKSC_AttrType.Life, EKSC_AttrType.LifeMax);
			attributeIdsWithMax.Add(EKSC_AttrType.BaseLife, EKSC_AttrType.LifeMax);
			attributeIdsWithMax.Add(EKSC_AttrType.Shield, EKSC_AttrType.ShieldMax);
			attributeIdsWithMax.Add(EKSC_AttrType.SpecialEnergy1, EKSC_AttrType.SpecialEnergy1Max);
			attributeIdsWithMax.Add(EKSC_AttrType.SpecialEnergy2, EKSC_AttrType.SpecialEnergy2Max);
			attributeIdsWithMax.Add(EKSC_AttrType.SpecialEnergy3, EKSC_AttrType.SpecialEnergy3Max);
		}

		// Token: 0x0604587A RID: 284794 RVA: 0x01141413 File Offset: 0x0113F613
		protected override void CreateEntityFilter()
		{
			this.RedirectFilter = this.EntityRedirectFilter;
		}

		// Token: 0x0604587B RID: 284795 RVA: 0x01141421 File Offset: 0x0113F621
		[NullableContext(2)]
		protected override EntityHandle GetPossessedPlayerEntity()
		{
			return null;
		}

		// Token: 0x0604587C RID: 284796 RVA: 0x01141424 File Offset: 0x0113F624
		protected override void SyncPlayerTransform()
		{
		}

		// Token: 0x0604587D RID: 284797 RVA: 0x01141426 File Offset: 0x0113F626
		private void AddTreeListener()
		{
		}

		// Token: 0x0604587E RID: 284798 RVA: 0x01141428 File Offset: 0x0113F628
		private void RemoveTreeListener()
		{
		}

		// Token: 0x0604587F RID: 284799 RVA: 0x0114142A File Offset: 0x0113F62A
		public override void OnPlayerEntityCreated()
		{
		}

		// Token: 0x06045880 RID: 284800 RVA: 0x0114142C File Offset: 0x0113F62C
		private void OnPlayerEntityCreatedNew(AKSC_Shape2D_Entity_Player kscPlayer, PinballFormationRolePb roleData)
		{
			this.UpdateTranslucentSortPriority(kscPlayer, roleData.RoleId, null);
			USpineSkeletonAnimationComponent uspineSkeletonAnimationComponent = kscPlayer.GetComponentByClass(USpineSkeletonAnimationComponent.StaticClass()) as USpineSkeletonAnimationComponent;
			if (uspineSkeletonAnimationComponent != null && uspineSkeletonAnimationComponent.IsValid())
			{
				uspineSkeletonAnimationComponent.SetTickableWhenPaused(false);
			}
			TArray<UActorComponent> tarray = kscPlayer.K2_GetComponentsByClass(USpineSkeletonRendererComponent.StaticClass());
			for (int i = 0; i < tarray.Num(); i++)
			{
				USpineSkeletonRendererComponent uspineSkeletonRendererComponent = tarray.Get(i) as USpineSkeletonRendererComponent;
				if (uspineSkeletonRendererComponent != null && uspineSkeletonRendererComponent.IsValid())
				{
					uspineSkeletonRendererComponent.SetTickableWhenPaused(false);
				}
			}
		}

		// Token: 0x06045881 RID: 284801 RVA: 0x011414BC File Offset: 0x0113F6BC
		private void OnTeamPlayerEntityCreated(AKSC_Shape2D_Entity_TeamPlayer kscTeamPlayer)
		{
			Dictionary<EKSC_AttrType, float> dictionary = new Dictionary<EKSC_AttrType, float>();
			this.GetModel().GetTeamAttrs(1001, dictionary);
			foreach (KeyValuePair<EKSC_AttrType, float> keyValuePair in dictionary)
			{
				kscTeamPlayer.SetAttr(keyValuePair.Key, (int)keyValuePair.Value);
			}
			PinballBattleFeverBarController feverBarController = this.FeverBarController;
			if (feverBarController == null)
			{
				return;
			}
			feverBarController.BindAttr(kscTeamPlayer);
		}

		// Token: 0x06045882 RID: 284802 RVA: 0x01141540 File Offset: 0x0113F740
		protected void InitKscPlayerEntities()
		{
			if (!this.IsShapeWorldReady)
			{
				return;
			}
			if (!this.IsFormationTestMode && !this.IsFormationDataReady)
			{
				return;
			}
			if (this.IsInitKscPlayerEntities)
			{
				return;
			}
			this.IsInitKscPlayerEntities = true;
			int formationLength = 3;
			List<PinballFormationRolePb> list = null;
			if (this.IsFormationDataReady)
			{
				PinballBattleSubModel model = this.GetModel();
				list = ((model != null) ? model.FormationData : null);
				if (list == null || list.Count == 0)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.PinballBattle;
					ELogAuthor author = ELogAuthor.WWJ;
					string message = "角色编队加载失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("FormationData", list);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				formationLength = list.Count;
			}
			KuroSimpleCombatController.Instance.AddEntityDt((long)this.GetCreatureSpawnId(), 10001, null, this.WorldOriginTransform.ToUeTransform(), delegate(AKSC_Entity kscEntity)
			{
				AKSC_Shape2D_Entity_TeamPlayer aksc_Shape2D_Entity_TeamPlayer = kscEntity as AKSC_Shape2D_Entity_TeamPlayer;
				if (aksc_Shape2D_Entity_TeamPlayer != null)
				{
					this.OnTeamPlayerEntityCreated(aksc_Shape2D_Entity_TeamPlayer);
					this.KscTeamPlayer = aksc_Shape2D_Entity_TeamPlayer;
					EventSystem.Instance.Emit<int>(EEventName.OnPinballEntityCreated, 10001);
				}
			});
			this.KscPlayerEntityIds = new int[formationLength];
			this.KscPlayerEntities = new AKSC_Shape2D_Entity_Player[formationLength];
			this.KscPlayerInitCount = 0;
			for (int i = 0; i < formationLength; i++)
			{
				int? num = null;
				PinballFormationRolePb pinballFormationRolePb = null;
				if (this.IsFormationDataReady)
				{
					pinballFormationRolePb = list[i];
					PinballRoleConfig? roleConfig = PinballBattleConfig.Instance.GetRoleConfig(pinballFormationRolePb.RoleId);
					num = ((roleConfig != null) ? new int?(roleConfig.GetValueOrDefault().KscEntityId) : null);
				}
				else
				{
					num = new int?(PinballBattleSubController.PlayerEntityKeys[i]);
				}
				if (num != null)
				{
					int creatureSpawnId = this.GetCreatureSpawnId();
					if (pinballFormationRolePb != null)
					{
						this.GetModel().SetRoleId2CreatureId(pinballFormationRolePb.RoleId, creatureSpawnId);
					}
					int positionIndex = i;
					PinballFormationRolePb capturedRoleData = pinballFormationRolePb;
					KuroSimpleCombatController.Instance.AddEntityDt((long)creatureSpawnId, num.Value, null, this.BornTransform.ToUeTransform(), delegate(AKSC_Entity kscEntity)
					{
						AKSC_Shape2D_Entity_Player aksc_Shape2D_Entity_Player = kscEntity as AKSC_Shape2D_Entity_Player;
						if (aksc_Shape2D_Entity_Player == null)
						{
							return;
						}
						PinballFormationRolePb capturedRoleData;
						if (capturedRoleData != null)
						{
							this.OnPlayerEntityCreatedNew(aksc_Shape2D_Entity_Player, capturedRoleData);
						}
						this.KscPlayerEntities[positionIndex] = aksc_Shape2D_Entity_Player;
						this.KscPlayerEntityIds[positionIndex] = aksc_Shape2D_Entity_Player.EntityId_;
						this.KscPlayerInitCount++;
						this.SetPlayerEntityActive(aksc_Shape2D_Entity_Player, false, true);
						IReadOnlyDictionary<int, PinballRoleTotalInfo> roleTotalMap = this.GetModel().RoleTotalMap;
						capturedRoleData = capturedRoleData;
						PinballRoleTotalInfo valueOrDefault = roleTotalMap.GetValueOrDefault((capturedRoleData != null) ? capturedRoleData.RoleId : 0);
						PinballBattleSubController <>4__this = this;
						AKSC_Shape2D_Entity_Player playerEntity = aksc_Shape2D_Entity_Player;
						IPinballRoleTotalInfo roleTotalData = valueOrDefault;
						PinballFormationRolePb capturedRoleData2 = capturedRoleData;
						<>4__this.BindPlayerEntityTotalDelegate(playerEntity, roleTotalData, (capturedRoleData2 != null) ? capturedRoleData2.RoleId : 0);
						if (this.KscPlayerInitCount == formationLength)
						{
							TArray<int> tarray = new TArray<int>();
							tarray.AddUninitialized(this.KscPlayerEntityIds.Length);
							this.KscPlayerEntityIds.CopyTo(tarray.AsSpan<int>());
							UKSC_Shape2D_World shapeWorld = this.ShapeWorld;
							if (shapeWorld != null)
							{
								shapeWorld.InitTeamPlayerEntityIds(tarray);
							}
							EventSystem.Instance.Emit(EEventName.OnKscPlayerCreate);
							this.WorldUpdateOnceDelegateRef = DelegateUtils.ToManualReleaseDelegate<FOnWorldUpdateOnce>(new Action(this.OnWorldUpdateOnce));
							UKSC_Shape2D_World shapeWorld2 = this.ShapeWorld;
							if (shapeWorld2 == null)
							{
								return;
							}
							shapeWorld2.AssignWorldUpdateOnce(this.WorldUpdateOnceDelegateRef);
						}
					});
				}
			}
		}

		// Token: 0x06045883 RID: 284803 RVA: 0x0114174F File Offset: 0x0113F94F
		protected override void AddKscPlayerEntity()
		{
			if (this.IsFormationTestMode)
			{
				this.InitKscPlayerEntities();
			}
		}

		// Token: 0x06045884 RID: 284804 RVA: 0x01141760 File Offset: 0x0113F960
		private void TempInitKscEntities()
		{
			GameModeModel instance = GameModeModel.Instance;
			int mapId = (instance != null) ? instance.MapConfig.MapId : 0;
			PinballBattleConfig instance2 = PinballBattleConfig.Instance;
			IReadOnlyList<PinballEntityTest> readOnlyList = (instance2 != null) ? instance2.GetWorldEntities(mapId) : null;
			if (readOnlyList == null)
			{
				return;
			}
			global::Vector vector = global::Vector.Create();
			global::Rotator rotator = global::Rotator.Create();
			foreach (PinballEntityTest pinballEntityTest in readOnlyList)
			{
				global::Transform transform = global::Transform.Create();
				Aki.Config.Vector value = pinballEntityTest.Location.Value;
				Aki.Config.Vector value2 = pinballEntityTest.Rotation.Value;
				vector.X = (double)value.X + this.WorldOrigin.X;
				vector.Y = (double)value.Y + this.WorldOrigin.Y;
				vector.Z = (double)this.GroundPositionZ;
				transform.SetLocation(vector);
				rotator.Pitch = value2.X;
				rotator.Yaw = value2.Y;
				rotator.Roll = value2.Z;
				transform.SetRotation(rotator.Quaternion(null));
				KuroSimpleCombatController.Instance.AddEntityDt((long)this.GetCreatureSpawnId(), pinballEntityTest.KscEntityId, null, transform.ToUeTransform(), new Action<AKSC_Entity>(this.OnAddKscEntity));
			}
		}

		// Token: 0x06045885 RID: 284805 RVA: 0x011418CC File Offset: 0x0113FACC
		private void OnAddKscEntity(AKSC_Entity kscEntity)
		{
			AKSC_Shape2D_Entity_Bar aksc_Shape2D_Entity_Bar = kscEntity as AKSC_Shape2D_Entity_Bar;
			if (aksc_Shape2D_Entity_Bar != null)
			{
				this.OnAddKscBar(aksc_Shape2D_Entity_Bar);
			}
		}

		// Token: 0x06045886 RID: 284806 RVA: 0x011418EC File Offset: 0x0113FAEC
		private void SetShapeWorldReady()
		{
			this.IsShapeWorldReady = true;
			if (PinballBattleSubController.EnableSpineParallelUpdate)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "spine.Renderer.EnableParallelUpdate 1", null);
			}
			else
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "spine.Renderer.EnableParallelUpdate 0", null);
			}
			if (PinballBattleSubController.EnableSpineShadow)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "ksc.Shape.SpineShadowEnable 1", null);
			}
			else
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "ksc.Shape.SpineShadowEnable 0", null);
			}
			this.InitFeverBar();
			this.InitLaunchDirectionController();
			this.InitKscPlayerEntities();
		}

		// Token: 0x06045887 RID: 284807 RVA: 0x01141964 File Offset: 0x0113FB64
		private void SetFormationDataReady()
		{
			this.IsFormationDataReady = true;
			this.InitKscPlayerEntities();
		}

		// Token: 0x06045888 RID: 284808 RVA: 0x01141974 File Offset: 0x0113FB74
		[return: Nullable(2)]
		public global::Transform GetEntityTransform(global::Vector location, global::Rotator rotation)
		{
			location.X += this.WorldOrigin.X;
			location.Y += this.WorldOrigin.Y;
			location.Z = (double)this.GroundPositionZ;
			global::Transform transform = global::Transform.Create();
			transform.SetLocation(location);
			transform.SetRotation(rotation.Quaternion(null));
			return transform;
		}

		// Token: 0x06045889 RID: 284809 RVA: 0x011419D7 File Offset: 0x0113FBD7
		[NullableContext(2)]
		public global::Transform GetPlayerEntityTransform()
		{
			return this.BornTransform;
		}

		// Token: 0x0604588A RID: 284810 RVA: 0x011419E0 File Offset: 0x0113FBE0
		public void OnAddKscBar(AKSC_Shape2D_Entity_Bar kscBarEntity)
		{
			PinballBattlePlayerBarController pinballBattlePlayerBarController = new PinballBattlePlayerBarController();
			pinballBattlePlayerBarController.Init(kscBarEntity, this.GetModel());
			if (kscBarEntity.Side == EKSC_ShapeBarSide.Left)
			{
				this.KscEntityLeftBar = kscBarEntity;
				this.LeftBarController = pinballBattlePlayerBarController;
				return;
			}
			this.KscEntityRightBar = kscBarEntity;
			this.RightBarController = pinballBattlePlayerBarController;
		}

		// Token: 0x0604588B RID: 284811 RVA: 0x01141A28 File Offset: 0x0113FC28
		private void TempInitCamera(float? overrideFov = null)
		{
			PinballWorldConfig? worldConfigCache = this.GetModel().WorldConfigCache;
			if (worldConfigCache == null)
			{
				return;
			}
			PinballWorldConfig value = worldConfigCache.Value;
			Aki.Config.Vector value2 = value.CameraLocation.Value;
			Aki.Config.Vector value3 = value.CameraRotation.Value;
			global::Vector vector = global::Vector.Create();
			vector.X = this.WorldOrigin.X + (double)value2.X;
			vector.Y = this.WorldOrigin.Y + (double)value2.Y;
			vector.Z = this.WorldOrigin.Z + (double)value2.Z;
			global::Rotator rotation = global::Rotator.Create(value3.X, value3.Y, value3.Z);
			float num = overrideFov ?? ((float)value.CameraFov);
			this.BaseFov = num;
			this.EnterFixCamera(vector, rotation, num);
		}

		// Token: 0x0604588C RID: 284812 RVA: 0x01141B1C File Offset: 0x0113FD1C
		protected override void OnInit()
		{
			base.OnInit();
			Net.Instance.Register(ENotifyMessageId.PinballStartNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPinballStartNotify));
			Net.Instance.Register(ENotifyMessageId.PinballInGameStateChangeNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPinballGameStateChangeNotify));
			Net.Instance.Register(ENotifyMessageId.PinballSettleNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPinballSettleNotify));
			Net.Instance.Register(ENotifyMessageId.PinballInGameStarChangeNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPinballInGameStarChangeNotify));
			Net.Instance.Register(ENotifyMessageId.PinballUpdateWaveNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPinballUpdateWaveNotify));
			Net.Instance.Register(ENotifyMessageId.PinballSpawnFirstFinishNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPinballSpawnFinishNotify));
			this.GetModel().FirstWaveMonsterTracker.OnAllSpawned = delegate()
			{
				this.FirstStartLaunch();
			};
			this.GetModel().CurWaveMachineTracker.OnAllSpawned = delegate()
			{
				this.OnAllCurWaveMachineSpawned();
			};
		}

		// Token: 0x0604588D RID: 284813 RVA: 0x01141C10 File Offset: 0x0113FE10
		protected override void OnClear()
		{
			base.OnClear();
			Net.Instance.UnRegister(ENotifyMessageId.PinballStartNotify);
			Net.Instance.UnRegister(ENotifyMessageId.PinballInGameStateChangeNotify);
			Net.Instance.UnRegister(ENotifyMessageId.PinballSettleNotify);
			Net.Instance.UnRegister(ENotifyMessageId.PinballInGameStarChangeNotify);
			Net.Instance.UnRegister(ENotifyMessageId.PinballUpdateWaveNotify);
			Net.Instance.UnRegister(ENotifyMessageId.PinballSpawnFirstFinishNotify);
			this.GetModel().FirstWaveMonsterTracker.OnAllSpawned = null;
			this.GetModel().CurWaveMachineTracker.OnAllSpawned = null;
		}

		// Token: 0x0604588E RID: 284814 RVA: 0x01141CA5 File Offset: 0x0113FEA5
		[NullableContext(2)]
		private void OnPinballSpawnFinishNotify(IMessage msg, Net.CallbackStatus status)
		{
			if (((PinballSpawnFirstFinishNotify)msg).WaveId != 1)
			{
				return;
			}
			this.GetModel().FirstWaveMonsterTracker.MarkServerDone();
		}

		// Token: 0x0604588F RID: 284815 RVA: 0x01141CC8 File Offset: 0x0113FEC8
		[NullableContext(2)]
		private void OnPinballStartNotify(IMessage msg, Net.CallbackStatus status)
		{
			PinballStartNotify pinballStartNotify = (PinballStartNotify)msg;
			if (pinballStartNotify.InProgressPb != null)
			{
				this.GetModel().PreloadFormationData = new List<PinballFormationRolePb>(pinballStartNotify.InProgressPb.PinballFormation);
				PinballModel.Instance.CurLevelConfigId = pinballStartNotify.InProgressPb.LevelId;
			}
			if (pinballStartNotify.RealLevelId != 0)
			{
				PinballModel.Instance.CurLevelId = pinballStartNotify.RealLevelId;
			}
		}

		// Token: 0x06045890 RID: 284816 RVA: 0x01141D2C File Offset: 0x0113FF2C
		[NullableContext(2)]
		private void OnPinballUpdateWaveNotify(IMessage msg, Net.CallbackStatus status)
		{
			int waveId = ((PinballUpdateWaveNotify)msg).WaveId;
			this.GetModel().CurWave = waveId;
			this.GetModel().CurWaveMachineTracker.MarkServerDone();
		}

		// Token: 0x06045891 RID: 284817 RVA: 0x01141D64 File Offset: 0x0113FF64
		[NullableContext(2)]
		private void OnPinballInGameStarChangeNotify(IMessage msg, Net.CallbackStatus status)
		{
			RepeatedField<int> starInfo = ((PinballInGameStarChangeNotify)msg).StarInfo;
			PinballBattleSubModel model = this.GetModel();
			for (int i = 0; i < starInfo.Count; i++)
			{
				model.StarInfo[i] = starInfo[i];
			}
		}

		// Token: 0x06045892 RID: 284818 RVA: 0x01141DA4 File Offset: 0x0113FFA4
		[NullableContext(2)]
		private void OnPinballGameStateChangeNotify(IMessage msg, Net.CallbackStatus status)
		{
			PinballInGameStateChangeNotify pinballInGameStateChangeNotify = (PinballInGameStateChangeNotify)msg;
			PinballInGameStatePb inGameState = pinballInGameStateChangeNotify.InGameState;
			PinballBattleSubModel model = this.GetModel();
			model.GameState = (int)inGameState;
			if (inGameState == PinballInGameStatePb.InProgress)
			{
				PinballInProgressPb inProgressPb = pinballInGameStateChangeNotify.InProgressPb;
				model.LevelId = inProgressPb.LevelId;
				model.UsedReviveTime = inProgressPb.ReviveTimesCost;
				model.MaxReviveTime = inProgressPb.MaxReviveTimes;
				model.SetFormationData(new List<PinballFormationRolePb>(inProgressPb.PinballFormation));
				model.MonsterAttrRate[EKSC_AttrType.Atk] = (float)inProgressPb.MonsterAttrRate[0] * 0.0001f;
				model.MonsterAttrRate[EKSC_AttrType.Def] = (float)inProgressPb.MonsterAttrRate[1] * 0.0001f;
				model.MonsterAttrRate[EKSC_AttrType.Life] = (float)inProgressPb.MonsterAttrRate[2] * 0.0001f;
				model.TeamBuffList = new List<int>(inProgressPb.AllyKscBuffIds);
				this.SetFormationDataReady();
			}
			else if (inGameState == PinballInGameStatePb.SettlePreSubmit)
			{
				PinballSettlePreSubmitPb settlePreSubmitPb = pinballInGameStateChangeNotify.SettlePreSubmitPb;
				model.UsedReviveTime = settlePreSubmitPb.ReviveTimesCost;
				model.MaxReviveTime = settlePreSubmitPb.MaxReviveTimes;
			}
			if (inGameState == PinballInGameStatePb.InProgress)
			{
				this.StartScheduledSyncData();
			}
			else
			{
				this.StopAllTimerTask();
			}
			this.HandleGameStateChangeReason(pinballInGameStateChangeNotify.ChangeReason);
		}

		// Token: 0x06045893 RID: 284819 RVA: 0x01141ECC File Offset: 0x011400CC
		private void HandleGameStateChangeReason(PinballStateChangeReasonPb reason)
		{
			PinballController instance = PinballController.Instance;
			switch (reason)
			{
			case PinballStateChangeReasonPb.SettlePreSubmitAllTeamDeadNoRevive:
				this.RequestSettle();
				return;
			case PinballStateChangeReasonPb.SettlePreSubmitAllTeamDeadHaveRevive:
			{
				PinballBattleRevivePopupViewParam param = new PinballBattleRevivePopupViewParam
				{
					ConfirmCallback = delegate
					{
						this.RequestTeamRevive();
					},
					CancelCallback = delegate
					{
						this.RequestSettle();
					}
				};
				UiManager.Instance.OpenView(EUiViewName.PinballRevivePopupView, param, null);
				return;
			}
			case PinballStateChangeReasonPb.SettlePreSubmitTimeZero:
				this.RequestSettle();
				return;
			case PinballStateChangeReasonPb.SettlePreSubmitWaveClear:
				this.RequestSettle();
				return;
			default:
				if (reason != PinballStateChangeReasonPb.InProgressFirstStart)
				{
					if (reason != PinballStateChangeReasonPb.InProgressAllTeamRevive)
					{
						return;
					}
					UKSC_Shape2D_World shapeWorld = this.ShapeWorld;
					if (shapeWorld != null)
					{
						shapeWorld.ReviveTeam();
					}
					this.NeedSendLaunchRequest = true;
				}
				else if (instance != null)
				{
					instance.ShowLevelStartTips(this.GetModel().CurWave, this.GetModel().GetMaxWave(), null);
					return;
				}
				return;
			}
		}

		// Token: 0x06045894 RID: 284820 RVA: 0x01141F8A File Offset: 0x0114018A
		public void FirstStartLaunch()
		{
			this.ReadyLaunch();
			this.NeedSendLaunchRequest = true;
			this.IsFirstLaunch = true;
			this.StartAutoLaunchTimer();
		}

		// Token: 0x06045895 RID: 284821 RVA: 0x01141FA8 File Offset: 0x011401A8
		[NullableContext(2)]
		private void OnPinballSettleNotify(IMessage msg, Net.CallbackStatus status)
		{
			PinballSettleNotify notify = (PinballSettleNotify)msg;
			this.OnPinballSettleAsync(notify).Forget();
		}

		// Token: 0x06045896 RID: 284822 RVA: 0x01141FC8 File Offset: 0x011401C8
		private UniTask OnPinballSettleAsync(PinballSettleNotify notify)
		{
			PinballBattleSubController.<OnPinballSettleAsync>d__140 <OnPinballSettleAsync>d__;
			<OnPinballSettleAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPinballSettleAsync>d__.<>4__this = this;
			<OnPinballSettleAsync>d__.notify = notify;
			<OnPinballSettleAsync>d__.<>1__state = -1;
			<OnPinballSettleAsync>d__.<>t__builder.Start<PinballBattleSubController.<OnPinballSettleAsync>d__140>(ref <OnPinballSettleAsync>d__);
			return <OnPinballSettleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06045897 RID: 284823 RVA: 0x01142013 File Offset: 0x01140213
		private void OnCloseView(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.PinballBattlePauseView)
			{
				return;
			}
			CustomPromise canOpenSettleResultPromise = this.CanOpenSettleResultPromise;
			if (canOpenSettleResultPromise == null)
			{
				return;
			}
			canOpenSettleResultPromise.SetResult();
		}

		// Token: 0x06045898 RID: 284824 RVA: 0x01142034 File Offset: 0x01140234
		private UniTask OpenSettleViewAsync(bool isWin, Action openSettleView)
		{
			PinballBattleSubController.<OpenSettleViewAsync>d__142 <OpenSettleViewAsync>d__;
			<OpenSettleViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenSettleViewAsync>d__.<>4__this = this;
			<OpenSettleViewAsync>d__.isWin = isWin;
			<OpenSettleViewAsync>d__.openSettleView = openSettleView;
			<OpenSettleViewAsync>d__.<>1__state = -1;
			<OpenSettleViewAsync>d__.<>t__builder.Start<PinballBattleSubController.<OpenSettleViewAsync>d__142>(ref <OpenSettleViewAsync>d__);
			return <OpenSettleViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06045899 RID: 284825 RVA: 0x01142088 File Offset: 0x01140288
		public unsafe void RequestGameDataSync()
		{
			if (Time.Instance.Now - this.LastSyncRealTimeMs < 5000.0)
			{
				return;
			}
			this.LastSyncRealTimeMs = Time.Instance.Now;
			PinballInGameSyncPayloadRequest pinballInGameSyncPayloadRequest = PinballInGameSyncPayloadRequest.Create();
			pinballInGameSyncPayloadRequest.Payload = this.GetModel().GetPayloadData();
			Net.Instance.Call(ERequestMessageId.PinballInGameSyncPayloadRequest, pinballInGameSyncPayloadRequest, delegate(IMessage msg, Net.CallbackStatus status)
			{
				PinballInGameSyncPayloadResponse pinballInGameSyncPayloadResponse = (PinballInGameSyncPayloadResponse)msg;
				if (pinballInGameSyncPayloadResponse == null)
				{
					return;
				}
				if (pinballInGameSyncPayloadResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.PinballBattle;
					ELogAuthor author = ELogAuthor.LJ;
					string message = "战斗数据定时同步返回错误";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("errorCode", pinballInGameSyncPayloadResponse.ErrorCode);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("messageId", 19461);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}, 0);
		}

		// Token: 0x0604589A RID: 284826 RVA: 0x01142109 File Offset: 0x01140309
		private void StartScheduledSyncData()
		{
			if (this.PayloadSyncTimerHandle != null)
			{
				return;
			}
			this.PayloadSyncTimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				this.RequestGameDataSync();
			}, 10000f, 1f, null, null, true);
		}

		// Token: 0x0604589B RID: 284827 RVA: 0x0114213D File Offset: 0x0114033D
		private void StopScheduledSyncData()
		{
			if (this.PayloadSyncTimerHandle == null)
			{
				return;
			}
			TimerSystem.GameplayTimeInstance.Remove(this.PayloadSyncTimerHandle);
			this.PayloadSyncTimerHandle = null;
		}

		// Token: 0x0604589C RID: 284828 RVA: 0x01142160 File Offset: 0x01140360
		private void StopAllTimerTask()
		{
			this.StopScheduledSyncData();
			this.StopAutoLaunchTimer();
		}

		// Token: 0x0604589D RID: 284829 RVA: 0x01142170 File Offset: 0x01140370
		public void RequestTeamAllDie()
		{
			PinballTeamDieRequest message = PinballTeamDieRequest.Create();
			Net.Instance.Call(ERequestMessageId.PinballTeamDieRequest, message, delegate(IMessage msg, Net.CallbackStatus status)
			{
				PinballTeamDieResponse pinballTeamDieResponse = (PinballTeamDieResponse)msg;
				if (pinballTeamDieResponse == null)
				{
					return;
				}
				if (pinballTeamDieResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(pinballTeamDieResponse.ErrorCode, 24554, null, true, true);
				}
			}, 0);
		}

		// Token: 0x0604589E RID: 284830 RVA: 0x011421B4 File Offset: 0x011403B4
		public void RequestTeamRevive()
		{
			PinballTeamReviveRequest message = PinballTeamReviveRequest.Create();
			Net.Instance.Call(ERequestMessageId.PinballTeamReviveRequest, message, delegate(IMessage msg, Net.CallbackStatus status)
			{
				PinballTeamReviveResponse pinballTeamReviveResponse = (PinballTeamReviveResponse)msg;
				if (pinballTeamReviveResponse == null)
				{
					return;
				}
				if (pinballTeamReviveResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(pinballTeamReviveResponse.ErrorCode, 17085, null, true, true);
				}
			}, 0);
		}

		// Token: 0x0604589F RID: 284831 RVA: 0x011421F8 File Offset: 0x011403F8
		public void RequestQuit()
		{
			this.StopAllTimerTask();
			PinballQuitRequest pinballQuitRequest = PinballQuitRequest.Create();
			pinballQuitRequest.Payload = this.GetModel().GetPayloadData();
			pinballQuitRequest.NeedNotify = true;
			Net.Instance.Call(ERequestMessageId.PinballQuitRequest, pinballQuitRequest, delegate(IMessage msg, Net.CallbackStatus status)
			{
				PinballQuitResponse pinballQuitResponse = (PinballQuitResponse)msg;
				if (pinballQuitResponse == null)
				{
					return;
				}
				if (pinballQuitResponse.ErrCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(pinballQuitResponse.ErrCode, 17521, null, true, true);
				}
			}, 0);
		}

		// Token: 0x060458A0 RID: 284832 RVA: 0x0114225C File Offset: 0x0114045C
		[NullableContext(2)]
		public UniTask Restart(List<int> roleIdList = null)
		{
			PinballBattleSubController.<Restart>d__150 <Restart>d__;
			<Restart>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Restart>d__.<>4__this = this;
			<Restart>d__.roleIdList = roleIdList;
			<Restart>d__.<>1__state = -1;
			<Restart>d__.<>t__builder.Start<PinballBattleSubController.<Restart>d__150>(ref <Restart>d__);
			return <Restart>d__.<>t__builder.Task;
		}

		// Token: 0x060458A1 RID: 284833 RVA: 0x011422A8 File Offset: 0x011404A8
		public void RequestBonusFullWin()
		{
			this.StopAllTimerTask();
			PinballBonusFullWinRequest pinballBonusFullWinRequest = PinballBonusFullWinRequest.Create();
			pinballBonusFullWinRequest.Payload = this.GetModel().GetPayloadData();
			Net.Instance.Call(ERequestMessageId.PinballBonusFullWinRequest, pinballBonusFullWinRequest, delegate(IMessage msg, Net.CallbackStatus status)
			{
				PinballBonusFullWinResponse pinballBonusFullWinResponse = (PinballBonusFullWinResponse)msg;
				if (pinballBonusFullWinResponse == null)
				{
					return;
				}
				if (pinballBonusFullWinResponse.ErrCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(pinballBonusFullWinResponse.ErrCode, 22647, null, true, true);
				}
			}, 0);
		}

		// Token: 0x060458A2 RID: 284834 RVA: 0x01142304 File Offset: 0x01140504
		public void RequestSettle()
		{
			this.StopAllTimerTask();
			PinballSetPayloadRequest pinballSetPayloadRequest = PinballSetPayloadRequest.Create();
			pinballSetPayloadRequest.Payload = this.GetModel().GetPayloadData();
			Net.Instance.Call(ERequestMessageId.PinballSetPayloadRequest, pinballSetPayloadRequest, delegate(IMessage msg, Net.CallbackStatus status)
			{
				PinballSetPayloadResponse pinballSetPayloadResponse = (PinballSetPayloadResponse)msg;
				if (pinballSetPayloadResponse == null)
				{
					return;
				}
				if (pinballSetPayloadResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(pinballSetPayloadResponse.ErrorCode, 24616, null, true, true);
				}
			}, 0);
		}

		// Token: 0x060458A3 RID: 284835 RVA: 0x0114235E File Offset: 0x0114055E
		private void OnBlackFadeScreenFinish()
		{
			CustomPromise canRequestSettlePromise = this.CanRequestSettlePromise;
			if (canRequestSettlePromise == null)
			{
				return;
			}
			canRequestSettlePromise.SetResult();
		}

		// Token: 0x060458A4 RID: 284836 RVA: 0x01142370 File Offset: 0x01140570
		private void RequestLaunch()
		{
			PinballInGameKickBallRequest message = PinballInGameKickBallRequest.Create();
			Net.Instance.Call(ERequestMessageId.PinballInGameKickBallRequest, message, delegate(IMessage msg, Net.CallbackStatus status)
			{
				PinballInGameKickBallResponse pinballInGameKickBallResponse = (PinballInGameKickBallResponse)msg;
				if (pinballInGameKickBallResponse == null)
				{
					return;
				}
				if (pinballInGameKickBallResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(pinballInGameKickBallResponse.ErrorCode, 26970, null, true, true);
				}
			}, 0);
		}

		// Token: 0x060458A5 RID: 284837 RVA: 0x011423B3 File Offset: 0x011405B3
		private void OnScoreChanged(int score)
		{
			if (this.AlreadyRequestBonusWin)
			{
				return;
			}
			if (this.GetModel().CheckBonusFullWin())
			{
				this.AlreadyRequestBonusWin = true;
				this.RequestBonusFullWin();
			}
		}

		// Token: 0x060458A6 RID: 284838 RVA: 0x011423D8 File Offset: 0x011405D8
		public static void RequestEnterInst(int levelId, List<int> roleIdList)
		{
			PinballCtx pinballCtx = PinballCtx.Create();
			PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(levelId);
			if (pinballLevelConfigById == null)
			{
				KscLog.EModule flag = KscLog.EModule.Common;
				ELogAuthor author = ELogAuthor.LJ;
				UObject kscWorld = KscEnv.Instance.KscWorld;
				string log = "[星弹奇游]副本进入请求异常：关卡配置为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("levelId", levelId);
				KscLog.Error(flag, author, kscWorld, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			foreach (int num in roleIdList)
			{
				if (PinballConfig.Instance.GetPinballRoleConfigById(num) == null)
				{
					KscLog.EModule flag2 = KscLog.EModule.Common;
					ELogAuthor author2 = ELogAuthor.LJ;
					UObject kscWorld2 = KscEnv.Instance.KscWorld;
					string log2 = "[星弹奇游]副本进入请求异常：角色配置为空";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("roleId", num);
					KscLog.Error(flag2, author2, kscWorld2, log2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return;
				}
			}
			pinballCtx.LevelId = levelId;
			foreach (int item in roleIdList)
			{
				pinballCtx.FormationRoles.Add(item);
			}
			InstanceDungeonModel.Instance.InstanceEnterContentText.PinballCtx = pinballCtx;
			int instId = pinballLevelConfigById.Value.InstId;
			if (pinballLevelConfigById.Value.Type == 4)
			{
				int dailyRandomLevelId = PinballModel.Instance.ActivityData.GetDailyRandomLevelId();
				if (dailyRandomLevelId > 0)
				{
					instId = PinballConfig.Instance.GetPinballLevelConfigById(dailyRandomLevelId).Value.InstId;
				}
			}
			InstanceDungeonController.Instance.PrewarTeamFightRequest(instId, new List<int>(), 0, 0, null, null).Forget<bool>();
		}

		// Token: 0x060458A7 RID: 284839 RVA: 0x01142588 File Offset: 0x01140788
		protected override void OnHandleHeadHpInfo(FKSC_HeadHpContext headInfo)
		{
			bool flag = headInfo.HeadUiType == EKSC_HeadUiType.TopBoss;
			bool flag2 = headInfo.HeadUiType == EKSC_HeadUiType.Marble;
			if (!flag && !flag2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PinballBattle;
				ELogAuthor author = ELogAuthor.LJ;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 1);
				defaultInterpolatedStringHandler.AppendLiteral("未处理的KSC头部UI数据！EKSC_HeadUiType = ");
				defaultInterpolatedStringHandler.AppendFormatted<EKSC_HeadUiType>(headInfo.HeadUiType);
				instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (flag)
			{
				EventSystem.Instance.Emit<FKSC_HeadHpContext>(EEventName.OnPinballEntityHpChanged, headInfo);
			}
			if (flag2)
			{
				PinballBattleHeadStateManager pinballBattleHeadStateManager = this.GetModel().PinballBattleHeadStateManager;
				if (pinballBattleHeadStateManager == null)
				{
					return;
				}
				pinballBattleHeadStateManager.UpdateHeadState(headInfo);
			}
		}

		// Token: 0x060458A8 RID: 284840 RVA: 0x01142621 File Offset: 0x01140821
		protected override void OnHandlePlayerHeadHpInfo(KscHeadStateData kscPlayerHeadStateData, FKSC_HeadHpContext headInfo)
		{
			base.OnHandlePlayerHeadHpInfo(kscPlayerHeadStateData, headInfo);
			this.PlayerHpHandle.OnPlayerHpChange(kscPlayerHeadStateData);
			this.OnHandleHeadHpInfo(headInfo);
		}

		// Token: 0x060458A9 RID: 284841 RVA: 0x01142640 File Offset: 0x01140840
		protected override UniTask LoadHeadStateCurve()
		{
			PinballBattleSubController.<LoadHeadStateCurve>d__159 <LoadHeadStateCurve>d__;
			<LoadHeadStateCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadHeadStateCurve>d__.<>4__this = this;
			<LoadHeadStateCurve>d__.<>1__state = -1;
			<LoadHeadStateCurve>d__.<>t__builder.Start<PinballBattleSubController.<LoadHeadStateCurve>d__159>(ref <LoadHeadStateCurve>d__);
			return <LoadHeadStateCurve>d__.<>t__builder.Task;
		}

		// Token: 0x060458AA RID: 284842 RVA: 0x01142684 File Offset: 0x01140884
		protected override UniTask LoadHeadStateDynamicBatchActor()
		{
			PinballBattleSubController.<LoadHeadStateDynamicBatchActor>d__160 <LoadHeadStateDynamicBatchActor>d__;
			<LoadHeadStateDynamicBatchActor>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadHeadStateDynamicBatchActor>d__.<>4__this = this;
			<LoadHeadStateDynamicBatchActor>d__.<>1__state = -1;
			<LoadHeadStateDynamicBatchActor>d__.<>t__builder.Start<PinballBattleSubController.<LoadHeadStateDynamicBatchActor>d__160>(ref <LoadHeadStateDynamicBatchActor>d__);
			return <LoadHeadStateDynamicBatchActor>d__.<>t__builder.Task;
		}

		// Token: 0x060458AB RID: 284843 RVA: 0x011426C8 File Offset: 0x011408C8
		protected override UniTask LoadHeadStateViewActor()
		{
			PinballBattleSubController.<LoadHeadStateViewActor>d__161 <LoadHeadStateViewActor>d__;
			<LoadHeadStateViewActor>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadHeadStateViewActor>d__.<>4__this = this;
			<LoadHeadStateViewActor>d__.<>1__state = -1;
			<LoadHeadStateViewActor>d__.<>t__builder.Start<PinballBattleSubController.<LoadHeadStateViewActor>d__161>(ref <LoadHeadStateViewActor>d__);
			return <LoadHeadStateViewActor>d__.<>t__builder.Task;
		}

		// Token: 0x060458AC RID: 284844 RVA: 0x0114270B File Offset: 0x0114090B
		public void OnInputTriggerBar()
		{
			PinballBattleLaunchPhaseController launchPhaseController = this.LaunchPhaseController;
			if (launchPhaseController != null && launchPhaseController.IsActive())
			{
				this.LaunchBall();
				return;
			}
			AKSC_Shape2D_Entity_Bar kscEntityLeftBar = this.KscEntityLeftBar;
			if (kscEntityLeftBar != null)
			{
				kscEntityLeftBar.TriggerBar();
			}
			AKSC_Shape2D_Entity_Bar kscEntityRightBar = this.KscEntityRightBar;
			if (kscEntityRightBar == null)
			{
				return;
			}
			kscEntityRightBar.TriggerBar();
		}

		// Token: 0x060458AD RID: 284845 RVA: 0x0114274C File Offset: 0x0114094C
		public void OnInputRebuildBounds()
		{
			UKSC_DA_Shape2D_WorldBounds shapeWorldBoundsDa = this.GetModel().ShapeWorldBoundsDa;
			if (shapeWorldBoundsDa != null)
			{
				UKSC_Shape2D_World shapeWorld = this.ShapeWorld;
				if (shapeWorld == null)
				{
					return;
				}
				shapeWorld.RebuildWorldBounds(shapeWorldBoundsDa);
			}
		}

		// Token: 0x060458AE RID: 284846 RVA: 0x0114277C File Offset: 0x0114097C
		public void OnInputResetPlayerPosition()
		{
			UKSC_Shape2D_World shapeWorld = this.ShapeWorld;
			AKSC_Shape2D_Entity_Player aksc_Shape2D_Entity_Player = (shapeWorld != null) ? shapeWorld.TeamPlayerEntities.Get(0) : null;
			if (aksc_Shape2D_Entity_Player != null)
			{
				AKSC_Shape2D_Entity_Player aksc_Shape2D_Entity_Player2 = aksc_Shape2D_Entity_Player;
				FTransform ftransform = this.BornTransform.ToUeTransformOld();
				aksc_Shape2D_Entity_Player2.SetEntityTransformDebug(ftransform);
			}
		}

		// Token: 0x060458AF RID: 284847 RVA: 0x011427BC File Offset: 0x011409BC
		public bool OnInputUseSkill(int roleIndex, int skillIndex = 0)
		{
			if (roleIndex < this.KscPlayerEntities.Length)
			{
				AKSC_Shape2D_Entity_Player aksc_Shape2D_Entity_Player = this.KscPlayerEntities[roleIndex];
				if (aksc_Shape2D_Entity_Player != null && aksc_Shape2D_Entity_Player.IsPlayerAlive)
				{
					aksc_Shape2D_Entity_Player.UseSkill(skillIndex);
					EventSystem.Instance.Emit<int>(EEventName.OnPinballRoleUseSkill, this.GetModel().GetRoleIdByEntityId(aksc_Shape2D_Entity_Player.EntityId_).GetValueOrDefault());
					return true;
				}
			}
			return false;
		}

		// Token: 0x060458B0 RID: 284848 RVA: 0x0114281B File Offset: 0x01140A1B
		public void OnInputUseTeamSkill(int skillIndex)
		{
			if (this.KscTeamPlayer != null)
			{
				this.KscTeamPlayer.UseSkill(skillIndex, true);
			}
		}

		// Token: 0x060458B1 RID: 284849 RVA: 0x01142832 File Offset: 0x01140A32
		protected int GetCreatureSpawnId()
		{
			this.CreatureIdCounter++;
			return this.CreatureIdCounter;
		}

		// Token: 0x060458B2 RID: 284850 RVA: 0x01142848 File Offset: 0x01140A48
		private void OnKscEntitySummon(FTransformDouble ueOwnerTransform, in TArray<FKSC_SpawnEntity> contexts, int summonerEntityId)
		{
			int num = contexts.Num();
			for (int i = 0; i < num; i++)
			{
				FKSC_SpawnEntity fksc_SpawnEntity = contexts.Get(i);
				FTransformDouble transform;
				if (fksc_SpawnEntity.IsUseAbsoluteTrans)
				{
					FTransformDouble entityTrans = fksc_SpawnEntity.EntityTrans;
					FTransformDouble ftransformDouble = this.WorldOriginTransform.ToUeTransform();
					transform = UKismetMathLibrary.D_ComposeTransforms(entityTrans, ftransformDouble);
				}
				else
				{
					FTransformDouble entityTrans = fksc_SpawnEntity.EntityTrans;
					transform = UKismetMathLibrary.D_ComposeTransforms(entityTrans, ueOwnerTransform);
				}
				this.SpawnEntityById(this.GetCreatureSpawnId(), fksc_SpawnEntity.EntityId, transform, new int?(summonerEntityId));
			}
		}

		// Token: 0x060458B3 RID: 284851 RVA: 0x011428C7 File Offset: 0x01140AC7
		private void OnRelaunchPlayer()
		{
			this.ReadyLaunch();
		}

		// Token: 0x060458B4 RID: 284852 RVA: 0x011428CF File Offset: 0x01140ACF
		private void OnTeamAllDead()
		{
			this.RequestTeamAllDie();
		}

		// Token: 0x060458B5 RID: 284853 RVA: 0x011428D8 File Offset: 0x01140AD8
		private void OnWorldUpdateOnce()
		{
			if (!Info.Instance.IsBuildShipping && this.ShapeWorld != null)
			{
				this.ShapeWorld.Entities_.Num();
				int num = this.ShapeWorld.ToAddEntities_.Num();
				if (num > 0)
				{
					for (int i = 0; i < num; i++)
					{
						this.ShapeWorld.ToAddEntities_.Get(i);
					}
				}
			}
			List<PinballFormationRolePb> list = this.GetModel().FormationData ?? new List<PinballFormationRolePb>();
			for (int j = 0; j < this.KscPlayerEntities.Length; j++)
			{
				AKSC_Shape2D_Entity_Player kscPlayer = this.KscPlayerEntities[j];
				PinballFormationRolePb pinballFormationRolePb = (list.Count > j) ? list[j] : null;
				if (pinballFormationRolePb != null)
				{
					this.InitPlayerEntityAttrAndBuffs(kscPlayer, pinballFormationRolePb);
				}
			}
			if (this.WorldUpdateOnceDelegateRef != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.OnWorldUpdateOnce));
				this.WorldUpdateOnceDelegateRef = null;
			}
		}

		// Token: 0x060458B6 RID: 284854 RVA: 0x011429B4 File Offset: 0x01140BB4
		private void InitPlayerEntityAttrAndBuffs(AKSC_Shape2D_Entity_Player kscPlayer, PinballFormationRolePb roleData)
		{
			PinballBattleSubModel model = this.GetModel();
			TMap<EKSC_AttrType, int> attrs_ = kscPlayer.GetSkillComp().AttrSet_.Attrs_;
			Dictionary<EKSC_AttrType, int> defaultAttrs = model.GetDefaultAttrs(attrs_);
			HashSet<int> valueOrDefault = model.RoleBornBuffsMap.GetValueOrDefault(roleData.RoleId);
			if (valueOrDefault != null)
			{
				foreach (int key in valueOrDefault)
				{
					UKSC_DA_Buff daBuff;
					if (model.LoadedBuffDaMap.TryGetValue(key, out daBuff))
					{
						kscPlayer.ApplyBuffSelf(daBuff);
					}
				}
			}
			List<int> teamBuffList = model.TeamBuffList;
			if (teamBuffList != null)
			{
				foreach (int key2 in teamBuffList)
				{
					UKSC_DA_Buff daBuff2;
					if (model.LoadedBuffDaMap.TryGetValue(key2, out daBuff2))
					{
						kscPlayer.ApplyBuffSelf(daBuff2);
					}
				}
			}
			Dictionary<EKSC_AttrType, float> dictionary = new Dictionary<EKSC_AttrType, float>();
			this.GetModel().GetRoleBornAttrs(roleData, dictionary);
			foreach (KeyValuePair<EKSC_AttrType, int> keyValuePair in attrs_)
			{
				EKSC_AttrType eksc_AttrType;
				int num;
				keyValuePair.Deconstruct(out eksc_AttrType, out num);
				EKSC_AttrType key3 = eksc_AttrType;
				int num2 = num;
				int valueOrDefault2 = defaultAttrs.GetValueOrDefault(key3, 0);
				int num3 = num2 - valueOrDefault2;
				if (num3 != 0)
				{
					dictionary[key3] = dictionary.GetValueOrDefault(key3, 0f) + (float)num3;
				}
			}
			float num4 = dictionary.GetValueOrDefault(EKSC_AttrType.LifeMax, 0f);
			if (num4 > 0f)
			{
				float valueOrDefault3 = dictionary.GetValueOrDefault(EKSC_AttrType.LifeChange, 0f);
				float valueOrDefault4 = dictionary.GetValueOrDefault(EKSC_AttrType.LifeExtra, 0f);
				num4 = (float)Math.Ceiling((double)(num4 * (1f + valueOrDefault3 * 0.0001f) + valueOrDefault4));
				dictionary[EKSC_AttrType.LifeMax] = num4;
				dictionary[EKSC_AttrType.Life] = num4;
				dictionary[EKSC_AttrType.BaseLife] = num4;
			}
			foreach (KeyValuePair<EKSC_AttrType, float> keyValuePair2 in dictionary)
			{
				kscPlayer.SetAttr(keyValuePair2.Key, (int)keyValuePair2.Value);
			}
			this.GetModel().SetRoleBaseAttrsRecord(roleData, dictionary);
		}

		// Token: 0x060458B7 RID: 284855 RVA: 0x01142C04 File Offset: 0x01140E04
		protected bool SpawnEntityById(int creatureId, int configId, FTransformDouble transform, int? summonerEntityId = null)
		{
			PinballCreature? creatureConfig = PinballBattleConfig.Instance.GetCreatureConfigById(configId);
			if (creatureConfig == null)
			{
				KscLog.EModule flag = KscLog.EModule.Common;
				ELogAuthor author = ELogAuthor.WWJ;
				UObject kscWorld = KscEnv.Instance.KscWorld;
				string log = "[弹球玩法]实体配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("creatureConfig", creatureConfig);
				KscLog.Error(flag, author, kscWorld, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			int kscEntityId = creatureConfig.Value.KscEntityId;
			string entityPathById = KuroSimpleCombatController.Instance.CurSubModel.GetEntityPathById(kscEntityId);
			if (string.IsNullOrEmpty(entityPathById))
			{
				KscLog.EModule flag2 = KscLog.EModule.Common;
				ELogAuthor author2 = ELogAuthor.WWJ;
				UObject kscWorld2 = KscEnv.Instance.KscWorld;
				string log2 = "[弹球玩法]实体资产路径不存在";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("simpleCombatId", kscEntityId);
				KscLog.Error(flag2, author2, kscWorld2, log2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			Dictionary<int, int> dictionary = null;
			if (summonerEntityId != null && creatureConfig.Value.SummonLifeInherit > 0)
			{
				KscEntityHandle kscEntityHandle;
				AKSC_Entity aksc_Entity = this.GetModel().KscEntities.TryGetValue(summonerEntityId.Value, out kscEntityHandle) ? ((kscEntityHandle != null) ? kscEntityHandle.KscEntity : null) : null;
				TMap<EKSC_AttrType, int> tmap;
				if (aksc_Entity == null)
				{
					tmap = null;
				}
				else
				{
					UKSC_SkillComp skillComp = aksc_Entity.GetSkillComp();
					if (skillComp == null)
					{
						tmap = null;
					}
					else
					{
						UKSC_AttrSet attrSet_ = skillComp.AttrSet_;
						tmap = ((attrSet_ != null) ? attrSet_.Attrs_ : null);
					}
				}
				TMap<EKSC_AttrType, int> tmap2 = tmap;
				if (tmap2 != null)
				{
					dictionary = new Dictionary<int, int>();
					float valueOrDefault = (float)tmap2.GetValueOrDefault(EKSC_AttrType.LifeMax, 0);
					float num = (float)creatureConfig.Value.SummonLifeInherit * 0.0001f;
					float num2 = (float)Math.Ceiling((double)(valueOrDefault * num));
					if (num2 > 0f)
					{
						dictionary[2] = (int)num2;
						dictionary[3] = (int)num2;
						dictionary[13] = (int)num2;
					}
				}
			}
			KuroSimpleCombatController.Instance.AsyncAddEntity(new KscEntityParam
			{
				CreatureId = (long)creatureId,
				SimpleCombatId = kscEntityId,
				AssetPath = entityPathById,
				PropertyId = creatureConfig.Value.AttrId,
				Transform = transform,
				Buffs = KscUtil.ToBuffParam(creatureConfig.Value.GetBornBuffArray(), null),
				AttributeMap = dictionary,
				FinishCallback = delegate(AKSC_Entity kscEntity)
				{
					UKSC_DA_Buff daBuff;
					if (summonerEntityId != null && creatureConfig.Value.SummonBuffId != 0 && this.GetModel().LoadedBuffDaMap.TryGetValue(creatureConfig.Value.SummonBuffId, out daBuff))
					{
						kscEntity.ApplyBuffByOther(daBuff, summonerEntityId.Value);
					}
					this.SetSpineCompTickEnabled(kscEntity, true);
				}
			});
			return true;
		}

		// Token: 0x060458B8 RID: 284856 RVA: 0x01142E44 File Offset: 0x01141044
		private void RefreshCameraFov()
		{
			SceneCamera sceneCamera = CameraController.Instance.MainModel.SceneCamera;
			UCineCameraComponent ucineCameraComponent;
			if (sceneCamera == null)
			{
				ucineCameraComponent = null;
			}
			else
			{
				SceneCameraDisplayComponent displayComponent = sceneCamera.DisplayComponent;
				if (displayComponent == null)
				{
					ucineCameraComponent = null;
				}
				else
				{
					SceneSubCamera curSceneSubCamera = displayComponent.CurSceneSubCamera;
					if (curSceneSubCamera == null)
					{
						ucineCameraComponent = null;
					}
					else
					{
						BP_CineCamera_C camera = curSceneSubCamera.Camera;
						ucineCameraComponent = ((camera != null) ? camera.GetCineCameraComponent() : null);
					}
				}
			}
			UCineCameraComponent ucineCameraComponent2 = ucineCameraComponent;
			if (ucineCameraComponent2 == null)
			{
				return;
			}
			float fieldOfView = this.AdjustCameraFovByScreenHeight(this.BaseFov);
			ucineCameraComponent2.SetFieldOfView(fieldOfView);
		}

		// Token: 0x060458B9 RID: 284857 RVA: 0x01142EAC File Offset: 0x011410AC
		public float AdjustCameraFovByScreenHeight(float baseFov)
		{
			TsCharacterController characterController = Global.CharacterController;
			if (characterController != null)
			{
				int num = 0;
				int num2 = 0;
				characterController.GetViewportSize(ref num, ref num2);
				float num3 = (float)num / (float)num2;
				float num4 = MathCommon.DegreeToRadian(baseFov);
				float val = MathCommon.RadianToDegree(2f * (float)Math.Atan((double)(1.7777778f / num3) * Math.Tan((double)(num4 / 2f))));
				return Math.Max(baseFov, val);
			}
			return baseFov;
		}

		// Token: 0x060458BA RID: 284858 RVA: 0x01142F14 File Offset: 0x01141114
		private void InitBackgroundMaterial()
		{
			TArray<AActor> tarray = new TArray<AActor>();
			UGameplayStatics.GetAllActorsOfClassWithTag(GlobalData.World, AStaticMeshActor.StaticClass(), FNameUtil.GetDynamicFName("Background").Value, ref tarray);
			if (tarray.Num() == 0)
			{
				return;
			}
			AStaticMeshActor astaticMeshActor = tarray.Get(0) as AStaticMeshActor;
			UStaticMeshComponent ustaticMeshComponent = (astaticMeshActor != null) ? astaticMeshActor.StaticMeshComponent : null;
			UMaterialInterface sourceMaterial = (ustaticMeshComponent != null) ? ustaticMeshComponent.GetMaterial(0) : null;
			this.BgDynamicMat = ((ustaticMeshComponent != null) ? ustaticMeshComponent.CreateDynamicMaterialInstance(0, sourceMaterial, default(FName)) : null);
			int curLevelId = PinballModel.Instance.CurLevelId;
			if (curLevelId != 0)
			{
				PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(curLevelId);
				if (pinballLevelConfigById == null)
				{
					return;
				}
				this.ChangeBackground(pinballLevelConfigById.Value.LevelBg);
			}
		}

		// Token: 0x060458BB RID: 284859 RVA: 0x01142FDC File Offset: 0x011411DC
		private void ChangeBackground(string texturePath)
		{
			if (string.IsNullOrEmpty(texturePath))
			{
				return;
			}
			UTexture value = ResourceSystem.Instance.Load<UTexture>(texturePath, "js_undefined");
			UMaterialInstanceDynamic bgDynamicMat = this.BgDynamicMat;
			if (bgDynamicMat == null)
			{
				return;
			}
			bgDynamicMat.SetTextureParameterValue(FNameUtil.GetDynamicFName("Background").Value, value);
		}

		// Token: 0x060458BC RID: 284860 RVA: 0x01143028 File Offset: 0x01141228
		private void UpdateCombo()
		{
			if (this.ShapeWorld == null)
			{
				return;
			}
			int worldAttr = this.ShapeWorld.GetWorldAttr(EKSC_WorldAttrType.Combo);
			PinballBattleSubModel model = this.GetModel();
			if (model == null)
			{
				return;
			}
			model.SetCombo(worldAttr);
		}

		// Token: 0x060458BD RID: 284861 RVA: 0x0114305C File Offset: 0x0114125C
		private void UpdateDamageInfo()
		{
			if (this.ShapeWorld == null)
			{
				return;
			}
			if (this.DamageInfo == null)
			{
				this.DamageInfo = new TMap<int, int>();
			}
			this.ShapeWorld.GetDamageInfo(ref this.DamageInfo);
			this.GetModel().UpdateDamageInfo(this.DamageInfo);
		}

		// Token: 0x060458BE RID: 284862 RVA: 0x0114309C File Offset: 0x0114129C
		public void CreateLaunchController()
		{
			global::Vector vector = global::Vector.Create(this.WorldOrigin);
			vector.Z = (double)this.GroundPositionZ;
			PinballBattleSubModel model = this.GetModel();
			PinballWorldConfig? pinballWorldConfig = (model != null) ? model.WorldConfigCache : null;
			if (pinballWorldConfig != null)
			{
				vector.Y += (double)pinballWorldConfig.Value.LaunchSplineYOffset;
			}
			UiPanelBase launchBallItem = this.LaunchBallItem;
			if (launchBallItem != null)
			{
				launchBallItem.Show(null);
			}
			AActor rootActor = this.LaunchBallItem.GetRootActor();
			FHitResult fhitResult = new FHitResult();
			rootActor.D_K2_SetActorLocation(vector.ToUeVector(false), false, ref fhitResult, false);
			this.LaunchPhaseController = new PinballBattleLaunchPhaseController();
			this.LaunchPhaseController.SetupSplineMotion(rootActor, 319850000, this.LaunchSpeedCurve, this.LaunchDegCurve);
		}

		// Token: 0x060458BF RID: 284863 RVA: 0x01143163 File Offset: 0x01141363
		public void ReadyLaunch()
		{
			this.SetAllPlayerEntityActive(false, true);
			PinballBattleLaunchPhaseController launchPhaseController = this.LaunchPhaseController;
			if (launchPhaseController == null)
			{
				return;
			}
			launchPhaseController.StartSplineMotion();
		}

		// Token: 0x060458C0 RID: 284864 RVA: 0x01143180 File Offset: 0x01141380
		public void LaunchBall()
		{
			PinballBattleLaunchPhaseController launchPhaseController = this.LaunchPhaseController;
			if (launchPhaseController == null || !launchPhaseController.IsActive())
			{
				return;
			}
			UKSC_Shape2D_World shapeWorld = this.ShapeWorld;
			AKSC_Shape2D_Entity_Player aksc_Shape2D_Entity_Player = (shapeWorld != null) ? shapeWorld.TeamPlayerEntities.Get(0) : null;
			if (aksc_Shape2D_Entity_Player == null)
			{
				return;
			}
			this.SetAllPlayerEntityActive(true, true);
			FVector value = this.LaunchPhaseController.GetCurrentActorPosition().Value;
			float currentAngle = this.LaunchPhaseController.GetCurrentAngle();
			UKSC_DA_Shape2D_World shapeWorldDa = this.GetModel().ShapeWorldDa;
			float launchSpeed = (shapeWorldDa != null) ? shapeWorldDa.LaunchSpeed : 0f;
			UKSC_Shape2DMove uksc_Shape2DMove = aksc_Shape2D_Entity_Player.GetMoveComponent() as UKSC_Shape2DMove;
			global::Transform transform = global::Transform.Create();
			transform.SetLocation(value);
			foreach (AKSC_Shape2D_Entity_Player aksc_Shape2D_Entity_Player2 in this.KscPlayerEntities)
			{
				if (aksc_Shape2D_Entity_Player2 != null && aksc_Shape2D_Entity_Player2.IsPlayerAlive)
				{
					AKSC_Entity aksc_Entity = aksc_Shape2D_Entity_Player2;
					FTransformDouble ftransformDouble = transform.ToUeTransform();
					aksc_Entity.SetTransformByWorld(ftransformDouble);
				}
			}
			FVector2D rotated = new FVector2D(0f, 1f).GetRotated(currentAngle);
			if (uksc_Shape2DMove != null)
			{
				uksc_Shape2DMove.Launch(launchSpeed, rotated, false, false);
			}
			this.LaunchPhaseController.StopSplineMotion();
			if (this.NeedSendLaunchRequest)
			{
				this.NeedSendLaunchRequest = false;
				this.RequestLaunch();
			}
			if (this.IsFirstLaunch)
			{
				EventSystem.Instance.Emit(EEventName.OnPinballFirstLaunch);
			}
			this.IsFirstLaunch = false;
			this.StopAutoLaunchTimer();
		}

		// Token: 0x060458C1 RID: 284865 RVA: 0x011432DC File Offset: 0x011414DC
		public void SetAllPlayerEntityActive(bool active, bool checkIsAlive = true)
		{
			foreach (AKSC_Shape2D_Entity_Player aksc_Shape2D_Entity_Player in this.KscPlayerEntities)
			{
				if (aksc_Shape2D_Entity_Player != null)
				{
					this.SetPlayerEntityActive(aksc_Shape2D_Entity_Player, active, checkIsAlive);
				}
			}
		}

		// Token: 0x060458C2 RID: 284866 RVA: 0x0114330E File Offset: 0x0114150E
		public void SetPlayerEntityActive(AKSC_Shape2D_Entity_Player entity, bool active, bool checkIsAlive = true)
		{
			if (checkIsAlive && !entity.IsPlayerAlive)
			{
				return;
			}
			entity.SetEntityActive(active);
			entity.SetActorHiddenInGame(!active);
			if (!active)
			{
				entity.SetLocationByWorld(this.EntityHidePosition);
			}
		}

		// Token: 0x060458C3 RID: 284867 RVA: 0x01143340 File Offset: 0x01141540
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<UCurveFloat> LoadCurveAsync(string path)
		{
			PinballBattleSubController.<LoadCurveAsync>d__187 <LoadCurveAsync>d__;
			<LoadCurveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<UCurveFloat>.Create();
			<LoadCurveAsync>d__.path = path;
			<LoadCurveAsync>d__.<>1__state = -1;
			<LoadCurveAsync>d__.<>t__builder.Start<PinballBattleSubController.<LoadCurveAsync>d__187>(ref <LoadCurveAsync>d__);
			return <LoadCurveAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060458C4 RID: 284868 RVA: 0x01143384 File Offset: 0x01141584
		private void InitFeverBar()
		{
			global::Transform transform = global::Transform.Create(this.WorldOriginTransform.ToUeTransform());
			PinballWorldConfig? worldConfigCache = this.GetModel().WorldConfigCache;
			float dissolveMin = 0f;
			float dissolveMax = 1f;
			if (worldConfigCache != null)
			{
				global::Vector location = transform.GetLocation();
				location.Y += (double)worldConfigCache.Value.FeverBarYOffset;
				transform.SetLocation(location);
				if (worldConfigCache.Value.FeverBarDissolveRangeLength > 1)
				{
					dissolveMin = worldConfigCache.Value.FeverBarDissolveRange(0);
					dissolveMax = worldConfigCache.Value.FeverBarDissolveRange(1);
				}
			}
			this.FeverBar = ActorSystem.Instance.Spawn<BP_Fever_Bar_C>(BP_Fever_Bar_C.StaticClass(), transform.ToUeTransform(), null);
			this.FeverBarController = new PinballBattleFeverBarController();
			this.FeverBarController.Init(this.FeverBar, dissolveMin, dissolveMax, this.FeverBarMaterial);
		}

		// Token: 0x060458C5 RID: 284869 RVA: 0x0114346E File Offset: 0x0114166E
		private void InitLaunchDirectionController()
		{
			if (this.LaunchDirectionItem == null)
			{
				return;
			}
			this.LaunchDirectionController = new PinballBattleLaunchDirectionController();
			this.LaunchDirectionController.Init(this.LaunchDirectionItem);
		}

		// Token: 0x060458C6 RID: 284870 RVA: 0x01143495 File Offset: 0x01141695
		public void BindBossSkillStateChangeDelegate(AKSC_Shape2D_Entity kscEntity)
		{
			this.ClearBossSkillStateChangeDelegate();
			this.BossSkillStateChangeDelegate = DelegateUtils.ToManualReleaseDelegate<FOnShape2DSkillStateChange>(new Action<int, EKSC_Skill_State>(this.OnBossSkillStateChange));
			kscEntity.AssignSkillStateChange(this.BossSkillStateChangeDelegate);
		}

		// Token: 0x060458C7 RID: 284871 RVA: 0x011434C0 File Offset: 0x011416C0
		public void ClearBossSkillStateChangeDelegate()
		{
			if (this.BossSkillStateChangeDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<int, EKSC_Skill_State>(this.OnBossSkillStateChange));
				this.BossSkillStateChangeDelegate = null;
			}
		}

		// Token: 0x060458C8 RID: 284872 RVA: 0x011434E4 File Offset: 0x011416E4
		private void ClearTotalDelegateList()
		{
			foreach (Delegate callBack in this.RoleSkillDelegateList)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(callBack);
			}
			foreach (Delegate callBack2 in this.PlayerStateChangeDelegateList)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(callBack2);
			}
			this.RoleSkillDelegateList.Clear();
			this.PlayerStateChangeDelegateList.Clear();
			this.ClearBossSkillStateChangeDelegate();
		}

		// Token: 0x060458C9 RID: 284873 RVA: 0x01143590 File Offset: 0x01141790
		private void BindPlayerEntityTotalDelegate(AKSC_Shape2D_Entity_Player playerEntity, IPinballRoleTotalInfo roleTotalData, int roleId)
		{
			Action<int, EKSC_Skill_State> action = delegate(int skillIndex, EKSC_Skill_State state)
			{
				if (state != EKSC_Skill_State.BeginSkill)
				{
					return;
				}
				if (skillIndex == 1)
				{
					this.GetModel().DashTimes++;
					return;
				}
				if (skillIndex == 0)
				{
					IPinballRoleTotalInfo roleTotalData2 = roleTotalData;
					int skillTimes = roleTotalData2.SkillTimes;
					roleTotalData2.SkillTimes = skillTimes + 1;
				}
			};
			FOnShape2DSkillStateChange fonShape2DSkillStateChange = DelegateUtils.ToManualReleaseDelegate<FOnShape2DSkillStateChange>(action);
			this.RoleSkillDelegateList.Add(action);
			playerEntity.AssignSkillStateChange(fonShape2DSkillStateChange);
			Action<bool> action2 = delegate(bool isAlive)
			{
				EventSystem.Instance.Emit<int, bool>(EEventName.OnPinballRoleStateChange, this.GetModel().GetRoleIdByEntityId(playerEntity.EntityId_).GetValueOrDefault(), isAlive);
				int num;
				if (isAlive)
				{
					IPinballRoleTotalInfo roleTotalData2 = roleTotalData;
					num = roleTotalData2.ReviveTimes;
					roleTotalData2.ReviveTimes = num + 1;
					this.UpdateTranslucentSortPriority(playerEntity, roleId, null);
					return;
				}
				IPinballRoleTotalInfo roleTotalData3 = roleTotalData;
				num = roleTotalData3.DieTimes;
				roleTotalData3.DieTimes = num + 1;
				this.UpdateTranslucentSortPriority(playerEntity, roleId, new int?(1));
			};
			FOnPlayerStateChange fonPlayerStateChange = DelegateUtils.ToManualReleaseDelegate<FOnPlayerStateChange>(action2);
			this.PlayerStateChangeDelegateList.Add(action2);
			playerEntity.AssignPlayerStateChange(fonPlayerStateChange);
		}

		// Token: 0x060458CA RID: 284874 RVA: 0x01143617 File Offset: 0x01141817
		public void OnBossSkillStateChange(int skillIndex, EKSC_Skill_State state)
		{
			if (state != EKSC_Skill_State.BeginSkill)
			{
				return;
			}
			this.GetModel().BossSkillTimes++;
		}

		// Token: 0x060458CB RID: 284875 RVA: 0x01143634 File Offset: 0x01141834
		private void UpdateDamageTotalInfo()
		{
			if (this.ShapeWorld == null)
			{
				return;
			}
			if (this.DamageTotalInfo == null)
			{
				this.DamageTotalInfo = new TArray<FKSC_Shape2D_DamageTotalInfo>();
			}
			this.ShapeWorld.GetDamageTotalInfo(ref this.DamageTotalInfo);
			for (int i = 0; i < this.DamageTotalInfo.Num(); i++)
			{
				FKSC_Shape2D_DamageTotalInfo damageInfo = this.DamageTotalInfo.Get(i);
				this.ExecuteDamageTotalInfo(damageInfo);
			}
		}

		// Token: 0x060458CC RID: 284876 RVA: 0x01143698 File Offset: 0x01141898
		private void ExecuteDamageTotalInfo(FKSC_Shape2D_DamageTotalInfo damageInfo)
		{
			int sourceEntityId = damageInfo.SourceEntityId;
			int targetEntityId = damageInfo.TargetEntityId;
			int damageId = damageInfo.DamageId;
			int damageValue = damageInfo.DamageValue;
			long collisionDamageId = this.ShapeWorld.DA_Shape2D_World.CollisionDamageId0;
			int valueOrDefault = this.GetModel().GetRoleIdByEntityId(sourceEntityId).GetValueOrDefault();
			PinballRoleTotalInfo pinballRoleTotalInfo;
			this.GetModel().RoleTotalMap.TryGetValue(valueOrDefault, out pinballRoleTotalInfo);
			IPinballRoleTotalInfo pinballRoleTotalInfo2 = pinballRoleTotalInfo;
			if (sourceEntityId == targetEntityId && pinballRoleTotalInfo2 != null)
			{
				pinballRoleTotalInfo2.DropCostHp += (float)damageValue;
				return;
			}
			if (pinballRoleTotalInfo2 != null)
			{
				if ((long)damageId == collisionDamageId)
				{
					this.GetModel().AttackTimes++;
				}
				else
				{
					this.GetModel().FullEnergyTimes++;
				}
			}
			int valueOrDefault2 = this.GetModel().GetRoleIdByEntityId(targetEntityId).GetValueOrDefault();
			PinballRoleTotalInfo pinballRoleTotalInfo3;
			this.GetModel().RoleTotalMap.TryGetValue(valueOrDefault2, out pinballRoleTotalInfo3);
			pinballRoleTotalInfo2 = pinballRoleTotalInfo3;
			if (pinballRoleTotalInfo2 != null)
			{
				pinballRoleTotalInfo2.HitCostHp += (float)damageValue;
			}
		}

		// Token: 0x060458CD RID: 284877 RVA: 0x01143798 File Offset: 0x01141998
		public void StartAutoLaunchTimer()
		{
			if (this.AutoLaunchTimer != null)
			{
				return;
			}
			this.AutoLaunchTimer = TimerSystem.FlowTimeInstance.Delay(delegate(float _)
			{
				this.LaunchBall();
			}, (float)this.GetModel().WorldConfigCache.Value.ForceLaunchTime, null, null, true, 1f);
		}

		// Token: 0x060458CE RID: 284878 RVA: 0x011437EB File Offset: 0x011419EB
		public void StopAutoLaunchTimer()
		{
			if (this.AutoLaunchTimer == null)
			{
				return;
			}
			TimerSystem.FlowTimeInstance.Remove(this.AutoLaunchTimer);
			this.AutoLaunchTimer = null;
		}

		// Token: 0x060458CF RID: 284879 RVA: 0x01143810 File Offset: 0x01141A10
		private void TryTriggerDeathrattle(int creatureDataId)
		{
			IPinballBattleCombatInfo entity = this.GetModel().GetEntity(creatureDataId);
			if (entity == null || entity.EntityType != EPinballBattleEntityType.Drop)
			{
				return;
			}
			int configId = ((IPinballBattleActivityEntityInfo)entity).ConfigId;
			PinballCommonItem? commonItemConfigByConfigId = PinballBattleConfig.Instance.GetCommonItemConfigByConfigId(configId);
			if (commonItemConfigByConfigId == null)
			{
				return;
			}
			PinballDeathrattle? deathrattleConfig = PinballBattleConfig.Instance.GetDeathrattleConfig(commonItemConfigByConfigId.Value.Deathrattle);
			if (deathrattleConfig == null || deathrattleConfig.Value.Type != 2)
			{
				return;
			}
			for (int i = 0; i < deathrattleConfig.Value.BuffIdListLength; i++)
			{
				int configId2 = deathrattleConfig.Value.BuffIdList(i);
				PinballEffect? effectConfig = PinballBattleConfig.Instance.GetEffectConfig(configId2);
				if (effectConfig != null)
				{
					int type = effectConfig.Value.Type;
					if (type != 1)
					{
						if (type == 2)
						{
							this.ApplyBuffToEnemies(effectConfig.Value);
						}
					}
					else
					{
						this.ApplyBuffToAllies(effectConfig.Value.Param1);
					}
				}
			}
		}

		// Token: 0x060458D0 RID: 284880 RVA: 0x01143930 File Offset: 0x01141B30
		private void ApplyBuffToAllies(string buffIdStr)
		{
			foreach (int buffId in this.ParseNumberArray(buffIdStr))
			{
				foreach (AKSC_Shape2D_Entity_Player aksc_Shape2D_Entity_Player in this.KscPlayerEntities)
				{
					KuroSimpleCombatController.Instance.ModifyBuffAsync(aksc_Shape2D_Entity_Player.EntityId_, true, buffId);
				}
			}
		}

		// Token: 0x060458D1 RID: 284881 RVA: 0x011439AC File Offset: 0x01141BAC
		private void ApplyBuffToEnemies(PinballEffect buffEffect)
		{
			List<IPinballBattleCombatInfo> list = new List<IPinballBattleCombatInfo>();
			this.GetModel().GetAllEntities(list);
			List<int> list2 = this.ParseNumberArray(buffEffect.Param2);
			List<int> list3 = this.ParseNumberArray(buffEffect.Param1);
			foreach (IPinballBattleCombatInfo pinballBattleCombatInfo in list)
			{
				if (pinballBattleCombatInfo.EntityType == EPinballBattleEntityType.Monster)
				{
					IPinballBattleActivityEntityInfo pinballBattleActivityEntityInfo = pinballBattleCombatInfo as IPinballBattleActivityEntityInfo;
					if (pinballBattleActivityEntityInfo != null)
					{
						int? logicProxy = this.GetModel().GetLogicProxy((long)pinballBattleCombatInfo.Uid);
						if (logicProxy == null)
						{
							Log instance = Log.Instance;
							ELogModule module = ELogModule.PinballBattle;
							ELogAuthor author = ELogAuthor.LJ;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
							defaultInterpolatedStringHandler.AppendLiteral("获取怪物实体Id失败！ConfigId: ");
							defaultInterpolatedStringHandler.AppendFormatted<int>(pinballBattleActivityEntityInfo.ConfigId);
							defaultInterpolatedStringHandler.AppendLiteral(", Uid: ");
							defaultInterpolatedStringHandler.AppendFormatted<int>(pinballBattleCombatInfo.Uid);
							instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
						}
						else
						{
							PinballMonster? pinballMonsterConfigById = PinballConfig.Instance.GetPinballMonsterConfigById(pinballBattleActivityEntityInfo.ConfigId);
							if (pinballMonsterConfigById == null)
							{
								Log instance2 = Log.Instance;
								ELogModule module2 = ELogModule.PinballBattle;
								ELogAuthor author2 = ELogAuthor.LJ;
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
								defaultInterpolatedStringHandler.AppendLiteral("获取怪物配置失败！ConfigId: ");
								defaultInterpolatedStringHandler.AppendFormatted<int>(pinballBattleActivityEntityInfo.ConfigId);
								instance2.Error(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
							}
							else
							{
								PinballMonsterType? pinballMonsterTypeConfigById = PinballConfig.Instance.GetPinballMonsterTypeConfigById(pinballMonsterConfigById.Value.MonsterType);
								if (pinballMonsterTypeConfigById == null)
								{
									Log instance3 = Log.Instance;
									ELogModule module3 = ELogModule.PinballBattle;
									ELogAuthor author3 = ELogAuthor.LJ;
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 2);
									defaultInterpolatedStringHandler.AppendLiteral("获取怪物类型配置失败！ConfigId: ");
									defaultInterpolatedStringHandler.AppendFormatted<int>(pinballBattleActivityEntityInfo.ConfigId);
									defaultInterpolatedStringHandler.AppendLiteral(", MonsterTypeId: ");
									defaultInterpolatedStringHandler.AppendFormatted<int>(pinballMonsterConfigById.Value.MonsterType);
									instance3.Error(module3, author3, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
								}
								else if (list2.Contains(pinballMonsterTypeConfigById.Value.RiskType))
								{
									foreach (int buffId in list3)
									{
										KuroSimpleCombatController.Instance.ModifyBuffAsync(logicProxy.Value, true, buffId);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060458D2 RID: 284882 RVA: 0x01143C40 File Offset: 0x01141E40
		private List<int> ParseNumberArray(string str)
		{
			string text = str.Replace("[", "").Replace("]", "").Trim();
			if (string.IsNullOrEmpty(text))
			{
				return new List<int>();
			}
			List<int> list = new List<int>();
			string[] array = text.Split(',', StringSplitOptions.None);
			for (int i = 0; i < array.Length; i++)
			{
				int item;
				if (int.TryParse(array[i].Trim(), out item))
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x060458D3 RID: 284883 RVA: 0x01143CB8 File Offset: 0x01141EB8
		public void AddRoleChargeMaxEffectBuff(int roleId)
		{
			KscEntityHandle kscEntityByRoleId = this.GetModel().GetKscEntityByRoleId(roleId);
			AKSC_Shape2D_Entity_Player aksc_Shape2D_Entity_Player = ((kscEntityByRoleId != null) ? kscEntityByRoleId.KscEntity : null) as AKSC_Shape2D_Entity_Player;
			if (aksc_Shape2D_Entity_Player == null || !aksc_Shape2D_Entity_Player.IsPlayerAlive)
			{
				return;
			}
			KuroSimpleCombatController.Instance.ModifyBuffAsync(aksc_Shape2D_Entity_Player.EntityId_, true, this.GetModel().WorldConfigCache.Value.RoleChargeMaxBuffId);
		}

		// Token: 0x060458D4 RID: 284884 RVA: 0x01143D18 File Offset: 0x01141F18
		public void RemoveRoleChargeMaxEffectBuff(int roleId)
		{
			KscEntityHandle kscEntityByRoleId = this.GetModel().GetKscEntityByRoleId(roleId);
			AKSC_Shape2D_Entity_Player aksc_Shape2D_Entity_Player = ((kscEntityByRoleId != null) ? kscEntityByRoleId.KscEntity : null) as AKSC_Shape2D_Entity_Player;
			if (aksc_Shape2D_Entity_Player == null)
			{
				return;
			}
			KuroSimpleCombatController.Instance.ModifyBuffAsync(aksc_Shape2D_Entity_Player.EntityId_, false, this.GetModel().WorldConfigCache.Value.RoleChargeMaxBuffId);
		}

		// Token: 0x060458D5 RID: 284885 RVA: 0x01143D70 File Offset: 0x01141F70
		private void UpdateTranslucentSortPriority(AKSC_Shape2D_Entity_Player kscPlayer, int roleId, int? priority = null)
		{
			int? roleSlotIndex = this.GetModel().GetRoleSlotIndex(roleId);
			List<PinballFormationRolePb> formationData = this.GetModel().FormationData;
			int num = (formationData != null) ? formationData.Count : 0;
			if (roleSlotIndex != null && num != 0)
			{
				TArray<UActorComponent> tarray = kscPlayer.K2_GetComponentsByClass(USpineSkeletonRendererComponent.StaticClass());
				int num2 = tarray.Num();
				FName b = new FName("SpineShadow");
				for (int i = 0; i < num2; i++)
				{
					USpineSkeletonRendererComponent uspineSkeletonRendererComponent = (USpineSkeletonRendererComponent)tarray.Get(i);
					int num3 = priority ?? ((num - roleSlotIndex.Value) * 2 + 1);
					if (uspineSkeletonRendererComponent.GetFName() == b)
					{
						uspineSkeletonRendererComponent.SetTranslucentSortPriority(num3 - 1);
					}
					else
					{
						uspineSkeletonRendererComponent.SetTranslucentSortPriority(num3);
					}
				}
			}
		}

		// Token: 0x060458D6 RID: 284886 RVA: 0x01143E44 File Offset: 0x01142044
		public bool HasAnyPlayerUseSkill()
		{
			AKSC_Shape2D_Entity_Player[] kscPlayerEntities = this.KscPlayerEntities;
			for (int i = 0; i < kscPlayerEntities.Length; i++)
			{
				UKSC_SkillComp skillComp_ = kscPlayerEntities[i].SkillComp_;
				TArray<UKSC_Skill> tarray = (skillComp_ != null) ? skillComp_.Skills_ : null;
				if (tarray != null && tarray.Num() > 0)
				{
					for (int j = 0; j < tarray.Num(); j++)
					{
						EKSC_Skill_State skillState_ = tarray.Get(j).SkillState_;
						if (skillState_ != EKSC_Skill_State.Ready && skillState_ != EKSC_Skill_State.EndCast && skillState_ != EKSC_Skill_State.EndSkill && skillState_ != EKSC_Skill_State.CoolDown)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x060458D7 RID: 284887 RVA: 0x01143EBC File Offset: 0x011420BC
		public bool IsInDashCd()
		{
			UKSC_Shape2D_World shapeWorld = this.ShapeWorld;
			AKSC_Shape2D_Entity_Player aksc_Shape2D_Entity_Player = (shapeWorld != null) ? shapeWorld.CurrentPlayer : null;
			if (aksc_Shape2D_Entity_Player == null)
			{
				return false;
			}
			UKSC_SkillComp skillComp_ = aksc_Shape2D_Entity_Player.SkillComp_;
			TArray<UKSC_Skill> tarray = (skillComp_ != null) ? skillComp_.Skills_ : null;
			return tarray != null && tarray.Num() > 1 && tarray.Get(1).SkillState_ > EKSC_Skill_State.Ready;
		}

		// Token: 0x060458D8 RID: 284888 RVA: 0x01143F14 File Offset: 0x01142114
		public float? GetDashNeedCost()
		{
			UKSC_Shape2D_World shapeWorld = this.ShapeWorld;
			AKSC_Shape2D_Entity_Player aksc_Shape2D_Entity_Player = (shapeWorld != null) ? shapeWorld.CurrentPlayer : null;
			if (aksc_Shape2D_Entity_Player == null)
			{
				return null;
			}
			UKSC_SkillComp skillComp_ = aksc_Shape2D_Entity_Player.SkillComp_;
			TArray<UKSC_Skill> tarray = (skillComp_ != null) ? skillComp_.Skills_ : null;
			if (tarray == null || tarray.Num() <= 1)
			{
				return null;
			}
			UKSC_DA_Skill daSkill_ = tarray.Get(1).DaSkill_;
			if (daSkill_ == null)
			{
				return null;
			}
			return new float?(daSkill_.CustomCostValue);
		}

		// Token: 0x060458D9 RID: 284889 RVA: 0x01143F90 File Offset: 0x01142190
		private void EnterFixCamera(global::Vector location, global::Rotator rotation, float fov)
		{
			if (this.IsInFixCamera)
			{
				return;
			}
			this.IsInFixCamera = true;
			SceneCamera sceneCamera = CameraController.Instance.MainModel.SceneCamera;
			if (sceneCamera == null)
			{
				return;
			}
			SceneCameraPlayerComponent playerComponent = sceneCamera.PlayerComponent;
			if (playerComponent == null)
			{
				return;
			}
			playerComponent.EnterFixSceneSubCamera(location, rotation, fov, 0f, 0f, ESceneSubCameraType.Fix, null, new EViewTargetBlendFunction?(EViewTargetBlendFunction.VTBlend_Linear), new float?(0f), new EViewTargetBlendFunction?(EViewTargetBlendFunction.VTBlend_Linear), new float?(0f), new bool?(false), null, new bool?(false), null, "", null, null, null, false, false);
		}

		// Token: 0x060458DA RID: 284890 RVA: 0x01144017 File Offset: 0x01142217
		private void ExitFixCamera()
		{
			if (!this.IsInFixCamera)
			{
				return;
			}
			this.IsInFixCamera = false;
			SceneCamera sceneCamera = CameraController.Instance.MainModel.SceneCamera;
			if (sceneCamera == null)
			{
				return;
			}
			SceneCameraPlayerComponent playerComponent = sceneCamera.PlayerComponent;
			if (playerComponent == null)
			{
				return;
			}
			playerComponent.ExitFixSceneSubCamera(null, true);
		}

		// Token: 0x060458DB RID: 284891 RVA: 0x01144050 File Offset: 0x01142250
		private void ClearAllBullets()
		{
			BulletModel instance = BulletModel.Instance;
			UBulletWorld ubulletWorld = (instance != null) ? instance.GetKuroBulletWorld() : null;
			if (ubulletWorld != null)
			{
				foreach (KscEntityHandle kscEntityHandle in this.GetModel().KscEntities.Values)
				{
					if (((kscEntityHandle != null) ? kscEntityHandle.KscEntity : null) != null)
					{
						ubulletWorld.DestroyAllBulletsByOwner(kscEntityHandle.KscEntity);
					}
				}
			}
		}

		// Token: 0x060458DC RID: 284892 RVA: 0x011440D8 File Offset: 0x011422D8
		public void SetSpineCompTickEnabled(AKSC_Entity kscEntity, bool enabled)
		{
			USpineSkeletonAnimationComponent uspineSkeletonAnimationComponent = kscEntity.GetComponentByClass(USpineSkeletonAnimationComponent.StaticClass()) as USpineSkeletonAnimationComponent;
			if (uspineSkeletonAnimationComponent != null && uspineSkeletonAnimationComponent.IsValid())
			{
				uspineSkeletonAnimationComponent.SetComponentTickEnabled(enabled);
				if (enabled)
				{
					uspineSkeletonAnimationComponent.SetTickableWhenPaused(false);
				}
			}
			USpineSkeletonRendererComponent uspineSkeletonRendererComponent = kscEntity.GetComponentByClass(USpineSkeletonRendererComponent.StaticClass()) as USpineSkeletonRendererComponent;
			if (uspineSkeletonRendererComponent != null && uspineSkeletonRendererComponent.IsValid())
			{
				uspineSkeletonRendererComponent.SetComponentTickEnabled(enabled);
				if (enabled)
				{
					uspineSkeletonRendererComponent.SetTickableWhenPaused(false);
				}
			}
		}

		// Token: 0x060458DD RID: 284893 RVA: 0x0114414C File Offset: 0x0114234C
		public void OnAllCurWaveMachineSpawned()
		{
			foreach (AKSC_Entity aksc_Entity in this.GetModel().CurWaveMachineTracker.SpawnedEntities)
			{
				USpineSkeletonAnimationComponent uspineSkeletonAnimationComponent = aksc_Entity.GetComponentByClass(USpineSkeletonAnimationComponent.StaticClass()) as USpineSkeletonAnimationComponent;
				if (uspineSkeletonAnimationComponent != null && uspineSkeletonAnimationComponent.IsValid() && aksc_Entity.ActorHasTag(FNameUtil.GetDynamicFName("SyncAnim").Value))
				{
					uspineSkeletonAnimationComponent.SetAnimation(0, "Stand01", true);
				}
			}
		}

		// Token: 0x060458DE RID: 284894 RVA: 0x011441EC File Offset: 0x011423EC
		public void ClearGame(bool exitCamera = false)
		{
			this.ClearAllBullets();
			UKSC_Shape2D_World shapeWorld = this.ShapeWorld;
			if (shapeWorld != null)
			{
				shapeWorld.SetGameEnd();
			}
			foreach (AKSC_Shape2D_Entity_Player aksc_Shape2D_Entity_Player in this.KscPlayerEntities)
			{
				if (aksc_Shape2D_Entity_Player != null)
				{
					aksc_Shape2D_Entity_Player.SetEntityActive(false);
				}
			}
			this.EntityRedirectFilter.PreReset();
			if (exitCamera)
			{
				this.ExitFixCamera();
			}
		}

		// Token: 0x04024470 RID: 148592
		[Nullable(2)]
		private static int[] PlayerEntityKeys;

		// Token: 0x04024471 RID: 148593
		[Nullable(2)]
		private static Stat UpdateStat;

		// Token: 0x04024472 RID: 148594
		public static bool EnableSpineParallelUpdate;

		// Token: 0x04024473 RID: 148595
		public static bool EnableSpineShadow;

		// Token: 0x04024474 RID: 148596
		public const int PINBALL_TEAM_PLAYER_ENTITY_KEY = 10001;

		// Token: 0x04024475 RID: 148597
		private const int TEAM_PLAYER_ATTR_ID = 1001;

		// Token: 0x04024476 RID: 148598
		private const int MAX_FORMATION_ROLES = 3;

		// Token: 0x04024477 RID: 148599
		private const float BASE_ASPECT_RATIO = 1.7777778f;

		// Token: 0x04024478 RID: 148600
		private const string SCENE_BG_ACTOR_TAG = "Background";

		// Token: 0x04024479 RID: 148601
		private const string BG_MAT_TEX_PARAM_NAME = "Background";

		// Token: 0x0402447A RID: 148602
		private const int GAME_SYNC_INTERVAL = 10000;

		// Token: 0x0402447B RID: 148603
		private const int GAME_SYNC_REJECT_TIME = 5000;

		// Token: 0x0402447C RID: 148604
		private const int LAUNCH_WAY_SPLINE_ID = 319850000;

		// Token: 0x0402447D RID: 148605
		private FVectorDouble EntityHidePosition = new FVectorDouble(0.0, 0.0, 0.0);

		// Token: 0x0402447E RID: 148606
		private const string FORCE_SHOW_CURSOR_TAG = "PinballBattleInstanceForceShowCursor";

		// Token: 0x0402447F RID: 148607
		private const int DASH_SKILL_INDEX = 1;

		// Token: 0x04024480 RID: 148608
		private const int MAIN_SKILL_INDEX = 0;

		// Token: 0x04024481 RID: 148609
		private const int DEATHRATTLE_ADD_BUFF_TYPE = 2;

		// Token: 0x04024482 RID: 148610
		private const int EFFECT_TYPE_ALLY = 1;

		// Token: 0x04024483 RID: 148611
		private const int EFFECT_TYPE_ENEMY = 2;

		// Token: 0x04024484 RID: 148612
		private const int ROLE_ID_FEIXUE = 80850019;

		// Token: 0x04024485 RID: 148613
		private readonly PinballBattlePlayerHpHandle PlayerHpHandle = new PinballBattlePlayerHpHandle();

		// Token: 0x04024486 RID: 148614
		private readonly PinballBattleEntityRedirectFilter EntityRedirectFilter = new PinballBattleEntityRedirectFilter();

		// Token: 0x04024487 RID: 148615
		private int CreatureIdCounter;

		// Token: 0x04024488 RID: 148616
		[Nullable(2)]
		private UKSC_Shape2D_World ShapeWorld;

		// Token: 0x04024489 RID: 148617
		[Nullable(2)]
		private AKSC_Shape2D_Entity_Bar KscEntityLeftBar;

		// Token: 0x0402448A RID: 148618
		[Nullable(2)]
		private AKSC_Shape2D_Entity_Bar KscEntityRightBar;

		// Token: 0x0402448B RID: 148619
		[Nullable(2)]
		private BP_Fever_Bar_C FeverBar;

		// Token: 0x0402448C RID: 148620
		[Nullable(2)]
		private PinballBattleFeverBarController FeverBarController;

		// Token: 0x0402448D RID: 148621
		[Nullable(2)]
		private PinballBattlePlayerBarController LeftBarController;

		// Token: 0x0402448E RID: 148622
		[Nullable(2)]
		private PinballBattlePlayerBarController RightBarController;

		// Token: 0x0402448F RID: 148623
		private float GroundPositionZ;

		// Token: 0x04024490 RID: 148624
		private global::Vector WorldOrigin = global::Vector.Create();

		// Token: 0x04024491 RID: 148625
		private global::Transform WorldOriginTransform = global::Transform.Create();

		// Token: 0x04024492 RID: 148626
		private global::Transform BornTransform = global::Transform.Create();

		// Token: 0x04024493 RID: 148627
		private global::Vector InitLocation = global::Vector.Create();

		// Token: 0x04024494 RID: 148628
		private bool IsShapeWorldReady;

		// Token: 0x04024495 RID: 148629
		private bool IsInFixCamera;

		// Token: 0x04024496 RID: 148630
		private bool IsInitShapeWorld;

		// Token: 0x04024497 RID: 148631
		private bool IsPreloadFinish;

		// Token: 0x04024498 RID: 148632
		private bool IsMapLoadFinish;

		// Token: 0x04024499 RID: 148633
		[Nullable(2)]
		public AKSC_Shape2D_Entity_TeamPlayer KscTeamPlayer;

		// Token: 0x0402449A RID: 148634
		private int[] KscPlayerEntityIds = Array.Empty<int>();

		// Token: 0x0402449B RID: 148635
		private AKSC_Shape2D_Entity_Player[] KscPlayerEntities = Array.Empty<AKSC_Shape2D_Entity_Player>();

		// Token: 0x0402449C RID: 148636
		private int KscPlayerInitCount;

		// Token: 0x0402449D RID: 148637
		private bool IsFormationDataReady;

		// Token: 0x0402449E RID: 148638
		private bool IsInitKscPlayerEntities;

		// Token: 0x0402449F RID: 148639
		private bool NeedSendLaunchRequest;

		// Token: 0x040244A0 RID: 148640
		[Nullable(2)]
		private TMap<int, int> DamageInfo;

		// Token: 0x040244A1 RID: 148641
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKSC_Shape2D_DamageTotalInfo> DamageTotalInfo;

		// Token: 0x040244A2 RID: 148642
		private bool IsFirstLaunch;

		// Token: 0x040244A3 RID: 148643
		[Nullable(2)]
		private FOnWorldUpdateOnce WorldUpdateOnceDelegateRef;

		// Token: 0x040244A4 RID: 148644
		[Nullable(2)]
		private FOnKSCEntitySummon KscEntitySummonDelegateRef;

		// Token: 0x040244A5 RID: 148645
		[Nullable(2)]
		private FOnRelaunchPlayer RelaunchPlayerDelegateRef;

		// Token: 0x040244A6 RID: 148646
		[Nullable(2)]
		private FOnTeamAllDead TeamAllDeadDelegateRef;

		// Token: 0x040244A7 RID: 148647
		[Nullable(2)]
		private HashSet<int> PendingLoadBuffs;

		// Token: 0x040244A8 RID: 148648
		private int CachedShowFlagTonemapper;

		// Token: 0x040244A9 RID: 148649
		private int CachedScreenSizeCullRatioFactor;

		// Token: 0x040244AA RID: 148650
		private int CachedAntiAliasing;

		// Token: 0x040244AB RID: 148651
		[Nullable(2)]
		private UMaterialInstanceDynamic BgDynamicMat;

		// Token: 0x040244AC RID: 148652
		[Nullable(2)]
		private UMaterialInstance FeverBarMaterial;

		// Token: 0x040244AD RID: 148653
		[Nullable(2)]
		private TimerHandle PayloadSyncTimerHandle;

		// Token: 0x040244AE RID: 148654
		private double LastSyncRealTimeMs;

		// Token: 0x040244AF RID: 148655
		[Nullable(2)]
		private UCurveFloat LaunchSpeedCurve;

		// Token: 0x040244B0 RID: 148656
		[Nullable(2)]
		private UCurveFloat LaunchDegCurve;

		// Token: 0x040244B1 RID: 148657
		[Nullable(2)]
		private UiPanelBase LaunchBallItem;

		// Token: 0x040244B2 RID: 148658
		[Nullable(2)]
		private PinballBattleLaunchDirectionItem LaunchDirectionItem;

		// Token: 0x040244B3 RID: 148659
		[Nullable(2)]
		private PinballBattleLaunchDirectionController LaunchDirectionController;

		// Token: 0x040244B4 RID: 148660
		private bool AlreadyRequestBonusWin;

		// Token: 0x040244B5 RID: 148661
		[Nullable(2)]
		private CustomPromise CanRequestSettlePromise;

		// Token: 0x040244B6 RID: 148662
		[Nullable(2)]
		private CustomPromise CanOpenSettleResultPromise;

		// Token: 0x040244B7 RID: 148663
		private float BaseFov;

		// Token: 0x040244B8 RID: 148664
		[Nullable(2)]
		public PinballBattleLaunchPhaseController LaunchPhaseController;

		// Token: 0x040244B9 RID: 148665
		private readonly List<Delegate> RoleSkillDelegateList = new List<Delegate>();

		// Token: 0x040244BA RID: 148666
		private readonly List<Delegate> PlayerStateChangeDelegateList = new List<Delegate>();

		// Token: 0x040244BB RID: 148667
		[Nullable(2)]
		private FOnShape2DSkillStateChange BossSkillStateChangeDelegate;

		// Token: 0x040244BC RID: 148668
		[Nullable(2)]
		private TimerHandle AutoLaunchTimer;

		// Token: 0x0200CDBA RID: 52666
		[NullableContext(0)]
		private class AlwaysShowCursor : IExtraShowCursor
		{
			// Token: 0x06051CD2 RID: 335058 RVA: 0x01637450 File Offset: 0x01635650
			public bool IsShowCursor()
			{
				return true;
			}
		}
	}
}
