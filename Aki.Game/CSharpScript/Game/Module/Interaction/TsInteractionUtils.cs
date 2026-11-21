using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
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
using UnrealEngine;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x0200482A RID: 18474
	[NullableContext(1)]
	[Nullable(0)]
	public class TsInteractionUtils : IStaticVariableResetter
	{
		// Token: 0x0602E6A9 RID: 190121 RVA: 0x00CF3608 File Offset: 0x00CF1808
		static TsInteractionUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TsInteractionUtils.CreateStaticDefaultValue), new Action(TsInteractionUtils.ResetStaticDefaultValue));
		}

		// Token: 0x0602E6AA RID: 190122 RVA: 0x00CF3627 File Offset: 0x00CF1827
		[return: Nullable(2)]
		public static SInteractionConfig GetInteractionConfig(string inRow)
		{
			return DataTableUtil.GetDataTableRowFromName<SInteractionConfig>(EDataTable.InteractionConfigs, inRow);
		}

		// Token: 0x0602E6AB RID: 190123 RVA: 0x00CF3634 File Offset: 0x00CF1834
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

		// Token: 0x0602E6AC RID: 190124 RVA: 0x00CF36F4 File Offset: 0x00CF18F4
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

		// Token: 0x0602E6AD RID: 190125 RVA: 0x00CF3A0B File Offset: 0x00CF1C0B
		public static bool IsInteractHintViewOpened()
		{
			return TsInteractionUtils.IsOpenedInteractionHintView;
		}

		// Token: 0x17005E18 RID: 24088
		// (get) Token: 0x0602E6AE RID: 190126 RVA: 0x00CF3A12 File Offset: 0x00CF1C12
		public static bool IsInteractWaitOpenViewName
		{
			get
			{
				return TsInteractionUtils.WaitOpenViewName != null;
			}
		}

		// Token: 0x0602E6AF RID: 190127 RVA: 0x00CF3A20 File Offset: 0x00CF1C20
		[NullableContext(0)]
		public static UniTask<bool> OpenInteractHintView()
		{
			TsInteractionUtils.<OpenInteractHintView>d__12 <OpenInteractHintView>d__;
			<OpenInteractHintView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenInteractHintView>d__.<>1__state = -1;
			<OpenInteractHintView>d__.<>t__builder.Start<TsInteractionUtils.<OpenInteractHintView>d__12>(ref <OpenInteractHintView>d__);
			return <OpenInteractHintView>d__.<>t__builder.Task;
		}

		// Token: 0x0602E6B0 RID: 190128 RVA: 0x00CF3A5C File Offset: 0x00CF1C5C
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

		// Token: 0x0602E6B1 RID: 190129 RVA: 0x00CF3AF4 File Offset: 0x00CF1CF4
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

		// Token: 0x0602E6B2 RID: 190130 RVA: 0x00CF3BCC File Offset: 0x00CF1DCC
		[NullableContext(2)]
		private static void OnOpenWaitViewDone(EUiViewName viewName, UiViewBase view)
		{
			if (viewName != TsInteractionUtils.WaitOpenViewName)
			{
				return;
			}
			TsInteractionUtils.ClearWaitView();
		}

		// Token: 0x0602E6B3 RID: 190131 RVA: 0x00CF3C02 File Offset: 0x00CF1E02
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

		// Token: 0x0602E6B4 RID: 190132 RVA: 0x00CF3C35 File Offset: 0x00CF1E35
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

		// Token: 0x0602E6B5 RID: 190133 RVA: 0x00CF3C68 File Offset: 0x00CF1E68
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

		// Token: 0x0602E6B6 RID: 190134 RVA: 0x00CF3CB4 File Offset: 0x00CF1EB4
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

		// Token: 0x0602E6B7 RID: 190135 RVA: 0x00CF3D00 File Offset: 0x00CF1F00
		public static EUiViewName? GetCurrentOpenViewName()
		{
			return TsInteractionUtils.CurrentOpenViewName;
		}

		// Token: 0x0602E6B8 RID: 190136 RVA: 0x00CF3D08 File Offset: 0x00CF1F08
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

		// Token: 0x0602E6B9 RID: 190137 RVA: 0x00CF3D76 File Offset: 0x00CF1F76
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

		// Token: 0x0602E6BA RID: 190138 RVA: 0x00CF3DB0 File Offset: 0x00CF1FB0
		public static bool IsInteractionOpenView()
		{
			return TsInteractionUtils.CurrentOpenViewName != null;
		}

		// Token: 0x0602E6BB RID: 190139 RVA: 0x00CF3DBC File Offset: 0x00CF1FBC
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

		// Token: 0x0602E6BC RID: 190140 RVA: 0x00CF3E08 File Offset: 0x00CF2008
		public static void UpdateInteractHintView()
		{
			if (!TsInteractionUtils.LockInteractionRequest)
			{
				EventSystem.Instance.Emit(EEventName.InteractionViewUpdate);
			}
		}

		// Token: 0x0602E6BD RID: 190141 RVA: 0x00CF3E24 File Offset: 0x00CF2024
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

		// Token: 0x0602E6BE RID: 190142 RVA: 0x00CF3E70 File Offset: 0x00CF2070
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

		// Token: 0x0602E6BF RID: 190143 RVA: 0x00CF3F84 File Offset: 0x00CF2184
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

		// Token: 0x0602E6C0 RID: 190144 RVA: 0x00CF4008 File Offset: 0x00CF2208
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
						int mapBlockFromPosition = ResourceManagerController.Instance.GetMapBlockFromPosition(teleportIntercept.TargetMapConfigId, position);
						SubPackageDownLoadModel.Instance.OpenSubPackageDownLoadConfirm("SubPackageDownLoad_CommonLock_Confirm", new List<int>
						{
							mapBlockFromPosition
						}, null, new double?(0.0));
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

		// Token: 0x0602E6C1 RID: 190145 RVA: 0x00CF4188 File Offset: 0x00CF2388
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

		// Token: 0x0602E6C2 RID: 190146 RVA: 0x00CF4260 File Offset: 0x00CF2460
		public static bool IsScreenPositionInDetectShape(FVector2D screenPosition, int sizeX, int sizeY, IInteractScreenDetectShapeBase config)
		{
			IInteractScreenDetectShapeCircle interactScreenDetectShapeCircle = config as IInteractScreenDetectShapeCircle;
			if (interactScreenDetectShapeCircle != null && config.Type == EInteractScreenDetectShape.Circle)
			{
				float num = (float)Math.Min(sizeX, sizeY) / 2f * interactScreenDetectShapeCircle.RadiusRatio;
				float num2 = screenPosition.X - (float)sizeX / 2f;
				float num3 = screenPosition.Y - (float)sizeY / 2f;
				return num2 * num2 + num3 * num3 <= num * num;
			}
			return true;
		}

		// Token: 0x0602E6C3 RID: 190147 RVA: 0x00CF42C4 File Offset: 0x00CF24C4
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E6C4 RID: 190148 RVA: 0x00CF42C6 File Offset: 0x00CF24C6
		public static void ResetStaticDefaultValue()
		{
			TsInteractionUtils.CurrentOpenViewName = null;
			TsInteractionUtils.LockInteractionRequest = false;
			TsInteractionUtils.IsOpenedInteractionHintView = false;
			TsInteractionUtils.WaitOpenViewName = null;
			TsInteractionUtils.IsWaitForInteractOpenViewDone = false;
		}

		// Token: 0x04018B7B RID: 101243
		private static EUiViewName? CurrentOpenViewName;

		// Token: 0x04018B7C RID: 101244
		private static bool LockInteractionRequest;

		// Token: 0x04018B7D RID: 101245
		private static bool IsOpenedInteractionHintView;

		// Token: 0x04018B7E RID: 101246
		public static EUiViewName? WaitOpenViewName;

		// Token: 0x04018B7F RID: 101247
		public static bool IsWaitForInteractOpenViewDone;

		// Token: 0x0200A487 RID: 42119
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04032FC1 RID: 208833
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<EUiViewName, UiViewBase> <0>__OnOpenWaitViewDone;

			// Token: 0x04032FC2 RID: 208834
			[Nullable(0)]
			public static Action <1>__OnOpenLoading;

			// Token: 0x04032FC3 RID: 208835
			[Nullable(0)]
			public static Action<EUiViewName, int> <2>__OnCloseView;
		}
	}
}
