using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000520 RID: 1312
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorAutoEjectPositionEntityConfig : IMotorAutoEjectConfigBase
	{
		// Token: 0x06001A92 RID: 6802 RVA: 0x0004D3F0 File Offset: 0x0004B5F0
		private IMotorAutoEjectPositionEntityConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorAutoEjectPositionEntityConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorAutoEjectPositionEntityConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorAutoEjectPositionEntityConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x0004D428 File Offset: 0x0004B628
		public static IMotorAutoEjectPositionEntityConfig Create([Nullable(2)] IMotorAutoEjectPositionEntityConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorAutoEjectPositionEntityConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x0004D43B File Offset: 0x0004B63B
		public static IMotorAutoEjectPositionEntityConfig CreateFromSetValue([Nullable(2)] IMotorAutoEjectPositionEntityConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorAutoEjectPositionEntityConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x0004D44E File Offset: 0x0004B64E
		public new IMotorAutoEjectPositionEntityConfig_SetValue ToSetValue()
		{
			return new IMotorAutoEjectPositionEntityConfig_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06001A96 RID: 6806 RVA: 0x0004D46D File Offset: 0x0004B66D
		// (set) Token: 0x06001A97 RID: 6807 RVA: 0x0004D498 File Offset: 0x0004B698
		public override EMotorAutoEjectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMotorAutoEjectType.NextHook;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06001A98 RID: 6808 RVA: 0x0004D4A6 File Offset: 0x0004B6A6
		// (set) Token: 0x06001A99 RID: 6809 RVA: 0x0004D4D1 File Offset: 0x0004B6D1
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x04001334 RID: 4916
		[Nullable(2)]
		protected new IMotorAutoEjectPositionEntityConfig FbInstance;

		// Token: 0x04001335 RID: 4917
		[Nullable(2)]
		protected new IMotorAutoEjectPositionEntityConfig_SetValue PocoInterface;
	}
}
