using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B4A RID: 23370
	public class IMotorAutoEjectNextHookConfigT
	{
		// Token: 0x1700AA81 RID: 43649
		// (get) Token: 0x060266FA RID: 157434 RVA: 0x00543568 File Offset: 0x00541768
		// (set) Token: 0x060266FB RID: 157435 RVA: 0x00543570 File Offset: 0x00541770
		public EMotorAutoEjectType Type { get; set; }

		// Token: 0x1700AA82 RID: 43650
		// (get) Token: 0x060266FC RID: 157436 RVA: 0x00543579 File Offset: 0x00541779
		// (set) Token: 0x060266FD RID: 157437 RVA: 0x00543581 File Offset: 0x00541781
		public int EntityId { get; set; }

		// Token: 0x060266FE RID: 157438 RVA: 0x0054358A File Offset: 0x0054178A
		public IMotorAutoEjectNextHookConfigT()
		{
			this.Type = EMotorAutoEjectType.NextHook;
			this.EntityId = 0;
		}
	}
}
