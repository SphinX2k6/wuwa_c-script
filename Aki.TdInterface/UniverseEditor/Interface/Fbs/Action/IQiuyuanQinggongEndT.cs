using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007559 RID: 30041
	public class IQiuyuanQinggongEndT
	{
		// Token: 0x1700DCF5 RID: 56565
		// (get) Token: 0x06034AE7 RID: 215783 RVA: 0x0071609A File Offset: 0x0071429A
		// (set) Token: 0x06034AE8 RID: 215784 RVA: 0x007160A2 File Offset: 0x007142A2
		public ELeisureInteract Type { get; set; }

		// Token: 0x06034AE9 RID: 215785 RVA: 0x007160AB File Offset: 0x007142AB
		public IQiuyuanQinggongEndT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
