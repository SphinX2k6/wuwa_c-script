using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026DA RID: 9946
	public class ISendBattleStateType
	{
		// Token: 0x0600DE40 RID: 56896 RVA: 0x0020FAD3 File Offset: 0x0020DCD3
		[NullableContext(1)]
		public static ISendBattleStateType Create(ISendBattleStateType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISendBattleStateType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700424E RID: 16974
		// (get) Token: 0x0600DE41 RID: 56897 RVA: 0x0020FAF2 File Offset: 0x0020DCF2
		public virtual ESetBattleStateType Type
		{
			get
			{
				return (ESetBattleStateType)this.Instance.Type;
			}
		}

		// Token: 0x04007B62 RID: 31586
		private ISendBattleStateType Instance;
	}
}
