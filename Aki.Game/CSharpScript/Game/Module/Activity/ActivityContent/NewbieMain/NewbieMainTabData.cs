using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.NewbieMain
{
	// Token: 0x02006389 RID: 25481
	[NullableContext(1)]
	[Nullable(0)]
	public class NewbieMainTabData
	{
		// Token: 0x0604013F RID: 262463 RVA: 0x00F814AC File Offset: 0x00F7F6AC
		public NewbieMainTabData(int tabId)
		{
			this.TabId = tabId;
		}

		// Token: 0x06040140 RID: 262464 RVA: 0x00F814C6 File Offset: 0x00F7F6C6
		public void SetCompletedTaskIds(IEnumerable<int> ids)
		{
			this.CompletedTaskIdsInternal = new HashSet<int>(ids);
		}

		// Token: 0x06040141 RID: 262465 RVA: 0x00F814D4 File Offset: 0x00F7F6D4
		public bool IsTaskCompleted(int taskId)
		{
			return this.CompletedTaskIdsInternal.Contains(taskId);
		}

		// Token: 0x06040142 RID: 262466 RVA: 0x00F814E2 File Offset: 0x00F7F6E2
		public HashSet<int> GetCompletedTaskIds()
		{
			return this.CompletedTaskIdsInternal;
		}

		// Token: 0x06040143 RID: 262467 RVA: 0x00F814EA File Offset: 0x00F7F6EA
		public int GetCompletedTaskCount()
		{
			return this.CompletedTaskIdsInternal.Count;
		}

		// Token: 0x04021642 RID: 136770
		public readonly int TabId;

		// Token: 0x04021643 RID: 136771
		private HashSet<int> CompletedTaskIdsInternal = new HashSet<int>();
	}
}
