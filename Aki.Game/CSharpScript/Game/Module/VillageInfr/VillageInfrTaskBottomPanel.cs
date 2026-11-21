using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x020037F8 RID: 14328
	public class VillageInfrTaskBottomPanel : UiPanelBase
	{
		// Token: 0x0602542A RID: 152618 RVA: 0x00A82510 File Offset: 0x00A80710
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

		// Token: 0x0602542B RID: 152619 RVA: 0x00A82596 File Offset: 0x00A80796
		protected override void OnStart()
		{
			this.CreateRewardLayout();
			this.Refresh();
		}

		// Token: 0x0602542C RID: 152620 RVA: 0x00A825A4 File Offset: 0x00A807A4
		public void Refresh()
		{
			this.RefreshReward();
		}

		// Token: 0x0602542D RID: 152621 RVA: 0x00A825AC File Offset: 0x00A807AC
		private void CreateRewardLayout()
		{
			this.RewardLayout = new GenericLayout<RewardItem, int>(base.GetHorizontalLayout(1), () => new RewardItem(), null, false, true);
		}

		// Token: 0x0602542E RID: 152622 RVA: 0x00A825E4 File Offset: 0x00A807E4
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

		// Token: 0x040149F3 RID: 84467
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RewardItem, int> RewardLayout;
	}
}
