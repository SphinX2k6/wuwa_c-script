using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200567F RID: 22143
	public class IConvertRule
	{
		// Token: 0x0401CDF3 RID: 118259
		[Nullable(1)]
		public HashSet<int> SourceItemIds = new HashSet<int>();

		// Token: 0x0401CDF4 RID: 118260
		public int TargetItemId;

		// Token: 0x0401CDF5 RID: 118261
		public double Duration;
	}
}
