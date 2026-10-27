using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200114F RID: 4431
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubBehaviorTreeFile_SetValue
	{
		// Token: 0x04003C75 RID: 15477
		public int Id;

		// Token: 0x04003C76 RID: 15478
		public string ParentUid;

		// Token: 0x04003C77 RID: 15479
		public IBehaviorTree Tree;

		// Token: 0x04003C78 RID: 15480
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> Children;

		// Token: 0x04003C79 RID: 15481
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> Reference;

		// Token: 0x04003C7A RID: 15482
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> WeakReference;

		// Token: 0x04003C7B RID: 15483
		public string _name;

		// Token: 0x04003C7C RID: 15484
		public string _path;

		// Token: 0x04003C7D RID: 15485
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> EdTextRef;
	}
}
