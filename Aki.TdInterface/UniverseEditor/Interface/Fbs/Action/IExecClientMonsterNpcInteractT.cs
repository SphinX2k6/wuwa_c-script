using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D8F RID: 28047
	public class IExecClientMonsterNpcInteractT
	{
		// Token: 0x1700CDB4 RID: 52660
		// (get) Token: 0x06030683 RID: 198275 RVA: 0x00693E7F File Offset: 0x0069207F
		// (set) Token: 0x06030684 RID: 198276 RVA: 0x00693E87 File Offset: 0x00692087
		public int MonsterNpcEntityId { get; set; }

		// Token: 0x1700CDB5 RID: 52661
		// (get) Token: 0x06030685 RID: 198277 RVA: 0x00693E90 File Offset: 0x00692090
		// (set) Token: 0x06030686 RID: 198278 RVA: 0x00693E98 File Offset: 0x00692098
		public IMonsterNpcInteractTriggerHookT Config { get; set; }

		// Token: 0x06030687 RID: 198279 RVA: 0x00693EA1 File Offset: 0x006920A1
		public IExecClientMonsterNpcInteractT()
		{
			this.MonsterNpcEntityId = 0;
			this.Config = null;
		}
	}
}
