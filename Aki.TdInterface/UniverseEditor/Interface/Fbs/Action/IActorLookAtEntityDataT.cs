using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006740 RID: 26432
	public class IActorLookAtEntityDataT
	{
		// Token: 0x1700C029 RID: 49193
		// (get) Token: 0x0602CC97 RID: 183447 RVA: 0x00620648 File Offset: 0x0061E848
		// (set) Token: 0x0602CC98 RID: 183448 RVA: 0x00620650 File Offset: 0x0061E850
		public EActorLookAtMode Type { get; set; }

		// Token: 0x1700C02A RID: 49194
		// (get) Token: 0x0602CC99 RID: 183449 RVA: 0x00620659 File Offset: 0x0061E859
		// (set) Token: 0x0602CC9A RID: 183450 RVA: 0x00620661 File Offset: 0x0061E861
		public bool Lock { get; set; }

		// Token: 0x1700C02B RID: 49195
		// (get) Token: 0x0602CC9B RID: 183451 RVA: 0x0062066A File Offset: 0x0061E86A
		// (set) Token: 0x0602CC9C RID: 183452 RVA: 0x00620672 File Offset: 0x0061E872
		public int EntityId { get; set; }

		// Token: 0x1700C02C RID: 49196
		// (get) Token: 0x0602CC9D RID: 183453 RVA: 0x0062067B File Offset: 0x0061E87B
		// (set) Token: 0x0602CC9E RID: 183454 RVA: 0x00620683 File Offset: 0x0061E883
		public byte NullMask { get; set; }

		// Token: 0x0602CC9F RID: 183455 RVA: 0x0062068C File Offset: 0x0061E88C
		public IActorLookAtEntityDataT()
		{
			this.Type = EActorLookAtMode.Talker;
			this.Lock = false;
			this.EntityId = 0;
			this.NullMask = 0;
		}
	}
}
