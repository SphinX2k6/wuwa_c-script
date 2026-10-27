using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BB9 RID: 23481
	public class IWuWaGoHintStepInteractT
	{
		// Token: 0x1700B16A RID: 45418
		// (get) Token: 0x06028365 RID: 164709 RVA: 0x0058678A File Offset: 0x0058498A
		// (set) Token: 0x06028366 RID: 164710 RVA: 0x00586792 File Offset: 0x00584992
		public EWuWaGoHintStepType Type { get; set; }

		// Token: 0x06028367 RID: 164711 RVA: 0x0058679B File Offset: 0x0058499B
		public IWuWaGoHintStepInteractT()
		{
			this.Type = EWuWaGoHintStepType.Move;
		}
	}
}
