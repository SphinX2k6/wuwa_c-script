using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F38 RID: 16184
	public class IWoodenBoxProliferateSpawnConfigT
	{
		// Token: 0x17006DA2 RID: 28066
		// (get) Token: 0x0601602B RID: 90155 RVA: 0x003297F2 File Offset: 0x003279F2
		// (set) Token: 0x0601602C RID: 90156 RVA: 0x003297FA File Offset: 0x003279FA
		public EWoodenBoxProliferateSpawnType Type { get; set; }

		// Token: 0x0601602D RID: 90157 RVA: 0x00329803 File Offset: 0x00327A03
		public IWoodenBoxProliferateSpawnConfigT()
		{
			this.Type = EWoodenBoxProliferateSpawnType.RandomInRange;
		}
	}
}
