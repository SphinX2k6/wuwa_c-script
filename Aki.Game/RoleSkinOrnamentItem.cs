using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001FD9 RID: 8153
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleSkinOrnamentItem : GridProxyAbstract<RoleSkinData>
{
	// Token: 0x060143D6 RID: 82902 RVA: 0x005E6FB8 File Offset: 0x005E51B8
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

	// Token: 0x060143D7 RID: 82903 RVA: 0x005E710C File Offset: 0x005E530C
	protected override void OnStart()
	{
		EventSystem.Instance.Add<int>(EEventName.OrnamentRedDotRefresh, new Action<int>(this.OnOrnamentRedDotRefresh));
		this.OrnamentLayout = new GenericLayout<RoleOrnamentGridItem, IRoleOrnamentGridData>(base.GetMultiTemplateLayout(6), new Func<RoleOrnamentGridItem>(this.CreateOrnamentItem), base.GetItem(7).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x060143D8 RID: 82904 RVA: 0x005E7166 File Offset: 0x005E5366
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove<int>(EEventName.OrnamentRedDotRefresh, new Action<int>(this.OnOrnamentRedDotRefresh));
	}

	// Token: 0x060143D9 RID: 82905 RVA: 0x005E7184 File Offset: 0x005E5384
	public override void Refresh(RoleSkinData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.UpdateItemDataList();
		this.RefreshView();
		this.RefreshLayout();
	}

	// Token: 0x060143DA RID: 82906 RVA: 0x005E71A0 File Offset: 0x005E53A0
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

	// Token: 0x060143DB RID: 82907 RVA: 0x005E720C File Offset: 0x005E540C
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

	// Token: 0x060143DC RID: 82908 RVA: 0x005E7311 File Offset: 0x005E5511
	public void RefreshLayout()
	{
		this.OrnamentLayout.RefreshByData(this.ItemDataList, new Action(this.RefreshGridSelected), false);
	}

	// Token: 0x060143DD RID: 82909 RVA: 0x005E7334 File Offset: 0x005E5534
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

	// Token: 0x060143DE RID: 82910 RVA: 0x005E73FF File Offset: 0x005E55FF
	public void RefreshOrnamentItems()
	{
		this.OrnamentLayout.RefreshWithoutDataSync();
	}

	// Token: 0x060143DF RID: 82911 RVA: 0x005E740C File Offset: 0x005E560C
	public void SetClickOrnamentCallback(Action<int, int> callback)
	{
		this.ClickOrnamentCallback = callback;
	}

	// Token: 0x060143E0 RID: 82912 RVA: 0x005E7415 File Offset: 0x005E5615
	public void SetGetPreviewSkinIdFunc(Func<int> func)
	{
		this.GetPreviewSkinIdFunc = func;
	}

	// Token: 0x060143E1 RID: 82913 RVA: 0x005E741E File Offset: 0x005E561E
	public void SetGetPreviewOrnamentIdFunc(Func<int> func)
	{
		this.GetPreviewOrnamentIdFunc = func;
	}

	// Token: 0x060143E2 RID: 82914 RVA: 0x005E7427 File Offset: 0x005E5627
	private RoleOrnamentGridItem CreateOrnamentItem()
	{
		RoleOrnamentGridItem roleOrnamentGridItem = new RoleOrnamentGridItem();
		roleOrnamentGridItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnOrnamentItemClick));
		roleOrnamentGridItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OrnamentItemCanExecuteChange));
		return roleOrnamentGridItem;
	}

	// Token: 0x060143E3 RID: 82915 RVA: 0x005E7454 File Offset: 0x005E5654
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

	// Token: 0x060143E4 RID: 82916 RVA: 0x005E7494 File Offset: 0x005E5694
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

	// Token: 0x060143E5 RID: 82917 RVA: 0x005E7528 File Offset: 0x005E5728
	private void OnOrnamentRedDotRefresh(int ornamentId)
	{
		RoleOrnamentGridItem layoutItemByKey = this.OrnamentLayout.GetLayoutItemByKey(ornamentId);
		if (layoutItemByKey == null)
		{
			return;
		}
		layoutItemByKey.RefreshRedDotVisible();
	}

	// Token: 0x0400ABB4 RID: 43956
	private RoleSkinData Data;

	// Token: 0x0400ABB5 RID: 43957
	private List<IRoleOrnamentGridData> ItemDataList;

	// Token: 0x0400ABB6 RID: 43958
	private GenericLayout<RoleOrnamentGridItem, IRoleOrnamentGridData> OrnamentLayout;

	// Token: 0x0400ABB7 RID: 43959
	[Nullable(2)]
	private Action<int, int> ClickOrnamentCallback;

	// Token: 0x0400ABB8 RID: 43960
	[Nullable(2)]
	private Func<int> GetPreviewSkinIdFunc;

	// Token: 0x0400ABB9 RID: 43961
	[Nullable(2)]
	private Func<int> GetPreviewOrnamentIdFunc;

	// Token: 0x020082E9 RID: 33513
	[NullableContext(0)]
	private enum EComponentType
	{
		// Token: 0x0402A4CC RID: 173260
		UnlockItem,
		// Token: 0x0402A4CD RID: 173261
		EquipSprite,
		// Token: 0x0402A4CE RID: 173262
		LockItem,
		// Token: 0x0402A4CF RID: 173263
		RoleTexture,
		// Token: 0x0402A4D0 RID: 173264
		RoleLockTexture,
		// Token: 0x0402A4D1 RID: 173265
		NameText,
		// Token: 0x0402A4D2 RID: 173266
		OrnamentLayout,
		// Token: 0x0402A4D3 RID: 173267
		OrnamentItem,
		// Token: 0x0402A4D4 RID: 173268
		BgSprite
	}
}
