using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F04 RID: 28420
	public class IRotatorEntityT
	{
		// Token: 0x1700D358 RID: 54104
		// (get) Token: 0x06032374 RID: 205684 RVA: 0x006C8F2D File Offset: 0x006C712D
		// (set) Token: 0x06032375 RID: 205685 RVA: 0x006C8F35 File Offset: 0x006C7135
		public TTargetEntityUnion Entity { get; set; }

		// Token: 0x06032376 RID: 205686 RVA: 0x006C8F3E File Offset: 0x006C713E
		public IRotatorEntityT()
		{
			this.Entity = null;
		}
	}
}
