using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B35 RID: 23349
	public class IMonsterPerformConfigT
	{
		// Token: 0x1700AA65 RID: 43621
		// (get) Token: 0x0602666E RID: 157294 RVA: 0x00542779 File Offset: 0x00540979
		// (set) Token: 0x0602666F RID: 157295 RVA: 0x00542781 File Offset: 0x00540981
		public IMonsterShowOnDeathEffectT ShowOnDeath { get; set; }

		// Token: 0x06026670 RID: 157296 RVA: 0x0054278A File Offset: 0x0054098A
		public IMonsterPerformConfigT()
		{
			this.ShowOnDeath = null;
		}
	}
}
