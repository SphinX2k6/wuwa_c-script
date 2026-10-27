using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A94 RID: 6804
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowInfo_SetValue
	{
		// Token: 0x040059D0 RID: 22992
		public string ObjType;

		// Token: 0x040059D1 RID: 22993
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> Children;

		// Token: 0x040059D2 RID: 22994
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> Reference;

		// Token: 0x040059D3 RID: 22995
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> WeakReference;

		// Token: 0x040059D4 RID: 22996
		[Nullable(2)]
		public string EdPlannedBranch;

		// Token: 0x040059D5 RID: 22997
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> EdTextRef;

		// Token: 0x040059D6 RID: 22998
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> _children;

		// Token: 0x040059D7 RID: 22999
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> _reference;

		// Token: 0x040059D8 RID: 23000
		public int Id;

		// Token: 0x040059D9 RID: 23001
		public string Name;

		// Token: 0x040059DA RID: 23002
		public int? DungeonId;

		// Token: 0x040059DB RID: 23003
		public bool? _folded;

		// Token: 0x040059DC RID: 23004
		public int? _selectedStateId;

		// Token: 0x040059DD RID: 23005
		[Nullable(2)]
		public IVarContext VarContext;

		// Token: 0x040059DE RID: 23006
		public List<IStateInfo> States;

		// Token: 0x040059DF RID: 23007
		public bool? EdIsReserved;
	}
}
