using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200058B RID: 1419
	public class IMotorHookAcceleration
	{
		// Token: 0x06001CB6 RID: 7350 RVA: 0x0005280C File Offset: 0x00050A0C
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

		// Token: 0x06001CB7 RID: 7351 RVA: 0x00052844 File Offset: 0x00050A44
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

		// Token: 0x06001CB8 RID: 7352 RVA: 0x00052857 File Offset: 0x00050A57
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

		// Token: 0x06001CB9 RID: 7353 RVA: 0x0005286A File Offset: 0x00050A6A
		public IMotorHookAcceleration_SetValue ToSetValue()
		{
			return new IMotorHookAcceleration_SetValue
			{
				MaxSpeed = this.MaxSpeed,
				SpeedSampleCurve = this.SpeedSampleCurve
			};
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001CBA RID: 7354 RVA: 0x00052889 File Offset: 0x00050A89
		// (set) Token: 0x06001CBB RID: 7355 RVA: 0x000528B4 File Offset: 0x00050AB4
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

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001CBC RID: 7356 RVA: 0x000528C2 File Offset: 0x00050AC2
		// (set) Token: 0x06001CBD RID: 7357 RVA: 0x000528ED File Offset: 0x00050AED
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

		// Token: 0x040014B8 RID: 5304
		[Nullable(2)]
		protected IMotorHookAcceleration FbInstance;

		// Token: 0x040014B9 RID: 5305
		[Nullable(2)]
		protected IMotorHookAcceleration_SetValue PocoInterface;
	}
}
