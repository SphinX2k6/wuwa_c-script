using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.NewbieMain
{
	// Token: 0x02005307 RID: 21255
	[NullableContext(1)]
	[Nullable(0)]
	public class NewbieMainTabData
	{
		// Token: 0x06034E00 RID: 216576 RVA: 0x00EC8410 File Offset: 0x00EC6610
		public NewbieMainTabData(int tabId)
		{
			this.TabId = tabId;
		}

		// Token: 0x06034E01 RID: 216577 RVA: 0x00EC842A File Offset: 0x00EC662A
		public void SetCompletedTaskIds(IEnumerable<int> ids)
		{
			this.CompletedTaskIdsInternal = new HashSet<int>(ids);
		}

		// Token: 0x06034E02 RID: 216578 RVA: 0x00EC8438 File Offset: 0x00EC6638
		public bool IsTaskCompleted(int taskId)
		{
			return this.CompletedTaskIdsInternal.Contains(taskId);
		}

		// Token: 0x06034E03 RID: 216579 RVA: 0x00EC8446 File Offset: 0x00EC6646
		public HashSet<int> GetCompletedTaskIds()
		{
			return this.CompletedTaskIdsInternal;
		}

		// Token: 0x06034E04 RID: 216580 RVA: 0x00EC844E File Offset: 0x00EC664E
		public int GetCompletedTaskCount()
		{
			return this.CompletedTaskIdsInternal.Count;
		}

		// Token: 0x0401BF71 RID: 114545
		public readonly int TabId;

		// Token: 0x0401BF72 RID: 114546
		private HashSet<int> CompletedTaskIdsInternal = new HashSet<int>();
	}
}
