using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004158 RID: 16728
	public class ICameraConditionT
	{
		// Token: 0x1700714C RID: 29004
		// (get) Token: 0x06016FF7 RID: 94199 RVA: 0x00347B0B File Offset: 0x00345D0B
		// (set) Token: 0x06016FF8 RID: 94200 RVA: 0x00347B13 File Offset: 0x00345D13
		public string TidTip { get; set; }

		// Token: 0x1700714D RID: 29005
		// (get) Token: 0x06016FF9 RID: 94201 RVA: 0x00347B1C File Offset: 0x00345D1C
		// (set) Token: 0x06016FFA RID: 94202 RVA: 0x00347B24 File Offset: 0x00345D24
		public IConditionGroupT Condition { get; set; }

		// Token: 0x06016FFB RID: 94203 RVA: 0x00347B2D File Offset: 0x00345D2D
		public ICameraConditionT()
		{
			this.TidTip = null;
			this.Condition = null;
		}
	}
}
