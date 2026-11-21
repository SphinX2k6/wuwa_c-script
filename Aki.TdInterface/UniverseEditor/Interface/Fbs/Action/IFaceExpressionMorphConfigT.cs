using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DD1 RID: 28113
	public class IFaceExpressionMorphConfigT
	{
		// Token: 0x1700CE11 RID: 52753
		// (get) Token: 0x06030871 RID: 198769 RVA: 0x00697387 File Offset: 0x00695587
		// (set) Token: 0x06030872 RID: 198770 RVA: 0x0069738F File Offset: 0x0069558F
		public EFaceExpressionConfigType Type { get; set; }

		// Token: 0x1700CE12 RID: 52754
		// (get) Token: 0x06030873 RID: 198771 RVA: 0x00697398 File Offset: 0x00695598
		// (set) Token: 0x06030874 RID: 198772 RVA: 0x006973A0 File Offset: 0x006955A0
		public string MorphData { get; set; }

		// Token: 0x06030875 RID: 198773 RVA: 0x006973A9 File Offset: 0x006955A9
		public IFaceExpressionMorphConfigT()
		{
			this.Type = EFaceExpressionConfigType.Morph;
			this.MorphData = null;
		}
	}
}
