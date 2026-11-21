using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200104D RID: 4173
[Nullable(new byte[]
{
	0,
	1
})]
public class FloroRanchDungeonSettleRewardItem : GridProxyAbstract<FloroRanchSubInsSettleReward>
{
	// Token: 0x0600A61F RID: 42527 RVA: 0x0030DDC8 File Offset: 0x0030BFC8
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

	// Token: 0x0600A620 RID: 42528 RVA: 0x0030DEF4 File Offset: 0x0030C0F4
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

	// Token: 0x0600A621 RID: 42529 RVA: 0x0030DF40 File Offset: 0x0030C140
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

	// Token: 0x0600A622 RID: 42530 RVA: 0x0030DFD8 File Offset: 0x0030C1D8
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

	// Token: 0x0600A623 RID: 42531 RVA: 0x0030E09C File Offset: 0x0030C29C
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

	// Token: 0x0600A624 RID: 42532 RVA: 0x0030E108 File Offset: 0x0030C308
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

	// Token: 0x04006117 RID: 24855
	[Nullable(2)]
	private FloroRanchSubInsSettleReward Data;

	// Token: 0x020072A3 RID: 29347
	private class EComponent
	{
		// Token: 0x04025552 RID: 152914
		public const int Button = 0;

		// Token: 0x04025553 RID: 152915
		public const int QualitySprite = 1;

		// Token: 0x04025554 RID: 152916
		public const int Texture = 2;

		// Token: 0x04025555 RID: 152917
		public const int ItemToyRaceType = 3;

		// Token: 0x04025556 RID: 152918
		public const int TextureToyRaceIcon = 4;

		// Token: 0x04025557 RID: 152919
		public const int ItemPhantomIcon = 5;
	}
}
