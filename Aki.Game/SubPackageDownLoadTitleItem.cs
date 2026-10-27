using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002AA5 RID: 10917
internal class SubPackageDownLoadTitleItem : UiPanelBase
{
	// Token: 0x06016BB9 RID: 93113 RVA: 0x005C3CBE File Offset: 0x005C1EBE
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06016BBA RID: 93114 RVA: 0x005C3CF8 File Offset: 0x005C1EF8
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
