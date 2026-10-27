using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200022F RID: 559
	[NullableContext(1)]
	[Nullable(0)]
	public class ICharacterConnectorLogicType
	{
		// Token: 0x060009C2 RID: 2498 RVA: 0x00029D4C File Offset: 0x00027F4C
		private ICharacterConnectorLogicType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICharacterConnectorLogicType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICharacterConnectorLogicType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICharacterConnectorLogicType_SetValue());
			}
			return result;
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00029D84 File Offset: 0x00027F84
		public static ICharacterConnectorLogicType Create([Nullable(2)] ICharacterConnectorLogicType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICharacterConnectorLogicType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00029D97 File Offset: 0x00027F97
		public static ICharacterConnectorLogicType CreateFromSetValue([Nullable(2)] ICharacterConnectorLogicType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICharacterConnectorLogicType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00029DAA File Offset: 0x00027FAA
		public ICharacterConnectorLogicType_SetValue ToSetValue()
		{
			return new ICharacterConnectorLogicType_SetValue
			{
				Type = this.Type,
				EffectConfig = this.EffectConfig
			};
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x00029DC9 File Offset: 0x00027FC9
		// (set) Token: 0x060009C7 RID: 2503 RVA: 0x00029DF4 File Offset: 0x00027FF4
		public virtual ECharacterConnectorLogicType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECharacterConnectorLogicType.Range;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x00029E04 File Offset: 0x00028004
		// (set) Token: 0x060009C9 RID: 2505 RVA: 0x00029E65 File Offset: 0x00028065
		public virtual IConnectorEffectConfig EffectConfig
		{
			get
			{
				if (this._EffectConfigInited)
				{
					return this._EffectConfigCache;
				}
				this._EffectConfigInited = true;
				if (this.FbInstance != null)
				{
					this._EffectConfigCache = IConnectorEffectConfig.Create(this.FbInstance.EffectConfig);
				}
				else
				{
					ICharacterConnectorLogicType_SetValue pocoInterface = this.PocoInterface;
					this._EffectConfigCache = ((pocoInterface != null) ? pocoInterface.EffectConfig : null);
				}
				return this._EffectConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().EffectConfig = value;
				this._EffectConfigInited = false;
			}
		}

		// Token: 0x040009FC RID: 2556
		[Nullable(2)]
		protected ICharacterConnectorLogicType FbInstance;

		// Token: 0x040009FD RID: 2557
		[Nullable(2)]
		protected ICharacterConnectorLogicType_SetValue PocoInterface;

		// Token: 0x040009FE RID: 2558
		private IConnectorEffectConfig _EffectConfigCache;

		// Token: 0x040009FF RID: 2559
		private bool _EffectConfigInited;
	}
}
