using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020052F2 RID: 21234
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueIllustratedTabData
	{
		// Token: 0x0401CB47 RID: 117575
		public ERogueHandbookType TabType;

		// Token: 0x0401CB48 RID: 117576
		public string Icon = "";

		// Token: 0x0401CB49 RID: 117577
		public string TabName = "";

		// Token: 0x0401CB4A RID: 117578
		public int Index = 1;

		// Token: 0x0401CB4B RID: 117579
		public RogueResTheme? Config;
	}
}
