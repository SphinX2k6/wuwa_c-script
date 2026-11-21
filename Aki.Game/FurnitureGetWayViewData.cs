using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200048B RID: 1163
[NullableContext(2)]
[Nullable(0)]
public class FurnitureGetWayViewData : IFurnitureGetWayViewData
{
	// Token: 0x17000889 RID: 2185
	// (get) Token: 0x06003BB6 RID: 15286 RVA: 0x0015386E File Offset: 0x00151A6E
	// (set) Token: 0x06003BB7 RID: 15287 RVA: 0x00153876 File Offset: 0x00151A76
	public Furniture FurnitureConfig { get; set; }

	// Token: 0x1700088A RID: 2186
	// (get) Token: 0x06003BB8 RID: 15288 RVA: 0x0015387F File Offset: 0x00151A7F
	// (set) Token: 0x06003BB9 RID: 15289 RVA: 0x00153887 File Offset: 0x00151A87
	public EFurnitureLockReason LockReason { get; set; }

	// Token: 0x1700088B RID: 2187
	// (get) Token: 0x06003BBA RID: 15290 RVA: 0x00153890 File Offset: 0x00151A90
	// (set) Token: 0x06003BBB RID: 15291 RVA: 0x00153898 File Offset: 0x00151A98
	[Nullable(1)]
	public string LockReasonTextId { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x1700088C RID: 2188
	// (get) Token: 0x06003BBC RID: 15292 RVA: 0x001538A1 File Offset: 0x00151AA1
	// (set) Token: 0x06003BBD RID: 15293 RVA: 0x001538A9 File Offset: 0x00151AA9
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

	// Token: 0x1700088D RID: 2189
	// (get) Token: 0x06003BBE RID: 15294 RVA: 0x001538B2 File Offset: 0x00151AB2
	// (set) Token: 0x06003BBF RID: 15295 RVA: 0x001538BA File Offset: 0x00151ABA
	public Action JumpFunction { get; set; }

	// Token: 0x1700088E RID: 2190
	// (get) Token: 0x06003BC0 RID: 15296 RVA: 0x001538C3 File Offset: 0x00151AC3
	// (set) Token: 0x06003BC1 RID: 15297 RVA: 0x001538CB File Offset: 0x00151ACB
	public Action ConfirmFunction { get; set; }
}
