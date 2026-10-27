using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Movement;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02004706 RID: 18182
	[NullableContext(1)]
	public interface IWuWaGoGridRelocationRequest : IWuWaGoGridRelocationContext
	{
		// Token: 0x170076AE RID: 30382
		// (get) Token: 0x0602F867 RID: 194663
		WuWaGoGridController GridController { get; }

		// Token: 0x170076AF RID: 30383
		// (get) Token: 0x0602F868 RID: 194664
		string OldKey { get; }

		// Token: 0x170076B0 RID: 30384
		// (get) Token: 0x0602F869 RID: 194665
		string TargetKey { get; }

		// Token: 0x170076B1 RID: 30385
		// (get) Token: 0x0602F86A RID: 194666
		IReadOnlyList<IWuWaGoGridMoveParticipant> Participants { get; }
	}
}
