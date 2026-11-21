using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DFC RID: 3580
	public class IDynamicPortalByBullet : IDynamicPortalCreateMode
	{
		// Token: 0x0600511C RID: 20764 RVA: 0x000C8F38 File Offset: 0x000C7138
		public static IDynamicPortalByBullet Create(IDynamicPortalByBullet? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicPortalByBullet
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700191F RID: 6431
		// (get) Token: 0x0600511D RID: 20765 RVA: 0x000C8F57 File Offset: 0x000C7157
		public override EDynamicPortalCreateType Type
		{
			get
			{
				return (EDynamicPortalCreateType)this.Instance.Type;
			}
		}

		// Token: 0x17001920 RID: 6432
		// (get) Token: 0x0600511E RID: 20766 RVA: 0x000C8F64 File Offset: 0x000C7164
		public override IDynamicPortalConfig PortalA
		{
			get
			{
				if (this._PortalAInited)
				{
					return this._PortalACache;
				}
				this._PortalAInited = true;
				this._PortalACache = IDynamicPortalConfig.Create(this.Instance.PortalA);
				return this._PortalACache;
			}
		}

		// Token: 0x17001921 RID: 6433
		// (get) Token: 0x0600511F RID: 20767 RVA: 0x000C8F98 File Offset: 0x000C7198
		public override IDynamicPortalConfig PortalB
		{
			get
			{
				if (this._PortalBInited)
				{
					return this._PortalBCache;
				}
				this._PortalBInited = true;
				this._PortalBCache = IDynamicPortalConfig.Create(this.Instance.PortalB);
				return this._PortalBCache;
			}
		}

		// Token: 0x17001922 RID: 6434
		// (get) Token: 0x06005120 RID: 20768 RVA: 0x000C8FCC File Offset: 0x000C71CC
		public override EPortalModel? InitOpenPortal
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EPortalModel?((EPortalModel)this.Instance.InitOpenPortal);
			}
		}

		// Token: 0x17001923 RID: 6435
		// (get) Token: 0x06005121 RID: 20769 RVA: 0x000C9002 File Offset: 0x000C7202
		[Nullable(2)]
		public override IPortalRenderConfig RenderConfig
		{
			[NullableContext(2)]
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

		// Token: 0x17001924 RID: 6436
		// (get) Token: 0x06005122 RID: 20770 RVA: 0x000C9036 File Offset: 0x000C7236
		public virtual IDynamicBulletConfig TypeA
		{
			get
			{
				if (this._TypeAInited)
				{
					return this._TypeACache;
				}
				this._TypeAInited = true;
				this._TypeACache = IDynamicBulletConfig.Create(this.Instance.TypeA);
				return this._TypeACache;
			}
		}

		// Token: 0x17001925 RID: 6437
		// (get) Token: 0x06005123 RID: 20771 RVA: 0x000C906A File Offset: 0x000C726A
		public virtual IDynamicBulletConfig TypeB
		{
			get
			{
				if (this._TypeBInited)
				{
					return this._TypeBCache;
				}
				this._TypeBInited = true;
				this._TypeBCache = IDynamicBulletConfig.Create(this.Instance.TypeB);
				return this._TypeBCache;
			}
		}

		// Token: 0x04002E35 RID: 11829
		private IDynamicPortalByBullet Instance;

		// Token: 0x04002E36 RID: 11830
		[Nullable(2)]
		private IDynamicPortalConfig _PortalACache;

		// Token: 0x04002E37 RID: 11831
		private bool _PortalAInited;

		// Token: 0x04002E38 RID: 11832
		[Nullable(2)]
		private IDynamicPortalConfig _PortalBCache;

		// Token: 0x04002E39 RID: 11833
		private bool _PortalBInited;

		// Token: 0x04002E3A RID: 11834
		[Nullable(2)]
		private IPortalRenderConfig _RenderConfigCache;

		// Token: 0x04002E3B RID: 11835
		private bool _RenderConfigInited;

		// Token: 0x04002E3C RID: 11836
		[Nullable(2)]
		private IDynamicBulletConfig _TypeACache;

		// Token: 0x04002E3D RID: 11837
		private bool _TypeAInited;

		// Token: 0x04002E3E RID: 11838
		[Nullable(2)]
		private IDynamicBulletConfig _TypeBCache;

		// Token: 0x04002E3F RID: 11839
		private bool _TypeBInited;
	}
}
