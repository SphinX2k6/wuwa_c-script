using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007131 RID: 28977
	public class ILiveSetUiT
	{
		// Token: 0x1700D428 RID: 54312
		// (get) Token: 0x06032578 RID: 206200 RVA: 0x006CE92D File Offset: 0x006CCB2D
		// (set) Token: 0x06032579 RID: 206201 RVA: 0x006CE935 File Offset: 0x006CCB35
		public TLiveUiConfigUnion UiConfig { get; set; }

		// Token: 0x0603257A RID: 206202 RVA: 0x006CE93E File Offset: 0x006CCB3E
		public ILiveSetUiT()
		{
			this.UiConfig = null;
		}
	}
}
