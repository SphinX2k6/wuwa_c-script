using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029C3 RID: 10691
	public class ICurrentVehicle : ITargetVehicle
	{
		// Token: 0x0600EC5E RID: 60510 RVA: 0x00228528 File Offset: 0x00226728
		[NullableContext(1)]
		public static ICurrentVehicle Create(ICurrentVehicle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICurrentVehicle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A9A RID: 19098
		// (get) Token: 0x0600EC5F RID: 60511 RVA: 0x00228547 File Offset: 0x00226747
		public override ETargetVehicle Type
		{
			get
			{
				return (ETargetVehicle)this.Instance.Type;
			}
		}

		// Token: 0x04008223 RID: 33315
		private ICurrentVehicle Instance;
	}
}
