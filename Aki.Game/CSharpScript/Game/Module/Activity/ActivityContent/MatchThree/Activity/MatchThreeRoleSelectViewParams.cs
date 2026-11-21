using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity
{
	// Token: 0x020054C6 RID: 21702
	[NullableContext(2)]
	[Nullable(0)]
	public class MatchThreeRoleSelectViewParams
	{
		// Token: 0x0401C755 RID: 116565
		public EMatchThreeRolePopupMode Mode;

		// Token: 0x0401C756 RID: 116566
		public MatchThreeLevelDetailViewModel ViewModel;

		// Token: 0x0401C757 RID: 116567
		public Action OnRoleSelected;

		// Token: 0x0401C758 RID: 116568
		public int FocusRoleId;

		// Token: 0x0401C759 RID: 116569
		public Action OnClosed;
	}
}
