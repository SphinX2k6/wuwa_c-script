using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B3C RID: 11068
	public class ITurntableConnectorUiGameplay : IUiGame
	{
		// Token: 0x0600F368 RID: 62312 RVA: 0x002385C7 File Offset: 0x002367C7
		public static ITurntableConnectorUiGameplay Create(ITurntableConnectorUiGameplay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITurntableConnectorUiGameplay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700499E RID: 18846
		// (get) Token: 0x0600F369 RID: 62313 RVA: 0x002385E6 File Offset: 0x002367E6
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x1700499F RID: 18847
		// (get) Token: 0x0600F36A RID: 62314 RVA: 0x002385F3 File Offset: 0x002367F3
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04008588 RID: 34184
		private ITurntableConnectorUiGameplay Instance;
	}
}
