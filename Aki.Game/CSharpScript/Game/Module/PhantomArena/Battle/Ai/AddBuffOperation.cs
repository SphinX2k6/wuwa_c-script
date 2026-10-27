using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020052D4 RID: 21204
	[NullableContext(1)]
	[Nullable(0)]
	public class AddBuffOperation : NpcAiOperation
	{
		// Token: 0x170082F9 RID: 33529
		// (get) Token: 0x06036456 RID: 222294 RVA: 0x00CD6F6E File Offset: 0x00CD516E
		// (set) Token: 0x06036457 RID: 222295 RVA: 0x00CD6F76 File Offset: 0x00CD5176
		public PhantomBattleBuffTriggerInfo Info { get; private set; }

		// Token: 0x06036458 RID: 222296 RVA: 0x00CD6F7F File Offset: 0x00CD517F
		public AddBuffOperation(PhantomBattleBuffTriggerInfo info)
		{
			this.Info = info;
		}

		// Token: 0x06036459 RID: 222297 RVA: 0x00CD6F8E File Offset: 0x00CD518E
		public override UniTask ExecuteAiOperation(PhantomArenaBattleProxy proxy)
		{
			return UniTask.CompletedTask;
		}
	}
}
