using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050C1 RID: 20673
	public class IDropComponentT
	{
		// Token: 0x17009672 RID: 38514
		// (get) Token: 0x06021409 RID: 136201 RVA: 0x0049EA1C File Offset: 0x0049CC1C
		// (set) Token: 0x0602140A RID: 136202 RVA: 0x0049EA24 File Offset: 0x0049CC24
		public bool Disabled { get; set; }

		// Token: 0x17009673 RID: 38515
		// (get) Token: 0x0602140B RID: 136203 RVA: 0x0049EA2D File Offset: 0x0049CC2D
		// (set) Token: 0x0602140C RID: 136204 RVA: 0x0049EA35 File Offset: 0x0049CC35
		public byte NullMask { get; set; }

		// Token: 0x0602140D RID: 136205 RVA: 0x0049EA3E File Offset: 0x0049CC3E
		public IDropComponentT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}
