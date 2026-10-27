using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055AC RID: 21932
	public class IMotorAutoEjectNextHookConfigT
	{
		// Token: 0x1700A1F9 RID: 41465
		// (get) Token: 0x060244ED RID: 148717 RVA: 0x00502FF0 File Offset: 0x005011F0
		// (set) Token: 0x060244EE RID: 148718 RVA: 0x00502FF8 File Offset: 0x005011F8
		public EMotorAutoEjectType Type { get; set; }

		// Token: 0x1700A1FA RID: 41466
		// (get) Token: 0x060244EF RID: 148719 RVA: 0x00503001 File Offset: 0x00501201
		// (set) Token: 0x060244F0 RID: 148720 RVA: 0x00503009 File Offset: 0x00501209
		public int EntityId { get; set; }

		// Token: 0x060244F1 RID: 148721 RVA: 0x00503012 File Offset: 0x00501212
		public IMotorAutoEjectNextHookConfigT()
		{
			this.Type = EMotorAutoEjectType.NextHook;
			this.EntityId = 0;
		}
	}
}
