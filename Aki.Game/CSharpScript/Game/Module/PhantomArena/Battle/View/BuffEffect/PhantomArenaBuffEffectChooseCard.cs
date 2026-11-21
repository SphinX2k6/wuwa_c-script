using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.BuffEffect
{
	// Token: 0x0200424D RID: 16973
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBuffEffectChooseCard
	{
		// Token: 0x0602AF23 RID: 175907 RVA: 0x00C1575C File Offset: 0x00C1395C
		public PhantomArenaBuffEffectChooseCard(IBuffEffectData data, PhantomArenaBuffEffectManager manager)
		{
			this.Data = data;
			this.Manager = manager;
		}

		// Token: 0x0602AF24 RID: 175908 RVA: 0x00C15774 File Offset: 0x00C13974
		public void ShowChooseCard()
		{
			PhantomBattleCardSelectEffectCtx phantomBattleCardSelectEffectCtx = this.Data.Effect.PhantomBattleCardSelectEffectCtx;
			this.Manager.Proxy.ServerActionQueue.PushChooseCardAction(phantomBattleCardSelectEffectCtx);
		}

		// Token: 0x040173CD RID: 95181
		protected IBuffEffectData Data;

		// Token: 0x040173CE RID: 95182
		protected PhantomArenaBuffEffectManager Manager;
	}
}
