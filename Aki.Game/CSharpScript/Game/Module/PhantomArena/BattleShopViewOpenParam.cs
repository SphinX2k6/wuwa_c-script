using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x0200512F RID: 20783
	[RequiredMember]
	public class BattleShopViewOpenParam
	{
		// Token: 0x06035164 RID: 217444 RVA: 0x00C9423A File Offset: 0x00C9243A
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public BattleShopViewOpenParam()
		{
		}

		// Token: 0x0401C4A2 RID: 115874
		[RequiredMember]
		public EUiTabViewName TabViewName;

		// Token: 0x0401C4A3 RID: 115875
		[RequiredMember]
		public int ActivityId;
	}
}
