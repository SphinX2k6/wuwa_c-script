using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000256 RID: 598
	public class ICharacterConnectorLogicType
	{
		// Token: 0x06000A36 RID: 2614 RVA: 0x0002B50C File Offset: 0x0002970C
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

		// Token: 0x06000A37 RID: 2615 RVA: 0x0002B544 File Offset: 0x00029744
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

		// Token: 0x06000A38 RID: 2616 RVA: 0x0002B557 File Offset: 0x00029757
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

		// Token: 0x06000A39 RID: 2617 RVA: 0x0002B56A File Offset: 0x0002976A
		public ICharacterConnectorLogicType_SetValue ToSetValue()
		{
			return new ICharacterConnectorLogicType_SetValue
			{
				Type = this.Type,
				EffectConfig = this.EffectConfig
			};
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000A3A RID: 2618 RVA: 0x0002B589 File Offset: 0x00029789
		// (set) Token: 0x06000A3B RID: 2619 RVA: 0x0002B5B4 File Offset: 0x000297B4
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

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x0002B5C4 File Offset: 0x000297C4
		// (set) Token: 0x06000A3D RID: 2621 RVA: 0x0002B625 File Offset: 0x00029825
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

		// Token: 0x04000A86 RID: 2694
		[Nullable(2)]
		protected ICharacterConnectorLogicType FbInstance;

		// Token: 0x04000A87 RID: 2695
		[Nullable(2)]
		protected ICharacterConnectorLogicType_SetValue PocoInterface;

		// Token: 0x04000A88 RID: 2696
		private IConnectorEffectConfig _EffectConfigCache;

		// Token: 0x04000A89 RID: 2697
		private bool _EffectConfigInited;
	}
}
