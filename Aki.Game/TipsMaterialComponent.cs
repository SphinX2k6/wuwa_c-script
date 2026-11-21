using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using UnrealEngine;

// Token: 0x02000DAE RID: 3502
[NullableContext(1)]
[Nullable(0)]
public class TipsMaterialComponent : TipsBaseSubComponent
{
	// Token: 0x06008F23 RID: 36643 RVA: 0x002B0A1D File Offset: 0x002AEC1D
	public TipsMaterialComponent(UUIItem rootUiItem) : base(rootUiItem)
	{
		base.CreateThenShowByResourceIdAsync("UiItem_TipsMaterial", rootUiItem, false);
	}

	// Token: 0x06008F24 RID: 36644 RVA: 0x002B0A34 File Offset: 0x002AEC34
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

	// Token: 0x06008F25 RID: 36645 RVA: 0x002B0C30 File Offset: 0x002AEE30
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(6);
		this.TipsGetWayPanel = new TipsGetWayPanel(item);
	}

	// Token: 0x06008F26 RID: 36646 RVA: 0x002B0C51 File Offset: 0x002AEE51
	protected override void OnBeforeDestroy()
	{
		if (this.Data != null)
		{
			this.Data = null;
			ItemTipsModel.Instance.SetCurrentItemTipsData(null);
		}
	}

	// Token: 0x06008F27 RID: 36647 RVA: 0x002B0C70 File Offset: 0x002AEE70
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

	// Token: 0x06008F28 RID: 36648 RVA: 0x002B0CC4 File Offset: 0x002AEEC4
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

	// Token: 0x06008F29 RID: 36649 RVA: 0x002B0E44 File Offset: 0x002AF044
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

	// Token: 0x06008F2A RID: 36650 RVA: 0x002B0E8C File Offset: 0x002AF08C
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

	// Token: 0x06008F2B RID: 36651 RVA: 0x002B0F00 File Offset: 0x002AF100
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

	// Token: 0x06008F2C RID: 36652 RVA: 0x002B0FD4 File Offset: 0x002AF1D4
	public IGetWayItemData[] GetWayDataList(TipsMaterialData data, InventoryDefine.EItemType? itemType)
	{
		bool flag = data.Num > 0;
		if (itemType.GetValueOrDefault() == InventoryDefine.EItemType.ShipTowerBuff && flag)
		{
			return new IGetWayItemData[0];
		}
		return data.GetWayData ?? new IGetWayItemData[0];
	}

	// Token: 0x06008F2D RID: 36653 RVA: 0x002B1014 File Offset: 0x002AF214
	private void RefreshGetWayPanel(IGetWayItemData[] getWayData)
	{
		bool uiactive = this.NeedShowTip(getWayData);
		base.GetItem(6).SetUIActive(uiactive);
		if (getWayData != null)
		{
			this.TipsGetWayPanel.Refresh(getWayData);
		}
	}

	// Token: 0x06008F2E RID: 36654 RVA: 0x002B1045 File Offset: 0x002AF245
	private bool NeedShowTip(IGetWayItemData[] getWayData)
	{
		return getWayData.Length != 0 && !RecallQuestModel.Instance.IsInRecallInstance();
	}

	// Token: 0x06008F2F RID: 36655 RVA: 0x002B105A File Offset: 0x002AF25A
	private void RefreshLimitTimePanel(string limitTimeTxt)
	{
		base.GetItem(7).SetUIActive(limitTimeTxt != null);
		if (!string.IsNullOrEmpty(limitTimeTxt))
		{
			base.GetText(8).SetText(limitTimeTxt, true);
		}
	}

	// Token: 0x06008F30 RID: 36656 RVA: 0x002B1084 File Offset: 0x002AF284
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

	// Token: 0x040055AC RID: 21932
	[Nullable(2)]
	private TipsMaterialData Data;

	// Token: 0x040055AD RID: 21933
	[Nullable(2)]
	private TipsGetWayPanel TipsGetWayPanel;

	// Token: 0x02006FF1 RID: 28657
	[NullableContext(0)]
	private class ETipsMaterialNode
	{
		// Token: 0x040248F5 RID: 149749
		public const int TxtType = 0;

		// Token: 0x040248F6 RID: 149750
		public const int SpriteIcon = 1;

		// Token: 0x040248F7 RID: 149751
		public const int PanelNum = 2;

		// Token: 0x040248F8 RID: 149752
		public const int TxtNum = 3;

		// Token: 0x040248F9 RID: 149753
		public const int TxtEffect = 4;

		// Token: 0x040248FA RID: 149754
		public const int TxtDescription = 5;

		// Token: 0x040248FB RID: 149755
		public const int PanelPath = 6;

		// Token: 0x040248FC RID: 149756
		public const int PanelLimitTime = 7;

		// Token: 0x040248FD RID: 149757
		public const int TxtLimitTime = 8;

		// Token: 0x040248FE RID: 149758
		public const int PnlRoleDevelopMat = 9;

		// Token: 0x040248FF RID: 149759
		public const int TexRole = 10;

		// Token: 0x04024900 RID: 149760
		public const int TxtLinkDesc = 11;

		// Token: 0x04024901 RID: 149761
		public const int UiItemRoleDevelopMatFull = 12;

		// Token: 0x04024902 RID: 149762
		public const int ExTxtDescription = 13;
	}
}
