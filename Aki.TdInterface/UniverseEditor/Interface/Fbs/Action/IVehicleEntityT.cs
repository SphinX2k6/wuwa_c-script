using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007515 RID: 29973
	public class IVehicleEntityT
	{
		// Token: 0x1700E372 RID: 58226
		// (get) Token: 0x0603683F RID: 223295 RVA: 0x00767E33 File Offset: 0x00766033
		// (set) Token: 0x06036840 RID: 223296 RVA: 0x00767E3B File Offset: 0x0076603B
		public ETargetEntityType Type { get; set; }

		// Token: 0x1700E373 RID: 58227
		// (get) Token: 0x06036841 RID: 223297 RVA: 0x00767E44 File Offset: 0x00766044
		// (set) Token: 0x06036842 RID: 223298 RVA: 0x00767E4C File Offset: 0x0076604C
		public TTargetVehicleUnion Vehicle { get; set; }

		// Token: 0x06036843 RID: 223299 RVA: 0x00767E55 File Offset: 0x00766055
		public IVehicleEntityT()
		{
			this.Type = ETargetEntityType.Target;
			this.Vehicle = null;
		}
	}
}
