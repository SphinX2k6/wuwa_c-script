using System;
using System.Runtime.CompilerServices;

// Token: 0x020009CD RID: 2509
[NullableContext(2)]
[Nullable(0)]
[RequiredMember]
public class Spring25LetterListTabData
{
	// Token: 0x06006DE4 RID: 28132 RVA: 0x0021F1DF File Offset: 0x0021D3DF
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public Spring25LetterListTabData()
	{
	}

	// Token: 0x0400445A RID: 17498
	[RequiredMember]
	public int SignId;

	// Token: 0x0400445B RID: 17499
	[RequiredMember]
	public bool IsChosen;

	// Token: 0x0400445C RID: 17500
	[RequiredMember]
	public bool IsNew;

	// Token: 0x0400445D RID: 17501
	public string TexturePath;

	// Token: 0x0400445E RID: 17502
	public string DescriptionTextId;
}
