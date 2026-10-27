using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055D6 RID: 21974
	public class IMoveComponentT
	{
		// Token: 0x1700A28F RID: 41615
		// (get) Token: 0x060246FD RID: 149245 RVA: 0x00507A1A File Offset: 0x00505C1A
		// (set) Token: 0x060246FE RID: 149246 RVA: 0x00507A22 File Offset: 0x00505C22
		public bool Disabled { get; set; }

		// Token: 0x1700A290 RID: 41616
		// (get) Token: 0x060246FF RID: 149247 RVA: 0x00507A2B File Offset: 0x00505C2B
		// (set) Token: 0x06024700 RID: 149248 RVA: 0x00507A33 File Offset: 0x00505C33
		public float InitSpeed { get; set; }

		// Token: 0x1700A291 RID: 41617
		// (get) Token: 0x06024701 RID: 149249 RVA: 0x00507A3C File Offset: 0x00505C3C
		// (set) Token: 0x06024702 RID: 149250 RVA: 0x00507A44 File Offset: 0x00505C44
		public byte NullMask { get; set; }

		// Token: 0x06024703 RID: 149251 RVA: 0x00507A4D File Offset: 0x00505C4D
		public IMoveComponentT()
		{
			this.Disabled = false;
			this.InitSpeed = 0f;
			this.NullMask = 0;
		}
	}
}
