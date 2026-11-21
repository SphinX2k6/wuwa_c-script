using System;
using Aki.Config;

// Token: 0x0200043A RID: 1082
public class FurnitureScrollItemData : IFurnitureScrollItemData
{
	// Token: 0x170007FE RID: 2046
	// (get) Token: 0x06003984 RID: 14724 RVA: 0x0014C6A8 File Offset: 0x0014A8A8
	// (set) Token: 0x06003985 RID: 14725 RVA: 0x0014C6B0 File Offset: 0x0014A8B0
	public Furniture FurnitureConfig { get; set; }

	// Token: 0x170007FF RID: 2047
	// (get) Token: 0x06003986 RID: 14726 RVA: 0x0014C6B9 File Offset: 0x0014A8B9
	// (set) Token: 0x06003987 RID: 14727 RVA: 0x0014C6C1 File Offset: 0x0014A8C1
	public bool RedDotShowState { get; set; }

	// Token: 0x17000800 RID: 2048
	// (get) Token: 0x06003988 RID: 14728 RVA: 0x0014C6CA File Offset: 0x0014A8CA
	// (set) Token: 0x06003989 RID: 14729 RVA: 0x0014C6D2 File Offset: 0x0014A8D2
	public bool IsSelected { get; set; }

	// Token: 0x17000801 RID: 2049
	// (get) Token: 0x0600398A RID: 14730 RVA: 0x0014C6DB File Offset: 0x0014A8DB
	// (set) Token: 0x0600398B RID: 14731 RVA: 0x0014C6E3 File Offset: 0x0014A8E3
	public int LeftCount { get; set; }

	// Token: 0x17000802 RID: 2050
	// (get) Token: 0x0600398C RID: 14732 RVA: 0x0014C6EC File Offset: 0x0014A8EC
	// (set) Token: 0x0600398D RID: 14733 RVA: 0x0014C6F4 File Offset: 0x0014A8F4
	public bool IsLock { get; set; }

	// Token: 0x17000803 RID: 2051
	// (get) Token: 0x0600398E RID: 14734 RVA: 0x0014C6FD File Offset: 0x0014A8FD
	// (set) Token: 0x0600398F RID: 14735 RVA: 0x0014C705 File Offset: 0x0014A905
	public bool IsCheck { get; set; }
}
