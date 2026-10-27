using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200450A RID: 17674
	public class ILevelPlayOpenConditionT
	{
		// Token: 0x17007D51 RID: 32081
		// (get) Token: 0x0601A8EB RID: 108779 RVA: 0x003CB147 File Offset: 0x003C9347
		// (set) Token: 0x0601A8EC RID: 108780 RVA: 0x003CB14F File Offset: 0x003C934F
		public EConditionCount Type { get; set; }

		// Token: 0x17007D52 RID: 32082
		// (get) Token: 0x0601A8ED RID: 108781 RVA: 0x003CB158 File Offset: 0x003C9358
		// (set) Token: 0x0601A8EE RID: 108782 RVA: 0x003CB160 File Offset: 0x003C9360
		public List<TAccessQuestConditionUnion> Conditions { get; set; }

		// Token: 0x17007D53 RID: 32083
		// (get) Token: 0x0601A8EF RID: 108783 RVA: 0x003CB169 File Offset: 0x003C9369
		// (set) Token: 0x0601A8F0 RID: 108784 RVA: 0x003CB171 File Offset: 0x003C9371
		public bool DelayRefresh { get; set; }

		// Token: 0x17007D54 RID: 32084
		// (get) Token: 0x0601A8F1 RID: 108785 RVA: 0x003CB17A File Offset: 0x003C937A
		// (set) Token: 0x0601A8F2 RID: 108786 RVA: 0x003CB182 File Offset: 0x003C9382
		public byte NullMask { get; set; }

		// Token: 0x0601A8F3 RID: 108787 RVA: 0x003CB18B File Offset: 0x003C938B
		public ILevelPlayOpenConditionT()
		{
			this.Type = EConditionCount.All;
			this.Conditions = null;
			this.DelayRefresh = false;
			this.NullMask = 0;
		}
	}
}
