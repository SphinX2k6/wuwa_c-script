using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Battle
{
	// Token: 0x02006372 RID: 25458
	[NullableContext(1)]
	public interface IPinballBattleLevelInfoTargetData
	{
		// Token: 0x17009345 RID: 37701
		// (get) Token: 0x06040096 RID: 262294
		// (set) Token: 0x06040097 RID: 262295
		bool IsSpecial { get; set; }

		// Token: 0x17009346 RID: 37702
		// (get) Token: 0x06040098 RID: 262296
		// (set) Token: 0x06040099 RID: 262297
		bool IsFinish { get; set; }

		// Token: 0x17009347 RID: 37703
		// (get) Token: 0x0604009A RID: 262298
		// (set) Token: 0x0604009B RID: 262299
		string Desc { get; set; }

		// Token: 0x17009348 RID: 37704
		// (get) Token: 0x0604009C RID: 262300
		// (set) Token: 0x0604009D RID: 262301
		int Value { get; set; }
	}
}
