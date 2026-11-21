using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078E8 RID: 30952
	public class ISitOnGroundT
	{
		// Token: 0x1700E327 RID: 58151
		// (get) Token: 0x06036813 RID: 223251 RVA: 0x0074BFEE File Offset: 0x0074A1EE
		// (set) Token: 0x06036814 RID: 223252 RVA: 0x0074BFF6 File Offset: 0x0074A1F6
		public ELeisureInteract Type { get; set; }

		// Token: 0x06036815 RID: 223253 RVA: 0x0074BFFF File Offset: 0x0074A1FF
		public ISitOnGroundT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
