using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C29 RID: 7209
	public class IFlowInfo_SetValue
	{
		// Token: 0x04005E35 RID: 24117
		public string ObjType;

		// Token: 0x04005E36 RID: 24118
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> Children;

		// Token: 0x04005E37 RID: 24119
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> Reference;

		// Token: 0x04005E38 RID: 24120
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> WeakReference;

		// Token: 0x04005E39 RID: 24121
		[Nullable(2)]
		public string EdPlannedBranch;

		// Token: 0x04005E3A RID: 24122
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> EdTextRef;

		// Token: 0x04005E3B RID: 24123
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> _children;

		// Token: 0x04005E3C RID: 24124
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> _reference;

		// Token: 0x04005E3D RID: 24125
		public int Id;

		// Token: 0x04005E3E RID: 24126
		public string Name;

		// Token: 0x04005E3F RID: 24127
		public int? DungeonId;

		// Token: 0x04005E40 RID: 24128
		public bool? _folded;

		// Token: 0x04005E41 RID: 24129
		public int? _selectedStateId;

		// Token: 0x04005E42 RID: 24130
		[Nullable(2)]
		public List<int> _selectedStateIds;

		// Token: 0x04005E43 RID: 24131
		[Nullable(2)]
		public IVarContext VarContext;

		// Token: 0x04005E44 RID: 24132
		public List<IStateInfo> States;

		// Token: 0x04005E45 RID: 24133
		public bool? EdIsReserved;
	}
}
