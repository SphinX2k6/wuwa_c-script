using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001FBC RID: 8124
public class SettingGridLayout : UiPanelBase
{
	// Token: 0x0600FE00 RID: 65024 RVA: 0x003D9CC1 File Offset: 0x003D7EC1
	public SettingGridLayout(int ruleId, InventoryDefine.ESettingGridType gridType)
	{
		this.RuleId = ruleId;
		this.GridType = new InventoryDefine.ESettingGridType?(gridType);
	}

	// Token: 0x0600FE01 RID: 65025 RVA: 0x003D9CDC File Offset: 0x003D7EDC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIGridLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600FE02 RID: 65026 RVA: 0x003D9D48 File Offset: 0x003D7F48
	protected override UniTask OnBeforeStartAsync()
	{
		SettingGridLayout.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SettingGridLayout.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FE03 RID: 65027 RVA: 0x003D9D8C File Offset: 0x003D7F8C
	[NullableContext(1)]
	public UniTask RefreshAsync(InventoryDefine.IManageConfigSettingGridData[] data)
	{
		SettingGridLayout.<RefreshAsync>d__8 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.data = data;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<SettingGridLayout.<RefreshAsync>d__8>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FE04 RID: 65028 RVA: 0x003D9DD8 File Offset: 0x003D7FD8
	[NullableContext(1)]
	private SettingGridBase OnCreateGrid()
	{
		SettingGridBase settingGridBase = new SettingGridSmall();
		if (this.GridType.GetValueOrDefault() != InventoryDefine.ESettingGridType.Small)
		{
			settingGridBase = new SettingGridBig();
		}
		settingGridBase.CallbackOnClicked = this.CallbackOnClicked;
		return settingGridBase;
	}

	// Token: 0x0400759E RID: 30110
	private readonly int RuleId;

	// Token: 0x0400759F RID: 30111
	private readonly InventoryDefine.ESettingGridType? GridType;

	// Token: 0x040075A0 RID: 30112
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SettingGridBase, InventoryDefine.IManageConfigSettingGridData> GridLayout;

	// Token: 0x040075A1 RID: 30113
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<InventoryDefine.IManageConfigSettingGridData, bool> CallbackOnClicked;

	// Token: 0x020085C3 RID: 34243
	private enum EComponentLayout
	{
		// Token: 0x0402B8BC RID: 178364
		LayoutRoot,
		// Token: 0x0402B8BD RID: 178365
		PanelItem
	}
}
