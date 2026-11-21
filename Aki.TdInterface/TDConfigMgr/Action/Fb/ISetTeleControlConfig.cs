using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C9C RID: 11420
	public class ISetTeleControlConfig
	{
		// Token: 0x0600FAAB RID: 64171 RVA: 0x002457EC File Offset: 0x002439EC
		public static ISetTeleControlConfig Create(ISetTeleControlConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetTeleControlConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E21 RID: 20001
		// (get) Token: 0x0600FAAC RID: 64172 RVA: 0x0024580B File Offset: 0x00243A0B
		public virtual ESetTeleControlType Type
		{
			get
			{
				return (ESetTeleControlType)this.Instance.Type;
			}
		}

		// Token: 0x17004E22 RID: 20002
		// (get) Token: 0x0600FAAD RID: 64173 RVA: 0x00245818 File Offset: 0x00243A18
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x040088F2 RID: 35058
		private ISetTeleControlConfig Instance;
	}
}
