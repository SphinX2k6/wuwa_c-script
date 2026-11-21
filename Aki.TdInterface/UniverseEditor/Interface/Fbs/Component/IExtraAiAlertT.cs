using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005779 RID: 22393
	public class IExtraAiAlertT
	{
		// Token: 0x1700A1DE RID: 41438
		// (get) Token: 0x060241D6 RID: 147926 RVA: 0x004F7653 File Offset: 0x004F5853
		// (set) Token: 0x060241D7 RID: 147927 RVA: 0x004F765B File Offset: 0x004F585B
		public int MoveAlert { get; set; }

		// Token: 0x1700A1DF RID: 41439
		// (get) Token: 0x060241D8 RID: 147928 RVA: 0x004F7664 File Offset: 0x004F5864
		// (set) Token: 0x060241D9 RID: 147929 RVA: 0x004F766C File Offset: 0x004F586C
		public int StopAlert { get; set; }

		// Token: 0x1700A1E0 RID: 41440
		// (get) Token: 0x060241DA RID: 147930 RVA: 0x004F7675 File Offset: 0x004F5875
		// (set) Token: 0x060241DB RID: 147931 RVA: 0x004F767D File Offset: 0x004F587D
		public List<IStateAlertT> SelfStateAlert { get; set; }

		// Token: 0x1700A1E1 RID: 41441
		// (get) Token: 0x060241DC RID: 147932 RVA: 0x004F7686 File Offset: 0x004F5886
		// (set) Token: 0x060241DD RID: 147933 RVA: 0x004F768E File Offset: 0x004F588E
		public byte NullMask { get; set; }

		// Token: 0x060241DE RID: 147934 RVA: 0x004F7697 File Offset: 0x004F5897
		public IExtraAiAlertT()
		{
			this.MoveAlert = 0;
			this.StopAlert = 0;
			this.SelfStateAlert = null;
			this.NullMask = 0;
		}
	}
}
