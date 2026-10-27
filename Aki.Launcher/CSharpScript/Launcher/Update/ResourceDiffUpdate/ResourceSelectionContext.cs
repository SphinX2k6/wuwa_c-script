using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate
{
	// Token: 0x020000A1 RID: 161
	[NullableContext(1)]
	[Nullable(0)]
	public class ResourceSelectionContext
	{
		// Token: 0x0400036D RID: 877
		public List<int> ActiveQuestIds = new List<int>();

		// Token: 0x0400036E RID: 878
		public readonly HashSet<int> FinishedQuests = new HashSet<int>();

		// Token: 0x0400036F RID: 879
		public List<int> CurrentBlockIds = new List<int>();

		// Token: 0x04000370 RID: 880
		public int Gender = -1;

		// Token: 0x04000371 RID: 881
		public List<ResourcePackagePositionData> Positions = new List<ResourcePackagePositionData>();
	}
}
