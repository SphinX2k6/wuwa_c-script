using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x0200512E RID: 20782
	[RequiredMember]
	public class BattleResultViewOpenParam
	{
		// Token: 0x06035163 RID: 217443 RVA: 0x00C94232 File Offset: 0x00C92432
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public BattleResultViewOpenParam()
		{
		}

		// Token: 0x0401C4A0 RID: 115872
		[Nullable(1)]
		[RequiredMember]
		public PhantomBattleBoardSettleNotify Result;

		// Token: 0x0401C4A1 RID: 115873
		[Nullable(2)]
		public Action<bool> CallbackOnClose;
	}
}
