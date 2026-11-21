using System;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x02004869 RID: 18537
	public class IMatchRoleTypeT
	{
		// Token: 0x17008118 RID: 33048
		// (get) Token: 0x0601B687 RID: 112263 RVA: 0x003E1512 File Offset: 0x003DF712
		// (set) Token: 0x0601B688 RID: 112264 RVA: 0x003E151A File Offset: 0x003DF71A
		public EMatchRoleType Type { get; set; }

		// Token: 0x0601B689 RID: 112265 RVA: 0x003E1523 File Offset: 0x003DF723
		public IMatchRoleTypeT()
		{
			this.Type = EMatchRoleType.Player;
		}
	}
}
