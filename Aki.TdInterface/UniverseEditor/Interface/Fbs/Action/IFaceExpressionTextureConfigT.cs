using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DD4 RID: 28116
	public class IFaceExpressionTextureConfigT
	{
		// Token: 0x1700CE16 RID: 52758
		// (get) Token: 0x06030887 RID: 198791 RVA: 0x00697584 File Offset: 0x00695784
		// (set) Token: 0x06030888 RID: 198792 RVA: 0x0069758C File Offset: 0x0069578C
		public EFaceExpressionConfigType Type { get; set; }

		// Token: 0x1700CE17 RID: 52759
		// (get) Token: 0x06030889 RID: 198793 RVA: 0x00697595 File Offset: 0x00695795
		// (set) Token: 0x0603088A RID: 198794 RVA: 0x0069759D File Offset: 0x0069579D
		public int FaceIndex { get; set; }

		// Token: 0x0603088B RID: 198795 RVA: 0x006975A6 File Offset: 0x006957A6
		public IFaceExpressionTextureConfigT()
		{
			this.Type = EFaceExpressionConfigType.Morph;
			this.FaceIndex = 0;
		}
	}
}
