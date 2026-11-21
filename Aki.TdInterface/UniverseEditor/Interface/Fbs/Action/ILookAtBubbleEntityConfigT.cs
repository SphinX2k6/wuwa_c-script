using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200717C RID: 29052
	public class ILookAtBubbleEntityConfigT
	{
		// Token: 0x1700D4A5 RID: 54437
		// (get) Token: 0x060327FA RID: 206842 RVA: 0x006D32F1 File Offset: 0x006D14F1
		// (set) Token: 0x060327FB RID: 206843 RVA: 0x006D32F9 File Offset: 0x006D14F9
		public int BubbleEntity { get; set; }

		// Token: 0x1700D4A6 RID: 54438
		// (get) Token: 0x060327FC RID: 206844 RVA: 0x006D3302 File Offset: 0x006D1502
		// (set) Token: 0x060327FD RID: 206845 RVA: 0x006D330A File Offset: 0x006D150A
		public List<int> RangeEntities { get; set; }

		// Token: 0x1700D4A7 RID: 54439
		// (get) Token: 0x060327FE RID: 206846 RVA: 0x006D3313 File Offset: 0x006D1513
		// (set) Token: 0x060327FF RID: 206847 RVA: 0x006D331B File Offset: 0x006D151B
		public IEntityLookAtPerformT EntityLookAtPerform { get; set; }

		// Token: 0x06032800 RID: 206848 RVA: 0x006D3324 File Offset: 0x006D1524
		public ILookAtBubbleEntityConfigT()
		{
			this.BubbleEntity = 0;
			this.RangeEntities = null;
			this.EntityLookAtPerform = null;
		}
	}
}
