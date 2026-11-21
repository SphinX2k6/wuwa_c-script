using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020042C2 RID: 17090
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueIllustratedTabData
	{
		// Token: 0x0401757D RID: 95613
		public ERogueHandbookType TabType;

		// Token: 0x0401757E RID: 95614
		public string Icon = "";

		// Token: 0x0401757F RID: 95615
		public string TabName = "";

		// Token: 0x04017580 RID: 95616
		public int Index = 1;

		// Token: 0x04017581 RID: 95617
		public RogueResTheme? Config;
	}
}
