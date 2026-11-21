using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A8D RID: 23181
	public class ILiftMoveCurveT
	{
		// Token: 0x1700A8EF RID: 43247
		// (get) Token: 0x06025FF1 RID: 155633 RVA: 0x005355B7 File Offset: 0x005337B7
		// (set) Token: 0x06025FF2 RID: 155634 RVA: 0x005355BF File Offset: 0x005337BF
		public string Curve { get; set; }

		// Token: 0x1700A8F0 RID: 43248
		// (get) Token: 0x06025FF3 RID: 155635 RVA: 0x005355C8 File Offset: 0x005337C8
		// (set) Token: 0x06025FF4 RID: 155636 RVA: 0x005355D0 File Offset: 0x005337D0
		public float Time { get; set; }

		// Token: 0x06025FF5 RID: 155637 RVA: 0x005355D9 File Offset: 0x005337D9
		public ILiftMoveCurveT()
		{
			this.Curve = null;
			this.Time = 0f;
		}
	}
}
