using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D36 RID: 3382
	public class IVehicleGenerateByVehicleTeamTemplate : IVehicleGenerationType
	{
		// Token: 0x06004D02 RID: 19714 RVA: 0x000C0727 File Offset: 0x000BE927
		public static IVehicleGenerateByVehicleTeamTemplate Create(IVehicleGenerateByVehicleTeamTemplate? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleGenerateByVehicleTeamTemplate
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001691 RID: 5777
		// (get) Token: 0x06004D03 RID: 19715 RVA: 0x000C0746 File Offset: 0x000BE946
		public override EVehicleGenerationType Type
		{
			get
			{
				return (EVehicleGenerationType)this.Instance.Type;
			}
		}

		// Token: 0x17001692 RID: 5778
		// (get) Token: 0x06004D04 RID: 19716 RVA: 0x000C0753 File Offset: 0x000BE953
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17001693 RID: 5779
		// (get) Token: 0x06004D05 RID: 19717 RVA: 0x000C0760 File Offset: 0x000BE960
		public override int Weight
		{
			get
			{
				return this.Instance.Weight;
			}
		}

		// Token: 0x04002BA9 RID: 11177
		private IVehicleGenerateByVehicleTeamTemplate Instance;
	}
}
