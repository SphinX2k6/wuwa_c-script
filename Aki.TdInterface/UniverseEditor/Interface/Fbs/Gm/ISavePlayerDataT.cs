using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AF0 RID: 19184
	public class ISavePlayerDataT
	{
		// Token: 0x17008673 RID: 34419
		// (get) Token: 0x0601CE74 RID: 118388 RVA: 0x004114E6 File Offset: 0x0040F6E6
		// (set) Token: 0x0601CE75 RID: 118389 RVA: 0x004114EE File Offset: 0x0040F6EE
		public EGmCommand Type { get; set; }

		// Token: 0x0601CE76 RID: 118390 RVA: 0x004114F7 File Offset: 0x0040F6F7
		public ISavePlayerDataT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
