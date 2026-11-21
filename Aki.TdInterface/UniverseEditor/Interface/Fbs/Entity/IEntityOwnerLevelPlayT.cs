using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C2C RID: 19500
	public class IEntityOwnerLevelPlayT
	{
		// Token: 0x17008A36 RID: 35382
		// (get) Token: 0x0601DDBC RID: 122300 RVA: 0x0042FE30 File Offset: 0x0042E030
		// (set) Token: 0x0601DDBD RID: 122301 RVA: 0x0042FE38 File Offset: 0x0042E038
		public EEntityOwnerType Type { get; set; }

		// Token: 0x17008A37 RID: 35383
		// (get) Token: 0x0601DDBE RID: 122302 RVA: 0x0042FE41 File Offset: 0x0042E041
		// (set) Token: 0x0601DDBF RID: 122303 RVA: 0x0042FE49 File Offset: 0x0042E049
		public int LevelPlayId { get; set; }

		// Token: 0x0601DDC0 RID: 122304 RVA: 0x0042FE52 File Offset: 0x0042E052
		public IEntityOwnerLevelPlayT()
		{
			this.Type = EEntityOwnerType.Quest;
			this.LevelPlayId = 0;
		}
	}
}
