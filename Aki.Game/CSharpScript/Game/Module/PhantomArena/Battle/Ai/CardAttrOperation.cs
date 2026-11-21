using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020042A7 RID: 17063
	[NullableContext(1)]
	[Nullable(0)]
	public class CardAttrOperation : NpcAiOperation
	{
		// Token: 0x170056BC RID: 22204
		// (get) Token: 0x0602B35D RID: 176989 RVA: 0x00C24797 File Offset: 0x00C22997
		// (set) Token: 0x0602B35E RID: 176990 RVA: 0x00C2479F File Offset: 0x00C2299F
		public NpcPhantomBattleCardAttrInfo Info { get; private set; }

		// Token: 0x0602B35F RID: 176991 RVA: 0x00C247A8 File Offset: 0x00C229A8
		public CardAttrOperation(NpcPhantomBattleCardAttrInfo info)
		{
			this.Info = info;
		}

		// Token: 0x0602B360 RID: 176992 RVA: 0x00C247B7 File Offset: 0x00C229B7
		public override UniTask ExecuteAiOperation(PhantomArenaBattleProxy proxy)
		{
			PhantomArenaBattleModel.Instance.RefreshFighterAttr(this.Info.CardFighterUId, new Dictionary<int, int>(this.Info.BattleStatus));
			return UniTask.CompletedTask;
		}
	}
}
