using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B35 RID: 19253
	[NullableContext(1)]
	public interface ITowerDefensePhantomConfigSkillData
	{
		// Token: 0x17007B81 RID: 31617
		// (get) Token: 0x06031DC0 RID: 204224
		// (set) Token: 0x06031DC1 RID: 204225
		string Name { get; set; }

		// Token: 0x17007B82 RID: 31618
		// (get) Token: 0x06031DC2 RID: 204226
		// (set) Token: 0x06031DC3 RID: 204227
		string Description { get; set; }

		// Token: 0x17007B83 RID: 31619
		// (get) Token: 0x06031DC4 RID: 204228
		// (set) Token: 0x06031DC5 RID: 204229
		string UnlockDescription { get; set; }

		// Token: 0x17007B84 RID: 31620
		// (get) Token: 0x06031DC6 RID: 204230
		// (set) Token: 0x06031DC7 RID: 204231
		double? ExpThreshold { get; set; }

		// Token: 0x17007B85 RID: 31621
		// (get) Token: 0x06031DC8 RID: 204232
		// (set) Token: 0x06031DC9 RID: 204233
		int PhantomSkill { get; set; }
	}
}
