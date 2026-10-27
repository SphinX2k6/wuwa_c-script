using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Model;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02004702 RID: 18178
	[NullableContext(1)]
	public interface IWuWaGoGridRelocationContext
	{
		// Token: 0x1700769C RID: 30364
		// (get) Token: 0x0602F846 RID: 194630
		WuWaGoGrid Grid { get; }

		// Token: 0x1700769D RID: 30365
		// (get) Token: 0x0602F847 RID: 194631
		Vector StartCoordinate { get; }

		// Token: 0x1700769E RID: 30366
		// (get) Token: 0x0602F848 RID: 194632
		Vector TargetCoordinate { get; }
	}
}
