using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Commit
{
	// Token: 0x02006881 RID: 26753
	internal class PendingOp
	{
		// Token: 0x04022C32 RID: 142386
		public int SourceUid;

		// Token: 0x04022C33 RID: 142387
		[Nullable(1)]
		public Func<DangoBrawlBagOpInfo[]> BuildOp;
	}
}
