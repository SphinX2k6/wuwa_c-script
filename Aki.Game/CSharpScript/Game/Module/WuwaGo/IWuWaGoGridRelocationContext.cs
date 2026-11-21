using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Model;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02003632 RID: 13874
	[NullableContext(1)]
	public interface IWuWaGoGridRelocationContext
	{
		// Token: 0x17004958 RID: 18776
		// (get) Token: 0x0602400C RID: 147468
		WuWaGoGrid Grid { get; }

		// Token: 0x17004959 RID: 18777
		// (get) Token: 0x0602400D RID: 147469
		Vector StartCoordinate { get; }

		// Token: 0x1700495A RID: 18778
		// (get) Token: 0x0602400E RID: 147470
		Vector TargetCoordinate { get; }
	}
}
