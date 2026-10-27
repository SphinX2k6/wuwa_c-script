using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059CC RID: 22988
	public class IStealthNearbyTrackingT
	{
		// Token: 0x1700ACAE RID: 44206
		// (get) Token: 0x06026FCC RID: 159692 RVA: 0x0055D671 File Offset: 0x0055B871
		// (set) Token: 0x06026FCD RID: 159693 RVA: 0x0055D679 File Offset: 0x0055B879
		public ENearbyTrackingType Type { get; set; }

		// Token: 0x1700ACAF RID: 44207
		// (get) Token: 0x06026FCE RID: 159694 RVA: 0x0055D682 File Offset: 0x0055B882
		// (set) Token: 0x06026FCF RID: 159695 RVA: 0x0055D68A File Offset: 0x0055B88A
		public int ShowRange { get; set; }

		// Token: 0x1700ACB0 RID: 44208
		// (get) Token: 0x06026FD0 RID: 159696 RVA: 0x0055D693 File Offset: 0x0055B893
		// (set) Token: 0x06026FD1 RID: 159697 RVA: 0x0055D69B File Offset: 0x0055B89B
		public int HideRange { get; set; }

		// Token: 0x1700ACB1 RID: 44209
		// (get) Token: 0x06026FD2 RID: 159698 RVA: 0x0055D6A4 File Offset: 0x0055B8A4
		// (set) Token: 0x06026FD3 RID: 159699 RVA: 0x0055D6AC File Offset: 0x0055B8AC
		public string Icon { get; set; }

		// Token: 0x1700ACB2 RID: 44210
		// (get) Token: 0x06026FD4 RID: 159700 RVA: 0x0055D6B5 File Offset: 0x0055B8B5
		// (set) Token: 0x06026FD5 RID: 159701 RVA: 0x0055D6BD File Offset: 0x0055B8BD
		public IVectorInfoT IconOffset { get; set; }

		// Token: 0x06026FD6 RID: 159702 RVA: 0x0055D6C6 File Offset: 0x0055B8C6
		public IStealthNearbyTrackingT()
		{
			this.Type = ENearbyTrackingType.Icon;
			this.ShowRange = 0;
			this.HideRange = 0;
			this.Icon = null;
			this.IconOffset = null;
		}
	}
}
