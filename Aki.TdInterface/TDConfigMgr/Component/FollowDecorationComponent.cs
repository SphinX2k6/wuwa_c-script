using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000177 RID: 375
	[NullableContext(1)]
	[Nullable(0)]
	public class FollowDecorationComponent : IComponentBase
	{
		// Token: 0x06000504 RID: 1284 RVA: 0x0001F8C0 File Offset: 0x0001DAC0
		private FollowDecorationComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("FollowDecorationComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			FollowDecorationComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new FollowDecorationComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0001F8F8 File Offset: 0x0001DAF8
		public static FollowDecorationComponent Create([Nullable(2)] FollowDecorationComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FollowDecorationComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0001F90B File Offset: 0x0001DB0B
		public static FollowDecorationComponent CreateFromSetValue([Nullable(2)] FollowDecorationComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new FollowDecorationComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0001F91E File Offset: 0x0001DB1E
		public new FollowDecorationComponent_SetValue ToSetValue()
		{
			return new FollowDecorationComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				DecorationConfig = this.DecorationConfig
			};
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x0001F94C File Offset: 0x0001DB4C
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x0001F986 File Offset: 0x0001DB86
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				FollowDecorationComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x0001F994 File Offset: 0x0001DB94
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x0001F9BE File Offset: 0x0001DBBE
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x0001F9CC File Offset: 0x0001DBCC
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x0001FA2D File Offset: 0x0001DC2D
		public virtual IFollowDecorationChairConfig DecorationConfig
		{
			get
			{
				if (this._DecorationConfigInited)
				{
					return this._DecorationConfigCache;
				}
				this._DecorationConfigInited = true;
				if (this.FbInstance != null)
				{
					this._DecorationConfigCache = IFollowDecorationChairConfig.Create(this.FbInstance.DecorationConfig);
				}
				else
				{
					FollowDecorationComponent_SetValue pocoInterface = this.PocoInterface;
					this._DecorationConfigCache = ((pocoInterface != null) ? pocoInterface.DecorationConfig : null);
				}
				return this._DecorationConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().DecorationConfig = value;
				this._DecorationConfigInited = false;
			}
		}

		// Token: 0x0400072D RID: 1837
		[Nullable(2)]
		protected new FollowDecorationComponent FbInstance;

		// Token: 0x0400072E RID: 1838
		[Nullable(2)]
		protected new FollowDecorationComponent_SetValue PocoInterface;

		// Token: 0x0400072F RID: 1839
		private IFollowDecorationChairConfig _DecorationConfigCache;

		// Token: 0x04000730 RID: 1840
		private bool _DecorationConfigInited;
	}
}
