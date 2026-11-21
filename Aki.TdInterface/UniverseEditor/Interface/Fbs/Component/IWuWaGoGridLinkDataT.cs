using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061C7 RID: 25031
	public class IWuWaGoGridLinkDataT
	{
		// Token: 0x1700BAA9 RID: 47785
		// (get) Token: 0x0602A8F6 RID: 174326 RVA: 0x005CDDF0 File Offset: 0x005CBFF0
		// (set) Token: 0x0602A8F7 RID: 174327 RVA: 0x005CDDF8 File Offset: 0x005CBFF8
		public EWuWaGoGridLinkType GridLinkType { get; set; }

		// Token: 0x1700BAAA RID: 47786
		// (get) Token: 0x0602A8F8 RID: 174328 RVA: 0x005CDE01 File Offset: 0x005CC001
		// (set) Token: 0x0602A8F9 RID: 174329 RVA: 0x005CDE09 File Offset: 0x005CC009
		public EWuWaGoGridRotationType RotationType { get; set; }

		// Token: 0x0602A8FA RID: 174330 RVA: 0x005CDE12 File Offset: 0x005CC012
		public IWuWaGoGridLinkDataT()
		{
			this.GridLinkType = EWuWaGoGridLinkType.EmptyGrid;
			this.RotationType = EWuWaGoGridRotationType.Front;
		}
	}
}
