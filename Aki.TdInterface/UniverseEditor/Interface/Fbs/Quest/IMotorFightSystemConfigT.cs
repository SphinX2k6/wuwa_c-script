using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F45 RID: 16197
	public class IMotorFightSystemConfigT
	{
		// Token: 0x170070A4 RID: 28836
		// (get) Token: 0x06017067 RID: 94311 RVA: 0x0035201F File Offset: 0x0035021F
		// (set) Token: 0x06017068 RID: 94312 RVA: 0x00352027 File Offset: 0x00350227
		public EEnableSystemType Type { get; set; }

		// Token: 0x170070A5 RID: 28837
		// (get) Token: 0x06017069 RID: 94313 RVA: 0x00352030 File Offset: 0x00350230
		// (set) Token: 0x0601706A RID: 94314 RVA: 0x00352038 File Offset: 0x00350238
		public List<IMotorFightSystemVarT> Vars { get; set; }

		// Token: 0x0601706B RID: 94315 RVA: 0x00352041 File Offset: 0x00350241
		public IMotorFightSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
			this.Vars = null;
		}
	}
}
