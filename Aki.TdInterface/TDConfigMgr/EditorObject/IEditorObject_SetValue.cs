using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.EditorObject
{
	// Token: 0x0200000D RID: 13
	public class IEditorObject_SetValue
	{
		// Token: 0x0400001F RID: 31
		public TEditorObjectType ObjType;

		// Token: 0x04000020 RID: 32
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> Children;

		// Token: 0x04000021 RID: 33
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> Reference;

		// Token: 0x04000022 RID: 34
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> WeakReference;

		// Token: 0x04000023 RID: 35
		[Nullable(2)]
		public string EdPlannedBranch;

		// Token: 0x04000024 RID: 36
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> EdTextRef;

		// Token: 0x04000025 RID: 37
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> _children;

		// Token: 0x04000026 RID: 38
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> _reference;
	}
}
