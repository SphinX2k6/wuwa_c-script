using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007948 RID: 31048
	public class ISpecificScanEffectT
	{
		// Token: 0x1700E3C0 RID: 58304
		// (get) Token: 0x06036AED RID: 223981 RVA: 0x0075122A File Offset: 0x0074F42A
		// (set) Token: 0x06036AEE RID: 223982 RVA: 0x00751232 File Offset: 0x0074F432
		public ESpecificScanType Type { get; set; }

		// Token: 0x06036AEF RID: 223983 RVA: 0x0075123B File Offset: 0x0074F43B
		public ISpecificScanEffectT()
		{
			this.Type = ESpecificScanType.None;
		}
	}
}
