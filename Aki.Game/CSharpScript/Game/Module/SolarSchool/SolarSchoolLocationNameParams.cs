using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A58 RID: 23128
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolLocationNameParams
	{
		// Token: 0x06038FCA RID: 233418 RVA: 0x00FF63B5 File Offset: 0x00FF45B5
		public SolarSchoolLocationNameParams(string textId)
		{
			this.TextId = textId;
		}

		// Token: 0x17006CB6 RID: 27830
		// (get) Token: 0x06038FCB RID: 233419 RVA: 0x00FF63C4 File Offset: 0x00FF45C4
		public string TextId { get; }
	}
}
