using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026D9 RID: 9945
	public class IBattleStateMonsterSleep : ISetBattleTagType
	{
		// Token: 0x0600DE3D RID: 56893 RVA: 0x0020FA9F File Offset: 0x0020DC9F
		[NullableContext(1)]
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

		// Token: 0x1700424D RID: 16973
		// (get) Token: 0x0600DE3E RID: 56894 RVA: 0x0020FABE File Offset: 0x0020DCBE
		public override ESetBattleTagType Type
		{
			get
			{
				return (ESetBattleTagType)this.Instance.Type;
			}
		}

		// Token: 0x04007B61 RID: 31585
		private IBattleStateMonsterSleep Instance;
	}
}
