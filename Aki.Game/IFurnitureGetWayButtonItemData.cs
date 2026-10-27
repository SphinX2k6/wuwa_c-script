using System;
using System.Runtime.CompilerServices;

// Token: 0x02000FCF RID: 4047
[NullableContext(2)]
public interface IFurnitureGetWayButtonItemData
{
	// Token: 0x1700085B RID: 2139
	// (get) Token: 0x060067F5 RID: 26613
	// (set) Token: 0x060067F6 RID: 26614
	string NameTextId { get; set; }

	// Token: 0x1700085C RID: 2140
	// (get) Token: 0x060067F7 RID: 26615
	// (set) Token: 0x060067F8 RID: 26616
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

	// Token: 0x1700085D RID: 2141
	// (get) Token: 0x060067F9 RID: 26617
	// (set) Token: 0x060067FA RID: 26618
	Action JumpFunction { get; set; }
}
