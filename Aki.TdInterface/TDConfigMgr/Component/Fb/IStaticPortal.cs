using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CFE RID: 3326
	[NullableContext(2)]
	[Nullable(0)]
	public class IStaticPortal : IPortalMode
	{
		// Token: 0x06004BED RID: 19437 RVA: 0x000BD69B File Offset: 0x000BB89B
		[NullableContext(1)]
		public static IStaticPortal Create(IStaticPortal? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStaticPortal
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x06004BEE RID: 19438 RVA: 0x000BD6BA File Offset: 0x000BB8BA
		public override EPortalType Type
		{
			get
			{
				return (EPortalType)this.Instance.Type;
			}
		}

		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x06004BEF RID: 19439 RVA: 0x000BD6C7 File Offset: 0x000BB8C7
		public override EPortalModel PortalModel
		{
			get
			{
				return (EPortalModel)this.Instance.PortalModel;
			}
		}

		// Token: 0x170017B0 RID: 6064
		// (get) Token: 0x06004BF0 RID: 19440 RVA: 0x000BD6D4 File Offset: 0x000BB8D4
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

		// Token: 0x170017B1 RID: 6065
		// (get) Token: 0x06004BF1 RID: 19441 RVA: 0x000BD708 File Offset: 0x000BB908
		public virtual int LinkPortalEntityId
		{
			get
			{
				return this.Instance.LinkPortalEntityId;
			}
		}

		// Token: 0x170017B2 RID: 6066
		// (get) Token: 0x06004BF2 RID: 19442 RVA: 0x000BD718 File Offset: 0x000BB918
		public virtual bool? IsStreamSource
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsStreamSource);
			}
		}

		// Token: 0x04002B69 RID: 11113
		private IStaticPortal Instance;

		// Token: 0x04002B6A RID: 11114
		private IPortalRenderConfig _RenderConfigCache;

		// Token: 0x04002B6B RID: 11115
		private bool _RenderConfigInited;
	}
}
