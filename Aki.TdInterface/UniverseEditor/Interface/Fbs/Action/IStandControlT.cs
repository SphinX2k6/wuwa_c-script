using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071A9 RID: 29097
	public class IStandControlT
	{
		// Token: 0x1700D818 RID: 55320
		// (get) Token: 0x06033974 RID: 211316 RVA: 0x006F2972 File Offset: 0x006F0B72
		// (set) Token: 0x06033975 RID: 211317 RVA: 0x006F297A File Offset: 0x006F0B7A
		public ELeisureInteract Type { get; set; }

		// Token: 0x06033976 RID: 211318 RVA: 0x006F2983 File Offset: 0x006F0B83
		public IStandControlT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
