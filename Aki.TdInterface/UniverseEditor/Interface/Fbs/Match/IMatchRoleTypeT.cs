using System;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x02004401 RID: 17409
	public class IMatchRoleTypeT
	{
		// Token: 0x17007AD9 RID: 31449
		// (get) Token: 0x06019EBA RID: 106170 RVA: 0x003B5396 File Offset: 0x003B3596
		// (set) Token: 0x06019EBB RID: 106171 RVA: 0x003B539E File Offset: 0x003B359E
		public EMatchRoleType Type { get; set; }

		// Token: 0x06019EBC RID: 106172 RVA: 0x003B53A7 File Offset: 0x003B35A7
		public IMatchRoleTypeT()
		{
			this.Type = EMatchRoleType.Player;
		}
	}
}
