using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DC5 RID: 28101
	public class IFaceExpressionAnimSequenceConfigT
	{
		// Token: 0x1700CDFC RID: 52732
		// (get) Token: 0x06030805 RID: 198661 RVA: 0x00696523 File Offset: 0x00694723
		// (set) Token: 0x06030806 RID: 198662 RVA: 0x0069652B File Offset: 0x0069472B
		public EFaceExpressionConfigType Type { get; set; }

		// Token: 0x1700CDFD RID: 52733
		// (get) Token: 0x06030807 RID: 198663 RVA: 0x00696534 File Offset: 0x00694734
		// (set) Token: 0x06030808 RID: 198664 RVA: 0x0069653C File Offset: 0x0069473C
		public string Path { get; set; }

		// Token: 0x06030809 RID: 198665 RVA: 0x00696545 File Offset: 0x00694745
		public IFaceExpressionAnimSequenceConfigT()
		{
			this.Type = EFaceExpressionConfigType.Morph;
			this.Path = null;
		}
	}
}
