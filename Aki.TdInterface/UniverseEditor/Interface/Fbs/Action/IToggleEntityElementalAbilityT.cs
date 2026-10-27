using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007407 RID: 29703
	public class IToggleEntityElementalAbilityT
	{
		// Token: 0x1700E19B RID: 57755
		// (get) Token: 0x06035F6B RID: 221035 RVA: 0x00757BB8 File Offset: 0x00755DB8
		// (set) Token: 0x06035F6C RID: 221036 RVA: 0x00757BC0 File Offset: 0x00755DC0
		public int EntityId { get; set; }

		// Token: 0x1700E19C RID: 57756
		// (get) Token: 0x06035F6D RID: 221037 RVA: 0x00757BC9 File Offset: 0x00755DC9
		// (set) Token: 0x06035F6E RID: 221038 RVA: 0x00757BD1 File Offset: 0x00755DD1
		public bool Enable { get; set; }

		// Token: 0x06035F6F RID: 221039 RVA: 0x00757BDA File Offset: 0x00755DDA
		public IToggleEntityElementalAbilityT()
		{
			this.EntityId = 0;
			this.Enable = false;
		}
	}
}
