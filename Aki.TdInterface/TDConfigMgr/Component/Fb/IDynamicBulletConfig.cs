using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DFB RID: 3579
	public class IDynamicBulletConfig
	{
		// Token: 0x06005117 RID: 20759 RVA: 0x000C8EEA File Offset: 0x000C70EA
		public static IDynamicBulletConfig Create(IDynamicBulletConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicBulletConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700191C RID: 6428
		// (get) Token: 0x06005118 RID: 20760 RVA: 0x000C8F09 File Offset: 0x000C7109
		public virtual int BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x1700191D RID: 6429
		// (get) Token: 0x06005119 RID: 20761 RVA: 0x000C8F16 File Offset: 0x000C7116
		public virtual EPortalModel PortalModel
		{
			get
			{
				return (EPortalModel)this.Instance.PortalModel;
			}
		}

		// Token: 0x1700191E RID: 6430
		// (get) Token: 0x0600511A RID: 20762 RVA: 0x000C8F23 File Offset: 0x000C7123
		public virtual string TemplateId
		{
			get
			{
				return this.Instance.TemplateId;
			}
		}

		// Token: 0x04002E34 RID: 11828
		private IDynamicBulletConfig Instance;
	}
}
