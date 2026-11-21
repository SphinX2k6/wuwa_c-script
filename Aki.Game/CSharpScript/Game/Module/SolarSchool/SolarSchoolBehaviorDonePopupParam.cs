using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059D1 RID: 22993
	public class SolarSchoolBehaviorDonePopupParam
	{
		// Token: 0x0401DD5B RID: 122203
		public int BehaviorId;

		// Token: 0x0401DD5C RID: 122204
		[Nullable(1)]
		public string TextKey = string.Empty;

		// Token: 0x0401DD5D RID: 122205
		public bool ShowAttrList = true;

		// Token: 0x0401DD5E RID: 122206
		[Nullable(2)]
		public Action CloseCallback;
	}
}
