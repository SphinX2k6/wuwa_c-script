using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DF9 RID: 3577
	public class IDynamicPortalConfig
	{
		// Token: 0x0600510C RID: 20748 RVA: 0x000C8DA1 File Offset: 0x000C6FA1
		public static IDynamicPortalConfig Create(IDynamicPortalConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicPortalConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001915 RID: 6421
		// (get) Token: 0x0600510D RID: 20749 RVA: 0x000C8DC0 File Offset: 0x000C6FC0
		public virtual EPortalModel PortalModel
		{
			get
			{
				return (EPortalModel)this.Instance.PortalModel;
			}
		}

		// Token: 0x17001916 RID: 6422
		// (get) Token: 0x0600510E RID: 20750 RVA: 0x000C8DCD File Offset: 0x000C6FCD
		public virtual string TemplateId
		{
			get
			{
				return this.Instance.TemplateId;
			}
		}

		// Token: 0x04002E2C RID: 11820
		private IDynamicPortalConfig Instance;
	}
}
