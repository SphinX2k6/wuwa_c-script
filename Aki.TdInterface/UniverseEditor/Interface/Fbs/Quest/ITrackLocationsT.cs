using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004206 RID: 16902
	public class ITrackLocationsT
	{
		// Token: 0x17007809 RID: 30729
		// (get) Token: 0x06018F72 RID: 102258 RVA: 0x00397E91 File Offset: 0x00396091
		// (set) Token: 0x06018F73 RID: 102259 RVA: 0x00397E99 File Offset: 0x00396099
		public ETrackType Type { get; set; }

		// Token: 0x1700780A RID: 30730
		// (get) Token: 0x06018F74 RID: 102260 RVA: 0x00397EA2 File Offset: 0x003960A2
		// (set) Token: 0x06018F75 RID: 102261 RVA: 0x00397EAA File Offset: 0x003960AA
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700780B RID: 30731
		// (get) Token: 0x06018F76 RID: 102262 RVA: 0x00397EB3 File Offset: 0x003960B3
		// (set) Token: 0x06018F77 RID: 102263 RVA: 0x00397EBB File Offset: 0x003960BB
		public List<IVectorInfoT> Locations { get; set; }

		// Token: 0x1700780C RID: 30732
		// (get) Token: 0x06018F78 RID: 102264 RVA: 0x00397EC4 File Offset: 0x003960C4
		// (set) Token: 0x06018F79 RID: 102265 RVA: 0x00397ECC File Offset: 0x003960CC
		public IOutOfRangeTrackTargetT OutOfRangeTrackTarget { get; set; }

		// Token: 0x1700780D RID: 30733
		// (get) Token: 0x06018F7A RID: 102266 RVA: 0x00397ED5 File Offset: 0x003960D5
		// (set) Token: 0x06018F7B RID: 102267 RVA: 0x00397EDD File Offset: 0x003960DD
		public IOutOfRangeTrackEntityT OutOfRangeTrackTargetEntity { get; set; }

		// Token: 0x06018F7C RID: 102268 RVA: 0x00397EE6 File Offset: 0x003960E6
		public ITrackLocationsT()
		{
			this.Type = ETrackType.Locations;
			this.GravityDirection = null;
			this.Locations = null;
			this.OutOfRangeTrackTarget = null;
			this.OutOfRangeTrackTargetEntity = null;
		}
	}
}
