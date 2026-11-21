using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A3D RID: 23101
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolTogItemData
	{
		// Token: 0x0401DF8A RID: 122762
		public int OptionId;

		// Token: 0x0401DF8B RID: 122763
		public int BehaviorId;

		// Token: 0x0401DF8C RID: 122764
		public string Text = string.Empty;

		// Token: 0x0401DF8D RID: 122765
		[Nullable(2)]
		public string IconPath;

		// Token: 0x0401DF8E RID: 122766
		public bool CanClick = true;

		// Token: 0x0401DF8F RID: 122767
		public bool IsExtraEntry;

		// Token: 0x0401DF90 RID: 122768
		public bool ShowRedDot;

		// Token: 0x0401DF91 RID: 122769
		public string LockHint = string.Empty;

		// Token: 0x0401DF92 RID: 122770
		public int Level;

		// Token: 0x0401DF93 RID: 122771
		public ESolarSchoolTimeSlot OccupySlot;
	}
}
