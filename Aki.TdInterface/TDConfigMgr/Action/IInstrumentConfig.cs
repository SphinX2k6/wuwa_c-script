using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CE8 RID: 7400
	public class IInstrumentConfig
	{
		// Token: 0x06009D0A RID: 40202 RVA: 0x00169A3C File Offset: 0x00167C3C
		private IInstrumentConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInstrumentConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInstrumentConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInstrumentConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009D0B RID: 40203 RVA: 0x00169A74 File Offset: 0x00167C74
		public static IInstrumentConfig Create([Nullable(2)] IInstrumentConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInstrumentConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009D0C RID: 40204 RVA: 0x00169A87 File Offset: 0x00167C87
		public static IInstrumentConfig CreateFromSetValue([Nullable(2)] IInstrumentConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInstrumentConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009D0D RID: 40205 RVA: 0x00169A9A File Offset: 0x00167C9A
		public IInstrumentConfig_SetValue ToSetValue()
		{
			return new IInstrumentConfig_SetValue
			{
				Id = this.Id,
				InstrumentType = this.InstrumentType,
				KeyConfigs = this.KeyConfigs
			};
		}

		// Token: 0x17003136 RID: 12598
		// (get) Token: 0x06009D0E RID: 40206 RVA: 0x00169AC5 File Offset: 0x00167CC5
		// (set) Token: 0x06009D0F RID: 40207 RVA: 0x00169AF0 File Offset: 0x00167CF0
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x17003137 RID: 12599
		// (get) Token: 0x06009D10 RID: 40208 RVA: 0x00169AFE File Offset: 0x00167CFE
		// (set) Token: 0x06009D11 RID: 40209 RVA: 0x00169B29 File Offset: 0x00167D29
		public virtual EInstrumentType InstrumentType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InstrumentType;
				}
				if (this.PocoInterface == null)
				{
					return EInstrumentType.ChineseZither;
				}
				return this.PocoInterface.InstrumentType;
			}
			set
			{
				this.GetOrCreatePoco().InstrumentType = value;
			}
		}

		// Token: 0x17003138 RID: 12600
		// (get) Token: 0x06009D12 RID: 40210 RVA: 0x00169B38 File Offset: 0x00167D38
		// (set) Token: 0x06009D13 RID: 40211 RVA: 0x00169B99 File Offset: 0x00167D99
		public virtual IInstrumentKeyConfigs KeyConfigs
		{
			get
			{
				if (this._KeyConfigsInited)
				{
					return this._KeyConfigsCache;
				}
				this._KeyConfigsInited = true;
				if (this.FbInstance != null)
				{
					this._KeyConfigsCache = IInstrumentKeyConfigs.Create(this.FbInstance.KeyConfigs);
				}
				else
				{
					IInstrumentConfig_SetValue pocoInterface = this.PocoInterface;
					this._KeyConfigsCache = ((pocoInterface != null) ? pocoInterface.KeyConfigs : null);
				}
				return this._KeyConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().KeyConfigs = value;
				this._KeyConfigsInited = false;
			}
		}

		// Token: 0x04005FE5 RID: 24549
		[Nullable(2)]
		protected IInstrumentConfig FbInstance;

		// Token: 0x04005FE6 RID: 24550
		[Nullable(2)]
		protected IInstrumentConfig_SetValue PocoInterface;

		// Token: 0x04005FE7 RID: 24551
		private IInstrumentKeyConfigs _KeyConfigsCache;

		// Token: 0x04005FE8 RID: 24552
		private bool _KeyConfigsInited;
	}
}
