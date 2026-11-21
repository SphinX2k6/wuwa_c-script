using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078EB RID: 30955
	public class ISkiConfigT
	{
		// Token: 0x1700E32B RID: 58155
		// (get) Token: 0x0603682C RID: 223276 RVA: 0x0074C373 File Offset: 0x0074A573
		// (set) Token: 0x0603682D RID: 223277 RVA: 0x0074C37B File Offset: 0x0074A57B
		public ESportStateType Type { get; set; }

		// Token: 0x1700E32C RID: 58156
		// (get) Token: 0x0603682E RID: 223278 RVA: 0x0074C384 File Offset: 0x0074A584
		// (set) Token: 0x0603682F RID: 223279 RVA: 0x0074C38C File Offset: 0x0074A58C
		public TSkiConfigUnion Config { get; set; }

		// Token: 0x06036830 RID: 223280 RVA: 0x0074C395 File Offset: 0x0074A595
		public ISkiConfigT()
		{
			this.Type = ESportStateType.Slide;
			this.Config = null;
		}
	}
}
