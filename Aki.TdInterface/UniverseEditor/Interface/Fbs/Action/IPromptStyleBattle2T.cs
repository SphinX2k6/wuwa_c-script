using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DCF RID: 28111
	public class IPromptStyleBattle2T
	{
		// Token: 0x1700D196 RID: 53654
		// (get) Token: 0x06031A7D RID: 203389 RVA: 0x006B9FC6 File Offset: 0x006B81C6
		// (set) Token: 0x06031A7E RID: 203390 RVA: 0x006B9FCE File Offset: 0x006B81CE
		public EPromptStyle Type { get; set; }

		// Token: 0x06031A7F RID: 203391 RVA: 0x006B9FD7 File Offset: 0x006B81D7
		public IPromptStyleBattle2T()
		{
			this.Type = EPromptStyle.Default;
		}
	}
}
