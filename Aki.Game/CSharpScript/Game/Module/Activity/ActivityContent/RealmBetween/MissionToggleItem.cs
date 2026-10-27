using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x0200629B RID: 25243
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MissionToggleItem : GridProxyAbstract<ActivityTaskData>
	{
		// Token: 0x0603F816 RID: 260118 RVA: 0x00F5AB44 File Offset: 0x00F58D44
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem))
			};
		}

		// Token: 0x0603F817 RID: 260119 RVA: 0x00F5AC0C File Offset: 0x00F58E0C
		protected override UniTask OnBeforeStartAsync()
		{
			MissionToggleItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MissionToggleItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F818 RID: 260120 RVA: 0x00F5AC50 File Offset: 0x00F58E50
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData>(base.GetScrollViewWithScrollbar(2), () => new ActivitySmallItemGrid(), null, false, null);
			this.GotoButton.SetLocalTextNew("RealmBetweenJump_Text", Array.Empty<object>());
			this.RewardButton.SetLocalTextNew("RealmBetweenGetReward_Text", Array.Empty<object>());
		}

		// Token: 0x0603F819 RID: 260121 RVA: 0x00F5ACBC File Offset: 0x00F58EBC
		public override void Refresh(ActivityTaskData taskData, bool isSelected, int gridIndex)
		{
			this.TaskData = taskData;
			RealmBetweenChallenge value = ActivityRealmBetweenConfig.Instance.GetMotorChallengeConfig(this.TaskData.Id).Value;
			bool uiactive = taskData.Status == EActivityTaskState.FinishedAndClaimed;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), value.ScoreText, Array.Empty<object>());
			UUIText text = base.GetText(1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(taskData.Current);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(taskData.Target);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			this.RefreshRewardData(value.Reward);
			this.RewardButton.SetUiActive(taskData.Status == EActivityTaskState.FinishedAndUnclaimed);
			base.GetItem(4).SetUIActive(taskData.Status == EActivityTaskState.Active);
			base.GetItem(7).SetUIActive(uiactive);
		}

		// Token: 0x0603F81A RID: 260122 RVA: 0x00F5AD9B File Offset: 0x00F58F9B
		public void SetClickRewardCb(Action clickRewardCb)
		{
			this.OnClickRewardCb = clickRewardCb;
		}

		// Token: 0x0603F81B RID: 260123 RVA: 0x00F5ADA4 File Offset: 0x00F58FA4
		private void RefreshRewardData(int rewardId)
		{
			List<IItemGridData> list = new List<IItemGridData>();
			foreach (TItem item in CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(rewardId))
			{
				ItemGridData item2 = new ItemGridData
				{
					Item = item,
					HasClaimed = (this.TaskData.Status == EActivityTaskState.FinishedAndClaimed)
				};
				list.Add(item2);
			}
			this.RewardScrollView.RefreshByData(list, null, false);
		}

		// Token: 0x0603F81C RID: 260124 RVA: 0x00F5AE34 File Offset: 0x00F59034
		private void OnClickedRewardButton()
		{
			Action onClickRewardCb = this.OnClickRewardCb;
			if (onClickRewardCb == null)
			{
				return;
			}
			onClickRewardCb();
		}

		// Token: 0x04021335 RID: 135989
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

		// Token: 0x04021336 RID: 135990
		private ActivityButtonItem GotoButton;

		// Token: 0x04021337 RID: 135991
		private ActivityButtonItem RewardButton;

		// Token: 0x04021338 RID: 135992
		private ActivityTaskData TaskData;

		// Token: 0x04021339 RID: 135993
		[Nullable(2)]
		private Action OnClickRewardCb;
	}
}
