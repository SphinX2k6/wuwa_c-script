using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029B6 RID: 10678
	public class IVehicleEnteringTarget
	{
		// Token: 0x0600EC2B RID: 60459 RVA: 0x0022803B File Offset: 0x0022623B
		[NullableContext(1)]
		public static IVehicleEnteringTarget Create(IVehicleEnteringTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleEnteringTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A81 RID: 19073
		// (get) Token: 0x0600EC2C RID: 60460 RVA: 0x0022805A File Offset: 0x0022625A
		public virtual EVehicleEnteringTarget Type
		{
			get
			{
				return (EVehicleEnteringTarget)this.Instance.Type;
			}
		}

		// Token: 0x17004A82 RID: 19074
		// (get) Token: 0x0600EC2D RID: 60461 RVA: 0x00228068 File Offset: 0x00226268
		public virtual int? TargetVehicle
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.TargetVehicle);
			}
		}

		// Token: 0x0400820A RID: 33290
		private IVehicleEnteringTarget Instance;
	}
}
