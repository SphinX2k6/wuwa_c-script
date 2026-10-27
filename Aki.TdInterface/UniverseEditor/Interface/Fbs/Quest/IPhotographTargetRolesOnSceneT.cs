using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F96 RID: 16278
	public class IPhotographTargetRolesOnSceneT
	{
		// Token: 0x170071A5 RID: 29093
		// (get) Token: 0x0601740E RID: 95246 RVA: 0x0035A91E File Offset: 0x00358B1E
		// (set) Token: 0x0601740F RID: 95247 RVA: 0x0035A926 File Offset: 0x00358B26
		public EPhotographTargetType Type { get; set; }

		// Token: 0x06017410 RID: 95248 RVA: 0x0035A92F File Offset: 0x00358B2F
		public IPhotographTargetRolesOnSceneT()
		{
			this.Type = EPhotographTargetType.Player;
		}
	}
}
