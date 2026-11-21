using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020042A4 RID: 17060
	[NullableContext(1)]
	[Nullable(0)]
	public class AddBuffOperation : NpcAiOperation
	{
		// Token: 0x170056B9 RID: 22201
		// (get) Token: 0x0602B351 RID: 176977 RVA: 0x00C24696 File Offset: 0x00C22896
		// (set) Token: 0x0602B352 RID: 176978 RVA: 0x00C2469E File Offset: 0x00C2289E
		public PhantomBattleBuffTriggerInfo Info { get; private set; }

		// Token: 0x0602B353 RID: 176979 RVA: 0x00C246A7 File Offset: 0x00C228A7
		public AddBuffOperation(PhantomBattleBuffTriggerInfo info)
		{
			this.Info = info;
		}

		// Token: 0x0602B354 RID: 176980 RVA: 0x00C246B6 File Offset: 0x00C228B6
		public override UniTask ExecuteAiOperation(PhantomArenaBattleProxy proxy)
		{
			return UniTask.CompletedTask;
		}
	}
}
