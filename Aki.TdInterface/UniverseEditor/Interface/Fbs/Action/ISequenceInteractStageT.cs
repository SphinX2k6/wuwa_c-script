using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200774B RID: 30539
	public class ISequenceInteractStageT
	{
		// Token: 0x1700DFDC RID: 57308
		// (get) Token: 0x06035980 RID: 219520 RVA: 0x0072F003 File Offset: 0x0072D203
		// (set) Token: 0x06035981 RID: 219521 RVA: 0x0072F00B File Offset: 0x0072D20B
		public List<TInteractEffectUnion> EnterStageEffects { get; set; }

		// Token: 0x1700DFDD RID: 57309
		// (get) Token: 0x06035982 RID: 219522 RVA: 0x0072F014 File Offset: 0x0072D214
		// (set) Token: 0x06035983 RID: 219523 RVA: 0x0072F01C File Offset: 0x0072D21C
		public List<IInteractPointT> InteractPoints { get; set; }

		// Token: 0x1700DFDE RID: 57310
		// (get) Token: 0x06035984 RID: 219524 RVA: 0x0072F025 File Offset: 0x0072D225
		// (set) Token: 0x06035985 RID: 219525 RVA: 0x0072F02D File Offset: 0x0072D22D
		public string UiTipText { get; set; }

		// Token: 0x1700DFDF RID: 57311
		// (get) Token: 0x06035986 RID: 219526 RVA: 0x0072F036 File Offset: 0x0072D236
		// (set) Token: 0x06035987 RID: 219527 RVA: 0x0072F03E File Offset: 0x0072D23E
		public bool IsResetAfterStageEnd { get; set; }

		// Token: 0x1700DFE0 RID: 57312
		// (get) Token: 0x06035988 RID: 219528 RVA: 0x0072F047 File Offset: 0x0072D247
		// (set) Token: 0x06035989 RID: 219529 RVA: 0x0072F04F File Offset: 0x0072D24F
		public byte NullMask { get; set; }

		// Token: 0x0603598A RID: 219530 RVA: 0x0072F058 File Offset: 0x0072D258
		public ISequenceInteractStageT()
		{
			this.EnterStageEffects = null;
			this.InteractPoints = null;
			this.UiTipText = null;
			this.IsResetAfterStageEnd = false;
			this.NullMask = 0;
		}
	}
}
