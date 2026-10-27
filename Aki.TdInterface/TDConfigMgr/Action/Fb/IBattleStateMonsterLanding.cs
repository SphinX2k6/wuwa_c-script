using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026D7 RID: 9943
	public class IBattleStateMonsterLanding : ISetBattleTagType
	{
		// Token: 0x0600DE37 RID: 56887 RVA: 0x0020FA37 File Offset: 0x0020DC37
		[NullableContext(1)]
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

		// Token: 0x1700424B RID: 16971
		// (get) Token: 0x0600DE38 RID: 56888 RVA: 0x0020FA56 File Offset: 0x0020DC56
		public override ESetBattleTagType Type
		{
			get
			{
				return (ESetBattleTagType)this.Instance.Type;
			}
		}

		// Token: 0x04007B5F RID: 31583
		private IBattleStateMonsterLanding Instance;
	}
}
