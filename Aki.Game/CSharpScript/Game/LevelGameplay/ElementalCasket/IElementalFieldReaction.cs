using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02006003 RID: 24579
	[NullableContext(1)]
	public interface IElementalFieldReaction
	{
		// Token: 0x0603B0CF RID: 241871
		void ExecuteEnter(EntityHandle owner, EntityHandle target);

		// Token: 0x0603B0D0 RID: 241872
		void ExecuteLeave(EntityHandle owner, EntityHandle target);
	}
}
