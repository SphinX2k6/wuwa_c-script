using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020052DF RID: 21215
	public abstract class NpcAiOperation
	{
		// Token: 0x06036482 RID: 222338
		[NullableContext(1)]
		public abstract UniTask ExecuteAiOperation(PhantomArenaBattleProxy proxy);
	}
}
