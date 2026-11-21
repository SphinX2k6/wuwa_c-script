using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Battle
{
	// Token: 0x020052F1 RID: 21233
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballBattleLevelInfoTargetData : IPinballBattleLevelInfoTargetData
	{
		// Token: 0x170066AB RID: 26283
		// (get) Token: 0x06034D5F RID: 216415 RVA: 0x00EC5188 File Offset: 0x00EC3388
		// (set) Token: 0x06034D60 RID: 216416 RVA: 0x00EC5190 File Offset: 0x00EC3390
		public bool IsSpecial { get; set; }

		// Token: 0x170066AC RID: 26284
		// (get) Token: 0x06034D61 RID: 216417 RVA: 0x00EC5199 File Offset: 0x00EC3399
		// (set) Token: 0x06034D62 RID: 216418 RVA: 0x00EC51A1 File Offset: 0x00EC33A1
		public bool IsFinish { get; set; }

		// Token: 0x170066AD RID: 26285
		// (get) Token: 0x06034D63 RID: 216419 RVA: 0x00EC51AA File Offset: 0x00EC33AA
		// (set) Token: 0x06034D64 RID: 216420 RVA: 0x00EC51B2 File Offset: 0x00EC33B2
		public string Desc { get; set; }

		// Token: 0x170066AE RID: 26286
		// (get) Token: 0x06034D65 RID: 216421 RVA: 0x00EC51BB File Offset: 0x00EC33BB
		// (set) Token: 0x06034D66 RID: 216422 RVA: 0x00EC51C3 File Offset: 0x00EC33C3
		public int Value { get; set; }
	}
}
