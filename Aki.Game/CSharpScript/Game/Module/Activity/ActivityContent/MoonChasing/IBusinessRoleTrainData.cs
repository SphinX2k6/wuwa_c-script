using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x020053FB RID: 21499
	public interface IBusinessRoleTrainData
	{
		// Token: 0x17006811 RID: 26641
		// (get) Token: 0x060356FF RID: 218879
		// (set) Token: 0x06035700 RID: 218880
		bool IsMoreSuccessful { get; set; }

		// Token: 0x17006812 RID: 26642
		// (get) Token: 0x06035701 RID: 218881
		// (set) Token: 0x06035702 RID: 218882
		int TrainType { get; set; }

		// Token: 0x17006813 RID: 26643
		// (get) Token: 0x06035703 RID: 218883
		// (set) Token: 0x06035704 RID: 218884
		int LastLevel { get; set; }
	}
}
