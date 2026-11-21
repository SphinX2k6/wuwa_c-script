using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007305 RID: 29445
	public class INpcGroupPerformInitiatorTypeT
	{
		// Token: 0x1700D7E5 RID: 55269
		// (get) Token: 0x060335A1 RID: 210337 RVA: 0x006ECDFE File Offset: 0x006EAFFE
		// (set) Token: 0x060335A2 RID: 210338 RVA: 0x006ECE06 File Offset: 0x006EB006
		public ENpcGroupPerformInitiatorType Type { get; set; }

		// Token: 0x060335A3 RID: 210339 RVA: 0x006ECE0F File Offset: 0x006EB00F
		public INpcGroupPerformInitiatorTypeT()
		{
			this.Type = ENpcGroupPerformInitiatorType.Player;
		}
	}
}
