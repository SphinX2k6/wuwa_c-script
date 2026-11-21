using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.BuffEffect
{
	// Token: 0x0200424C RID: 16972
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBuffEffectAddBuff
	{
		// Token: 0x0602AF21 RID: 175905 RVA: 0x00C156B9 File Offset: 0x00C138B9
		public PhantomArenaBuffEffectAddBuff(IBuffEffectData data, PhantomArenaBuffEffectManager manager)
		{
			this.Data = data;
			this.Manager = manager;
		}

		// Token: 0x0602AF22 RID: 175906 RVA: 0x00C156D0 File Offset: 0x00C138D0
		public void ShowBuffEffect()
		{
			foreach (int buffConfigId in this.Data.Effect.PhantomBattleAddBuffEffectCtx.PhantomBattleBuffId)
			{
				PhantomBattleBuff phantomBattleBuffConfig = PhantomArenaConfig.Instance.GetPhantomBattleBuffConfig(buffConfigId);
				if (phantomBattleBuffConfig.BuffShowType != 0)
				{
					this.Manager.Proxy.ShowAddBuffEffect((EBuffShowType)phantomBattleBuffConfig.BuffShowType, this.Data.SelectFightIdList);
				}
			}
		}

		// Token: 0x040173CB RID: 95179
		protected IBuffEffectData Data;

		// Token: 0x040173CC RID: 95180
		protected PhantomArenaBuffEffectManager Manager;
	}
}
