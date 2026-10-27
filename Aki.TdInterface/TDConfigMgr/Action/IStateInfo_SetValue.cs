using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EB8 RID: 7864
	[NullableContext(2)]
	[Nullable(0)]
	public class IStateInfo_SetValue
	{
		// Token: 0x0400643D RID: 25661
		[Nullable(1)]
		public string ObjType;

		// Token: 0x0400643E RID: 25662
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> Children;

		// Token: 0x0400643F RID: 25663
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> Reference;

		// Token: 0x04006440 RID: 25664
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> WeakReference;

		// Token: 0x04006441 RID: 25665
		public string EdPlannedBranch;

		// Token: 0x04006442 RID: 25666
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> EdTextRef;

		// Token: 0x04006443 RID: 25667
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> _children;

		// Token: 0x04006444 RID: 25668
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> _reference;

		// Token: 0x04006445 RID: 25669
		public int Id;

		// Token: 0x04006446 RID: 25670
		[Nullable(1)]
		public string Name;

		// Token: 0x04006447 RID: 25671
		public bool? _folded;

		// Token: 0x04006448 RID: 25672
		[Nullable(1)]
		public List<ActionInfo> Actions;

		// Token: 0x04006449 RID: 25673
		public bool? KeepBgm;

		// Token: 0x0400644A RID: 25674
		public bool? OnlyPlayOnce;

		// Token: 0x0400644B RID: 25675
		public bool? KeepInVehicle;

		// Token: 0x0400644C RID: 25676
		public bool? AllowMultiReference;

		// Token: 0x0400644D RID: 25677
		public bool? IgnoreInPlotHandBook;

		// Token: 0x0400644E RID: 25678
		public bool? DontInterruptMatch;

		// Token: 0x0400644F RID: 25679
		public bool? IsPreloadFlow;

		// Token: 0x04006450 RID: 25680
		public bool? IsClientFlow;

		// Token: 0x04006451 RID: 25681
		public bool? _showImport;

		// Token: 0x04006452 RID: 25682
		public PosA PlotPos;

		// Token: 0x04006453 RID: 25683
		public IStateProgramSpecialProcessChangeTeamOptimization ProgramSpecialProcess;

		// Token: 0x04006454 RID: 25684
		public List<int> _SelectedIndexes;

		// Token: 0x04006455 RID: 25685
		public string EdPlotNode;

		// Token: 0x04006456 RID: 25686
		public bool? EdPlotHandleJump;

		// Token: 0x04006457 RID: 25687
		public string EdPlotFileId;

		// Token: 0x04006458 RID: 25688
		public int? EdNextPlotKeyId;
	}
}
