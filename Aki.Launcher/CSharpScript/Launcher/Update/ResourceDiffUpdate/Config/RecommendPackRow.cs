using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000BF RID: 191
	[NullableContext(1)]
	[Nullable(0)]
	public class RecommendPackRow : TableBaseRow
	{
		// Token: 0x06000647 RID: 1607 RVA: 0x0003711D File Offset: 0x0003531D
		public override object GetId()
		{
			return this.Id;
		}

		// Token: 0x040003D4 RID: 980
		public int Id;

		// Token: 0x040003D5 RID: 981
		public List<int> FinishQuest = new List<int>();

		// Token: 0x040003D6 RID: 982
		public List<int> UnfinishQuest = new List<int>();

		// Token: 0x040003D7 RID: 983
		public List<int> Source = new List<int>();

		// Token: 0x040003D8 RID: 984
		public List<int> VideoQuestId = new List<int>();
	}
}
