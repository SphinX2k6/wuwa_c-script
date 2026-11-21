using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020042AD RID: 17069
	[NullableContext(1)]
	[Nullable(0)]
	public class GamerStatusOperation : NpcAiOperation
	{
		// Token: 0x170056C2 RID: 22210
		// (get) Token: 0x0602B375 RID: 177013 RVA: 0x00C249FF File Offset: 0x00C22BFF
		// (set) Token: 0x0602B376 RID: 177014 RVA: 0x00C24A07 File Offset: 0x00C22C07
		public NpcPhantomBattleGamerStatusInfo Info { get; private set; }

		// Token: 0x0602B377 RID: 177015 RVA: 0x00C24A10 File Offset: 0x00C22C10
		public GamerStatusOperation(NpcPhantomBattleGamerStatusInfo info)
		{
			this.Info = info;
		}

		// Token: 0x0602B378 RID: 177016 RVA: 0x00C24A20 File Offset: 0x00C22C20
		public override UniTask ExecuteAiOperation(PhantomArenaBattleProxy proxy)
		{
			if (this.Info.GamerIndex == 0)
			{
				PhantomArenaBattleModel.Instance.OpponentData.RefreshBattleStatus(new Dictionary<int, int>(this.Info.BattleStatus));
			}
			else if (this.Info.GamerIndex == 1)
			{
				PhantomArenaBattleModel.Instance.OwnData.RefreshBattleStatus(new Dictionary<int, int>(this.Info.BattleStatus));
			}
			return UniTask.CompletedTask;
		}
	}
}
