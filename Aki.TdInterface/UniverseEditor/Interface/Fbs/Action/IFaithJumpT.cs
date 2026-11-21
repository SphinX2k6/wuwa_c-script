using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E1C RID: 28188
	public class IFaithJumpT
	{
		// Token: 0x1700CE9B RID: 52891
		// (get) Token: 0x06030AC0 RID: 199360 RVA: 0x0069B486 File Offset: 0x00699686
		// (set) Token: 0x06030AC1 RID: 199361 RVA: 0x0069B48E File Offset: 0x0069968E
		public ELeisureInteract Type { get; set; }

		// Token: 0x06030AC2 RID: 199362 RVA: 0x0069B497 File Offset: 0x00699697
		public IFaithJumpT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
