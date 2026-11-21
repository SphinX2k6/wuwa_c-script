using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Battle
{
	// Token: 0x020052F0 RID: 21232
	[NullableContext(1)]
	public interface IPinballBattleLevelInfoTargetData
	{
		// Token: 0x170066A7 RID: 26279
		// (get) Token: 0x06034D57 RID: 216407
		// (set) Token: 0x06034D58 RID: 216408
		bool IsSpecial { get; set; }

		// Token: 0x170066A8 RID: 26280
		// (get) Token: 0x06034D59 RID: 216409
		// (set) Token: 0x06034D5A RID: 216410
		bool IsFinish { get; set; }

		// Token: 0x170066A9 RID: 26281
		// (get) Token: 0x06034D5B RID: 216411
		// (set) Token: 0x06034D5C RID: 216412
		string Desc { get; set; }

		// Token: 0x170066AA RID: 26282
		// (get) Token: 0x06034D5D RID: 216413
		// (set) Token: 0x06034D5E RID: 216414
		int Value { get; set; }
	}
}
