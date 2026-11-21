using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200641A RID: 25626
	public class IGiantStableValueTypeT
	{
		// Token: 0x1700BD48 RID: 48456
		// (get) Token: 0x0602B8A4 RID: 178340 RVA: 0x005EDE26 File Offset: 0x005EC026
		// (set) Token: 0x0602B8A5 RID: 178341 RVA: 0x005EDE2E File Offset: 0x005EC02E
		public EGiantStableValueType Type { get; set; }

		// Token: 0x0602B8A6 RID: 178342 RVA: 0x005EDE37 File Offset: 0x005EC037
		public IGiantStableValueTypeT()
		{
			this.Type = EGiantStableValueType.Region;
		}
	}
}
