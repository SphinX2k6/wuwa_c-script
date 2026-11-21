using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059D0 RID: 22992
	public class SolarSchoolFavorLevelUpPopupParam
	{
		// Token: 0x0401DD57 RID: 122199
		public int RoleId;

		// Token: 0x0401DD58 RID: 122200
		public int PreviousLevel;

		// Token: 0x0401DD59 RID: 122201
		public int FinalLevel;

		// Token: 0x0401DD5A RID: 122202
		[Nullable(2)]
		public Action CloseCallback;
	}
}
