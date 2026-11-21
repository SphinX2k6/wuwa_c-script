using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C09 RID: 27657
	public class IDestroySummonedEntitiesT
	{
		// Token: 0x1700CAC5 RID: 51909
		// (get) Token: 0x0602F9A5 RID: 194981 RVA: 0x0067CC15 File Offset: 0x0067AE15
		// (set) Token: 0x0602F9A6 RID: 194982 RVA: 0x0067CC1D File Offset: 0x0067AE1D
		public IDestroySummonedVehicleT DestroyEntitiesConfig { get; set; }

		// Token: 0x0602F9A7 RID: 194983 RVA: 0x0067CC26 File Offset: 0x0067AE26
		public IDestroySummonedEntitiesT()
		{
			this.DestroyEntitiesConfig = null;
		}
	}
}
