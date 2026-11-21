using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004FAC RID: 20396
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpView : ActivitySubViewBase
	{
		// Token: 0x060331C5 RID: 209349 RVA: 0x00E53784 File Offset: 0x00E51984
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem))
			};
		}

		// Token: 0x060331C6 RID: 209350 RVA: 0x00E53890 File Offset: 0x00E51A90
		protected override UniTask OnBeforeStartAsync()
		{
			TotalTopUpView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TotalTopUpView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060331C7 RID: 209351 RVA: 0x00E538D4 File Offset: 0x00E51AD4
		protected override void OnStart()
		{
			TotalTopUpData totalTopUpData = this.ActivityBaseData as TotalTopUpData;
			if (totalTopUpData != null)
			{
				this.Refresh(totalTopUpData);
			}
		}

		// Token: 0x060331C8 RID: 209352 RVA: 0x00E538F8 File Offset: 0x00E51AF8
		private void Refresh(TotalTopUpData data)
		{
			TotalTopUpPageViewModel pageViewModel = data.PageViewModel;
			for (int i = 0; i < this.RewardPanels.Count; i++)
			{
				TotalTopUpPageRewardItem totalTopUpPageRewardItem = this.RewardPanels[i];
				if (i < pageViewModel.RewardViewModels.Count)
				{
					TotalTopUpPageRewardViewModel totalTopUpPageRewardViewModel = pageViewModel.RewardViewModels[i];
					if (totalTopUpPageRewardViewModel != null)
					{
						totalTopUpPageRewardItem.Refresh(totalTopUpPageRewardViewModel);
					}
				}
			}
			TotalTopUpPageProgressPanel progressPanel = this.ProgressPanel;
			if (progressPanel == null)
			{
				return;
			}
			progressPanel.Refresh(pageViewModel);
		}

		// Token: 0x060331C9 RID: 209353 RVA: 0x00E53968 File Offset: 0x00E51B68
		protected override void OnRefreshView()
		{
			TotalTopUpUtil.Debug("TotalTopUpView刷新", default(ReadOnlySpan<ValueTuple<string, object>>));
			TotalTopUpData totalTopUpData = this.ActivityBaseData as TotalTopUpData;
			if (totalTopUpData != null)
			{
				this.Refresh(totalTopUpData);
			}
		}

		// Token: 0x060331CA RID: 209354 RVA: 0x00E539A0 File Offset: 0x00E51BA0
		protected override void OnTimer(float deltaTime)
		{
			TotalTopUpData totalTopUpData = this.ActivityBaseData as TotalTopUpData;
			if (totalTopUpData == null)
			{
				return;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			double num = (double)totalTopUpData.EndOpenTime - serverTime;
			TotalTopUpPageTitlePanel titlePanel = this.TitlePanel;
			if (titlePanel == null)
			{
				return;
			}
			titlePanel.RefreshTime((long)num);
		}

		// Token: 0x0401B233 RID: 111155
		private readonly List<TotalTopUpPageRewardItem> RewardPanels = new List<TotalTopUpPageRewardItem>();

		// Token: 0x0401B234 RID: 111156
		[Nullable(2)]
		private TotalTopUpPageProgressPanel ProgressPanel;

		// Token: 0x0401B235 RID: 111157
		[Nullable(2)]
		private TotalTopUpPageTitlePanel TitlePanel;

		// Token: 0x0401B236 RID: 111158
		[StaticVariableRuleIgnore]
		private static readonly int[] RewardNodes = new int[]
		{
			8,
			0,
			1,
			2,
			3,
			4,
			5,
			6,
			7
		};

		// Token: 0x0200ACA6 RID: 44198
		[NullableContext(0)]
		private class ENode
		{
			// Token: 0x04035676 RID: 218742
			public const int ItemReward0 = 0;

			// Token: 0x04035677 RID: 218743
			public const int ItemReward1 = 1;

			// Token: 0x04035678 RID: 218744
			public const int ItemReward2 = 2;

			// Token: 0x04035679 RID: 218745
			public const int ItemReward3 = 3;

			// Token: 0x0403567A RID: 218746
			public const int ItemReward4 = 4;

			// Token: 0x0403567B RID: 218747
			public const int ItemReward5 = 5;

			// Token: 0x0403567C RID: 218748
			public const int ItemReward6 = 6;

			// Token: 0x0403567D RID: 218749
			public const int ItemReward7 = 7;

			// Token: 0x0403567E RID: 218750
			public const int ItemRewardIsolate = 8;

			// Token: 0x0403567F RID: 218751
			public const int ItemTitlePanel = 9;

			// Token: 0x04035680 RID: 218752
			public const int ItemProgressPanel = 10;
		}
	}
}
