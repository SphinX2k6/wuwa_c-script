using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E12 RID: 15890
	public class IBvbCardFilterCheckIsCoreT
	{
		// Token: 0x17006B50 RID: 27472
		// (get) Token: 0x060155CA RID: 87498 RVA: 0x00316008 File Offset: 0x00314208
		// (set) Token: 0x060155CB RID: 87499 RVA: 0x00316010 File Offset: 0x00314210
		public EBvbCardFilterType Type { get; set; }

		// Token: 0x17006B51 RID: 27473
		// (get) Token: 0x060155CC RID: 87500 RVA: 0x00316019 File Offset: 0x00314219
		// (set) Token: 0x060155CD RID: 87501 RVA: 0x00316021 File Offset: 0x00314221
		public bool IsCore { get; set; }

		// Token: 0x060155CE RID: 87502 RVA: 0x0031602A File Offset: 0x0031422A
		public IBvbCardFilterCheckIsCoreT()
		{
			this.Type = EBvbCardFilterType.CompareCost;
			this.IsCore = false;
		}
	}
}
