using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000271 RID: 625
	[NullableContext(2)]
	[Nullable(0)]
	public class IConnectorEffectConfig
	{
		// Token: 0x06000B67 RID: 2919 RVA: 0x0002DDB8 File Offset: 0x0002BFB8
		[NullableContext(1)]
		private IConnectorEffectConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IConnectorEffectConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IConnectorEffectConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IConnectorEffectConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0002DDF0 File Offset: 0x0002BFF0
		[NullableContext(1)]
		public static IConnectorEffectConfig Create([Nullable(2)] IConnectorEffectConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConnectorEffectConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0002DE03 File Offset: 0x0002C003
		[NullableContext(1)]
		public static IConnectorEffectConfig CreateFromSetValue([Nullable(2)] IConnectorEffectConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IConnectorEffectConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0002DE16 File Offset: 0x0002C016
		[NullableContext(1)]
		public IConnectorEffectConfig_SetValue ToSetValue()
		{
			return new IConnectorEffectConfig_SetValue
			{
				EffectPath = this.EffectPath,
				StartPoint = this.StartPoint,
				EndPoint = this.EndPoint
			};
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x0002DE41 File Offset: 0x0002C041
		// (set) Token: 0x06000B6C RID: 2924 RVA: 0x0002DE6C File Offset: 0x0002C06C
		[Nullable(1)]
		public virtual string EffectPath
		{
			[NullableContext(1)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EffectPath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EffectPath;
			}
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().EffectPath = value;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x0002DE7A File Offset: 0x0002C07A
		// (set) Token: 0x06000B6E RID: 2926 RVA: 0x0002DEA1 File Offset: 0x0002C0A1
		public virtual string StartPoint
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartPoint;
				}
				IConnectorEffectConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StartPoint;
			}
			set
			{
				this.GetOrCreatePoco().StartPoint = value;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x0002DEAF File Offset: 0x0002C0AF
		// (set) Token: 0x06000B70 RID: 2928 RVA: 0x0002DED6 File Offset: 0x0002C0D6
		public virtual string EndPoint
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EndPoint;
				}
				IConnectorEffectConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EndPoint;
			}
			set
			{
				this.GetOrCreatePoco().EndPoint = value;
			}
		}

		// Token: 0x04000B0C RID: 2828
		protected IConnectorEffectConfig FbInstance;

		// Token: 0x04000B0D RID: 2829
		protected IConnectorEffectConfig_SetValue PocoInterface;
	}
}
