using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02006E82 RID: 28290
	[NullableContext(1)]
	public interface IElementalFieldReaction
	{
		// Token: 0x06044F1F RID: 282399
		void ExecuteEnter(EntityHandle owner, EntityHandle target);

		// Token: 0x06044F20 RID: 282400
		void ExecuteLeave(EntityHandle owner, EntityHandle target);
	}
}
