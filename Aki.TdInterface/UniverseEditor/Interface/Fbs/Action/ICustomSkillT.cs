using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200651A RID: 25882
	public class ICustomSkillT
	{
		// Token: 0x1700C072 RID: 49266
		// (get) Token: 0x0602CE5F RID: 183903 RVA: 0x0062A7EC File Offset: 0x006289EC
		// (set) Token: 0x0602CE60 RID: 183904 RVA: 0x0062A7F4 File Offset: 0x006289F4
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700C073 RID: 49267
		// (get) Token: 0x0602CE61 RID: 183905 RVA: 0x0062A7FD File Offset: 0x006289FD
		// (set) Token: 0x0602CE62 RID: 183906 RVA: 0x0062A805 File Offset: 0x00628A05
		public int SkillId { get; set; }

		// Token: 0x0602CE63 RID: 183907 RVA: 0x0062A80E File Offset: 0x00628A0E
		public ICustomSkillT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.SkillId = 0;
		}
	}
}
