using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029D4 RID: 10708
	public class IVehicleCruisingParams
	{
		// Token: 0x0600ECA0 RID: 60576 RVA: 0x00228C41 File Offset: 0x00226E41
		[NullableContext(1)]
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

		// Token: 0x17004ABA RID: 19130
		// (get) Token: 0x0600ECA1 RID: 60577 RVA: 0x00228C60 File Offset: 0x00226E60
		public virtual float ForwardSpeed
		{
			get
			{
				return this.Instance.ForwardSpeed;
			}
		}

		// Token: 0x17004ABB RID: 19131
		// (get) Token: 0x0600ECA2 RID: 60578 RVA: 0x00228C6D File Offset: 0x00226E6D
		public virtual float ForwardAcceleration
		{
			get
			{
				return this.Instance.ForwardAcceleration;
			}
		}

		// Token: 0x17004ABC RID: 19132
		// (get) Token: 0x0600ECA3 RID: 60579 RVA: 0x00228C7C File Offset: 0x00226E7C
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

		// Token: 0x0400824C RID: 33356
		private IVehicleCruisingParams Instance;
	}
}
