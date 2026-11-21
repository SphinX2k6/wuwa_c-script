using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200048A RID: 1162
[NullableContext(2)]
public interface IFurnitureGetWayViewData
{
	// Token: 0x17000883 RID: 2179
	// (get) Token: 0x06003BAA RID: 15274
	// (set) Token: 0x06003BAB RID: 15275
	Furniture FurnitureConfig { get; set; }

	// Token: 0x17000884 RID: 2180
	// (get) Token: 0x06003BAC RID: 15276
	// (set) Token: 0x06003BAD RID: 15277
	EFurnitureLockReason LockReason { get; set; }

	// Token: 0x17000885 RID: 2181
	// (get) Token: 0x06003BAE RID: 15278
	// (set) Token: 0x06003BAF RID: 15279
	[Nullable(1)]
	string LockReasonTextId { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000886 RID: 2182
	// (get) Token: 0x06003BB0 RID: 15280
	// (set) Token: 0x06003BB1 RID: 15281
	[Nullable(new byte[]
	{
		2,
		1
	})]
	string[] LockReasonTextParams { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17000887 RID: 2183
	// (get) Token: 0x06003BB2 RID: 15282
	// (set) Token: 0x06003BB3 RID: 15283
	Action JumpFunction { get; set; }

	// Token: 0x17000888 RID: 2184
	// (get) Token: 0x06003BB4 RID: 15284
	// (set) Token: 0x06003BB5 RID: 15285
	Action ConfirmFunction { get; set; }
}
