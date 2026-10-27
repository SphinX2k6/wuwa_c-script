using System;
using System.Runtime.CompilerServices;

// Token: 0x02001770 RID: 6000
[NullableContext(2)]
[Nullable(0)]
public class VisionRefineRefineTabData
{
	// Token: 0x04004F0D RID: 20237
	public bool IsChosen;

	// Token: 0x04004F0E RID: 20238
	public EVisionRefineRefineType RefineType;

	// Token: 0x04004F0F RID: 20239
	public string TabTextId;

	// Token: 0x04004F10 RID: 20240
	public Action OnClick;

	// Token: 0x04004F11 RID: 20241
	public Func<EVisionRefineRefineType, bool> CanChangeExecute;
}
