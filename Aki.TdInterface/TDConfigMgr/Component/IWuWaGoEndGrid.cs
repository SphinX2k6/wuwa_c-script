using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007F7 RID: 2039
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoEndGrid : IWuWaGoEntityBase
	{
		// Token: 0x06002C49 RID: 11337 RVA: 0x00073190 File Offset: 0x00071390
		private IWuWaGoEndGrid_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWuWaGoEndGrid 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWuWaGoEndGrid_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWuWaGoEndGrid_SetValue());
			}
			return result;
		}

		// Token: 0x06002C4A RID: 11338 RVA: 0x000731C8 File Offset: 0x000713C8
		public static IWuWaGoEndGrid Create([Nullable(2)] IWuWaGoEndGrid instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoEndGrid
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002C4B RID: 11339 RVA: 0x000731DB File Offset: 0x000713DB
		public static IWuWaGoEndGrid CreateFromSetValue([Nullable(2)] IWuWaGoEndGrid_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWuWaGoEndGrid
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002C4C RID: 11340 RVA: 0x000731EE File Offset: 0x000713EE
		public new IWuWaGoEndGrid_SetValue ToSetValue()
		{
			return new IWuWaGoEndGrid_SetValue
			{
				Type = this.Type,
				LinkData = this.LinkData
			};
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x06002C4D RID: 11341 RVA: 0x0007320D File Offset: 0x0007140D
		// (set) Token: 0x06002C4E RID: 11342 RVA: 0x00073238 File Offset: 0x00071438
		public override EWuWaGoEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EWuWaGoEntityType.LevelCenter;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06002C4F RID: 11343 RVA: 0x00073248 File Offset: 0x00071448
		// (set) Token: 0x06002C50 RID: 11344 RVA: 0x000732A9 File Offset: 0x000714A9
		public virtual IWuWaGoGridLinkData LinkData
		{
			get
			{
				if (this._LinkDataInited)
				{
					return this._LinkDataCache;
				}
				this._LinkDataInited = true;
				if (this.FbInstance != null)
				{
					this._LinkDataCache = IWuWaGoGridLinkData.Create(this.FbInstance.LinkData);
				}
				else
				{
					IWuWaGoEndGrid_SetValue pocoInterface = this.PocoInterface;
					this._LinkDataCache = ((pocoInterface != null) ? pocoInterface.LinkData : null);
				}
				return this._LinkDataCache;
			}
			set
			{
				this.GetOrCreatePoco().LinkData = value;
				this._LinkDataInited = false;
			}
		}

		// Token: 0x04001D57 RID: 7511
		[Nullable(2)]
		protected new IWuWaGoEndGrid FbInstance;

		// Token: 0x04001D58 RID: 7512
		[Nullable(2)]
		protected new IWuWaGoEndGrid_SetValue PocoInterface;

		// Token: 0x04001D59 RID: 7513
		private IWuWaGoGridLinkData _LinkDataCache;

		// Token: 0x04001D5A RID: 7514
		private bool _LinkDataInited;
	}
}
