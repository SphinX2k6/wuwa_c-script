using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006745 RID: 26437
	public class IFaceExpressionAnimSequenceConfigT
	{
		// Token: 0x1700C446 RID: 50246
		// (get) Token: 0x0602DFBF RID: 188351 RVA: 0x00648DDF File Offset: 0x00646FDF
		// (set) Token: 0x0602DFC0 RID: 188352 RVA: 0x00648DE7 File Offset: 0x00646FE7
		public EFaceExpressionConfigType Type { get; set; }

		// Token: 0x1700C447 RID: 50247
		// (get) Token: 0x0602DFC1 RID: 188353 RVA: 0x00648DF0 File Offset: 0x00646FF0
		// (set) Token: 0x0602DFC2 RID: 188354 RVA: 0x00648DF8 File Offset: 0x00646FF8
		public string Path { get; set; }

		// Token: 0x0602DFC3 RID: 188355 RVA: 0x00648E01 File Offset: 0x00647001
		public IFaceExpressionAnimSequenceConfigT()
		{
			this.Type = EFaceExpressionConfigType.Morph;
			this.Path = null;
		}
	}
}
