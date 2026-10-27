using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004676 RID: 18038
	public class IOpenBackLoginViewT
	{
		// Token: 0x17008019 RID: 32793
		// (get) Token: 0x0601B625 RID: 112165 RVA: 0x003E4733 File Offset: 0x003E2933
		// (set) Token: 0x0601B626 RID: 112166 RVA: 0x003E473B File Offset: 0x003E293B
		public EGmCommand Type { get; set; }

		// Token: 0x1700801A RID: 32794
		// (get) Token: 0x0601B627 RID: 112167 RVA: 0x003E4744 File Offset: 0x003E2944
		// (set) Token: 0x0601B628 RID: 112168 RVA: 0x003E474C File Offset: 0x003E294C
		public string Account { get; set; }

		// Token: 0x0601B629 RID: 112169 RVA: 0x003E4755 File Offset: 0x003E2955
		public IOpenBackLoginViewT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.Account = null;
		}
	}
}
