using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000BC RID: 188
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestRefVideoConfigRow : TableBaseRow
	{
		// Token: 0x0600064D RID: 1613 RVA: 0x00038944 File Offset: 0x00036B44
		public override object GetId()
		{
			return this.Id;
		}

		// Token: 0x040003FA RID: 1018
		public int Id;

		// Token: 0x040003FB RID: 1019
		public int QuestId;

		// Token: 0x040003FC RID: 1020
		public int GirlOrBoy;

		// Token: 0x040003FD RID: 1021
		public string PakName = "";
	}
}
