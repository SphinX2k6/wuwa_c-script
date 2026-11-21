using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Card.Logic
{
	// Token: 0x02004293 RID: 17043
	public class PhantomArenaLogicFactory
	{
		// Token: 0x0602B21D RID: 176669 RVA: 0x00C1F91C File Offset: 0x00C1DB1C
		[NullableContext(1)]
		public static PhantomArenaCardLogic CreateLogic(PhantomArenaCard card, EPhantomArenaCardType type, PhantomArenaBattleProxy viewProxy)
		{
			if (type == EPhantomArenaCardType.Normal)
			{
				return new PhantomArenaNormalLogic(card, viewProxy);
			}
			if (type == EPhantomArenaCardType.Field)
			{
				return new PhantomArenaFieldLogic(card, viewProxy);
			}
			if (type == EPhantomArenaCardType.Tool)
			{
				return new PhantomArenaToolLogic(card, viewProxy);
			}
			return new PhantomArenaNormalLogic(card, viewProxy);
		}
	}
}
