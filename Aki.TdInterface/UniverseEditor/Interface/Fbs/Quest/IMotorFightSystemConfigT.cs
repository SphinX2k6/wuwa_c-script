using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004383 RID: 17283
	public class IMotorFightSystemConfigT
	{
		// Token: 0x17007695 RID: 30357
		// (get) Token: 0x060186C9 RID: 100041 RVA: 0x0037B493 File Offset: 0x00379693
		// (set) Token: 0x060186CA RID: 100042 RVA: 0x0037B49B File Offset: 0x0037969B
		public EEnableSystemType Type { get; set; }

		// Token: 0x17007696 RID: 30358
		// (get) Token: 0x060186CB RID: 100043 RVA: 0x0037B4A4 File Offset: 0x003796A4
		// (set) Token: 0x060186CC RID: 100044 RVA: 0x0037B4AC File Offset: 0x003796AC
		public List<IMotorFightSystemVarT> Vars { get; set; }

		// Token: 0x060186CD RID: 100045 RVA: 0x0037B4B5 File Offset: 0x003796B5
		public IMotorFightSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
			this.Vars = null;
		}
	}
}
