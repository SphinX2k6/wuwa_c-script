using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200127F RID: 4735
	public class ISubBehaviorTreeFile_SetValue
	{
		// Token: 0x04003FC8 RID: 16328
		public int Id;

		// Token: 0x04003FC9 RID: 16329
		public string ParentUid;

		// Token: 0x04003FCA RID: 16330
		public IBehaviorTree Tree;

		// Token: 0x04003FCB RID: 16331
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> Children;

		// Token: 0x04003FCC RID: 16332
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> Reference;

		// Token: 0x04003FCD RID: 16333
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> WeakReference;

		// Token: 0x04003FCE RID: 16334
		public string _name;

		// Token: 0x04003FCF RID: 16335
		public string _path;

		// Token: 0x04003FD0 RID: 16336
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> EdTextRef;
	}
}
