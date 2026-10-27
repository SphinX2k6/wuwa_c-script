using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049E3 RID: 18915
	public class ICheckElementalEffectActiveT
	{
		// Token: 0x170088CC RID: 35020
		// (get) Token: 0x0601D8CA RID: 121034 RVA: 0x00428F58 File Offset: 0x00427158
		// (set) Token: 0x0601D8CB RID: 121035 RVA: 0x00428F60 File Offset: 0x00427160
		public ECondition Type { get; set; }

		// Token: 0x170088CD RID: 35021
		// (get) Token: 0x0601D8CC RID: 121036 RVA: 0x00428F69 File Offset: 0x00427169
		// (set) Token: 0x0601D8CD RID: 121037 RVA: 0x00428F71 File Offset: 0x00427171
		public bool IsActive { get; set; }

		// Token: 0x0601D8CE RID: 121038 RVA: 0x00428F7A File Offset: 0x0042717A
		public ICheckElementalEffectActiveT()
		{
			this.Type = ECondition.CompareVar;
			this.IsActive = false;
		}
	}
}
