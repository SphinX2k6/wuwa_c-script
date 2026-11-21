using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006465 RID: 25701
	public class IOutAreaBorderTypeT
	{
		// Token: 0x1700BDB7 RID: 48567
		// (get) Token: 0x0602BAD4 RID: 178900 RVA: 0x005F1C16 File Offset: 0x005EFE16
		// (set) Token: 0x0602BAD5 RID: 178901 RVA: 0x005F1C1E File Offset: 0x005EFE1E
		public EOutAreaBorderType Type { get; set; }

		// Token: 0x0602BAD6 RID: 178902 RVA: 0x005F1C27 File Offset: 0x005EFE27
		public IOutAreaBorderTypeT()
		{
			this.Type = EOutAreaBorderType.TeleportTimer;
		}
	}
}
