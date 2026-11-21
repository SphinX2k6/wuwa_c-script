using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001EE1 RID: 7905
[NullableContext(1)]
[Nullable(0)]
public class SdkLoginViewData
{
	// Token: 0x06013880 RID: 80000 RVA: 0x005B1842 File Offset: 0x005AFA42
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

	// Token: 0x0400A6F0 RID: 42736
	public string DescTextId = "";

	// Token: 0x0400A6F1 RID: 42737
	public Action EnterCallback = delegate()
	{
	};

	// Token: 0x0400A6F2 RID: 42738
	public Action CancelCallback = delegate()
	{
	};

	// Token: 0x0400A6F3 RID: 42739
	public List<SdkLoginViewLayoutData> LayoutData = new List<SdkLoginViewLayoutData>();
}
