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
	// Token: 0x0200467B RID: 18043
	[NullableContext(2)]
	[Nullable(0)]
	public class MailBindView : UiViewBase
	{
		// Token: 0x0602D610 RID: 185872 RVA: 0x00CB47FC File Offset: 0x00CB29FC
		[NullableContext(1)]
		public MailBindView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602D611 RID: 185873 RVA: 0x00CB4808 File Offset: 0x00CB2A08
		protected override UniTask OnCreateAsync()
		{
			MailBindView.<OnCreateAsync>d__8 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<MailBindView.<OnCreateAsync>d__8>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D612 RID: 185874 RVA: 0x00CB4844 File Offset: 0x00CB2A44
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

		// Token: 0x0602D613 RID: 185875 RVA: 0x00CB4930 File Offset: 0x00CB2B30
		protected override UniTask OnBeforeStartAsync()
		{
			MailBindView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MailBindView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D614 RID: 185876 RVA: 0x00CB4974 File Offset: 0x00CB2B74
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

		// Token: 0x0602D615 RID: 185877 RVA: 0x00CB4B23 File Offset: 0x00CB2D23
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnMailBindInfoNotify, new Action(this.OnMailBindInfoNotify));
		}

		// Token: 0x0602D616 RID: 185878 RVA: 0x00CB4B41 File Offset: 0x00CB2D41
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnMailBindInfoNotify, new Action(this.OnMailBindInfoNotify));
		}

		// Token: 0x0602D617 RID: 185879 RVA: 0x00CB4B5F File Offset: 0x00CB2D5F
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x0602D618 RID: 185880 RVA: 0x00CB4B67 File Offset: 0x00CB2D67
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

		// Token: 0x0602D619 RID: 185881 RVA: 0x00CB4B9D File Offset: 0x00CB2D9D
		private void OnBackBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602D61A RID: 185882 RVA: 0x00CB4BA6 File Offset: 0x00CB2DA6
		private void OnRewardButtonClick()
		{
			MailBindController.Instance.MailBindRewardRequest();
		}

		// Token: 0x0602D61B RID: 185883 RVA: 0x00CB4BB4 File Offset: 0x00CB2DB4
		private void OnHelpButtonClick()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig(this.IsGlobalSdk ? "Mail_Activity_HelpId02" : "Mail_Activity_HelpId01");
			if (intConfig == null)
			{
				return;
			}
			HelpController.Instance.OpenHelpById(intConfig.Value);
		}

		// Token: 0x0602D61C RID: 185884 RVA: 0x00CB4BF6 File Offset: 0x00CB2DF6
		private void OnMailBindInfoNotify()
		{
			this.Refresh();
		}

		// Token: 0x0602D61D RID: 185885 RVA: 0x00CB4BFE File Offset: 0x00CB2DFE
		public void Refresh()
		{
			this.RefreshTimerText();
			this.RefreshState();
		}

		// Token: 0x0602D61E RID: 185886 RVA: 0x00CB4C0C File Offset: 0x00CB2E0C
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

		// Token: 0x0602D61F RID: 185887 RVA: 0x00CB4C64 File Offset: 0x00CB2E64
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

		// Token: 0x040184C4 RID: 99524
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x040184C5 RID: 99525
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x040184C6 RID: 99526
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x040184C7 RID: 99527
		private ActivityFunctionalTypeA FunctionalComponent;

		// Token: 0x040184C8 RID: 99528
		private PopupCaptionItem CaptionItem;

		// Token: 0x040184C9 RID: 99529
		private bool IsGlobalSdk;

		// Token: 0x0200A28E RID: 41614
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403271E RID: 206622
			TitleItem,
			// Token: 0x0403271F RID: 206623
			DescriptionItem,
			// Token: 0x04032720 RID: 206624
			RewardListItem,
			// Token: 0x04032721 RID: 206625
			FunctionAreaItem,
			// Token: 0x04032722 RID: 206626
			CaptionItem,
			// Token: 0x04032723 RID: 206627
			HasRewardItem,
			// Token: 0x04032724 RID: 206628
			UnDoneItem,
			// Token: 0x04032725 RID: 206629
			ReceiveButton
		}
	}
}
