using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005419 RID: 21529
	public class IAxisAngleMethodConfigT
	{
		// Token: 0x1700987A RID: 39034
		// (get) Token: 0x06021ADD RID: 137949 RVA: 0x004A4589 File Offset: 0x004A2789
		// (set) Token: 0x06021ADE RID: 137950 RVA: 0x004A4591 File Offset: 0x004A2791
		public ERotationType Type { get; set; }

		// Token: 0x1700987B RID: 39035
		// (get) Token: 0x06021ADF RID: 137951 RVA: 0x004A459A File Offset: 0x004A279A
		// (set) Token: 0x06021AE0 RID: 137952 RVA: 0x004A45A2 File Offset: 0x004A27A2
		public float Time { get; set; }

		// Token: 0x1700987C RID: 39036
		// (get) Token: 0x06021AE1 RID: 137953 RVA: 0x004A45AB File Offset: 0x004A27AB
		// (set) Token: 0x06021AE2 RID: 137954 RVA: 0x004A45B3 File Offset: 0x004A27B3
		public float Cd { get; set; }

		// Token: 0x1700987D RID: 39037
		// (get) Token: 0x06021AE3 RID: 137955 RVA: 0x004A45BC File Offset: 0x004A27BC
		// (set) Token: 0x06021AE4 RID: 137956 RVA: 0x004A45C4 File Offset: 0x004A27C4
		public string Curve { get; set; }

		// Token: 0x1700987E RID: 39038
		// (get) Token: 0x06021AE5 RID: 137957 RVA: 0x004A45CD File Offset: 0x004A27CD
		// (set) Token: 0x06021AE6 RID: 137958 RVA: 0x004A45D5 File Offset: 0x004A27D5
		public IVectorInfoT Axis { get; set; }

		// Token: 0x1700987F RID: 39039
		// (get) Token: 0x06021AE7 RID: 137959 RVA: 0x004A45DE File Offset: 0x004A27DE
		// (set) Token: 0x06021AE8 RID: 137960 RVA: 0x004A45E6 File Offset: 0x004A27E6
		public float Angle { get; set; }

		// Token: 0x17009880 RID: 39040
		// (get) Token: 0x06021AE9 RID: 137961 RVA: 0x004A45EF File Offset: 0x004A27EF
		// (set) Token: 0x06021AEA RID: 137962 RVA: 0x004A45F7 File Offset: 0x004A27F7
		public byte NullMask { get; set; }

		// Token: 0x06021AEB RID: 137963 RVA: 0x004A4600 File Offset: 0x004A2800
		public IAxisAngleMethodConfigT()
		{
			this.Type = ERotationType.Relative;
			this.Time = 0f;
			this.Cd = 0f;
			this.Curve = null;
			this.Axis = null;
			this.Angle = 0f;
			this.NullMask = 0;
		}
	}
}
