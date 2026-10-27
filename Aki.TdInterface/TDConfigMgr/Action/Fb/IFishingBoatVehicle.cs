using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029C7 RID: 10695
	public class IFishingBoatVehicle : ITargetVehicle
	{
		// Token: 0x0600EC6B RID: 60523 RVA: 0x00228605 File Offset: 0x00226805
		[NullableContext(1)]
		public static IFishingBoatVehicle Create(IFishingBoatVehicle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFishingBoatVehicle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A9F RID: 19103
		// (get) Token: 0x0600EC6C RID: 60524 RVA: 0x00228624 File Offset: 0x00226824
		public override ETargetVehicle Type
		{
			get
			{
				return (ETargetVehicle)this.Instance.Type;
			}
		}

		// Token: 0x04008227 RID: 33319
		private IFishingBoatVehicle Instance;
	}
}
