using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075FE RID: 30206
	public class IRequestSystemFunctionT
	{
		// Token: 0x1700DDFF RID: 56831
		// (get) Token: 0x0603500F RID: 217103 RVA: 0x0071EF25 File Offset: 0x0071D125
		// (set) Token: 0x06035010 RID: 217104 RVA: 0x0071EF2D File Offset: 0x0071D12D
		public IBuyGoodsT SystemFunction { get; set; }

		// Token: 0x06035011 RID: 217105 RVA: 0x0071EF36 File Offset: 0x0071D136
		public IRequestSystemFunctionT()
		{
			this.SystemFunction = null;
		}
	}
}
