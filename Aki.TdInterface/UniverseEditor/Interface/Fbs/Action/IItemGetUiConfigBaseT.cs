using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069BE RID: 27070
	public class IItemGetUiConfigBaseT
	{
		// Token: 0x1700C8C9 RID: 51401
		// (get) Token: 0x0602F4D1 RID: 193745 RVA: 0x006711AE File Offset: 0x0066F3AE
		// (set) Token: 0x0602F4D2 RID: 193746 RVA: 0x006711B6 File Offset: 0x0066F3B6
		public EItemGetUiType Type { get; set; }

		// Token: 0x0602F4D3 RID: 193747 RVA: 0x006711BF File Offset: 0x0066F3BF
		public IItemGetUiConfigBaseT()
		{
			this.Type = EItemGetUiType.None;
		}
	}
}
