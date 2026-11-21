using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000441 RID: 1089
	public class IGravityFlipConfig
	{
		// Token: 0x060015B5 RID: 5557 RVA: 0x00044674 File Offset: 0x00042874
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

		// Token: 0x060015B6 RID: 5558 RVA: 0x000446AC File Offset: 0x000428AC
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

		// Token: 0x060015B7 RID: 5559 RVA: 0x000446BF File Offset: 0x000428BF
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

		// Token: 0x060015B8 RID: 5560 RVA: 0x000446D2 File Offset: 0x000428D2
		public IGravityFlipConfig_SetValue ToSetValue()
		{
			return new IGravityFlipConfig_SetValue
			{
				Type = this.Type,
				LocationEntityId = this.LocationEntityId
			};
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060015B9 RID: 5561 RVA: 0x000446F1 File Offset: 0x000428F1
		// (set) Token: 0x060015BA RID: 5562 RVA: 0x0004471C File Offset: 0x0004291C
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

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060015BB RID: 5563 RVA: 0x0004472A File Offset: 0x0004292A
		// (set) Token: 0x060015BC RID: 5564 RVA: 0x00044755 File Offset: 0x00042955
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

		// Token: 0x04001102 RID: 4354
		[Nullable(2)]
		protected IGravityFlipConfig FbInstance;

		// Token: 0x04001103 RID: 4355
		[Nullable(2)]
		protected IGravityFlipConfig_SetValue PocoInterface;
	}
}
