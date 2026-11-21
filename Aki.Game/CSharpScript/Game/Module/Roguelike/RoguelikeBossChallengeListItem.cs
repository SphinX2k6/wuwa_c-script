using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D96 RID: 15766
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeBossChallengeListItem : UiPanelBase
	{
		// Token: 0x060284DD RID: 165085 RVA: 0x00B4999C File Offset: 0x00B47B9C
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

		// Token: 0x060284DE RID: 165086 RVA: 0x00B49A26 File Offset: 0x00B47C26
		protected override void OnStart()
		{
			this.BossItemLayout = new GenericLayout<RoguelikeBossChallengeBossItem, RoguelikeBossChallengeBossData>(base.GetHorizontalLayout(1), new Func<RoguelikeBossChallengeBossItem>(this.CreateBossItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x060284DF RID: 165087 RVA: 0x00B49A5C File Offset: 0x00B47C5C
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

		// Token: 0x060284E0 RID: 165088 RVA: 0x00B49A9C File Offset: 0x00B47C9C
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

		// Token: 0x060284E1 RID: 165089 RVA: 0x00B49AF0 File Offset: 0x00B47CF0
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

		// Token: 0x060284E2 RID: 165090 RVA: 0x00B49B4C File Offset: 0x00B47D4C
		protected override void OnBeforeDestroy()
		{
			this.BossItemLayout = null;
		}

		// Token: 0x060284E3 RID: 165091 RVA: 0x00B49B55 File Offset: 0x00B47D55
		private RoguelikeBossChallengeBossItem CreateBossItem()
		{
			return new RoguelikeBossChallengeBossItem
			{
				ShowCurrentArrow = true
			};
		}

		// Token: 0x04015E86 RID: 89734
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoguelikeBossChallengeBossItem, RoguelikeBossChallengeBossData> BossItemLayout;

		// Token: 0x02009978 RID: 39288
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0402FDAF RID: 196015
			public const int TxtTitle = 0;

			// Token: 0x0402FDB0 RID: 196016
			public const int PnlBossItemLayout = 1;

			// Token: 0x0402FDB1 RID: 196017
			public const int UiItemRougueBossItem = 2;
		}
	}
}
