using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077EC RID: 30700
	public class ISetMotorSpeedTargetSpeedT
	{
		// Token: 0x1700E104 RID: 57604
		// (get) Token: 0x06035EEF RID: 220911 RVA: 0x00739AF9 File Offset: 0x00737CF9
		// (set) Token: 0x06035EF0 RID: 220912 RVA: 0x00739B01 File Offset: 0x00737D01
		public EMotorSpeedType Type { get; set; }

		// Token: 0x1700E105 RID: 57605
		// (get) Token: 0x06035EF1 RID: 220913 RVA: 0x00739B0A File Offset: 0x00737D0A
		// (set) Token: 0x06035EF2 RID: 220914 RVA: 0x00739B12 File Offset: 0x00737D12
		public float TargetSpeed { get; set; }

		// Token: 0x1700E106 RID: 57606
		// (get) Token: 0x06035EF3 RID: 220915 RVA: 0x00739B1B File Offset: 0x00737D1B
		// (set) Token: 0x06035EF4 RID: 220916 RVA: 0x00739B23 File Offset: 0x00737D23
		public float TransitionTime { get; set; }

		// Token: 0x1700E107 RID: 57607
		// (get) Token: 0x06035EF5 RID: 220917 RVA: 0x00739B2C File Offset: 0x00737D2C
		// (set) Token: 0x06035EF6 RID: 220918 RVA: 0x00739B34 File Offset: 0x00737D34
		public TEaseCurveTypeUnion ChangeSpeedCurve { get; set; }

		// Token: 0x1700E108 RID: 57608
		// (get) Token: 0x06035EF7 RID: 220919 RVA: 0x00739B3D File Offset: 0x00737D3D
		// (set) Token: 0x06035EF8 RID: 220920 RVA: 0x00739B45 File Offset: 0x00737D45
		public bool NotAllowSpeedAdjustmentIfExceed { get; set; }

		// Token: 0x1700E109 RID: 57609
		// (get) Token: 0x06035EF9 RID: 220921 RVA: 0x00739B4E File Offset: 0x00737D4E
		// (set) Token: 0x06035EFA RID: 220922 RVA: 0x00739B56 File Offset: 0x00737D56
		public bool NotAllowSpeedAdjustmentIfBelow { get; set; }

		// Token: 0x1700E10A RID: 57610
		// (get) Token: 0x06035EFB RID: 220923 RVA: 0x00739B5F File Offset: 0x00737D5F
		// (set) Token: 0x06035EFC RID: 220924 RVA: 0x00739B67 File Offset: 0x00737D67
		public byte NullMask { get; set; }

		// Token: 0x06035EFD RID: 220925 RVA: 0x00739B70 File Offset: 0x00737D70
		public ISetMotorSpeedTargetSpeedT()
		{
			this.Type = EMotorSpeedType.TargetSpeed;
			this.TargetSpeed = 0f;
			this.TransitionTime = 0f;
			this.ChangeSpeedCurve = null;
			this.NotAllowSpeedAdjustmentIfExceed = false;
			this.NotAllowSpeedAdjustmentIfBelow = false;
			this.NullMask = 0;
		}
	}
}
