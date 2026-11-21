using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A57 RID: 23127
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolFestivalTipsParams
	{
		// Token: 0x06038FC8 RID: 233416 RVA: 0x00FF639E File Offset: 0x00FF459E
		public SolarSchoolFestivalTipsParams(string textId)
		{
			this.TextId = textId;
		}

		// Token: 0x17006CB5 RID: 27829
		// (get) Token: 0x06038FC9 RID: 233417 RVA: 0x00FF63AD File Offset: 0x00FF45AD
		public string TextId { get; }
	}
}
