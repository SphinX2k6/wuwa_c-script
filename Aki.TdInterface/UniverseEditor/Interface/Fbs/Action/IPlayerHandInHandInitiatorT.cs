using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200746F RID: 29807
	public class IPlayerHandInHandInitiatorT
	{
		// Token: 0x1700DB01 RID: 56065
		// (get) Token: 0x060342E9 RID: 213737 RVA: 0x00707956 File Offset: 0x00705B56
		// (set) Token: 0x060342EA RID: 213738 RVA: 0x0070795E File Offset: 0x00705B5E
		public EHandInHandInitiatorType Type { get; set; }

		// Token: 0x060342EB RID: 213739 RVA: 0x00707967 File Offset: 0x00705B67
		public IPlayerHandInHandInitiatorT()
		{
			this.Type = EHandInHandInitiatorType.Player;
		}
	}
}
