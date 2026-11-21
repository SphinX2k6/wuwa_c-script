using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000C0 RID: 192
	[NullableContext(1)]
	[Nullable(0)]
	public class RecallConfigRow : TableBaseRow
	{
		// Token: 0x0600065B RID: 1627 RVA: 0x00038AC5 File Offset: 0x00036CC5
		public override object GetId()
		{
			return this.RecallId;
		}

		// Token: 0x04000401 RID: 1025
		public int RecallId;

		// Token: 0x04000402 RID: 1026
		public List<int> QuestIds = new List<int>();
	}
}
