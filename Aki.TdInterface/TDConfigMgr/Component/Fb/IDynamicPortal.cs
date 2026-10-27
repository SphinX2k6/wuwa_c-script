using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CFF RID: 3327
	[NullableContext(2)]
	[Nullable(0)]
	public class IDynamicPortal : IPortalMode
	{
		// Token: 0x06004BF4 RID: 19444 RVA: 0x000BD756 File Offset: 0x000BB956
		[NullableContext(1)]
		public static IDynamicPortal Create(IDynamicPortal? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicPortal
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017B3 RID: 6067
		// (get) Token: 0x06004BF5 RID: 19445 RVA: 0x000BD775 File Offset: 0x000BB975
		public override EPortalType Type
		{
			get
			{
				return (EPortalType)this.Instance.Type;
			}
		}

		// Token: 0x170017B4 RID: 6068
		// (get) Token: 0x06004BF6 RID: 19446 RVA: 0x000BD782 File Offset: 0x000BB982
		public override EPortalModel PortalModel
		{
			get
			{
				return (EPortalModel)this.Instance.PortalModel;
			}
		}

		// Token: 0x170017B5 RID: 6069
		// (get) Token: 0x06004BF7 RID: 19447 RVA: 0x000BD78F File Offset: 0x000BB98F
		public override IPortalRenderConfig RenderConfig
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

		// Token: 0x04002B6C RID: 11116
		private IDynamicPortal Instance;

		// Token: 0x04002B6D RID: 11117
		private IPortalRenderConfig _RenderConfigCache;

		// Token: 0x04002B6E RID: 11118
		private bool _RenderConfigInited;
	}
}
