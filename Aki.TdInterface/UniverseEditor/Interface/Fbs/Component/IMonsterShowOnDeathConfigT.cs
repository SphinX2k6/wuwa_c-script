using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B38 RID: 23352
	public class IMonsterShowOnDeathConfigT
	{
		// Token: 0x1700AA68 RID: 43624
		// (get) Token: 0x06026680 RID: 157312 RVA: 0x00542906 File Offset: 0x00540B06
		// (set) Token: 0x06026681 RID: 157313 RVA: 0x0054290E File Offset: 0x00540B0E
		public EMonsterShowOnDeathType Type { get; set; }

		// Token: 0x06026682 RID: 157314 RVA: 0x00542917 File Offset: 0x00540B17
		public IMonsterShowOnDeathConfigT()
		{
			this.Type = EMonsterShowOnDeathType.Effect;
		}
	}
}
