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
	// Token: 0x02004AB0 RID: 19120
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseLevelRewardItem : GridProxyAbstract<ITrapDefenseLevelRewardItemData>
	{
		// Token: 0x060318AB RID: 202923 RVA: 0x00B7CFD4 File Offset: 0x00B7B1D4
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

		// Token: 0x060318AC RID: 202924 RVA: 0x00B7D104 File Offset: 0x00B7B304
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseLevelRewardItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseLevelRewardItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060318AD RID: 202925 RVA: 0x00B7D148 File Offset: 0x00B7B348
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

		// Token: 0x060318AE RID: 202926 RVA: 0x00B7D18A File Offset: 0x00B7B38A
		private void SetTalentShow(bool show)
		{
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(show);
		}

		// Token: 0x060318AF RID: 202927 RVA: 0x00B7D19E File Offset: 0x00B7B39E
		private void SetTitleKey(string key)
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(key);
		}

		// Token: 0x060318B0 RID: 202928 RVA: 0x00B7D1B4 File Offset: 0x00B7B3B4
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

		// Token: 0x060318B1 RID: 202929 RVA: 0x00B7D248 File Offset: 0x00B7B448
		public void UpdateMachine()
		{
			this.LayoutMachineReward.SetActive(true);
			this.SetTalentShow(false);
			this.LayoutBdReward.SetActive(false);
			this.SetTitleKey(this.ItemData.TypeNameKey.ToString());
			this.LayoutMachineReward.RefreshByData(this.ItemData.LevelData.GetRewardShowListMachineData(), null, false);
		}

		// Token: 0x060318B2 RID: 202930 RVA: 0x00B7D2A8 File Offset: 0x00B7B4A8
		public void UpdateBdBuff()
		{
			this.LayoutBdReward.SetActive(true);
			this.SetTalentShow(false);
			this.LayoutMachineReward.SetActive(false);
			this.SetTitleKey(this.ItemData.TypeNameKey.ToString());
			this.LayoutBdReward.RefreshByData(this.ItemData.LevelData.GetRewardShowListBdBuffData(), null, false);
		}

		// Token: 0x060318B3 RID: 202931 RVA: 0x00B7D307 File Offset: 0x00B7B507
		public TrapDefenseResultBdUnlockItem CreateItemBdReward()
		{
			return new TrapDefenseResultBdUnlockItem();
		}

		// Token: 0x060318B4 RID: 202932 RVA: 0x00B7D30E File Offset: 0x00B7B50E
		public TrapDefenseResultOrganUnlockItem CreateItemMachineReward()
		{
			return new TrapDefenseResultOrganUnlockItem();
		}

		// Token: 0x0401A79E RID: 108446
		public ITrapDefenseLevelRewardItemData ItemData;

		// Token: 0x0401A79F RID: 108447
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<ITrapDefenseLevelRewardItemData> ClickCallBack;

		// Token: 0x0401A7A0 RID: 108448
		public GenericLayout<TrapDefenseResultOrganUnlockItem, ITrapDefenseResultUnlockInfo> LayoutMachineReward;

		// Token: 0x0401A7A1 RID: 108449
		public GenericLayout<TrapDefenseResultBdUnlockItem, ITrapDefenseResultUnlockInfo> LayoutBdReward;

		// Token: 0x0200AC0D RID: 44045
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04034483 RID: 214147
			public const int TextTitle = 0;

			// Token: 0x04034484 RID: 214148
			public const int ItemTalentRoot = 1;

			// Token: 0x04034485 RID: 214149
			public const int TextTalent = 2;

			// Token: 0x04034486 RID: 214150
			public const int LayoutMachineReward = 3;

			// Token: 0x04034487 RID: 214151
			public const int ItemMachineReward = 4;

			// Token: 0x04034488 RID: 214152
			public const int LayoutBdReward = 5;

			// Token: 0x04034489 RID: 214153
			public const int ItemBdReward = 6;

			// Token: 0x0403448A RID: 214154
			public const int ItemFinish = 7;
		}
	}
}
