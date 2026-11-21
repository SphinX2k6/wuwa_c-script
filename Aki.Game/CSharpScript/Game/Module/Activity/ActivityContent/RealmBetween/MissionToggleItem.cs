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
	// Token: 0x02005219 RID: 21017
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MissionToggleItem : GridProxyAbstract<ActivityTaskData>
	{
		// Token: 0x060344D7 RID: 214231 RVA: 0x00EA1AA0 File Offset: 0x00E9FCA0
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

		// Token: 0x060344D8 RID: 214232 RVA: 0x00EA1B68 File Offset: 0x00E9FD68
		protected override UniTask OnBeforeStartAsync()
		{
			MissionToggleItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MissionToggleItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060344D9 RID: 214233 RVA: 0x00EA1BAC File Offset: 0x00E9FDAC
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData>(base.GetScrollViewWithScrollbar(2), () => new ActivitySmallItemGrid(), null, false, null);
			this.GotoButton.SetLocalTextNew("RealmBetweenJump_Text", Array.Empty<object>());
			this.RewardButton.SetLocalTextNew("RealmBetweenGetReward_Text", Array.Empty<object>());
		}

		// Token: 0x060344DA RID: 214234 RVA: 0x00EA1C18 File Offset: 0x00E9FE18
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

		// Token: 0x060344DB RID: 214235 RVA: 0x00EA1CF7 File Offset: 0x00E9FEF7
		public void SetClickRewardCb(Action clickRewardCb)
		{
			this.OnClickRewardCb = clickRewardCb;
		}

		// Token: 0x060344DC RID: 214236 RVA: 0x00EA1D00 File Offset: 0x00E9FF00
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

		// Token: 0x060344DD RID: 214237 RVA: 0x00EA1D90 File Offset: 0x00E9FF90
		private void OnClickedRewardButton()
		{
			Action onClickRewardCb = this.OnClickRewardCb;
			if (onClickRewardCb == null)
			{
				return;
			}
			onClickRewardCb();
		}

		// Token: 0x0401BC64 RID: 113764
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

		// Token: 0x0401BC65 RID: 113765
		private ActivityButtonItem GotoButton;

		// Token: 0x0401BC66 RID: 113766
		private ActivityButtonItem RewardButton;

		// Token: 0x0401BC67 RID: 113767
		private ActivityTaskData TaskData;

		// Token: 0x0401BC68 RID: 113768
		[Nullable(2)]
		private Action OnClickRewardCb;
	}
}
