using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000BA RID: 186
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestRefMapBlockRow : TableBaseRow
	{
		// Token: 0x06000646 RID: 1606 RVA: 0x0003884D File Offset: 0x00036A4D
		public override object GetId()
		{
			return this.QuestId;
		}

		// Token: 0x040003F8 RID: 1016
		public int QuestId;

		// Token: 0x040003F9 RID: 1017
		public List<int> MapBlockId = new List<int>();
	}
}
