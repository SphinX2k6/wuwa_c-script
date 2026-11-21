using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E1F RID: 32287
	public class IWindProtagonistParkour4T
	{
		// Token: 0x1700F1CD RID: 61901
		// (get) Token: 0x0603A58B RID: 238987 RVA: 0x007DBEEA File Offset: 0x007DA0EA
		// (set) Token: 0x0603A58C RID: 238988 RVA: 0x007DBEF2 File Offset: 0x007DA0F2
		public ELeisureInteract Type { get; set; }

		// Token: 0x0603A58D RID: 238989 RVA: 0x007DBEFB File Offset: 0x007DA0FB
		public IWindProtagonistParkour4T()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
