using System;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A2B RID: 18987
	public interface ITrapDefenseLevelModeData<out TLevelData> where TLevelData : TrapDefenseLevelModeDataBase
	{
		// Token: 0x17007A30 RID: 31280
		// (get) Token: 0x060314C7 RID: 201927
		// (set) Token: 0x060314C8 RID: 201928
		int ActivityId { get; set; }
	}
}
