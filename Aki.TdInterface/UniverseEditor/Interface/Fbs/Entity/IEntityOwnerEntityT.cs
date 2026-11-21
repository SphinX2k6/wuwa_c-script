using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C23 RID: 19491
	public class IEntityOwnerEntityT
	{
		// Token: 0x17008A2A RID: 35370
		// (get) Token: 0x0601DD80 RID: 122240 RVA: 0x0042F8D7 File Offset: 0x0042DAD7
		// (set) Token: 0x0601DD81 RID: 122241 RVA: 0x0042F8DF File Offset: 0x0042DADF
		public EEntityOwnerType Type { get; set; }

		// Token: 0x17008A2B RID: 35371
		// (get) Token: 0x0601DD82 RID: 122242 RVA: 0x0042F8E8 File Offset: 0x0042DAE8
		// (set) Token: 0x0601DD83 RID: 122243 RVA: 0x0042F8F0 File Offset: 0x0042DAF0
		public int LevelId { get; set; }

		// Token: 0x17008A2C RID: 35372
		// (get) Token: 0x0601DD84 RID: 122244 RVA: 0x0042F8F9 File Offset: 0x0042DAF9
		// (set) Token: 0x0601DD85 RID: 122245 RVA: 0x0042F901 File Offset: 0x0042DB01
		public int EntityId { get; set; }

		// Token: 0x17008A2D RID: 35373
		// (get) Token: 0x0601DD86 RID: 122246 RVA: 0x0042F90A File Offset: 0x0042DB0A
		// (set) Token: 0x0601DD87 RID: 122247 RVA: 0x0042F912 File Offset: 0x0042DB12
		public string FromFlowUid { get; set; }

		// Token: 0x0601DD88 RID: 122248 RVA: 0x0042F91B File Offset: 0x0042DB1B
		public IEntityOwnerEntityT()
		{
			this.Type = EEntityOwnerType.Quest;
			this.LevelId = 0;
			this.EntityId = 0;
			this.FromFlowUid = null;
		}
	}
}
