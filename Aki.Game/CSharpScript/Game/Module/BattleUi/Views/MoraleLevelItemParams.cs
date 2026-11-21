using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E16 RID: 19990
	[RequiredMember]
	public class MoraleLevelItemParams : ExtraItemParams
	{
		// Token: 0x060324C3 RID: 206019 RVA: 0x00E19F89 File Offset: 0x00E18189
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MoraleLevelItemParams()
		{
		}

		// Token: 0x0401AA8D RID: 109197
		[RequiredMember]
		public int MoraleLevel;
	}
}
