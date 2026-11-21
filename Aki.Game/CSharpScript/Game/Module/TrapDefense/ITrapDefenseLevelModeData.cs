using System;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039D3 RID: 14803
	public interface ITrapDefenseLevelModeData<out TLevelData> where TLevelData : TrapDefenseLevelModeDataBase
	{
		// Token: 0x17004DDD RID: 19933
		// (get) Token: 0x06026257 RID: 156247
		// (set) Token: 0x06026258 RID: 156248
		int ActivityId { get; set; }
	}
}
