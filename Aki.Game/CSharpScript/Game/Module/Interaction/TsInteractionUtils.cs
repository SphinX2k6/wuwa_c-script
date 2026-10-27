using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Data.Interaction.Struct;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.ResManager;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.NewWorld.Pawn.Controllers;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02005852 RID: 22610
	[NullableContext(1)]
	[Nullable(0)]
	public class TsInteractionUtils : IStaticVariableResetter
	{
		// Token: 0x0603978D RID: 235405 RVA: 0x00DA4948 File Offset: 0x00DA2B48
		static TsInteractionUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TsInteractionUtils.CreateStaticDefaultValue), new Action(TsInteractionUtils.ResetStaticDefaultValue));
		}

		// Token: 0x0603978E RID: 235406 RVA: 0x00DA4967 File Offset: 0x00DA2B67
		[return: Nullable(2)]
		public static SInteractionConfig GetInteractionConfig(string inRow)
		{
			return DataTableUtil.GetDataTableRowFromName<SInteractionConfig>(EDataTable.InteractionConfigs, inRow);
		}

		// Token: 0x0603978F RID: 235407 RVA: 0x00DA4974 File Offset: 0x00DA2B74
		public static void HandleInteractionOptionFromVision(CommonInteractOption option, PawnInteractController controller, int visionId)
		{
			if (option.OptionType != EOptionType.Normal)
			{
				return;
			}
			IInteractActions interactActions = option.Type as IInteractActions;
			if (interactActions == null || interactActions.Actions == null || interactActions.Actions.Count != 1)
			{
				return;
			}
			if (interactActions.Actions[0].Name.ToEnumString() != "Collect")
			{
				return;
			}
			CreatureDataComponent component = EntitySystem.Instance.GetComponent<CreatureDataComponent>(visionId);
			if (component == null)
			{
				return;
			}
			controller.HandleInteractRequest();
			int optionIndex = option.InstanceId - 1;
			LevelGeneralNetworks.RequestEntityInteractOption(controller.CreatureData.GetCreatureDataId(), optionIndex, delegate(EntityInteractResponse response, Net.CallbackStatus _)
			{
				PawnInteractController controller2 = controller;
				if (controller2 == null)
				{
					return;
				}
				controller2.HandleInteractResponse(response.ErrorCode, response.Interacting);
			}, new long?(component.GetCreatureDataId()));
		}

		// Token: 0x06039790 RID: 235408 RVA: 0x00DA4A34 File Offset: 0x00DA2C34
		public static void HandleInteractionOptionNew(CommonInteractOption option, PawnInteractController controller)
		{
			if (TsInteractionUtils.LockInteractionRequest)
			{
				if (controller.OnInteractActionEnd != null)
				{
					controller.OnInteractActionEnd();
				}
				return;
			}
			EventSystem.Instance.Emit<string>(EEventName.DynamicInteractServerResponse, option.Guid);
			if (option.OptionType != EOptionType.Custom)
			{
				CharacterActorComponent characterActorComponent = Global.BaseCharacter.CharacterActorComponent;
				if (characterActorComponent != null)
				{
					Entity entity = characterActorComponent.Entity;
					if (entity != null)
					{
						CharacterMovementSyncComponent component = entity.GetComponent<CharacterMovementSyncComponent>();
						if (component != null)
						{
							component.CollectSampleAndSend(true);
						}
					}
				}
			}
			switch (option.DelayRemove ? EOptionType.Custom : option.OptionType)
			{
			case EOptionType.Normal:
			{
				TsInteractionUtils.LockInteractionRequest = true;
				controller.HandleInteractRequest();
				int optionIndex = option.InstanceId - 1;
				LevelGeneralNetworks.RequestEntityInteractOption(controller.CreatureData.GetCreatureDataId(), optionIndex, delegate(EntityInteractResponse response, Net.CallbackStatus _)
				{
					TsInteractionUtils.LockInteractionRequest = false;
					PawnInteractController controller3 = controller;
					if (controller3 == null)
					{
						return;
					}
					controller3.HandleInteractResponse(response.ErrorCode, response.Interacting);
				}, null);
				return;
			}
			case EOptionType.Dynamic:
				TsInteractionUtils.LockInteractionRequest = true;
				controller.HandleInteractRequest();
				LevelGeneralNetworks.RequestEntityDynamicInteractOption(controller.CreatureData.GetCreatureDataId(), option.Guid, delegate(EntityDynamicInteractResponse response, Net.CallbackStatus _)
				{
					TsInteractionUtils.LockInteractionRequest = false;
					PawnInteractController controller3 = controller;
					if (controller3 != null)
					{
						controller3.HandleInteractResponse(response.ErrorCode, response.Interacting);
					}
					if (option != null)
					{
						EventSystem.Instance.Emit<string>(EEventName.DynamicInteractServerResponse, option.Guid);
					}
				});
				return;
			case EOptionType.Random:
				TsInteractionUtils.LockInteractionRequest = true;
				controller.HandleInteractRequest();
				LevelGeneralNetworks.RequestEntityRandomInteractOption(controller.CreatureData.GetCreatureDataId(), option.RandomOptionIndex.Value, delegate(EntityRandomInteractResponse response, Net.CallbackStatus _)
				{
					TsInteractionUtils.LockInteractionRequest = false;
					PawnInteractController controller3 = controller;
					if (controller3 == null)
					{
						return;
					}
					controller3.HandleInteractResponse(response.ErrorCode, response.Interacting);
				});
				return;
			case EOptionType.Custom:
				if (option.Type.Type == EInteractOption.Flow)
				{
					IInteractFlow interactFlow = option.Type as IInteractFlow;
					EntityContext context = EntityContext.Create(controller.EntityId.GetValueOrDefault(), null);
					if (interactFlow != null)
					{
						FlowController.Instance.StartFlow(interactFlow.Flow.FlowListName, interactFlow.Flow.FlowId, interactFlow.Flow.StateId, context, 0L, false, false, false, null);
					}
					PawnInteractController controller2 = controller;
					if (((controller2 != null) ? controller2.OnInteractActionEnd : null) != null)
					{
						controller.OnInteractActionEnd();
						return;
					}
				}
				else if (option.Type.Type == EInteractOption.Actions)
				{
					controller.HandleInteractClientAction();
					GeneralContext generalContext = option.Context;
					if (generalContext == null)
					{
						generalContext = EntityContext.Create(controller.EntityId.GetValueOrDefault(), null);
					}
					else
					{
						generalContext = GeneralContext.Copy(generalContext);
					}
					LevelGeneralController.Instance.ExecuteActionsNew((option.Type as IInteractActions).Actions, generalContext, delegate(ELevelEventState result)
					{
						PawnInteractController controller3 = controller;
						if (((controller3 != null) ? controller3.OnInteractActionEnd : null) != null)
						{
							controller.OnInteractActionEnd();
						}
						PawnInteractController controller4 = controller;
						if (controller4 == null)
						{
							return;
						}
						controller4.FinishInteractClientAction();
					});
					return;
				}
				break;
			default:
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Interaction;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "未定义的交互选项类型";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("optionType", option.OptionType);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				break;
			}
			}
		}

		// Token: 0x06039791 RID: 235409 RVA: 0x00DA4D4B File Offset: 0x00DA2F4B
		public static bool IsInteractHintViewOpened()
		{
			return TsInteractionUtils.IsOpenedInteractionHintView;
		}

		// Token: 0x17008A4C RID: 35404
		// (get) Token: 0x06039792 RID: 235410 RVA: 0x00DA4D52 File Offset: 0x00DA2F52
		public static bool IsInteractWaitOpenViewName
		{
			get
			{
				return TsInteractionUtils.WaitOpenViewName != null;
			}
		}

		// Token: 0x06039793 RID: 235411 RVA: 0x00DA4D60 File Offset: 0x00DA2F60
		[NullableContext(0)]
		public static UniTask<bool> OpenInteractHintView()
		{
			TsInteractionUtils.<OpenInteractHintView>d__12 <OpenInteractHintView>d__;
			<OpenInteractHintView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenInteractHintView>d__.<>1__state = -1;
			<OpenInteractHintView>d__.<>t__builder.Start<TsInteractionUtils.<OpenInteractHintView>d__12>(ref <OpenInteractHintView>d__);
			return <OpenInteractHintView>d__.<>t__builder.Task;
		}

		// Token: 0x06039794 RID: 235412 RVA: 0x00DA4D9C File Offset: 0x00DA2F9C
		public static void CloseInteractHintView(string reason = "Unknown")
		{
			if (!TsInteractionUtils.IsInteractHintViewOpened())
			{
				return;
			}
			if (UiManager.Instance.IsViewDestroying(EUiViewName.InteractionHintView))
			{
				return;
			}
			if (reason != "Unknown")
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Interaction;
				ELogAuthor author = ELogAuthor.FJH;
				string message = "[InteractionDebug]尝试关闭交互界面";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", reason);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			UiManager.Instance.CloseViewAsync(EUiViewName.InteractionHintView).ContinueWith(delegate(bool _)
			{
				TsInteractionUtils.IsOpenedInteractionHintView = false;
			}).Forget();
		}

		// Token: 0x06039795 RID: 235413 RVA: 0x00DA4E34 File Offset: 0x00DA3034
		public static void RegisterWaitOpenViewName(EUiViewName waitOpenViewName)
		{
			if (TsInteractionUtils.WaitOpenViewName == waitOpenViewName)
			{
				return;
			}
			UiViewInfo uiViewInfo = UiConfig.Instance.TryGetViewInfo(waitOpenViewName);
			if (uiViewInfo != null && uiViewInfo.Type == ELayerType.Normal)
			{
				if (TsInteractionUtils.WaitOpenViewName == null)
				{
					EventSystem instance = EventSystem.Instance;
					EEventName name = EEventName.OnViewDone;
					Action<EUiViewName, UiViewBase> handle;
					if ((handle = TsInteractionUtils.<>O.<0>__OnOpenWaitViewDone) == null)
					{
						handle = (TsInteractionUtils.<>O.<0>__OnOpenWaitViewDone = new Action<EUiViewName, UiViewBase>(TsInteractionUtils.OnOpenWaitViewDone));
					}
					instance.Add<EUiViewName, UiViewBase>(name, handle);
				}
				TsInteractionUtils.WaitOpenViewName = new EUiViewName?(waitOpenViewName);
				InputDistributeController.Instance.RefreshInputTag();
				TimerSystem.Instance.Delay(delegate(float _)
				{
					if (TsInteractionUtils.WaitOpenViewName == waitOpenViewName)
					{
						global::Log.Instance.Warn(ELogModule.Interaction, ELogAuthor.WLJ, "等待界面打开超时", default(ReadOnlySpan<ValueTuple<string, object>>));
						TsInteractionUtils.ClearWaitView();
					}
				}, 10000f, null, null, true, 1f);
			}
		}

		// Token: 0x06039796 RID: 235414 RVA: 0x00DA4F0C File Offset: 0x00DA310C
		[NullableContext(2)]
		private static void OnOpenWaitViewDone(EUiViewName viewName, UiViewBase view)
		{
			if (viewName != TsInteractionUtils.WaitOpenViewName)
			{
				return;
			}
			TsInteractionUtils.ClearWaitView();
		}

		// Token: 0x06039797 RID: 235415 RVA: 0x00DA4F42 File Offset: 0x00DA3142
		public static void Init()
		{
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.OnStartLoadingState;
			Action handle;
			if ((handle = TsInteractionUtils.<>O.<1>__OnOpenLoading) == null)
			{
				handle = (TsInteractionUtils.<>O.<1>__OnOpenLoading = new Action(TsInteractionUtils.OnOpenLoading));
			}
			instance.Add(name, handle);
			TsInteractionUtils.LockInteractionRequest = false;
		}

		// Token: 0x06039798 RID: 235416 RVA: 0x00DA4F75 File Offset: 0x00DA3175
		public static void Clear()
		{
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.OnStartLoadingState;
			Action handle;
			if ((handle = TsInteractionUtils.<>O.<1>__OnOpenLoading) == null)
			{
				handle = (TsInteractionUtils.<>O.<1>__OnOpenLoading = new Action(TsInteractionUtils.OnOpenLoading));
			}
			instance.Remove(name, handle);
			TsInteractionUtils.ClearCurrentOpenViewName();
		}

		// Token: 0x06039799 RID: 235417 RVA: 0x00DA4FA8 File Offset: 0x00DA31A8
		public static void RegisterOpenViewName(EUiViewName viewName)
		{
			if (TsInteractionUtils.CurrentOpenViewName == null)
			{
				EventSystem instance = EventSystem.Instance;
				EEventName name = EEventName.CloseView;
				Action<EUiViewName, int> handle;
				if ((handle = TsInteractionUtils.<>O.<2>__OnCloseView) == null)
				{
					handle = (TsInteractionUtils.<>O.<2>__OnCloseView = new Action<EUiViewName, int>(TsInteractionUtils.OnCloseView));
				}
				instance.Add<EUiViewName, int>(name, handle);
			}
			TsInteractionUtils.CurrentOpenViewName = new EUiViewName?(viewName);
		}

		// Token: 0x0603979A RID: 235418 RVA: 0x00DA4FF4 File Offset: 0x00DA31F4
		public static void ClearCurrentOpenViewName()
		{
			if (TsInteractionUtils.CurrentOpenViewName != null)
			{
				TsInteractionUtils.CurrentOpenViewName = null;
				EventSystem instance = EventSystem.Instance;
				EEventName name = EEventName.CloseView;
				Action<EUiViewName, int> handle;
				if ((handle = TsInteractionUtils.<>O.<2>__OnCloseView) == null)
				{
					handle = (TsInteractionUtils.<>O.<2>__OnCloseView = new Action<EUiViewName, int>(TsInteractionUtils.OnCloseView));
				}
				instance.Remove(name, handle);
			}
		}

		// Token: 0x0603979B RID: 235419 RVA: 0x00DA5040 File Offset: 0x00DA3240
		public static EUiViewName? GetCurrentOpenViewName()
		{
			return TsInteractionUtils.CurrentOpenViewName;
		}

		// Token: 0x0603979C RID: 235420 RVA: 0x00DA5048 File Offset: 0x00DA3248
		private static void OnCloseView(EUiViewName viewName, int viewId)
		{
			if (viewName != TsInteractionUtils.CurrentOpenViewName)
			{
				return;
			}
			TsInteractionUtils.CurrentOpenViewName = null;
			InputDistributeController.Instance.RefreshInputTag();
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.CloseView;
			Action<EUiViewName, int> handle;
			if ((handle = TsInteractionUtils.<>O.<2>__OnCloseView) == null)
			{
				handle = (TsInteractionUtils.<>O.<2>__OnCloseView = new Action<EUiViewName, int>(TsInteractionUtils.OnCloseView));
			}
			instance.Remove(name, handle);
		}

		// Token: 0x0603979D RID: 235421 RVA: 0x00DA50B6 File Offset: 0x00DA32B6
		private static void OnOpenLoading()
		{
			if (TsInteractionUtils.WaitOpenViewName != null)
			{
				TsInteractionUtils.OnOpenWaitViewDone(TsInteractionUtils.WaitOpenViewName.Value, null);
			}
			if (TsInteractionUtils.CurrentOpenViewName != null)
			{
				TsInteractionUtils.OnCloseView(TsInteractionUtils.CurrentOpenViewName.Value, 0);
			}
		}

		// Token: 0x0603979E RID: 235422 RVA: 0x00DA50F0 File Offset: 0x00DA32F0
		public static bool IsInteractionOpenView()
		{
			return TsInteractionUtils.CurrentOpenViewName != null;
		}

		// Token: 0x0603979F RID: 235423 RVA: 0x00DA50FC File Offset: 0x00DA32FC
		private static void ClearWaitView()
		{
			TsInteractionUtils.WaitOpenViewName = null;
			InputDistributeController.Instance.RefreshInputTag();
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.OnViewDone;
			Action<EUiViewName, UiViewBase> handle;
			if ((handle = TsInteractionUtils.<>O.<0>__OnOpenWaitViewDone) == null)
			{
				Action<EUiViewName, UiViewBase> action = TsInteractionUtils.<>O.<0>__OnOpenWaitViewDone = new Action<EUiViewName, UiViewBase>(TsInteractionUtils.OnOpenWaitViewDone);
				handle = action;
			}
			instance.Remove(name, handle);
		}

		// Token: 0x060397A0 RID: 235424 RVA: 0x00DA5148 File Offset: 0x00DA3348
		public static void UpdateInteractHintView()
		{
			if (!TsInteractionUtils.LockInteractionRequest)
			{
				EventSystem.Instance.Emit(EEventName.InteractionViewUpdate);
			}
		}

		// Token: 0x060397A1 RID: 235425 RVA: 0x00DA5164 File Offset: 0x00DA3364
		public static void HandleEntityInteractByServerNotify(ActionNotify notify, long creatureDataId, int optionIndex)
		{
			WaitEntityTask.Create("TsInteractionUtils.HandleEntityInteractByServerNotify", creatureDataId, delegate(bool? result)
			{
				if (result == null || !result.Value)
				{
					global::Log.Instance.Warn(ELogModule.Interaction, ELogAuthor.WLJ, "[基础交互选项继续执行]等待实体超时", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				EntityHandle entity = CreatureModel.Instance.GetEntity(creatureDataId);
				if (entity == null)
				{
					global::Log.Instance.Warn(ELogModule.Interaction, ELogAuthor.WLJ, "[基础交互选项继续执行]查找不到对应实体", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				PawnInteractNewComponent component = entity.Entity.GetComponent<PawnInteractNewComponent>();
				if (component == null)
				{
					global::Log.Instance.Warn(ELogModule.Interaction, ELogAuthor.WLJ, "[基础交互选项继续执行]实体交互组件为空", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				PawnInteractController interactController = component.GetInteractController();
				if (interactController == null)
				{
					global::Log.Instance.Warn(ELogModule.Interaction, ELogAuthor.WLJ, "[基础交互选项继续执行]实体交互控制器为空", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				CommonInteractOption optionByIndex = interactController.GetOptionByIndex(optionIndex);
				if (optionByIndex == null)
				{
					global::Log.Instance.Warn(ELogModule.Interaction, ELogAuthor.WLJ, "[基础交互选项继续执行]实体当前交互选项为空", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				if (optionByIndex.Type.Type != EInteractOption.Actions)
				{
					global::Log.Instance.Warn(ELogModule.Interaction, ELogAuthor.WLJ, "[基础交互选项继续执行]实体当前交互不是行为", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				IInteractActions interactActions = optionByIndex.Type as IInteractActions;
				GeneralContext generalContext = optionByIndex.Context;
				if (generalContext == null)
				{
					generalContext = EntityContext.Create(interactController.EntityId.GetValueOrDefault(), null);
				}
				else
				{
					generalContext = GeneralContext.Copy(generalContext);
				}
				if (generalContext is EntityContext)
				{
					InteractionModel instance = InteractionModel.Instance;
					int? entityId = ((EntityContext)generalContext).EntityId;
					CreatureModel instance2 = CreatureModel.Instance;
					if (instance2 != null)
					{
						instance2.GetCreatureDataId(entityId.Value);
					}
					instance.SetInteractTarget(entityId);
					instance.SetInterctCreatureDataId(creatureDataId);
				}
				LevelGeneralController.Instance.ExecuteActionsByServerNotify(interactActions.Actions, generalContext, notify.PlayerId, notify.IncId, notify.StartIndex, notify.EndIndex, notify.NeedFinishReq, null);
			}, 90000, true, true);
		}

		// Token: 0x060397A2 RID: 235426 RVA: 0x00DA51B0 File Offset: 0x00DA33B0
		public static void HandleEntityDynamicInteractByServerNotify(ActionNotify notify, string guid)
		{
			GeneralContext generalContext = LevelGeneralContextUtil.CreateByServerContext((notify != null) ? notify.GameCtx : null);
			if (generalContext == null)
			{
				global::Log.Instance.Warn(ELogModule.Interaction, ELogAuthor.WLJ, "[动态交互选项继续执行]上下文缺失", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			InteractionModel instance = InteractionModel.Instance;
			IInteractOption dynamicConfig = instance.GetDynamicConfig(guid);
			if (dynamicConfig == null)
			{
				global::Log.Instance.Warn(ELogModule.Interaction, ELogAuthor.WLJ, "[动态交互选项继续执行]动态交互选项为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (dynamicConfig.Type.Type != EInteractOption.Actions)
			{
				global::Log.Instance.Warn(ELogModule.Interaction, ELogAuthor.WLJ, "[动态交互选项继续执行]动态交互选项不是行为", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (generalContext is EntityContext)
			{
				int? entityId = ((EntityContext)generalContext).EntityId;
				long creatureDataId = CreatureModel.Instance.GetCreatureDataId(entityId.Value);
				instance.SetInteractTarget(entityId);
				instance.SetInterctCreatureDataId(creatureDataId);
			}
			LevelGeneralController.Instance.ExecuteActionsByServerNotify((dynamicConfig.Type as IInteractActions).Actions, generalContext, notify.PlayerId, notify.IncId, notify.StartIndex, notify.EndIndex, notify.NeedFinishReq, null);
		}

		// Token: 0x060397A3 RID: 235427 RVA: 0x00DA52C4 File Offset: 0x00DA34C4
		public static int HandleInteractionSecondConfirm([Nullable(2)] CommonInteractOption option, PawnInteractController controller, Action<int, bool, CommonInteractOption> confirmCallback)
		{
			if (option == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Interaction;
				ELogAuthor author = ELogAuthor.FJH;
				string message = "[执行交互] 未提供交互选项信息";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", controller.InteractEntity.EntityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return 0;
			}
			if (option.ConfirmBox == null)
			{
				TsInteractionUtils.HandleInteractionOptionNew(option, controller);
				return 0;
			}
			int num = InteractConfirmController.Instance.HandleAction(option, confirmCallback);
			if (num == 0)
			{
				if (controller.OnInteractActionEnd != null)
				{
					controller.OnInteractActionEnd();
				}
				return 0;
			}
			return num;
		}

		// Token: 0x060397A4 RID: 235428 RVA: 0x00DA5348 File Offset: 0x00DA3548
		public unsafe static bool CheckTeleportInterceptByOption(int optionInstanceId, PawnInteractController controller)
		{
			InteractEntity interactEntity = controller.InteractEntity;
			Entity entity = (interactEntity != null) ? interactEntity.GetEntity() : null;
			CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
			if (creatureDataComponent == null)
			{
				return false;
			}
			IReadOnlyList<TeleportIntercept> configList = ConfigTeleportInterceptByEntityConfigId.GetConfigList(creatureDataComponent.GetPbDataId(), true);
			if (configList == null || configList.Count == 0)
			{
				return false;
			}
			int num = optionInstanceId - 1;
			int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
			foreach (TeleportIntercept teleportIntercept in configList)
			{
				if (num == teleportIntercept.OptionIndex && instanceId == teleportIntercept.CurInstConfigId)
				{
					global::Vector position = global::Vector.Create((double)(*teleportIntercept.GetTargetPositionBytes()[0]), (double)(*teleportIntercept.GetTargetPositionBytes()[1]), (double)(*teleportIntercept.GetTargetPositionBytes()[2]));
					ValueTuple<bool, bool> valueTuple = ResourceManagerController.Instance.IsBlockResourceDownloaded(teleportIntercept.TargetMapConfigId, position);
					bool item = valueTuple.Item1;
					bool item2 = valueTuple.Item2;
					if (!item)
					{
						ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SubPackageTeleportToUnFinishAreaConfirm);
						confirmBoxDataNew.FunctionMap[1] = delegate()
						{
							ConfirmBoxController.Instance.CloseConfirmBoxView();
							ReConnectController.Instance.Logout(ELogoutReason.InvalidTeleportPosition);
						};
						ConfirmBoxController.Instance.ShowNetWorkConfirmBoxView(confirmBoxDataNew, null);
						return true;
					}
					if (item2)
					{
						SubPackageDownLoadModel.Instance.OpenBlockNeedReLoginConfirm();
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060397A5 RID: 235429 RVA: 0x00DA54C4 File Offset: 0x00DA36C4
		public static bool CheckOptionLockType(int optionInstanceId, PawnInteractController controller, BaseTagComponent playerTagComponent)
		{
			CommonInteractOption commonInteractOption;
			if (optionInstanceId > -1)
			{
				commonInteractOption = controller.GetOptionByInstanceId(optionInstanceId);
			}
			else
			{
				commonInteractOption = controller.GetInteractiveOption(false);
			}
			if (commonInteractOption == null)
			{
				return false;
			}
			if (commonInteractOption.OptionLockTypeList != null && commonInteractOption.OptionLockTypeList.Count > 0)
			{
				using (List<EOptionLockType>.Enumerator enumerator = commonInteractOption.OptionLockTypeList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current == EOptionLockType.OnMotor && playerTagComponent != null && playerTagComponent.HasExactTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托骑乘状态"]))
						{
							string localTextNew = ConfigMultiTextLang.GetLocalTextNew("InteractProhibitTips_Motor", null);
							GenericPromptController.Instance.ShowPromptByItsType(EPromptSubViewType.FloatLinePrompt, null, null, new object[]
							{
								localTextNew
							}, null, null, null);
							return true;
						}
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x060397A6 RID: 235430 RVA: 0x00DA559C File Offset: 0x00DA379C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060397A7 RID: 235431 RVA: 0x00DA559E File Offset: 0x00DA379E
		public static void ResetStaticDefaultValue()
		{
			TsInteractionUtils.CurrentOpenViewName = null;
			TsInteractionUtils.LockInteractionRequest = false;
			TsInteractionUtils.IsOpenedInteractionHintView = false;
			TsInteractionUtils.WaitOpenViewName = null;
			TsInteractionUtils.IsWaitForInteractOpenViewDone = false;
		}

		// Token: 0x0401E0DE RID: 123102
		private static EUiViewName? CurrentOpenViewName;

		// Token: 0x0401E0DF RID: 123103
		private static bool LockInteractionRequest;

		// Token: 0x0401E0E0 RID: 123104
		private static bool IsOpenedInteractionHintView;

		// Token: 0x0401E0E1 RID: 123105
		public static EUiViewName? WaitOpenViewName;

		// Token: 0x0401E0E2 RID: 123106
		public static bool IsWaitForInteractOpenViewDone;

		// Token: 0x0200BA70 RID: 47728
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040385C9 RID: 230857
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<EUiViewName, UiViewBase> <0>__OnOpenWaitViewDone;

			// Token: 0x040385CA RID: 230858
			[Nullable(0)]
			public static Action <1>__OnOpenLoading;

			// Token: 0x040385CB RID: 230859
			[Nullable(0)]
			public static Action<EUiViewName, int> <2>__OnCloseView;
		}
	}
}
