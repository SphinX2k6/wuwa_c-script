using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006613 RID: 26131
	public class IDriveMotorInSpecConfigT
	{
		// Token: 0x1700C22E RID: 49710
		// (get) Token: 0x0602D617 RID: 185879 RVA: 0x00638052 File Offset: 0x00636252
		// (set) Token: 0x0602D618 RID: 185880 RVA: 0x0063805A File Offset: 0x0063625A
		public TMotorParamsChangeConfigUnion MotorParamsChangeConfig { get; set; }

		// Token: 0x1700C22F RID: 49711
		// (get) Token: 0x0602D619 RID: 185881 RVA: 0x00638063 File Offset: 0x00636263
		// (set) Token: 0x0602D61A RID: 185882 RVA: 0x0063806B File Offset: 0x0063626B
		public bool IsEnableNitrogen { get; set; }

		// Token: 0x1700C230 RID: 49712
		// (get) Token: 0x0602D61B RID: 185883 RVA: 0x00638074 File Offset: 0x00636274
		// (set) Token: 0x0602D61C RID: 185884 RVA: 0x0063807C File Offset: 0x0063627C
		public List<EPlayerInputConstraintType> DisableInput { get; set; }

		// Token: 0x1700C231 RID: 49713
		// (get) Token: 0x0602D61D RID: 185885 RVA: 0x00638085 File Offset: 0x00636285
		// (set) Token: 0x0602D61E RID: 185886 RVA: 0x0063808D File Offset: 0x0063628D
		public float Duration { get; set; }

		// Token: 0x1700C232 RID: 49714
		// (get) Token: 0x0602D61F RID: 185887 RVA: 0x00638096 File Offset: 0x00636296
		// (set) Token: 0x0602D620 RID: 185888 RVA: 0x0063809E File Offset: 0x0063629E
		public bool IsAffectedByTimeStop { get; set; }

		// Token: 0x1700C233 RID: 49715
		// (get) Token: 0x0602D621 RID: 185889 RVA: 0x006380A7 File Offset: 0x006362A7
		// (set) Token: 0x0602D622 RID: 185890 RVA: 0x006380AF File Offset: 0x006362AF
		public bool CanBeInterrupted { get; set; }

		// Token: 0x1700C234 RID: 49716
		// (get) Token: 0x0602D623 RID: 185891 RVA: 0x006380B8 File Offset: 0x006362B8
		// (set) Token: 0x0602D624 RID: 185892 RVA: 0x006380C0 File Offset: 0x006362C0
		public byte NullMask { get; set; }

		// Token: 0x0602D625 RID: 185893 RVA: 0x006380C9 File Offset: 0x006362C9
		public IDriveMotorInSpecConfigT()
		{
			this.MotorParamsChangeConfig = null;
			this.IsEnableNitrogen = false;
			this.DisableInput = null;
			this.Duration = 0f;
			this.IsAffectedByTimeStop = false;
			this.CanBeInterrupted = false;
			this.NullMask = 0;
		}
	}
}
