using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020FF RID: 8447
	[NullableContext(1)]
	[Nullable(0)]
	public class PerformSunSpiritGearRoundTrip : ActionParams
	{
		// Token: 0x0600B9D4 RID: 47572 RVA: 0x001AD958 File Offset: 0x001ABB58
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

		// Token: 0x0600B9D5 RID: 47573 RVA: 0x001AD990 File Offset: 0x001ABB90
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

		// Token: 0x0600B9D6 RID: 47574 RVA: 0x001AD9A3 File Offset: 0x001ABBA3
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

		// Token: 0x0600B9D7 RID: 47575 RVA: 0x001AD9B6 File Offset: 0x001ABBB6
		public PerformSunSpiritGearRoundTrip_SetValue ToSetValue()
		{
			return new PerformSunSpiritGearRoundTrip_SetValue
			{
				PerformType = this.PerformType,
				SunSpiritGearId = this.SunSpiritGearId
			};
		}

		// Token: 0x170038C5 RID: 14533
		// (get) Token: 0x0600B9D8 RID: 47576 RVA: 0x001AD9D5 File Offset: 0x001ABBD5
		// (set) Token: 0x0600B9D9 RID: 47577 RVA: 0x001ADA00 File Offset: 0x001ABC00
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

		// Token: 0x170038C6 RID: 14534
		// (get) Token: 0x0600B9DA RID: 47578 RVA: 0x001ADA0E File Offset: 0x001ABC0E
		// (set) Token: 0x0600B9DB RID: 47579 RVA: 0x001ADA39 File Offset: 0x001ABC39
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

		// Token: 0x04006F48 RID: 28488
		[Nullable(2)]
		protected new PerformSunSpiritGearRoundTrip FbInstance;

		// Token: 0x04006F49 RID: 28489
		[Nullable(2)]
		protected PerformSunSpiritGearRoundTrip_SetValue PocoInterface;
	}
}
