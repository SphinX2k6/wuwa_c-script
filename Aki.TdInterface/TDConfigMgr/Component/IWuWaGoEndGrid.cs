using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200089A RID: 2202
	public class IWuWaGoEndGrid : IWuWaGoEntityBase
	{
		// Token: 0x06002F79 RID: 12153 RVA: 0x0007A4F4 File Offset: 0x000786F4
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

		// Token: 0x06002F7A RID: 12154 RVA: 0x0007A52C File Offset: 0x0007872C
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

		// Token: 0x06002F7B RID: 12155 RVA: 0x0007A53F File Offset: 0x0007873F
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

		// Token: 0x06002F7C RID: 12156 RVA: 0x0007A552 File Offset: 0x00078752
		public new IWuWaGoEndGrid_SetValue ToSetValue()
		{
			return new IWuWaGoEndGrid_SetValue
			{
				Type = this.Type,
				LinkData = this.LinkData
			};
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06002F7D RID: 12157 RVA: 0x0007A571 File Offset: 0x00078771
		// (set) Token: 0x06002F7E RID: 12158 RVA: 0x0007A59C File Offset: 0x0007879C
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

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06002F7F RID: 12159 RVA: 0x0007A5AC File Offset: 0x000787AC
		// (set) Token: 0x06002F80 RID: 12160 RVA: 0x0007A60D File Offset: 0x0007880D
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

		// Token: 0x04001F63 RID: 8035
		[Nullable(2)]
		protected new IWuWaGoEndGrid FbInstance;

		// Token: 0x04001F64 RID: 8036
		[Nullable(2)]
		protected new IWuWaGoEndGrid_SetValue PocoInterface;

		// Token: 0x04001F65 RID: 8037
		private IWuWaGoGridLinkData _LinkDataCache;

		// Token: 0x04001F66 RID: 8038
		private bool _LinkDataInited;
	}
}
