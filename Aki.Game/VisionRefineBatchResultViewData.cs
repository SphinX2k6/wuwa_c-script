using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02000C2E RID: 3118
[NullableContext(2)]
[Nullable(0)]
public class VisionRefineBatchResultViewData
{
	// Token: 0x04004FCE RID: 20430
	public Func<UniTask> OnClickConfirm;

	// Token: 0x04004FCF RID: 20431
	public Func<UniTask> OnClickCancel;

	// Token: 0x04004FD0 RID: 20432
	[Nullable(1)]
	public VisionRefineAttributeItemData[] LeftAttrList = new VisionRefineAttributeItemData[0];

	// Token: 0x04004FD1 RID: 20433
	[Nullable(1)]
	public VisionRefineAttributeItemData[] RightAttrList = new VisionRefineAttributeItemData[0];

	// Token: 0x04004FD2 RID: 20434
	public int? UniqueId;

	// Token: 0x04004FD3 RID: 20435
	public string ConfirmTipTextId;

	// Token: 0x04004FD4 RID: 20436
	public bool HasRecommendData;
}
