using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040FE RID: 16638
	[RequiredMember]
	public class BattleResultViewOpenParam
	{
		// Token: 0x0602A05C RID: 172124 RVA: 0x00BE1646 File Offset: 0x00BDF846
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public BattleResultViewOpenParam()
		{
		}

		// Token: 0x04016ED5 RID: 93909
		[Nullable(1)]
		[RequiredMember]
		public PhantomBattleBoardSettleNotify Result;

		// Token: 0x04016ED6 RID: 93910
		[Nullable(2)]
		public Action<bool> CallbackOnClose;
	}
}
