using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000C1 RID: 193
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleVoiceLanguageTableRow : TableBaseRow
	{
		// Token: 0x0600064E RID: 1614 RVA: 0x000371F7 File Offset: 0x000353F7
		public override object GetId()
		{
			return this.LanguageId;
		}

		// Token: 0x040003D9 RID: 985
		public int LanguageId;

		// Token: 0x040003DA RID: 986
		public string Text = "";
	}
}
