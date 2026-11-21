using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008BC RID: 2236
	public class IWuWaGoSpikeTrap : IWuWaGoEntityBase
	{
		// Token: 0x06003035 RID: 12341 RVA: 0x0007BE98 File Offset: 0x0007A098
		private IWuWaGoSpikeTrap_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWuWaGoSpikeTrap 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWuWaGoSpikeTrap_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWuWaGoSpikeTrap_SetValue());
			}
			return result;
		}

		// Token: 0x06003036 RID: 12342 RVA: 0x0007BED0 File Offset: 0x0007A0D0
		public static IWuWaGoSpikeTrap Create([Nullable(2)] IWuWaGoSpikeTrap instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoSpikeTrap
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003037 RID: 12343 RVA: 0x0007BEE3 File Offset: 0x0007A0E3
		public static IWuWaGoSpikeTrap CreateFromSetValue([Nullable(2)] IWuWaGoSpikeTrap_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWuWaGoSpikeTrap
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003038 RID: 12344 RVA: 0x0007BEF6 File Offset: 0x0007A0F6
		public new IWuWaGoSpikeTrap_SetValue ToSetValue()
		{
			return new IWuWaGoSpikeTrap_SetValue
			{
				Type = this.Type,
				LinkData = this.LinkData
			};
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x06003039 RID: 12345 RVA: 0x0007BF15 File Offset: 0x0007A115
		// (set) Token: 0x0600303A RID: 12346 RVA: 0x0007BF40 File Offset: 0x0007A140
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

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x0600303B RID: 12347 RVA: 0x0007BF50 File Offset: 0x0007A150
		// (set) Token: 0x0600303C RID: 12348 RVA: 0x0007BFB1 File Offset: 0x0007A1B1
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
					IWuWaGoSpikeTrap_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04001FD8 RID: 8152
		[Nullable(2)]
		protected new IWuWaGoSpikeTrap FbInstance;

		// Token: 0x04001FD9 RID: 8153
		[Nullable(2)]
		protected new IWuWaGoSpikeTrap_SetValue PocoInterface;

		// Token: 0x04001FDA RID: 8154
		private IWuWaGoGridLinkData _LinkDataCache;

		// Token: 0x04001FDB RID: 8155
		private bool _LinkDataInited;
	}
}
