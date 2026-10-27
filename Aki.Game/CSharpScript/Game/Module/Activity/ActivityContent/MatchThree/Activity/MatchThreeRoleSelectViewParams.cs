using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity
{
	// Token: 0x02006548 RID: 25928
	[NullableContext(2)]
	[Nullable(0)]
	public class MatchThreeRoleSelectViewParams
	{
		// Token: 0x04021E24 RID: 138788
		public EMatchThreeRolePopupMode Mode;

		// Token: 0x04021E25 RID: 138789
		public MatchThreeLevelDetailViewModel ViewModel;

		// Token: 0x04021E26 RID: 138790
		public Action OnRoleSelected;

		// Token: 0x04021E27 RID: 138791
		public int FocusRoleId;

		// Token: 0x04021E28 RID: 138792
		public Action OnClosed;
	}
}
