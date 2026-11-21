using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200299D RID: 10653
	public class IBattleStateMonsterSleep : ISetBattleTagType
	{
		// Token: 0x0600EC19 RID: 60441 RVA: 0x0022C2DF File Offset: 0x0022A4DF
		public static IBattleStateMonsterSleep Create(IBattleStateMonsterSleep? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBattleStateMonsterSleep
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700458D RID: 17805
		// (get) Token: 0x0600EC1A RID: 60442 RVA: 0x0022C2FE File Offset: 0x0022A4FE
		public override ESetBattleTagType Type
		{
			get
			{
				return (ESetBattleTagType)this.Instance.Type;
			}
		}

		// Token: 0x04008201 RID: 33281
		private IBattleStateMonsterSleep Instance;
	}
}
