using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029BF RID: 10687
	public class IExitVehicleSeatStandUp : IExitVehicleType
	{
		// Token: 0x0600EC50 RID: 60496 RVA: 0x002283CF File Offset: 0x002265CF
		[NullableContext(1)]
		public static IExitVehicleSeatStandUp Create(IExitVehicleSeatStandUp? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExitVehicleSeatStandUp
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A94 RID: 19092
		// (get) Token: 0x0600EC51 RID: 60497 RVA: 0x002283EE File Offset: 0x002265EE
		public override EExitVehicleType Type
		{
			get
			{
				return (EExitVehicleType)this.Instance.Type;
			}
		}

		// Token: 0x0400821B RID: 33307
		private IExitVehicleSeatStandUp Instance;
	}
}
