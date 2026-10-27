using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020052E8 RID: 21224
	[NullableContext(1)]
	[Nullable(0)]
	public class UseRoleSkillOperation : NpcAiOperation
	{
		// Token: 0x1700830A RID: 33546
		// (get) Token: 0x060364A2 RID: 222370 RVA: 0x00CD7937 File Offset: 0x00CD5B37
		// (set) Token: 0x060364A3 RID: 222371 RVA: 0x00CD793F File Offset: 0x00CD5B3F
		public NpcPhantomBattleCardRoleSkillInfo Info { get; private set; }

		// Token: 0x060364A4 RID: 222372 RVA: 0x00CD7948 File Offset: 0x00CD5B48
		public UseRoleSkillOperation(NpcPhantomBattleCardRoleSkillInfo info)
		{
			this.Info = info;
		}

		// Token: 0x060364A5 RID: 222373 RVA: 0x00CD7957 File Offset: 0x00CD5B57
		public override UniTask ExecuteAiOperation(PhantomArenaBattleProxy proxy)
		{
			return UniTask.CompletedTask;
		}
	}
}
