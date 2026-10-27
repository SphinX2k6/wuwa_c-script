using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005423 RID: 21539
	public class IInitStateDigitalT
	{
		// Token: 0x17009E6E RID: 40558
		// (get) Token: 0x06023607 RID: 144903 RVA: 0x004E528A File Offset: 0x004E348A
		// (set) Token: 0x06023608 RID: 144904 RVA: 0x004E5292 File Offset: 0x004E3492
		public EInitStateType Type { get; set; }

		// Token: 0x06023609 RID: 144905 RVA: 0x004E529B File Offset: 0x004E349B
		public IInitStateDigitalT()
		{
			this.Type = EInitStateType.Birth;
		}
	}
}
