using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000587 RID: 1415
	public class IMotorAutoEjectPositionEntityConfig : IMotorAutoEjectConfigBase
	{
		// Token: 0x06001C8E RID: 7310 RVA: 0x000521AC File Offset: 0x000503AC
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

		// Token: 0x06001C8F RID: 7311 RVA: 0x000521E4 File Offset: 0x000503E4
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

		// Token: 0x06001C90 RID: 7312 RVA: 0x000521F7 File Offset: 0x000503F7
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

		// Token: 0x06001C91 RID: 7313 RVA: 0x0005220A File Offset: 0x0005040A
		public new IMotorAutoEjectPositionEntityConfig_SetValue ToSetValue()
		{
			return new IMotorAutoEjectPositionEntityConfig_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001C92 RID: 7314 RVA: 0x00052229 File Offset: 0x00050429
		// (set) Token: 0x06001C93 RID: 7315 RVA: 0x00052254 File Offset: 0x00050454
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

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001C94 RID: 7316 RVA: 0x00052262 File Offset: 0x00050462
		// (set) Token: 0x06001C95 RID: 7317 RVA: 0x0005228D File Offset: 0x0005048D
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

		// Token: 0x0400149E RID: 5278
		[Nullable(2)]
		protected new IMotorAutoEjectPositionEntityConfig FbInstance;

		// Token: 0x0400149F RID: 5279
		[Nullable(2)]
		protected new IMotorAutoEjectPositionEntityConfig_SetValue PocoInterface;
	}
}
