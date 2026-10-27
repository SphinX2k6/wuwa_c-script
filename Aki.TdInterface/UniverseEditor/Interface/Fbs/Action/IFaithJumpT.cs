using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200679C RID: 26524
	public class IFaithJumpT
	{
		// Token: 0x1700C4E5 RID: 50405
		// (get) Token: 0x0602E27A RID: 189050 RVA: 0x0064DD42 File Offset: 0x0064BF42
		// (set) Token: 0x0602E27B RID: 189051 RVA: 0x0064DD4A File Offset: 0x0064BF4A
		public ELeisureInteract Type { get; set; }

		// Token: 0x0602E27C RID: 189052 RVA: 0x0064DD53 File Offset: 0x0064BF53
		public IFaithJumpT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
