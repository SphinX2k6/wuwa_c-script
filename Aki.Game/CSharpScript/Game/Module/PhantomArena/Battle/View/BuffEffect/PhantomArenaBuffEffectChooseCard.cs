using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.BuffEffect
{
	// Token: 0x0200527D RID: 21117
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBuffEffectChooseCard
	{
		// Token: 0x06036028 RID: 221224 RVA: 0x00CC805C File Offset: 0x00CC625C
		public PhantomArenaBuffEffectChooseCard(IBuffEffectData data, PhantomArenaBuffEffectManager manager)
		{
			this.Data = data;
			this.Manager = manager;
		}

		// Token: 0x06036029 RID: 221225 RVA: 0x00CC8074 File Offset: 0x00CC6274
		public void ShowChooseCard()
		{
			PhantomBattleCardSelectEffectCtx phantomBattleCardSelectEffectCtx = this.Data.Effect.PhantomBattleCardSelectEffectCtx;
			this.Manager.Proxy.ServerActionQueue.PushChooseCardAction(phantomBattleCardSelectEffectCtx);
		}

		// Token: 0x0401C998 RID: 117144
		protected IBuffEffectData Data;

		// Token: 0x0401C999 RID: 117145
		protected PhantomArenaBuffEffectManager Manager;
	}
}
