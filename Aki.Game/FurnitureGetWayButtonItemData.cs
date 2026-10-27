using System;
using System.Runtime.CompilerServices;

// Token: 0x02000FD0 RID: 4048
[NullableContext(2)]
[Nullable(0)]
public class FurnitureGetWayButtonItemData : IFurnitureGetWayButtonItemData
{
	// Token: 0x1700085E RID: 2142
	// (get) Token: 0x060067FB RID: 26619 RVA: 0x0014A8ED File Offset: 0x00148AED
	// (set) Token: 0x060067FC RID: 26620 RVA: 0x0014A8F5 File Offset: 0x00148AF5
	public string NameTextId { get; set; }

	// Token: 0x1700085F RID: 2143
	// (get) Token: 0x060067FD RID: 26621 RVA: 0x0014A8FE File Offset: 0x00148AFE
	// (set) Token: 0x060067FE RID: 26622 RVA: 0x0014A906 File Offset: 0x00148B06
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

	// Token: 0x17000860 RID: 2144
	// (get) Token: 0x060067FF RID: 26623 RVA: 0x0014A90F File Offset: 0x00148B0F
	// (set) Token: 0x06006800 RID: 26624 RVA: 0x0014A917 File Offset: 0x00148B17
	public Action JumpFunction { get; set; }
}
