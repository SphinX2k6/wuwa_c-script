using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000BE RID: 190
	public class RefResourceQuestListRow : TableBaseRow
	{
		// Token: 0x06000654 RID: 1620 RVA: 0x00038A0F File Offset: 0x00036C0F
		[NullableContext(1)]
		public override object GetId()
		{
			return this.BitId;
		}

		// Token: 0x040003FE RID: 1022
		public int BitId;

		// Token: 0x040003FF RID: 1023
		public int QuestId;

		// Token: 0x04000400 RID: 1024
		public int HasRefResource;
	}
}
