using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B36 RID: 15158
	public class IWoodenBoxProliferateSpawnConfigT
	{
		// Token: 0x17006807 RID: 26631
		// (get) Token: 0x06014B81 RID: 84865 RVA: 0x00303562 File Offset: 0x00301762
		// (set) Token: 0x06014B82 RID: 84866 RVA: 0x0030356A File Offset: 0x0030176A
		public EWoodenBoxProliferateSpawnType Type { get; set; }

		// Token: 0x06014B83 RID: 84867 RVA: 0x00303573 File Offset: 0x00301773
		public IWoodenBoxProliferateSpawnConfigT()
		{
			this.Type = EWoodenBoxProliferateSpawnType.RandomInRange;
		}
	}
}
