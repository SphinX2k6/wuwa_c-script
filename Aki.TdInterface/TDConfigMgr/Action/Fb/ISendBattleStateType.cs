using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200299E RID: 10654
	public class ISendBattleStateType
	{
		// Token: 0x0600EC1C RID: 60444 RVA: 0x0022C313 File Offset: 0x0022A513
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

		// Token: 0x1700458E RID: 17806
		// (get) Token: 0x0600EC1D RID: 60445 RVA: 0x0022C332 File Offset: 0x0022A532
		public virtual ESetBattleStateType Type
		{
			get
			{
				return (ESetBattleStateType)this.Instance.Type;
			}
		}

		// Token: 0x04008202 RID: 33282
		private ISendBattleStateType Instance;
	}
}
