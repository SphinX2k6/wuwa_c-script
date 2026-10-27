using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FE4 RID: 28644
	public class ISetEntityPosT
	{
		// Token: 0x1700D4AA RID: 54442
		// (get) Token: 0x06032A46 RID: 207430 RVA: 0x006D51AD File Offset: 0x006D33AD
		// (set) Token: 0x06032A47 RID: 207431 RVA: 0x006D51B5 File Offset: 0x006D33B5
		public int EntityId { get; set; }

		// Token: 0x1700D4AB RID: 54443
		// (get) Token: 0x06032A48 RID: 207432 RVA: 0x006D51BE File Offset: 0x006D33BE
		// (set) Token: 0x06032A49 RID: 207433 RVA: 0x006D51C6 File Offset: 0x006D33C6
		public IPosAT Pos { get; set; }

		// Token: 0x1700D4AC RID: 54444
		// (get) Token: 0x06032A4A RID: 207434 RVA: 0x006D51CF File Offset: 0x006D33CF
		// (set) Token: 0x06032A4B RID: 207435 RVA: 0x006D51D7 File Offset: 0x006D33D7
		public IVectorInfoT Rot { get; set; }

		// Token: 0x06032A4C RID: 207436 RVA: 0x006D51E0 File Offset: 0x006D33E0
		public ISetEntityPosT()
		{
			this.EntityId = 0;
			this.Pos = null;
			this.Rot = null;
		}
	}
}
