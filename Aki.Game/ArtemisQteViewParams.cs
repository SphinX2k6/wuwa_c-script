using System;
using System.Runtime.CompilerServices;

// Token: 0x02001106 RID: 4358
[RequiredMember]
public class ArtemisQteViewParams
{
	// Token: 0x060071AE RID: 29102 RVA: 0x001741C6 File Offset: 0x001723C6
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ArtemisQteViewParams()
	{
	}

	// Token: 0x040034C9 RID: 13513
	[RequiredMember]
	public int GamePlayId;

	// Token: 0x040034CA RID: 13514
	[RequiredMember]
	public int Index;

	// Token: 0x040034CB RID: 13515
	[Nullable(1)]
	[RequiredMember]
	public Action CallBack;
}
