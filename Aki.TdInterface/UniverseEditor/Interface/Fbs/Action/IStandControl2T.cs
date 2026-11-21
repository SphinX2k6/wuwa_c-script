using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007981 RID: 31105
	public class IStandControl2T
	{
		// Token: 0x1700E412 RID: 58386
		// (get) Token: 0x06036C84 RID: 224388 RVA: 0x00753DB6 File Offset: 0x00751FB6
		// (set) Token: 0x06036C85 RID: 224389 RVA: 0x00753DBE File Offset: 0x00751FBE
		public ELeisureInteract Type { get; set; }

		// Token: 0x06036C86 RID: 224390 RVA: 0x00753DC7 File Offset: 0x00751FC7
		public IStandControl2T()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
