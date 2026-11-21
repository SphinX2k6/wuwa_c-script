using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CB0 RID: 11440
	public class ICurrentVehicle : ITargetVehicle
	{
		// Token: 0x0600FAF5 RID: 64245 RVA: 0x00245EAC File Offset: 0x002440AC
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

		// Token: 0x17004E43 RID: 20035
		// (get) Token: 0x0600FAF6 RID: 64246 RVA: 0x00245ECB File Offset: 0x002440CB
		public override ETargetVehicle Type
		{
			get
			{
				return (ETargetVehicle)this.Instance.Type;
			}
		}

		// Token: 0x04008914 RID: 35092
		private ICurrentVehicle Instance;
	}
}
