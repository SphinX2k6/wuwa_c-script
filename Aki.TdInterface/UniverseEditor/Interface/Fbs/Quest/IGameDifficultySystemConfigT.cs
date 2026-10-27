using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E76 RID: 15990
	public class IGameDifficultySystemConfigT
	{
		// Token: 0x17006EE4 RID: 28388
		// (get) Token: 0x06016873 RID: 92275 RVA: 0x003416A2 File Offset: 0x0033F8A2
		// (set) Token: 0x06016874 RID: 92276 RVA: 0x003416AA File Offset: 0x0033F8AA
		public EEnableSystemType Type { get; set; }

		// Token: 0x06016875 RID: 92277 RVA: 0x003416B3 File Offset: 0x0033F8B3
		public IGameDifficultySystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
		}
	}
}
