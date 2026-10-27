using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A0C RID: 27148
	public class ILiftMoveTypeTeleportT
	{
		// Token: 0x1700C96D RID: 51565
		// (get) Token: 0x0602F81F RID: 194591 RVA: 0x00678172 File Offset: 0x00676372
		// (set) Token: 0x0602F820 RID: 194592 RVA: 0x0067817A File Offset: 0x0067637A
		public ELiftMoveType Type { get; set; }

		// Token: 0x1700C96E RID: 51566
		// (get) Token: 0x0602F821 RID: 194593 RVA: 0x00678183 File Offset: 0x00676383
		// (set) Token: 0x0602F822 RID: 194594 RVA: 0x0067818B File Offset: 0x0067638B
		public float StartTeleportOffsetDistance { get; set; }

		// Token: 0x1700C96F RID: 51567
		// (get) Token: 0x0602F823 RID: 194595 RVA: 0x00678194 File Offset: 0x00676394
		// (set) Token: 0x0602F824 RID: 194596 RVA: 0x0067819C File Offset: 0x0067639C
		public float EndTeleportOffsetDistance { get; set; }

		// Token: 0x1700C970 RID: 51568
		// (get) Token: 0x0602F825 RID: 194597 RVA: 0x006781A5 File Offset: 0x006763A5
		// (set) Token: 0x0602F826 RID: 194598 RVA: 0x006781AD File Offset: 0x006763AD
		public bool SendTeleportEvent { get; set; }

		// Token: 0x1700C971 RID: 51569
		// (get) Token: 0x0602F827 RID: 194599 RVA: 0x006781B6 File Offset: 0x006763B6
		// (set) Token: 0x0602F828 RID: 194600 RVA: 0x006781BE File Offset: 0x006763BE
		public float TeleportStartEventOffsetDistance { get; set; }

		// Token: 0x0602F829 RID: 194601 RVA: 0x006781C7 File Offset: 0x006763C7
		public ILiftMoveTypeTeleportT()
		{
			this.Type = ELiftMoveType.Default;
			this.StartTeleportOffsetDistance = 0f;
			this.EndTeleportOffsetDistance = 0f;
			this.SendTeleportEvent = false;
			this.TeleportStartEventOffsetDistance = 0f;
		}
	}
}
