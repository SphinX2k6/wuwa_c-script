using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000237 RID: 567
	[NullableContext(1)]
	[Nullable(0)]
	public class IChargingDevice : IProgressBarControl
	{
		// Token: 0x06000A08 RID: 2568 RVA: 0x0002A8C8 File Offset: 0x00028AC8
		private IChargingDevice_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChargingDevice 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChargingDevice_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChargingDevice_SetValue());
			}
			return result;
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x0002A900 File Offset: 0x00028B00
		public static IChargingDevice Create([Nullable(2)] IChargingDevice instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChargingDevice
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x0002A913 File Offset: 0x00028B13
		public static IChargingDevice CreateFromSetValue([Nullable(2)] IChargingDevice_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChargingDevice
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x0002A928 File Offset: 0x00028B28
		public new IChargingDevice_SetValue ToSetValue()
		{
			return new IChargingDevice_SetValue
			{
				Type = this.Type,
				MaxValue = this.MaxValue,
				InitValue = this.InitValue,
				ProgressPerformanceAttribute = this.ProgressPerformanceAttribute,
				IncreaseSpeed = this.IncreaseSpeed,
				HitExtraValue = this.HitExtraValue
			};
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x0002A982 File Offset: 0x00028B82
		// (set) Token: 0x06000A0D RID: 2573 RVA: 0x0002A9AD File Offset: 0x00028BAD
		public override EProgressBarControlType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EProgressBarControlType.CaptureStrategicPoint;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x0002A9BB File Offset: 0x00028BBB
		// (set) Token: 0x06000A0F RID: 2575 RVA: 0x0002A9E6 File Offset: 0x00028BE6
		public override int MaxValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxValue;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MaxValue;
			}
			set
			{
				this.GetOrCreatePoco().MaxValue = value;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x0002A9F4 File Offset: 0x00028BF4
		// (set) Token: 0x06000A11 RID: 2577 RVA: 0x0002AA1F File Offset: 0x00028C1F
		public override int InitValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitValue;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.InitValue;
			}
			set
			{
				this.GetOrCreatePoco().InitValue = value;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x0002AA30 File Offset: 0x00028C30
		// (set) Token: 0x06000A13 RID: 2579 RVA: 0x0002AA6A File Offset: 0x00028C6A
		public override int? ProgressPerformanceAttribute
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ProgressPerformanceAttribute;
				}
				IChargingDevice_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ProgressPerformanceAttribute;
			}
			set
			{
				this.GetOrCreatePoco().ProgressPerformanceAttribute = value;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x0002AA78 File Offset: 0x00028C78
		// (set) Token: 0x06000A15 RID: 2581 RVA: 0x0002AAA3 File Offset: 0x00028CA3
		public virtual int IncreaseSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IncreaseSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.IncreaseSpeed;
			}
			set
			{
				this.GetOrCreatePoco().IncreaseSpeed = value;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x0002AAB1 File Offset: 0x00028CB1
		// (set) Token: 0x06000A17 RID: 2583 RVA: 0x0002AADC File Offset: 0x00028CDC
		public virtual int HitExtraValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HitExtraValue;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.HitExtraValue;
			}
			set
			{
				this.GetOrCreatePoco().HitExtraValue = value;
			}
		}

		// Token: 0x04000A2D RID: 2605
		[Nullable(2)]
		protected new IChargingDevice FbInstance;

		// Token: 0x04000A2E RID: 2606
		[Nullable(2)]
		protected new IChargingDevice_SetValue PocoInterface;
	}
}
