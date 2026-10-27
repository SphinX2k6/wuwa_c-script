using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BC8 RID: 27592
	public class INpcLookAtConfigT
	{
		// Token: 0x1700CD0E RID: 52494
		// (get) Token: 0x06030796 RID: 198550 RVA: 0x00695241 File Offset: 0x00693441
		// (set) Token: 0x06030797 RID: 198551 RVA: 0x00695249 File Offset: 0x00693449
		public TNpcLookAtTypeUnion Target { get; set; }

		// Token: 0x1700CD0F RID: 52495
		// (get) Token: 0x06030798 RID: 198552 RVA: 0x00695252 File Offset: 0x00693452
		// (set) Token: 0x06030799 RID: 198553 RVA: 0x0069525A File Offset: 0x0069345A
		public bool IsKeepOverAngle { get; set; }

		// Token: 0x1700CD10 RID: 52496
		// (get) Token: 0x0603079A RID: 198554 RVA: 0x00695263 File Offset: 0x00693463
		// (set) Token: 0x0603079B RID: 198555 RVA: 0x0069526B File Offset: 0x0069346B
		public float MaxDistance { get; set; }

		// Token: 0x1700CD11 RID: 52497
		// (get) Token: 0x0603079C RID: 198556 RVA: 0x00695274 File Offset: 0x00693474
		// (set) Token: 0x0603079D RID: 198557 RVA: 0x0069527C File Offset: 0x0069347C
		public float MaxAngle { get; set; }

		// Token: 0x1700CD12 RID: 52498
		// (get) Token: 0x0603079E RID: 198558 RVA: 0x00695285 File Offset: 0x00693485
		// (set) Token: 0x0603079F RID: 198559 RVA: 0x0069528D File Offset: 0x0069348D
		public byte NullMask { get; set; }

		// Token: 0x060307A0 RID: 198560 RVA: 0x00695296 File Offset: 0x00693496
		public INpcLookAtConfigT()
		{
			this.Target = null;
			this.IsKeepOverAngle = false;
			this.MaxDistance = 0f;
			this.MaxAngle = 0f;
			this.NullMask = 0;
		}
	}
}
