using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View
{
	// Token: 0x02004BF8 RID: 19448
	public class BossPilingSubView : ActivitySubViewBase
	{
		// Token: 0x06030871 RID: 198769 RVA: 0x00D854A0 File Offset: 0x00D836A0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06030872 RID: 198770 RVA: 0x00D8550C File Offset: 0x00D8370C
		protected override UniTask OnBeforeStartAsync()
		{
			BossPilingSubView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BossPilingSubView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030873 RID: 198771 RVA: 0x00D85550 File Offset: 0x00D83750
		protected override void OnRefreshView()
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityBaseData.Id);
			ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
			if (commonInfoPanel != null)
			{
				commonInfoPanel.OnRefreshView();
			}
			bool functionRedDotVisible = BossPilingModel.Instance.GetActivityData().CheckLevelRedDot();
			this.CommonInfoPanel.SetFunctionRedDotVisible(functionRedDotVisible);
			UiPanelBase btnReward = this.BtnReward;
			ActivityBaseData activityBaseData = this.ActivityBaseData;
			btnReward.SetUiActive(activityBaseData != null && activityBaseData.IsUnLock());
			this.BtnReward.UnBindRedDot();
			this.BtnReward.BindRedDot(ERedDotName.BossPilingReward, 0);
			List<int> taskNumState = BossPilingModel.Instance.GetActivityData().GetTaskNumState();
			ButtonItem btnReward2 = this.BtnReward;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(taskNumState[0]);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(taskNumState[1]);
			btnReward2.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06030874 RID: 198772 RVA: 0x00D85631 File Offset: 0x00D83831
		protected override void OnBeforeHide()
		{
			this.BtnReward.UnBindRedDot();
		}

		// Token: 0x06030875 RID: 198773 RVA: 0x00D8563E File Offset: 0x00D8383E
		private void OnClickedReward(int _)
		{
			UiManager.Instance.OpenView(EUiViewName.BossPilingTaskView, null, null);
		}

		// Token: 0x06030876 RID: 198774 RVA: 0x00D85651 File Offset: 0x00D83851
		[NullableContext(2)]
		private void OnClickedConfirm(ActivityBaseData _)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
				{
					int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
					LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.BossPilingQuestClicked, true);
					UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
					return;
				}
				UiManager.Instance.OpenView(EUiViewName.BossPilingMainView, null, null);
			});
		}

		// Token: 0x04019AFE RID: 105214
		[Nullable(1)]
		protected ButtonItem BtnReward;

		// Token: 0x04019AFF RID: 105215
		[Nullable(1)]
		protected ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x0200A80B RID: 43019
		private enum EDefine
		{
			// Token: 0x04033E76 RID: 212598
			CommonActivityInfoItem,
			// Token: 0x04033E77 RID: 212599
			BtnCircle
		}
	}
}
