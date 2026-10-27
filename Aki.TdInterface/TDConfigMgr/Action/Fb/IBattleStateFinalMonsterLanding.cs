using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026D8 RID: 9944
	public class IBattleStateFinalMonsterLanding : ISetBattleTagType
	{
		// Token: 0x0600DE3A RID: 56890 RVA: 0x0020FA6B File Offset: 0x0020DC6B
		[NullableContext(1)]
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

		// Token: 0x1700424C RID: 16972
		// (get) Token: 0x0600DE3B RID: 56891 RVA: 0x0020FA8A File Offset: 0x0020DC8A
		public override ESetBattleTagType Type
		{
			get
			{
				return (ESetBattleTagType)this.Instance.Type;
			}
		}

		// Token: 0x04007B60 RID: 31584
		private IBattleStateFinalMonsterLanding Instance;
	}
}
