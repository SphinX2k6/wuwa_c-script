using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200732F RID: 29487
	public class ITalkOptionFirstSelectT
	{
		// Token: 0x1700DFFD RID: 57341
		// (get) Token: 0x0603583A RID: 219194 RVA: 0x0074A56A File Offset: 0x0074876A
		// (set) Token: 0x0603583B RID: 219195 RVA: 0x0074A572 File Offset: 0x00748772
		public ETalkOptionPreConditionType Type { get; set; }

		// Token: 0x0603583C RID: 219196 RVA: 0x0074A57B File Offset: 0x0074877B
		public ITalkOptionFirstSelectT()
		{
			this.Type = ETalkOptionPreConditionType.PreOption;
		}
	}
}
