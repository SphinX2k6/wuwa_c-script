using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056AE RID: 22190
	public class BuffInfo
	{
		// Token: 0x06036D2A RID: 224554 RVA: 0x00F4B514 File Offset: 0x00F49714
		[NullableContext(1)]
		public void CopyFromChangeInfo(DangoBrawlFightActionBuffChangeInfo info)
		{
			this.BuffUId = info.BuffUId;
			this.SourceFighterUId = info.SourceFighterUId;
			this.TargetFighterUId = info.TargetFighterUId;
			this.BuffConfigId = info.BuffConfigId;
			this.Stack = info.Stack;
			this.RemainingMs = info.RemainingMs;
			this.SourceItemUId = info.SourceItemUId;
		}

		// Token: 0x0401CEFD RID: 118525
		public int BuffUId;

		// Token: 0x0401CEFE RID: 118526
		public int SourceFighterUId;

		// Token: 0x0401CEFF RID: 118527
		public int TargetFighterUId;

		// Token: 0x0401CF00 RID: 118528
		public int BuffConfigId;

		// Token: 0x0401CF01 RID: 118529
		public int Stack;

		// Token: 0x0401CF02 RID: 118530
		public int RemainingMs;

		// Token: 0x0401CF03 RID: 118531
		public int SourceItemUId;
	}
}
