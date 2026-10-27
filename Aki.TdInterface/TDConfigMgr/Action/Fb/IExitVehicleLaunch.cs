using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029BC RID: 10684
	public class IExitVehicleLaunch : IExitVehicleType
	{
		// Token: 0x0600EC45 RID: 60485 RVA: 0x002282CB File Offset: 0x002264CB
		[NullableContext(1)]
		public static IExitVehicleLaunch Create(IExitVehicleLaunch? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExitVehicleLaunch
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A8F RID: 19087
		// (get) Token: 0x0600EC46 RID: 60486 RVA: 0x002282EA File Offset: 0x002264EA
		public override EExitVehicleType Type
		{
			get
			{
				return (EExitVehicleType)this.Instance.Type;
			}
		}

		// Token: 0x04008214 RID: 33300
		private IExitVehicleLaunch Instance;
	}
}
