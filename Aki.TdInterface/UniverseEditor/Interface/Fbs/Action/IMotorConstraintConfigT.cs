using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B16 RID: 27414
	public class IMotorConstraintConfigT
	{
		// Token: 0x1700CBA5 RID: 52133
		// (get) Token: 0x060301A0 RID: 197024 RVA: 0x00689F2F File Offset: 0x0068812F
		// (set) Token: 0x060301A1 RID: 197025 RVA: 0x00689F37 File Offset: 0x00688137
		public List<EPlayerInputConstraintType> DisableInput { get; set; }

		// Token: 0x1700CBA6 RID: 52134
		// (get) Token: 0x060301A2 RID: 197026 RVA: 0x00689F40 File Offset: 0x00688140
		// (set) Token: 0x060301A3 RID: 197027 RVA: 0x00689F48 File Offset: 0x00688148
		public byte NullMask { get; set; }

		// Token: 0x060301A4 RID: 197028 RVA: 0x00689F51 File Offset: 0x00688151
		public IMotorConstraintConfigT()
		{
			this.DisableInput = null;
			this.NullMask = 0;
		}
	}
}
