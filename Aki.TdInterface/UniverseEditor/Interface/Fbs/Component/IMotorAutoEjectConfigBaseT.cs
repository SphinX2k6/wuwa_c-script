using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055A6 RID: 21926
	public class IMotorAutoEjectConfigBaseT
	{
		// Token: 0x1700A1F3 RID: 41459
		// (get) Token: 0x060244CB RID: 148683 RVA: 0x00502CCE File Offset: 0x00500ECE
		// (set) Token: 0x060244CC RID: 148684 RVA: 0x00502CD6 File Offset: 0x00500ED6
		public EMotorAutoEjectType Type { get; set; }

		// Token: 0x060244CD RID: 148685 RVA: 0x00502CDF File Offset: 0x00500EDF
		public IMotorAutoEjectConfigBaseT()
		{
			this.Type = EMotorAutoEjectType.NextHook;
		}
	}
}
