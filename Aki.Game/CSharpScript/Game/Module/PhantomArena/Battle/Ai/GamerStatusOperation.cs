using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020052DD RID: 21213
	[NullableContext(1)]
	[Nullable(0)]
	public class GamerStatusOperation : NpcAiOperation
	{
		// Token: 0x17008302 RID: 33538
		// (get) Token: 0x0603647A RID: 222330 RVA: 0x00CD72D7 File Offset: 0x00CD54D7
		// (set) Token: 0x0603647B RID: 222331 RVA: 0x00CD72DF File Offset: 0x00CD54DF
		public NpcPhantomBattleGamerStatusInfo Info { get; private set; }

		// Token: 0x0603647C RID: 222332 RVA: 0x00CD72E8 File Offset: 0x00CD54E8
		public GamerStatusOperation(NpcPhantomBattleGamerStatusInfo info)
		{
			this.Info = info;
		}

		// Token: 0x0603647D RID: 222333 RVA: 0x00CD72F8 File Offset: 0x00CD54F8
		public override UniTask ExecuteAiOperation(PhantomArenaBattleProxy proxy)
		{
			if (this.Info.GamerIndex == 0)
			{
				PhantomArenaBattleModel.Instance.OpponentData.RefreshBattleStatus(this.Info.BattleStatus.ToDictionary<int, int>());
			}
			else if (this.Info.GamerIndex == 1)
			{
				PhantomArenaBattleModel.Instance.OwnData.RefreshBattleStatus(this.Info.BattleStatus.ToDictionary<int, int>());
			}
			return UniTask.CompletedTask;
		}
	}
}
