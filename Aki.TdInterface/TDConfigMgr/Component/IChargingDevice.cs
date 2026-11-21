using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200025E RID: 606
	public class IChargingDevice : IProgressBarControl
	{
		// Token: 0x06000A7C RID: 2684 RVA: 0x0002C088 File Offset: 0x0002A288
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

		// Token: 0x06000A7D RID: 2685 RVA: 0x0002C0C0 File Offset: 0x0002A2C0
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

		// Token: 0x06000A7E RID: 2686 RVA: 0x0002C0D3 File Offset: 0x0002A2D3
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

		// Token: 0x06000A7F RID: 2687 RVA: 0x0002C0E8 File Offset: 0x0002A2E8
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

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x0002C142 File Offset: 0x0002A342
		// (set) Token: 0x06000A81 RID: 2689 RVA: 0x0002C16D File Offset: 0x0002A36D
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

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x0002C17B File Offset: 0x0002A37B
		// (set) Token: 0x06000A83 RID: 2691 RVA: 0x0002C1A6 File Offset: 0x0002A3A6
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

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x0002C1B4 File Offset: 0x0002A3B4
		// (set) Token: 0x06000A85 RID: 2693 RVA: 0x0002C1DF File Offset: 0x0002A3DF
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

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x0002C1F0 File Offset: 0x0002A3F0
		// (set) Token: 0x06000A87 RID: 2695 RVA: 0x0002C22A File Offset: 0x0002A42A
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

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x0002C238 File Offset: 0x0002A438
		// (set) Token: 0x06000A89 RID: 2697 RVA: 0x0002C263 File Offset: 0x0002A463
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

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x0002C271 File Offset: 0x0002A471
		// (set) Token: 0x06000A8B RID: 2699 RVA: 0x0002C29C File Offset: 0x0002A49C
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

		// Token: 0x04000AB7 RID: 2743
		[Nullable(2)]
		protected new IChargingDevice FbInstance;

		// Token: 0x04000AB8 RID: 2744
		[Nullable(2)]
		protected new IChargingDevice_SetValue PocoInterface;
	}
}
