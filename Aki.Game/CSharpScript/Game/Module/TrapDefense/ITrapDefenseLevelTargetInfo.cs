using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A66 RID: 19046
	[NullableContext(1)]
	public interface ITrapDefenseLevelTargetInfo
	{
		// Token: 0x17007AA2 RID: 31394
		// (get) Token: 0x0603163B RID: 202299
		ETrapDefenseLevelTarget TargetType { get; }

		// Token: 0x17007AA3 RID: 31395
		// (get) Token: 0x0603163C RID: 202300
		string NameKey { get; }

		// Token: 0x17007AA4 RID: 31396
		// (get) Token: 0x0603163D RID: 202301
		string IconKey { get; }
	}
}
