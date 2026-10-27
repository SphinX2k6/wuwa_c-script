using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MailBind.Views
{
	// Token: 0x020056A5 RID: 22181
	[NullableContext(2)]
	[Nullable(0)]
	public class MailBindView : UiViewBase
	{
		// Token: 0x06038713 RID: 231187 RVA: 0x00D666AB File Offset: 0x00D648AB
		[NullableContext(1)]
		public MailBindView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06038714 RID: 231188 RVA: 0x00D666B4 File Offset: 0x00D648B4
		protected override UniTask OnCreateAsync()
		{
			MailBindView.<OnCreateAsync>d__8 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<MailBindView.<OnCreateAsync>d__8>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038715 RID: 231189 RVA: 0x00D666F0 File Offset: 0x00D648F0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(7, new Action(this.OnRewardButtonClick))
			};
		}

		// Token: 0x06038716 RID: 231190 RVA: 0x00D667DC File Offset: 0x00D649DC
		protected override UniTask OnBeforeStartAsync()
		{
			MailBindView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MailBindView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038717 RID: 231191 RVA: 0x00D66820 File Offset: 0x00D64A20
		protected override void OnStart()
		{
			string textId = this.IsGlobalSdk ? "Mail_Activity_Function_Entry02" : "Mail_Activity_Function_Entry01";
			this.CaptionItem.SetTitleByTextIdAndArgNew(textId, Array.Empty<object>());
			this.CaptionItem.SetCloseCallBack(new Action(this.OnBackBtnClick));
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem != null)
			{
				captionItem.SetHelpCallBack(new Action(this.OnHelpButtonClick));
			}
			string titleIconByResourceId = this.IsGlobalSdk ? "SP_MailBindIcon" : "SP_KuroStreetIcon";
			this.CaptionItem.SetTitleIconByResourceId(titleIconByResourceId);
			string textId2 = this.IsGlobalSdk ? "Mail_Activity_Title02" : "Mail_Activity_Title";
			this.TitleComponent.SetTitleByTextId(textId2, Array.Empty<string>());
			this.TitleComponent.SetSubTitleVisible(false);
			string textId3 = this.IsGlobalSdk ? "Mail_Activity_Desc02" : "Mail_Activity_Desc01";
			this.DescriptionComponent.SetContentByTextId(textId3, Array.Empty<string>());
			int? intConfig = ConfigCommonParamById.GetIntConfig("MailBindReward");
			if (intConfig == null)
			{
				return;
			}
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(intConfig.Value);
			this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
			this.RewardListComponent.RefreshItemLayout(dropPackagePreviewItemList, null);
			string textId4 = this.IsGlobalSdk ? "Mail_Activity_Binding" : "Mail_Activity_Login";
			this.FunctionalComponent.FunctionButton.SetFunction(new Action(this.OnGotoMailBindBtnClick));
			this.FunctionalComponent.FunctionButton.SetLocalTextNew(textId4, Array.Empty<object>());
			string textId5 = this.IsGlobalSdk ? "Mail_Activity_Finish02" : "Mail_Activity_Finish01";
			this.FunctionalComponent.SetActivateTextByTextId(textId5, Array.Empty<string>());
			MailBindController.Instance.RecordMailBindNextShowRedDotTime();
		}

		// Token: 0x06038718 RID: 231192 RVA: 0x00D669CF File Offset: 0x00D64BCF
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnMailBindInfoNotify, new Action(this.OnMailBindInfoNotify));
		}

		// Token: 0x06038719 RID: 231193 RVA: 0x00D669ED File Offset: 0x00D64BED
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnMailBindInfoNotify, new Action(this.OnMailBindInfoNotify));
		}

		// Token: 0x0603871A RID: 231194 RVA: 0x00D66A0B File Offset: 0x00D64C0B
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x0603871B RID: 231195 RVA: 0x00D66A13 File Offset: 0x00D64C13
		private void OnGotoMailBindBtnClick()
		{
			MailBindController.Instance.MailBindRequest();
			if (this.IsGlobalSdk)
			{
				KuroSdkController.Instance.PostKuroSdkEvent(EKuroSdkEventKey.KuroOpenUserCenter);
			}
			else
			{
				ChannelController.Instance.OpenKuroStreet();
			}
			MailBindController.Instance.RecordMailBindJumpToWebView();
		}

		// Token: 0x0603871C RID: 231196 RVA: 0x00D66A49 File Offset: 0x00D64C49
		private void OnBackBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603871D RID: 231197 RVA: 0x00D66A52 File Offset: 0x00D64C52
		private void OnRewardButtonClick()
		{
			MailBindController.Instance.MailBindRewardRequest();
		}

		// Token: 0x0603871E RID: 231198 RVA: 0x00D66A60 File Offset: 0x00D64C60
		private void OnHelpButtonClick()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig(this.IsGlobalSdk ? "Mail_Activity_HelpId02" : "Mail_Activity_HelpId01");
			if (intConfig == null)
			{
				return;
			}
			HelpController.Instance.OpenHelpById(intConfig.Value);
		}

		// Token: 0x0603871F RID: 231199 RVA: 0x00D66AA2 File Offset: 0x00D64CA2
		private void OnMailBindInfoNotify()
		{
			this.Refresh();
		}

		// Token: 0x06038720 RID: 231200 RVA: 0x00D66AAA File Offset: 0x00D64CAA
		public void Refresh()
		{
			this.RefreshTimerText();
			this.RefreshState();
		}

		// Token: 0x06038721 RID: 231201 RVA: 0x00D66AB8 File Offset: 0x00D64CB8
		private void RefreshTimerText()
		{
			MailBindModel instance = MailBindModel.Instance;
			bool flag = this.IsGlobalSdk && instance.GetIsReward();
			this.TitleComponent.SetTimeTextVisible(flag);
			if (flag)
			{
				string timeTextByText = instance.GetRemainTimeText(instance.GetCloseTime()) ?? "";
				this.TitleComponent.SetTimeTextByText(timeTextByText);
			}
		}

		// Token: 0x06038722 RID: 231202 RVA: 0x00D66B10 File Offset: 0x00D64D10
		private void RefreshState()
		{
			EMailBindState state = MailBindModel.Instance.GetState();
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(state == EMailBindState.NotBind);
			}
			UUIButtonComponent button = base.GetButton(7);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(state == EMailBindState.CanReward);
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(state == EMailBindState.HasReward);
			}
			this.FunctionalComponent.SetLockConditionButtonVisible(false);
			this.FunctionalComponent.SetActivatePanelConditionVisible(state > EMailBindState.NotBind);
			ActivityButtonItem functionButton = this.FunctionalComponent.FunctionButton;
			if (functionButton == null)
			{
				return;
			}
			functionButton.SetUiActive(state == EMailBindState.NotBind);
		}

		// Token: 0x0401DA39 RID: 121401
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x0401DA3A RID: 121402
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x0401DA3B RID: 121403
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x0401DA3C RID: 121404
		private ActivityFunctionalTypeA FunctionalComponent;

		// Token: 0x0401DA3D RID: 121405
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401DA3E RID: 121406
		private bool IsGlobalSdk;

		// Token: 0x0200B866 RID: 47206
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04037D01 RID: 228609
			TitleItem,
			// Token: 0x04037D02 RID: 228610
			DescriptionItem,
			// Token: 0x04037D03 RID: 228611
			RewardListItem,
			// Token: 0x04037D04 RID: 228612
			FunctionAreaItem,
			// Token: 0x04037D05 RID: 228613
			CaptionItem,
			// Token: 0x04037D06 RID: 228614
			HasRewardItem,
			// Token: 0x04037D07 RID: 228615
			UnDoneItem,
			// Token: 0x04037D08 RID: 228616
			ReceiveButton
		}
	}
}
