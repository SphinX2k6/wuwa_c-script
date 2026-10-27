using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029C4 RID: 10692
	public class ISelfVehicle : ITargetVehicle
	{
		// Token: 0x0600EC61 RID: 60513 RVA: 0x0022855C File Offset: 0x0022675C
		[NullableContext(1)]
		public static ISelfVehicle Create(ISelfVehicle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISelfVehicle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A9B RID: 19099
		// (get) Token: 0x0600EC62 RID: 60514 RVA: 0x0022857B File Offset: 0x0022677B
		public override ETargetVehicle Type
		{
			get
			{
				return (ETargetVehicle)this.Instance.Type;
			}
		}

		// Token: 0x04008224 RID: 33316
		private ISelfVehicle Instance;
	}
}
