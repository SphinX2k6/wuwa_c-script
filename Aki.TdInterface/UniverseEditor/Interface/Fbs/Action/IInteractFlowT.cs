using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200703B RID: 28731
	public class IInteractFlowT
	{
		// Token: 0x1700D25E RID: 53854
		// (get) Token: 0x06031CC0 RID: 203968 RVA: 0x006BDA73 File Offset: 0x006BBC73
		// (set) Token: 0x06031CC1 RID: 203969 RVA: 0x006BDA7B File Offset: 0x006BBC7B
		public EInteractOption Type { get; set; }

		// Token: 0x1700D25F RID: 53855
		// (get) Token: 0x06031CC2 RID: 203970 RVA: 0x006BDA84 File Offset: 0x006BBC84
		// (set) Token: 0x06031CC3 RID: 203971 RVA: 0x006BDA8C File Offset: 0x006BBC8C
		public IPlayFlowT Flow { get; set; }

		// Token: 0x06031CC4 RID: 203972 RVA: 0x006BDA95 File Offset: 0x006BBC95
		public IInteractFlowT()
		{
			this.Type = EInteractOption.Flow;
			this.Flow = null;
		}
	}
}
