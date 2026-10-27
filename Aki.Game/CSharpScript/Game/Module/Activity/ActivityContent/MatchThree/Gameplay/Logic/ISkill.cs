using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x020064FC RID: 25852
	[NullableContext(2)]
	public interface ISkill
	{
		// Token: 0x17009503 RID: 38147
		// (get) Token: 0x06040E70 RID: 265840
		int Id { get; }

		// Token: 0x17009504 RID: 38148
		// (get) Token: 0x06040E71 RID: 265841
		int EnergyNode { get; }

		// Token: 0x17009505 RID: 38149
		// (get) Token: 0x06040E72 RID: 265842
		string Icon { get; }

		// Token: 0x17009506 RID: 38150
		// (get) Token: 0x06040E73 RID: 265843
		string Name { get; }

		// Token: 0x17009507 RID: 38151
		// (get) Token: 0x06040E74 RID: 265844
		ESkillCastEffect CastEffect { get; }

		// Token: 0x06040E75 RID: 265845
		[NullableContext(1)]
		void Release(ISkillContext ctx);
	}
}
