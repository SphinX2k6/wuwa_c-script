using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200299B RID: 10651
	public class IBattleStateMonsterLanding : ISetBattleTagType
	{
		// Token: 0x0600EC13 RID: 60435 RVA: 0x0022C277 File Offset: 0x0022A477
		public static IBattleStateMonsterLanding Create(IBattleStateMonsterLanding? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBattleStateMonsterLanding
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700458B RID: 17803
		// (get) Token: 0x0600EC14 RID: 60436 RVA: 0x0022C296 File Offset: 0x0022A496
		public override ESetBattleTagType Type
		{
			get
			{
				return (ESetBattleTagType)this.Instance.Type;
			}
		}

		// Token: 0x040081FF RID: 33279
		private IBattleStateMonsterLanding Instance;
	}
}
