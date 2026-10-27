using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020052D7 RID: 21207
	[NullableContext(1)]
	[Nullable(0)]
	public class CardAttrOperation : NpcAiOperation
	{
		// Token: 0x170082FC RID: 33532
		// (get) Token: 0x06036462 RID: 222306 RVA: 0x00CD706F File Offset: 0x00CD526F
		// (set) Token: 0x06036463 RID: 222307 RVA: 0x00CD7077 File Offset: 0x00CD5277
		public NpcPhantomBattleCardAttrInfo Info { get; private set; }

		// Token: 0x06036464 RID: 222308 RVA: 0x00CD7080 File Offset: 0x00CD5280
		public CardAttrOperation(NpcPhantomBattleCardAttrInfo info)
		{
			this.Info = info;
		}

		// Token: 0x06036465 RID: 222309 RVA: 0x00CD708F File Offset: 0x00CD528F
		public override UniTask ExecuteAiOperation(PhantomArenaBattleProxy proxy)
		{
			PhantomArenaBattleModel.Instance.RefreshFighterAttr(this.Info.CardFighterUId, this.Info.BattleStatus.ToDictionary<int, int>());
			return UniTask.CompletedTask;
		}
	}
}
