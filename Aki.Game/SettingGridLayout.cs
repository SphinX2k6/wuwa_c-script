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

// Token: 0x0200147E RID: 5246
public class SettingGridLayout : UiPanelBase
{
	// Token: 0x0600D226 RID: 53798 RVA: 0x003E569D File Offset: 0x003E389D
	public SettingGridLayout(int ruleId, InventoryDefine.ESettingGridType gridType)
	{
		this.RuleId = ruleId;
		this.GridType = new InventoryDefine.ESettingGridType?(gridType);
	}

	// Token: 0x0600D227 RID: 53799 RVA: 0x003E56B8 File Offset: 0x003E38B8
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

	// Token: 0x0600D228 RID: 53800 RVA: 0x003E5724 File Offset: 0x003E3924
	protected override UniTask OnBeforeStartAsync()
	{
		SettingGridLayout.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SettingGridLayout.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D229 RID: 53801 RVA: 0x003E5768 File Offset: 0x003E3968
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

	// Token: 0x0600D22A RID: 53802 RVA: 0x003E57B4 File Offset: 0x003E39B4
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

	// Token: 0x04007680 RID: 30336
	private readonly int RuleId;

	// Token: 0x04007681 RID: 30337
	private readonly InventoryDefine.ESettingGridType? GridType;

	// Token: 0x04007682 RID: 30338
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SettingGridBase, InventoryDefine.IManageConfigSettingGridData> GridLayout;

	// Token: 0x04007683 RID: 30339
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<InventoryDefine.IManageConfigSettingGridData, bool> CallbackOnClicked;

	// Token: 0x02007745 RID: 30533
	private enum EComponentLayout
	{
		// Token: 0x04026BC4 RID: 158660
		LayoutRoot,
		// Token: 0x04026BC5 RID: 158661
		PanelItem
	}
}
