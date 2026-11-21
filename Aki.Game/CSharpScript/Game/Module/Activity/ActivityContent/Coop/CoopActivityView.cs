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
	// Token: 0x0200581A RID: 22554
	[NullableContext(2)]
	[Nullable(0)]
	public class CoopActivityView : ActivitySubViewBase
	{
		// Token: 0x06037A93 RID: 227987 RVA: 0x00F8F908 File Offset: 0x00F8DB08
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

		// Token: 0x06037A94 RID: 227988 RVA: 0x00F8F9A4 File Offset: 0x00F8DBA4
		protected override void OnSetData()
		{
			this.Data = (this.ActivityBaseData as CoopActivityData);
		}

		// Token: 0x06037A95 RID: 227989 RVA: 0x00F8F9B8 File Offset: 0x00F8DBB8
		protected override UniTask OnBeforeStartAsync()
		{
			CoopActivityView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CoopActivityView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037A96 RID: 227990 RVA: 0x00F8F9FC File Offset: 0x00F8DBFC
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

		// Token: 0x06037A97 RID: 227991 RVA: 0x00F8FA56 File Offset: 0x00F8DC56
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06037A98 RID: 227992 RVA: 0x00F8FA74 File Offset: 0x00F8DC74
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06037A99 RID: 227993 RVA: 0x00F8FA94 File Offset: 0x00F8DC94
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

		// Token: 0x06037A9A RID: 227994 RVA: 0x00F8FADC File Offset: 0x00F8DCDC
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

		// Token: 0x06037A9B RID: 227995 RVA: 0x00F8FB50 File Offset: 0x00F8DD50
		private void OnBtnClick(ActivityBaseData _)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				UiManager.Instance.OpenView(EUiViewName.CoopEntranceView, this.Data, null);
			});
		}

		// Token: 0x06037A9C RID: 227996 RVA: 0x00F8FB6E File Offset: 0x00F8DD6E
		private void OnClickRewardBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.CoopSpRewardView, this.Data, null);
		}

		// Token: 0x0401D595 RID: 120213
		protected CoopActivityData Data;

		// Token: 0x0401D596 RID: 120214
		protected ActivitySubViewGeneralInfo GeneralInfo;

		// Token: 0x0401D597 RID: 120215
		private CoopRewardButton RewardButton;
	}
}
