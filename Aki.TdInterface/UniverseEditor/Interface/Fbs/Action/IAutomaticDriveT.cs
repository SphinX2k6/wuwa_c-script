using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061BC RID: 25020
	public class IAutomaticDriveT
	{
		// Token: 0x1700BA88 RID: 47752
		// (get) Token: 0x0602B1CC RID: 176588 RVA: 0x005F1A8E File Offset: 0x005EFC8E
		// (set) Token: 0x0602B1CD RID: 176589 RVA: 0x005F1A96 File Offset: 0x005EFC96
		public float StandbyTime { get; set; }

		// Token: 0x0602B1CE RID: 176590 RVA: 0x005F1A9F File Offset: 0x005EFC9F
		public IAutomaticDriveT()
		{
			this.StandbyTime = 0f;
		}
	}
}
