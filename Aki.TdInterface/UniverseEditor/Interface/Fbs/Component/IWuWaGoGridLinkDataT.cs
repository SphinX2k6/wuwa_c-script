using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BB1 RID: 23473
	public class IWuWaGoGridLinkDataT
	{
		// Token: 0x1700B161 RID: 45409
		// (get) Token: 0x06028332 RID: 164658 RVA: 0x00586360 File Offset: 0x00584560
		// (set) Token: 0x06028333 RID: 164659 RVA: 0x00586368 File Offset: 0x00584568
		public EWuWaGoGridLinkType GridLinkType { get; set; }

		// Token: 0x1700B162 RID: 45410
		// (get) Token: 0x06028334 RID: 164660 RVA: 0x00586371 File Offset: 0x00584571
		// (set) Token: 0x06028335 RID: 164661 RVA: 0x00586379 File Offset: 0x00584579
		public EWuWaGoGridRotationType RotationType { get; set; }

		// Token: 0x06028336 RID: 164662 RVA: 0x00586382 File Offset: 0x00584582
		public IWuWaGoGridLinkDataT()
		{
			this.GridLinkType = EWuWaGoGridLinkType.EmptyGrid;
			this.RotationType = EWuWaGoGridRotationType.Front;
		}
	}
}
