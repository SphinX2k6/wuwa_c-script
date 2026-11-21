using System;
using System.Runtime.CompilerServices;

// Token: 0x020005BA RID: 1466
[RequiredMember]
public class ArtemisQteViewParams
{
	// Token: 0x06004544 RID: 17732 RVA: 0x0017CB82 File Offset: 0x0017AD82
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ArtemisQteViewParams()
	{
	}

	// Token: 0x04003562 RID: 13666
	[RequiredMember]
	public int GamePlayId;

	// Token: 0x04003563 RID: 13667
	[RequiredMember]
	public int Index;

	// Token: 0x04003564 RID: 13668
	[Nullable(1)]
	[RequiredMember]
	public Action CallBack;
}
