using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200670F RID: 26383
	public class IExecClientMonsterNpcInteractT
	{
		// Token: 0x1700C3FE RID: 50174
		// (get) Token: 0x0602DE3D RID: 187965 RVA: 0x0064673B File Offset: 0x0064493B
		// (set) Token: 0x0602DE3E RID: 187966 RVA: 0x00646743 File Offset: 0x00644943
		public int MonsterNpcEntityId { get; set; }

		// Token: 0x1700C3FF RID: 50175
		// (get) Token: 0x0602DE3F RID: 187967 RVA: 0x0064674C File Offset: 0x0064494C
		// (set) Token: 0x0602DE40 RID: 187968 RVA: 0x00646754 File Offset: 0x00644954
		public IMonsterNpcInteractTriggerHookT Config { get; set; }

		// Token: 0x0602DE41 RID: 187969 RVA: 0x0064675D File Offset: 0x0064495D
		public IExecClientMonsterNpcInteractT()
		{
			this.MonsterNpcEntityId = 0;
			this.Config = null;
		}
	}
}
