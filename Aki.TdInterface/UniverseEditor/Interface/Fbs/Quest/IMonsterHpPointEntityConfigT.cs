using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004374 RID: 17268
	public class IMonsterHpPointEntityConfigT
	{
		// Token: 0x1700767C RID: 30332
		// (get) Token: 0x0601864D RID: 99917 RVA: 0x0037A7DC File Offset: 0x003789DC
		// (set) Token: 0x0601864E RID: 99918 RVA: 0x0037A7E4 File Offset: 0x003789E4
		public int EntityId { get; set; }

		// Token: 0x1700767D RID: 30333
		// (get) Token: 0x0601864F RID: 99919 RVA: 0x0037A7ED File Offset: 0x003789ED
		// (set) Token: 0x06018650 RID: 99920 RVA: 0x0037A7F5 File Offset: 0x003789F5
		public int PointOfEveryOnePercentHp { get; set; }

		// Token: 0x06018651 RID: 99921 RVA: 0x0037A7FE File Offset: 0x003789FE
		public IMonsterHpPointEntityConfigT()
		{
			this.EntityId = 0;
			this.PointOfEveryOnePercentHp = 0;
		}
	}
}
