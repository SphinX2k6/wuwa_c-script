using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200454F RID: 17743
	[NullableContext(2)]
	public interface IMapLifeEventTriggerParam
	{
		// Token: 0x170059DE RID: 23006
		// (get) Token: 0x0602CB4F RID: 183119
		// (set) Token: 0x0602CB50 RID: 183120
		bool State { get; set; }

		// Token: 0x170059DF RID: 23007
		// (get) Token: 0x0602CB51 RID: 183121
		object Data { get; }
	}
}
