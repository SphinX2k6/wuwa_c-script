using System;
using System.Runtime.CompilerServices;

// Token: 0x02000485 RID: 1157
[NullableContext(2)]
[Nullable(0)]
public class FurnitureGetWayButtonItemData : IFurnitureGetWayButtonItemData
{
	// Token: 0x17000880 RID: 2176
	// (get) Token: 0x06003B93 RID: 15251 RVA: 0x001531B1 File Offset: 0x001513B1
	// (set) Token: 0x06003B94 RID: 15252 RVA: 0x001531B9 File Offset: 0x001513B9
	public string NameTextId { get; set; }

	// Token: 0x17000881 RID: 2177
	// (get) Token: 0x06003B95 RID: 15253 RVA: 0x001531C2 File Offset: 0x001513C2
	// (set) Token: 0x06003B96 RID: 15254 RVA: 0x001531CA File Offset: 0x001513CA
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] NameTextParams { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17000882 RID: 2178
	// (get) Token: 0x06003B97 RID: 15255 RVA: 0x001531D3 File Offset: 0x001513D3
	// (set) Token: 0x06003B98 RID: 15256 RVA: 0x001531DB File Offset: 0x001513DB
	public Action JumpFunction { get; set; }
}
