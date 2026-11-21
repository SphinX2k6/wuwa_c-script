using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007161 RID: 29025
	public class ILongPressInteractConfigT
	{
		// Token: 0x1700D476 RID: 54390
		// (get) Token: 0x06032718 RID: 206616 RVA: 0x006D1A64 File Offset: 0x006CFC64
		// (set) Token: 0x06032719 RID: 206617 RVA: 0x006D1A6C File Offset: 0x006CFC6C
		public float PressDuration { get; set; }

		// Token: 0x1700D477 RID: 54391
		// (get) Token: 0x0603271A RID: 206618 RVA: 0x006D1A75 File Offset: 0x006CFC75
		// (set) Token: 0x0603271B RID: 206619 RVA: 0x006D1A7D File Offset: 0x006CFC7D
		public ILongPressEffectConfigT PressEffect { get; set; }

		// Token: 0x1700D478 RID: 54392
		// (get) Token: 0x0603271C RID: 206620 RVA: 0x006D1A86 File Offset: 0x006CFC86
		// (set) Token: 0x0603271D RID: 206621 RVA: 0x006D1A8E File Offset: 0x006CFC8E
		public TLongPressInteractStyleConfigUnion Style { get; set; }

		// Token: 0x1700D479 RID: 54393
		// (get) Token: 0x0603271E RID: 206622 RVA: 0x006D1A97 File Offset: 0x006CFC97
		// (set) Token: 0x0603271F RID: 206623 RVA: 0x006D1A9F File Offset: 0x006CFC9F
		public bool ResetFromCurrentProgress { get; set; }

		// Token: 0x1700D47A RID: 54394
		// (get) Token: 0x06032720 RID: 206624 RVA: 0x006D1AA8 File Offset: 0x006CFCA8
		// (set) Token: 0x06032721 RID: 206625 RVA: 0x006D1AB0 File Offset: 0x006CFCB0
		public ILongPressButtonActionMappingT LongPressButtonActionMapping { get; set; }

		// Token: 0x1700D47B RID: 54395
		// (get) Token: 0x06032722 RID: 206626 RVA: 0x006D1AB9 File Offset: 0x006CFCB9
		// (set) Token: 0x06032723 RID: 206627 RVA: 0x006D1AC1 File Offset: 0x006CFCC1
		public List<IActionInfoT> LongPressStartActions { get; set; }

		// Token: 0x1700D47C RID: 54396
		// (get) Token: 0x06032724 RID: 206628 RVA: 0x006D1ACA File Offset: 0x006CFCCA
		// (set) Token: 0x06032725 RID: 206629 RVA: 0x006D1AD2 File Offset: 0x006CFCD2
		public List<IActionInfoT> LongPressInterruptedActions { get; set; }

		// Token: 0x1700D47D RID: 54397
		// (get) Token: 0x06032726 RID: 206630 RVA: 0x006D1ADB File Offset: 0x006CFCDB
		// (set) Token: 0x06032727 RID: 206631 RVA: 0x006D1AE3 File Offset: 0x006CFCE3
		public List<IActionInfoT> LongPressSuccessActions { get; set; }

		// Token: 0x1700D47E RID: 54398
		// (get) Token: 0x06032728 RID: 206632 RVA: 0x006D1AEC File Offset: 0x006CFCEC
		// (set) Token: 0x06032729 RID: 206633 RVA: 0x006D1AF4 File Offset: 0x006CFCF4
		public List<ILongPressProgressActionT> LongPressProgressActions { get; set; }

		// Token: 0x1700D47F RID: 54399
		// (get) Token: 0x0603272A RID: 206634 RVA: 0x006D1AFD File Offset: 0x006CFCFD
		// (set) Token: 0x0603272B RID: 206635 RVA: 0x006D1B05 File Offset: 0x006CFD05
		public byte NullMask { get; set; }

		// Token: 0x0603272C RID: 206636 RVA: 0x006D1B10 File Offset: 0x006CFD10
		public ILongPressInteractConfigT()
		{
			this.PressDuration = 0f;
			this.PressEffect = null;
			this.Style = null;
			this.ResetFromCurrentProgress = false;
			this.LongPressButtonActionMapping = null;
			this.LongPressStartActions = null;
			this.LongPressInterruptedActions = null;
			this.LongPressSuccessActions = null;
			this.LongPressProgressActions = null;
			this.NullMask = 0;
		}
	}
}
