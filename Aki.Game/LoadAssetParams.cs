using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200033F RID: 831
public class LoadAssetParams<TD> where TD : UDataAsset
{
	// Token: 0x04002A3C RID: 10812
	[Nullable(2)]
	public UObject Context;

	// Token: 0x04002A3D RID: 10813
	public int Id;

	// Token: 0x04002A3E RID: 10814
	[Nullable(1)]
	public string Path = "";

	// Token: 0x04002A3F RID: 10815
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public TMap<TD, int> NativeContainer;

	// Token: 0x04002A40 RID: 10816
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<TD> Callback;

	// Token: 0x04002A41 RID: 10817
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<string> FailCallback;

	// Token: 0x04002A42 RID: 10818
	public int KscWorldHandle;
}
