using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A58 RID: 14936
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseLevelRewardItem : GridProxyAbstract<ITrapDefenseLevelRewardItemData>
	{
		// Token: 0x0602663B RID: 157243 RVA: 0x00AC0F88 File Offset: 0x00ABF188
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602663C RID: 157244 RVA: 0x00AC10B8 File Offset: 0x00ABF2B8
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseLevelRewardItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseLevelRewardItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602663D RID: 157245 RVA: 0x00AC10FC File Offset: 0x00ABF2FC
		public override void Refresh(ITrapDefenseLevelRewardItemData data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			switch (data.ItemType)
			{
			case ETrapDefenseLevelRewardItemType.Talent:
				this.UpdateTalent();
				return;
			case ETrapDefenseLevelRewardItemType.Machine:
				this.UpdateMachine();
				return;
			case ETrapDefenseLevelRewardItemType.BdBuff:
				this.UpdateBdBuff();
				return;
			default:
				return;
			}
		}

		// Token: 0x0602663E RID: 157246 RVA: 0x00AC113E File Offset: 0x00ABF33E
		private void SetTalentShow(bool show)
		{
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(show);
		}

		// Token: 0x0602663F RID: 157247 RVA: 0x00AC1152 File Offset: 0x00ABF352
		private void SetTitleKey(string key)
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(key);
		}

		// Token: 0x06026640 RID: 157248 RVA: 0x00AC1168 File Offset: 0x00ABF368
		public void UpdateTalent()
		{
			this.SetTalentShow(true);
			this.LayoutBdReward.SetActive(false);
			this.LayoutMachineReward.SetActive(false);
			this.SetTitleKey(this.ItemData.TypeNameKey.ToString());
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText(this.ItemData.LevelData.Config.RewardMoneyCount.ToString(), true);
			}
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.ItemData.LevelData.IsPassed);
		}

		// Token: 0x06026641 RID: 157249 RVA: 0x00AC11FC File Offset: 0x00ABF3FC
		public void UpdateMachine()
		{
			this.LayoutMachineReward.SetActive(true);
			this.SetTalentShow(false);
			this.LayoutBdReward.SetActive(false);
			this.SetTitleKey(this.ItemData.TypeNameKey.ToString());
			this.LayoutMachineReward.RefreshByData(this.ItemData.LevelData.GetRewardShowListMachineData(), null, false);
		}

		// Token: 0x06026642 RID: 157250 RVA: 0x00AC125C File Offset: 0x00ABF45C
		public void UpdateBdBuff()
		{
			this.LayoutBdReward.SetActive(true);
			this.SetTalentShow(false);
			this.LayoutMachineReward.SetActive(false);
			this.SetTitleKey(this.ItemData.TypeNameKey.ToString());
			this.LayoutBdReward.RefreshByData(this.ItemData.LevelData.GetRewardShowListBdBuffData(), null, false);
		}

		// Token: 0x06026643 RID: 157251 RVA: 0x00AC12BB File Offset: 0x00ABF4BB
		public TrapDefenseResultBdUnlockItem CreateItemBdReward()
		{
			return new TrapDefenseResultBdUnlockItem();
		}

		// Token: 0x06026644 RID: 157252 RVA: 0x00AC12C2 File Offset: 0x00ABF4C2
		public TrapDefenseResultOrganUnlockItem CreateItemMachineReward()
		{
			return new TrapDefenseResultOrganUnlockItem();
		}

		// Token: 0x040150F0 RID: 86256
		public ITrapDefenseLevelRewardItemData ItemData;

		// Token: 0x040150F1 RID: 86257
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<ITrapDefenseLevelRewardItemData> ClickCallBack;

		// Token: 0x040150F2 RID: 86258
		public GenericLayout<TrapDefenseResultOrganUnlockItem, ITrapDefenseResultUnlockInfo> LayoutMachineReward;

		// Token: 0x040150F3 RID: 86259
		public GenericLayout<TrapDefenseResultBdUnlockItem, ITrapDefenseResultUnlockInfo> LayoutBdReward;

		// Token: 0x0200962D RID: 38445
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0402EE34 RID: 192052
			public const int TextTitle = 0;

			// Token: 0x0402EE35 RID: 192053
			public const int ItemTalentRoot = 1;

			// Token: 0x0402EE36 RID: 192054
			public const int TextTalent = 2;

			// Token: 0x0402EE37 RID: 192055
			public const int LayoutMachineReward = 3;

			// Token: 0x0402EE38 RID: 192056
			public const int ItemMachineReward = 4;

			// Token: 0x0402EE39 RID: 192057
			public const int LayoutBdReward = 5;

			// Token: 0x0402EE3A RID: 192058
			public const int ItemBdReward = 6;

			// Token: 0x0402EE3B RID: 192059
			public const int ItemFinish = 7;
		}
	}
}
