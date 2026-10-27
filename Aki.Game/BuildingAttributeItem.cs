using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020012FA RID: 4858
[Nullable(new byte[]
{
	0,
	1
})]
public class BuildingAttributeItem : GridProxyAbstract<IAdditionData>
{
	// Token: 0x0600866D RID: 34413 RVA: 0x001CAC74 File Offset: 0x001C8E74
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600866E RID: 34414 RVA: 0x001CACAD File Offset: 0x001C8EAD
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

	// Token: 0x02007924 RID: 31012
	private static class EComponentDefine
	{
		// Token: 0x04027E8D RID: 163469
		public const int Name = 0;

		// Token: 0x04027E8E RID: 163470
		public const int Value = 1;
	}
}
