using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D20 RID: 32032
	public class IVehiclePlayerMotorT
	{
		// Token: 0x1700EFC8 RID: 61384
		// (get) Token: 0x06039D33 RID: 236851 RVA: 0x007CD3FE File Offset: 0x007CB5FE
		// (set) Token: 0x06039D34 RID: 236852 RVA: 0x007CD406 File Offset: 0x007CB606
		public ETargetVehicle Type { get; set; }

		// Token: 0x1700EFC9 RID: 61385
		// (get) Token: 0x06039D35 RID: 236853 RVA: 0x007CD40F File Offset: 0x007CB60F
		// (set) Token: 0x06039D36 RID: 236854 RVA: 0x007CD417 File Offset: 0x007CB617
		public int SummonPositionEntityId { get; set; }

		// Token: 0x1700EFCA RID: 61386
		// (get) Token: 0x06039D37 RID: 236855 RVA: 0x007CD420 File Offset: 0x007CB620
		// (set) Token: 0x06039D38 RID: 236856 RVA: 0x007CD428 File Offset: 0x007CB628
		public byte NullMask { get; set; }

		// Token: 0x06039D39 RID: 236857 RVA: 0x007CD431 File Offset: 0x007CB631
		public IVehiclePlayerMotorT()
		{
			this.Type = ETargetVehicle.Current;
			this.SummonPositionEntityId = 0;
			this.NullMask = 0;
		}
	}
}
