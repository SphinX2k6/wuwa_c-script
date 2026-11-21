using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020042B8 RID: 17080
	[NullableContext(1)]
	[Nullable(0)]
	public class UseRoleSkillOperation : NpcAiOperation
	{
		// Token: 0x170056CA RID: 22218
		// (get) Token: 0x0602B39D RID: 177053 RVA: 0x00C2505B File Offset: 0x00C2325B
		// (set) Token: 0x0602B39E RID: 177054 RVA: 0x00C25063 File Offset: 0x00C23263
		public NpcPhantomBattleCardRoleSkillInfo Info { get; private set; }

		// Token: 0x0602B39F RID: 177055 RVA: 0x00C2506C File Offset: 0x00C2326C
		public UseRoleSkillOperation(NpcPhantomBattleCardRoleSkillInfo info)
		{
			this.Info = info;
		}

		// Token: 0x0602B3A0 RID: 177056 RVA: 0x00C2507B File Offset: 0x00C2327B
		public override UniTask ExecuteAiOperation(PhantomArenaBattleProxy proxy)
		{
			return UniTask.CompletedTask;
		}
	}
}
