using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D03 RID: 3331
	[NullableContext(1)]
	[Nullable(0)]
	public class IDynamicBulletConfig
	{
		// Token: 0x06004C09 RID: 19465 RVA: 0x000BD9BA File Offset: 0x000BBBBA
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

		// Token: 0x170017C0 RID: 6080
		// (get) Token: 0x06004C0A RID: 19466 RVA: 0x000BD9D9 File Offset: 0x000BBBD9
		public virtual int BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x170017C1 RID: 6081
		// (get) Token: 0x06004C0B RID: 19467 RVA: 0x000BD9E6 File Offset: 0x000BBBE6
		public virtual EPortalModel PortalModel
		{
			get
			{
				return (EPortalModel)this.Instance.PortalModel;
			}
		}

		// Token: 0x170017C2 RID: 6082
		// (get) Token: 0x06004C0C RID: 19468 RVA: 0x000BD9F3 File Offset: 0x000BBBF3
		public virtual string TemplateId
		{
			get
			{
				return this.Instance.TemplateId;
			}
		}

		// Token: 0x04002B7A RID: 11130
		private IDynamicBulletConfig Instance;
	}
}
