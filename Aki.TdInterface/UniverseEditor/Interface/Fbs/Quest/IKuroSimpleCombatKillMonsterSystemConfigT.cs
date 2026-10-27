using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003ED0 RID: 16080
	public class IKuroSimpleCombatKillMonsterSystemConfigT
	{
		// Token: 0x17006FA6 RID: 28582
		// (get) Token: 0x06016BEB RID: 93163 RVA: 0x003489CE File Offset: 0x00346BCE
		// (set) Token: 0x06016BEC RID: 93164 RVA: 0x003489D6 File Offset: 0x00346BD6
		public EEnableSystemType Type { get; set; }

		// Token: 0x06016BED RID: 93165 RVA: 0x003489DF File Offset: 0x00346BDF
		public IKuroSimpleCombatKillMonsterSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
		}
	}
}
