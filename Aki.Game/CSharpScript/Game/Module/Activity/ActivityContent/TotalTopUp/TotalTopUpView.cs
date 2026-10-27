using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005FC5 RID: 24517
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpView : ActivitySubViewBase
	{
		// Token: 0x0603E22B RID: 254507 RVA: 0x00F01AC8 File Offset: 0x00EFFCC8
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

		// Token: 0x0603E22C RID: 254508 RVA: 0x00F01BD4 File Offset: 0x00EFFDD4
		protected override UniTask OnBeforeStartAsync()
		{
			TotalTopUpView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TotalTopUpView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E22D RID: 254509 RVA: 0x00F01C18 File Offset: 0x00EFFE18
		protected override void OnStart()
		{
			TotalTopUpData totalTopUpData = this.ActivityBaseData as TotalTopUpData;
			if (totalTopUpData != null)
			{
				this.Refresh(totalTopUpData);
			}
		}

		// Token: 0x0603E22E RID: 254510 RVA: 0x00F01C3C File Offset: 0x00EFFE3C
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

		// Token: 0x0603E22F RID: 254511 RVA: 0x00F01CAC File Offset: 0x00EFFEAC
		protected override void OnRefreshView()
		{
			TotalTopUpUtil.Debug("TotalTopUpView刷新", default(ReadOnlySpan<ValueTuple<string, object>>));
			TotalTopUpData totalTopUpData = this.ActivityBaseData as TotalTopUpData;
			if (totalTopUpData != null)
			{
				this.Refresh(totalTopUpData);
			}
		}

		// Token: 0x0603E230 RID: 254512 RVA: 0x00F01CE4 File Offset: 0x00EFFEE4
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

		// Token: 0x04020761 RID: 132961
		private readonly List<TotalTopUpPageRewardItem> RewardPanels = new List<TotalTopUpPageRewardItem>();

		// Token: 0x04020762 RID: 132962
		[Nullable(2)]
		private TotalTopUpPageProgressPanel ProgressPanel;

		// Token: 0x04020763 RID: 132963
		[Nullable(2)]
		private TotalTopUpPageTitlePanel TitlePanel;

		// Token: 0x04020764 RID: 132964
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

		// Token: 0x0200C29B RID: 49819
		[NullableContext(0)]
		private class ENode
		{
			// Token: 0x0403AC9A RID: 240794
			public const int ItemReward0 = 0;

			// Token: 0x0403AC9B RID: 240795
			public const int ItemReward1 = 1;

			// Token: 0x0403AC9C RID: 240796
			public const int ItemReward2 = 2;

			// Token: 0x0403AC9D RID: 240797
			public const int ItemReward3 = 3;

			// Token: 0x0403AC9E RID: 240798
			public const int ItemReward4 = 4;

			// Token: 0x0403AC9F RID: 240799
			public const int ItemReward5 = 5;

			// Token: 0x0403ACA0 RID: 240800
			public const int ItemReward6 = 6;

			// Token: 0x0403ACA1 RID: 240801
			public const int ItemReward7 = 7;

			// Token: 0x0403ACA2 RID: 240802
			public const int ItemRewardIsolate = 8;

			// Token: 0x0403ACA3 RID: 240803
			public const int ItemTitlePanel = 9;

			// Token: 0x0403ACA4 RID: 240804
			public const int ItemProgressPanel = 10;
		}
	}
}
