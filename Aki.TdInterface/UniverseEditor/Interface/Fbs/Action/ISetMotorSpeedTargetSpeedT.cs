using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007023 RID: 28707
	public class ISetMotorSpeedTargetSpeedT
	{
		// Token: 0x1700D530 RID: 54576
		// (get) Token: 0x06032C89 RID: 208009 RVA: 0x006D9EB5 File Offset: 0x006D80B5
		// (set) Token: 0x06032C8A RID: 208010 RVA: 0x006D9EBD File Offset: 0x006D80BD
		public EMotorSpeedType Type { get; set; }

		// Token: 0x1700D531 RID: 54577
		// (get) Token: 0x06032C8B RID: 208011 RVA: 0x006D9EC6 File Offset: 0x006D80C6
		// (set) Token: 0x06032C8C RID: 208012 RVA: 0x006D9ECE File Offset: 0x006D80CE
		public float TargetSpeed { get; set; }

		// Token: 0x1700D532 RID: 54578
		// (get) Token: 0x06032C8D RID: 208013 RVA: 0x006D9ED7 File Offset: 0x006D80D7
		// (set) Token: 0x06032C8E RID: 208014 RVA: 0x006D9EDF File Offset: 0x006D80DF
		public float TransitionTime { get; set; }

		// Token: 0x1700D533 RID: 54579
		// (get) Token: 0x06032C8F RID: 208015 RVA: 0x006D9EE8 File Offset: 0x006D80E8
		// (set) Token: 0x06032C90 RID: 208016 RVA: 0x006D9EF0 File Offset: 0x006D80F0
		public TEaseCurveTypeUnion ChangeSpeedCurve { get; set; }

		// Token: 0x1700D534 RID: 54580
		// (get) Token: 0x06032C91 RID: 208017 RVA: 0x006D9EF9 File Offset: 0x006D80F9
		// (set) Token: 0x06032C92 RID: 208018 RVA: 0x006D9F01 File Offset: 0x006D8101
		public bool NotAllowSpeedAdjustmentIfExceed { get; set; }

		// Token: 0x1700D535 RID: 54581
		// (get) Token: 0x06032C93 RID: 208019 RVA: 0x006D9F0A File Offset: 0x006D810A
		// (set) Token: 0x06032C94 RID: 208020 RVA: 0x006D9F12 File Offset: 0x006D8112
		public bool NotAllowSpeedAdjustmentIfBelow { get; set; }

		// Token: 0x1700D536 RID: 54582
		// (get) Token: 0x06032C95 RID: 208021 RVA: 0x006D9F1B File Offset: 0x006D811B
		// (set) Token: 0x06032C96 RID: 208022 RVA: 0x006D9F23 File Offset: 0x006D8123
		public byte NullMask { get; set; }

		// Token: 0x06032C97 RID: 208023 RVA: 0x006D9F2C File Offset: 0x006D812C
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
