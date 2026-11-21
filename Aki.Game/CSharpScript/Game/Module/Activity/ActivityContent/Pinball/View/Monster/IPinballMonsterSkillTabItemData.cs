using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Monster
{
	// Token: 0x020052A8 RID: 21160
	[NullableContext(1)]
	public interface IPinballMonsterSkillTabItemData
	{
		// Token: 0x17006656 RID: 26198
		// (get) Token: 0x06034AAB RID: 215723
		// (set) Token: 0x06034AAC RID: 215724
		bool IsSelected { get; set; }

		// Token: 0x17006657 RID: 26199
		// (get) Token: 0x06034AAD RID: 215725
		// (set) Token: 0x06034AAE RID: 215726
		string Name { get; set; }

		// Token: 0x17006658 RID: 26200
		// (get) Token: 0x06034AAF RID: 215727
		// (set) Token: 0x06034AB0 RID: 215728
		Action<int> OnSelected { get; set; }
	}
}
