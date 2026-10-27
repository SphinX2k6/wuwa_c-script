using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ABE RID: 15038
	public class IRequiredVector2T
	{
		// Token: 0x1700672B RID: 26411
		// (get) Token: 0x06014734 RID: 83764 RVA: 0x002FAF04 File Offset: 0x002F9104
		// (set) Token: 0x06014735 RID: 83765 RVA: 0x002FAF0C File Offset: 0x002F910C
		public float X { get; set; }

		// Token: 0x1700672C RID: 26412
		// (get) Token: 0x06014736 RID: 83766 RVA: 0x002FAF15 File Offset: 0x002F9115
		// (set) Token: 0x06014737 RID: 83767 RVA: 0x002FAF1D File Offset: 0x002F911D
		public float Y { get; set; }

		// Token: 0x06014738 RID: 83768 RVA: 0x002FAF26 File Offset: 0x002F9126
		public IRequiredVector2T()
		{
			this.X = 0f;
			this.Y = 0f;
		}
	}
}
