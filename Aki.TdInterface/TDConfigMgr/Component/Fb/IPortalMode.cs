using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DF5 RID: 3573
	[NullableContext(2)]
	[Nullable(0)]
	public class IPortalMode
	{
		// Token: 0x060050F6 RID: 20726 RVA: 0x000C8B56 File Offset: 0x000C6D56
		[NullableContext(0)]
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

		// Token: 0x17001907 RID: 6407
		// (get) Token: 0x060050F7 RID: 20727 RVA: 0x000C8B75 File Offset: 0x000C6D75
		public virtual EPortalType Type
		{
			get
			{
				return (EPortalType)this.Instance.Type;
			}
		}

		// Token: 0x17001908 RID: 6408
		// (get) Token: 0x060050F8 RID: 20728 RVA: 0x000C8B82 File Offset: 0x000C6D82
		public virtual EPortalModel PortalModel
		{
			get
			{
				return (EPortalModel)this.Instance.PortalModel;
			}
		}

		// Token: 0x17001909 RID: 6409
		// (get) Token: 0x060050F9 RID: 20729 RVA: 0x000C8B8F File Offset: 0x000C6D8F
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

		// Token: 0x04002E20 RID: 11808
		private IPortalMode Instance;

		// Token: 0x04002E21 RID: 11809
		private IPortalRenderConfig _RenderConfigCache;

		// Token: 0x04002E22 RID: 11810
		private bool _RenderConfigInited;
	}
}
