using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Model;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02004708 RID: 18184
	[NullableContext(2)]
	public interface IWuWaGoWorldMoveTarget
	{
		// Token: 0x170076B9 RID: 30393
		// (get) Token: 0x0602F87A RID: 194682
		WuWaGoBaseUnit Unit { get; }

		// Token: 0x170076BA RID: 30394
		// (get) Token: 0x0602F87B RID: 194683
		AActor Actor { get; }

		// Token: 0x170076BB RID: 30395
		// (get) Token: 0x0602F87C RID: 194684
		Vector FromWorldPosition { get; }

		// Token: 0x170076BC RID: 30396
		// (get) Token: 0x0602F87D RID: 194685
		Vector ToWorldPosition { get; }
	}
}
