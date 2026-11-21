using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006146 RID: 24902
	public class IVehicleTypedMotorConfigT
	{
		// Token: 0x1700B97B RID: 47483
		// (get) Token: 0x0602A420 RID: 173088 RVA: 0x005C41FA File Offset: 0x005C23FA
		// (set) Token: 0x0602A421 RID: 173089 RVA: 0x005C4202 File Offset: 0x005C2402
		public EVehicleType Type { get; set; }

		// Token: 0x1700B97C RID: 47484
		// (get) Token: 0x0602A422 RID: 173090 RVA: 0x005C420B File Offset: 0x005C240B
		// (set) Token: 0x0602A423 RID: 173091 RVA: 0x005C4213 File Offset: 0x005C2413
		public int TrialAttributeId { get; set; }

		// Token: 0x1700B97D RID: 47485
		// (get) Token: 0x0602A424 RID: 173092 RVA: 0x005C421C File Offset: 0x005C241C
		// (set) Token: 0x0602A425 RID: 173093 RVA: 0x005C4224 File Offset: 0x005C2424
		public byte NullMask { get; set; }

		// Token: 0x0602A426 RID: 173094 RVA: 0x005C422D File Offset: 0x005C242D
		public IVehicleTypedMotorConfigT()
		{
			this.Type = EVehicleType.Gongduola;
			this.TrialAttributeId = 0;
			this.NullMask = 0;
		}
	}
}
