using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040FF RID: 16639
	[RequiredMember]
	public class BattleShopViewOpenParam
	{
		// Token: 0x0602A05D RID: 172125 RVA: 0x00BE164E File Offset: 0x00BDF84E
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public BattleShopViewOpenParam()
		{
		}

		// Token: 0x04016ED7 RID: 93911
		[RequiredMember]
		public EUiTabViewName TabViewName;

		// Token: 0x04016ED8 RID: 93912
		[RequiredMember]
		public int ActivityId;
	}
}
