using System;
using System.Runtime.CompilerServices;

// Token: 0x02002C2C RID: 11308
[NullableContext(2)]
[Nullable(0)]
public class TutorialItemData
{
	// Token: 0x0400AFBB RID: 44987
	public bool IsTypeTitle;

	// Token: 0x0400AFBC RID: 44988
	public string TextId;

	// Token: 0x0400AFBD RID: 44989
	public string Text;

	// Token: 0x0400AFBE RID: 44990
	public TutorialSaveData SavedData;

	// Token: 0x0400AFBF RID: 44991
	public bool? Selected = new bool?(false);

	// Token: 0x0400AFC0 RID: 44992
	public ETutorialType? OwnerType;
}
