using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020042B5 RID: 17077
	[NullableContext(1)]
	[Nullable(0)]
	public class SettingCardOperation : NpcAiOperation
	{
		// Token: 0x170056C7 RID: 22215
		// (get) Token: 0x0602B391 RID: 177041 RVA: 0x00C24F17 File Offset: 0x00C23117
		// (set) Token: 0x0602B392 RID: 177042 RVA: 0x00C24F1F File Offset: 0x00C2311F
		public NpcPhantomBattleEnterSlotInfo Info { get; private set; }

		// Token: 0x0602B393 RID: 177043 RVA: 0x00C24F28 File Offset: 0x00C23128
		public SettingCardOperation(NpcPhantomBattleEnterSlotInfo info)
		{
			this.Info = info;
		}

		// Token: 0x0602B394 RID: 177044 RVA: 0x00C24F38 File Offset: 0x00C23138
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
