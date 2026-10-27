using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029BB RID: 10683
	public class IExitVehicleType
	{
		// Token: 0x0600EC42 RID: 60482 RVA: 0x00228297 File Offset: 0x00226497
		[NullableContext(1)]
		public static IExitVehicleType Create(IExitVehicleType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExitVehicleType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A8E RID: 19086
		// (get) Token: 0x0600EC43 RID: 60483 RVA: 0x002282B6 File Offset: 0x002264B6
		public virtual EExitVehicleType Type
		{
			get
			{
				return (EExitVehicleType)this.Instance.Type;
			}
		}

		// Token: 0x04008213 RID: 33299
		private IExitVehicleType Instance;
	}
}
