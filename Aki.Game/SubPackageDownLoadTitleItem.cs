using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002021 RID: 8225
internal class SubPackageDownLoadTitleItem : UiPanelBase
{
	// Token: 0x060145E8 RID: 83432 RVA: 0x005F075E File Offset: 0x005EE95E
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x060145E9 RID: 83433 RVA: 0x005F0798 File Offset: 0x005EE998
	public void RefreshItem(ESubPackageDownLoadVersionType type)
	{
		if (type == ESubPackageDownLoadVersionType.Key)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "SubPackageDownLoadTitle_Must", Array.Empty<object>());
		}
		if (type == ESubPackageDownLoadVersionType.Optional)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "SubPackageDownLoadTitle_Optional", Array.Empty<object>());
		}
		if (type == ESubPackageDownLoadVersionType.Expand)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "SubPackageDownLoadTitle_Expand", Array.Empty<object>());
		}
	}
}
