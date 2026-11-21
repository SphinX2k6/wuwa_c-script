using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200754D RID: 30029
	public class IPromptStyleDefaultT
	{
		// Token: 0x1700DCE1 RID: 56545
		// (get) Token: 0x06034A8B RID: 215691 RVA: 0x00715826 File Offset: 0x00713A26
		// (set) Token: 0x06034A8C RID: 215692 RVA: 0x0071582E File Offset: 0x00713A2E
		public EPromptStyle Type { get; set; }

		// Token: 0x06034A8D RID: 215693 RVA: 0x00715837 File Offset: 0x00713A37
		public IPromptStyleDefaultT()
		{
			this.Type = EPromptStyle.Default;
		}
	}
}
