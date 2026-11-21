using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007733 RID: 30515
	public class ISendBattleTagT
	{
		// Token: 0x1700DFB9 RID: 57273
		// (get) Token: 0x060358A9 RID: 219305 RVA: 0x0072D3CE File Offset: 0x0072B5CE
		// (set) Token: 0x060358AA RID: 219306 RVA: 0x0072D3D6 File Offset: 0x0072B5D6
		public int TagConfigId { get; set; }

		// Token: 0x060358AB RID: 219307 RVA: 0x0072D3DF File Offset: 0x0072B5DF
		public ISendBattleTagT()
		{
			this.TagConfigId = 0;
		}
	}
}
