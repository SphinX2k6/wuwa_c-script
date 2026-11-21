using System;
using System.Runtime.CompilerServices;

// Token: 0x02000484 RID: 1156
[NullableContext(2)]
public interface IFurnitureGetWayButtonItemData
{
	// Token: 0x1700087D RID: 2173
	// (get) Token: 0x06003B8D RID: 15245
	// (set) Token: 0x06003B8E RID: 15246
	string NameTextId { get; set; }

	// Token: 0x1700087E RID: 2174
	// (get) Token: 0x06003B8F RID: 15247
	// (set) Token: 0x06003B90 RID: 15248
	[Nullable(new byte[]
	{
		2,
		1
	})]
	string[] NameTextParams { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x1700087F RID: 2175
	// (get) Token: 0x06003B91 RID: 15249
	// (set) Token: 0x06003B92 RID: 15250
	Action JumpFunction { get; set; }
}
