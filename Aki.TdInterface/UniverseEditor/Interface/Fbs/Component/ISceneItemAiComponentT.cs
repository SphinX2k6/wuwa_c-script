using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058AA RID: 22698
	public class ISceneItemAiComponentT
	{
		// Token: 0x1700A9F7 RID: 43511
		// (get) Token: 0x060264C0 RID: 156864 RVA: 0x00547809 File Offset: 0x00545A09
		// (set) Token: 0x060264C1 RID: 156865 RVA: 0x00547811 File Offset: 0x00545A11
		public bool Disabled { get; set; }

		// Token: 0x1700A9F8 RID: 43512
		// (get) Token: 0x060264C2 RID: 156866 RVA: 0x0054781A File Offset: 0x00545A1A
		// (set) Token: 0x060264C3 RID: 156867 RVA: 0x00547822 File Offset: 0x00545A22
		public ISceneItemPatrolT AiConfig { get; set; }

		// Token: 0x1700A9F9 RID: 43513
		// (get) Token: 0x060264C4 RID: 156868 RVA: 0x0054782B File Offset: 0x00545A2B
		// (set) Token: 0x060264C5 RID: 156869 RVA: 0x00547833 File Offset: 0x00545A33
		public byte NullMask { get; set; }

		// Token: 0x060264C6 RID: 156870 RVA: 0x0054783C File Offset: 0x00545A3C
		public ISceneItemAiComponentT()
		{
			this.Disabled = false;
			this.AiConfig = null;
			this.NullMask = 0;
		}
	}
}
