using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078E5 RID: 30949
	public class ISitDownT
	{
		// Token: 0x1700E322 RID: 58146
		// (get) Token: 0x060367FD RID: 223229 RVA: 0x0074BE1E File Offset: 0x0074A01E
		// (set) Token: 0x060367FE RID: 223230 RVA: 0x0074BE26 File Offset: 0x0074A026
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700E323 RID: 58147
		// (get) Token: 0x060367FF RID: 223231 RVA: 0x0074BE2F File Offset: 0x0074A02F
		// (set) Token: 0x06036800 RID: 223232 RVA: 0x0074BE37 File Offset: 0x0074A037
		public bool OnlyAllowForwardStandUp { get; set; }

		// Token: 0x1700E324 RID: 58148
		// (get) Token: 0x06036801 RID: 223233 RVA: 0x0074BE40 File Offset: 0x0074A040
		// (set) Token: 0x06036802 RID: 223234 RVA: 0x0074BE48 File Offset: 0x0074A048
		public byte NullMask { get; set; }

		// Token: 0x06036803 RID: 223235 RVA: 0x0074BE51 File Offset: 0x0074A051
		public ISitDownT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.OnlyAllowForwardStandUp = false;
			this.NullMask = 0;
		}
	}
}
