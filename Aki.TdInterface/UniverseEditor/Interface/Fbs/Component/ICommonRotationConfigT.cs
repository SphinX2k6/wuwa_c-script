using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200552A RID: 21802
	public class ICommonRotationConfigT
	{
		// Token: 0x17009BD9 RID: 39897
		// (get) Token: 0x06022797 RID: 141207 RVA: 0x004BFC4D File Offset: 0x004BDE4D
		// (set) Token: 0x06022798 RID: 141208 RVA: 0x004BFC55 File Offset: 0x004BDE55
		public ERotationType Type { get; set; }

		// Token: 0x17009BDA RID: 39898
		// (get) Token: 0x06022799 RID: 141209 RVA: 0x004BFC5E File Offset: 0x004BDE5E
		// (set) Token: 0x0602279A RID: 141210 RVA: 0x004BFC66 File Offset: 0x004BDE66
		public float Time { get; set; }

		// Token: 0x17009BDB RID: 39899
		// (get) Token: 0x0602279B RID: 141211 RVA: 0x004BFC6F File Offset: 0x004BDE6F
		// (set) Token: 0x0602279C RID: 141212 RVA: 0x004BFC77 File Offset: 0x004BDE77
		public float Cd { get; set; }

		// Token: 0x17009BDC RID: 39900
		// (get) Token: 0x0602279D RID: 141213 RVA: 0x004BFC80 File Offset: 0x004BDE80
		// (set) Token: 0x0602279E RID: 141214 RVA: 0x004BFC88 File Offset: 0x004BDE88
		public string Curve { get; set; }

		// Token: 0x17009BDD RID: 39901
		// (get) Token: 0x0602279F RID: 141215 RVA: 0x004BFC91 File Offset: 0x004BDE91
		// (set) Token: 0x060227A0 RID: 141216 RVA: 0x004BFC99 File Offset: 0x004BDE99
		public byte NullMask { get; set; }

		// Token: 0x060227A1 RID: 141217 RVA: 0x004BFCA2 File Offset: 0x004BDEA2
		public ICommonRotationConfigT()
		{
			this.Type = ERotationType.Relative;
			this.Time = 0f;
			this.Cd = 0f;
			this.Curve = null;
			this.NullMask = 0;
		}
	}
}
