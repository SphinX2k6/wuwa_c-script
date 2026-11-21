using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CB4 RID: 11444
	public class IFishingBoatVehicle : ITargetVehicle
	{
		// Token: 0x0600FB02 RID: 64258 RVA: 0x00245F89 File Offset: 0x00244189
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

		// Token: 0x17004E48 RID: 20040
		// (get) Token: 0x0600FB03 RID: 64259 RVA: 0x00245FA8 File Offset: 0x002441A8
		public override ETargetVehicle Type
		{
			get
			{
				return (ETargetVehicle)this.Instance.Type;
			}
		}

		// Token: 0x04008918 RID: 35096
		private IFishingBoatVehicle Instance;
	}
}
