using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006751 RID: 26449
	public class IFaceExpressionMorphConfigT
	{
		// Token: 0x1700C45B RID: 50267
		// (get) Token: 0x0602E02B RID: 188459 RVA: 0x00649C43 File Offset: 0x00647E43
		// (set) Token: 0x0602E02C RID: 188460 RVA: 0x00649C4B File Offset: 0x00647E4B
		public EFaceExpressionConfigType Type { get; set; }

		// Token: 0x1700C45C RID: 50268
		// (get) Token: 0x0602E02D RID: 188461 RVA: 0x00649C54 File Offset: 0x00647E54
		// (set) Token: 0x0602E02E RID: 188462 RVA: 0x00649C5C File Offset: 0x00647E5C
		public string MorphData { get; set; }

		// Token: 0x0602E02F RID: 188463 RVA: 0x00649C65 File Offset: 0x00647E65
		public IFaceExpressionMorphConfigT()
		{
			this.Type = EFaceExpressionConfigType.Morph;
			this.MorphData = null;
		}
	}
}
