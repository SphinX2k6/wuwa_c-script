using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity
{
	// Token: 0x02005888 RID: 22664
	[NullableContext(1)]
	public interface IActivityEntityComposition
	{
		// Token: 0x17006B31 RID: 27441
		// (get) Token: 0x06037DA0 RID: 228768
		// (set) Token: 0x06037DA1 RID: 228769
		List<Type> Components { get; set; }
	}
}
