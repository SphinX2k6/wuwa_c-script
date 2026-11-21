using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E17 RID: 19991
	[RequiredMember]
	public class HonamiStoryLevelItemParams : ExtraItemParams
	{
		// Token: 0x060324C4 RID: 206020 RVA: 0x00E19F91 File Offset: 0x00E18191
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public HonamiStoryLevelItemParams()
		{
		}

		// Token: 0x0401AA8E RID: 109198
		[RequiredMember]
		public int HonamiStoryLevel;
	}
}
