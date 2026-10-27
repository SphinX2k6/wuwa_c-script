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
	// Token: 0x02005C18 RID: 23576
	public class BossPilingSubView : ActivitySubViewBase
	{
		// Token: 0x0603B926 RID: 244006 RVA: 0x00E35144 File Offset: 0x00E33344
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

		// Token: 0x0603B927 RID: 244007 RVA: 0x00E351B0 File Offset: 0x00E333B0
		protected override UniTask OnBeforeStartAsync()
		{
			BossPilingSubView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BossPilingSubView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B928 RID: 244008 RVA: 0x00E351F4 File Offset: 0x00E333F4
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

		// Token: 0x0603B929 RID: 244009 RVA: 0x00E352D5 File Offset: 0x00E334D5
		protected override void OnBeforeHide()
		{
			this.BtnReward.UnBindRedDot();
		}

		// Token: 0x0603B92A RID: 244010 RVA: 0x00E352E2 File Offset: 0x00E334E2
		private void OnClickedReward(int _)
		{
			UiManager.Instance.OpenView(EUiViewName.BossPilingTaskView, null, null);
		}

		// Token: 0x0603B92B RID: 244011 RVA: 0x00E352F5 File Offset: 0x00E334F5
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

		// Token: 0x0401F04D RID: 127053
		[Nullable(1)]
		protected ButtonItem BtnReward;

		// Token: 0x0401F04E RID: 127054
		[Nullable(1)]
		protected ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x0200BE03 RID: 48643
		private enum EDefine
		{
			// Token: 0x040394B3 RID: 234675
			CommonActivityInfoItem,
			// Token: 0x040394B4 RID: 234676
			BtnCircle
		}
	}
}
