using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F4B RID: 16203
	public class IMotorRacingSystemConfigT
	{
		// Token: 0x170070AF RID: 28847
		// (get) Token: 0x060170A2 RID: 94370 RVA: 0x003528B9 File Offset: 0x00350AB9
		// (set) Token: 0x060170A3 RID: 94371 RVA: 0x003528C1 File Offset: 0x00350AC1
		public EEnableSystemType Type { get; set; }

		// Token: 0x170070B0 RID: 28848
		// (get) Token: 0x060170A4 RID: 94372 RVA: 0x003528CA File Offset: 0x00350ACA
		// (set) Token: 0x060170A5 RID: 94373 RVA: 0x003528D2 File Offset: 0x00350AD2
		public int MotorParkourId { get; set; }

		// Token: 0x170070B1 RID: 28849
		// (get) Token: 0x060170A6 RID: 94374 RVA: 0x003528DB File Offset: 0x00350ADB
		// (set) Token: 0x060170A7 RID: 94375 RVA: 0x003528E3 File Offset: 0x00350AE3
		public List<IMotorParkourSystemVarT> SystemVars { get; set; }

		// Token: 0x060170A8 RID: 94376 RVA: 0x003528EC File Offset: 0x00350AEC
		public IMotorRacingSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
			this.MotorParkourId = 0;
			this.SystemVars = null;
		}
	}
}
