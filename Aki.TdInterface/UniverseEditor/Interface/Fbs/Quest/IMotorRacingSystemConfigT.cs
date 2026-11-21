using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004389 RID: 17289
	public class IMotorRacingSystemConfigT
	{
		// Token: 0x170076A0 RID: 30368
		// (get) Token: 0x06018704 RID: 100100 RVA: 0x0037BD2D File Offset: 0x00379F2D
		// (set) Token: 0x06018705 RID: 100101 RVA: 0x0037BD35 File Offset: 0x00379F35
		public EEnableSystemType Type { get; set; }

		// Token: 0x170076A1 RID: 30369
		// (get) Token: 0x06018706 RID: 100102 RVA: 0x0037BD3E File Offset: 0x00379F3E
		// (set) Token: 0x06018707 RID: 100103 RVA: 0x0037BD46 File Offset: 0x00379F46
		public int MotorParkourId { get; set; }

		// Token: 0x170076A2 RID: 30370
		// (get) Token: 0x06018708 RID: 100104 RVA: 0x0037BD4F File Offset: 0x00379F4F
		// (set) Token: 0x06018709 RID: 100105 RVA: 0x0037BD57 File Offset: 0x00379F57
		public List<IMotorParkourSystemVarT> SystemVars { get; set; }

		// Token: 0x0601870A RID: 100106 RVA: 0x0037BD60 File Offset: 0x00379F60
		public IMotorRacingSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
			this.MotorParkourId = 0;
			this.SystemVars = null;
		}
	}
}
