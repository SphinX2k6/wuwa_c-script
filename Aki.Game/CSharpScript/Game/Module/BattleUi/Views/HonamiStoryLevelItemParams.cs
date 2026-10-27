using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E32 RID: 24114
	[RequiredMember]
	public class HonamiStoryLevelItemParams : ExtraItemParams
	{
		// Token: 0x0603D534 RID: 251188 RVA: 0x00EC8A25 File Offset: 0x00EC6C25
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public HonamiStoryLevelItemParams()
		{
		}

		// Token: 0x0401FFC7 RID: 131015
		[RequiredMember]
		public int HonamiStoryLevel;
	}
}
