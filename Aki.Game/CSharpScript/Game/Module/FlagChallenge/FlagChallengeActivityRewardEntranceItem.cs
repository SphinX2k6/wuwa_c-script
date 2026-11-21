using System;
using System.Collections.Generic;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A1F RID: 18975
	public class FlagChallengeActivityRewardEntranceItem : UiPanelBase
	{
		// Token: 0x0602F8FD RID: 194813 RVA: 0x00D43788 File Offset: 0x00D41988
		public FlagChallengeActivityRewardEntranceItem(int activityId)
		{
			this.ActivityId = activityId;
		}

		// Token: 0x0602F8FE RID: 194814 RVA: 0x00D43798 File Offset: 0x00D41998
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

		// Token: 0x0602F8FF RID: 194815 RVA: 0x00D4382C File Offset: 0x00D41A2C
		protected override void OnStart()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotFlagChallengeActivityReward, base.GetItem(2), null, this.ActivityId);
			this.RefreshProgress();
			EventSystem.Instance.Add<int>(EEventName.OnFlagChallengeTaskUpdate, new Action<int>(this.OnTaskUpdate));
		}

		// Token: 0x0602F900 RID: 194816 RVA: 0x00D43878 File Offset: 0x00D41A78
		protected override void OnBeforeDestroy()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotFlagChallengeActivityReward, base.GetItem(2), this.ActivityId);
			EventSystem.Instance.Remove(EEventName.OnFlagChallengeTaskUpdate, new Action<int>(this.OnTaskUpdate));
		}

		// Token: 0x0602F901 RID: 194817 RVA: 0x00D438B4 File Offset: 0x00D41AB4
		private void RefreshProgress()
		{
			FlagChallengeData flagChallengeData = FlagChallengeModel.Instance.GetFlagChallengeData(this.ActivityId);
			base.GetText(3).SetText(flagChallengeData.GetTaskProgressText(), true);
		}

		// Token: 0x0602F902 RID: 194818 RVA: 0x00D438E5 File Offset: 0x00D41AE5
		private void OnRewardBtnClick()
		{
			FlagChallengeController.Instance.OpenFlagChallengeTaskView(this.ActivityId);
		}

		// Token: 0x0602F903 RID: 194819 RVA: 0x00D438F7 File Offset: 0x00D41AF7
		private void OnTaskUpdate(int activityId)
		{
			if (activityId != this.ActivityId)
			{
				return;
			}
			this.RefreshProgress();
		}

		// Token: 0x04019325 RID: 103205
		private int ActivityId;
	}
}
