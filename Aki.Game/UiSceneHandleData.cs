using System;
using System.Runtime.CompilerServices;

// Token: 0x020021BB RID: 8635
public class UiSceneHandleData
{
	// Token: 0x06015468 RID: 87144 RVA: 0x0062F3FC File Offset: 0x0062D5FC
	public UiSceneHandleData()
	{
		this.CustomPromise = new CustomPromise<bool>();
	}

	// Token: 0x0400B43F RID: 46143
	[Nullable(1)]
	public CustomPromise<bool> CustomPromise;
}
