using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200559A RID: 21914
	public class IMonsterShowOnDeathConfigT
	{
		// Token: 0x1700A1E0 RID: 41440
		// (get) Token: 0x06024473 RID: 148595 RVA: 0x0050238E File Offset: 0x0050058E
		// (set) Token: 0x06024474 RID: 148596 RVA: 0x00502396 File Offset: 0x00500596
		public EMonsterShowOnDeathType Type { get; set; }

		// Token: 0x06024475 RID: 148597 RVA: 0x0050239F File Offset: 0x0050059F
		public IMonsterShowOnDeathConfigT()
		{
			this.Type = EMonsterShowOnDeathType.Effect;
		}
	}
}
