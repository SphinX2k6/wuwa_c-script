using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate
{
	// Token: 0x020000A4 RID: 164
	[NullableContext(1)]
	[Nullable(0)]
	public class ResourceSelectionContext
	{
		// Token: 0x0400039B RID: 923
		public List<int> ActiveQuestIds = new List<int>();

		// Token: 0x0400039C RID: 924
		public readonly HashSet<int> FinishedQuests = new HashSet<int>();

		// Token: 0x0400039D RID: 925
		public List<int> CurrentBlockIds = new List<int>();

		// Token: 0x0400039E RID: 926
		public int Gender = -1;

		// Token: 0x0400039F RID: 927
		public List<ResourcePackagePositionData> Positions = new List<ResourcePackagePositionData>();
	}
}
