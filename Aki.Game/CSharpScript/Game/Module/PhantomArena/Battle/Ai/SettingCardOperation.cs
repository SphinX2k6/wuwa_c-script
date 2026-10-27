using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020052E5 RID: 21221
	[NullableContext(1)]
	[Nullable(0)]
	public class SettingCardOperation : NpcAiOperation
	{
		// Token: 0x17008307 RID: 33543
		// (get) Token: 0x06036496 RID: 222358 RVA: 0x00CD77F3 File Offset: 0x00CD59F3
		// (set) Token: 0x06036497 RID: 222359 RVA: 0x00CD77FB File Offset: 0x00CD59FB
		public NpcPhantomBattleEnterSlotInfo Info { get; private set; }

		// Token: 0x06036498 RID: 222360 RVA: 0x00CD7804 File Offset: 0x00CD5A04
		public SettingCardOperation(NpcPhantomBattleEnterSlotInfo info)
		{
			this.Info = info;
		}

		// Token: 0x06036499 RID: 222361 RVA: 0x00CD7814 File Offset: 0x00CD5A14
		public override UniTask ExecuteAiOperation(PhantomArenaBattleProxy proxy)
		{
			SettingCardOperation.<ExecuteAiOperation>d__5 <ExecuteAiOperation>d__;
			<ExecuteAiOperation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteAiOperation>d__.<>4__this = this;
			<ExecuteAiOperation>d__.proxy = proxy;
			<ExecuteAiOperation>d__.<>1__state = -1;
			<ExecuteAiOperation>d__.<>t__builder.Start<SettingCardOperation.<ExecuteAiOperation>d__5>(ref <ExecuteAiOperation>d__);
			return <ExecuteAiOperation>d__.<>t__builder.Task;
		}
	}
}
