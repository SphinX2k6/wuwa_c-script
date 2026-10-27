using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000B9 RID: 185
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestRefVideoConfigRow : TableBaseRow
	{
		// Token: 0x06000632 RID: 1586 RVA: 0x00036E44 File Offset: 0x00035044
		public override object GetId()
		{
			return this.Id;
		}

		// Token: 0x040003CB RID: 971
		public int Id;

		// Token: 0x040003CC RID: 972
		public int QuestId;

		// Token: 0x040003CD RID: 973
		public int GirlOrBoy;

		// Token: 0x040003CE RID: 974
		public string PakName = "";
	}
}
