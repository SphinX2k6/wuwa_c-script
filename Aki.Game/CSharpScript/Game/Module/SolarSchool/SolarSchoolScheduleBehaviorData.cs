using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200599E RID: 22942
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolScheduleBehaviorData
	{
		// Token: 0x0401DCA6 RID: 122022
		public int BehaviorId;

		// Token: 0x0401DCA7 RID: 122023
		public ESolarSchoolBehaviorType BehaviorType;

		// Token: 0x0401DCA8 RID: 122024
		public ESolarSchoolTimeSlot[] AvailableSlots = Array.Empty<ESolarSchoolTimeSlot>();

		// Token: 0x0401DCA9 RID: 122025
		public int StarLevel;

		// Token: 0x0401DCAA RID: 122026
		public int Level;

		// Token: 0x0401DCAB RID: 122027
		public string Name = string.Empty;

		// Token: 0x0401DCAC RID: 122028
		public string Desc = string.Empty;

		// Token: 0x0401DCAD RID: 122029
		public string IconPath = string.Empty;

		// Token: 0x0401DCAE RID: 122030
		public string BgNmlPath = string.Empty;

		// Token: 0x0401DCAF RID: 122031
		public string BgHoldPath = string.Empty;

		// Token: 0x0401DCB0 RID: 122032
		public bool IsAddEnabled = true;
	}
}
