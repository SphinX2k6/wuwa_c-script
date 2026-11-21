using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DF7 RID: 3575
	[NullableContext(2)]
	[Nullable(0)]
	public class IDynamicPortal : IPortalMode
	{
		// Token: 0x06005102 RID: 20738 RVA: 0x000C8C86 File Offset: 0x000C6E86
		[NullableContext(0)]
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

		// Token: 0x1700190F RID: 6415
		// (get) Token: 0x06005103 RID: 20739 RVA: 0x000C8CA5 File Offset: 0x000C6EA5
		public override EPortalType Type
		{
			get
			{
				return (EPortalType)this.Instance.Type;
			}
		}

		// Token: 0x17001910 RID: 6416
		// (get) Token: 0x06005104 RID: 20740 RVA: 0x000C8CB2 File Offset: 0x000C6EB2
		public override EPortalModel PortalModel
		{
			get
			{
				return (EPortalModel)this.Instance.PortalModel;
			}
		}

		// Token: 0x17001911 RID: 6417
		// (get) Token: 0x06005105 RID: 20741 RVA: 0x000C8CBF File Offset: 0x000C6EBF
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

		// Token: 0x04002E26 RID: 11814
		private IDynamicPortal Instance;

		// Token: 0x04002E27 RID: 11815
		private IPortalRenderConfig _RenderConfigCache;

		// Token: 0x04002E28 RID: 11816
		private bool _RenderConfigInited;
	}
}
