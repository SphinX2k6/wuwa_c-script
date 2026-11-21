using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001CD3 RID: 7379
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerSettleUpgradeItem : GridProxyAbstract<RoleTowerFeatureData>
{
	// Token: 0x06012456 RID: 74838 RVA: 0x00563195 File Offset: 0x00561395
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x06012457 RID: 74839 RVA: 0x005631B8 File Offset: 0x005613B8
	public override void Refresh(RoleTowerFeatureData data, bool isSelected, int gridIndex)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Desc, data.DescParams);
	}

	// Token: 0x06012458 RID: 74840 RVA: 0x005631D7 File Offset: 0x005613D7
	public override object GetKey(RoleTowerFeatureData data, int displayIndex)
	{
		return displayIndex;
	}

	// Token: 0x04009F86 RID: 40838
	private const int TxtDesc = 0;
}
