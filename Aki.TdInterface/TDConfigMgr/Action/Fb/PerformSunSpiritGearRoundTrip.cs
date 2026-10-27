using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AB5 RID: 10933
	public class PerformSunSpiritGearRoundTrip : ActionParams
	{
		// Token: 0x0600EFF8 RID: 61432 RVA: 0x0022DD4C File Offset: 0x0022BF4C
		[NullableContext(1)]
		public static PerformSunSpiritGearRoundTrip Create(IPerformSunSpiritGearRoundTrip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PerformSunSpiritGearRoundTrip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C50 RID: 19536
		// (get) Token: 0x0600EFF9 RID: 61433 RVA: 0x0022DD6B File Offset: 0x0022BF6B
		public virtual ESunSpiritGearRoundTripType PerformType
		{
			get
			{
				return (ESunSpiritGearRoundTripType)this.Instance.PerformType;
			}
		}

		// Token: 0x17004C51 RID: 19537
		// (get) Token: 0x0600EFFA RID: 61434 RVA: 0x0022DD78 File Offset: 0x0022BF78
		public virtual int SunSpiritGearId
		{
			get
			{
				return this.Instance.SunSpiritGearId;
			}
		}

		// Token: 0x04008403 RID: 33795
		private IPerformSunSpiritGearRoundTrip Instance;
	}
}
