using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using UnrealEngine;

// Token: 0x020018F5 RID: 6389
[NullableContext(1)]
[Nullable(0)]
public class TipsMaterialComponent : TipsBaseSubComponent
{
	// Token: 0x0600BB39 RID: 47929 RVA: 0x002A62BD File Offset: 0x002A44BD
	public TipsMaterialComponent(UUIItem rootUiItem) : base(rootUiItem)
	{
		base.CreateThenShowByResourceIdAsync("UiItem_TipsMaterial", rootUiItem, false);
	}

	// Token: 0x0600BB3A RID: 47930 RVA: 0x002A62D4 File Offset: 0x002A44D4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 14;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BB3B RID: 47931 RVA: 0x002A64D0 File Offset: 0x002A46D0
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(6);
		this.TipsGetWayPanel = new TipsGetWayPanel(item);
	}

	// Token: 0x0600BB3C RID: 47932 RVA: 0x002A64F1 File Offset: 0x002A46F1
	protected override void OnBeforeDestroy()
	{
		if (this.Data != null)
		{
			this.Data = null;
			ItemTipsModel.Instance.SetCurrentItemTipsData(null);
		}
	}

	// Token: 0x0600BB3D RID: 47933 RVA: 0x002A6510 File Offset: 0x002A4710
	public override void Refresh(ItemTipsData data)
	{
		TipsMaterialData tipsMaterialData = (TipsMaterialData)data;
		Action action = delegate()
		{
			TipsMaterialData data2 = this.Data;
			this.RefreshBaseInfo(data2);
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(data2.ConfigId);
			bool isHideHave = this.GetIsHideHave(new int?((int)((itemConfigData != null) ? itemConfigData.ItemType : null).Value));
			this.RefreshStockAndGetWay(data2, new int?((int)((itemConfigData != null) ? itemConfigData.ItemType : null).Value), isHideHave);
			this.RefreshRoleDevelopPanel(data2);
		};
		this.Data = tipsMaterialData;
		ItemTipsModel.Instance.SetCurrentItemTipsData(tipsMaterialData);
		if (base.InAsyncLoading())
		{
			this.OperationMap["Refresh"] = action;
			return;
		}
		action();
	}

	// Token: 0x0600BB3E RID: 47934 RVA: 0x002A6564 File Offset: 0x002A4764
	private void RefreshBaseInfo(TipsMaterialData data)
	{
		bool flag = !StringUtils.IsEmpty(data.MaterialType);
		if (flag)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.MaterialType, Array.Empty<object>());
		}
		base.GetText(0).SetUIActive(flag);
		base.GetSprite(1).SetUIActive(data.FunctionSpritePath != null);
		if (!string.IsNullOrEmpty(data.FunctionSpritePath))
		{
			this.SetSpriteByPath(data.FunctionSpritePath, base.GetSprite(1), false, null, null);
		}
		bool flag2 = !StringUtils.IsEmpty(data.TxtEffect);
		if (flag2)
		{
			if (data.EffectAutoLocalText)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), data.TxtEffect, data.TxtEffectArgs);
			}
			else
			{
				UUIText text = base.GetText(4);
				if (text != null)
				{
					text.SetText(data.TxtEffect, true);
				}
			}
		}
		base.GetText(4).SetUIActive(flag2);
		bool flag3 = !StringUtils.IsEmpty(data.TxtDescription);
		if (flag3)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), data.TxtDescription, Array.Empty<object>());
		}
		if (!string.IsNullOrEmpty(data.ExTxtDescription))
		{
			UUIText text2 = base.GetText(13);
			if (text2 != null)
			{
				text2.SetText(data.ExTxtDescription, true);
			}
			UUIText text3 = base.GetText(13);
			if (text3 != null)
			{
				text3.SetUIActive(true);
			}
		}
		else
		{
			UUIText text4 = base.GetText(13);
			if (text4 != null)
			{
				text4.SetUIActive(false);
			}
		}
		base.GetText(5).SetUIActive(flag3);
		this.RefreshLimitTimePanel(data.LimitTimeTxt);
	}

	// Token: 0x0600BB3F RID: 47935 RVA: 0x002A66E4 File Offset: 0x002A48E4
	private bool GetIsHideHave(int? itemType)
	{
		bool result = false;
		if (itemType != null)
		{
			TypeInfo? itemTypeConfig = InventoryConfig.Instance.GetItemTypeConfig(itemType.Value);
			if (itemTypeConfig != null && !itemTypeConfig.Value.ShowStock)
			{
				result = true;
			}
		}
		return result;
	}

	// Token: 0x0600BB40 RID: 47936 RVA: 0x002A672C File Offset: 0x002A492C
	private void RefreshStockAndGetWay(TipsMaterialData data, int? itemType, bool isHideHave)
	{
		this.SetPanelNumVisible(!isHideHave);
		int? num = itemType;
		this.RefreshGetWayPanel(this.GetWayDataList(data, (num != null) ? new InventoryDefine.EItemType?((InventoryDefine.EItemType)num.GetValueOrDefault()) : null));
		if (!isHideHave)
		{
			int num2 = data.Num;
			base.GetText(3).SetText(num2.ToString(), true);
			base.GetText(3).useChangeColor = (num2 == 0);
		}
	}

	// Token: 0x0600BB41 RID: 47937 RVA: 0x002A67A0 File Offset: 0x002A49A0
	private void RefreshRoleDevelopPanel(TipsMaterialData data)
	{
		RoleDevelopModel instance = RoleDevelopModel.Instance;
		bool flag = instance != null && instance.DevTargetRoleId != 0 && instance.IsDevelopRoleNeedItem(data.ConfigId);
		int num = flag ? instance.GetDevelopRoleNeedItemCount(data.ConfigId) : 0;
		int num2 = data.Num;
		bool flag2 = flag && num > 0 && num2 < num;
		base.GetItem(9).SetUIActive(flag2);
		if (!flag2)
		{
			return;
		}
		string developRoleSmallIconPath = instance.GetDevelopRoleSmallIconPath();
		if (!StringUtils.IsEmpty(developRoleSmallIconPath))
		{
			base.SetTextureByPath(developRoleSmallIconPath, base.GetTexture(10), null, null);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "RoleProject_ItemCount", new <>z__ReadOnlySingleElementList<object>(num - num2));
		bool uiactive = instance.IsDevelopRoleNeedItemCanBeSupplemented(data.ConfigId);
		base.GetItem(12).SetUIActive(uiactive);
	}

	// Token: 0x0600BB42 RID: 47938 RVA: 0x002A6874 File Offset: 0x002A4A74
	public IGetWayItemData[] GetWayDataList(TipsMaterialData data, InventoryDefine.EItemType? itemType)
	{
		bool flag = data.Num > 0;
		if (itemType.GetValueOrDefault() == InventoryDefine.EItemType.ShipTowerBuff && flag)
		{
			return new IGetWayItemData[0];
		}
		return data.GetWayData ?? new IGetWayItemData[0];
	}

	// Token: 0x0600BB43 RID: 47939 RVA: 0x002A68B4 File Offset: 0x002A4AB4
	private void RefreshGetWayPanel(IGetWayItemData[] getWayData)
	{
		bool uiactive = this.NeedShowTip(getWayData);
		base.GetItem(6).SetUIActive(uiactive);
		if (getWayData != null)
		{
			this.TipsGetWayPanel.Refresh(getWayData);
		}
	}

	// Token: 0x0600BB44 RID: 47940 RVA: 0x002A68E5 File Offset: 0x002A4AE5
	private bool NeedShowTip(IGetWayItemData[] getWayData)
	{
		return getWayData.Length != 0 && !RecallQuestModel.Instance.IsInRecallInstance();
	}

	// Token: 0x0600BB45 RID: 47941 RVA: 0x002A68FA File Offset: 0x002A4AFA
	private void RefreshLimitTimePanel(string limitTimeTxt)
	{
		base.GetItem(7).SetUIActive(limitTimeTxt != null);
		if (!string.IsNullOrEmpty(limitTimeTxt))
		{
			base.GetText(8).SetText(limitTimeTxt, true);
		}
	}

	// Token: 0x0600BB46 RID: 47942 RVA: 0x002A6924 File Offset: 0x002A4B24
	public override void SetPanelNumVisible(bool isShow)
	{
		Action action = delegate()
		{
			this.GetItem(2).SetUIActive(isShow);
		};
		if (base.InAsyncLoading())
		{
			this.OperationMap["SetPanelNumVisible"] = action;
			return;
		}
		action();
	}

	// Token: 0x04005501 RID: 21761
	[Nullable(2)]
	private TipsMaterialData Data;

	// Token: 0x04005502 RID: 21762
	[Nullable(2)]
	private TipsGetWayPanel TipsGetWayPanel;

	// Token: 0x02007E6A RID: 32362
	[NullableContext(0)]
	private class ETipsMaterialNode
	{
		// Token: 0x040295C9 RID: 169417
		public const int TxtType = 0;

		// Token: 0x040295CA RID: 169418
		public const int SpriteIcon = 1;

		// Token: 0x040295CB RID: 169419
		public const int PanelNum = 2;

		// Token: 0x040295CC RID: 169420
		public const int TxtNum = 3;

		// Token: 0x040295CD RID: 169421
		public const int TxtEffect = 4;

		// Token: 0x040295CE RID: 169422
		public const int TxtDescription = 5;

		// Token: 0x040295CF RID: 169423
		public const int PanelPath = 6;

		// Token: 0x040295D0 RID: 169424
		public const int PanelLimitTime = 7;

		// Token: 0x040295D1 RID: 169425
		public const int TxtLimitTime = 8;

		// Token: 0x040295D2 RID: 169426
		public const int PnlRoleDevelopMat = 9;

		// Token: 0x040295D3 RID: 169427
		public const int TexRole = 10;

		// Token: 0x040295D4 RID: 169428
		public const int TxtLinkDesc = 11;

		// Token: 0x040295D5 RID: 169429
		public const int UiItemRoleDevelopMatFull = 12;

		// Token: 0x040295D6 RID: 169430
		public const int ExTxtDescription = 13;
	}
}
