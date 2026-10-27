using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000BD RID: 189
	[NullableContext(1)]
	[Nullable(0)]
	public class RecallConfigRow : TableBaseRow
	{
		// Token: 0x06000640 RID: 1600 RVA: 0x00036FC5 File Offset: 0x000351C5
		public override object GetId()
		{
			return this.RecallId;
		}

		// Token: 0x040003D2 RID: 978
		public int RecallId;

		// Token: 0x040003D3 RID: 979
		public List<int> QuestIds = new List<int>();
	}
}
