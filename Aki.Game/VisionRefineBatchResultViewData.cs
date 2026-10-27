using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02001775 RID: 6005
[NullableContext(2)]
[Nullable(0)]
public class VisionRefineBatchResultViewData
{
	// Token: 0x04004F24 RID: 20260
	public Func<UniTask> OnClickConfirm;

	// Token: 0x04004F25 RID: 20261
	public Func<UniTask> OnClickCancel;

	// Token: 0x04004F26 RID: 20262
	[Nullable(1)]
	public VisionRefineAttributeItemData[] LeftAttrList = new VisionRefineAttributeItemData[0];

	// Token: 0x04004F27 RID: 20263
	[Nullable(1)]
	public VisionRefineAttributeItemData[] RightAttrList = new VisionRefineAttributeItemData[0];

	// Token: 0x04004F28 RID: 20264
	public int? UniqueId;

	// Token: 0x04004F29 RID: 20265
	public string ConfirmTipTextId;

	// Token: 0x04004F2A RID: 20266
	public bool HasRecommendData;
}
