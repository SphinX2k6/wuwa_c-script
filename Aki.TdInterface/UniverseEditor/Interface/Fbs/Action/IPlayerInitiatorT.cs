using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007472 RID: 29810
	public class IPlayerInitiatorT
	{
		// Token: 0x1700DB04 RID: 56068
		// (get) Token: 0x060342FB RID: 213755 RVA: 0x00707ACE File Offset: 0x00705CCE
		// (set) Token: 0x060342FC RID: 213756 RVA: 0x00707AD6 File Offset: 0x00705CD6
		public ENpcGroupPerformInitiatorType Type { get; set; }

		// Token: 0x060342FD RID: 213757 RVA: 0x00707ADF File Offset: 0x00705CDF
		public IPlayerInitiatorT()
		{
			this.Type = ENpcGroupPerformInitiatorType.Player;
		}
	}
}
