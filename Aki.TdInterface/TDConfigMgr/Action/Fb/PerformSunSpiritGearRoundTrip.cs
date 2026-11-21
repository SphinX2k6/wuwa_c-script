using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DA9 RID: 11689
	public class PerformSunSpiritGearRoundTrip : ActionParams
	{
		// Token: 0x0600FEAE RID: 65198 RVA: 0x0024BA58 File Offset: 0x00249C58
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

		// Token: 0x1700500A RID: 20490
		// (get) Token: 0x0600FEAF RID: 65199 RVA: 0x0024BA77 File Offset: 0x00249C77
		public virtual ESunSpiritGearRoundTripType PerformType
		{
			get
			{
				return (ESunSpiritGearRoundTripType)this.Instance.PerformType;
			}
		}

		// Token: 0x1700500B RID: 20491
		// (get) Token: 0x0600FEB0 RID: 65200 RVA: 0x0024BA84 File Offset: 0x00249C84
		public virtual int SunSpiritGearId
		{
			get
			{
				return this.Instance.SunSpiritGearId;
			}
		}

		// Token: 0x04008B07 RID: 35591
		private IPerformSunSpiritGearRoundTrip Instance;
	}
}
