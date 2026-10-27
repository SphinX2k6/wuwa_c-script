using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000273 RID: 627
	[NullableContext(1)]
	[Nullable(0)]
	public class IConnectorLogicType
	{
		// Token: 0x06000B73 RID: 2931 RVA: 0x0002DEF4 File Offset: 0x0002C0F4
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

		// Token: 0x06000B74 RID: 2932 RVA: 0x0002DF2C File Offset: 0x0002C12C
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

		// Token: 0x06000B75 RID: 2933 RVA: 0x0002DF3F File Offset: 0x0002C13F
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

		// Token: 0x06000B76 RID: 2934 RVA: 0x0002DF52 File Offset: 0x0002C152
		public IConnectorLogicType_SetValue ToSetValue()
		{
			return new IConnectorLogicType_SetValue
			{
				Type = this.Type,
				EffectConfig = this.EffectConfig
			};
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x0002DF71 File Offset: 0x0002C171
		// (set) Token: 0x06000B78 RID: 2936 RVA: 0x0002DF9C File Offset: 0x0002C19C
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

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x0002DFAC File Offset: 0x0002C1AC
		// (set) Token: 0x06000B7A RID: 2938 RVA: 0x0002E00D File Offset: 0x0002C20D
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

		// Token: 0x04000B11 RID: 2833
		[Nullable(2)]
		protected IConnectorLogicType FbInstance;

		// Token: 0x04000B12 RID: 2834
		[Nullable(2)]
		protected IConnectorLogicType_SetValue PocoInterface;

		// Token: 0x04000B13 RID: 2835
		private IConnectorEffectConfig _EffectConfigCache;

		// Token: 0x04000B14 RID: 2836
		private bool _EffectConfigInited;
	}
}
