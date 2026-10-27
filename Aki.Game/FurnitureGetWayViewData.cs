using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000FD6 RID: 4054
[NullableContext(2)]
[Nullable(0)]
public class FurnitureGetWayViewData : IFurnitureGetWayViewData
{
	// Token: 0x17000867 RID: 2151
	// (get) Token: 0x0600681E RID: 26654 RVA: 0x0014AFAA File Offset: 0x001491AA
	// (set) Token: 0x0600681F RID: 26655 RVA: 0x0014AFB2 File Offset: 0x001491B2
	public Furniture FurnitureConfig { get; set; }

	// Token: 0x17000868 RID: 2152
	// (get) Token: 0x06006820 RID: 26656 RVA: 0x0014AFBB File Offset: 0x001491BB
	// (set) Token: 0x06006821 RID: 26657 RVA: 0x0014AFC3 File Offset: 0x001491C3
	public EFurnitureLockReason LockReason { get; set; }

	// Token: 0x17000869 RID: 2153
	// (get) Token: 0x06006822 RID: 26658 RVA: 0x0014AFCC File Offset: 0x001491CC
	// (set) Token: 0x06006823 RID: 26659 RVA: 0x0014AFD4 File Offset: 0x001491D4
	[Nullable(1)]
	public string LockReasonTextId { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x1700086A RID: 2154
	// (get) Token: 0x06006824 RID: 26660 RVA: 0x0014AFDD File Offset: 0x001491DD
	// (set) Token: 0x06006825 RID: 26661 RVA: 0x0014AFE5 File Offset: 0x001491E5
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] LockReasonTextParams { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x1700086B RID: 2155
	// (get) Token: 0x06006826 RID: 26662 RVA: 0x0014AFEE File Offset: 0x001491EE
	// (set) Token: 0x06006827 RID: 26663 RVA: 0x0014AFF6 File Offset: 0x001491F6
	public Action JumpFunction { get; set; }

	// Token: 0x1700086C RID: 2156
	// (get) Token: 0x06006828 RID: 26664 RVA: 0x0014AFFF File Offset: 0x001491FF
	// (set) Token: 0x06006829 RID: 26665 RVA: 0x0014B007 File Offset: 0x00149207
	public Action ConfirmFunction { get; set; }
}
