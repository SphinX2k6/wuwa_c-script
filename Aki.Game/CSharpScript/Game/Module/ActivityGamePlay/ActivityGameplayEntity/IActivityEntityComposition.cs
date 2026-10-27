using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity
{
	// Token: 0x02006937 RID: 26935
	[NullableContext(1)]
	public interface IActivityEntityComposition
	{
		// Token: 0x170097F1 RID: 38897
		// (get) Token: 0x06043243 RID: 275011
		// (set) Token: 0x06043244 RID: 275012
		List<Type> Components { get; set; }
	}
}
