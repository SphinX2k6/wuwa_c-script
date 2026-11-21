using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Movement;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02003636 RID: 13878
	[NullableContext(1)]
	public interface IWuWaGoGridRelocationRequest : IWuWaGoGridRelocationContext
	{
		// Token: 0x1700496A RID: 18794
		// (get) Token: 0x0602402D RID: 147501
		WuWaGoGridController GridController { get; }

		// Token: 0x1700496B RID: 18795
		// (get) Token: 0x0602402E RID: 147502
		string OldKey { get; }

		// Token: 0x1700496C RID: 18796
		// (get) Token: 0x0602402F RID: 147503
		string TargetKey { get; }

		// Token: 0x1700496D RID: 18797
		// (get) Token: 0x06024030 RID: 147504
		IReadOnlyList<IWuWaGoGridMoveParticipant> Participants { get; }
	}
}
