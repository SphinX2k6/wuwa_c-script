using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E10 RID: 15888
	public class IEntityStateConditionT
	{
		// Token: 0x17006DD3 RID: 28115
		// (get) Token: 0x060163CC RID: 91084 RVA: 0x00335CC3 File Offset: 0x00333EC3
		// (set) Token: 0x060163CD RID: 91085 RVA: 0x00335CCB File Offset: 0x00333ECB
		public int EntityId { get; set; }

		// Token: 0x17006DD4 RID: 28116
		// (get) Token: 0x060163CE RID: 91086 RVA: 0x00335CD4 File Offset: 0x00333ED4
		// (set) Token: 0x060163CF RID: 91087 RVA: 0x00335CDC File Offset: 0x00333EDC
		public string State { get; set; }

		// Token: 0x060163D0 RID: 91088 RVA: 0x00335CE5 File Offset: 0x00333EE5
		public IEntityStateConditionT()
		{
			this.EntityId = 0;
			this.State = null;
		}
	}
}
