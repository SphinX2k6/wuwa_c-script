using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002B6 RID: 694
	public class IConnectorLogicType
	{
		// Token: 0x06000C8D RID: 3213 RVA: 0x00030BE4 File Offset: 0x0002EDE4
		private IConnectorLogicType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IConnectorLogicType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IConnectorLogicType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IConnectorLogicType_SetValue());
			}
			return result;
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00030C1C File Offset: 0x0002EE1C
		public static IConnectorLogicType Create([Nullable(2)] IConnectorLogicType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConnectorLogicType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00030C2F File Offset: 0x0002EE2F
		public static IConnectorLogicType CreateFromSetValue([Nullable(2)] IConnectorLogicType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IConnectorLogicType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00030C42 File Offset: 0x0002EE42
		public IConnectorLogicType_SetValue ToSetValue()
		{
			return new IConnectorLogicType_SetValue
			{
				Type = this.Type,
				EffectConfig = this.EffectConfig
			};
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x00030C61 File Offset: 0x0002EE61
		// (set) Token: 0x06000C92 RID: 3218 RVA: 0x00030C8C File Offset: 0x0002EE8C
		public virtual EConnectorLogicType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EConnectorLogicType.Range;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x00030C9C File Offset: 0x0002EE9C
		// (set) Token: 0x06000C94 RID: 3220 RVA: 0x00030CFD File Offset: 0x0002EEFD
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
					IConnectorLogicType_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04000BF2 RID: 3058
		[Nullable(2)]
		protected IConnectorLogicType FbInstance;

		// Token: 0x04000BF3 RID: 3059
		[Nullable(2)]
		protected IConnectorLogicType_SetValue PocoInterface;

		// Token: 0x04000BF4 RID: 3060
		private IConnectorEffectConfig _EffectConfigCache;

		// Token: 0x04000BF5 RID: 3061
		private bool _EffectConfigInited;
	}
}
