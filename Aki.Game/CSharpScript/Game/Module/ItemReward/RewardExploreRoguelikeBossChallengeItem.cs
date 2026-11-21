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
	// Token: 0x020047DC RID: 18396
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreRoguelikeBossChallengeItem : UiPanelBase
	{
		// Token: 0x0602E39A RID: 189338 RVA: 0x00CE4A6C File Offset: 0x00CE2C6C
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

		// Token: 0x0602E39B RID: 189339 RVA: 0x00CE4B18 File Offset: 0x00CE2D18
		protected override UniTask OnBeforeStartAsync()
		{
			RewardExploreRoguelikeBossChallengeItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RewardExploreRoguelikeBossChallengeItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E39C RID: 189340 RVA: 0x00CE4B5B File Offset: 0x00CE2D5B
		public void Refresh(IRoguelikeBossChallengeData data)
		{
			RoguelikeResultRecordItem resultRecordItem = this.ResultRecordItem;
			if (resultRecordItem != null)
			{
				resultRecordItem.Refresh(data);
			}
			this.RefreshBossList(data);
		}

		// Token: 0x0602E39D RID: 189341 RVA: 0x00CE4B78 File Offset: 0x00CE2D78
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

		// Token: 0x0602E39E RID: 189342 RVA: 0x00CE4CD0 File Offset: 0x00CE2ED0
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

		// Token: 0x0602E39F RID: 189343 RVA: 0x00CE4D1C File Offset: 0x00CE2F1C
		private RoguelikeBossChallengeBossItem CreateBossItem()
		{
			return new RoguelikeBossChallengeBossItem();
		}

		// Token: 0x0602E3A0 RID: 189344 RVA: 0x00CE4D23 File Offset: 0x00CE2F23
		protected override void OnBeforeDestroy()
		{
			this.ResultRecordItem = null;
			this.BossItemLayout = null;
		}

		// Token: 0x040189E7 RID: 100839
		[Nullable(2)]
		private RoguelikeResultRecordItem ResultRecordItem;

		// Token: 0x040189E8 RID: 100840
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoguelikeBossChallengeBossItem, RoguelikeBossChallengeBossData> BossItemLayout;

		// Token: 0x0200A416 RID: 42006
		[NullableContext(0)]
		private class EBossChallengeComponent
		{
			// Token: 0x04032D8C RID: 208268
			public const int ResultRecordItem = 0;

			// Token: 0x04032D8D RID: 208269
			public const int BossItemLayout = 1;

			// Token: 0x04032D8E RID: 208270
			public const int TxtNum = 2;

			// Token: 0x04032D8F RID: 208271
			public const int ResultNewTagItem = 3;
		}
	}
}
