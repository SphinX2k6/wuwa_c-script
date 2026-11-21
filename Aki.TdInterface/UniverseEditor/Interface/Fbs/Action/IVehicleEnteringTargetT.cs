using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D02 RID: 32002
	public class IVehicleEnteringTargetT
	{
		// Token: 0x1700EF8D RID: 61325
		// (get) Token: 0x06039C03 RID: 236547 RVA: 0x007CA402 File Offset: 0x007C8602
		// (set) Token: 0x06039C04 RID: 236548 RVA: 0x007CA40A File Offset: 0x007C860A
		public EVehicleEnteringTarget Type { get; set; }

		// Token: 0x1700EF8E RID: 61326
		// (get) Token: 0x06039C05 RID: 236549 RVA: 0x007CA413 File Offset: 0x007C8613
		// (set) Token: 0x06039C06 RID: 236550 RVA: 0x007CA41B File Offset: 0x007C861B
		public int TargetVehicle { get; set; }

		// Token: 0x1700EF8F RID: 61327
		// (get) Token: 0x06039C07 RID: 236551 RVA: 0x007CA424 File Offset: 0x007C8624
		// (set) Token: 0x06039C08 RID: 236552 RVA: 0x007CA42C File Offset: 0x007C862C
		public byte NullMask { get; set; }

		// Token: 0x06039C09 RID: 236553 RVA: 0x007CA435 File Offset: 0x007C8635
		public IVehicleEnteringTargetT()
		{
			this.Type = EVehicleEnteringTarget.Player;
			this.TargetVehicle = 0;
			this.NullMask = 0;
		}
	}
}
