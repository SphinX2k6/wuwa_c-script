using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200559C RID: 21916
	public class ICountDownTextTipT
	{
		// Token: 0x17009CF0 RID: 40176
		// (get) Token: 0x06022DBD RID: 142781 RVA: 0x004CD26B File Offset: 0x004CB46B
		// (set) Token: 0x06022DBE RID: 142782 RVA: 0x004CD273 File Offset: 0x004CB473
		public ETrampleTipType Type { get; set; }

		// Token: 0x17009CF1 RID: 40177
		// (get) Token: 0x06022DBF RID: 142783 RVA: 0x004CD27C File Offset: 0x004CB47C
		// (set) Token: 0x06022DC0 RID: 142784 RVA: 0x004CD284 File Offset: 0x004CB484
		public string TidCountDownTip { get; set; }

		// Token: 0x06022DC1 RID: 142785 RVA: 0x004CD28D File Offset: 0x004CB48D
		public ICountDownTextTipT()
		{
			this.Type = ETrampleTipType.CountDownTextTip;
			this.TidCountDownTip = null;
		}
	}
}
