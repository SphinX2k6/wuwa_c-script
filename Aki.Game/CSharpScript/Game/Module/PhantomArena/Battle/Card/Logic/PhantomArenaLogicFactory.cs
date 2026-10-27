using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Card.Logic
{
	// Token: 0x020052C3 RID: 21187
	public class PhantomArenaLogicFactory
	{
		// Token: 0x06036322 RID: 221986 RVA: 0x00CD21F4 File Offset: 0x00CD03F4
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
