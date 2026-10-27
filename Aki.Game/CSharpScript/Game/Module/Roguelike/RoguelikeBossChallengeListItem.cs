using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DCD RID: 19917
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeBossChallengeListItem : UiPanelBase
	{
		// Token: 0x06033670 RID: 210544 RVA: 0x00C0045C File Offset: 0x00BFE65C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033671 RID: 210545 RVA: 0x00C004E6 File Offset: 0x00BFE6E6
		protected override void OnStart()
		{
			this.BossItemLayout = new GenericLayout<RoguelikeBossChallengeBossItem, RoguelikeBossChallengeBossData>(base.GetHorizontalLayout(1), new Func<RoguelikeBossChallengeBossItem>(this.CreateBossItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06033672 RID: 210546 RVA: 0x00C0051C File Offset: 0x00BFE71C
		public void RefreshBossList(List<RoguelikeBossChallengeBossData> dataList, int currentBossId)
		{
			GenericLayout<RoguelikeBossChallengeBossItem, RoguelikeBossChallengeBossData> bossItemLayout = this.BossItemLayout;
			if (bossItemLayout == null)
			{
				return;
			}
			bossItemLayout.RefreshByData(dataList, delegate
			{
				this.OnBossListRefreshed(currentBossId);
			}, false);
		}

		// Token: 0x06033673 RID: 210547 RVA: 0x00C0055C File Offset: 0x00BFE75C
		private void OnBossListRefreshed(int currentBossId)
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
			this.PlayCurrentBossSwitchSequence(layoutItemList, currentBossId);
		}

		// Token: 0x06033674 RID: 210548 RVA: 0x00C005B0 File Offset: 0x00BFE7B0
		private void PlayCurrentBossSwitchSequence(List<RoguelikeBossChallengeBossItem> itemList, int currentBossId)
		{
			if (currentBossId == 0)
			{
				return;
			}
			foreach (RoguelikeBossChallengeBossItem roguelikeBossChallengeBossItem in itemList)
			{
				if (roguelikeBossChallengeBossItem.IsCurrentBoss(currentBossId))
				{
					roguelikeBossChallengeBossItem.PlaySwitchSequence();
					break;
				}
			}
		}

		// Token: 0x06033675 RID: 210549 RVA: 0x00C0060C File Offset: 0x00BFE80C
		protected override void OnBeforeDestroy()
		{
			this.BossItemLayout = null;
		}

		// Token: 0x06033676 RID: 210550 RVA: 0x00C00615 File Offset: 0x00BFE815
		private RoguelikeBossChallengeBossItem CreateBossItem()
		{
			return new RoguelikeBossChallengeBossItem
			{
				ShowCurrentArrow = true
			};
		}

		// Token: 0x0401B4B3 RID: 111795
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoguelikeBossChallengeBossItem, RoguelikeBossChallengeBossData> BossItemLayout;

		// Token: 0x0200AF43 RID: 44867
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403537A RID: 217978
			public const int TxtTitle = 0;

			// Token: 0x0403537B RID: 217979
			public const int PnlBossItemLayout = 1;

			// Token: 0x0403537C RID: 217980
			public const int UiItemRougueBossItem = 2;
		}
	}
}
