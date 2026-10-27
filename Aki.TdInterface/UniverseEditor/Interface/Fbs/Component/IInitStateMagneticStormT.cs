using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005426 RID: 21542
	public class IInitStateMagneticStormT
	{
		// Token: 0x17009E71 RID: 40561
		// (get) Token: 0x06023619 RID: 144921 RVA: 0x004E5402 File Offset: 0x004E3602
		// (set) Token: 0x0602361A RID: 144922 RVA: 0x004E540A File Offset: 0x004E360A
		public EInitStateType Type { get; set; }

		// Token: 0x0602361B RID: 144923 RVA: 0x004E5413 File Offset: 0x004E3613
		public IInitStateMagneticStormT()
		{
			this.Type = EInitStateType.Birth;
		}
	}
}
