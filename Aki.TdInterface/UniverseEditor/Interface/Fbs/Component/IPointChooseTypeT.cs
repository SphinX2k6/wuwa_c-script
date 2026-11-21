using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D59 RID: 23897
	public class IPointChooseTypeT
	{
		// Token: 0x1700AFED RID: 45037
		// (get) Token: 0x06027C87 RID: 162951 RVA: 0x005715E2 File Offset: 0x0056F7E2
		// (set) Token: 0x06027C88 RID: 162952 RVA: 0x005715EA File Offset: 0x0056F7EA
		public EPointChooseType Type { get; set; }

		// Token: 0x06027C89 RID: 162953 RVA: 0x005715F3 File Offset: 0x0056F7F3
		public IPointChooseTypeT()
		{
			this.Type = EPointChooseType.SpawnMonsterPoint;
		}
	}
}
