using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AA5 RID: 19109
	public class IBrokenRockHotFixT
	{
		// Token: 0x170085D9 RID: 34265
		// (get) Token: 0x0601CB9A RID: 117658 RVA: 0x0040C8CE File Offset: 0x0040AACE
		// (set) Token: 0x0601CB9B RID: 117659 RVA: 0x0040C8D6 File Offset: 0x0040AAD6
		public EGmCommand Type { get; set; }

		// Token: 0x0601CB9C RID: 117660 RVA: 0x0040C8DF File Offset: 0x0040AADF
		public IBrokenRockHotFixT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
