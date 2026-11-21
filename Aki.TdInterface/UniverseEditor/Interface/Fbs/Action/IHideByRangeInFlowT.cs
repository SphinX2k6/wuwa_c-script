using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F93 RID: 28563
	public class IHideByRangeInFlowT
	{
		// Token: 0x1700D132 RID: 53554
		// (get) Token: 0x06031718 RID: 202520 RVA: 0x006B4036 File Offset: 0x006B2236
		// (set) Token: 0x06031719 RID: 202521 RVA: 0x006B403E File Offset: 0x006B223E
		public ETriggerShape Type { get; set; }

		// Token: 0x1700D133 RID: 53555
		// (get) Token: 0x0603171A RID: 202522 RVA: 0x006B4047 File Offset: 0x006B2247
		// (set) Token: 0x0603171B RID: 202523 RVA: 0x006B404F File Offset: 0x006B224F
		public IVectorInfoT Center { get; set; }

		// Token: 0x1700D134 RID: 53556
		// (get) Token: 0x0603171C RID: 202524 RVA: 0x006B4058 File Offset: 0x006B2258
		// (set) Token: 0x0603171D RID: 202525 RVA: 0x006B4060 File Offset: 0x006B2260
		public int Radius { get; set; }

		// Token: 0x1700D135 RID: 53557
		// (get) Token: 0x0603171E RID: 202526 RVA: 0x006B4069 File Offset: 0x006B2269
		// (set) Token: 0x0603171F RID: 202527 RVA: 0x006B4071 File Offset: 0x006B2271
		public List<int> EntityIds { get; set; }

		// Token: 0x1700D136 RID: 53558
		// (get) Token: 0x06031720 RID: 202528 RVA: 0x006B407A File Offset: 0x006B227A
		// (set) Token: 0x06031721 RID: 202529 RVA: 0x006B4082 File Offset: 0x006B2282
		public bool IsCleanSimpleNpc { get; set; }

		// Token: 0x1700D137 RID: 53559
		// (get) Token: 0x06031722 RID: 202530 RVA: 0x006B408B File Offset: 0x006B228B
		// (set) Token: 0x06031723 RID: 202531 RVA: 0x006B4093 File Offset: 0x006B2293
		public bool IsCleanPasserByNpc { get; set; }

		// Token: 0x1700D138 RID: 53560
		// (get) Token: 0x06031724 RID: 202532 RVA: 0x006B409C File Offset: 0x006B229C
		// (set) Token: 0x06031725 RID: 202533 RVA: 0x006B40A4 File Offset: 0x006B22A4
		public byte NullMask { get; set; }

		// Token: 0x06031726 RID: 202534 RVA: 0x006B40AD File Offset: 0x006B22AD
		public IHideByRangeInFlowT()
		{
			this.Type = ETriggerShape.Box;
			this.Center = null;
			this.Radius = 0;
			this.EntityIds = null;
			this.IsCleanSimpleNpc = false;
			this.IsCleanPasserByNpc = false;
			this.NullMask = 0;
		}
	}
}
