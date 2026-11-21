using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059D5 RID: 22997
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolJumpAccessPopupParam
	{
		// Token: 0x0401DD64 RID: 122212
		public List<SolarSchoolJumpAccessItemData> DataList = new List<SolarSchoolJumpAccessItemData>();

		// Token: 0x0401DD65 RID: 122213
		public string TitleId = string.Empty;

		// Token: 0x0401DD66 RID: 122214
		public string TipsId = string.Empty;

		// Token: 0x0401DD67 RID: 122215
		[Nullable(2)]
		public Action CloseCallback;
	}
}
