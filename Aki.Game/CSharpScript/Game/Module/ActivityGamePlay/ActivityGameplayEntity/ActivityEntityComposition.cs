using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity
{
	// Token: 0x02006938 RID: 26936
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityEntityComposition : IActivityEntityComposition
	{
		// Token: 0x170097F2 RID: 38898
		// (get) Token: 0x06043245 RID: 275013 RVA: 0x0105DF3E File Offset: 0x0105C13E
		// (set) Token: 0x06043246 RID: 275014 RVA: 0x0105DF46 File Offset: 0x0105C146
		public List<Type> Components { get; set; } = new List<Type>();
	}
}
