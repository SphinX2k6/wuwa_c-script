using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F72 RID: 28530
	public class IHandInHandInitiatorTypeT
	{
		// Token: 0x1700D101 RID: 53505
		// (get) Token: 0x06031626 RID: 202278 RVA: 0x006B283A File Offset: 0x006B0A3A
		// (set) Token: 0x06031627 RID: 202279 RVA: 0x006B2842 File Offset: 0x006B0A42
		public EHandInHandInitiatorType Type { get; set; }

		// Token: 0x06031628 RID: 202280 RVA: 0x006B284B File Offset: 0x006B0A4B
		public IHandInHandInitiatorTypeT()
		{
			this.Type = EHandInHandInitiatorType.Player;
		}
	}
}
