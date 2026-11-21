using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity
{
	// Token: 0x020054C2 RID: 21698
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityMatchThreeSubView : ActivitySubViewBase
	{
		// Token: 0x06035C80 RID: 220288 RVA: 0x00F065C1 File Offset: 0x00F047C1
		protected override void OnSetData()
		{
			this.MatchThreeData = (this.ActivityBaseData as ActivityMatchThreeData);
		}

		// Token: 0x06035C81 RID: 220289 RVA: 0x00F065D4 File Offset: 0x00F047D4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06035C82 RID: 220290 RVA: 0x00F06660 File Offset: 0x00F04860
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityMatchThreeSubView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityMatchThreeSubView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035C83 RID: 220291 RVA: 0x00F066A3 File Offset: 0x00F048A3
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnActivityRedDotRefresh));
			EventSystem.Instance.Add<int>(EEventName.OnMatchThreeChallengeStateUpdate, new Action<int>(this.OnChallengeStateUpdate));
		}

		// Token: 0x06035C84 RID: 220292 RVA: 0x00F066DD File Offset: 0x00F048DD
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnActivityRedDotRefresh));
			EventSystem.Instance.Remove<int>(EEventName.OnMatchThreeChallengeStateUpdate, new Action<int>(this.OnChallengeStateUpdate));
		}

		// Token: 0x06035C85 RID: 220293 RVA: 0x00F06717 File Offset: 0x00F04917
		protected override void OnStart()
		{
			this.RefreshProgress();
			this.RefreshRedDot();
		}

		// Token: 0x06035C86 RID: 220294 RVA: 0x00F06725 File Offset: 0x00F04925
		protected override void OnRefreshView()
		{
			ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
			if (commonInfoPanel != null)
			{
				commonInfoPanel.OnRefreshView();
			}
			this.RefreshProgress();
			this.RefreshRedDot();
		}

		// Token: 0x06035C87 RID: 220295 RVA: 0x00F06744 File Offset: 0x00F04944
		private void RefreshProgress()
		{
			if (this.MatchThreeData == null)
			{
				return;
			}
			bool preGuideQuestFinishState = this.MatchThreeData.GetPreGuideQuestFinishState();
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(preGuideQuestFinishState);
			}
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetUIActive(preGuideQuestFinishState);
			}
			if (!preGuideQuestFinishState)
			{
				return;
			}
			int completeChallengeCount = this.MatchThreeData.GetCompleteChallengeCount();
			int displayChallengeCount = this.MatchThreeData.GetDisplayChallengeCount();
			UUIText text2 = base.GetText(2);
			if (text2 == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(completeChallengeCount);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(displayChallengeCount);
			text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x06035C88 RID: 220296 RVA: 0x00F067E6 File Offset: 0x00F049E6
		private void RefreshRedDot()
		{
			if (this.MatchThreeData == null || this.CommonInfoPanel == null)
			{
				return;
			}
			this.CommonInfoPanel.SetFunctionRedDotVisible(this.MatchThreeData.GetExDataRedPointShowState());
		}

		// Token: 0x06035C89 RID: 220297 RVA: 0x00F0680F File Offset: 0x00F04A0F
		private void OnClickedGo(ActivityBaseData _)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				if (GameModeModel.Instance.IsMulti)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("Farm_ConnectBan", Array.Empty<object>());
					return;
				}
				if (this.MatchThreeData == null)
				{
					return;
				}
				if (!this.MatchThreeData.GetPreGuideQuestFinishState())
				{
					int unFinishPreGuideQuestId = this.MatchThreeData.GetUnFinishPreGuideQuestId();
					UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
					return;
				}
				UiManager.Instance.OpenView(EUiViewName.MatchThreeSelectLevelView, null, null);
			});
		}

		// Token: 0x06035C8A RID: 220298 RVA: 0x00F0682D File Offset: 0x00F04A2D
		private void OnActivityRedDotRefresh(int activityId)
		{
			if (this.MatchThreeData == null || activityId != this.MatchThreeData.Id)
			{
				return;
			}
			this.RefreshProgress();
			this.RefreshRedDot();
		}

		// Token: 0x06035C8B RID: 220299 RVA: 0x00F06852 File Offset: 0x00F04A52
		private void OnChallengeStateUpdate(int challengeId)
		{
			this.RefreshProgress();
			this.RefreshRedDot();
		}

		// Token: 0x0401C749 RID: 116553
		private ActivityMatchThreeData MatchThreeData;

		// Token: 0x0401C74A RID: 116554
		protected ActivitySubViewGeneralInfo CommonInfoPanel;
	}
}
