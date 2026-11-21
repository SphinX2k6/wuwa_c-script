using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002B4 RID: 692
	public class IConnectorEffectConfig
	{
		// Token: 0x06000C81 RID: 3201 RVA: 0x00030AA8 File Offset: 0x0002ECA8
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

		// Token: 0x06000C82 RID: 3202 RVA: 0x00030AE0 File Offset: 0x0002ECE0
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

		// Token: 0x06000C83 RID: 3203 RVA: 0x00030AF3 File Offset: 0x0002ECF3
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

		// Token: 0x06000C84 RID: 3204 RVA: 0x00030B06 File Offset: 0x0002ED06
		public IConnectorEffectConfig_SetValue ToSetValue()
		{
			return new IConnectorEffectConfig_SetValue
			{
				EffectPath = this.EffectPath,
				StartPoint = this.StartPoint,
				EndPoint = this.EndPoint
			};
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x00030B31 File Offset: 0x0002ED31
		// (set) Token: 0x06000C86 RID: 3206 RVA: 0x00030B5C File Offset: 0x0002ED5C
		public virtual string EffectPath
		{
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
			set
			{
				this.GetOrCreatePoco().EffectPath = value;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x00030B6A File Offset: 0x0002ED6A
		// (set) Token: 0x06000C88 RID: 3208 RVA: 0x00030B91 File Offset: 0x0002ED91
		[Nullable(2)]
		public virtual string StartPoint
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().StartPoint = value;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000C89 RID: 3209 RVA: 0x00030B9F File Offset: 0x0002ED9F
		// (set) Token: 0x06000C8A RID: 3210 RVA: 0x00030BC6 File Offset: 0x0002EDC6
		[Nullable(2)]
		public virtual string EndPoint
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EndPoint = value;
			}
		}

		// Token: 0x04000BED RID: 3053
		[Nullable(2)]
		protected IConnectorEffectConfig FbInstance;

		// Token: 0x04000BEE RID: 3054
		[Nullable(2)]
		protected IConnectorEffectConfig_SetValue PocoInterface;
	}
}
