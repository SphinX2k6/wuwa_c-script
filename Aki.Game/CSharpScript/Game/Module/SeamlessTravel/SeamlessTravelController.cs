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
	// Token: 0x02004C84 RID: 19588
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class SeamlessTravelController : ControllerBase
	{
		// Token: 0x06032A0F RID: 207375 RVA: 0x00BCD620 File Offset: 0x00BCB820
		protected override bool OnInit()
		{
			EventSystem.Instance.Add(EEventName.OnEnterTransitionMap, this.EnterTransitionMap);
			EventSystem.Instance.Add(EEventName.EndTravelMap, this.EnterDestinationMap);
			base.PauseTick();
			return true;
		}

		// Token: 0x06032A10 RID: 207376 RVA: 0x00BCD655 File Offset: 0x00BCB855
		protected override bool OnClear()
		{
			EventSystem.Instance.Remove(EEventName.OnEnterTransitionMap, this.EnterTransitionMap);
			EventSystem.Instance.Remove(EEventName.EndTravelMap, this.EnterDestinationMap);
			return true;
		}

		// Token: 0x06032A11 RID: 207377 RVA: 0x00BCD684 File Offset: 0x00BCB884
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

		// Token: 0x06032A12 RID: 207378 RVA: 0x00BCD734 File Offset: 0x00BCB934
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

		// Token: 0x06032A13 RID: 207379 RVA: 0x00BCD7F8 File Offset: 0x00BCB9F8
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

		// Token: 0x06032A14 RID: 207380 RVA: 0x00BCD84C File Offset: 0x00BCBA4C
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

		// Token: 0x06032A15 RID: 207381 RVA: 0x00BCD97F File Offset: 0x00BCBB7F
		[NullableContext(2)]
		public void AddSeamlessTravelActor(AActor actor)
		{
			SeamlessTravelModel.Instance.AddSeamlessTravelActor(actor);
		}

		// Token: 0x06032A16 RID: 207382 RVA: 0x00BCD990 File Offset: 0x00BCBB90
		public UniTask PreLeaveLevel()
		{
			SeamlessTravelController.<PreLeaveLevel>d__7 <PreLeaveLevel>d__;
			<PreLeaveLevel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreLeaveLevel>d__.<>4__this = this;
			<PreLeaveLevel>d__.<>1__state = -1;
			<PreLeaveLevel>d__.<>t__builder.Start<SeamlessTravelController.<PreLeaveLevel>d__7>(ref <PreLeaveLevel>d__);
			return <PreLeaveLevel>d__.<>t__builder.Task;
		}

		// Token: 0x06032A17 RID: 207383 RVA: 0x00BCD9D4 File Offset: 0x00BCBBD4
		public UniTask PreLeaveLevelWaitEnd()
		{
			SeamlessTravelController.<PreLeaveLevelWaitEnd>d__8 <PreLeaveLevelWaitEnd>d__;
			<PreLeaveLevelWaitEnd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreLeaveLevelWaitEnd>d__.<>4__this = this;
			<PreLeaveLevelWaitEnd>d__.<>1__state = -1;
			<PreLeaveLevelWaitEnd>d__.<>t__builder.Start<SeamlessTravelController.<PreLeaveLevelWaitEnd>d__8>(ref <PreLeaveLevelWaitEnd>d__);
			return <PreLeaveLevelWaitEnd>d__.<>t__builder.Task;
		}

		// Token: 0x06032A18 RID: 207384 RVA: 0x00BCDA18 File Offset: 0x00BCBC18
		public void PostLeaveLevel()
		{
			if (!SeamlessTravelModel.Instance.IsSeamlessTravel)
			{
				return;
			}
			Log.Instance.Info(ELogModule.SeamlessTravel, ELogAuthor.CJH, "[无缝加载:PostLeaveLevel完成]", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06032A19 RID: 207385 RVA: 0x00BCDA51 File Offset: 0x00BCBC51
		public bool PreOpenLevel()
		{
			return true;
		}

		// Token: 0x06032A1A RID: 207386 RVA: 0x00BCDA54 File Offset: 0x00BCBC54
		[NullableContext(0)]
		public UniTask<bool> PostOpenLevel()
		{
			SeamlessTravelController.<PostOpenLevel>d__11 <PostOpenLevel>d__;
			<PostOpenLevel>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PostOpenLevel>d__.<>1__state = -1;
			<PostOpenLevel>d__.<>t__builder.Start<SeamlessTravelController.<PostOpenLevel>d__11>(ref <PostOpenLevel>d__);
			return <PostOpenLevel>d__.<>t__builder.Task;
		}

		// Token: 0x06032A1B RID: 207387 RVA: 0x00BCDA90 File Offset: 0x00BCBC90
		public void PostLoadedLevel()
		{
			if (!SeamlessTravelModel.Instance.IsSeamlessTravel)
			{
				return;
			}
			Log.Instance.Info(ELogModule.SeamlessTravel, ELogAuthor.CJH, "[无缝加载:PostLoadedLevel完成]", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06032A1C RID: 207388 RVA: 0x00BCDACC File Offset: 0x00BCBCCC
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

		// Token: 0x06032A1D RID: 207389 RVA: 0x00BCDC84 File Offset: 0x00BCBE84
		public UniTask EndSeamlessTravel()
		{
			SeamlessTravelController.<EndSeamlessTravel>d__14 <EndSeamlessTravel>d__;
			<EndSeamlessTravel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EndSeamlessTravel>d__.<>4__this = this;
			<EndSeamlessTravel>d__.<>1__state = -1;
			<EndSeamlessTravel>d__.<>t__builder.Start<SeamlessTravelController.<EndSeamlessTravel>d__14>(ref <EndSeamlessTravel>d__);
			return <EndSeamlessTravel>d__.<>t__builder.Task;
		}

		// Token: 0x06032A1E RID: 207390 RVA: 0x00BCDCC8 File Offset: 0x00BCBEC8
		public UniTask EndSeamlessTravelWaitEnd()
		{
			SeamlessTravelController.<EndSeamlessTravelWaitEnd>d__15 <EndSeamlessTravelWaitEnd>d__;
			<EndSeamlessTravelWaitEnd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EndSeamlessTravelWaitEnd>d__.<>1__state = -1;
			<EndSeamlessTravelWaitEnd>d__.<>t__builder.Start<SeamlessTravelController.<EndSeamlessTravelWaitEnd>d__15>(ref <EndSeamlessTravelWaitEnd>d__);
			return <EndSeamlessTravelWaitEnd>d__.<>t__builder.Task;
		}

		// Token: 0x06032A1F RID: 207391 RVA: 0x00BCDD04 File Offset: 0x00BCBF04
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

		// Token: 0x06032A20 RID: 207392 RVA: 0x00BCDF5C File Offset: 0x00BCC15C
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

		// Token: 0x06032A21 RID: 207393 RVA: 0x00BCDFA0 File Offset: 0x00BCC1A0
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

		// Token: 0x06032A22 RID: 207394 RVA: 0x00BCE060 File Offset: 0x00BCC260
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

		// Token: 0x17007CF4 RID: 31988
		// (get) Token: 0x06032A23 RID: 207395 RVA: 0x00BCE083 File Offset: 0x00BCC283
		public static SeamlessTravelController Instance
		{
			get
			{
				return SeamlessTravelController._Instance;
			}
		}

		// Token: 0x06032A24 RID: 207396 RVA: 0x00BCE08A File Offset: 0x00BCC28A
		public static SeamlessTravelController GetOrCreateInstance()
		{
			if (SeamlessTravelController._Instance == null)
			{
				SeamlessTravelController.CreateInstance();
			}
			return SeamlessTravelController._Instance;
		}

		// Token: 0x06032A25 RID: 207397 RVA: 0x00BCE09E File Offset: 0x00BCC29E
		public static bool CreateInstance()
		{
			if (SeamlessTravelController._Instance != null)
			{
				return true;
			}
			SeamlessTravelController._Instance = new SeamlessTravelController();
			return true;
		}

		// Token: 0x06032A26 RID: 207398 RVA: 0x00BCE0B4 File Offset: 0x00BCC2B4
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06032A27 RID: 207399 RVA: 0x00BCE0B6 File Offset: 0x00BCC2B6
		public static void ResetStaticDefaultValue()
		{
			SeamlessTravelController._Instance = null;
		}

		// Token: 0x06032A28 RID: 207400 RVA: 0x00BCE0BE File Offset: 0x00BCC2BE
		static SeamlessTravelController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SeamlessTravelController.CreateStaticDefaultValue), new Action(SeamlessTravelController.ResetStaticDefaultValue));
		}

		// Token: 0x0401AEE7 RID: 110311
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

		// Token: 0x0401AEE8 RID: 110312
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

		// Token: 0x0401AEE9 RID: 110313
		[Nullable(2)]
		private static SeamlessTravelController _Instance;
	}
}
