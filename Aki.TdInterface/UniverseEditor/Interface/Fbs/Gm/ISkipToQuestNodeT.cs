using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046A6 RID: 18086
	public class ISkipToQuestNodeT
	{
		// Token: 0x17008077 RID: 32887
		// (get) Token: 0x0601B7A5 RID: 112549 RVA: 0x003E6CE3 File Offset: 0x003E4EE3
		// (set) Token: 0x0601B7A6 RID: 112550 RVA: 0x003E6CEB File Offset: 0x003E4EEB
		public EGmCommand Type { get; set; }

		// Token: 0x17008078 RID: 32888
		// (get) Token: 0x0601B7A7 RID: 112551 RVA: 0x003E6CF4 File Offset: 0x003E4EF4
		// (set) Token: 0x0601B7A8 RID: 112552 RVA: 0x003E6CFC File Offset: 0x003E4EFC
		public IChildQuestConditionT Quest { get; set; }

		// Token: 0x17008079 RID: 32889
		// (get) Token: 0x0601B7A9 RID: 112553 RVA: 0x003E6D05 File Offset: 0x003E4F05
		// (set) Token: 0x0601B7AA RID: 112554 RVA: 0x003E6D0D File Offset: 0x003E4F0D
		public bool IsTeleport { get; set; }

		// Token: 0x1700807A RID: 32890
		// (get) Token: 0x0601B7AB RID: 112555 RVA: 0x003E6D16 File Offset: 0x003E4F16
		// (set) Token: 0x0601B7AC RID: 112556 RVA: 0x003E6D1E File Offset: 0x003E4F1E
		public bool IsFastMode { get; set; }

		// Token: 0x0601B7AD RID: 112557 RVA: 0x003E6D27 File Offset: 0x003E4F27
		public ISkipToQuestNodeT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.Quest = null;
			this.IsTeleport = false;
			this.IsFastMode = false;
		}
	}
}
