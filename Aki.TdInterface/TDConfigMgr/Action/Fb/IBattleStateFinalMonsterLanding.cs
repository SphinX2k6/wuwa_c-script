using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200299C RID: 10652
	public class IBattleStateFinalMonsterLanding : ISetBattleTagType
	{
		// Token: 0x0600EC16 RID: 60438 RVA: 0x0022C2AB File Offset: 0x0022A4AB
		public static IBattleStateFinalMonsterLanding Create(IBattleStateFinalMonsterLanding? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBattleStateFinalMonsterLanding
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700458C RID: 17804
		// (get) Token: 0x0600EC17 RID: 60439 RVA: 0x0022C2CA File Offset: 0x0022A4CA
		public override ESetBattleTagType Type
		{
			get
			{
				return (ESetBattleTagType)this.Instance.Type;
			}
		}

		// Token: 0x04008200 RID: 33280
		private IBattleStateFinalMonsterLanding Instance;
	}
}
