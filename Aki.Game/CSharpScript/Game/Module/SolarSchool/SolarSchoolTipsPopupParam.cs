using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059CE RID: 22990
	public class SolarSchoolTipsPopupParam
	{
		// Token: 0x0401DD4E RID: 122190
		public int ItemId;

		// Token: 0x0401DD4F RID: 122191
		public int Count;

		// Token: 0x0401DD50 RID: 122192
		public bool ShowTitle = true;

		// Token: 0x0401DD51 RID: 122193
		[Nullable(2)]
		public Action CloseCallback;
	}
}
