using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070CB RID: 28875
	public class ILimitPlayerMouseT
	{
		// Token: 0x1700D37F RID: 54143
		// (get) Token: 0x06032241 RID: 205377 RVA: 0x006C8D2A File Offset: 0x006C6F2A
		// (set) Token: 0x06032242 RID: 205378 RVA: 0x006C8D32 File Offset: 0x006C6F32
		public ELimitPlayOperation Type { get; set; }

		// Token: 0x06032243 RID: 205379 RVA: 0x006C8D3B File Offset: 0x006C6F3B
		public ILimitPlayerMouseT()
		{
			this.Type = ELimitPlayOperation.AllowCamera;
		}
	}
}
