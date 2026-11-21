using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02004103 RID: 16643
	[RequiredMember]
	public class MasterLevelDescData
	{
		// Token: 0x0602A061 RID: 172129 RVA: 0x00BE166E File Offset: 0x00BDF86E
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MasterLevelDescData()
		{
		}

		// Token: 0x04016EE2 RID: 93922
		[RequiredMember]
		public int Level;

		// Token: 0x04016EE3 RID: 93923
		[Nullable(1)]
		[RequiredMember]
		public string StringId;

		// Token: 0x04016EE4 RID: 93924
		[RequiredMember]
		public bool IsDone;
	}
}
