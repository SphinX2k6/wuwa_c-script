using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004662 RID: 18018
	public class ITrackLocationsT
	{
		// Token: 0x17007E3A RID: 32314
		// (get) Token: 0x0601A6DE RID: 108254 RVA: 0x003C3569 File Offset: 0x003C1769
		// (set) Token: 0x0601A6DF RID: 108255 RVA: 0x003C3571 File Offset: 0x003C1771
		public ETrackType Type { get; set; }

		// Token: 0x17007E3B RID: 32315
		// (get) Token: 0x0601A6E0 RID: 108256 RVA: 0x003C357A File Offset: 0x003C177A
		// (set) Token: 0x0601A6E1 RID: 108257 RVA: 0x003C3582 File Offset: 0x003C1782
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x17007E3C RID: 32316
		// (get) Token: 0x0601A6E2 RID: 108258 RVA: 0x003C358B File Offset: 0x003C178B
		// (set) Token: 0x0601A6E3 RID: 108259 RVA: 0x003C3593 File Offset: 0x003C1793
		public List<IVectorInfoT> Locations { get; set; }

		// Token: 0x17007E3D RID: 32317
		// (get) Token: 0x0601A6E4 RID: 108260 RVA: 0x003C359C File Offset: 0x003C179C
		// (set) Token: 0x0601A6E5 RID: 108261 RVA: 0x003C35A4 File Offset: 0x003C17A4
		public IOutOfRangeTrackTargetT OutOfRangeTrackTarget { get; set; }

		// Token: 0x17007E3E RID: 32318
		// (get) Token: 0x0601A6E6 RID: 108262 RVA: 0x003C35AD File Offset: 0x003C17AD
		// (set) Token: 0x0601A6E7 RID: 108263 RVA: 0x003C35B5 File Offset: 0x003C17B5
		public IOutOfRangeTrackEntityT OutOfRangeTrackTargetEntity { get; set; }

		// Token: 0x0601A6E8 RID: 108264 RVA: 0x003C35BE File Offset: 0x003C17BE
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
