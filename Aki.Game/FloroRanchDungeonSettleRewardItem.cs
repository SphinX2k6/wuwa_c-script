using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001B8E RID: 7054
[Nullable(new byte[]
{
	0,
	1
})]
public class FloroRanchDungeonSettleRewardItem : GridProxyAbstract<FloroRanchSubInsSettleReward>
{
	// Token: 0x0600D20E RID: 53774 RVA: 0x00302CF0 File Offset: 0x00300EF0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D20F RID: 53775 RVA: 0x00302E1C File Offset: 0x0030101C
	[NullableContext(1)]
	public override void Refresh(FloroRanchSubInsSettleReward data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		if (data.Type == SubInsSettleRewardType.FloroRanchCard)
		{
			this.RefreshCard(data.Id);
			return;
		}
		if (data.Type == SubInsSettleRewardType.FloroRanchToy)
		{
			this.RefreshToy(data.Id);
			return;
		}
		this.RefreshSkill(data.Id);
	}

	// Token: 0x0600D210 RID: 53776 RVA: 0x00302E68 File Offset: 0x00301068
	private void RefreshCard(int id)
	{
		FloroRanchCardData floroRanchCardData = FloroRanchModel.Instance.GetFloroRanchCardData(id);
		FloroRanchRarityData cardQualityData = floroRanchCardData.GetCardQualityData();
		base.SetTextureShowUntilLoaded(floroRanchCardData.GetIcon(), base.GetTexture(2), null);
		string rarityShopItemBg = cardQualityData.GetRarityShopItemBg();
		this.SetSpriteByPath(rarityShopItemBg, base.GetSprite(1), true, null, null);
		base.GetSprite(1).SetUIActive(true);
		base.GetButton(0).SetSelfInteractive(true);
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(floroRanchCardData.IsSpecialPhantom);
		}
		UUIItem item2 = base.GetItem(3);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x0600D211 RID: 53777 RVA: 0x00302F00 File Offset: 0x00301100
	private void RefreshToy(int id)
	{
		FloroRanchToyData floroRanchToyData = FloroRanchModel.Instance.GetFloroRanchToyData(id);
		FloroRanchRarityData toyQualityData = floroRanchToyData.GetToyQualityData();
		base.SetTextureShowUntilLoaded(floroRanchToyData.GetIcon(), base.GetTexture(2), null);
		string rarityShopItemBg = toyQualityData.GetRarityShopItemBg();
		this.SetSpriteByPath(rarityShopItemBg, base.GetSprite(1), true, null, null);
		base.GetSprite(1).SetUIActive(true);
		base.GetButton(0).SetSelfInteractive(true);
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		FloroRanchRaceData toyRaceData = floroRanchToyData.GetToyRaceData();
		if (toyRaceData != null)
		{
			UUIItem item2 = base.GetItem(3);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			base.SetTextureShowUntilLoaded(toyRaceData.SmallIcon, base.GetTexture(4), null);
			return;
		}
		UUIItem item3 = base.GetItem(3);
		if (item3 == null)
		{
			return;
		}
		item3.SetUIActive(false);
	}

	// Token: 0x0600D212 RID: 53778 RVA: 0x00302FC4 File Offset: 0x003011C4
	private void RefreshSkill(int id)
	{
		FloroRanchSkillData floroRanchSkillData = FloroRanchModel.Instance.GetFloroRanchSkillData(id);
		base.SetTextureShowUntilLoaded(floroRanchSkillData.Icon, base.GetTexture(2), null);
		base.GetSprite(1).SetUIActive(false);
		base.GetButton(0).SetSelfInteractive(false);
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(3);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x0600D213 RID: 53779 RVA: 0x00303030 File Offset: 0x00301230
	private void OnClickButton()
	{
		if (this.Data == null)
		{
			return;
		}
		if (this.Data.Type == SubInsSettleRewardType.FloroRanchCard)
		{
			FloroRanchCardData floroRanchCardData = FloroRanchModel.Instance.GetFloroRanchCardData(this.Data.Id);
			UiManager.Instance.OpenView(EUiViewName.FloroRanchCommonTipsView, new FloroRanchCommonTipParam
			{
				TipType = EFloroRanchCommonTipType.Card,
				CardData = floroRanchCardData
			}, null);
			return;
		}
		if (this.Data.Type == SubInsSettleRewardType.FloroRanchToy)
		{
			FloroRanchToyData floroRanchToyData = FloroRanchModel.Instance.GetFloroRanchToyData(this.Data.Id);
			UiManager.Instance.OpenView(EUiViewName.FloroRanchCommonTipsView, new FloroRanchCommonTipParam
			{
				TipType = EFloroRanchCommonTipType.Toy,
				ToyData = floroRanchToyData
			}, null);
		}
	}

	// Token: 0x04006048 RID: 24648
	[Nullable(2)]
	private FloroRanchSubInsSettleReward Data;

	// Token: 0x02008115 RID: 33045
	private class EComponent
	{
		// Token: 0x0402A21E RID: 172574
		public const int Button = 0;

		// Token: 0x0402A21F RID: 172575
		public const int QualitySprite = 1;

		// Token: 0x0402A220 RID: 172576
		public const int Texture = 2;

		// Token: 0x0402A221 RID: 172577
		public const int ItemToyRaceType = 3;

		// Token: 0x0402A222 RID: 172578
		public const int TextureToyRaceIcon = 4;

		// Token: 0x0402A223 RID: 172579
		public const int ItemPhantomIcon = 5;
	}
}
