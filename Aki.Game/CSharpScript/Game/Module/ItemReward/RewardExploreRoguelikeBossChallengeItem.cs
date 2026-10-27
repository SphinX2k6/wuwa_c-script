using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x02005805 RID: 22533
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreRoguelikeBossChallengeItem : UiPanelBase
	{
		// Token: 0x06039486 RID: 234630 RVA: 0x00D95C04 File Offset: 0x00D93E04
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039487 RID: 234631 RVA: 0x00D95CB0 File Offset: 0x00D93EB0
		protected override UniTask OnBeforeStartAsync()
		{
			RewardExploreRoguelikeBossChallengeItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RewardExploreRoguelikeBossChallengeItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039488 RID: 234632 RVA: 0x00D95CF3 File Offset: 0x00D93EF3
		public void Refresh(IRoguelikeBossChallengeData data)
		{
			RoguelikeResultRecordItem resultRecordItem = this.ResultRecordItem;
			if (resultRecordItem != null)
			{
				resultRecordItem.Refresh(data);
			}
			this.RefreshBossList(data);
		}

		// Token: 0x06039489 RID: 234633 RVA: 0x00D95D10 File Offset: 0x00D93F10
		private void RefreshBossList(IRoguelikeBossChallengeData data)
		{
			RoguelikeConfig instance = RoguelikeConfig.Instance;
			RogueInst? rogueInst = (instance != null) ? instance.GetRogueInstConfig(data.InstId) : null;
			if (rogueInst == null)
			{
				return;
			}
			int num = (rogueInst.Value.SpecialBossIndex > 0) ? (rogueInst.Value.SpecialBossIndex - 1) : -1;
			List<RoguelikeBossChallengeBossData> list = new List<RoguelikeBossChallengeBossData>();
			for (int i = 0; i < data.BossTotalCount; i++)
			{
				RoguelikeBossChallengeBossData roguelikeBossChallengeBossData = new RoguelikeBossChallengeBossData();
				if (i < data.FinishedBossIdList.Count)
				{
					roguelikeBossChallengeBossData.Id = data.FinishedBossIdList[i];
					roguelikeBossChallengeBossData.State = ERoguelikeBossChallengeBossState.Finished;
				}
				else
				{
					if (i == data.FinishedBossIdList.Count && data.CurrentBossId != null)
					{
						int? currentBossId = data.CurrentBossId;
						int num2 = 0;
						if (!(currentBossId.GetValueOrDefault() == num2 & currentBossId != null))
						{
							roguelikeBossChallengeBossData.Id = data.CurrentBossId.Value;
							roguelikeBossChallengeBossData.State = ERoguelikeBossChallengeBossState.Processing;
							goto IL_105;
						}
					}
					roguelikeBossChallengeBossData.Id = 0;
					roguelikeBossChallengeBossData.State = ERoguelikeBossChallengeBossState.Locked;
				}
				IL_105:
				roguelikeBossChallengeBossData.IsSpecial = (num == i);
				list.Add(roguelikeBossChallengeBossData);
			}
			GenericLayout<RoguelikeBossChallengeBossItem, RoguelikeBossChallengeBossData> bossItemLayout = this.BossItemLayout;
			if (bossItemLayout == null)
			{
				return;
			}
			bossItemLayout.RefreshByData(list, new Action(this.OnBossListRefreshed), false);
		}

		// Token: 0x0603948A RID: 234634 RVA: 0x00D95E68 File Offset: 0x00D94068
		private void OnBossListRefreshed()
		{
			if (this.BossItemLayout == null)
			{
				return;
			}
			List<RoguelikeBossChallengeBossItem> layoutItemList = this.BossItemLayout.GetLayoutItemList();
			int num = layoutItemList.Count - 1;
			for (int i = 0; i < layoutItemList.Count; i++)
			{
				layoutItemList[i].SetArrowVisible(i < num);
			}
		}

		// Token: 0x0603948B RID: 234635 RVA: 0x00D95EB4 File Offset: 0x00D940B4
		private RoguelikeBossChallengeBossItem CreateBossItem()
		{
			return new RoguelikeBossChallengeBossItem();
		}

		// Token: 0x0603948C RID: 234636 RVA: 0x00D95EBB File Offset: 0x00D940BB
		protected override void OnBeforeDestroy()
		{
			this.ResultRecordItem = null;
			this.BossItemLayout = null;
		}

		// Token: 0x0401DF50 RID: 122704
		[Nullable(2)]
		private RoguelikeResultRecordItem ResultRecordItem;

		// Token: 0x0401DF51 RID: 122705
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoguelikeBossChallengeBossItem, RoguelikeBossChallengeBossData> BossItemLayout;

		// Token: 0x0200BA00 RID: 47616
		[NullableContext(0)]
		private class EBossChallengeComponent
		{
			// Token: 0x0403839F RID: 230303
			public const int ResultRecordItem = 0;

			// Token: 0x040383A0 RID: 230304
			public const int BossItemLayout = 1;

			// Token: 0x040383A1 RID: 230305
			public const int TxtNum = 2;

			// Token: 0x040383A2 RID: 230306
			public const int ResultNewTagItem = 3;
		}
	}
}
