using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059A1 RID: 22945
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolScheduleCellData
	{
		// Token: 0x0401DCB9 RID: 122041
		public int Weekday;

		// Token: 0x0401DCBA RID: 122042
		public ESolarSchoolTimeSlot Slot;

		// Token: 0x0401DCBB RID: 122043
		public int BehaviorId;

		// Token: 0x0401DCBC RID: 122044
		public ESolarSchoolBehaviorType? BehaviorType;

		// Token: 0x0401DCBD RID: 122045
		public ESolarSchoolCellState State;

		// Token: 0x0401DCBE RID: 122046
		public string Text = string.Empty;

		// Token: 0x0401DCBF RID: 122047
		public string BgPath = string.Empty;

		// Token: 0x0401DCC0 RID: 122048
		public string PreviousBgPath = string.Empty;

		// Token: 0x0401DCC1 RID: 122049
		public bool CanDelete;

		// Token: 0x0401DCC2 RID: 122050
		public bool IsPreviewCovered;

		// Token: 0x0401DCC3 RID: 122051
		public bool IsSpecialDay;

		// Token: 0x0401DCC4 RID: 122052
		public bool WasPreviewCovered;

		// Token: 0x0401DCC5 RID: 122053
		public bool PlayRefreshAnimation;

		// Token: 0x0401DCC6 RID: 122054
		public bool PlayCancelAnimation;
	}
}
