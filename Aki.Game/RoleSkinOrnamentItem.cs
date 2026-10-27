using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002A5E RID: 10846
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleSkinOrnamentItem : GridProxyAbstract<RoleSkinData>
{
	// Token: 0x060169B5 RID: 92597 RVA: 0x005BAE30 File Offset: 0x005B9030
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIMultiTemplateLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060169B6 RID: 92598 RVA: 0x005BAF84 File Offset: 0x005B9184
	protected override void OnStart()
	{
		EventSystem.Instance.Add<int>(EEventName.OrnamentRedDotRefresh, new Action<int>(this.OnOrnamentRedDotRefresh));
		this.OrnamentLayout = new GenericLayout<RoleOrnamentGridItem, IRoleOrnamentGridData>(base.GetMultiTemplateLayout(6), new Func<RoleOrnamentGridItem>(this.CreateOrnamentItem), base.GetItem(7).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x060169B7 RID: 92599 RVA: 0x005BAFDE File Offset: 0x005B91DE
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove<int>(EEventName.OrnamentRedDotRefresh, new Action<int>(this.OnOrnamentRedDotRefresh));
	}

	// Token: 0x060169B8 RID: 92600 RVA: 0x005BAFFC File Offset: 0x005B91FC
	public override void Refresh(RoleSkinData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.UpdateItemDataList();
		this.RefreshView();
		this.RefreshLayout();
	}

	// Token: 0x060169B9 RID: 92601 RVA: 0x005BB018 File Offset: 0x005B9218
	private void UpdateItemDataList()
	{
		int itemId = this.Data.GetItemId();
		List<int> skinAllOrnaments = RoleOrnamentModel.Instance.GetSkinAllOrnaments(itemId, new bool?(true));
		List<IRoleOrnamentGridData> list = new List<IRoleOrnamentGridData>();
		for (int i = 0; i < skinAllOrnaments.Count; i++)
		{
			int ornamentId = skinAllOrnaments[i];
			list.Add(new RoleOrnamentGridData
			{
				SkinId = itemId,
				OrnamentId = ornamentId
			});
		}
		this.ItemDataList = list;
	}

	// Token: 0x060169BA RID: 92602 RVA: 0x005BB084 File Offset: 0x005B9284
	public void RefreshView()
	{
		RoleSkinData data = this.Data;
		bool flag = !data.IsLocked();
		bool flag2 = data.IsWear();
		base.GetItem(0).SetUIActive(flag);
		base.GetSprite(1).SetUIActive(flag2);
		base.GetItem(2).SetUIActive(!flag);
		base.SetRoleIcon(data.GetRoleSkinConfig().RoleHeadIconCircle, base.GetTexture(3), data.GetRoleId(), null, null);
		base.GetTexture(4).SetUIActive(!flag2);
		UUIText text = base.GetText(5);
		text.ShowTextNew(data.GetTitleName());
		UUIItem uuiitem = text;
		bool bUseChangeColor = flag2;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		float alpha = flag ? 1f : 0.4f;
		text.SetAlpha(alpha);
		string resourceId = flag2 ? "SP_IconAccessoriesSkinTitleBgHightLight" : "SP_IconAccessoriesSkinTitleBgNor";
		this.SetSpriteByPath(UiResourceConfig.Instance.GetResourcePath(resourceId), base.GetSprite(8), false, null, null);
	}

	// Token: 0x060169BB RID: 92603 RVA: 0x005BB189 File Offset: 0x005B9389
	public void RefreshLayout()
	{
		this.OrnamentLayout.RefreshByData(this.ItemDataList, new Action(this.RefreshGridSelected), false);
	}

	// Token: 0x060169BC RID: 92604 RVA: 0x005BB1AC File Offset: 0x005B93AC
	public void RefreshGridSelected()
	{
		Func<int> getPreviewSkinIdFunc = this.GetPreviewSkinIdFunc;
		int? num = (getPreviewSkinIdFunc != null) ? new int?(getPreviewSkinIdFunc()) : null;
		int itemId = this.Data.GetItemId();
		if (!(num.GetValueOrDefault() == itemId & num != null))
		{
			this.OrnamentLayout.DeselectCurrentGridProxy();
			return;
		}
		Func<int> getPreviewOrnamentIdFunc = this.GetPreviewOrnamentIdFunc;
		int? num2 = (getPreviewOrnamentIdFunc != null) ? new int?(getPreviewOrnamentIdFunc()) : null;
		int gridIndex = -1;
		if (num2 != null)
		{
			for (int i = 0; i < this.ItemDataList.Count; i++)
			{
				if (this.ItemDataList[i].OrnamentId == num2.Value)
				{
					gridIndex = i;
					break;
				}
			}
		}
		this.OrnamentLayout.SelectGridProxy(gridIndex, true);
	}

	// Token: 0x060169BD RID: 92605 RVA: 0x005BB277 File Offset: 0x005B9477
	public void RefreshOrnamentItems()
	{
		this.OrnamentLayout.RefreshWithoutDataSync();
	}

	// Token: 0x060169BE RID: 92606 RVA: 0x005BB284 File Offset: 0x005B9484
	public void SetClickOrnamentCallback(Action<int, int> callback)
	{
		this.ClickOrnamentCallback = callback;
	}

	// Token: 0x060169BF RID: 92607 RVA: 0x005BB28D File Offset: 0x005B948D
	public void SetGetPreviewSkinIdFunc(Func<int> func)
	{
		this.GetPreviewSkinIdFunc = func;
	}

	// Token: 0x060169C0 RID: 92608 RVA: 0x005BB296 File Offset: 0x005B9496
	public void SetGetPreviewOrnamentIdFunc(Func<int> func)
	{
		this.GetPreviewOrnamentIdFunc = func;
	}

	// Token: 0x060169C1 RID: 92609 RVA: 0x005BB29F File Offset: 0x005B949F
	private RoleOrnamentGridItem CreateOrnamentItem()
	{
		RoleOrnamentGridItem roleOrnamentGridItem = new RoleOrnamentGridItem();
		roleOrnamentGridItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnOrnamentItemClick));
		roleOrnamentGridItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OrnamentItemCanExecuteChange));
		return roleOrnamentGridItem;
	}

	// Token: 0x060169C2 RID: 92610 RVA: 0x005BB2CC File Offset: 0x005B94CC
	private void OnOrnamentItemClick(MediumItemGridExtendCallback parameters)
	{
		IRoleOrnamentGridData roleOrnamentGridData = parameters.Data as IRoleOrnamentGridData;
		if (roleOrnamentGridData == null)
		{
			return;
		}
		Action<int, int> clickOrnamentCallback = this.ClickOrnamentCallback;
		if (clickOrnamentCallback == null)
		{
			return;
		}
		clickOrnamentCallback(this.Data.GetItemId(), roleOrnamentGridData.OrnamentId);
	}

	// Token: 0x060169C3 RID: 92611 RVA: 0x005BB30C File Offset: 0x005B950C
	[NullableContext(2)]
	private bool OrnamentItemCanExecuteChange(object parameters, bool _, EToggleState __)
	{
		IRoleOrnamentGridData roleOrnamentGridData = parameters as IRoleOrnamentGridData;
		if (roleOrnamentGridData == null)
		{
			return true;
		}
		Func<int> getPreviewSkinIdFunc = this.GetPreviewSkinIdFunc;
		int? num = (getPreviewSkinIdFunc != null) ? new int?(getPreviewSkinIdFunc()) : null;
		int num2 = roleOrnamentGridData.SkinId;
		if (num.GetValueOrDefault() == num2 & num != null)
		{
			Func<int> getPreviewOrnamentIdFunc = this.GetPreviewOrnamentIdFunc;
			num = ((getPreviewOrnamentIdFunc != null) ? new int?(getPreviewOrnamentIdFunc()) : null);
			num2 = roleOrnamentGridData.OrnamentId;
			return !(num.GetValueOrDefault() == num2 & num != null);
		}
		return true;
	}

	// Token: 0x060169C4 RID: 92612 RVA: 0x005BB3A0 File Offset: 0x005B95A0
	private void OnOrnamentRedDotRefresh(int ornamentId)
	{
		RoleOrnamentGridItem layoutItemByKey = this.OrnamentLayout.GetLayoutItemByKey(ornamentId);
		if (layoutItemByKey == null)
		{
			return;
		}
		layoutItemByKey.RefreshRedDotVisible();
	}

	// Token: 0x0400A7B0 RID: 42928
	private RoleSkinData Data;

	// Token: 0x0400A7B1 RID: 42929
	private List<IRoleOrnamentGridData> ItemDataList;

	// Token: 0x0400A7B2 RID: 42930
	private GenericLayout<RoleOrnamentGridItem, IRoleOrnamentGridData> OrnamentLayout;

	// Token: 0x0400A7B3 RID: 42931
	[Nullable(2)]
	private Action<int, int> ClickOrnamentCallback;

	// Token: 0x0400A7B4 RID: 42932
	[Nullable(2)]
	private Func<int> GetPreviewSkinIdFunc;

	// Token: 0x0400A7B5 RID: 42933
	[Nullable(2)]
	private Func<int> GetPreviewOrnamentIdFunc;

	// Token: 0x020090A2 RID: 37026
	[NullableContext(0)]
	private enum EComponentType
	{
		// Token: 0x0402EDD2 RID: 191954
		UnlockItem,
		// Token: 0x0402EDD3 RID: 191955
		EquipSprite,
		// Token: 0x0402EDD4 RID: 191956
		LockItem,
		// Token: 0x0402EDD5 RID: 191957
		RoleTexture,
		// Token: 0x0402EDD6 RID: 191958
		RoleLockTexture,
		// Token: 0x0402EDD7 RID: 191959
		NameText,
		// Token: 0x0402EDD8 RID: 191960
		OrnamentLayout,
		// Token: 0x0402EDD9 RID: 191961
		OrnamentItem,
		// Token: 0x0402EDDA RID: 191962
		BgSprite
	}
}
