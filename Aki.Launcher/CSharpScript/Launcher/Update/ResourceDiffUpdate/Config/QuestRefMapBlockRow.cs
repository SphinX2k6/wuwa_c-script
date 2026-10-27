using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000B7 RID: 183
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestRefMapBlockRow : TableBaseRow
	{
		// Token: 0x0600062B RID: 1579 RVA: 0x00036D4D File Offset: 0x00034F4D
		public override object GetId()
		{
			return this.QuestId;
		}

		// Token: 0x040003C9 RID: 969
		public int QuestId;

		// Token: 0x040003CA RID: 970
		public List<int> MapBlockId = new List<int>();
	}
}
