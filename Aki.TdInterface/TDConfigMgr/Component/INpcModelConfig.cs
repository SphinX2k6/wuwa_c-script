using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000562 RID: 1378
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcModelConfig
	{
		// Token: 0x06001C3C RID: 7228 RVA: 0x00050EC8 File Offset: 0x0004F0C8
		private INpcModelConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcModelConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcModelConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcModelConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x00050F00 File Offset: 0x0004F100
		public static INpcModelConfig Create([Nullable(2)] INpcModelConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcModelConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x00050F13 File Offset: 0x0004F113
		public static INpcModelConfig CreateFromSetValue([Nullable(2)] INpcModelConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcModelConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x00050F26 File Offset: 0x0004F126
		public INpcModelConfig_SetValue ToSetValue()
		{
			return new INpcModelConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x00050F39 File Offset: 0x0004F139
		// (set) Token: 0x06001C41 RID: 7233 RVA: 0x00050F64 File Offset: 0x0004F164
		public virtual ENpcModelType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcModelType.Mesh;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400142E RID: 5166
		[Nullable(2)]
		protected INpcModelConfig FbInstance;

		// Token: 0x0400142F RID: 5167
		[Nullable(2)]
		protected INpcModelConfig_SetValue PocoInterface;
	}
}
