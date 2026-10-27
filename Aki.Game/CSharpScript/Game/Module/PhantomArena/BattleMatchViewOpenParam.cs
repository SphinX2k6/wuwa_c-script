using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005130 RID: 20784
	[RequiredMember]
	public class BattleMatchViewOpenParam
	{
		// Token: 0x06035165 RID: 217445 RVA: 0x00C94242 File Offset: 0x00C92442
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public BattleMatchViewOpenParam()
		{
		}

		// Token: 0x0401C4A4 RID: 115876
		[RequiredMember]
		public int Level;

		// Token: 0x0401C4A5 RID: 115877
		[RequiredMember]
		public int ActivityId;
	}
}
