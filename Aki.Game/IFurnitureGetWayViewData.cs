using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000FD5 RID: 4053
[NullableContext(2)]
public interface IFurnitureGetWayViewData
{
	// Token: 0x17000861 RID: 2145
	// (get) Token: 0x06006812 RID: 26642
	// (set) Token: 0x06006813 RID: 26643
	Furniture FurnitureConfig { get; set; }

	// Token: 0x17000862 RID: 2146
	// (get) Token: 0x06006814 RID: 26644
	// (set) Token: 0x06006815 RID: 26645
	EFurnitureLockReason LockReason { get; set; }

	// Token: 0x17000863 RID: 2147
	// (get) Token: 0x06006816 RID: 26646
	// (set) Token: 0x06006817 RID: 26647
	[Nullable(1)]
	string LockReasonTextId { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000864 RID: 2148
	// (get) Token: 0x06006818 RID: 26648
	// (set) Token: 0x06006819 RID: 26649
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

	// Token: 0x17000865 RID: 2149
	// (get) Token: 0x0600681A RID: 26650
	// (set) Token: 0x0600681B RID: 26651
	Action JumpFunction { get; set; }

	// Token: 0x17000866 RID: 2150
	// (get) Token: 0x0600681C RID: 26652
	// (set) Token: 0x0600681D RID: 26653
	Action ConfirmFunction { get; set; }
}
