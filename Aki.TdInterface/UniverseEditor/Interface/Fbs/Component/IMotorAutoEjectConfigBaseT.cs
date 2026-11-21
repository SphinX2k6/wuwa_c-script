using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B44 RID: 23364
	public class IMotorAutoEjectConfigBaseT
	{
		// Token: 0x1700AA7B RID: 43643
		// (get) Token: 0x060266D8 RID: 157400 RVA: 0x00543246 File Offset: 0x00541446
		// (set) Token: 0x060266D9 RID: 157401 RVA: 0x0054324E File Offset: 0x0054144E
		public EMotorAutoEjectType Type { get; set; }

		// Token: 0x060266DA RID: 157402 RVA: 0x00543257 File Offset: 0x00541457
		public IMotorAutoEjectConfigBaseT()
		{
			this.Type = EMotorAutoEjectType.NextHook;
		}
	}
}
