using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000C4 RID: 196
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleVoiceLanguageTableRow : TableBaseRow
	{
		// Token: 0x06000669 RID: 1641 RVA: 0x00038CF7 File Offset: 0x00036EF7
		public override object GetId()
		{
			return this.LanguageId;
		}

		// Token: 0x04000408 RID: 1032
		public int LanguageId;

		// Token: 0x04000409 RID: 1033
		public string Text = "";
	}
}
