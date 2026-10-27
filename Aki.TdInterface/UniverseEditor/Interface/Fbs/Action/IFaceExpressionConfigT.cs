using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006748 RID: 26440
	public class IFaceExpressionConfigT
	{
		// Token: 0x1700C44A RID: 50250
		// (get) Token: 0x0602DFD3 RID: 188371 RVA: 0x00648F7A File Offset: 0x0064717A
		// (set) Token: 0x0602DFD4 RID: 188372 RVA: 0x00648F82 File Offset: 0x00647182
		public EFaceExpressionConfigType Type { get; set; }

		// Token: 0x0602DFD5 RID: 188373 RVA: 0x00648F8B File Offset: 0x0064718B
		public IFaceExpressionConfigT()
		{
			this.Type = EFaceExpressionConfigType.Morph;
		}
	}
}
