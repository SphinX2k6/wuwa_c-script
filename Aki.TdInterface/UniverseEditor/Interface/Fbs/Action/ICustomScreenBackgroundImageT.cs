using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064FC RID: 25852
	public class ICustomScreenBackgroundImageT
	{
		// Token: 0x1700C048 RID: 49224
		// (get) Token: 0x0602CD95 RID: 183701 RVA: 0x0062949B File Offset: 0x0062769B
		// (set) Token: 0x0602CD96 RID: 183702 RVA: 0x006294A3 File Offset: 0x006276A3
		public ECustomScreenType Type { get; set; }

		// Token: 0x1700C049 RID: 49225
		// (get) Token: 0x0602CD97 RID: 183703 RVA: 0x006294AC File Offset: 0x006276AC
		// (set) Token: 0x0602CD98 RID: 183704 RVA: 0x006294B4 File Offset: 0x006276B4
		public string BackgroundImagePath { get; set; }

		// Token: 0x0602CD99 RID: 183705 RVA: 0x006294BD File Offset: 0x006276BD
		public ICustomScreenBackgroundImageT()
		{
			this.Type = ECustomScreenType.Spine;
			this.BackgroundImagePath = null;
		}
	}
}
