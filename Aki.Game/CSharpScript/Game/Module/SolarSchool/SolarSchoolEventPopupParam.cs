using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A3E RID: 23102
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolEventPopupParam
	{
		// Token: 0x0401DF94 RID: 122772
		public ESolarSchoolPopupId PopupId;

		// Token: 0x0401DF95 RID: 122773
		public IReadOnlyList<string> MainTitleParams = Array.Empty<string>();

		// Token: 0x0401DF96 RID: 122774
		public IReadOnlyList<string> SubTitleParams = Array.Empty<string>();

		// Token: 0x0401DF97 RID: 122775
		[Nullable(2)]
		public Action OnCloseCallback;
	}
}
