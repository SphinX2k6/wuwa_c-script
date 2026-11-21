using System;
using System.Runtime.CompilerServices;

// Token: 0x020021A7 RID: 8615
[NullableContext(2)]
[Nullable(0)]
public class TutorialItemData
{
	// Token: 0x0400B3C0 RID: 46016
	public bool IsTypeTitle;

	// Token: 0x0400B3C1 RID: 46017
	public string TextId;

	// Token: 0x0400B3C2 RID: 46018
	public string Text;

	// Token: 0x0400B3C3 RID: 46019
	public TutorialSaveData SavedData;

	// Token: 0x0400B3C4 RID: 46020
	public bool? Selected = new bool?(false);

	// Token: 0x0400B3C5 RID: 46021
	public ETutorialType? OwnerType;
}
