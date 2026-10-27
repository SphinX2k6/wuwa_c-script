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
	// Token: 0x02006544 RID: 25924
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityMatchThreeSubView : ActivitySubViewBase
	{
		// Token: 0x06040FBB RID: 266171 RVA: 0x00FBF5D1 File Offset: 0x00FBD7D1
		protected override void OnSetData()
		{
			this.MatchThreeData = (this.ActivityBaseData as ActivityMatchThreeData);
		}

		// Token: 0x06040FBC RID: 266172 RVA: 0x00FBF5E4 File Offset: 0x00FBD7E4
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

		// Token: 0x06040FBD RID: 266173 RVA: 0x00FBF670 File Offset: 0x00FBD870
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityMatchThreeSubView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityMatchThreeSubView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040FBE RID: 266174 RVA: 0x00FBF6B3 File Offset: 0x00FBD8B3
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnActivityRedDotRefresh));
			EventSystem.Instance.Add<int>(EEventName.OnMatchThreeChallengeStateUpdate, new Action<int>(this.OnChallengeStateUpdate));
		}

		// Token: 0x06040FBF RID: 266175 RVA: 0x00FBF6ED File Offset: 0x00FBD8ED
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnActivityRedDotRefresh));
			EventSystem.Instance.Remove<int>(EEventName.OnMatchThreeChallengeStateUpdate, new Action<int>(this.OnChallengeStateUpdate));
		}

		// Token: 0x06040FC0 RID: 266176 RVA: 0x00FBF727 File Offset: 0x00FBD927
		protected override void OnStart()
		{
			this.RefreshProgress();
			this.RefreshRedDot();
		}

		// Token: 0x06040FC1 RID: 266177 RVA: 0x00FBF735 File Offset: 0x00FBD935
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

		// Token: 0x06040FC2 RID: 266178 RVA: 0x00FBF754 File Offset: 0x00FBD954
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

		// Token: 0x06040FC3 RID: 266179 RVA: 0x00FBF7F6 File Offset: 0x00FBD9F6
		private void RefreshRedDot()
		{
			if (this.MatchThreeData == null || this.CommonInfoPanel == null)
			{
				return;
			}
			this.CommonInfoPanel.SetFunctionRedDotVisible(this.MatchThreeData.GetExDataRedPointShowState());
		}

		// Token: 0x06040FC4 RID: 266180 RVA: 0x00FBF81F File Offset: 0x00FBDA1F
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

		// Token: 0x06040FC5 RID: 266181 RVA: 0x00FBF83D File Offset: 0x00FBDA3D
		private void OnActivityRedDotRefresh(int activityId)
		{
			if (this.MatchThreeData == null || activityId != this.MatchThreeData.Id)
			{
				return;
			}
			this.RefreshProgress();
			this.RefreshRedDot();
		}

		// Token: 0x06040FC6 RID: 266182 RVA: 0x00FBF862 File Offset: 0x00FBDA62
		private void OnChallengeStateUpdate(int challengeId)
		{
			this.RefreshProgress();
			this.RefreshRedDot();
		}

		// Token: 0x04021E18 RID: 138776
		private ActivityMatchThreeData MatchThreeData;

		// Token: 0x04021E19 RID: 138777
		protected ActivitySubViewGeneralInfo CommonInfoPanel;
	}
}
