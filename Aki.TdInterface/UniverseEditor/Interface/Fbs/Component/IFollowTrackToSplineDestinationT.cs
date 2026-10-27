using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052B6 RID: 21174
	public class IFollowTrackToSplineDestinationT
	{
		// Token: 0x17009B45 RID: 39749
		// (get) Token: 0x06022863 RID: 141411 RVA: 0x004C907B File Offset: 0x004C727B
		// (set) Token: 0x06022864 RID: 141412 RVA: 0x004C9083 File Offset: 0x004C7283
		public EFollowTrackEndType Type { get; set; }

		// Token: 0x17009B46 RID: 39750
		// (get) Token: 0x06022865 RID: 141413 RVA: 0x004C908C File Offset: 0x004C728C
		// (set) Token: 0x06022866 RID: 141414 RVA: 0x004C9094 File Offset: 0x004C7294
		public string ChangeSelfState { get; set; }

		// Token: 0x06022867 RID: 141415 RVA: 0x004C909D File Offset: 0x004C729D
		public IFollowTrackToSplineDestinationT()
		{
			this.Type = EFollowTrackEndType.ToStart;
			this.ChangeSelfState = null;
		}
	}
}
