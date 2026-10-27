using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049AD RID: 18861
	public class ICheckCoopRoleCoopLevelT
	{
		// Token: 0x1700885D RID: 34909
		// (get) Token: 0x0601D708 RID: 120584 RVA: 0x00425EE4 File Offset: 0x004240E4
		// (set) Token: 0x0601D709 RID: 120585 RVA: 0x00425EEC File Offset: 0x004240EC
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x1700885E RID: 34910
		// (get) Token: 0x0601D70A RID: 120586 RVA: 0x00425EF5 File Offset: 0x004240F5
		// (set) Token: 0x0601D70B RID: 120587 RVA: 0x00425EFD File Offset: 0x004240FD
		public int CoopRoleId { get; set; }

		// Token: 0x1700885F RID: 34911
		// (get) Token: 0x0601D70C RID: 120588 RVA: 0x00425F06 File Offset: 0x00424106
		// (set) Token: 0x0601D70D RID: 120589 RVA: 0x00425F0E File Offset: 0x0042410E
		public ECompare Compare { get; set; }

		// Token: 0x17008860 RID: 34912
		// (get) Token: 0x0601D70E RID: 120590 RVA: 0x00425F17 File Offset: 0x00424117
		// (set) Token: 0x0601D70F RID: 120591 RVA: 0x00425F1F File Offset: 0x0042411F
		public int Level { get; set; }

		// Token: 0x0601D710 RID: 120592 RVA: 0x00425F28 File Offset: 0x00424128
		public ICheckCoopRoleCoopLevelT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.CoopRoleId = 0;
			this.Compare = ECompare.Eq;
			this.Level = 0;
		}
	}
}
