using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.FloroRanch;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001053 RID: 4179
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FloroRanchIncomeItem : GridProxyAbstract<IFloroRanchDetailData>
{
	// Token: 0x0600A645 RID: 42565 RVA: 0x0030EF50 File Offset: 0x0030D150
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIExtendToggle));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(9, new Action<EToggleState>(this.OnClickCallBack));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A646 RID: 42566 RVA: 0x0030F101 File Offset: 0x0030D301
	public override void Refresh(IFloroRanchDetailData data, bool isSelected, int gridIndex)
	{
		this.EntityData = data.EntityData;
		this.RefreshView(data.Rank);
	}

	// Token: 0x0600A647 RID: 42567 RVA: 0x0030F11C File Offset: 0x0030D31C
	private void RefreshView(int rank)
	{
		base.GetText(0).SetText(rank.ToString(), true);
		FloroRanchEntityDataComponent floroRanchEntityDataComponent = this.EntityData.CheckGetComponent<FloroRanchEntityDataComponent>();
		EFloroRanchEntityType entityType = floroRanchEntityDataComponent.EntityType;
		string coinText = FloroRanchModel.Instance.GetCoinText(floroRanchEntityDataComponent.Income);
		FloroRanchCurrencyConfigData floroRanchCurrencyConfig = FloroRanchModel.Instance.GetFloroRanchCurrencyConfig(ECurrencyType.Coin);
		base.SetTextureByPath(floroRanchCurrencyConfig.GetSmallIcon(), base.GetTexture(6), null, null);
		base.GetText(7).SetText(coinText, true);
		base.GetItem(3).SetUIActive(!floroRanchEntityDataComponent.IsValid);
		bool flag = floroRanchEntityDataComponent.Point != -1;
		base.GetItem(5).SetUIActive(flag);
		base.GetItem(8).SetUIActive(!flag);
		switch (entityType)
		{
		case EFloroRanchEntityType.Terrain:
			this.RefreshTerrain();
			return;
		case EFloroRanchEntityType.Card:
			this.RefreshCard();
			return;
		case EFloroRanchEntityType.Toy:
			this.RefreshToy();
			return;
		default:
			return;
		}
	}

	// Token: 0x0600A648 RID: 42568 RVA: 0x0030F204 File Offset: 0x0030D404
	private void RefreshCard()
	{
		FloroRanchCardData cardData = this.EntityData.CheckGetComponent<FloroRanchCardDataComponent>().CardData;
		FloroRanchRarityData cardQualityData = cardData.GetCardQualityData();
		this.SetSpriteByPath(cardQualityData.GetRaritySmallBg(), base.GetSprite(1), true, null, null);
		base.GetSprite(1).SetUIActive(true);
		string icon = cardData.GetIcon();
		base.SetTextureByPath(icon, base.GetTexture(2), null, null);
		string name = cardData.GetName();
		base.GetText(4).ShowTextNew(name);
	}

	// Token: 0x0600A649 RID: 42569 RVA: 0x0030F288 File Offset: 0x0030D488
	private void RefreshTerrain()
	{
		FloroRanchTerrainData terrainData = this.EntityData.CheckGetComponent<FloroRanchTerrainDataComponent>().TerrainData;
		base.GetSprite(1).SetUIActive(false);
		base.SetTextureByPath(terrainData.Icon, base.GetTexture(2), null, null);
		base.GetText(4).SetText(terrainData.Name, true);
	}

	// Token: 0x0600A64A RID: 42570 RVA: 0x0030F2E4 File Offset: 0x0030D4E4
	private void RefreshToy()
	{
		FloroRanchToyData toyData = this.EntityData.CheckGetComponent<FloroRanchToyDataComponent>().ToyData;
		FloroRanchRarityData toyQualityData = toyData.GetToyQualityData();
		this.SetSpriteByPath(toyQualityData.GetRaritySmallBg(), base.GetSprite(1), true, null, null);
		base.GetSprite(1).SetUIActive(true);
		string icon = toyData.GetIcon();
		base.SetTextureByPath(icon, base.GetTexture(2), null, null);
		string name = toyData.GetName();
		base.GetText(4).ShowTextNew(name);
	}

	// Token: 0x0600A64B RID: 42571 RVA: 0x0030F365 File Offset: 0x0030D565
	public void BindClickCallBack(Action<int, FloroRanchEntityBase> callBack)
	{
		this.CallBack = callBack;
	}

	// Token: 0x0600A64C RID: 42572 RVA: 0x0030F36E File Offset: 0x0030D56E
	private void OnClickCallBack(EToggleState toggleState)
	{
		Action<int, FloroRanchEntityBase> callBack = this.CallBack;
		if (callBack == null)
		{
			return;
		}
		callBack(base.GridIndex, this.EntityData);
	}

	// Token: 0x0600A64D RID: 42573 RVA: 0x0030F38C File Offset: 0x0030D58C
	public void SetSelectState(bool isSelect)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(9);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04006125 RID: 24869
	private FloroRanchEntityBase EntityData;

	// Token: 0x04006126 RID: 24870
	private Action<int, FloroRanchEntityBase> CallBack;

	// Token: 0x020072AE RID: 29358
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04025594 RID: 152980
		public const int RankNum = 0;

		// Token: 0x04025595 RID: 152981
		public const int QualitySprite = 1;

		// Token: 0x04025596 RID: 152982
		public const int IconTexture = 2;

		// Token: 0x04025597 RID: 152983
		public const int LockItem = 3;

		// Token: 0x04025598 RID: 152984
		public const int Name = 4;

		// Token: 0x04025599 RID: 152985
		public const int IncomeItem = 5;

		// Token: 0x0402559A RID: 152986
		public const int CoinIconTexture = 6;

		// Token: 0x0402559B RID: 152987
		public const int IncomeCoinNum = 7;

		// Token: 0x0402559C RID: 152988
		public const int StateItem = 8;

		// Token: 0x0402559D RID: 152989
		public const int Toggle = 9;
	}
}
