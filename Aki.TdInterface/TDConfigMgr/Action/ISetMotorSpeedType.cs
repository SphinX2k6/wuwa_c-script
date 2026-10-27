using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E2E RID: 7726
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetMotorSpeedType
	{
		// Token: 0x0600A547 RID: 42311 RVA: 0x00176784 File Offset: 0x00174984
		private ISetMotorSpeedType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetMotorSpeedType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetMotorSpeedType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetMotorSpeedType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A548 RID: 42312 RVA: 0x001767BC File Offset: 0x001749BC
		public static ISetMotorSpeedType Create([Nullable(2)] ISetMotorSpeedType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetMotorSpeedType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A549 RID: 42313 RVA: 0x001767CF File Offset: 0x001749CF
		public static ISetMotorSpeedType CreateFromSetValue([Nullable(2)] ISetMotorSpeedType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetMotorSpeedType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A54A RID: 42314 RVA: 0x001767E2 File Offset: 0x001749E2
		public ISetMotorSpeedType_SetValue ToSetValue()
		{
			return new ISetMotorSpeedType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170032B5 RID: 12981
		// (get) Token: 0x0600A54B RID: 42315 RVA: 0x001767F5 File Offset: 0x001749F5
		// (set) Token: 0x0600A54C RID: 42316 RVA: 0x00176820 File Offset: 0x00174A20
		public virtual EMotorSpeedType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMotorSpeedType.TargetSpeed;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040062D8 RID: 25304
		[Nullable(2)]
		protected ISetMotorSpeedType FbInstance;

		// Token: 0x040062D9 RID: 25305
		[Nullable(2)]
		protected ISetMotorSpeedType_SetValue PocoInterface;
	}
}
