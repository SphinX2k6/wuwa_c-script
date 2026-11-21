using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020012B6 RID: 4790
public class HandBookPhotoData
{
	// Token: 0x04006D1C RID: 27932
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> TextureList;

	// Token: 0x04006D1D RID: 27933
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> TypeText;

	// Token: 0x04006D1E RID: 27934
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> NameText;

	// Token: 0x04006D1F RID: 27935
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> DescrtptionText;

	// Token: 0x04006D20 RID: 27936
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> DateText;

	// Token: 0x04006D21 RID: 27937
	public int Index;

	// Token: 0x04006D22 RID: 27938
	public EHandBookTabType HandBookType;

	// Token: 0x04006D23 RID: 27939
	[Nullable(2)]
	public int[] ConfigId;
}
