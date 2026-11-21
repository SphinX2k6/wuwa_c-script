using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CB0 RID: 19632
	public class ICustomShapeAreaConflictSelectorT
	{
		// Token: 0x17008B20 RID: 35616
		// (get) Token: 0x0601E1F1 RID: 123377 RVA: 0x004385E9 File Offset: 0x004367E9
		// (set) Token: 0x0601E1F2 RID: 123378 RVA: 0x004385F1 File Offset: 0x004367F1
		public EAreaConflictSelector Type { get; set; }

		// Token: 0x17008B21 RID: 35617
		// (get) Token: 0x0601E1F3 RID: 123379 RVA: 0x004385FA File Offset: 0x004367FA
		// (set) Token: 0x0601E1F4 RID: 123380 RVA: 0x00438602 File Offset: 0x00436802
		public TAreaConflictCheckTriggerShapeUnion Shape { get; set; }

		// Token: 0x17008B22 RID: 35618
		// (get) Token: 0x0601E1F5 RID: 123381 RVA: 0x0043860B File Offset: 0x0043680B
		// (set) Token: 0x0601E1F6 RID: 123382 RVA: 0x00438613 File Offset: 0x00436813
		public IVectorInfoT Rotator { get; set; }

		// Token: 0x0601E1F7 RID: 123383 RVA: 0x0043861C File Offset: 0x0043681C
		public ICustomShapeAreaConflictSelectorT()
		{
			this.Type = EAreaConflictSelector.Quest;
			this.Shape = null;
			this.Rotator = null;
		}
	}
}
