using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005131 RID: 20785
	[RequiredMember]
	public class BattleResultCardsViewOpenParam
	{
		// Token: 0x06035166 RID: 217446 RVA: 0x00C9424A File Offset: 0x00C9244A
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public BattleResultCardsViewOpenParam()
		{
		}

		// Token: 0x0401C4A6 RID: 115878
		[Nullable(1)]
		[RequiredMember]
		public List<int> CardIdList;

		// Token: 0x0401C4A7 RID: 115879
		[Nullable(2)]
		public Action CallbackOnClose;

		// Token: 0x0401C4A8 RID: 115880
		[RequiredMember]
		public bool IsNewPhantomArenaActivity;
	}
}
