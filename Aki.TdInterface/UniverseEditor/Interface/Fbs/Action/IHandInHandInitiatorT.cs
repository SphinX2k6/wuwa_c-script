using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F6F RID: 28527
	public class IHandInHandInitiatorT
	{
		// Token: 0x1700D0FD RID: 53501
		// (get) Token: 0x06031612 RID: 202258 RVA: 0x006B266B File Offset: 0x006B086B
		// (set) Token: 0x06031613 RID: 202259 RVA: 0x006B2673 File Offset: 0x006B0873
		public THandInHandInitiatorUnion Initiator { get; set; }

		// Token: 0x1700D0FE RID: 53502
		// (get) Token: 0x06031614 RID: 202260 RVA: 0x006B267C File Offset: 0x006B087C
		// (set) Token: 0x06031615 RID: 202261 RVA: 0x006B2684 File Offset: 0x006B0884
		public EHandType HandType { get; set; }

		// Token: 0x06031616 RID: 202262 RVA: 0x006B268D File Offset: 0x006B088D
		public IHandInHandInitiatorT()
		{
			this.Initiator = null;
			this.HandType = EHandType.Left;
		}
	}
}
