using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003ADD RID: 15069
	[NullableContext(1)]
	public interface ITowerDefensePhantomConfigSkillData
	{
		// Token: 0x17004F2E RID: 20270
		// (get) Token: 0x06026B50 RID: 158544
		// (set) Token: 0x06026B51 RID: 158545
		string Name { get; set; }

		// Token: 0x17004F2F RID: 20271
		// (get) Token: 0x06026B52 RID: 158546
		// (set) Token: 0x06026B53 RID: 158547
		string Description { get; set; }

		// Token: 0x17004F30 RID: 20272
		// (get) Token: 0x06026B54 RID: 158548
		// (set) Token: 0x06026B55 RID: 158549
		string UnlockDescription { get; set; }

		// Token: 0x17004F31 RID: 20273
		// (get) Token: 0x06026B56 RID: 158550
		// (set) Token: 0x06026B57 RID: 158551
		double? ExpThreshold { get; set; }

		// Token: 0x17004F32 RID: 20274
		// (get) Token: 0x06026B58 RID: 158552
		// (set) Token: 0x06026B59 RID: 158553
		int PhantomSkill { get; set; }
	}
}
