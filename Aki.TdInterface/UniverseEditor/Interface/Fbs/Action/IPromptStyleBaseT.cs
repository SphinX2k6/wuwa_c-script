using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DC6 RID: 28102
	public class IPromptStyleBaseT
	{
		// Token: 0x1700D18E RID: 53646
		// (get) Token: 0x06031A47 RID: 203335 RVA: 0x006B9B0E File Offset: 0x006B7D0E
		// (set) Token: 0x06031A48 RID: 203336 RVA: 0x006B9B16 File Offset: 0x006B7D16
		public EPromptStyle Type { get; set; }

		// Token: 0x06031A49 RID: 203337 RVA: 0x006B9B1F File Offset: 0x006B7D1F
		public IPromptStyleBaseT()
		{
			this.Type = EPromptStyle.Default;
		}
	}
}
