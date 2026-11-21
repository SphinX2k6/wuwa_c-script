using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004930 RID: 18736
	public class IFindSunSpiritLevelConfigT
	{
		// Token: 0x17008287 RID: 33415
		// (get) Token: 0x0601BCDD RID: 113885 RVA: 0x003EE103 File Offset: 0x003EC303
		// (set) Token: 0x0601BCDE RID: 113886 RVA: 0x003EE10B File Offset: 0x003EC30B
		public IFindSunSpiritGridConfigT GridConfig { get; set; }

		// Token: 0x17008288 RID: 33416
		// (get) Token: 0x0601BCDF RID: 113887 RVA: 0x003EE114 File Offset: 0x003EC314
		// (set) Token: 0x0601BCE0 RID: 113888 RVA: 0x003EE11C File Offset: 0x003EC31C
		public int MaxJumpHeight { get; set; }

		// Token: 0x17008289 RID: 33417
		// (get) Token: 0x0601BCE1 RID: 113889 RVA: 0x003EE125 File Offset: 0x003EC325
		// (set) Token: 0x0601BCE2 RID: 113890 RVA: 0x003EE12D File Offset: 0x003EC32D
		public int MaxTimes { get; set; }

		// Token: 0x1700828A RID: 33418
		// (get) Token: 0x0601BCE3 RID: 113891 RVA: 0x003EE136 File Offset: 0x003EC336
		// (set) Token: 0x0601BCE4 RID: 113892 RVA: 0x003EE13E File Offset: 0x003EC33E
		public byte NullMask { get; set; }

		// Token: 0x0601BCE5 RID: 113893 RVA: 0x003EE147 File Offset: 0x003EC347
		public IFindSunSpiritLevelConfigT()
		{
			this.GridConfig = null;
			this.MaxJumpHeight = 0;
			this.MaxTimes = 0;
			this.NullMask = 0;
		}
	}
}
