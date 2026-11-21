using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020F1 RID: 8433
	[NullableContext(2)]
	[Nullable(0)]
	public class IStateInfo_SetValue
	{
		// Token: 0x04006A2B RID: 27179
		[Nullable(0)]
		public string ObjType;

		// Token: 0x04006A2C RID: 27180
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> Children;

		// Token: 0x04006A2D RID: 27181
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> Reference;

		// Token: 0x04006A2E RID: 27182
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> WeakReference;

		// Token: 0x04006A2F RID: 27183
		public string EdPlannedBranch;

		// Token: 0x04006A30 RID: 27184
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> EdTextRef;

		// Token: 0x04006A31 RID: 27185
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> _children;

		// Token: 0x04006A32 RID: 27186
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> _reference;

		// Token: 0x04006A33 RID: 27187
		public int Id;

		// Token: 0x04006A34 RID: 27188
		[Nullable(0)]
		public string Name;

		// Token: 0x04006A35 RID: 27189
		public bool? _folded;

		// Token: 0x04006A36 RID: 27190
		[Nullable(0)]
		public List<ActionInfo> Actions;

		// Token: 0x04006A37 RID: 27191
		public bool? KeepBgm;

		// Token: 0x04006A38 RID: 27192
		public bool? OnlyPlayOnce;

		// Token: 0x04006A39 RID: 27193
		public bool? KeepInVehicle;

		// Token: 0x04006A3A RID: 27194
		public bool? AllowMultiReference;

		// Token: 0x04006A3B RID: 27195
		public bool? IgnoreInPlotHandBook;

		// Token: 0x04006A3C RID: 27196
		public bool? DontInterruptMatch;

		// Token: 0x04006A3D RID: 27197
		public bool? IsPreloadFlow;

		// Token: 0x04006A3E RID: 27198
		public bool? IsClientFlow;

		// Token: 0x04006A3F RID: 27199
		public bool? _showImport;

		// Token: 0x04006A40 RID: 27200
		public PosA PlotPos;

		// Token: 0x04006A41 RID: 27201
		public IStateProgramSpecialProcessChangeTeamOptimization ProgramSpecialProcess;

		// Token: 0x04006A42 RID: 27202
		public bool? UseConditionalText;

		// Token: 0x04006A43 RID: 27203
		public List<int> _SelectedIndexes;

		// Token: 0x04006A44 RID: 27204
		public string EdPlotNode;

		// Token: 0x04006A45 RID: 27205
		public bool? EdPlotHandleJump;

		// Token: 0x04006A46 RID: 27206
		public string EdPlotFileId;

		// Token: 0x04006A47 RID: 27207
		public int? EdNextPlotKeyId;
	}
}
