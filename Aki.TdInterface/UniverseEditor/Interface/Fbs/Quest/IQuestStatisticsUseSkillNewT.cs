using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044A0 RID: 17568
	public class IQuestStatisticsUseSkillNewT
	{
		// Token: 0x17007A0F RID: 31247
		// (get) Token: 0x06019510 RID: 103696 RVA: 0x0039D18D File Offset: 0x0039B38D
		// (set) Token: 0x06019511 RID: 103697 RVA: 0x0039D195 File Offset: 0x0039B395
		public EStatisticsEventType Type { get; set; }

		// Token: 0x17007A10 RID: 31248
		// (get) Token: 0x06019512 RID: 103698 RVA: 0x0039D19E File Offset: 0x0039B39E
		// (set) Token: 0x06019513 RID: 103699 RVA: 0x0039D1A6 File Offset: 0x0039B3A6
		public TVarRefUnion Var { get; set; }

		// Token: 0x17007A11 RID: 31249
		// (get) Token: 0x06019514 RID: 103700 RVA: 0x0039D1AF File Offset: 0x0039B3AF
		// (set) Token: 0x06019515 RID: 103701 RVA: 0x0039D1B7 File Offset: 0x0039B3B7
		public TUseSkillCheckUnion SkillCheck { get; set; }

		// Token: 0x17007A12 RID: 31250
		// (get) Token: 0x06019516 RID: 103702 RVA: 0x0039D1C0 File Offset: 0x0039B3C0
		// (set) Token: 0x06019517 RID: 103703 RVA: 0x0039D1C8 File Offset: 0x0039B3C8
		public bool IsWaitFinish { get; set; }

		// Token: 0x17007A13 RID: 31251
		// (get) Token: 0x06019518 RID: 103704 RVA: 0x0039D1D1 File Offset: 0x0039B3D1
		// (set) Token: 0x06019519 RID: 103705 RVA: 0x0039D1D9 File Offset: 0x0039B3D9
		public byte NullMask { get; set; }

		// Token: 0x0601951A RID: 103706 RVA: 0x0039D1E2 File Offset: 0x0039B3E2
		public IQuestStatisticsUseSkillNewT()
		{
			this.Type = EStatisticsEventType.Collect;
			this.Var = null;
			this.SkillCheck = null;
			this.IsWaitFinish = false;
			this.NullMask = 0;
		}
	}
}
