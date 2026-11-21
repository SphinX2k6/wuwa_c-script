using System;
using System.Runtime.CompilerServices;

// Token: 0x02000C29 RID: 3113
[NullableContext(2)]
[Nullable(0)]
public class VisionRefineRefineTabData
{
	// Token: 0x04004FB7 RID: 20407
	public bool IsChosen;

	// Token: 0x04004FB8 RID: 20408
	public EVisionRefineRefineType RefineType;

	// Token: 0x04004FB9 RID: 20409
	public string TabTextId;

	// Token: 0x04004FBA RID: 20410
	public Action OnClick;

	// Token: 0x04004FBB RID: 20411
	public Func<EVisionRefineRefineType, bool> CanChangeExecute;
}
