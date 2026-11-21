using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Commit
{
	// Token: 0x020057D1 RID: 22481
	internal class PendingOp
	{
		// Token: 0x0401D48E RID: 119950
		public int SourceUid;

		// Token: 0x0401D48F RID: 119951
		[Nullable(1)]
		public Func<DangoBrawlBagOpInfo[]> BuildOp;
	}
}
