using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007541 RID: 30017
	public class IPromptStyleBaseT
	{
		// Token: 0x1700DCD6 RID: 56534
		// (get) Token: 0x06034A43 RID: 215619 RVA: 0x007151F6 File Offset: 0x007133F6
		// (set) Token: 0x06034A44 RID: 215620 RVA: 0x007151FE File Offset: 0x007133FE
		public EPromptStyle Type { get; set; }

		// Token: 0x06034A45 RID: 215621 RVA: 0x00715207 File Offset: 0x00713407
		public IPromptStyleBaseT()
		{
			this.Type = EPromptStyle.Default;
		}
	}
}
