using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x0200647D RID: 25725
	public interface IBusinessRoleTrainData
	{
		// Token: 0x170094AF RID: 38063
		// (get) Token: 0x06040A3B RID: 264763
		// (set) Token: 0x06040A3C RID: 264764
		bool IsMoreSuccessful { get; set; }

		// Token: 0x170094B0 RID: 38064
		// (get) Token: 0x06040A3D RID: 264765
		// (set) Token: 0x06040A3E RID: 264766
		int TrainType { get; set; }

		// Token: 0x170094B1 RID: 38065
		// (get) Token: 0x06040A3F RID: 264767
		// (set) Token: 0x06040A40 RID: 264768
		int LastLevel { get; set; }
	}
}
