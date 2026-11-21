using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x0200547A RID: 21626
	[NullableContext(2)]
	public interface ISkill
	{
		// Token: 0x17006865 RID: 26725
		// (get) Token: 0x06035B34 RID: 219956
		int Id { get; }

		// Token: 0x17006866 RID: 26726
		// (get) Token: 0x06035B35 RID: 219957
		int EnergyNode { get; }

		// Token: 0x17006867 RID: 26727
		// (get) Token: 0x06035B36 RID: 219958
		string Icon { get; }

		// Token: 0x17006868 RID: 26728
		// (get) Token: 0x06035B37 RID: 219959
		string Name { get; }

		// Token: 0x17006869 RID: 26729
		// (get) Token: 0x06035B38 RID: 219960
		ESkillCastEffect CastEffect { get; }

		// Token: 0x06035B39 RID: 219961
		[NullableContext(1)]
		void Release(ISkillContext ctx);
	}
}
