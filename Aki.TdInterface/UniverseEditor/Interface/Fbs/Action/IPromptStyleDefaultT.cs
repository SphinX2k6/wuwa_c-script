using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DD2 RID: 28114
	public class IPromptStyleDefaultT
	{
		// Token: 0x1700D199 RID: 53657
		// (get) Token: 0x06031A8F RID: 203407 RVA: 0x006BA13E File Offset: 0x006B833E
		// (set) Token: 0x06031A90 RID: 203408 RVA: 0x006BA146 File Offset: 0x006B8346
		public EPromptStyle Type { get; set; }

		// Token: 0x06031A91 RID: 203409 RVA: 0x006BA14F File Offset: 0x006B834F
		public IPromptStyleDefaultT()
		{
			this.Type = EPromptStyle.Default;
		}
	}
}
