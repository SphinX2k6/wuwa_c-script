using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020042B0 RID: 17072
	[NullableContext(1)]
	[Nullable(0)]
	public class NpcCardUpdateOperation : NpcAiOperation
	{
		// Token: 0x170056C4 RID: 22212
		// (get) Token: 0x0602B37F RID: 177023 RVA: 0x00C24B03 File Offset: 0x00C22D03
		// (set) Token: 0x0602B380 RID: 177024 RVA: 0x00C24B0B File Offset: 0x00C22D0B
		public PhantomBattleNpcCardUpdateInfo Info { get; private set; }

		// Token: 0x0602B381 RID: 177025 RVA: 0x00C24B14 File Offset: 0x00C22D14
		public NpcCardUpdateOperation(PhantomBattleNpcCardUpdateInfo info)
		{
			this.Info = info;
		}

		// Token: 0x0602B382 RID: 177026 RVA: 0x00C24B24 File Offset: 0x00C22D24
		public override UniTask ExecuteAiOperation(PhantomArenaBattleProxy proxy)
		{
			PhantomCardData cardDataByFightId = PhantomArenaBattleModel.Instance.OpponentData.GetCardDataByFightId(this.Info.CardUId);
			if (cardDataByFightId == null)
			{
				return UniTask.CompletedTask;
			}
			cardDataByFightId.NotifyRefreshCardData(new Dictionary<int, int>(this.Info.Factors), this.Info.LockFactor, this.Info.CanUnlimitedEvolve);
			return UniTask.CompletedTask;
		}
	}
}
