using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Commit
{
	// Token: 0x020057D4 RID: 22484
	public class RestoreReport
	{
		// Token: 0x17006AF7 RID: 27383
		// (get) Token: 0x06037825 RID: 227365 RVA: 0x00F835C0 File Offset: 0x00F817C0
		public bool HasFailure
		{
			get
			{
				return this.FailedUids.Count > 0;
			}
		}

		// Token: 0x0401D497 RID: 119959
		[Nullable(1)]
		public readonly List<int> FailedUids = new List<int>();
	}
}
