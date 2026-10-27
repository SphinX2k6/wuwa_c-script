using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006511 RID: 25873
	public class ICustomScreenTypeBaseT
	{
		// Token: 0x1700C065 RID: 49253
		// (get) Token: 0x0602CE21 RID: 183841 RVA: 0x0062A16A File Offset: 0x0062836A
		// (set) Token: 0x0602CE22 RID: 183842 RVA: 0x0062A172 File Offset: 0x00628372
		public ECustomScreenType Type { get; set; }

		// Token: 0x0602CE23 RID: 183843 RVA: 0x0062A17B File Offset: 0x0062837B
		public ICustomScreenTypeBaseT()
		{
			this.Type = ECustomScreenType.Spine;
		}
	}
}
