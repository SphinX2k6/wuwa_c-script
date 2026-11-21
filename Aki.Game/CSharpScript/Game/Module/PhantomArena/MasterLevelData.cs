using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02004102 RID: 16642
	[RequiredMember]
	public class MasterLevelData
	{
		// Token: 0x0602A060 RID: 172128 RVA: 0x00BE1666 File Offset: 0x00BDF866
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MasterLevelData()
		{
		}

		// Token: 0x04016EDE RID: 93918
		[RequiredMember]
		public int Level;

		// Token: 0x04016EDF RID: 93919
		[RequiredMember]
		public int ExpLevel;

		// Token: 0x04016EE0 RID: 93920
		[RequiredMember]
		public int ExpNext;

		// Token: 0x04016EE1 RID: 93921
		[RequiredMember]
		public bool IsMax;
	}
}
