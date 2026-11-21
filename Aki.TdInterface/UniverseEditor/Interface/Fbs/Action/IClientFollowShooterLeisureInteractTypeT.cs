using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A3C RID: 27196
	public class IClientFollowShooterLeisureInteractTypeT
	{
		// Token: 0x1700C7D9 RID: 51161
		// (get) Token: 0x0602EA6A RID: 191082 RVA: 0x0065C27A File Offset: 0x0065A47A
		// (set) Token: 0x0602EA6B RID: 191083 RVA: 0x0065C282 File Offset: 0x0065A482
		public EClientFollowShooterLeisureInteractType Type { get; set; }

		// Token: 0x0602EA6C RID: 191084 RVA: 0x0065C28B File Offset: 0x0065A48B
		public IClientFollowShooterLeisureInteractTypeT()
		{
			this.Type = EClientFollowShooterLeisureInteractType.PlayAnimation;
		}
	}
}
