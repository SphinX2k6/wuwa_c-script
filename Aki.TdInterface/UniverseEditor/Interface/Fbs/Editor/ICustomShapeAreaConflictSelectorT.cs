using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004848 RID: 18504
	public class ICustomShapeAreaConflictSelectorT
	{
		// Token: 0x170084D5 RID: 34005
		// (get) Token: 0x0601C9F4 RID: 117236 RVA: 0x0040BC99 File Offset: 0x00409E99
		// (set) Token: 0x0601C9F5 RID: 117237 RVA: 0x0040BCA1 File Offset: 0x00409EA1
		public EAreaConflictSelector Type { get; set; }

		// Token: 0x170084D6 RID: 34006
		// (get) Token: 0x0601C9F6 RID: 117238 RVA: 0x0040BCAA File Offset: 0x00409EAA
		// (set) Token: 0x0601C9F7 RID: 117239 RVA: 0x0040BCB2 File Offset: 0x00409EB2
		public TAreaConflictCheckTriggerShapeUnion Shape { get; set; }

		// Token: 0x170084D7 RID: 34007
		// (get) Token: 0x0601C9F8 RID: 117240 RVA: 0x0040BCBB File Offset: 0x00409EBB
		// (set) Token: 0x0601C9F9 RID: 117241 RVA: 0x0040BCC3 File Offset: 0x00409EC3
		public IVectorInfoT Rotator { get; set; }

		// Token: 0x0601C9FA RID: 117242 RVA: 0x0040BCCC File Offset: 0x00409ECC
		public ICustomShapeAreaConflictSelectorT()
		{
			this.Type = EAreaConflictSelector.Quest;
			this.Shape = null;
			this.Rotator = null;
		}
	}
}
