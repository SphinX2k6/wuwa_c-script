using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020014A6 RID: 5286
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ItemView : GridProxyAbstract<global::ItemViewData>
{
	// Token: 0x0600D3A7 RID: 54183 RVA: 0x003EEBB8 File Offset: 0x003ECDB8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 19;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.OnToggleStateChanged));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D3A8 RID: 54184 RVA: 0x003EEE9A File Offset: 0x003ED09A
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600D3A9 RID: 54185 RVA: 0x003EEEAD File Offset: 0x003ED0AD
	protected override void OnBeforeDestroy()
	{
		this.OnItemButtonClickedCallback = null;
		this.LevelSequencePlayer.Clear();
		this.LevelSequencePlayer = null;
	}

	// Token: 0x0600D3AA RID: 54186 RVA: 0x003EEEC8 File Offset: 0x003ED0C8
	private void OnToggleStateChanged(EToggleState state)
	{
		if (this.OnItemButtonClickedCallback != null)
		{
			this.OnItemButtonClickedCallback(this.ItemViewData);
		}
	}

	// Token: 0x0600D3AB RID: 54187 RVA: 0x003EEEE3 File Offset: 0x003ED0E3
	public void BindOnItemButtonClickedCallback(Action<global::ItemViewData> onItemButtonClicked)
	{
		this.OnItemButtonClickedCallback = onItemButtonClicked;
	}

	// Token: 0x0600D3AC RID: 54188 RVA: 0x003EEEEC File Offset: 0x003ED0EC
	public override void Refresh(global::ItemViewData data, bool isSelected, int gridIndex)
	{
		this.RefreshItemViewByItemData(data);
		this.SetSelected(isSelected);
	}

	// Token: 0x0600D3AD RID: 54189 RVA: 0x003EEEFC File Offset: 0x003ED0FC
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true);
	}

	// Token: 0x0600D3AE RID: 54190 RVA: 0x003EEF05 File Offset: 0x003ED105
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false);
	}

	// Token: 0x0600D3AF RID: 54191 RVA: 0x003EEF10 File Offset: 0x003ED110
	public void RefreshItemViewByItemData(global::ItemViewData itemViewData)
	{
		this.ItemViewData = itemViewData;
		InventoryDefine.IItemViewDataInfo itemViewInfo = itemViewData.GetItemViewInfo();
		int qualityId = itemViewInfo.QualityId;
		bool isLock = itemViewInfo.IsLock;
		bool isNewItem = itemViewInfo.IsNewItem;
		InventoryDefine.EItemDataType itemDataType = itemViewInfo.ItemDataType;
		this.SetItemTexture();
		this.SetQualityIcon(qualityId);
		this.SetLock(isLock);
		this.SetIsNewItem(isNewItem);
		this.RefreshCdTimeDisplay();
		switch (itemDataType)
		{
		case InventoryDefine.EItemDataType.CommonItem:
		{
			int count = this.ItemViewData.GetCount();
			this.SetItemCount(count);
			return;
		}
		case InventoryDefine.EItemDataType.WeaponItem:
		{
			int uniqueId = (this.ItemViewData.GetItemDataBase() as WeaponItemData).GetUniqueId();
			int level = WeaponModel.Instance.GetWeaponDataByIncId(uniqueId).GetLevel();
			this.SetItemLevel(level);
			return;
		}
		case InventoryDefine.EItemDataType.PhantomItem:
		{
			int uniqueId2 = (this.ItemViewData.GetItemDataBase() as PhantomItemData).GetUniqueId();
			int phantomLevel = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId2).GetPhantomLevel();
			this.SetItemLevel(phantomLevel);
			return;
		}
		}
		int count2 = this.ItemViewData.GetCount();
		this.SetItemCount(count2);
	}

	// Token: 0x0600D3B0 RID: 54192 RVA: 0x003EF010 File Offset: 0x003ED210
	private void SetItemTexture()
	{
		UUITexture texture = base.GetTexture(0);
		base.SetItemIcon(texture, this.ItemViewData.GetConfigId(), null, null);
	}

	// Token: 0x0600D3B1 RID: 54193 RVA: 0x003EF044 File Offset: 0x003ED244
	private void SetQualityIcon(int qualityId)
	{
		UUISprite sprite = base.GetSprite(2);
		if (sprite == null)
		{
			return;
		}
		base.SetItemQualityIcon(sprite, this.ItemViewData.GetConfigId(), null, CommonDefine.EQualityIconType.BackgroundSprite, null);
	}

	// Token: 0x0600D3B2 RID: 54194 RVA: 0x003EF07C File Offset: 0x003ED27C
	public void SetSelected(bool bSelected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(5);
		if (bSelected)
		{
			extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600D3B3 RID: 54195 RVA: 0x003EF0AC File Offset: 0x003ED2AC
	private void SetLock(bool bLock)
	{
		UUISprite sprite = base.GetSprite(6);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(bLock);
	}

	// Token: 0x0600D3B4 RID: 54196 RVA: 0x003EF0CC File Offset: 0x003ED2CC
	public void SetIsNewItem(bool bNewItem)
	{
		base.GetSprite(7).SetUIActive(bNewItem);
	}

	// Token: 0x0600D3B5 RID: 54197 RVA: 0x003EF0DC File Offset: 0x003ED2DC
	private void SetItemCount(int count)
	{
		UUIText text = base.GetText(4);
		if (text == null)
		{
			return;
		}
		text.SetText(count.ToString(), true);
		text.SetUIActive(true);
		UUIText text2 = base.GetText(3);
		if (text2 != null)
		{
			text2.SetUIActive(false);
		}
	}

	// Token: 0x0600D3B6 RID: 54198 RVA: 0x003EF11C File Offset: 0x003ED31C
	private void SetItemLevel(int weaponLevel)
	{
		UUIText text = base.GetText(3);
		if (text == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalText(text, "LevelShow", new <>z__ReadOnlySingleElementList<object>(weaponLevel));
		text.SetUIActive(true);
		UUIText text2 = base.GetText(4);
		if (text2 != null)
		{
			text2.SetUIActive(false);
		}
	}

	// Token: 0x0600D3B7 RID: 54199 RVA: 0x003EF169 File Offset: 0x003ED369
	public void SetRoleHeadVisible(bool bVisible)
	{
		base.GetItem(14).SetUIActive(bVisible);
	}

	// Token: 0x0600D3B8 RID: 54200 RVA: 0x003EF17C File Offset: 0x003ED37C
	private void SetCdItemVisible(bool bVisible)
	{
		UUIItem item = base.GetItem(16);
		if (item.bIsUIActive == bVisible)
		{
			return;
		}
		item.SetUIActive(bVisible);
		if (bVisible)
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("EnterCd", false, null, false);
		}
	}

	// Token: 0x0600D3B9 RID: 54201 RVA: 0x003EF1C4 File Offset: 0x003ED3C4
	public void RefreshCdTimeDisplay()
	{
		int configId = this.ItemViewData.GetConfigId();
		BuffItemModel instance = BuffItemModel.Instance;
		double buffItemRemainCdTime = instance.GetBuffItemRemainCdTime(configId);
		if (buffItemRemainCdTime <= 0.0)
		{
			this.SetCdItemVisible(false);
			return;
		}
		double buffItemTotalCdTime = instance.GetBuffItemTotalCdTime(configId);
		this.SetCdTimePercent(buffItemRemainCdTime, buffItemTotalCdTime);
		this.SetCdItemVisible(true);
	}

	// Token: 0x0600D3BA RID: 54202 RVA: 0x003EF218 File Offset: 0x003ED418
	private void SetCdTimePercent(double remainingCdTime, double totalCdTime)
	{
		double num = Math.Ceiling(remainingCdTime);
		UUISprite sprite = base.GetSprite(17);
		UUIText text = base.GetText(18);
		double num2 = num / totalCdTime;
		sprite.SetFillAmount((float)num2);
		text.SetText(num.ToString(), true);
	}

	// Token: 0x04007713 RID: 30483
	[Nullable(2)]
	private global::ItemViewData ItemViewData;

	// Token: 0x04007714 RID: 30484
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04007715 RID: 30485
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<global::ItemViewData> OnItemButtonClickedCallback;

	// Token: 0x0200776E RID: 30574
	[NullableContext(0)]
	private enum EChildComponentType
	{
		// Token: 0x04026C5E RID: 158814
		ItemTexture,
		// Token: 0x04026C5F RID: 158815
		StarUiItem,
		// Token: 0x04026C60 RID: 158816
		QualitySprite,
		// Token: 0x04026C61 RID: 158817
		LevelText,
		// Token: 0x04026C62 RID: 158818
		CountText,
		// Token: 0x04026C63 RID: 158819
		ItemToggle,
		// Token: 0x04026C64 RID: 158820
		LockSprite,
		// Token: 0x04026C65 RID: 158821
		NewFlagSprite,
		// Token: 0x04026C66 RID: 158822
		Star1,
		// Token: 0x04026C67 RID: 158823
		Star2,
		// Token: 0x04026C68 RID: 158824
		Star3,
		// Token: 0x04026C69 RID: 158825
		Star4,
		// Token: 0x04026C6A RID: 158826
		Star5,
		// Token: 0x04026C6B RID: 158827
		Star6,
		// Token: 0x04026C6C RID: 158828
		RoleHeadItem,
		// Token: 0x04026C6D RID: 158829
		RoleHeadTexture,
		// Token: 0x04026C6E RID: 158830
		CdItem,
		// Token: 0x04026C6F RID: 158831
		CdSprite,
		// Token: 0x04026C70 RID: 158832
		CdText
	}
}
