using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CFD RID: 3325
	[NullableContext(2)]
	[Nullable(0)]
	public class IPortalMode
	{
		// Token: 0x06004BE8 RID: 19432 RVA: 0x000BD626 File Offset: 0x000BB826
		[NullableContext(1)]
		public static IPortalMode Create(IPortalMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPortalMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017AB RID: 6059
		// (get) Token: 0x06004BE9 RID: 19433 RVA: 0x000BD645 File Offset: 0x000BB845
		public virtual EPortalType Type
		{
			get
			{
				return (EPortalType)this.Instance.Type;
			}
		}

		// Token: 0x170017AC RID: 6060
		// (get) Token: 0x06004BEA RID: 19434 RVA: 0x000BD652 File Offset: 0x000BB852
		public virtual EPortalModel PortalModel
		{
			get
			{
				return (EPortalModel)this.Instance.PortalModel;
			}
		}

		// Token: 0x170017AD RID: 6061
		// (get) Token: 0x06004BEB RID: 19435 RVA: 0x000BD65F File Offset: 0x000BB85F
		public virtual IPortalRenderConfig RenderConfig
		{
			get
			{
				if (this._RenderConfigInited)
				{
					return this._RenderConfigCache;
				}
				this._RenderConfigInited = true;
				this._RenderConfigCache = IPortalRenderConfig.Create(this.Instance.RenderConfig);
				return this._RenderConfigCache;
			}
		}

		// Token: 0x04002B66 RID: 11110
		private IPortalMode Instance;

		// Token: 0x04002B67 RID: 11111
		private IPortalRenderConfig _RenderConfigCache;

		// Token: 0x04002B68 RID: 11112
		private bool _RenderConfigInited;
	}
}
