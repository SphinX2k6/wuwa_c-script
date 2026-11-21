using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020007AE RID: 1966
[Nullable(new byte[]
{
	0,
	1
})]
public class BuildingAttributeItem : GridProxyAbstract<IAdditionData>
{
	// Token: 0x06005A08 RID: 23048 RVA: 0x001D3AE0 File Offset: 0x001D1CE0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06005A09 RID: 23049 RVA: 0x001D3B19 File Offset: 0x001D1D19
	[NullableContext(1)]
	public override void Refresh(IAdditionData data, bool isSelected, int gridIndex)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.TextId, Array.Empty<object>());
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(data.ValueText, true);
	}

	// Token: 0x02006AAE RID: 27310
	private static class EComponentDefine
	{
		// Token: 0x040231BA RID: 143802
		public const int Name = 0;

		// Token: 0x040231BB RID: 143803
		public const int Value = 1;
	}
}
