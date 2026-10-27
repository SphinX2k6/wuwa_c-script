using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001FD3 RID: 8147
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ItemView : GridProxyAbstract<global::ItemViewData>
{
	// Token: 0x0600FF3F RID: 65343 RVA: 0x003E25E0 File Offset: 0x003E07E0
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

	// Token: 0x0600FF40 RID: 65344 RVA: 0x003E28C2 File Offset: 0x003E0AC2
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600FF41 RID: 65345 RVA: 0x003E28D5 File Offset: 0x003E0AD5
	protected override void OnBeforeDestroy()
	{
		this.OnItemButtonClickedCallback = null;
		this.LevelSequencePlayer.Clear();
		this.LevelSequencePlayer = null;
	}

	// Token: 0x0600FF42 RID: 65346 RVA: 0x003E28F0 File Offset: 0x003E0AF0
	private void OnToggleStateChanged(EToggleState state)
	{
		if (this.OnItemButtonClickedCallback != null)
		{
			this.OnItemButtonClickedCallback(this.ItemViewData);
		}
	}

	// Token: 0x0600FF43 RID: 65347 RVA: 0x003E290B File Offset: 0x003E0B0B
	public void BindOnItemButtonClickedCallback(Action<global::ItemViewData> onItemButtonClicked)
	{
		this.OnItemButtonClickedCallback = onItemButtonClicked;
	}

	// Token: 0x0600FF44 RID: 65348 RVA: 0x003E2914 File Offset: 0x003E0B14
	public override void Refresh(global::ItemViewData data, bool isSelected, int gridIndex)
	{
		this.RefreshItemViewByItemData(data);
		this.SetSelected(isSelected);
	}

	// Token: 0x0600FF45 RID: 65349 RVA: 0x003E2924 File Offset: 0x003E0B24
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true);
	}

	// Token: 0x0600FF46 RID: 65350 RVA: 0x003E292D File Offset: 0x003E0B2D
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false);
	}

	// Token: 0x0600FF47 RID: 65351 RVA: 0x003E2938 File Offset: 0x003E0B38
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

	// Token: 0x0600FF48 RID: 65352 RVA: 0x003E2A38 File Offset: 0x003E0C38
	private void SetItemTexture()
	{
		UUITexture texture = base.GetTexture(0);
		base.SetItemIcon(texture, this.ItemViewData.GetConfigId(), null, null);
	}

	// Token: 0x0600FF49 RID: 65353 RVA: 0x003E2A6C File Offset: 0x003E0C6C
	private void SetQualityIcon(int qualityId)
	{
		UUISprite sprite = base.GetSprite(2);
		if (sprite == null)
		{
			return;
		}
		base.SetItemQualityIcon(sprite, this.ItemViewData.GetConfigId(), null, CommonDefine.EQualityIconType.BackgroundSprite, null);
	}

	// Token: 0x0600FF4A RID: 65354 RVA: 0x003E2AA4 File Offset: 0x003E0CA4
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

	// Token: 0x0600FF4B RID: 65355 RVA: 0x003E2AD4 File Offset: 0x003E0CD4
	private void SetLock(bool bLock)
	{
		UUISprite sprite = base.GetSprite(6);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(bLock);
	}

	// Token: 0x0600FF4C RID: 65356 RVA: 0x003E2AF4 File Offset: 0x003E0CF4
	public void SetIsNewItem(bool bNewItem)
	{
		base.GetSprite(7).SetUIActive(bNewItem);
	}

	// Token: 0x0600FF4D RID: 65357 RVA: 0x003E2B04 File Offset: 0x003E0D04
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

	// Token: 0x0600FF4E RID: 65358 RVA: 0x003E2B44 File Offset: 0x003E0D44
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

	// Token: 0x0600FF4F RID: 65359 RVA: 0x003E2B91 File Offset: 0x003E0D91
	public void SetRoleHeadVisible(bool bVisible)
	{
		base.GetItem(14).SetUIActive(bVisible);
	}

	// Token: 0x0600FF50 RID: 65360 RVA: 0x003E2BA4 File Offset: 0x003E0DA4
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

	// Token: 0x0600FF51 RID: 65361 RVA: 0x003E2BEC File Offset: 0x003E0DEC
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

	// Token: 0x0600FF52 RID: 65362 RVA: 0x003E2C40 File Offset: 0x003E0E40
	private void SetCdTimePercent(double remainingCdTime, double totalCdTime)
	{
		double num = Math.Ceiling(remainingCdTime);
		UUISprite sprite = base.GetSprite(17);
		UUIText text = base.GetText(18);
		double num2 = num / totalCdTime;
		sprite.SetFillAmount((float)num2);
		text.SetText(num.ToString(), true);
	}

	// Token: 0x0400762A RID: 30250
	[Nullable(2)]
	private global::ItemViewData ItemViewData;

	// Token: 0x0400762B RID: 30251
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400762C RID: 30252
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<global::ItemViewData> OnItemButtonClickedCallback;

	// Token: 0x020085E7 RID: 34279
	[NullableContext(0)]
	private enum EChildComponentType
	{
		// Token: 0x0402B94F RID: 178511
		ItemTexture,
		// Token: 0x0402B950 RID: 178512
		StarUiItem,
		// Token: 0x0402B951 RID: 178513
		QualitySprite,
		// Token: 0x0402B952 RID: 178514
		LevelText,
		// Token: 0x0402B953 RID: 178515
		CountText,
		// Token: 0x0402B954 RID: 178516
		ItemToggle,
		// Token: 0x0402B955 RID: 178517
		LockSprite,
		// Token: 0x0402B956 RID: 178518
		NewFlagSprite,
		// Token: 0x0402B957 RID: 178519
		Star1,
		// Token: 0x0402B958 RID: 178520
		Star2,
		// Token: 0x0402B959 RID: 178521
		Star3,
		// Token: 0x0402B95A RID: 178522
		Star4,
		// Token: 0x0402B95B RID: 178523
		Star5,
		// Token: 0x0402B95C RID: 178524
		Star6,
		// Token: 0x0402B95D RID: 178525
		RoleHeadItem,
		// Token: 0x0402B95E RID: 178526
		RoleHeadTexture,
		// Token: 0x0402B95F RID: 178527
		CdItem,
		// Token: 0x0402B960 RID: 178528
		CdSprite,
		// Token: 0x0402B961 RID: 178529
		CdText
	}
}
