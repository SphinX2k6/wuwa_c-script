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
	// Token: 0x0200439A RID: 17306
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleScoreProgressPanel : UiPanelBase
	{
		// Token: 0x0602BB70 RID: 179056 RVA: 0x00C44FE4 File Offset: 0x00C431E4
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

		// Token: 0x0602BB71 RID: 179057 RVA: 0x00C45030 File Offset: 0x00C43230
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

		// Token: 0x0602BB72 RID: 179058 RVA: 0x00C450CC File Offset: 0x00C432CC
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleScoreProgressPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleScoreProgressPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BB73 RID: 179059 RVA: 0x00C4510F File Offset: 0x00C4330F
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

		// Token: 0x0602BB74 RID: 179060 RVA: 0x00C45134 File Offset: 0x00C43334
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

		// Token: 0x0602BB75 RID: 179061 RVA: 0x00C451E5 File Offset: 0x00C433E5
		protected void TimerUpdatePercentHandle(float _)
		{
			this.UpdatePercentHandle();
		}

		// Token: 0x0602BB76 RID: 179062 RVA: 0x00C451F0 File Offset: 0x00C433F0
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

		// Token: 0x0602BB77 RID: 179063 RVA: 0x00C45231 File Offset: 0x00C43431
		private MoraleScoreProgressPercentItem CreatePercentItem()
		{
			return new MoraleScoreProgressPercentItem();
		}

		// Token: 0x0602BB78 RID: 179064 RVA: 0x00C45238 File Offset: 0x00C43438
		private MoraleScoreProgressRewardItem CreateRewardItem()
		{
			return new MoraleScoreProgressRewardItem
			{
				ClickCallBack = new Action<MoraleProgressRewardData>(this.OnClickRewardItem)
			};
		}

		// Token: 0x0602BB79 RID: 179065 RVA: 0x00C45251 File Offset: 0x00C43451
		private void OnClickRewardItem(MoraleProgressRewardData data)
		{
			if (data.IsCanReceived)
			{
				MoraleModel.Instance.RequestProgressReward(data.Id, true);
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(data.ItemId, true, null, false);
		}

		// Token: 0x0401790C RID: 96524
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<MoraleScoreProgressPercentItem, MoraleProgressRewardData> RewardPercentLayout;

		// Token: 0x0401790D RID: 96525
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<MoraleScoreProgressRewardItem, MoraleProgressRewardData> RewardRewardLayout;

		// Token: 0x0200A08D RID: 41101
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04031E26 RID: 204326
			public const int TxtSumScoreProgress = 0;

			// Token: 0x04031E27 RID: 204327
			public const int TxtSumProgressTitle = 1;

			// Token: 0x04031E28 RID: 204328
			public const int LayoutPercent = 2;

			// Token: 0x04031E29 RID: 204329
			public const int ItemPercent = 3;

			// Token: 0x04031E2A RID: 204330
			public const int LayoutReward = 4;

			// Token: 0x04031E2B RID: 204331
			public const int ItemReward = 5;
		}
	}
}
