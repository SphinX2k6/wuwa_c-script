using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CC1 RID: 11457
	public class IVehicleCruisingParams
	{
		// Token: 0x0600FB37 RID: 64311 RVA: 0x002465C5 File Offset: 0x002447C5
		public static IVehicleCruisingParams Create(IVehicleCruisingParams? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleCruisingParams
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E63 RID: 20067
		// (get) Token: 0x0600FB38 RID: 64312 RVA: 0x002465E4 File Offset: 0x002447E4
		public virtual float ForwardSpeed
		{
			get
			{
				return this.Instance.ForwardSpeed;
			}
		}

		// Token: 0x17004E64 RID: 20068
		// (get) Token: 0x0600FB39 RID: 64313 RVA: 0x002465F1 File Offset: 0x002447F1
		public virtual float ForwardAcceleration
		{
			get
			{
				return this.Instance.ForwardAcceleration;
			}
		}

		// Token: 0x17004E65 RID: 20069
		// (get) Token: 0x0600FB3A RID: 64314 RVA: 0x00246600 File Offset: 0x00244800
		public virtual bool? DisableSprint
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableSprint);
			}
		}

		// Token: 0x0400893D RID: 35133
		private IVehicleCruisingParams Instance;
	}
}
