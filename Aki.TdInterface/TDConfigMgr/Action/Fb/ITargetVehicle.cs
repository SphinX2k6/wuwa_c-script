using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029C2 RID: 10690
	public class ITargetVehicle
	{
		// Token: 0x0600EC5B RID: 60507 RVA: 0x002284F4 File Offset: 0x002266F4
		[NullableContext(1)]
		public static ITargetVehicle Create(ITargetVehicle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITargetVehicle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A99 RID: 19097
		// (get) Token: 0x0600EC5C RID: 60508 RVA: 0x00228513 File Offset: 0x00226713
		public virtual ETargetVehicle Type
		{
			get
			{
				return (ETargetVehicle)this.Instance.Type;
			}
		}

		// Token: 0x04008222 RID: 33314
		private ITargetVehicle Instance;
	}
}
