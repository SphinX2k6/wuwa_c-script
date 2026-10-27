using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002966 RID: 10598
[NullableContext(1)]
[Nullable(0)]
public class SdkLoginViewData
{
	// Token: 0x06015E7C RID: 89724 RVA: 0x0058683E File Offset: 0x00584A3E
	public static SdkLoginViewData Create(string descTextId, Action enterCallback, Action cancelCallback, List<SdkLoginViewLayoutData> layoutData)
	{
		return new SdkLoginViewData
		{
			DescTextId = descTextId,
			EnterCallback = enterCallback,
			CancelCallback = cancelCallback,
			LayoutData = layoutData
		};
	}

	// Token: 0x0400A306 RID: 41734
	public string DescTextId = "";

	// Token: 0x0400A307 RID: 41735
	public Action EnterCallback = delegate()
	{
	};

	// Token: 0x0400A308 RID: 41736
	public Action CancelCallback = delegate()
	{
	};

	// Token: 0x0400A309 RID: 41737
	public List<SdkLoginViewLayoutData> LayoutData = new List<SdkLoginViewLayoutData>();
}
