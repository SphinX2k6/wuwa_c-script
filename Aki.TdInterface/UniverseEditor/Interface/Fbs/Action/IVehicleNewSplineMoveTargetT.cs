using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007524 RID: 29988
	public class IVehicleNewSplineMoveTargetT
	{
		// Token: 0x1700E391 RID: 58257
		// (get) Token: 0x060368E2 RID: 223458 RVA: 0x0076993B File Offset: 0x00767B3B
		// (set) Token: 0x060368E3 RID: 223459 RVA: 0x00769943 File Offset: 0x00767B43
		public ENewSplineMoveTargetType Type { get; set; }

		// Token: 0x1700E392 RID: 58258
		// (get) Token: 0x060368E4 RID: 223460 RVA: 0x0076994C File Offset: 0x00767B4C
		// (set) Token: 0x060368E5 RID: 223461 RVA: 0x00769954 File Offset: 0x00767B54
		public TTargetVehicleUnion TargetVehicle { get; set; }

		// Token: 0x1700E393 RID: 58259
		// (get) Token: 0x060368E6 RID: 223462 RVA: 0x0076995D File Offset: 0x00767B5D
		// (set) Token: 0x060368E7 RID: 223463 RVA: 0x00769965 File Offset: 0x00767B65
		public bool IsLookDir { get; set; }

		// Token: 0x1700E394 RID: 58260
		// (get) Token: 0x060368E8 RID: 223464 RVA: 0x0076996E File Offset: 0x00767B6E
		// (set) Token: 0x060368E9 RID: 223465 RVA: 0x00769976 File Offset: 0x00767B76
		public byte NullMask { get; set; }

		// Token: 0x060368EA RID: 223466 RVA: 0x0076997F File Offset: 0x00767B7F
		public IVehicleNewSplineMoveTargetT()
		{
			this.Type = ENewSplineMoveTargetType.Player;
			this.TargetVehicle = null;
			this.IsLookDir = false;
			this.NullMask = 0;
		}
	}
}
