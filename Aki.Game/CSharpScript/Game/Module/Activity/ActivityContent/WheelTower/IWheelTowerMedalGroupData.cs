using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F4A RID: 24394
	public interface IWheelTowerMedalGroupData
	{
		// Token: 0x17008FBB RID: 36795
		// (get) Token: 0x0603DFA5 RID: 253861
		// (set) Token: 0x0603DFA6 RID: 253862
		int GroupId { get; set; }

		// Token: 0x17008FBC RID: 36796
		// (get) Token: 0x0603DFA7 RID: 253863
		// (set) Token: 0x0603DFA8 RID: 253864
		int SeasonId { get; set; }

		// Token: 0x17008FBD RID: 36797
		// (get) Token: 0x0603DFA9 RID: 253865
		// (set) Token: 0x0603DFAA RID: 253866
		int CycleId { get; set; }

		// Token: 0x17008FBE RID: 36798
		// (get) Token: 0x0603DFAB RID: 253867
		// (set) Token: 0x0603DFAC RID: 253868
		int Progress { get; set; }

		// Token: 0x17008FBF RID: 36799
		// (get) Token: 0x0603DFAD RID: 253869
		// (set) Token: 0x0603DFAE RID: 253870
		long CompleteTime { get; set; }

		// Token: 0x17008FC0 RID: 36800
		// (get) Token: 0x0603DFAF RID: 253871
		// (set) Token: 0x0603DFB0 RID: 253872
		int CurrentMedalId { get; set; }

		// Token: 0x17008FC1 RID: 36801
		// (get) Token: 0x0603DFB1 RID: 253873
		// (set) Token: 0x0603DFB2 RID: 253874
		int NextMedalId { get; set; }

		// Token: 0x17008FC2 RID: 36802
		// (get) Token: 0x0603DFB3 RID: 253875
		// (set) Token: 0x0603DFB4 RID: 253876
		int CurrentTarget { get; set; }

		// Token: 0x17008FC3 RID: 36803
		// (get) Token: 0x0603DFB5 RID: 253877
		// (set) Token: 0x0603DFB6 RID: 253878
		bool IsMaxLevel { get; set; }
	}
}
