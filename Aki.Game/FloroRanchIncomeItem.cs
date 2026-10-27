using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.FloroRanch;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001B94 RID: 7060
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FloroRanchIncomeItem : GridProxyAbstract<IFloroRanchDetailData>
{
	// Token: 0x0600D234 RID: 53812 RVA: 0x00303E78 File Offset: 0x00302078
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

	// Token: 0x0600D235 RID: 53813 RVA: 0x00304029 File Offset: 0x00302229
	public override void Refresh(IFloroRanchDetailData data, bool isSelected, int gridIndex)
	{
		this.EntityData = data.EntityData;
		this.RefreshView(data.Rank);
	}

	// Token: 0x0600D236 RID: 53814 RVA: 0x00304044 File Offset: 0x00302244
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

	// Token: 0x0600D237 RID: 53815 RVA: 0x0030412C File Offset: 0x0030232C
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

	// Token: 0x0600D238 RID: 53816 RVA: 0x003041B0 File Offset: 0x003023B0
	private void RefreshTerrain()
	{
		FloroRanchTerrainData terrainData = this.EntityData.CheckGetComponent<FloroRanchTerrainDataComponent>().TerrainData;
		base.GetSprite(1).SetUIActive(false);
		base.SetTextureByPath(terrainData.Icon, base.GetTexture(2), null, null);
		base.GetText(4).SetText(terrainData.Name, true);
	}

	// Token: 0x0600D239 RID: 53817 RVA: 0x0030420C File Offset: 0x0030240C
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

	// Token: 0x0600D23A RID: 53818 RVA: 0x0030428D File Offset: 0x0030248D
	public void BindClickCallBack(Action<int, FloroRanchEntityBase> callBack)
	{
		this.CallBack = callBack;
	}

	// Token: 0x0600D23B RID: 53819 RVA: 0x00304296 File Offset: 0x00302496
	private void OnClickCallBack(EToggleState toggleState)
	{
		Action<int, FloroRanchEntityBase> callBack = this.CallBack;
		if (callBack == null)
		{
			return;
		}
		callBack(base.GridIndex, this.EntityData);
	}

	// Token: 0x0600D23C RID: 53820 RVA: 0x003042B4 File Offset: 0x003024B4
	public void SetSelectState(bool isSelect)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(9);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04006056 RID: 24662
	private FloroRanchEntityBase EntityData;

	// Token: 0x04006057 RID: 24663
	private Action<int, FloroRanchEntityBase> CallBack;

	// Token: 0x02008120 RID: 33056
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402A260 RID: 172640
		public const int RankNum = 0;

		// Token: 0x0402A261 RID: 172641
		public const int QualitySprite = 1;

		// Token: 0x0402A262 RID: 172642
		public const int IconTexture = 2;

		// Token: 0x0402A263 RID: 172643
		public const int LockItem = 3;

		// Token: 0x0402A264 RID: 172644
		public const int Name = 4;

		// Token: 0x0402A265 RID: 172645
		public const int IncomeItem = 5;

		// Token: 0x0402A266 RID: 172646
		public const int CoinIconTexture = 6;

		// Token: 0x0402A267 RID: 172647
		public const int IncomeCoinNum = 7;

		// Token: 0x0402A268 RID: 172648
		public const int StateItem = 8;

		// Token: 0x0402A269 RID: 172649
		public const int Toggle = 9;
	}
}
