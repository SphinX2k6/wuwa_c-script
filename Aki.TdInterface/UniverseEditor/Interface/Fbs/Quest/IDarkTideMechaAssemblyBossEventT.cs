using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041F4 RID: 16884
	public class IDarkTideMechaAssemblyBossEventT
	{
		// Token: 0x170072FD RID: 29437
		// (get) Token: 0x060176F0 RID: 95984 RVA: 0x003591C6 File Offset: 0x003573C6
		// (set) Token: 0x060176F1 RID: 95985 RVA: 0x003591CE File Offset: 0x003573CE
		public EDarkTideBossEventType Type { get; set; }

		// Token: 0x060176F2 RID: 95986 RVA: 0x003591D7 File Offset: 0x003573D7
		public IDarkTideMechaAssemblyBossEventT()
		{
			this.Type = EDarkTideBossEventType.XinjilemuChase;
		}
	}
}
