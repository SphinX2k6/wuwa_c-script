using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007089 RID: 28809
	public class IKiteHookInteractT
	{
		// Token: 0x1700D313 RID: 54035
		// (get) Token: 0x06031FAD RID: 204717 RVA: 0x006C391C File Offset: 0x006C1B1C
		// (set) Token: 0x06031FAE RID: 204718 RVA: 0x006C3924 File Offset: 0x006C1B24
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700D314 RID: 54036
		// (get) Token: 0x06031FAF RID: 204719 RVA: 0x006C392D File Offset: 0x006C1B2D
		// (set) Token: 0x06031FB0 RID: 204720 RVA: 0x006C3935 File Offset: 0x006C1B35
		public int EntityId { get; set; }

		// Token: 0x06031FB1 RID: 204721 RVA: 0x006C393E File Offset: 0x006C1B3E
		public IKiteHookInteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.EntityId = 0;
		}
	}
}
