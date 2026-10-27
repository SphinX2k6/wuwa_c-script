using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Giant.Activity
{
	// Token: 0x02005990 RID: 22928
	public class GiantActivitySubView : ActivitySubViewBase
	{
		// Token: 0x0603A2DF RID: 238303 RVA: 0x00DD41D0 File Offset: 0x00DD23D0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603A2E0 RID: 238304 RVA: 0x00DD427C File Offset: 0x00DD247C
		protected override UniTask OnBeforeStartAsync()
		{
			GiantActivitySubView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GiantActivitySubView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A2E1 RID: 238305 RVA: 0x00DD42BF File Offset: 0x00DD24BF
		private void OnEnterButtonClick()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
				{
					UiManager.Instance.OpenView(EUiViewName.QuestView, this.ActivityBaseData.GetUnFinishPreGuideQuestId(), null);
					return;
				}
				EventSystem.Instance.Emit<bool>(EEventName.ChangeActivityViewNeedBlurState, false);
				IGiantSystemMainOpenParam param = new GiantSystemMainOpenParam
				{
					ActivityId = this.ActivityBaseData.Id
				};
				UiManager.Instance.OpenView(EUiViewName.GiantSystemMainView, param, null);
			});
		}

		// Token: 0x0603A2E2 RID: 238306 RVA: 0x00DD42DD File Offset: 0x00DD24DD
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotDirty));
		}

		// Token: 0x0603A2E3 RID: 238307 RVA: 0x00DD42FB File Offset: 0x00DD24FB
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotDirty));
		}

		// Token: 0x0603A2E4 RID: 238308 RVA: 0x00DD431C File Offset: 0x00DD251C
		private void OnRedDotDirty(int activityId)
		{
			ActivityBaseData activityBaseData = this.ActivityBaseData;
			int? num = (activityBaseData != null) ? new int?(activityBaseData.Id) : null;
			if (activityId == num.GetValueOrDefault() & num != null)
			{
				GiantActivityInfoPanel infoPanel = this.InfoPanel;
				if (infoPanel == null)
				{
					return;
				}
				infoPanel.RefreshFunctionArea();
			}
		}

		// Token: 0x0603A2E5 RID: 238309 RVA: 0x00DD4370 File Offset: 0x00DD2570
		protected override void OnRefreshView()
		{
			Activity? localConfig = this.ActivityBaseData.LocalConfig;
			if (localConfig == null)
			{
				return;
			}
			this.InfoPanel.SetTitle(this.ActivityBaseData.GetTitle());
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			this.InfoPanel.SetTimer(item, item2);
			this.InfoPanel.SetDesc(localConfig.Value.Desc);
			this.InfoPanel.SetReward(this.ActivityBaseData.GetPreviewReward(null));
			this.InfoPanel.RefreshFunctionArea();
			this.RefreshProgress();
		}

		// Token: 0x0603A2E6 RID: 238310 RVA: 0x00DD4414 File Offset: 0x00DD2614
		private void RefreshProgress()
		{
			bool preGuideQuestFinishState = this.ActivityBaseData.GetPreGuideQuestFinishState();
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(preGuideQuestFinishState);
			}
			if (!preGuideQuestFinishState)
			{
				return;
			}
			GiantModel instance = GiantModel.Instance;
			double num = (instance != null) ? instance.GetTotalStableValue() : 0.0;
			int[] totalNodeGoals = GiantConfig.GetTotalNodeGoals();
			int value = (totalNodeGoals.Length != 0) ? totalNodeGoals[totalNodeGoals.Length - 1] : 0;
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText(num.ToString(), true);
			}
			UUIText text2 = base.GetText(3);
			if (text2 == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0603A2E7 RID: 238311 RVA: 0x00DD44C4 File Offset: 0x00DD26C4
		protected override void OnTimer(float gap)
		{
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			GiantActivityInfoPanel infoPanel = this.InfoPanel;
			if (infoPanel == null)
			{
				return;
			}
			infoPanel.SetTimer(item, item2);
		}

		// Token: 0x0401E5A1 RID: 124321
		[Nullable(2)]
		private GiantActivityInfoPanel InfoPanel;

		// Token: 0x0200BC12 RID: 48146
		private class EComponent
		{
			// Token: 0x04038C46 RID: 232518
			public const int ComActivityInfo = 0;

			// Token: 0x04038C47 RID: 232519
			public const int PnlProgress = 1;

			// Token: 0x04038C48 RID: 232520
			public const int TxtValue01 = 2;

			// Token: 0x04038C49 RID: 232521
			public const int TxtValue02 = 3;
		}
	}
}
