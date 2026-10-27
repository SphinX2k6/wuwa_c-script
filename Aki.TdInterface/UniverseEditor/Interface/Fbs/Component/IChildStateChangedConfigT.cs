using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F9E RID: 20382
	public class IChildStateChangedConfigT
	{
		// Token: 0x17009385 RID: 37765
		// (get) Token: 0x060206A3 RID: 132771 RVA: 0x004827EF File Offset: 0x004809EF
		// (set) Token: 0x060206A4 RID: 132772 RVA: 0x004827F7 File Offset: 0x004809F7
		public string State { get; set; }

		// Token: 0x17009386 RID: 37766
		// (get) Token: 0x060206A5 RID: 132773 RVA: 0x00482800 File Offset: 0x00480A00
		// (set) Token: 0x060206A6 RID: 132774 RVA: 0x00482808 File Offset: 0x00480A08
		public IDelayChangeStateT DelayChangeState { get; set; }

		// Token: 0x060206A7 RID: 132775 RVA: 0x00482811 File Offset: 0x00480A11
		public IChildStateChangedConfigT()
		{
			this.State = null;
			this.DelayChangeState = null;
		}
	}
}
