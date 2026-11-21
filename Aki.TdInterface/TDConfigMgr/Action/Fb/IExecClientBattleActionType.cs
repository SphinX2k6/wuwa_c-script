using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029B6 RID: 10678
	public class IExecClientBattleActionType
	{
		// Token: 0x0600EC82 RID: 60546 RVA: 0x0022CF30 File Offset: 0x0022B130
		public static IExecClientBattleActionType Create(IExecClientBattleActionType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExecClientBattleActionType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045C4 RID: 17860
		// (get) Token: 0x0600EC83 RID: 60547 RVA: 0x0022CF4F File Offset: 0x0022B14F
		public virtual EExecClientBattleActionType Type
		{
			get
			{
				return (EExecClientBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x04008236 RID: 33334
		private IExecClientBattleActionType Instance;
	}
}
