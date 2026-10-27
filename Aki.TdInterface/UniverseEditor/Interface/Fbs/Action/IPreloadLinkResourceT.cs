using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D96 RID: 28054
	public class IPreloadLinkResourceT
	{
		// Token: 0x1700D144 RID: 53572
		// (get) Token: 0x060318EB RID: 202987 RVA: 0x006B7824 File Offset: 0x006B5A24
		// (set) Token: 0x060318EC RID: 202988 RVA: 0x006B782C File Offset: 0x006B5A2C
		public EPreloadObjectType Type { get; set; }

		// Token: 0x1700D145 RID: 53573
		// (get) Token: 0x060318ED RID: 202989 RVA: 0x006B7835 File Offset: 0x006B5A35
		// (set) Token: 0x060318EE RID: 202990 RVA: 0x006B783D File Offset: 0x006B5A3D
		public int LinkResourceId { get; set; }

		// Token: 0x060318EF RID: 202991 RVA: 0x006B7846 File Offset: 0x006B5A46
		public IPreloadLinkResourceT()
		{
			this.Type = EPreloadObjectType.PreloadTrialCharacterForSkill;
			this.LinkResourceId = 0;
		}
	}
}
