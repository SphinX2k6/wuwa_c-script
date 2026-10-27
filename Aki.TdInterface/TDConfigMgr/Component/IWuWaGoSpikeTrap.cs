using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000819 RID: 2073
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoSpikeTrap : IWuWaGoEntityBase
	{
		// Token: 0x06002D05 RID: 11525 RVA: 0x00074B34 File Offset: 0x00072D34
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

		// Token: 0x06002D06 RID: 11526 RVA: 0x00074B6C File Offset: 0x00072D6C
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

		// Token: 0x06002D07 RID: 11527 RVA: 0x00074B7F File Offset: 0x00072D7F
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

		// Token: 0x06002D08 RID: 11528 RVA: 0x00074B92 File Offset: 0x00072D92
		public new IWuWaGoSpikeTrap_SetValue ToSetValue()
		{
			return new IWuWaGoSpikeTrap_SetValue
			{
				Type = this.Type,
				LinkData = this.LinkData
			};
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06002D09 RID: 11529 RVA: 0x00074BB1 File Offset: 0x00072DB1
		// (set) Token: 0x06002D0A RID: 11530 RVA: 0x00074BDC File Offset: 0x00072DDC
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

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06002D0B RID: 11531 RVA: 0x00074BEC File Offset: 0x00072DEC
		// (set) Token: 0x06002D0C RID: 11532 RVA: 0x00074C4D File Offset: 0x00072E4D
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

		// Token: 0x04001DCC RID: 7628
		[Nullable(2)]
		protected new IWuWaGoSpikeTrap FbInstance;

		// Token: 0x04001DCD RID: 7629
		[Nullable(2)]
		protected new IWuWaGoSpikeTrap_SetValue PocoInterface;

		// Token: 0x04001DCE RID: 7630
		private IWuWaGoGridLinkData _LinkDataCache;

		// Token: 0x04001DCF RID: 7631
		private bool _LinkDataInited;
	}
}
