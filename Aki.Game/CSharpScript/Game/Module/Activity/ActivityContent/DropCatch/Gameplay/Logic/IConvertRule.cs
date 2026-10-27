using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200672F RID: 26415
	public class IConvertRule
	{
		// Token: 0x0402259A RID: 140698
		[Nullable(1)]
		public HashSet<int> SourceItemIds = new HashSet<int>();

		// Token: 0x0402259B RID: 140699
		public int TargetItemId;

		// Token: 0x0402259C RID: 140700
		public double Duration;
	}
}
