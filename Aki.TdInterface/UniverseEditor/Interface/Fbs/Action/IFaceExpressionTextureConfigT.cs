using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006754 RID: 26452
	public class IFaceExpressionTextureConfigT
	{
		// Token: 0x1700C460 RID: 50272
		// (get) Token: 0x0602E041 RID: 188481 RVA: 0x00649E40 File Offset: 0x00648040
		// (set) Token: 0x0602E042 RID: 188482 RVA: 0x00649E48 File Offset: 0x00648048
		public EFaceExpressionConfigType Type { get; set; }

		// Token: 0x1700C461 RID: 50273
		// (get) Token: 0x0602E043 RID: 188483 RVA: 0x00649E51 File Offset: 0x00648051
		// (set) Token: 0x0602E044 RID: 188484 RVA: 0x00649E59 File Offset: 0x00648059
		public int FaceIndex { get; set; }

		// Token: 0x0602E045 RID: 188485 RVA: 0x00649E62 File Offset: 0x00648062
		public IFaceExpressionTextureConfigT()
		{
			this.Type = EFaceExpressionConfigType.Morph;
			this.FaceIndex = 0;
		}
	}
}
