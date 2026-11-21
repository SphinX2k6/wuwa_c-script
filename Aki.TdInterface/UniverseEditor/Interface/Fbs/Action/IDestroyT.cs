using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BE5 RID: 27621
	public class IDestroyT
	{
		// Token: 0x1700CA93 RID: 51859
		// (get) Token: 0x0602F8A8 RID: 194728 RVA: 0x0067B248 File Offset: 0x00679448
		// (set) Token: 0x0602F8A9 RID: 194729 RVA: 0x0067B250 File Offset: 0x00679450
		public bool DelayDestroy { get; set; }

		// Token: 0x1700CA94 RID: 51860
		// (get) Token: 0x0602F8AA RID: 194730 RVA: 0x0067B259 File Offset: 0x00679459
		// (set) Token: 0x0602F8AB RID: 194731 RVA: 0x0067B261 File Offset: 0x00679461
		public byte NullMask { get; set; }

		// Token: 0x0602F8AC RID: 194732 RVA: 0x0067B26A File Offset: 0x0067946A
		public IDestroyT()
		{
			this.DelayDestroy = false;
			this.NullMask = 0;
		}
	}
}
