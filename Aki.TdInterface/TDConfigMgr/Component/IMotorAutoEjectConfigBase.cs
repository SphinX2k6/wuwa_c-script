using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200051C RID: 1308
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorAutoEjectConfigBase
	{
		// Token: 0x06001A80 RID: 6784 RVA: 0x0004D234 File Offset: 0x0004B434
		private IMotorAutoEjectConfigBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorAutoEjectConfigBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorAutoEjectConfigBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorAutoEjectConfigBase_SetValue());
			}
			return result;
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x0004D26C File Offset: 0x0004B46C
		public static IMotorAutoEjectConfigBase Create([Nullable(2)] IMotorAutoEjectConfigBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorAutoEjectConfigBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x0004D27F File Offset: 0x0004B47F
		public static IMotorAutoEjectConfigBase CreateFromSetValue([Nullable(2)] IMotorAutoEjectConfigBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorAutoEjectConfigBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x0004D292 File Offset: 0x0004B492
		public IMotorAutoEjectConfigBase_SetValue ToSetValue()
		{
			return new IMotorAutoEjectConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x0004D2A5 File Offset: 0x0004B4A5
		// (set) Token: 0x06001A85 RID: 6789 RVA: 0x0004D2D0 File Offset: 0x0004B4D0
		public virtual EMotorAutoEjectType Type
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

		// Token: 0x0400132D RID: 4909
		[Nullable(2)]
		protected IMotorAutoEjectConfigBase FbInstance;

		// Token: 0x0400132E RID: 4910
		[Nullable(2)]
		protected IMotorAutoEjectConfigBase_SetValue PocoInterface;
	}
}
