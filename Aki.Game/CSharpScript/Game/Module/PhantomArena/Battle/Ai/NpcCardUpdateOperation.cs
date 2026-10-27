using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020052E0 RID: 21216
	[NullableContext(1)]
	[Nullable(0)]
	public class NpcCardUpdateOperation : NpcAiOperation
	{
		// Token: 0x17008304 RID: 33540
		// (get) Token: 0x06036484 RID: 222340 RVA: 0x00CD73DB File Offset: 0x00CD55DB
		// (set) Token: 0x06036485 RID: 222341 RVA: 0x00CD73E3 File Offset: 0x00CD55E3
		public PhantomBattleNpcCardUpdateInfo Info { get; private set; }

		// Token: 0x06036486 RID: 222342 RVA: 0x00CD73EC File Offset: 0x00CD55EC
		public NpcCardUpdateOperation(PhantomBattleNpcCardUpdateInfo info)
		{
			this.Info = info;
		}

		// Token: 0x06036487 RID: 222343 RVA: 0x00CD73FC File Offset: 0x00CD55FC
		public override UniTask ExecuteAiOperation(PhantomArenaBattleProxy proxy)
		{
			PhantomCardData cardDataByFightId = PhantomArenaBattleModel.Instance.OpponentData.GetCardDataByFightId(this.Info.CardUId);
			if (cardDataByFightId == null)
			{
				return UniTask.CompletedTask;
			}
			cardDataByFightId.NotifyRefreshCardData(this.Info.Factors.ToDictionary<int, int>(), this.Info.LockFactor.ToList<int>(), this.Info.CanUnlimitedEvolve);
			return UniTask.CompletedTask;
		}
	}
}
