using System;
using System.Runtime.CompilerServices;

// Token: 0x02001515 RID: 5397
[NullableContext(2)]
[Nullable(0)]
[RequiredMember]
public class Spring25LetterListTabData
{
	// Token: 0x06009A06 RID: 39430 RVA: 0x00215443 File Offset: 0x00213643
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public Spring25LetterListTabData()
	{
	}

	// Token: 0x040043B4 RID: 17332
	[RequiredMember]
	public int SignId;

	// Token: 0x040043B5 RID: 17333
	[RequiredMember]
	public bool IsChosen;

	// Token: 0x040043B6 RID: 17334
	[RequiredMember]
	public bool IsNew;

	// Token: 0x040043B7 RID: 17335
	public string TexturePath;

	// Token: 0x040043B8 RID: 17336
	public string DescriptionTextId;
}
