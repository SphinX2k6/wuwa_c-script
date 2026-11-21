using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A39 RID: 23097
	public class SolarSchoolSpecialBehaviorAcceptParam
	{
		// Token: 0x0401DF7C RID: 122748
		public int BehaviorId;

		// Token: 0x0401DF7D RID: 122749
		public bool HideClose;

		// Token: 0x0401DF7E RID: 122750
		[Nullable(2)]
		public Action OnAccepted;
	}
}
