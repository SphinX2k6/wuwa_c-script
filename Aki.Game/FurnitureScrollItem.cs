using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000FE6 RID: 4070
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FurnitureScrollItem : GridProxyAbstract<FurnitureScrollItemData>
{
	// Token: 0x0600687B RID: 26747 RVA: 0x0014C164 File Offset: 0x0014A364
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

	// Token: 0x0600687C RID: 26748 RVA: 0x0014C2C4 File Offset: 0x0014A4C4
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChangeInternal));
		extendToggle.OnPointUpCallBack.Bind(new Action<EToggleState>(this.OnPointUpCallBackInternal));
		extendToggle.OnPointEnterCallBack.Bind(new Action<EToggleState>(this.OnPointerEnterInternal));
	}

	// Token: 0x0600687D RID: 26749 RVA: 0x0014C31C File Offset: 0x0014A51C
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

	// Token: 0x0600687E RID: 26750 RVA: 0x0014C370 File Offset: 0x0014A570
	public void RefreshItemToggle(bool bToEndFrame = false)
	{
		FurnitureScrollItemData data = this.Data;
		EToggleState state = (data != null && data.IsSelected) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleStateForce(state, false, false, bToEndFrame);
	}

	// Token: 0x0600687F RID: 26751 RVA: 0x0014C3A8 File Offset: 0x0014A5A8
	public void RefreshCheckItem()
	{
		FurnitureScrollItemData data = this.Data;
		bool uiactive = data != null && data.IsCheck;
		base.GetItem(4).SetUIActive(uiactive);
	}

	// Token: 0x06006880 RID: 26752 RVA: 0x0014C3D8 File Offset: 0x0014A5D8
	public void RefreshFurnitureIcon()
	{
		FurnitureScrollItemData data = this.Data;
		Furniture? furniture = (data != null) ? new Furniture?(data.FurnitureConfig) : null;
		base.SetTextureByPath(((furniture != null) ? furniture.GetValueOrDefault().Icon : null) ?? "", base.GetTexture(2), null, null);
	}

	// Token: 0x06006881 RID: 26753 RVA: 0x0014C440 File Offset: 0x0014A640
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

	// Token: 0x06006882 RID: 26754 RVA: 0x0014C4E0 File Offset: 0x0014A6E0
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

	// Token: 0x06006883 RID: 26755 RVA: 0x0014C564 File Offset: 0x0014A764
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

	// Token: 0x06006884 RID: 26756 RVA: 0x0014C5F4 File Offset: 0x0014A7F4
	public void RefreshAtmosphere()
	{
		FurnitureScrollItemData data = this.Data;
		Furniture? furniture = (data != null) ? new Furniture?(data.FurnitureConfig) : null;
		base.GetText(9).SetText(((furniture != null) ? furniture.GetValueOrDefault().Atmosphere.ToString() : null) ?? "", true);
	}

	// Token: 0x06006885 RID: 26757 RVA: 0x0014C65B File Offset: 0x0014A85B
	public void RefreshLock()
	{
		UUIItem item = base.GetItem(10);
		FurnitureScrollItemData data = this.Data;
		item.SetUIActive(data != null && data.IsLock);
	}

	// Token: 0x06006886 RID: 26758 RVA: 0x0014C67C File Offset: 0x0014A87C
	public void RefreshRedDot()
	{
		UUIItem item = base.GetItem(11);
		FurnitureScrollItemData data = this.Data;
		item.SetUIActive(data != null && data.RedDotShowState);
	}

	// Token: 0x06006887 RID: 26759 RVA: 0x0014C6A0 File Offset: 0x0014A8A0
	public void RefreshQuality()
	{
		FurnitureScrollItemData data = this.Data;
		int qualityId = (data != null) ? data.FurnitureConfig.QualityId : 0;
		FurnitureQualityConfig? furnitureQualityConfig = FurnitureConfig.Instance.GetFurnitureQualityConfig(qualityId);
		FColor color = FColor.FromHex(((furnitureQualityConfig != null) ? furnitureQualityConfig.GetValueOrDefault().ScrollItemColor : null) ?? "");
		base.GetSprite(1).SetColor(color);
	}

	// Token: 0x06006888 RID: 26760 RVA: 0x0014C70C File Offset: 0x0014A90C
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

	// Token: 0x06006889 RID: 26761 RVA: 0x0014C73F File Offset: 0x0014A93F
	private bool CanExecuteChangeInternal()
	{
		return this.CanToggleChangedDelegate == null || this.CanToggleChangedDelegate(base.GridIndex);
	}

	// Token: 0x0600688A RID: 26762 RVA: 0x0014C75C File Offset: 0x0014A95C
	private void OnPointUpCallBackInternal(EToggleState _)
	{
		Action<int> onPointUpCallBackDelegate = this.OnPointUpCallBackDelegate;
		if (onPointUpCallBackDelegate == null)
		{
			return;
		}
		onPointUpCallBackDelegate(base.GridIndex);
	}

	// Token: 0x0600688B RID: 26763 RVA: 0x0014C774 File Offset: 0x0014A974
	private void OnPointerEnterInternal(EToggleState _)
	{
		Action<int> onPointerEnterDelegate = this.OnPointerEnterDelegate;
		if (onPointerEnterDelegate == null)
		{
			return;
		}
		onPointerEnterDelegate(base.GridIndex);
	}

	// Token: 0x04002FD1 RID: 12241
	private FurnitureScrollItemData Data;

	// Token: 0x04002FD2 RID: 12242
	public Action<int> OnItemSelectedDelegate;

	// Token: 0x04002FD3 RID: 12243
	public Action<int> OnItemUnSelectedDelegate;

	// Token: 0x04002FD4 RID: 12244
	public Func<int, bool> CanToggleChangedDelegate;

	// Token: 0x04002FD5 RID: 12245
	public Action<int> OnPointUpCallBackDelegate;

	// Token: 0x04002FD6 RID: 12246
	public Action<int> OnPointerEnterDelegate;
}
