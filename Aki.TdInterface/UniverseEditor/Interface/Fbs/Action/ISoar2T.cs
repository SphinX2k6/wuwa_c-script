using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200792D RID: 31021
	public class ISoar2T
	{
		// Token: 0x1700E392 RID: 58258
		// (get) Token: 0x06036A16 RID: 223766 RVA: 0x0074F7C6 File Offset: 0x0074D9C6
		// (set) Token: 0x06036A17 RID: 223767 RVA: 0x0074F7CE File Offset: 0x0074D9CE
		public ELeisureInteract Type { get; set; }

		// Token: 0x06036A18 RID: 223768 RVA: 0x0074F7D7 File Offset: 0x0074D9D7
		public ISoar2T()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
