using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000BB RID: 187
	public class RefResourceQuestListRow : TableBaseRow
	{
		// Token: 0x06000639 RID: 1593 RVA: 0x00036F0F File Offset: 0x0003510F
		[NullableContext(1)]
		public override object GetId()
		{
			return this.BitId;
		}

		// Token: 0x040003CF RID: 975
		public int BitId;

		// Token: 0x040003D0 RID: 976
		public int QuestId;

		// Token: 0x040003D1 RID: 977
		public int HasRefResource;
	}
}
