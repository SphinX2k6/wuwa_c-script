using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02004100 RID: 16640
	[RequiredMember]
	public class BattleMatchViewOpenParam
	{
		// Token: 0x0602A05E RID: 172126 RVA: 0x00BE1656 File Offset: 0x00BDF856
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public BattleMatchViewOpenParam()
		{
		}

		// Token: 0x04016ED9 RID: 93913
		[RequiredMember]
		public int Level;

		// Token: 0x04016EDA RID: 93914
		[RequiredMember]
		public int ActivityId;
	}
}
