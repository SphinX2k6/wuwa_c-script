using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02006266 RID: 25190
	public interface IRealmBetweenLevelData
	{
		// Token: 0x17009261 RID: 37473
		// (get) Token: 0x0603F713 RID: 259859
		// (set) Token: 0x0603F714 RID: 259860
		int Id { get; set; }

		// Token: 0x17009262 RID: 37474
		// (get) Token: 0x0603F715 RID: 259861
		// (set) Token: 0x0603F716 RID: 259862
		int Level { get; set; }

		// Token: 0x17009263 RID: 37475
		// (get) Token: 0x0603F717 RID: 259863
		// (set) Token: 0x0603F718 RID: 259864
		int AccumulateExp { get; set; }

		// Token: 0x17009264 RID: 37476
		// (get) Token: 0x0603F719 RID: 259865
		// (set) Token: 0x0603F71A RID: 259866
		int TargetExp { get; set; }
	}
}
