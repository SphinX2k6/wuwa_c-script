using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B49 RID: 27465
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventPhoneSystemInteract : LevelEventBase
	{
		// Token: 0x0604419A RID: 278938 RVA: 0x010C1754 File Offset: 0x010BF954
		public LevelEventPhoneSystemInteract(int id) : base(id)
		{
		}

		// Token: 0x0604419B RID: 278939 RVA: 0x010C1760 File Offset: 0x010BF960
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			PhoneSystemInteract phoneSystemInteract = inParams as PhoneSystemInteract;
			if (phoneSystemInteract.InteractType.Type != EPhoneSystemInteractType.OpenPhoneMessageBoard && phoneSystemInteract.InteractType.Type != EPhoneSystemInteractType.FlowOpenPhoneMessage)
			{
				return;
			}
			ShortMessage? shortMessageConfig = this.GetShortMessageConfig(phoneSystemInteract);
			if (shortMessageConfig == null)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			if (phoneSystemInteract.InteractType.Type == EPhoneSystemInteractType.OpenPhoneMessageBoard)
			{
				if (context != null && context.Type.GetValueOrDefault() == EGeneralContextType.Plot)
				{
					UiManager.Instance.OpenViewWithLayer(EUiViewName.PhoneMsgPanelViewBig, ELayerType.Pop, shortMessageConfig, null);
				}
				else
				{
					UiManager.Instance.OpenView(EUiViewName.PhoneMsgPanelViewBig, shortMessageConfig, null);
				}
				base.FinishExecute(true, false, true);
				return;
			}
			if (phoneSystemInteract.InteractType.Type == EPhoneSystemInteractType.FlowOpenPhoneMessage)
			{
				PhoneMsgPanelViewData param = new PhoneMsgPanelViewData
				{
					ShortMessage = shortMessageConfig,
					NeedShowTips = false,
					NeedForceReadAllMsg = true,
					OpenWay = EPhoneMsgOpenWay.ForceOpen,
					ViewType = EPhoneMsgViewType.Small
				};
				if (context != null && context.Type.GetValueOrDefault() == EGeneralContextType.Plot)
				{
					UiManager.Instance.OpenViewWithLayer(EUiViewName.PhoneMsgPanelViewSmall, ELayerType.Pop, param, null);
				}
				else
				{
					UiManager.Instance.OpenView(EUiViewName.PhoneMsgPanelViewSmall, param, null);
				}
				base.FinishExecute(true, false, true);
			}
		}

		// Token: 0x0604419C RID: 278940 RVA: 0x010C1880 File Offset: 0x010BFA80
		private ShortMessage? GetShortMessageConfig(PhoneSystemInteract param)
		{
			IPhoneSystemInteractBase interactType = param.InteractType;
			IOpenPhoneMessageBoard openPhoneMessageBoard = interactType as IOpenPhoneMessageBoard;
			IMessageBoard messageBoard;
			if (openPhoneMessageBoard == null)
			{
				IFlowOpenPhoneMessage flowOpenPhoneMessage = interactType as IFlowOpenPhoneMessage;
				if (flowOpenPhoneMessage == null)
				{
					messageBoard = null;
				}
				else
				{
					messageBoard = flowOpenPhoneMessage.PhoneBoardType;
				}
			}
			else
			{
				messageBoard = openPhoneMessageBoard.PhoneBoardType;
			}
			IMessageBoard messageBoard2 = messageBoard;
			if (messageBoard2 == null)
			{
				return null;
			}
			IPhoneMessageBoardConfig messageBoardConfig = messageBoard2.MessageBoardConfig;
			if (messageBoardConfig == null)
			{
				return null;
			}
			int? phoneMessageId = messageBoardConfig.PhoneMessageId;
			if (phoneMessageId == null)
			{
				return null;
			}
			return PhoneMsgConfig.Instance.GetPhoneMsgConfig(phoneMessageId.Value);
		}
	}
}
