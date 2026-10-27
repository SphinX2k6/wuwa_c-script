using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029BD RID: 10685
	public class IExitVehicleStandUp : IExitVehicleType
	{
		// Token: 0x0600EC48 RID: 60488 RVA: 0x002282FF File Offset: 0x002264FF
		[NullableContext(1)]
		public static IExitVehicleStandUp Create(IExitVehicleStandUp? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExitVehicleStandUp
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A90 RID: 19088
		// (get) Token: 0x0600EC49 RID: 60489 RVA: 0x0022831E File Offset: 0x0022651E
		public override EExitVehicleType Type
		{
			get
			{
				return (EExitVehicleType)this.Instance.Type;
			}
		}

		// Token: 0x04008215 RID: 33301
		private IExitVehicleStandUp Instance;
	}
}
