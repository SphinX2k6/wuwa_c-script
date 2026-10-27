using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Commit
{
	// Token: 0x02006884 RID: 26756
	public class RestoreReport
	{
		// Token: 0x170097B7 RID: 38839
		// (get) Token: 0x06042CCD RID: 273613 RVA: 0x01042040 File Offset: 0x01040240
		public bool HasFailure
		{
			get
			{
				return this.FailedUids.Count > 0;
			}
		}

		// Token: 0x04022C3B RID: 142395
		[Nullable(1)]
		public readonly List<int> FailedUids = new List<int>();
	}
}
