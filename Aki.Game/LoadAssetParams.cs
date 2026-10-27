using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000E8A RID: 3722
public class LoadAssetParams<TD> where TD : UDataAsset
{
	// Token: 0x040029A1 RID: 10657
	[Nullable(2)]
	public UObject Context;

	// Token: 0x040029A2 RID: 10658
	public int Id;

	// Token: 0x040029A3 RID: 10659
	[Nullable(1)]
	public string Path = "";

	// Token: 0x040029A4 RID: 10660
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public TMap<TD, int> NativeContainer;

	// Token: 0x040029A5 RID: 10661
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<TD> Callback;

	// Token: 0x040029A6 RID: 10662
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<string> FailCallback;

	// Token: 0x040029A7 RID: 10663
	public int KscWorldHandle;
}
