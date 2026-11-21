using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DCB RID: 28107
	public class IFaceExpressionConfigDataT
	{
		// Token: 0x1700CE07 RID: 52743
		// (get) Token: 0x06030841 RID: 198721 RVA: 0x00696EA5 File Offset: 0x006950A5
		// (set) Token: 0x06030842 RID: 198722 RVA: 0x00696EAD File Offset: 0x006950AD
		public int Id { get; set; }

		// Token: 0x1700CE08 RID: 52744
		// (get) Token: 0x06030843 RID: 198723 RVA: 0x00696EB6 File Offset: 0x006950B6
		// (set) Token: 0x06030844 RID: 198724 RVA: 0x00696EBE File Offset: 0x006950BE
		public IFaceExpressionConfig_UnionUnion FaceExpression { get; set; }

		// Token: 0x1700CE09 RID: 52745
		// (get) Token: 0x06030845 RID: 198725 RVA: 0x00696EC7 File Offset: 0x006950C7
		// (set) Token: 0x06030846 RID: 198726 RVA: 0x00696ECF File Offset: 0x006950CF
		public IFaceExpressionConfig_UnionUnion MaleVariant { get; set; }

		// Token: 0x1700CE0A RID: 52746
		// (get) Token: 0x06030847 RID: 198727 RVA: 0x00696ED8 File Offset: 0x006950D8
		// (set) Token: 0x06030848 RID: 198728 RVA: 0x00696EE0 File Offset: 0x006950E0
		public bool CloseAutoBlink { get; set; }

		// Token: 0x1700CE0B RID: 52747
		// (get) Token: 0x06030849 RID: 198729 RVA: 0x00696EE9 File Offset: 0x006950E9
		// (set) Token: 0x0603084A RID: 198730 RVA: 0x00696EF1 File Offset: 0x006950F1
		public byte NullMask { get; set; }

		// Token: 0x0603084B RID: 198731 RVA: 0x00696EFA File Offset: 0x006950FA
		public IFaceExpressionConfigDataT()
		{
			this.Id = 0;
			this.FaceExpression = null;
			this.MaleVariant = null;
			this.CloseAutoBlink = false;
			this.NullMask = 0;
		}
	}
}
