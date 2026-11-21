using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200645F RID: 25695
	public class IOutAreaBorderTipTypeT
	{
		// Token: 0x1700BDB2 RID: 48562
		// (get) Token: 0x0602BAB6 RID: 178870 RVA: 0x005F19A2 File Offset: 0x005EFBA2
		// (set) Token: 0x0602BAB7 RID: 178871 RVA: 0x005F19AA File Offset: 0x005EFBAA
		public EOutAreaBorderTipType Type { get; set; }

		// Token: 0x0602BAB8 RID: 178872 RVA: 0x005F19B3 File Offset: 0x005EFBB3
		public IOutAreaBorderTipTypeT()
		{
			this.Type = EOutAreaBorderTipType.DownTimeTextTip;
		}
	}
}
