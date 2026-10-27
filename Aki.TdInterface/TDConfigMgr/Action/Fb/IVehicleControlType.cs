using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029D3 RID: 10707
	public class IVehicleControlType
	{
		// Token: 0x0600EC9D RID: 60573 RVA: 0x00228C0D File Offset: 0x00226E0D
		[NullableContext(1)]
		public static IVehicleControlType Create(IVehicleControlType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleControlType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AB9 RID: 19129
		// (get) Token: 0x0600EC9E RID: 60574 RVA: 0x00228C2C File Offset: 0x00226E2C
		public virtual EVehicleControlType Type
		{
			get
			{
				return (EVehicleControlType)this.Instance.Type;
			}
		}

		// Token: 0x0400824B RID: 33355
		private IVehicleControlType Instance;
	}
}
