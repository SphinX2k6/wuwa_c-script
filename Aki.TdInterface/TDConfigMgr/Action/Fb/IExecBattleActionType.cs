using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029A8 RID: 10664
	public class IExecBattleActionType
	{
		// Token: 0x0600EC46 RID: 60486 RVA: 0x0022C7F8 File Offset: 0x0022A9F8
		public static IExecBattleActionType Create(IExecBattleActionType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExecBattleActionType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045A4 RID: 17828
		// (get) Token: 0x0600EC47 RID: 60487 RVA: 0x0022C817 File Offset: 0x0022AA17
		public virtual EExecBattleActionType Type
		{
			get
			{
				return (EExecBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x04008216 RID: 33302
		private IExecBattleActionType Instance;
	}
}
