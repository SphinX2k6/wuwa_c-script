using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02004108 RID: 16648
	[RequiredMember]
	public class PhantomArenaMapEntrancePanelParam
	{
		// Token: 0x0602A066 RID: 172134 RVA: 0x00BE16A8 File Offset: 0x00BDF8A8
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public PhantomArenaMapEntrancePanelParam()
		{
		}

		// Token: 0x04016EF5 RID: 93941
		[RequiredMember]
		public int ChallengeId;

		// Token: 0x04016EF6 RID: 93942
		public bool? IsNeedSelect;
	}
}
