using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020047F5 RID: 18421
	public class IAwakeEntityRefSourceT
	{
		// Token: 0x1700807E RID: 32894
		// (get) Token: 0x0601B369 RID: 111465 RVA: 0x003DB34C File Offset: 0x003D954C
		// (set) Token: 0x0601B36A RID: 111466 RVA: 0x003DB354 File Offset: 0x003D9554
		public ERefSourceType Type { get; set; }

		// Token: 0x1700807F RID: 32895
		// (get) Token: 0x0601B36B RID: 111467 RVA: 0x003DB35D File Offset: 0x003D955D
		// (set) Token: 0x0601B36C RID: 111468 RVA: 0x003DB365 File Offset: 0x003D9565
		public int EntityId { get; set; }

		// Token: 0x0601B36D RID: 111469 RVA: 0x003DB36E File Offset: 0x003D956E
		public IAwakeEntityRefSourceT()
		{
			this.Type = ERefSourceType.AwakeEntity;
			this.EntityId = 0;
		}
	}
}
