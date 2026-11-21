using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using UnrealEngine;

// Token: 0x02000DB1 RID: 3505
[NullableContext(1)]
[Nullable(0)]
public class TipsWeaponComponent : TipsBaseSubComponent
{
	// Token: 0x06008F4C RID: 36684 RVA: 0x002B1EC4 File Offset: 0x002B00C4
	public TipsWeaponComponent(UUIItem rootUiItem) : base(rootUiItem)
	{
		base.CreateThenShowByResourceIdAsync("UiItem_TipsWeapon", rootUiItem, false);
	}

	// Token: 0x06008F4D RID: 36685 RVA: 0x002B1EDC File Offset: 0x002B00DC
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

	// Token: 0x06008F4E RID: 36686 RVA: 0x002B2160 File Offset: 0x002B0360
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(5);
		this.TipsLockButton = new TipsLockButton(item);
		this.TipsAttributePanel = new GenericLayoutNew<TipsAttributeItem>(base.GetVerticalLayout(6), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<TipsAttributeItem>(this.CreateAttributeItem), null);
		UUIItem item2 = base.GetItem(12);
		this.TipsGetWayPanel = new TipsGetWayPanel(item2);
		this.StarLayout = new GenericLayout<CSharpScript.Game.Module.RoleUi.StarItem, IStarItemData>(base.GetHorizontalLayout(3), new Func<CSharpScript.Game.Module.RoleUi.StarItem>(this.InitStarItem), null, false, true);
	}

	// Token: 0x06008F4F RID: 36687 RVA: 0x002B21D6 File Offset: 0x002B03D6
	protected override void OnBeforeDestroy()
	{
		if (this.Data != null)
		{
			this.Data = null;
			ItemTipsModel.Instance.SetCurrentItemTipsData(null);
		}
	}

	// Token: 0x06008F50 RID: 36688 RVA: 0x002B21F4 File Offset: 0x002B03F4
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

	// Token: 0x06008F51 RID: 36689 RVA: 0x002B2248 File Offset: 0x002B0448
	private ILayoutItem<TipsAttributeItem> CreateAttributeItem(object data, UUIItem uiItem, int index)
	{
		TipsAttributeItem value = new TipsAttributeItem(uiItem, (ITipsAttributeItemData)data);
		return new LayoutItem<TipsAttributeItem>
		{
			Key = index,
			Value = value
		};
	}

	// Token: 0x06008F52 RID: 36690 RVA: 0x002B227A File Offset: 0x002B047A
	private CSharpScript.Game.Module.RoleUi.StarItem InitStarItem()
	{
		return new CSharpScript.Game.Module.RoleUi.StarItem();
	}

	// Token: 0x06008F53 RID: 36691 RVA: 0x002B2284 File Offset: 0x002B0484
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
		this.StarLayout.RefreshByData(array, null, false);
	}

	// Token: 0x06008F54 RID: 36692 RVA: 0x002B22EF File Offset: 0x002B04EF
	private void RefreshGetWayPanel(IGetWayItemData[] getWayData)
	{
		base.GetItem(12).SetUIActive(getWayData.Length != 0);
		if (getWayData != null)
		{
			this.TipsGetWayPanel.Refresh(getWayData);
		}
	}

	// Token: 0x06008F55 RID: 36693 RVA: 0x002B2312 File Offset: 0x002B0512
	private void RefreshLimitTimePanel(string limitTimeTxt)
	{
		base.GetItem(13).SetUIActive(limitTimeTxt != null);
		if (!string.IsNullOrEmpty(limitTimeTxt))
		{
			base.GetText(14).ShowTextNew(limitTimeTxt);
		}
	}

	// Token: 0x06008F56 RID: 36694 RVA: 0x002B233C File Offset: 0x002B053C
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

	// Token: 0x06008F57 RID: 36695 RVA: 0x002B23D0 File Offset: 0x002B05D0
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

	// Token: 0x040055B7 RID: 21943
	[Nullable(2)]
	private TipsWeaponData Data;

	// Token: 0x040055B8 RID: 21944
	[Nullable(2)]
	private TipsLockButton TipsLockButton;

	// Token: 0x040055B9 RID: 21945
	[Nullable(2)]
	private TipsGetWayPanel TipsGetWayPanel;

	// Token: 0x040055BA RID: 21946
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<TipsAttributeItem> TipsAttributePanel;

	// Token: 0x040055BB RID: 21947
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<CSharpScript.Game.Module.RoleUi.StarItem, IStarItemData> StarLayout;

	// Token: 0x02006FFA RID: 28666
	[NullableContext(0)]
	private class ETipsWeaponNode
	{
		// Token: 0x04024931 RID: 149809
		public const int TxtWeaponType = 0;

		// Token: 0x04024932 RID: 149810
		public const int TxtLevel = 1;

		// Token: 0x04024933 RID: 149811
		public const int TxtLevelLimit = 2;

		// Token: 0x04024934 RID: 149812
		public const int PanelStar = 3;

		// Token: 0x04024935 RID: 149813
		public const int ItemStar = 4;

		// Token: 0x04024936 RID: 149814
		public const int LockButton = 5;

		// Token: 0x04024937 RID: 149815
		public const int PanelAttribute = 6;

		// Token: 0x04024938 RID: 149816
		public const int ItemAttribute = 7;

		// Token: 0x04024939 RID: 149817
		public const int TxtWeaponStage = 8;

		// Token: 0x0402493A RID: 149818
		public const int TxtSkillName = 9;

		// Token: 0x0402493B RID: 149819
		public const int TxtWeaponEffect = 10;

		// Token: 0x0402493C RID: 149820
		public const int TxtDescription = 11;

		// Token: 0x0402493D RID: 149821
		public const int PanelPath = 12;

		// Token: 0x0402493E RID: 149822
		public const int PanelLimitTime = 13;

		// Token: 0x0402493F RID: 149823
		public const int TxtLimitTime = 14;

		// Token: 0x04024940 RID: 149824
		public const int PanelEquip = 15;

		// Token: 0x04024941 RID: 149825
		public const int TextureEquipIcon = 16;

		// Token: 0x04024942 RID: 149826
		public const int TxtEquip = 17;
	}
}
