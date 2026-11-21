using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200049B RID: 1179
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FurnitureScrollItem : GridProxyAbstract<FurnitureScrollItemData>
{
	// Token: 0x06003C13 RID: 15379 RVA: 0x00154A28 File Offset: 0x00152C28
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUITexture)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleStateChange))
		};
	}

	// Token: 0x06003C14 RID: 15380 RVA: 0x00154B88 File Offset: 0x00152D88
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChangeInternal));
		extendToggle.OnPointUpCallBack.Bind(new Action<EToggleState>(this.OnPointUpCallBackInternal));
		extendToggle.OnPointEnterCallBack.Bind(new Action<EToggleState>(this.OnPointerEnterInternal));
	}

	// Token: 0x06003C15 RID: 15381 RVA: 0x00154BE0 File Offset: 0x00152DE0
	[NullableContext(1)]
	public override void Refresh(FurnitureScrollItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.RefreshItemToggle(true);
		this.RefreshCheckItem();
		this.RefreshFurnitureIcon();
		this.RefreshCount();
		this.RefreshAtmosphere();
		this.RefreshLock();
		this.RefreshBan();
		this.RefreshRoleIcon();
		this.RefreshRedDot();
		this.RefreshQuality();
	}

	// Token: 0x06003C16 RID: 15382 RVA: 0x00154C34 File Offset: 0x00152E34
	public void RefreshItemToggle(bool bToEndFrame = false)
	{
		FurnitureScrollItemData data = this.Data;
		EToggleState state = (data != null && data.IsSelected) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleStateForce(state, false, false, bToEndFrame);
	}

	// Token: 0x06003C17 RID: 15383 RVA: 0x00154C6C File Offset: 0x00152E6C
	public void RefreshCheckItem()
	{
		FurnitureScrollItemData data = this.Data;
		bool uiactive = data != null && data.IsCheck;
		base.GetItem(4).SetUIActive(uiactive);
	}

	// Token: 0x06003C18 RID: 15384 RVA: 0x00154C9C File Offset: 0x00152E9C
	public void RefreshFurnitureIcon()
	{
		FurnitureScrollItemData data = this.Data;
		Furniture? furniture = (data != null) ? new Furniture?(data.FurnitureConfig) : null;
		base.SetTextureByPath(((furniture != null) ? furniture.GetValueOrDefault().Icon : null) ?? "", base.GetTexture(2), null, null);
	}

	// Token: 0x06003C19 RID: 15385 RVA: 0x00154D04 File Offset: 0x00152F04
	public void RefreshCount()
	{
		FurnitureScrollItemData data = this.Data;
		bool flag = data != null && data.IsLock;
		FurnitureScrollItemData data2 = this.Data;
		int value = (data2 != null) ? data2.LeftCount : 0;
		FurnitureScrollItemData data3 = this.Data;
		int num = (data3 != null) ? data3.FurnitureConfig.LimitCount : 0;
		base.GetItem(6).SetUIActive(!flag && num > 0);
		if (!flag)
		{
			UUIText text = base.GetText(7);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
	}

	// Token: 0x06003C1A RID: 15386 RVA: 0x00154DA4 File Offset: 0x00152FA4
	public void RefreshBan()
	{
		FurnitureScrollItemData data = this.Data;
		int num = (data != null) ? data.FurnitureConfig.LimitCount : 0;
		FurnitureScrollItemData data2 = this.Data;
		int num2 = (data2 != null) ? data2.LeftCount : 0;
		FurnitureScrollItemData data3 = this.Data;
		bool flag = data3 != null && data3.IsLock;
		FurnitureScrollItemData data4 = this.Data;
		bool flag2 = data4 != null && data4.IsSelected;
		base.GetItem(3).SetUIActive(!flag && !flag2 && num > 0 && num2 <= 0);
	}

	// Token: 0x06003C1B RID: 15387 RVA: 0x00154E28 File Offset: 0x00153028
	public void RefreshRoleIcon()
	{
		FurnitureScrollItemData data = this.Data;
		Furniture? furniture = (data != null) ? new Furniture?(data.FurnitureConfig) : null;
		bool flag = furniture != null && furniture.GetValueOrDefault().SourceType == 2;
		base.GetItem(12).SetUIActive(flag);
		if (flag)
		{
			base.SetTextureShowUntilLoaded(((furniture != null) ? furniture.GetValueOrDefault().RoleIconPath : null) ?? "", base.GetTexture(5), null);
		}
	}

	// Token: 0x06003C1C RID: 15388 RVA: 0x00154EB8 File Offset: 0x001530B8
	public void RefreshAtmosphere()
	{
		FurnitureScrollItemData data = this.Data;
		Furniture? furniture = (data != null) ? new Furniture?(data.FurnitureConfig) : null;
		base.GetText(9).SetText(((furniture != null) ? furniture.GetValueOrDefault().Atmosphere.ToString() : null) ?? "", true);
	}

	// Token: 0x06003C1D RID: 15389 RVA: 0x00154F1F File Offset: 0x0015311F
	public void RefreshLock()
	{
		UUIItem item = base.GetItem(10);
		FurnitureScrollItemData data = this.Data;
		item.SetUIActive(data != null && data.IsLock);
	}

	// Token: 0x06003C1E RID: 15390 RVA: 0x00154F40 File Offset: 0x00153140
	public void RefreshRedDot()
	{
		UUIItem item = base.GetItem(11);
		FurnitureScrollItemData data = this.Data;
		item.SetUIActive(data != null && data.RedDotShowState);
	}

	// Token: 0x06003C1F RID: 15391 RVA: 0x00154F64 File Offset: 0x00153164
	public void RefreshQuality()
	{
		FurnitureScrollItemData data = this.Data;
		int qualityId = (data != null) ? data.FurnitureConfig.QualityId : 0;
		FurnitureQualityConfig? furnitureQualityConfig = FurnitureConfig.Instance.GetFurnitureQualityConfig(qualityId);
		FColor color = FColor.FromHex(((furnitureQualityConfig != null) ? furnitureQualityConfig.GetValueOrDefault().ScrollItemColor : null) ?? "");
		base.GetSprite(1).SetColor(color);
	}

	// Token: 0x06003C20 RID: 15392 RVA: 0x00154FD0 File Offset: 0x001531D0
	private void OnToggleStateChange(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			Action<int> onItemSelectedDelegate = this.OnItemSelectedDelegate;
			if (onItemSelectedDelegate == null)
			{
				return;
			}
			onItemSelectedDelegate(base.GridIndex);
			return;
		}
		else
		{
			Action<int> onItemUnSelectedDelegate = this.OnItemUnSelectedDelegate;
			if (onItemUnSelectedDelegate == null)
			{
				return;
			}
			onItemUnSelectedDelegate(base.GridIndex);
			return;
		}
	}

	// Token: 0x06003C21 RID: 15393 RVA: 0x00155003 File Offset: 0x00153203
	private bool CanExecuteChangeInternal()
	{
		return this.CanToggleChangedDelegate == null || this.CanToggleChangedDelegate(base.GridIndex);
	}

	// Token: 0x06003C22 RID: 15394 RVA: 0x00155020 File Offset: 0x00153220
	private void OnPointUpCallBackInternal(EToggleState _)
	{
		Action<int> onPointUpCallBackDelegate = this.OnPointUpCallBackDelegate;
		if (onPointUpCallBackDelegate == null)
		{
			return;
		}
		onPointUpCallBackDelegate(base.GridIndex);
	}

	// Token: 0x06003C23 RID: 15395 RVA: 0x00155038 File Offset: 0x00153238
	private void OnPointerEnterInternal(EToggleState _)
	{
		Action<int> onPointerEnterDelegate = this.OnPointerEnterDelegate;
		if (onPointerEnterDelegate == null)
		{
			return;
		}
		onPointerEnterDelegate(base.GridIndex);
	}

	// Token: 0x0400306A RID: 12394
	private FurnitureScrollItemData Data;

	// Token: 0x0400306B RID: 12395
	public Action<int> OnItemSelectedDelegate;

	// Token: 0x0400306C RID: 12396
	public Action<int> OnItemUnSelectedDelegate;

	// Token: 0x0400306D RID: 12397
	public Func<int, bool> CanToggleChangedDelegate;

	// Token: 0x0400306E RID: 12398
	public Action<int> OnPointUpCallBackDelegate;

	// Token: 0x0400306F RID: 12399
	public Action<int> OnPointerEnterDelegate;
}
