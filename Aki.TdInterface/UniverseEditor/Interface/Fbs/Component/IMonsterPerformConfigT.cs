using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005597 RID: 21911
	public class IMonsterPerformConfigT
	{
		// Token: 0x1700A1DD RID: 41437
		// (get) Token: 0x06024461 RID: 148577 RVA: 0x00502201 File Offset: 0x00500401
		// (set) Token: 0x06024462 RID: 148578 RVA: 0x00502209 File Offset: 0x00500409
		public IMonsterShowOnDeathEffectT ShowOnDeath { get; set; }

		// Token: 0x06024463 RID: 148579 RVA: 0x00502212 File Offset: 0x00500412
		public IMonsterPerformConfigT()
		{
			this.ShowOnDeath = null;
		}
	}
}
