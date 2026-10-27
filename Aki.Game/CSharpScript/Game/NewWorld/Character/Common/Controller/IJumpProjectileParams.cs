using System;

namespace CSharpScript.Game.NewWorld.Character.Common.Controller
{
	// Token: 0x020070B3 RID: 28851
	public interface IJumpProjectileParams
	{
		// Token: 0x17009C5A RID: 40026
		// (get) Token: 0x0604656B RID: 288107
		// (set) Token: 0x0604656C RID: 288108
		float Length { get; set; }

		// Token: 0x17009C5B RID: 40027
		// (get) Token: 0x0604656D RID: 288109
		// (set) Token: 0x0604656E RID: 288110
		float AllTime { get; set; }

		// Token: 0x17009C5C RID: 40028
		// (get) Token: 0x0604656F RID: 288111
		// (set) Token: 0x06046570 RID: 288112
		float Height0 { get; set; }

		// Token: 0x17009C5D RID: 40029
		// (get) Token: 0x06046571 RID: 288113
		// (set) Token: 0x06046572 RID: 288114
		float ProjectileA { get; set; }

		// Token: 0x17009C5E RID: 40030
		// (get) Token: 0x06046573 RID: 288115
		// (set) Token: 0x06046574 RID: 288116
		float ProjectileB { get; set; }
	}
}
