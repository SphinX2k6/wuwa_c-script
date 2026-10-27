using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E07 RID: 15879
	public class IEntityDeadPositionT
	{
		// Token: 0x17006DBC RID: 28092
		// (get) Token: 0x06016376 RID: 90998 RVA: 0x0033540F File Offset: 0x0033360F
		// (set) Token: 0x06016377 RID: 90999 RVA: 0x00335417 File Offset: 0x00333617
		public int EntityId { get; set; }

		// Token: 0x17006DBD RID: 28093
		// (get) Token: 0x06016378 RID: 91000 RVA: 0x00335420 File Offset: 0x00333620
		// (set) Token: 0x06016379 RID: 91001 RVA: 0x00335428 File Offset: 0x00333628
		public TVarRefUnion Var { get; set; }

		// Token: 0x17006DBE RID: 28094
		// (get) Token: 0x0601637A RID: 91002 RVA: 0x00335431 File Offset: 0x00333631
		// (set) Token: 0x0601637B RID: 91003 RVA: 0x00335439 File Offset: 0x00333639
		public bool IsIgnoreRot { get; set; }

		// Token: 0x17006DBF RID: 28095
		// (get) Token: 0x0601637C RID: 91004 RVA: 0x00335442 File Offset: 0x00333642
		// (set) Token: 0x0601637D RID: 91005 RVA: 0x0033544A File Offset: 0x0033364A
		public byte NullMask { get; set; }

		// Token: 0x0601637E RID: 91006 RVA: 0x00335453 File Offset: 0x00333653
		public IEntityDeadPositionT()
		{
			this.EntityId = 0;
			this.Var = null;
			this.IsIgnoreRot = false;
			this.NullMask = 0;
		}
	}
}
