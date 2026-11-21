using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002360 RID: 9056
	public class PerformSunSpiritGearRoundTrip : ActionParams
	{
		// Token: 0x0600C560 RID: 50528 RVA: 0x001C4AB8 File Offset: 0x001C2CB8
		private PerformSunSpiritGearRoundTrip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PerformSunSpiritGearRoundTrip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PerformSunSpiritGearRoundTrip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PerformSunSpiritGearRoundTrip_SetValue());
			}
			return result;
		}

		// Token: 0x0600C561 RID: 50529 RVA: 0x001C4AF0 File Offset: 0x001C2CF0
		public static PerformSunSpiritGearRoundTrip Create([Nullable(2)] PerformSunSpiritGearRoundTrip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PerformSunSpiritGearRoundTrip
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C562 RID: 50530 RVA: 0x001C4B03 File Offset: 0x001C2D03
		public static PerformSunSpiritGearRoundTrip CreateFromSetValue([Nullable(2)] PerformSunSpiritGearRoundTrip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PerformSunSpiritGearRoundTrip
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C563 RID: 50531 RVA: 0x001C4B16 File Offset: 0x001C2D16
		public PerformSunSpiritGearRoundTrip_SetValue ToSetValue()
		{
			return new PerformSunSpiritGearRoundTrip_SetValue
			{
				PerformType = this.PerformType,
				SunSpiritGearId = this.SunSpiritGearId
			};
		}

		// Token: 0x17003BB1 RID: 15281
		// (get) Token: 0x0600C564 RID: 50532 RVA: 0x001C4B35 File Offset: 0x001C2D35
		// (set) Token: 0x0600C565 RID: 50533 RVA: 0x001C4B60 File Offset: 0x001C2D60
		public virtual ESunSpiritGearRoundTripType PerformType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PerformType;
				}
				if (this.PocoInterface == null)
				{
					return ESunSpiritGearRoundTripType.FlyToGear;
				}
				return this.PocoInterface.PerformType;
			}
			set
			{
				this.GetOrCreatePoco().PerformType = value;
			}
		}

		// Token: 0x17003BB2 RID: 15282
		// (get) Token: 0x0600C566 RID: 50534 RVA: 0x001C4B6E File Offset: 0x001C2D6E
		// (set) Token: 0x0600C567 RID: 50535 RVA: 0x001C4B99 File Offset: 0x001C2D99
		public virtual int SunSpiritGearId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SunSpiritGearId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SunSpiritGearId;
			}
			set
			{
				this.GetOrCreatePoco().SunSpiritGearId = value;
			}
		}

		// Token: 0x0400757C RID: 30076
		[Nullable(2)]
		protected new PerformSunSpiritGearRoundTrip FbInstance;

		// Token: 0x0400757D RID: 30077
		[Nullable(2)]
		protected PerformSunSpiritGearRoundTrip_SetValue PocoInterface;
	}
}
