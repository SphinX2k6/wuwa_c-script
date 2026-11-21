using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005536 RID: 21814
	public class ICompassTrackingT
	{
		// Token: 0x17009BF7 RID: 39927
		// (get) Token: 0x06022811 RID: 141329 RVA: 0x004C0D40 File Offset: 0x004BEF40
		// (set) Token: 0x06022812 RID: 141330 RVA: 0x004C0D48 File Offset: 0x004BEF48
		public ENearbyTrackingType Type { get; set; }

		// Token: 0x17009BF8 RID: 39928
		// (get) Token: 0x06022813 RID: 141331 RVA: 0x004C0D51 File Offset: 0x004BEF51
		// (set) Token: 0x06022814 RID: 141332 RVA: 0x004C0D59 File Offset: 0x004BEF59
		public int ShowRange { get; set; }

		// Token: 0x17009BF9 RID: 39929
		// (get) Token: 0x06022815 RID: 141333 RVA: 0x004C0D62 File Offset: 0x004BEF62
		// (set) Token: 0x06022816 RID: 141334 RVA: 0x004C0D6A File Offset: 0x004BEF6A
		public int HideRange { get; set; }

		// Token: 0x17009BFA RID: 39930
		// (get) Token: 0x06022817 RID: 141335 RVA: 0x004C0D73 File Offset: 0x004BEF73
		// (set) Token: 0x06022818 RID: 141336 RVA: 0x004C0D7B File Offset: 0x004BEF7B
		public IIconNearByTrackingConfigT IconTrackingConfig { get; set; }

		// Token: 0x17009BFB RID: 39931
		// (get) Token: 0x06022819 RID: 141337 RVA: 0x004C0D84 File Offset: 0x004BEF84
		// (set) Token: 0x0602281A RID: 141338 RVA: 0x004C0D8C File Offset: 0x004BEF8C
		public List<EVehicleType> VehicleTypes { get; set; }

		// Token: 0x17009BFC RID: 39932
		// (get) Token: 0x0602281B RID: 141339 RVA: 0x004C0D95 File Offset: 0x004BEF95
		// (set) Token: 0x0602281C RID: 141340 RVA: 0x004C0D9D File Offset: 0x004BEF9D
		public byte NullMask { get; set; }

		// Token: 0x0602281D RID: 141341 RVA: 0x004C0DA6 File Offset: 0x004BEFA6
		public ICompassTrackingT()
		{
			this.Type = ENearbyTrackingType.Icon;
			this.ShowRange = 0;
			this.HideRange = 0;
			this.IconTrackingConfig = null;
			this.VehicleTypes = null;
			this.NullMask = 0;
		}
	}
}
