using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;

// Token: 0x02001FBB RID: 8123
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SettingGridBase : GridProxyAbstract<InventoryDefine.IManageConfigSettingGridData>
{
	// Token: 0x0600FDFD RID: 65021 RVA: 0x003D9CAA File Offset: 0x003D7EAA
	public override void Refresh(InventoryDefine.IManageConfigSettingGridData data, bool isSelected, int gridIndex)
	{
	}

	// Token: 0x0600FDFE RID: 65022 RVA: 0x003D9CAC File Offset: 0x003D7EAC
	public override object GetKey(InventoryDefine.IManageConfigSettingGridData data, int displayIndex)
	{
		return base.GridIndex;
	}

	// Token: 0x0400759D RID: 30109
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<InventoryDefine.IManageConfigSettingGridData, bool> CallbackOnClicked;
}
