using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200557C RID: 21884
	[NullableContext(2)]
	public interface IMapLifeEventTriggerParam
	{
		// Token: 0x17008635 RID: 34357
		// (get) Token: 0x06037C75 RID: 228469
		// (set) Token: 0x06037C76 RID: 228470
		bool State { get; set; }

		// Token: 0x17008636 RID: 34358
		// (get) Token: 0x06037C77 RID: 228471
		object Data { get; }
	}
}
