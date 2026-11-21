using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;

// Token: 0x0200147D RID: 5245
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SettingGridBase : GridProxyAbstract<InventoryDefine.IManageConfigSettingGridData>
{
	// Token: 0x0600D223 RID: 53795 RVA: 0x003E5686 File Offset: 0x003E3886
	public override void Refresh(InventoryDefine.IManageConfigSettingGridData data, bool isSelected, int gridIndex)
	{
	}

	// Token: 0x0600D224 RID: 53796 RVA: 0x003E5688 File Offset: 0x003E3888
	public override object GetKey(InventoryDefine.IManageConfigSettingGridData data, int displayIndex)
	{
		return base.GridIndex;
	}

	// Token: 0x0400767F RID: 30335
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<InventoryDefine.IManageConfigSettingGridData, bool> CallbackOnClicked;
}
