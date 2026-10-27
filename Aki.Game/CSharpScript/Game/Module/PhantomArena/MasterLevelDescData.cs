using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005133 RID: 20787
	[RequiredMember]
	public class MasterLevelDescData
	{
		// Token: 0x06035168 RID: 217448 RVA: 0x00C9425A File Offset: 0x00C9245A
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MasterLevelDescData()
		{
		}

		// Token: 0x0401C4AD RID: 115885
		[RequiredMember]
		public int Level;

		// Token: 0x0401C4AE RID: 115886
		[Nullable(1)]
		[RequiredMember]
		public string StringId;

		// Token: 0x0401C4AF RID: 115887
		[RequiredMember]
		public bool IsDone;
	}
}
