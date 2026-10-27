using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F55 RID: 28501
	public class ISelfClientEventT
	{
		// Token: 0x1700D3C7 RID: 54215
		// (get) Token: 0x060325A7 RID: 206247 RVA: 0x006CC7AA File Offset: 0x006CA9AA
		// (set) Token: 0x060325A8 RID: 206248 RVA: 0x006CC7B2 File Offset: 0x006CA9B2
		public EClientEventTarget Type { get; set; }

		// Token: 0x060325A9 RID: 206249 RVA: 0x006CC7BB File Offset: 0x006CA9BB
		public ISelfClientEventT()
		{
			this.Type = EClientEventTarget.Self;
		}
	}
}
