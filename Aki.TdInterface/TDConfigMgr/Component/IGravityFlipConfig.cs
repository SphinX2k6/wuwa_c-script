using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003E8 RID: 1000
	[NullableContext(1)]
	[Nullable(0)]
	public class IGravityFlipConfig
	{
		// Token: 0x0600141B RID: 5147 RVA: 0x0004092C File Offset: 0x0003EB2C
		private IGravityFlipConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGravityFlipConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGravityFlipConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGravityFlipConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x00040964 File Offset: 0x0003EB64
		public static IGravityFlipConfig Create([Nullable(2)] IGravityFlipConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGravityFlipConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x00040977 File Offset: 0x0003EB77
		public static IGravityFlipConfig CreateFromSetValue([Nullable(2)] IGravityFlipConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGravityFlipConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x0004098A File Offset: 0x0003EB8A
		public IGravityFlipConfig_SetValue ToSetValue()
		{
			return new IGravityFlipConfig_SetValue
			{
				Type = this.Type,
				LocationEntityId = this.LocationEntityId
			};
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x000409A9 File Offset: 0x0003EBA9
		// (set) Token: 0x06001420 RID: 5152 RVA: 0x000409D4 File Offset: 0x0003EBD4
		public virtual EGravityFlipType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return (EGravityFlipType)0;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x000409E2 File Offset: 0x0003EBE2
		// (set) Token: 0x06001422 RID: 5154 RVA: 0x00040A0D File Offset: 0x0003EC0D
		public virtual int LocationEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LocationEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LocationEntityId;
			}
			set
			{
				this.GetOrCreatePoco().LocationEntityId = value;
			}
		}

		// Token: 0x04000FE0 RID: 4064
		[Nullable(2)]
		protected IGravityFlipConfig FbInstance;

		// Token: 0x04000FE1 RID: 4065
		[Nullable(2)]
		protected IGravityFlipConfig_SetValue PocoInterface;
	}
}
