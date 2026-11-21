using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020042AF RID: 17071
	public abstract class NpcAiOperation
	{
		// Token: 0x0602B37D RID: 177021
		[NullableContext(1)]
		public abstract UniTask ExecuteAiOperation(PhantomArenaBattleProxy proxy);
	}
}
