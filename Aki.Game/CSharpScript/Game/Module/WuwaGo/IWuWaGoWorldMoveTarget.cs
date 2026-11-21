using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Model;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02003638 RID: 13880
	[NullableContext(2)]
	public interface IWuWaGoWorldMoveTarget
	{
		// Token: 0x17004975 RID: 18805
		// (get) Token: 0x06024040 RID: 147520
		WuWaGoBaseUnit Unit { get; }

		// Token: 0x17004976 RID: 18806
		// (get) Token: 0x06024041 RID: 147521
		AActor Actor { get; }

		// Token: 0x17004977 RID: 18807
		// (get) Token: 0x06024042 RID: 147522
		Vector FromWorldPosition { get; }

		// Token: 0x17004978 RID: 18808
		// (get) Token: 0x06024043 RID: 147523
		Vector ToWorldPosition { get; }
	}
}
