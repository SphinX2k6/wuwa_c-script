using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029B7 RID: 10679
	public class IVehicleEnteringPlayerTarget : IVehicleEnteringTarget
	{
		// Token: 0x0600EC2F RID: 60463 RVA: 0x002280A6 File Offset: 0x002262A6
		[NullableContext(1)]
		public static IVehicleEnteringPlayerTarget Create(IVehicleEnteringPlayerTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleEnteringPlayerTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A83 RID: 19075
		// (get) Token: 0x0600EC30 RID: 60464 RVA: 0x002280C5 File Offset: 0x002262C5
		public override EVehicleEnteringTarget Type
		{
			get
			{
				return (EVehicleEnteringTarget)this.Instance.Type;
			}
		}

		// Token: 0x17004A84 RID: 19076
		// (get) Token: 0x0600EC31 RID: 60465 RVA: 0x002280D4 File Offset: 0x002262D4
		public override int? TargetVehicle
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

		// Token: 0x0400820B RID: 33291
		private IVehicleEnteringPlayerTarget Instance;
	}
}
