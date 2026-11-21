using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004140 RID: 16704
	public class IAwakeAndLoadEntityConditionT
	{
		// Token: 0x1700711D RID: 28957
		// (get) Token: 0x06016F05 RID: 93957 RVA: 0x00345E52 File Offset: 0x00344052
		// (set) Token: 0x06016F06 RID: 93958 RVA: 0x00345E5A File Offset: 0x0034405A
		public EChildQuest Type { get; set; }

		// Token: 0x1700711E RID: 28958
		// (get) Token: 0x06016F07 RID: 93959 RVA: 0x00345E63 File Offset: 0x00344063
		// (set) Token: 0x06016F08 RID: 93960 RVA: 0x00345E6B File Offset: 0x0034406B
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x1700711F RID: 28959
		// (get) Token: 0x06016F09 RID: 93961 RVA: 0x00345E74 File Offset: 0x00344074
		// (set) Token: 0x06016F0A RID: 93962 RVA: 0x00345E7C File Offset: 0x0034407C
		public List<int> EntityIds { get; set; }

		// Token: 0x17007120 RID: 28960
		// (get) Token: 0x06016F0B RID: 93963 RVA: 0x00345E85 File Offset: 0x00344085
		// (set) Token: 0x06016F0C RID: 93964 RVA: 0x00345E8D File Offset: 0x0034408D
		public bool IsWaitForShow { get; set; }

		// Token: 0x17007121 RID: 28961
		// (get) Token: 0x06016F0D RID: 93965 RVA: 0x00345E96 File Offset: 0x00344096
		// (set) Token: 0x06016F0E RID: 93966 RVA: 0x00345E9E File Offset: 0x0034409E
		public byte NullMask { get; set; }

		// Token: 0x06016F0F RID: 93967 RVA: 0x00345EA7 File Offset: 0x003440A7
		public IAwakeAndLoadEntityConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.EntityIds = null;
			this.IsWaitForShow = false;
			this.NullMask = 0;
		}
	}
}
