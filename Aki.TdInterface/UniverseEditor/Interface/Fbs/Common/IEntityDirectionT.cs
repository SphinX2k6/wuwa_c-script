using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DA7 RID: 23975
	public class IEntityDirectionT
	{
		// Token: 0x1700B390 RID: 45968
		// (get) Token: 0x06029094 RID: 168084 RVA: 0x005A28CB File Offset: 0x005A0ACB
		// (set) Token: 0x06029095 RID: 168085 RVA: 0x005A28D3 File Offset: 0x005A0AD3
		public int EntityId { get; set; }

		// Token: 0x1700B391 RID: 45969
		// (get) Token: 0x06029096 RID: 168086 RVA: 0x005A28DC File Offset: 0x005A0ADC
		// (set) Token: 0x06029097 RID: 168087 RVA: 0x005A28E4 File Offset: 0x005A0AE4
		public IVectorInfoT GravityDirection { get; set; }

		// Token: 0x06029098 RID: 168088 RVA: 0x005A28ED File Offset: 0x005A0AED
		public IEntityDirectionT()
		{
			this.EntityId = 0;
			this.GravityDirection = null;
		}
	}
}
