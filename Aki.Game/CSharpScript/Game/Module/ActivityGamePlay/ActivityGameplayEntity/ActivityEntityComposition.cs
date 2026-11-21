using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity
{
	// Token: 0x02005889 RID: 22665
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityEntityComposition : IActivityEntityComposition
	{
		// Token: 0x17006B32 RID: 27442
		// (get) Token: 0x06037DA2 RID: 228770 RVA: 0x00F9F5AE File Offset: 0x00F9D7AE
		// (set) Token: 0x06037DA3 RID: 228771 RVA: 0x00F9F5B6 File Offset: 0x00F9D7B6
		public List<Type> Components { get; set; } = new List<Type>();
	}
}
