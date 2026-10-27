using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x020053B7 RID: 21431
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleScoreProgressPanel : UiPanelBase
	{
		// Token: 0x06036C2A RID: 224298 RVA: 0x00CF5F3C File Offset: 0x00CF413C
		public UniTask Init(UUIItem item)
		{
			MoraleScoreProgressPanel.<Init>d__3 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MoraleScoreProgressPanel.<Init>d__3>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06036C2B RID: 224299 RVA: 0x00CF5F88 File Offset: 0x00CF4188
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
		}

		// Token: 0x06036C2C RID: 224300 RVA: 0x00CF6024 File Offset: 0x00CF4224
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleScoreProgressPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleScoreProgressPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036C2D RID: 224301 RVA: 0x00CF6067 File Offset: 0x00CF4267
		public void UpdateData()
		{
			this.UpdateDataExcludeReward();
			GenericLayout<MoraleScoreProgressRewardItem, MoraleProgressRewardData> rewardRewardLayout = this.RewardRewardLayout;
			if (rewardRewardLayout == null)
			{
				return;
			}
			rewardRewardLayout.RefreshByData(MoraleModel.Instance.ProgressRewardList, null, false);
		}

		// Token: 0x06036C2E RID: 224302 RVA: 0x00CF608C File Offset: 0x00CF428C
		public void UpdateDataExcludeReward()
		{
			MoraleModel instance = MoraleModel.Instance;
			GenericLayout<MoraleScoreProgressPercentItem, MoraleProgressRewardData> rewardPercentLayout = this.RewardPercentLayout;
			if (rewardPercentLayout != null)
			{
				rewardPercentLayout.RefreshByData(instance.ProgressRewardList, new Action(this.UpdatePercentHandle), false);
			}
			GenericLayout<MoraleScoreProgressPercentItem, MoraleProgressRewardData> rewardPercentLayout2 = this.RewardPercentLayout;
			if (rewardPercentLayout2 != null)
			{
				rewardPercentLayout2.BindLateUpdate(delegate(float _)
				{
					TimerSystem.Instance.Next(new TTimerAction(this.TimerUpdatePercentHandle), null, null);
					GenericLayout<MoraleScoreProgressPercentItem, MoraleProgressRewardData> rewardPercentLayout3 = this.RewardPercentLayout;
					if (rewardPercentLayout3 == null)
					{
						return;
					}
					rewardPercentLayout3.UnBindLateUpdate();
				});
			}
			int currentProgressScore = instance.GetCurrentProgressScore();
			int progressTotalScore = instance.GetProgressTotalScore();
			UUIText text = base.GetText(0);
			string textStringId = "Morale_title_17";
			LguiUtil.Instance.SetLocalTextNew(text, textStringId, new <>z__ReadOnlyArray<object>(new object[]
			{
				currentProgressScore,
				progressTotalScore
			}));
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			text2.ShowTextNew("Morale_title_1");
		}

		// Token: 0x06036C2F RID: 224303 RVA: 0x00CF613D File Offset: 0x00CF433D
		protected void TimerUpdatePercentHandle(float _)
		{
			this.UpdatePercentHandle();
		}

		// Token: 0x06036C30 RID: 224304 RVA: 0x00CF6148 File Offset: 0x00CF4348
		protected void UpdatePercentHandle()
		{
			GenericLayout<MoraleScoreProgressPercentItem, MoraleProgressRewardData> rewardPercentLayout = this.RewardPercentLayout;
			List<MoraleScoreProgressPercentItem> list = (rewardPercentLayout != null) ? rewardPercentLayout.GetLayoutItemList() : null;
			if (list == null)
			{
				return;
			}
			for (int i = 0; i < list.Count; i++)
			{
				list[i].UpdatePercentHandle();
			}
		}

		// Token: 0x06036C31 RID: 224305 RVA: 0x00CF6189 File Offset: 0x00CF4389
		private MoraleScoreProgressPercentItem CreatePercentItem()
		{
			return new MoraleScoreProgressPercentItem();
		}

		// Token: 0x06036C32 RID: 224306 RVA: 0x00CF6190 File Offset: 0x00CF4390
		private MoraleScoreProgressRewardItem CreateRewardItem()
		{
			return new MoraleScoreProgressRewardItem
			{
				ClickCallBack = new Action<MoraleProgressRewardData>(this.OnClickRewardItem)
			};
		}

		// Token: 0x06036C33 RID: 224307 RVA: 0x00CF61A9 File Offset: 0x00CF43A9
		private void OnClickRewardItem(MoraleProgressRewardData data)
		{
			if (data.IsCanReceived)
			{
				MoraleModel.Instance.RequestProgressReward(data.Id, true);
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(data.ItemId, true, null);
		}

		// Token: 0x0401CE74 RID: 118388
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<MoraleScoreProgressPercentItem, MoraleProgressRewardData> RewardPercentLayout;

		// Token: 0x0401CE75 RID: 118389
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<MoraleScoreProgressRewardItem, MoraleProgressRewardData> RewardRewardLayout;

		// Token: 0x0200B655 RID: 46677
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040373D1 RID: 226257
			public const int TxtSumScoreProgress = 0;

			// Token: 0x040373D2 RID: 226258
			public const int TxtSumProgressTitle = 1;

			// Token: 0x040373D3 RID: 226259
			public const int LayoutPercent = 2;

			// Token: 0x040373D4 RID: 226260
			public const int ItemPercent = 3;

			// Token: 0x040373D5 RID: 226261
			public const int LayoutReward = 4;

			// Token: 0x040373D6 RID: 226262
			public const int ItemReward = 5;
		}
	}
}
