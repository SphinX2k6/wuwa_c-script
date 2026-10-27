using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using UnrealEngine;

// Token: 0x020018F8 RID: 6392
[NullableContext(1)]
[Nullable(0)]
public class TipsWeaponComponent : TipsBaseSubComponent
{
	// Token: 0x0600BB62 RID: 47970 RVA: 0x002A7764 File Offset: 0x002A5964
	public TipsWeaponComponent(UUIItem rootUiItem) : base(rootUiItem)
	{
		base.CreateThenShowByResourceIdAsync("UiItem_TipsWeapon", rootUiItem, false);
	}

	// Token: 0x0600BB63 RID: 47971 RVA: 0x002A777C File Offset: 0x002A597C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 18;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BB64 RID: 47972 RVA: 0x002A7A00 File Offset: 0x002A5C00
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(5);
		this.TipsLockButton = new TipsLockButton(item);
		this.TipsAttributePanel = new GenericLayoutNew<TipsAttributeItem>(base.GetVerticalLayout(6), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<TipsAttributeItem>(this.CreateAttributeItem), null);
		UUIItem item2 = base.GetItem(12);
		this.TipsGetWayPanel = new TipsGetWayPanel(item2);
		this.StarLayout = new GenericLayout<CSharpScript.Game.Module.RoleUi.StarItem, IStarItemData>(base.GetHorizontalLayout(3), new Func<CSharpScript.Game.Module.RoleUi.StarItem>(this.InitStarItem), null, false, true);
	}

	// Token: 0x0600BB65 RID: 47973 RVA: 0x002A7A76 File Offset: 0x002A5C76
	protected override void OnBeforeDestroy()
	{
		if (this.Data != null)
		{
			this.Data = null;
			ItemTipsModel.Instance.SetCurrentItemTipsData(null);
		}
	}

	// Token: 0x0600BB66 RID: 47974 RVA: 0x002A7A94 File Offset: 0x002A5C94
	public override void Refresh(ItemTipsData data)
	{
		TipsWeaponData tipsWeaponData = (TipsWeaponData)data;
		Action action = delegate()
		{
			TipsWeaponData data2 = this.Data;
			base.GetText(0).SetText(data2.WeaponType, true);
			base.GetText(1).SetText(data2.WeaponLevel.ToString() + "/", true);
			base.GetText(2).SetText(data2.WeaponLimitLevel.ToString(), true);
			this.UpdateStar(data2.BreachLevel, data2.BreachMaxLevel);
			if (data2.IncId > 0)
			{
				this.TipsLockButton.Refresh(data2.IncId, data2.CanClickLockButton);
				this.TipsLockButton.SetDeprecateToggleVisible(data2.CanDeprecate());
			}
			this.TipsLockButton.SetUiActive(data2.IncId > 0);
			this.TipsAttributePanel.RebuildLayoutByDataNew<ITipsAttributeItemData>(data2.AttributeData, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "Text_WeaponResonanceItemLevelText_Text", new <>z__ReadOnlySingleElementList<object>(data2.WeaponStage));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), data2.WeaponSkillName, Array.Empty<object>());
			int num = data2.WeaponEffectParam.Length;
			string[] array = new string[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = data2.WeaponEffectParam[i];
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), data2.WeaponEffect, array);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), data2.WeaponDescription, Array.Empty<object>());
			this.RefreshGetWayPanel(data2.GetWayData);
			this.RefreshLimitTimePanel(data2.LimitTimeTxt);
			this.RefreshEquipPanel(data2.IsEquip, data2.EquippedId);
		};
		this.Data = tipsWeaponData;
		ItemTipsModel.Instance.SetCurrentItemTipsData(tipsWeaponData);
		if (base.InAsyncLoading())
		{
			this.OperationMap["Refresh"] = action;
			return;
		}
		action();
	}

	// Token: 0x0600BB67 RID: 47975 RVA: 0x002A7AE8 File Offset: 0x002A5CE8
	private ILayoutItem<TipsAttributeItem> CreateAttributeItem(object data, UUIItem uiItem, int index)
	{
		TipsAttributeItem value = new TipsAttributeItem(uiItem, (ITipsAttributeItemData)data);
		return new LayoutItem<TipsAttributeItem>
		{
			Key = index,
			Value = value
		};
	}

	// Token: 0x0600BB68 RID: 47976 RVA: 0x002A7B1A File Offset: 0x002A5D1A
	private CSharpScript.Game.Module.RoleUi.StarItem InitStarItem()
	{
		return new CSharpScript.Game.Module.RoleUi.StarItem();
	}

	// Token: 0x0600BB69 RID: 47977 RVA: 0x002A7B24 File Offset: 0x002A5D24
	private void UpdateStar(int breachLevel, int maxLevel)
	{
		IStarItemData[] array = new IStarItemData[maxLevel];
		for (int i = 0; i < maxLevel; i++)
		{
			StarItemData starItemData = new StarItemData
			{
				StarOnActive = (i < breachLevel),
				StarOffActive = (i >= breachLevel),
				StarNextActive = false,
				StarLoopActive = false,
				PlayLoopSequence = false,
				PlayActivateSequence = false
			};
			array[i] = starItemData;
		}
		this.StarLayout.RefreshByData(array.ToList<IStarItemData>(), null, false);
	}

	// Token: 0x0600BB6A RID: 47978 RVA: 0x002A7B94 File Offset: 0x002A5D94
	private void RefreshGetWayPanel(IGetWayItemData[] getWayData)
	{
		base.GetItem(12).SetUIActive(getWayData.Length != 0);
		if (getWayData != null)
		{
			this.TipsGetWayPanel.Refresh(getWayData);
		}
	}

	// Token: 0x0600BB6B RID: 47979 RVA: 0x002A7BB7 File Offset: 0x002A5DB7
	private void RefreshLimitTimePanel(string limitTimeTxt)
	{
		base.GetItem(13).SetUIActive(limitTimeTxt != null);
		if (!string.IsNullOrEmpty(limitTimeTxt))
		{
			base.GetText(14).ShowTextNew(limitTimeTxt);
		}
	}

	// Token: 0x0600BB6C RID: 47980 RVA: 0x002A7BE0 File Offset: 0x002A5DE0
	private void RefreshEquipPanel(bool isEquipped, int? equippedId = null)
	{
		base.GetItem(15).SetUIActive(isEquipped);
		if (isEquipped && equippedId != null)
		{
			RoleSkinData roleSkinDataByRoleId = RoleSkinModel.Instance.GetRoleSkinDataByRoleId(equippedId.Value);
			if (roleSkinDataByRoleId != null)
			{
				base.SetRoleSkinIcon(roleSkinDataByRoleId.GetRoleSkinConfig().RoleHeadIcon, base.GetTexture(16), roleSkinDataByRoleId.GetItemId(), null, null);
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew(roleSkinDataByRoleId.GetName(), null);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(17), "VisionEquipping", new <>z__ReadOnlySingleElementList<object>(localTextNew));
			}
		}
	}

	// Token: 0x0600BB6D RID: 47981 RVA: 0x002A7C74 File Offset: 0x002A5E74
	public override void SetLockButtonShow(bool isShow)
	{
		Action action = delegate()
		{
			this.GetItem(5).SetUIActive(isShow);
		};
		if (base.InAsyncLoading())
		{
			this.OperationMap["SetLockButtonShow"] = action;
			return;
		}
		action();
	}

	// Token: 0x0400550C RID: 21772
	[Nullable(2)]
	private TipsWeaponData Data;

	// Token: 0x0400550D RID: 21773
	[Nullable(2)]
	private TipsLockButton TipsLockButton;

	// Token: 0x0400550E RID: 21774
	[Nullable(2)]
	private TipsGetWayPanel TipsGetWayPanel;

	// Token: 0x0400550F RID: 21775
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<TipsAttributeItem> TipsAttributePanel;

	// Token: 0x04005510 RID: 21776
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<CSharpScript.Game.Module.RoleUi.StarItem, IStarItemData> StarLayout;

	// Token: 0x02007E73 RID: 32371
	[NullableContext(0)]
	private class ETipsWeaponNode
	{
		// Token: 0x04029605 RID: 169477
		public const int TxtWeaponType = 0;

		// Token: 0x04029606 RID: 169478
		public const int TxtLevel = 1;

		// Token: 0x04029607 RID: 169479
		public const int TxtLevelLimit = 2;

		// Token: 0x04029608 RID: 169480
		public const int PanelStar = 3;

		// Token: 0x04029609 RID: 169481
		public const int ItemStar = 4;

		// Token: 0x0402960A RID: 169482
		public const int LockButton = 5;

		// Token: 0x0402960B RID: 169483
		public const int PanelAttribute = 6;

		// Token: 0x0402960C RID: 169484
		public const int ItemAttribute = 7;

		// Token: 0x0402960D RID: 169485
		public const int TxtWeaponStage = 8;

		// Token: 0x0402960E RID: 169486
		public const int TxtSkillName = 9;

		// Token: 0x0402960F RID: 169487
		public const int TxtWeaponEffect = 10;

		// Token: 0x04029610 RID: 169488
		public const int TxtDescription = 11;

		// Token: 0x04029611 RID: 169489
		public const int PanelPath = 12;

		// Token: 0x04029612 RID: 169490
		public const int PanelLimitTime = 13;

		// Token: 0x04029613 RID: 169491
		public const int TxtLimitTime = 14;

		// Token: 0x04029614 RID: 169492
		public const int PanelEquip = 15;

		// Token: 0x04029615 RID: 169493
		public const int TextureEquipIcon = 16;

		// Token: 0x04029616 RID: 169494
		public const int TxtEquip = 17;
	}
}
