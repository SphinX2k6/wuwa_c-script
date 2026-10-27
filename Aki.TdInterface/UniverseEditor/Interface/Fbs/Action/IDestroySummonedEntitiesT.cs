using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065A1 RID: 26017
	public class IDestroySummonedEntitiesT
	{
		// Token: 0x1700C136 RID: 49462
		// (get) Token: 0x0602D221 RID: 184865 RVA: 0x00630A51 File Offset: 0x0062EC51
		// (set) Token: 0x0602D222 RID: 184866 RVA: 0x00630A59 File Offset: 0x0062EC59
		public IDestroySummonedVehicleT DestroyEntitiesConfig { get; set; }

		// Token: 0x0602D223 RID: 184867 RVA: 0x00630A62 File Offset: 0x0062EC62
		public IDestroySummonedEntitiesT()
		{
			this.DestroyEntitiesConfig = null;
		}
	}
}
