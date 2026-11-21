using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029CA RID: 10698
	public class IMechExecute : IExecClientBattleActionType
	{
		// Token: 0x0600ECD6 RID: 60630 RVA: 0x0022D6E0 File Offset: 0x0022B8E0
		public static IMechExecute Create(IMechExecute? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechExecute
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045F0 RID: 17904
		// (get) Token: 0x0600ECD7 RID: 60631 RVA: 0x0022D6FF File Offset: 0x0022B8FF
		public override EExecClientBattleActionType Type
		{
			get
			{
				return (EExecClientBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x170045F1 RID: 17905
		// (get) Token: 0x0600ECD8 RID: 60632 RVA: 0x0022D70C File Offset: 0x0022B90C
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x0400825C RID: 33372
		private IMechExecute Instance;
	}
}
