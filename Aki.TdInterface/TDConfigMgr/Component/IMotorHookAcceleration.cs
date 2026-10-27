using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000524 RID: 1316
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorHookAcceleration
	{
		// Token: 0x06001ABA RID: 6842 RVA: 0x0004DA50 File Offset: 0x0004BC50
		private IMotorHookAcceleration_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorHookAcceleration 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorHookAcceleration_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorHookAcceleration_SetValue());
			}
			return result;
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x0004DA88 File Offset: 0x0004BC88
		public static IMotorHookAcceleration Create([Nullable(2)] IMotorHookAcceleration instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorHookAcceleration
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x0004DA9B File Offset: 0x0004BC9B
		public static IMotorHookAcceleration CreateFromSetValue([Nullable(2)] IMotorHookAcceleration_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorHookAcceleration
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x0004DAAE File Offset: 0x0004BCAE
		public IMotorHookAcceleration_SetValue ToSetValue()
		{
			return new IMotorHookAcceleration_SetValue
			{
				MaxSpeed = this.MaxSpeed,
				SpeedSampleCurve = this.SpeedSampleCurve
			};
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06001ABE RID: 6846 RVA: 0x0004DACD File Offset: 0x0004BCCD
		// (set) Token: 0x06001ABF RID: 6847 RVA: 0x0004DAF8 File Offset: 0x0004BCF8
		public virtual int MaxSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MaxSpeed;
			}
			set
			{
				this.GetOrCreatePoco().MaxSpeed = value;
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06001AC0 RID: 6848 RVA: 0x0004DB06 File Offset: 0x0004BD06
		// (set) Token: 0x06001AC1 RID: 6849 RVA: 0x0004DB31 File Offset: 0x0004BD31
		public virtual string SpeedSampleCurve
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SpeedSampleCurve;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SpeedSampleCurve;
			}
			set
			{
				this.GetOrCreatePoco().SpeedSampleCurve = value;
			}
		}

		// Token: 0x0400134E RID: 4942
		[Nullable(2)]
		protected IMotorHookAcceleration FbInstance;

		// Token: 0x0400134F RID: 4943
		[Nullable(2)]
		protected IMotorHookAcceleration_SetValue PocoInterface;
	}
}
