using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.BuffEffect
{
	// Token: 0x0200527C RID: 21116
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBuffEffectAddBuff
	{
		// Token: 0x06036026 RID: 221222 RVA: 0x00CC7FB9 File Offset: 0x00CC61B9
		public PhantomArenaBuffEffectAddBuff(IBuffEffectData data, PhantomArenaBuffEffectManager manager)
		{
			this.Data = data;
			this.Manager = manager;
		}

		// Token: 0x06036027 RID: 221223 RVA: 0x00CC7FD0 File Offset: 0x00CC61D0
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

		// Token: 0x0401C996 RID: 117142
		protected IBuffEffectData Data;

		// Token: 0x0401C997 RID: 117143
		protected PhantomArenaBuffEffectManager Manager;
	}
}
