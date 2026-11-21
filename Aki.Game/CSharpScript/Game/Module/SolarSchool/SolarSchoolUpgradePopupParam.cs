using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059D8 RID: 23000
	public class SolarSchoolUpgradePopupParam
	{
		// Token: 0x0401DD6F RID: 122223
		[Nullable(1)]
		public List<SolarSchoolAttrRankUpInfo> AttrList = new List<SolarSchoolAttrRankUpInfo>();

		// Token: 0x0401DD70 RID: 122224
		[Nullable(2)]
		public Action CloseCallback;
	}
}
