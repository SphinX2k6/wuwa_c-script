using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D01 RID: 3329
	[NullableContext(1)]
	[Nullable(0)]
	public class IDynamicPortalConfig
	{
		// Token: 0x06004BFE RID: 19454 RVA: 0x000BD871 File Offset: 0x000BBA71
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

		// Token: 0x170017B9 RID: 6073
		// (get) Token: 0x06004BFF RID: 19455 RVA: 0x000BD890 File Offset: 0x000BBA90
		public virtual EPortalModel PortalModel
		{
			get
			{
				return (EPortalModel)this.Instance.PortalModel;
			}
		}

		// Token: 0x170017BA RID: 6074
		// (get) Token: 0x06004C00 RID: 19456 RVA: 0x000BD89D File Offset: 0x000BBA9D
		public virtual string TemplateId
		{
			get
			{
				return this.Instance.TemplateId;
			}
		}

		// Token: 0x04002B72 RID: 11122
		private IDynamicPortalConfig Instance;
	}
}
