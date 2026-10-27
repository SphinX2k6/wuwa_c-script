using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200675E RID: 26462
	public class BuffInfo
	{
		// Token: 0x060421D4 RID: 270804 RVA: 0x0100A130 File Offset: 0x01008330
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

		// Token: 0x040226A0 RID: 140960
		public int BuffUId;

		// Token: 0x040226A1 RID: 140961
		public int SourceFighterUId;

		// Token: 0x040226A2 RID: 140962
		public int TargetFighterUId;

		// Token: 0x040226A3 RID: 140963
		public int BuffConfigId;

		// Token: 0x040226A4 RID: 140964
		public int Stack;

		// Token: 0x040226A5 RID: 140965
		public int RemainingMs;

		// Token: 0x040226A6 RID: 140966
		public int SourceItemUId;
	}
}
