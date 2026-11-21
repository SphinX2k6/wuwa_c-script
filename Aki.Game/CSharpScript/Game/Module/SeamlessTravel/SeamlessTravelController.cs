using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SeamlessTravel
{
	// Token: 0x02003C35 RID: 15413
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class SeamlessTravelController : ControllerBase
	{
		// Token: 0x060277C2 RID: 161730 RVA: 0x00B12284 File Offset: 0x00B10484
		protected override bool OnInit()
		{
			EventSystem.Instance.Add(EEventName.OnEnterTransitionMap, this.EnterTransitionMap);
			EventSystem.Instance.Add(EEventName.EndTravelMap, this.EnterDestinationMap);
			base.PauseTick();
			return true;
		}

		// Token: 0x060277C3 RID: 161731 RVA: 0x00B122B9 File Offset: 0x00B104B9
		protected override bool OnClear()
		{
			EventSystem.Instance.Remove(EEventName.OnEnterTransitionMap, this.EnterTransitionMap);
			EventSystem.Instance.Remove(EEventName.EndTravelMap, this.EnterDestinationMap);
			return true;
		}

		// Token: 0x060277C4 RID: 161732 RVA: 0x00B122E8 File Offset: 0x00B104E8
		protected override void OnTick(float delta)
		{
			SeamlessTravelModel instance = SeamlessTravelModel.Instance;
			if (((instance != null) ? instance.SeamlessTravelTreadmill : null) != null)
			{
				SeamlessTravelModel instance2 = SeamlessTravelModel.Instance;
				if (instance2 != null)
				{
					instance2.SeamlessTravelTreadmill.Tick(delta);
				}
			}
			SeamlessTravelModel instance3 = SeamlessTravelModel.Instance;
			if (((instance3 != null) ? instance3.SeamlessTravelKeepKite : null) != null)
			{
				SeamlessTravelModel instance4 = SeamlessTravelModel.Instance;
				if (instance4 != null)
				{
					instance4.SeamlessTravelKeepKite.Tick(delta);
				}
			}
			SeamlessTravelModel instance5 = SeamlessTravelModel.Instance;
			if (((instance5 != null) ? instance5.SeamlessTravelKeepMovementMode : null) != null)
			{
				SeamlessTravelModel instance6 = SeamlessTravelModel.Instance;
				if (instance6 != null)
				{
					instance6.SeamlessTravelKeepMovementMode.Tick(delta);
				}
			}
			SeamlessTravelModel instance7 = SeamlessTravelModel.Instance;
			if (((instance7 != null) ? instance7.SeamlessTravelPostProcess : null) != null)
			{
				SeamlessTravelModel instance8 = SeamlessTravelModel.Instance;
				if (instance8 == null)
				{
					return;
				}
				instance8.SeamlessTravelPostProcess.Tick(delta);
			}
		}

		// Token: 0x060277C5 RID: 161733 RVA: 0x00B12398 File Offset: 0x00B10598
		public bool StartTravel(string levelName)
		{
			if (!SeamlessTravelModel.Instance.IsSeamlessTravel)
			{
				return false;
			}
			APlayerController seamlessTravelController = SeamlessTravelModel.Instance.SeamlessTravelController;
			if (seamlessTravelController == null || !seamlessTravelController.IsValid())
			{
				Log.Instance.Error(ELogModule.SeamlessTravel, ELogAuthor.CJH, "[无缝加载:失败]PlayerController无效", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			Log.Instance.Info(ELogModule.SeamlessTravel, ELogAuthor.CJH, "[无缝加载:开始]", default(ReadOnlySpan<ValueTuple<string, object>>));
			LoadModeManager.Instance.SetLoadModeByReason(ELoadMode.ForceInGame, ELoadModeReason.SeamlessTravel);
			SeamlessTravelModel.Instance.InSeamlessTraveling = true;
			if (SeamlessTravelModel.Instance.SeamlessEndHandle != null)
			{
				TimerSystem.Instance.Remove(SeamlessTravelModel.Instance.SeamlessEndHandle);
				SeamlessTravelModel.Instance.SeamlessEndHandle = null;
			}
			WorldGlobal.PlayerClientTravel(seamlessTravelController, levelName);
			return true;
		}

		// Token: 0x060277C6 RID: 161734 RVA: 0x00B1245C File Offset: 0x00B1065C
		[NullableContext(0)]
		public UniTask<bool> EnableSeamlessTravel([Nullable(1)] SeamlessTravelContext context, bool isPreEnable = false)
		{
			SeamlessTravelController.<EnableSeamlessTravel>d__4 <EnableSeamlessTravel>d__;
			<EnableSeamlessTravel>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<EnableSeamlessTravel>d__.<>4__this = this;
			<EnableSeamlessTravel>d__.context = context;
			<EnableSeamlessTravel>d__.isPreEnable = isPreEnable;
			<EnableSeamlessTravel>d__.<>1__state = -1;
			<EnableSeamlessTravel>d__.<>t__builder.Start<SeamlessTravelController.<EnableSeamlessTravel>d__4>(ref <EnableSeamlessTravel>d__);
			return <EnableSeamlessTravel>d__.<>t__builder.Task;
		}

		// Token: 0x060277C7 RID: 161735 RVA: 0x00B124B0 File Offset: 0x00B106B0
		private void SetupSeamlessTravelEntity(EntityHandle entityHandle)
		{
			SeamlessTravelModel instance = SeamlessTravelModel.Instance;
			BaseActorComponent component = entityHandle.Entity.GetComponent<BaseActorComponent>();
			if (((component != null) ? component.Owner : null) == null || SeamlessTravelModel.Instance.IsSeamlessTravelActor(component.Owner))
			{
				return;
			}
			this.AddSeamlessTravelActor(component.Owner);
			instance.SeamlessTravelPlayerTeamHandles.Add(entityHandle);
			TArray<UActorComponent> tarray = component.Owner.K2_GetComponentsByClass(USkeletalMeshComponent.StaticClass());
			int num = tarray.Num();
			for (int i = 0; i < num; i++)
			{
				UActorComponent uactorComponent = tarray.Get(i);
				if (uactorComponent is USkeletalMeshComponent)
				{
					uactorComponent.PrimaryComponentTick.bStartWithTickEnabled = false;
				}
			}
			EEntityType? eentityType = (component != null) ? new EEntityType?(component.CreatureData.GetEntityType()) : null;
			if (eentityType.GetValueOrDefault() != EEntityType.SceneItem)
			{
				if (eentityType.GetValueOrDefault() == EEntityType.Monster)
				{
					CharacterAiComponent component2 = entityHandle.Entity.GetComponent<CharacterAiComponent>();
					instance.SeamlessTravelTeamDefaultController.Add(component2.TsAiController);
					this.AddSeamlessTravelActor(component2.TsAiController);
					return;
				}
				CharacterActorComponent component3 = entityHandle.Entity.GetComponent<CharacterActorComponent>();
				instance.SeamlessTravelTeamDefaultController.Add(component3.DefaultController);
				this.AddSeamlessTravelActor(component3.DefaultController);
			}
		}

		// Token: 0x060277C8 RID: 161736 RVA: 0x00B125E3 File Offset: 0x00B107E3
		[NullableContext(2)]
		public void AddSeamlessTravelActor(AActor actor)
		{
			SeamlessTravelModel.Instance.AddSeamlessTravelActor(actor);
		}

		// Token: 0x060277C9 RID: 161737 RVA: 0x00B125F4 File Offset: 0x00B107F4
		public UniTask PreLeaveLevel()
		{
			SeamlessTravelController.<PreLeaveLevel>d__7 <PreLeaveLevel>d__;
			<PreLeaveLevel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreLeaveLevel>d__.<>4__this = this;
			<PreLeaveLevel>d__.<>1__state = -1;
			<PreLeaveLevel>d__.<>t__builder.Start<SeamlessTravelController.<PreLeaveLevel>d__7>(ref <PreLeaveLevel>d__);
			return <PreLeaveLevel>d__.<>t__builder.Task;
		}

		// Token: 0x060277CA RID: 161738 RVA: 0x00B12638 File Offset: 0x00B10838
		public UniTask PreLeaveLevelWaitEnd()
		{
			SeamlessTravelController.<PreLeaveLevelWaitEnd>d__8 <PreLeaveLevelWaitEnd>d__;
			<PreLeaveLevelWaitEnd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreLeaveLevelWaitEnd>d__.<>4__this = this;
			<PreLeaveLevelWaitEnd>d__.<>1__state = -1;
			<PreLeaveLevelWaitEnd>d__.<>t__builder.Start<SeamlessTravelController.<PreLeaveLevelWaitEnd>d__8>(ref <PreLeaveLevelWaitEnd>d__);
			return <PreLeaveLevelWaitEnd>d__.<>t__builder.Task;
		}

		// Token: 0x060277CB RID: 161739 RVA: 0x00B1267C File Offset: 0x00B1087C
		public void PostLeaveLevel()
		{
			if (!SeamlessTravelModel.Instance.IsSeamlessTravel)
			{
				return;
			}
			Log.Instance.Info(ELogModule.SeamlessTravel, ELogAuthor.CJH, "[无缝加载:PostLeaveLevel完成]", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060277CC RID: 161740 RVA: 0x00B126B5 File Offset: 0x00B108B5
		public bool PreOpenLevel()
		{
			return true;
		}

		// Token: 0x060277CD RID: 161741 RVA: 0x00B126B8 File Offset: 0x00B108B8
		[NullableContext(0)]
		public UniTask<bool> PostOpenLevel()
		{
			SeamlessTravelController.<PostOpenLevel>d__11 <PostOpenLevel>d__;
			<PostOpenLevel>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PostOpenLevel>d__.<>1__state = -1;
			<PostOpenLevel>d__.<>t__builder.Start<SeamlessTravelController.<PostOpenLevel>d__11>(ref <PostOpenLevel>d__);
			return <PostOpenLevel>d__.<>t__builder.Task;
		}

		// Token: 0x060277CE RID: 161742 RVA: 0x00B126F4 File Offset: 0x00B108F4
		public void PostLoadedLevel()
		{
			if (!SeamlessTravelModel.Instance.IsSeamlessTravel)
			{
				return;
			}
			Log.Instance.Info(ELogModule.SeamlessTravel, ELogAuthor.CJH, "[无缝加载:PostLoadedLevel完成]", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060277CF RID: 161743 RVA: 0x00B12730 File Offset: 0x00B10930
		public bool SetCurrentEntityAction(InstanceDungeon config)
		{
			if (!SeamlessTravelModel.Instance.IsSeamlessTravel)
			{
				return false;
			}
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (((baseCharacter != null) ? baseCharacter.CharacterActorComponent : null) == null)
			{
				return false;
			}
			CharacterActorComponent characterActorComponent = Global.BaseCharacter.CharacterActorComponent;
			global::Vector commonTempVector = MathUtils.Instance.CommonTempVector;
			global::Vector vector = commonTempVector;
			FVectorDouble location = characterActorComponent.CreatureData.GetLocation();
			vector.DeepCopy(location);
			global::Rotator rotator = global::Rotator.Create((float)config.GetBornRotationArray()[0], (float)config.GetBornRotationArray()[2], (float)config.GetBornRotationArray()[1]);
			float num = rotator.Yaw - characterActorComponent.ActorRotationProxy.Yaw;
			characterActorComponent.SetInputRotator(rotator);
			SeamlessTravelModel instance = SeamlessTravelModel.Instance;
			if (instance != null && instance.UseKeepMovementMode)
			{
				characterActorComponent.TeleportTo(commonTempVector.ToUeVector(false), rotator.ToUeRotator(), "[无缝加载SetCurrentEntityAction:传送玩家(不贴地修正)]");
			}
			else
			{
				characterActorComponent.TeleportAndFindStandLocation(commonTempVector, true);
				characterActorComponent.SetActorRotation(rotator.ToUeRotator(), "[无缝加载SetCurrentEntityAction:修正朝向]", false);
			}
			global::Vector vector2 = global::Vector.Create();
			global::Rotator.Create(0f, num, 0f).Quaternion(null).RotateVector(characterActorComponent.ActorVelocityProxy, vector2);
			characterActorComponent.MoveComp.SetForceSpeed(vector2);
			global::Rotator cameraRotation = CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraRotation;
			float inYaw = MathUtils.Instance.WrapAngle(cameraRotation.Yaw + num);
			FRotator rotation = new FRotator(cameraRotation.Pitch, inYaw, cameraRotation.Roll);
			CameraController.Instance.MainModel.FightCamera.LogicComponent.SetRotation(rotation);
			CameraController.Instance.MainModel.FightCamera.LogicComponent.ResetFightCameraLogic(false, true);
			Log.Instance.Info(ELogModule.SeamlessTravel, ELogAuthor.YJX, "[无缝加载:修正到目标位置和朝向]", default(ReadOnlySpan<ValueTuple<string, object>>));
			return true;
		}

		// Token: 0x060277D0 RID: 161744 RVA: 0x00B128E8 File Offset: 0x00B10AE8
		public UniTask EndSeamlessTravel()
		{
			SeamlessTravelController.<EndSeamlessTravel>d__14 <EndSeamlessTravel>d__;
			<EndSeamlessTravel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EndSeamlessTravel>d__.<>4__this = this;
			<EndSeamlessTravel>d__.<>1__state = -1;
			<EndSeamlessTravel>d__.<>t__builder.Start<SeamlessTravelController.<EndSeamlessTravel>d__14>(ref <EndSeamlessTravel>d__);
			return <EndSeamlessTravel>d__.<>t__builder.Task;
		}

		// Token: 0x060277D1 RID: 161745 RVA: 0x00B1292C File Offset: 0x00B10B2C
		public UniTask EndSeamlessTravelWaitEnd()
		{
			SeamlessTravelController.<EndSeamlessTravelWaitEnd>d__15 <EndSeamlessTravelWaitEnd>d__;
			<EndSeamlessTravelWaitEnd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EndSeamlessTravelWaitEnd>d__.<>1__state = -1;
			<EndSeamlessTravelWaitEnd>d__.<>t__builder.Start<SeamlessTravelController.<EndSeamlessTravelWaitEnd>d__15>(ref <EndSeamlessTravelWaitEnd>d__);
			return <EndSeamlessTravelWaitEnd>d__.<>t__builder.Task;
		}

		// Token: 0x060277D2 RID: 161746 RVA: 0x00B12968 File Offset: 0x00B10B68
		public void FinishSeamlessTravel()
		{
			SeamlessTravelModel instance = SeamlessTravelModel.Instance;
			if (instance != null)
			{
				List<EntityHandle> seamlessTravelPlayerTeamHandles = instance.SeamlessTravelPlayerTeamHandles;
				int? num = (seamlessTravelPlayerTeamHandles != null) ? new int?(seamlessTravelPlayerTeamHandles.Count) : null;
				int num2 = 0;
				if (num.GetValueOrDefault() == num2 & num != null)
				{
					return;
				}
			}
			foreach (EntityHandle entityHandle in instance.SeamlessTravelPlayerTeamHandles)
			{
				WorldEntity entity = entityHandle.Entity;
				TArray<UActorComponent> tarray = ((entity != null) ? entity.GetComponent<CharacterActorComponent>().Actor : null).K2_GetComponentsByClass(USkeletalMeshComponent.StaticClass());
				int num3 = tarray.Num();
				for (int i = 0; i < num3; i++)
				{
					UActorComponent uactorComponent = tarray.Get(i);
					if (uactorComponent is USkeletalMeshComponent)
					{
						uactorComponent.PrimaryComponentTick.bStartWithTickEnabled = true;
					}
				}
			}
			instance.SeamlessEndHandle = null;
			instance.SeamlessTravelPlayerTeamHandles.Clear();
			instance.SeamlessTravelController.bUseSeamlessCameraActor = false;
			instance.SeamlessTravelController.SeamlessCameraActor = null;
			instance.SeamlessTravelController = null;
			instance.SeamlessTravelTeamDefaultController.Clear();
			instance.SeamlessTravelCamera = null;
			SeamlessTravelScreenEffect seamlessTravelScreenEffect = instance.SeamlessTravelScreenEffect;
			if (seamlessTravelScreenEffect != null)
			{
				seamlessTravelScreenEffect.Destroy();
			}
			instance.SeamlessTravelScreenEffect = null;
			SeamlessTravelTreadmill seamlessTravelTreadmill = instance.SeamlessTravelTreadmill;
			if (seamlessTravelTreadmill != null)
			{
				seamlessTravelTreadmill.Destroy();
			}
			instance.SeamlessTravelTreadmill = null;
			SeamlessTravelKeepKite seamlessTravelKeepKite = instance.SeamlessTravelKeepKite;
			if (seamlessTravelKeepKite != null)
			{
				seamlessTravelKeepKite.Destroy();
			}
			instance.SeamlessTravelKeepKite = null;
			SeamlessTravelKeepMovementMode seamlessTravelKeepMovementMode = instance.SeamlessTravelKeepMovementMode;
			if (seamlessTravelKeepMovementMode != null)
			{
				seamlessTravelKeepMovementMode.Destroy();
			}
			instance.SeamlessTravelKeepMovementMode = null;
			SeamlessTravelPostProcess seamlessTravelPostProcess = instance.SeamlessTravelPostProcess;
			if (seamlessTravelPostProcess != null)
			{
				seamlessTravelPostProcess.Destroy();
			}
			instance.SeamlessTravelPostProcess = null;
			SeamlessTravelSceneEffect seamlessTravelSceneEffect = instance.SeamlessTravelSceneEffect;
			if (seamlessTravelSceneEffect != null)
			{
				seamlessTravelSceneEffect.Destroy();
			}
			instance.SeamlessTravelSceneEffect = null;
			base.PauseTick();
			instance.Config = null;
			instance.HasPreEnableSeamlessTravel = false;
			instance.ClearPromise();
			instance.ClearSeamlessTravelActor();
			instance.SeamlessTravelInputDistributeTags.Clear();
			instance.InSeamlessTraveling = false;
			instance.IsSeamlessTravel = false;
			EventSystem.Instance.Emit(EEventName.SeamlessTravelUIRefresh);
			EventSystem.Instance.Emit(EEventName.SeamlessTravelFinishBeforeShowUI);
			BattleUiModel.Instance.ChildViewData.ShowBattleView(EBattleUiVisibleReason.Seamless, 0);
			InputDistributeController.Instance.RefreshInputTag();
			Log.Instance.Info(ELogModule.SeamlessTravel, ELogAuthor.YJX, "[无缝加载:完成]", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060277D3 RID: 161747 RVA: 0x00B12BC0 File Offset: 0x00B10DC0
		[NullableContext(2)]
		public bool WasRoleEntityInSeamlessTraveling(Entity entity)
		{
			if (entity == null)
			{
				return false;
			}
			SeamlessTravelModel instance = SeamlessTravelModel.Instance;
			if (instance == null || !instance.IsSeamlessTravel)
			{
				return false;
			}
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			return component != null && this.WasRoleInSeamlessTraveling(component.GetCreatureDataId());
		}

		// Token: 0x060277D4 RID: 161748 RVA: 0x00B12C04 File Offset: 0x00B10E04
		public bool WasRoleInSeamlessTraveling(long creatureDataId)
		{
			SeamlessTravelModel instance = SeamlessTravelModel.Instance;
			if (instance == null || !instance.IsSeamlessTravel)
			{
				return false;
			}
			foreach (EntityHandle entityHandle in instance.SeamlessTravelPlayerTeamHandles)
			{
				if (!entityHandle.Valid)
				{
					Log instance2 = Log.Instance;
					ELogModule module = ELogModule.SeamlessTravel;
					ELogAuthor author = ELogAuthor.YZ;
					string message = "[无缝加载:需要保留的实体被删除！]";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", entityHandle.Id);
					instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else if (entityHandle.Entity.GetComponent<CreatureDataComponent>().GetCreatureDataId() == creatureDataId)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060277D5 RID: 161749 RVA: 0x00B12CC4 File Offset: 0x00B10EC4
		public void SeamlessTravelingRefreshData(Entity entity)
		{
			BaseAttributeComponent component = entity.GetComponent<BaseAttributeComponent>();
			if (component != null)
			{
				component.SeamlessTravelingRefresh();
			}
			BaseBuffComponent component2 = entity.GetComponent<BaseBuffComponent>();
			if (component2 == null)
			{
				return;
			}
			component2.SeamlessTravelingRefresh();
		}

		// Token: 0x1700509E RID: 20638
		// (get) Token: 0x060277D6 RID: 161750 RVA: 0x00B12CE7 File Offset: 0x00B10EE7
		public static SeamlessTravelController Instance
		{
			get
			{
				return SeamlessTravelController._Instance;
			}
		}

		// Token: 0x060277D7 RID: 161751 RVA: 0x00B12CEE File Offset: 0x00B10EEE
		public static SeamlessTravelController GetOrCreateInstance()
		{
			if (SeamlessTravelController._Instance == null)
			{
				SeamlessTravelController.CreateInstance();
			}
			return SeamlessTravelController._Instance;
		}

		// Token: 0x060277D8 RID: 161752 RVA: 0x00B12D02 File Offset: 0x00B10F02
		public static bool CreateInstance()
		{
			if (SeamlessTravelController._Instance != null)
			{
				return true;
			}
			SeamlessTravelController._Instance = new SeamlessTravelController();
			return true;
		}

		// Token: 0x060277D9 RID: 161753 RVA: 0x00B12D18 File Offset: 0x00B10F18
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060277DA RID: 161754 RVA: 0x00B12D1A File Offset: 0x00B10F1A
		public static void ResetStaticDefaultValue()
		{
			SeamlessTravelController._Instance = null;
		}

		// Token: 0x060277DB RID: 161755 RVA: 0x00B12D22 File Offset: 0x00B10F22
		static SeamlessTravelController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SeamlessTravelController.CreateStaticDefaultValue), new Action(SeamlessTravelController.ResetStaticDefaultValue));
		}

		// Token: 0x04015844 RID: 88132
		private readonly Action EnterTransitionMap = delegate()
		{
			SeamlessTravelModel instance = SeamlessTravelModel.Instance;
			if (!instance.IsSeamlessTravel)
			{
				return;
			}
			GameModePromise enterTransitionMapPromise = instance.EnterTransitionMapPromise;
			if (enterTransitionMapPromise == null)
			{
				return;
			}
			enterTransitionMapPromise.SetResult(true);
		};

		// Token: 0x04015845 RID: 88133
		private readonly Action EnterDestinationMap = delegate()
		{
			SeamlessTravelModel seamlessTravelModel = SeamlessTravelModel.Instance;
			if (!seamlessTravelModel.IsSeamlessTravel)
			{
				return;
			}
			GameModePromise enterDestinationMapPromise = seamlessTravelModel.EnterDestinationMapPromise;
			if (enterDestinationMapPromise != null)
			{
				enterDestinationMapPromise.SetResult(true);
			}
			Log.Instance.Info(ELogModule.SeamlessTravel, ELogAuthor.YJX, "[无缝加载]进入目标地图并重新设置位置", default(ReadOnlySpan<ValueTuple<string, object>>));
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
			if (characterActorComponent == null)
			{
				return;
			}
			if (seamlessTravelModel.UseTreadmill)
			{
				global::Vector commonTempVector = MathUtils.Instance.CommonTempVector;
				global::Vector vector = commonTempVector;
				FVectorDouble location = characterActorComponent.CreatureData.GetLocation();
				vector.DeepCopy(location);
				SeamlessTravelContext config = seamlessTravelModel.Config;
				if (config == null || !config.IsTeleportInPlace)
				{
					commonTempVector.Z += 2000000.0;
				}
				seamlessTravelModel.SeamlessTravelTreadmill.ResetLockOnLocation(commonTempVector, null);
				characterActorComponent.TeleportAndFindStandLocation(MathUtils.Instance.CommonTempVector, true);
				CameraController.Instance.MainModel.FightCamera.LogicComponent.ResetFightCameraLogic(false, true);
				Log.Instance.Info(ELogModule.SeamlessTravel, ELogAuthor.YJX, "[无缝加载:地板隐形(开始)]", default(ReadOnlySpan<ValueTuple<string, object>>));
				seamlessTravelModel.SeamlessTravelTreadmill.DisappearEffect(delegate
				{
					Log.Instance.Info(ELogModule.SeamlessTravel, ELogAuthor.YJX, "[无缝加载:地板隐形(完成)]", default(ReadOnlySpan<ValueTuple<string, object>>));
					seamlessTravelModel.TransitionFloorUnloadedPromise.SetResult(true);
				});
			}
		};

		// Token: 0x04015846 RID: 88134
		[Nullable(2)]
		private static SeamlessTravelController _Instance;
	}
}
