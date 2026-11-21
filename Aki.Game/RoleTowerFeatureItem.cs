using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001CE5 RID: 7397
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerFeatureItem : GridProxyAbstract<RoleTowerFeatureData>
{
	// Token: 0x06012507 RID: 75015 RVA: 0x00567192 File Offset: 0x00565392
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x06012508 RID: 75016 RVA: 0x005671B5 File Offset: 0x005653B5
	[NullableContext(1)]
	public override void Refresh(RoleTowerFeatureData data, bool isSelected, int gridIndex)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Desc, data.DescParams);
	}

	// Token: 0x02007FED RID: 32749
	private static class EChildType
	{
		// Token: 0x0402963B RID: 169531
		public const int TxtDesc = 0;
	}
}
