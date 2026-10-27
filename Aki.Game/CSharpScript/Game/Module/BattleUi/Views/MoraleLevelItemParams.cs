using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E31 RID: 24113
	[RequiredMember]
	public class MoraleLevelItemParams : ExtraItemParams
	{
		// Token: 0x0603D533 RID: 251187 RVA: 0x00EC8A1D File Offset: 0x00EC6C1D
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MoraleLevelItemParams()
		{
		}

		// Token: 0x0401FFC6 RID: 131014
		[RequiredMember]
		public int MoraleLevel;
	}
}
