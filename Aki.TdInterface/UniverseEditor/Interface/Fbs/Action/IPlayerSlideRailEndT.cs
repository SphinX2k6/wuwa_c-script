using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D0F RID: 27919
	public class IPlayerSlideRailEndT
	{
		// Token: 0x1700CFE6 RID: 53222
		// (get) Token: 0x060313BA RID: 201658 RVA: 0x006AD95E File Offset: 0x006ABB5E
		// (set) Token: 0x060313BB RID: 201659 RVA: 0x006AD966 File Offset: 0x006ABB66
		public ESlideRailEndType Type { get; set; }

		// Token: 0x060313BC RID: 201660 RVA: 0x006AD96F File Offset: 0x006ABB6F
		public IPlayerSlideRailEndT()
		{
			this.Type = ESlideRailEndType.Player;
		}
	}
}
