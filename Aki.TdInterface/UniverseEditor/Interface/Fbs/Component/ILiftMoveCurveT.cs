using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005507 RID: 21767
	public class ILiftMoveCurveT
	{
		// Token: 0x1700A0B5 RID: 41141
		// (get) Token: 0x06023F37 RID: 147255 RVA: 0x004F8493 File Offset: 0x004F6693
		// (set) Token: 0x06023F38 RID: 147256 RVA: 0x004F849B File Offset: 0x004F669B
		public string Curve { get; set; }

		// Token: 0x1700A0B6 RID: 41142
		// (get) Token: 0x06023F39 RID: 147257 RVA: 0x004F84A4 File Offset: 0x004F66A4
		// (set) Token: 0x06023F3A RID: 147258 RVA: 0x004F84AC File Offset: 0x004F66AC
		public float Time { get; set; }

		// Token: 0x06023F3B RID: 147259 RVA: 0x004F84B5 File Offset: 0x004F66B5
		public ILiftMoveCurveT()
		{
			this.Curve = null;
			this.Time = 0f;
		}
	}
}
