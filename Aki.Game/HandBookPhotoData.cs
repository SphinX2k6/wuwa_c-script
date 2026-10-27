using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001DF4 RID: 7668
public class HandBookPhotoData
{
	// Token: 0x04006C3B RID: 27707
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> TextureList;

	// Token: 0x04006C3C RID: 27708
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> TypeText;

	// Token: 0x04006C3D RID: 27709
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> NameText;

	// Token: 0x04006C3E RID: 27710
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> DescrtptionText;

	// Token: 0x04006C3F RID: 27711
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> DateText;

	// Token: 0x04006C40 RID: 27712
	public int Index;

	// Token: 0x04006C41 RID: 27713
	public EHandBookTabType HandBookType;

	// Token: 0x04006C42 RID: 27714
	[Nullable(2)]
	public int[] ConfigId;
}
