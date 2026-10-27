using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005138 RID: 20792
	[RequiredMember]
	public class PhantomArenaMapEntrancePanelParam
	{
		// Token: 0x0603516D RID: 217453 RVA: 0x00C94294 File Offset: 0x00C92494
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public PhantomArenaMapEntrancePanelParam()
		{
		}

		// Token: 0x0401C4C0 RID: 115904
		[RequiredMember]
		public int ChallengeId;

		// Token: 0x0401C4C1 RID: 115905
		public bool? IsNeedSelect;
	}
}
