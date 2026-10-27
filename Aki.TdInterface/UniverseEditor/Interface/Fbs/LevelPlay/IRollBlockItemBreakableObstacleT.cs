using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004597 RID: 17815
	public class IRollBlockItemBreakableObstacleT
	{
		// Token: 0x17007E8E RID: 32398
		// (get) Token: 0x0601AE9D RID: 110237 RVA: 0x003D6F61 File Offset: 0x003D5161
		// (set) Token: 0x0601AE9E RID: 110238 RVA: 0x003D6F69 File Offset: 0x003D5169
		public ERollBlockItemType Type { get; set; }

		// Token: 0x17007E8F RID: 32399
		// (get) Token: 0x0601AE9F RID: 110239 RVA: 0x003D6F72 File Offset: 0x003D5172
		// (set) Token: 0x0601AEA0 RID: 110240 RVA: 0x003D6F7A File Offset: 0x003D517A
		public int Key { get; set; }

		// Token: 0x17007E90 RID: 32400
		// (get) Token: 0x0601AEA1 RID: 110241 RVA: 0x003D6F83 File Offset: 0x003D5183
		// (set) Token: 0x0601AEA2 RID: 110242 RVA: 0x003D6F8B File Offset: 0x003D518B
		public IRollBlockPathT Path { get; set; }

		// Token: 0x0601AEA3 RID: 110243 RVA: 0x003D6F94 File Offset: 0x003D5194
		public IRollBlockItemBreakableObstacleT()
		{
			this.Type = ERollBlockItemType.BreakableObstacle;
			this.Key = 0;
			this.Path = null;
		}
	}
}
