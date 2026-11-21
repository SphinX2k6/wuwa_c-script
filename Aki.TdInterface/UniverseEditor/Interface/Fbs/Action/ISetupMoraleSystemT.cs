using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200786D RID: 30829
	public class ISetupMoraleSystemT
	{
		// Token: 0x1700E21A RID: 57882
		// (get) Token: 0x06036387 RID: 222087 RVA: 0x007433DC File Offset: 0x007415DC
		// (set) Token: 0x06036388 RID: 222088 RVA: 0x007433E4 File Offset: 0x007415E4
		public int MoralePlayId { get; set; }

		// Token: 0x1700E21B RID: 57883
		// (get) Token: 0x06036389 RID: 222089 RVA: 0x007433ED File Offset: 0x007415ED
		// (set) Token: 0x0603638A RID: 222090 RVA: 0x007433F5 File Offset: 0x007415F5
		public bool IsOn { get; set; }

		// Token: 0x0603638B RID: 222091 RVA: 0x007433FE File Offset: 0x007415FE
		public ISetupMoraleSystemT()
		{
			this.MoralePlayId = 0;
			this.IsOn = false;
		}
	}
}
