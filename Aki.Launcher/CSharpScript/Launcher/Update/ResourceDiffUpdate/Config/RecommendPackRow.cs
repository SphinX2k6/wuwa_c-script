using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000C2 RID: 194
	[NullableContext(1)]
	[Nullable(0)]
	public class RecommendPackRow : TableBaseRow
	{
		// Token: 0x06000662 RID: 1634 RVA: 0x00038C1D File Offset: 0x00036E1D
		public override object GetId()
		{
			return this.Id;
		}

		// Token: 0x04000403 RID: 1027
		public int Id;

		// Token: 0x04000404 RID: 1028
		public List<int> FinishQuest = new List<int>();

		// Token: 0x04000405 RID: 1029
		public List<int> UnfinishQuest = new List<int>();

		// Token: 0x04000406 RID: 1030
		public List<int> Source = new List<int>();

		// Token: 0x04000407 RID: 1031
		public List<int> VideoQuestId = new List<int>();
	}
}
