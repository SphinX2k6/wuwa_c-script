using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005429 RID: 21545
	public class IInitStateStandbyT
	{
		// Token: 0x17009E79 RID: 40569
		// (get) Token: 0x06023649 RID: 144969 RVA: 0x004E5B6B File Offset: 0x004E3D6B
		// (set) Token: 0x0602364A RID: 144970 RVA: 0x004E5B73 File Offset: 0x004E3D73
		public EInitStateType Type { get; set; }

		// Token: 0x17009E7A RID: 40570
		// (get) Token: 0x0602364B RID: 144971 RVA: 0x004E5B7C File Offset: 0x004E3D7C
		// (set) Token: 0x0602364C RID: 144972 RVA: 0x004E5B84 File Offset: 0x004E3D84
		public List<string> StandbyTags { get; set; }

		// Token: 0x17009E7B RID: 40571
		// (get) Token: 0x0602364D RID: 144973 RVA: 0x004E5B8D File Offset: 0x004E3D8D
		// (set) Token: 0x0602364E RID: 144974 RVA: 0x004E5B95 File Offset: 0x004E3D95
		public List<int> EmotionBubbleIds { get; set; }

		// Token: 0x17009E7C RID: 40572
		// (get) Token: 0x0602364F RID: 144975 RVA: 0x004E5B9E File Offset: 0x004E3D9E
		// (set) Token: 0x06023650 RID: 144976 RVA: 0x004E5BA6 File Offset: 0x004E3DA6
		public List<IConditionGroupT> Conditions { get; set; }

		// Token: 0x17009E7D RID: 40573
		// (get) Token: 0x06023651 RID: 144977 RVA: 0x004E5BAF File Offset: 0x004E3DAF
		// (set) Token: 0x06023652 RID: 144978 RVA: 0x004E5BB7 File Offset: 0x004E3DB7
		public EAiWanderType Wander { get; set; }

		// Token: 0x17009E7E RID: 40574
		// (get) Token: 0x06023653 RID: 144979 RVA: 0x004E5BC0 File Offset: 0x004E3DC0
		// (set) Token: 0x06023654 RID: 144980 RVA: 0x004E5BC8 File Offset: 0x004E3DC8
		public byte NullMask { get; set; }

		// Token: 0x06023655 RID: 144981 RVA: 0x004E5BD1 File Offset: 0x004E3DD1
		public IInitStateStandbyT()
		{
			this.Type = EInitStateType.Birth;
			this.StandbyTags = null;
			this.EmotionBubbleIds = null;
			this.Conditions = null;
			this.Wander = EAiWanderType.None;
			this.NullMask = 0;
		}
	}
}
