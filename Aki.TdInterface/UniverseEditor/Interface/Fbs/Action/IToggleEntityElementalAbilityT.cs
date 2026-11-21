using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BF1 RID: 31729
	public class IToggleEntityElementalAbilityT
	{
		// Token: 0x1700EDB0 RID: 60848
		// (get) Token: 0x0603931E RID: 234270 RVA: 0x007BA32C File Offset: 0x007B852C
		// (set) Token: 0x0603931F RID: 234271 RVA: 0x007BA334 File Offset: 0x007B8534
		public int EntityId { get; set; }

		// Token: 0x1700EDB1 RID: 60849
		// (get) Token: 0x06039320 RID: 234272 RVA: 0x007BA33D File Offset: 0x007B853D
		// (set) Token: 0x06039321 RID: 234273 RVA: 0x007BA345 File Offset: 0x007B8545
		public bool Enable { get; set; }

		// Token: 0x06039322 RID: 234274 RVA: 0x007BA34E File Offset: 0x007B854E
		public IToggleEntityElementalAbilityT()
		{
			this.EntityId = 0;
			this.Enable = false;
		}
	}
}
