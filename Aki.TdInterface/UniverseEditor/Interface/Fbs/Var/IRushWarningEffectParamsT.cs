using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AC1 RID: 15041
	public class IRushWarningEffectParamsT
	{
		// Token: 0x17006732 RID: 26418
		// (get) Token: 0x0601474E RID: 83790 RVA: 0x002FB1D8 File Offset: 0x002F93D8
		// (set) Token: 0x0601474F RID: 83791 RVA: 0x002FB1E0 File Offset: 0x002F93E0
		public EParamsPreset Type { get; set; }

		// Token: 0x17006733 RID: 26419
		// (get) Token: 0x06014750 RID: 83792 RVA: 0x002FB1E9 File Offset: 0x002F93E9
		// (set) Token: 0x06014751 RID: 83793 RVA: 0x002FB1F1 File Offset: 0x002F93F1
		public int Length { get; set; }

		// Token: 0x17006734 RID: 26420
		// (get) Token: 0x06014752 RID: 83794 RVA: 0x002FB1FA File Offset: 0x002F93FA
		// (set) Token: 0x06014753 RID: 83795 RVA: 0x002FB202 File Offset: 0x002F9402
		public int Width { get; set; }

		// Token: 0x17006735 RID: 26421
		// (get) Token: 0x06014754 RID: 83796 RVA: 0x002FB20B File Offset: 0x002F940B
		// (set) Token: 0x06014755 RID: 83797 RVA: 0x002FB213 File Offset: 0x002F9413
		public float Time { get; set; }

		// Token: 0x06014756 RID: 83798 RVA: 0x002FB21C File Offset: 0x002F941C
		public IRushWarningEffectParamsT()
		{
			this.Type = EParamsPreset.Decal;
			this.Length = 0;
			this.Width = 0;
			this.Time = 0f;
		}
	}
}
