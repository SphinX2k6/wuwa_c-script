using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B33 RID: 15155
	public class IWoodenBoxProliferateRandomInRangeT
	{
		// Token: 0x17006802 RID: 26626
		// (get) Token: 0x06014B6B RID: 84843 RVA: 0x0030338E File Offset: 0x0030158E
		// (set) Token: 0x06014B6C RID: 84844 RVA: 0x00303396 File Offset: 0x00301596
		public EWoodenBoxProliferateSpawnType Type { get; set; }

		// Token: 0x17006803 RID: 26627
		// (get) Token: 0x06014B6D RID: 84845 RVA: 0x0030339F File Offset: 0x0030159F
		// (set) Token: 0x06014B6E RID: 84846 RVA: 0x003033A7 File Offset: 0x003015A7
		public float RangeRadius { get; set; }

		// Token: 0x17006804 RID: 26628
		// (get) Token: 0x06014B6F RID: 84847 RVA: 0x003033B0 File Offset: 0x003015B0
		// (set) Token: 0x06014B70 RID: 84848 RVA: 0x003033B8 File Offset: 0x003015B8
		public int Count { get; set; }

		// Token: 0x06014B71 RID: 84849 RVA: 0x003033C1 File Offset: 0x003015C1
		public IWoodenBoxProliferateRandomInRangeT()
		{
			this.Type = EWoodenBoxProliferateSpawnType.RandomInRange;
			this.RangeRadius = 0f;
			this.Count = 0;
		}
	}
}
