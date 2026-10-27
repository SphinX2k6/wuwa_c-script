using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x02004881 RID: 18561
	public class VillageInfrTaskBottomPanel : UiPanelBase
	{
		// Token: 0x060308FE RID: 198910 RVA: 0x00B4773C File Offset: 0x00B4593C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUISprite))
			};
		}

		// Token: 0x060308FF RID: 198911 RVA: 0x00B477C2 File Offset: 0x00B459C2
		protected override void OnStart()
		{
			this.CreateRewardLayout();
			this.Refresh();
		}

		// Token: 0x06030900 RID: 198912 RVA: 0x00B477D0 File Offset: 0x00B459D0
		public void Refresh()
		{
			this.RefreshReward();
		}

		// Token: 0x06030901 RID: 198913 RVA: 0x00B477D8 File Offset: 0x00B459D8
		private void CreateRewardLayout()
		{
			this.RewardLayout = new GenericLayout<RewardItem, int>(base.GetHorizontalLayout(1), () => new RewardItem(), null, false, true);
		}

		// Token: 0x06030902 RID: 198914 RVA: 0x00B47810 File Offset: 0x00B45A10
		public void RefreshReward()
		{
			List<InfrV2ScoreReward> list = new List<InfrV2ScoreReward>(VillageInfrConfig.Instance.GetScoreReward());
			list.Sort((InfrV2ScoreReward a, InfrV2ScoreReward b) => a.Score - b.Score);
			List<int> list2 = new List<int>();
			foreach (InfrV2ScoreReward infrV2ScoreReward in list)
			{
				list2.Add(infrV2ScoreReward.Id);
			}
			this.RewardLayout.RefreshByData(list2, null, false);
			InfrV2ScoreReward infrV2ScoreReward2 = list[0];
			foreach (InfrV2ScoreReward infrV2ScoreReward3 in list)
			{
				if (infrV2ScoreReward3.Score > infrV2ScoreReward2.Score)
				{
					infrV2ScoreReward2 = infrV2ScoreReward3;
				}
			}
			int score = infrV2ScoreReward2.Score;
			int rewardScore = VillageInfrModel.Instance.GetRewardScore();
			base.GetText(0).SetText(rewardScore.ToString(), true);
			base.GetSprite(4).SetFillAmount((float)Math.Min((double)rewardScore / (double)score, 1.0));
		}

		// Token: 0x0401A180 RID: 106880
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RewardItem, int> RewardLayout;
	}
}
