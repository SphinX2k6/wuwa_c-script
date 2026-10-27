using System;
using System.Collections.Generic;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A43 RID: 23107
	public class FlagChallengeActivityRewardEntranceItem : UiPanelBase
	{
		// Token: 0x0603A9B4 RID: 240052 RVA: 0x00DF3204 File Offset: 0x00DF1404
		public FlagChallengeActivityRewardEntranceItem(int activityId)
		{
			this.ActivityId = activityId;
		}

		// Token: 0x0603A9B5 RID: 240053 RVA: 0x00DF3214 File Offset: 0x00DF1414
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnRewardBtnClick))
			};
		}

		// Token: 0x0603A9B6 RID: 240054 RVA: 0x00DF32A8 File Offset: 0x00DF14A8
		protected override void OnStart()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotFlagChallengeActivityReward, base.GetItem(2), null, this.ActivityId);
			this.RefreshProgress();
			EventSystem.Instance.Add<int>(EEventName.OnFlagChallengeTaskUpdate, new Action<int>(this.OnTaskUpdate));
		}

		// Token: 0x0603A9B7 RID: 240055 RVA: 0x00DF32F4 File Offset: 0x00DF14F4
		protected override void OnBeforeDestroy()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotFlagChallengeActivityReward, base.GetItem(2), this.ActivityId);
			EventSystem.Instance.Remove(EEventName.OnFlagChallengeTaskUpdate, new Action<int>(this.OnTaskUpdate));
		}

		// Token: 0x0603A9B8 RID: 240056 RVA: 0x00DF3330 File Offset: 0x00DF1530
		private void RefreshProgress()
		{
			FlagChallengeData flagChallengeData = FlagChallengeModel.Instance.GetFlagChallengeData(this.ActivityId);
			base.GetText(3).SetText(flagChallengeData.GetTaskProgressText(), true);
		}

		// Token: 0x0603A9B9 RID: 240057 RVA: 0x00DF3361 File Offset: 0x00DF1561
		private void OnRewardBtnClick()
		{
			FlagChallengeController.Instance.OpenFlagChallengeTaskView(this.ActivityId);
		}

		// Token: 0x0603A9BA RID: 240058 RVA: 0x00DF3373 File Offset: 0x00DF1573
		private void OnTaskUpdate(int activityId)
		{
			if (activityId != this.ActivityId)
			{
				return;
			}
			this.RefreshProgress();
		}

		// Token: 0x0401E87E RID: 125054
		private int ActivityId;
	}
}
