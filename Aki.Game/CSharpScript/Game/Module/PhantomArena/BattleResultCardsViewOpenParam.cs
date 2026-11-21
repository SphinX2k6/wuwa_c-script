using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02004101 RID: 16641
	[RequiredMember]
	public class BattleResultCardsViewOpenParam
	{
		// Token: 0x0602A05F RID: 172127 RVA: 0x00BE165E File Offset: 0x00BDF85E
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public BattleResultCardsViewOpenParam()
		{
		}

		// Token: 0x04016EDB RID: 93915
		[Nullable(1)]
		[RequiredMember]
		public List<int> CardIdList;

		// Token: 0x04016EDC RID: 93916
		[Nullable(2)]
		public Action CallbackOnClose;

		// Token: 0x04016EDD RID: 93917
		[RequiredMember]
		public bool IsNewPhantomArenaActivity;
	}
}
