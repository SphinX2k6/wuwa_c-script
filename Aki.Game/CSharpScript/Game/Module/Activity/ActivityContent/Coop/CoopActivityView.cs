using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x020068CA RID: 26826
	[NullableContext(2)]
	[Nullable(0)]
	public class CoopActivityView : ActivitySubViewBase
	{
		// Token: 0x06042F3B RID: 274235 RVA: 0x0104E2E0 File Offset: 0x0104C4E0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
		}

		// Token: 0x06042F3C RID: 274236 RVA: 0x0104E37C File Offset: 0x0104C57C
		protected override void OnSetData()
		{
			this.Data = (this.ActivityBaseData as CoopActivityData);
		}

		// Token: 0x06042F3D RID: 274237 RVA: 0x0104E390 File Offset: 0x0104C590
		protected override UniTask OnBeforeStartAsync()
		{
			CoopActivityView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CoopActivityView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042F3E RID: 274238 RVA: 0x0104E3D4 File Offset: 0x0104C5D4
		protected override void OnBeforeShow()
		{
			ActivitySubViewGeneralInfo generalInfo = this.GeneralInfo;
			if (generalInfo != null)
			{
				generalInfo.SetBtnText("Coop_Role_Tracking_Task", Array.Empty<object>());
			}
			ActivitySubViewGeneralInfo generalInfo2 = this.GeneralInfo;
			if (generalInfo2 != null)
			{
				generalInfo2.SetFunctionRedDotVisible(this.Data.IsAnyRoleHasRedDot() || this.Data.IsHasCoopSpRewardRedDot());
			}
			this.RefreshRewardButton();
		}

		// Token: 0x06042F3F RID: 274239 RVA: 0x0104E42E File Offset: 0x0104C62E
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06042F40 RID: 274240 RVA: 0x0104E44C File Offset: 0x0104C64C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06042F41 RID: 274241 RVA: 0x0104E46C File Offset: 0x0104C66C
		private void RefreshRewardButton()
		{
			int claimedRewardCount = this.Data.GetClaimedRewardCount();
			CoopRewardButton rewardButton = this.RewardButton;
			if (rewardButton != null)
			{
				rewardButton.RefreshRewardCount(claimedRewardCount);
			}
			CoopRewardButton rewardButton2 = this.RewardButton;
			if (rewardButton2 == null)
			{
				return;
			}
			rewardButton2.SetRedDotShow(this.Data.IsHasCoopSpRewardRedDot());
		}

		// Token: 0x06042F42 RID: 274242 RVA: 0x0104E4B4 File Offset: 0x0104C6B4
		private void OnRefreshCommonActivityRedDot(int id)
		{
			CoopActivityData data = this.Data;
			int? num = (data != null) ? new int?(data.Id) : null;
			if (!(id == num.GetValueOrDefault() & num != null))
			{
				return;
			}
			ActivitySubViewGeneralInfo generalInfo = this.GeneralInfo;
			if (generalInfo != null)
			{
				generalInfo.SetFunctionRedDotVisible(this.Data.IsAnyRoleHasRedDot() || this.Data.IsHasCoopSpRewardRedDot());
			}
			this.RefreshRewardButton();
		}

		// Token: 0x06042F43 RID: 274243 RVA: 0x0104E528 File Offset: 0x0104C728
		private void OnBtnClick(ActivityBaseData _)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				UiManager.Instance.OpenView(EUiViewName.CoopEntranceView, this.Data, null);
			});
		}

		// Token: 0x06042F44 RID: 274244 RVA: 0x0104E546 File Offset: 0x0104C746
		private void OnClickRewardBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.CoopSpRewardView, this.Data, null);
		}

		// Token: 0x04022D39 RID: 142649
		protected CoopActivityData Data;

		// Token: 0x04022D3A RID: 142650
		protected ActivitySubViewGeneralInfo GeneralInfo;

		// Token: 0x04022D3B RID: 142651
		private CoopRewardButton RewardButton;
	}
}
