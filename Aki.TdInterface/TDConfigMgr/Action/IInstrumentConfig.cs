using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B39 RID: 6969
	[NullableContext(1)]
	[Nullable(0)]
	public class IInstrumentConfig
	{
		// Token: 0x06009520 RID: 38176 RVA: 0x00158D60 File Offset: 0x00156F60
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

		// Token: 0x06009521 RID: 38177 RVA: 0x00158D98 File Offset: 0x00156F98
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

		// Token: 0x06009522 RID: 38178 RVA: 0x00158DAB File Offset: 0x00156FAB
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

		// Token: 0x06009523 RID: 38179 RVA: 0x00158DBE File Offset: 0x00156FBE
		public IInstrumentConfig_SetValue ToSetValue()
		{
			return new IInstrumentConfig_SetValue
			{
				Id = this.Id,
				InstrumentType = this.InstrumentType,
				KeyConfigs = this.KeyConfigs
			};
		}

		// Token: 0x17002F10 RID: 12048
		// (get) Token: 0x06009524 RID: 38180 RVA: 0x00158DE9 File Offset: 0x00156FE9
		// (set) Token: 0x06009525 RID: 38181 RVA: 0x00158E14 File Offset: 0x00157014
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

		// Token: 0x17002F11 RID: 12049
		// (get) Token: 0x06009526 RID: 38182 RVA: 0x00158E22 File Offset: 0x00157022
		// (set) Token: 0x06009527 RID: 38183 RVA: 0x00158E4D File Offset: 0x0015704D
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

		// Token: 0x17002F12 RID: 12050
		// (get) Token: 0x06009528 RID: 38184 RVA: 0x00158E5C File Offset: 0x0015705C
		// (set) Token: 0x06009529 RID: 38185 RVA: 0x00158EBD File Offset: 0x001570BD
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

		// Token: 0x04005B47 RID: 23367
		[Nullable(2)]
		protected IInstrumentConfig FbInstance;

		// Token: 0x04005B48 RID: 23368
		[Nullable(2)]
		protected IInstrumentConfig_SetValue PocoInterface;

		// Token: 0x04005B49 RID: 23369
		private IInstrumentKeyConfigs _KeyConfigsCache;

		// Token: 0x04005B4A RID: 23370
		private bool _KeyConfigsInited;
	}
}
