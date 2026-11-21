using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004659 RID: 18009
	public class ITrackEntityGroupT
	{
		// Token: 0x17007E1E RID: 32286
		// (get) Token: 0x0601A66A RID: 108138 RVA: 0x003C225A File Offset: 0x003C045A
		// (set) Token: 0x0601A66B RID: 108139 RVA: 0x003C2262 File Offset: 0x003C0462
		public ETrackType Type { get; set; }

		// Token: 0x17007E1F RID: 32287
		// (get) Token: 0x0601A66C RID: 108140 RVA: 0x003C226B File Offset: 0x003C046B
		// (set) Token: 0x0601A66D RID: 108141 RVA: 0x003C2273 File Offset: 0x003C0473
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x17007E20 RID: 32288
		// (get) Token: 0x0601A66E RID: 108142 RVA: 0x003C227C File Offset: 0x003C047C
		// (set) Token: 0x0601A66F RID: 108143 RVA: 0x003C2284 File Offset: 0x003C0484
		public List<int> Entities { get; set; }

		// Token: 0x17007E21 RID: 32289
		// (get) Token: 0x0601A670 RID: 108144 RVA: 0x003C228D File Offset: 0x003C048D
		// (set) Token: 0x0601A671 RID: 108145 RVA: 0x003C2295 File Offset: 0x003C0495
		public TTrackRuleTypeUnion TrackRuleType { get; set; }

		// Token: 0x0601A672 RID: 108146 RVA: 0x003C229E File Offset: 0x003C049E
		public ITrackEntityGroupT()
		{
			this.Type = ETrackType.Locations;
			this.GravityDirection = null;
			this.Entities = null;
			this.TrackRuleType = null;
		}
	}
}
