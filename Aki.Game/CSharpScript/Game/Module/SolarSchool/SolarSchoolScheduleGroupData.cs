using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059A3 RID: 22947
	public class SolarSchoolScheduleGroupData
	{
		// Token: 0x0401DCD0 RID: 122064
		public ESolarSchoolTimeSlot Slot;

		// Token: 0x0401DCD1 RID: 122065
		public int BehaviorId;

		// Token: 0x0401DCD2 RID: 122066
		public ESolarSchoolBehaviorType? BehaviorType;

		// Token: 0x0401DCD3 RID: 122067
		public int FirstWeekday;

		// Token: 0x0401DCD4 RID: 122068
		public bool CanDelete;

		// Token: 0x0401DCD5 RID: 122069
		public bool IsEmptyClickable;

		// Token: 0x0401DCD6 RID: 122070
		[Nullable(1)]
		public List<SolarSchoolScheduleCellData> Cells = new List<SolarSchoolScheduleCellData>();
	}
}
