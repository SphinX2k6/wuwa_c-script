using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C95 RID: 19605
	public class IPreGenderCondtionT
	{
		// Token: 0x17008E5A RID: 36442
		// (get) Token: 0x0601F18F RID: 127375 RVA: 0x004585B4 File Offset: 0x004567B4
		// (set) Token: 0x0601F190 RID: 127376 RVA: 0x004585BC File Offset: 0x004567BC
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x17008E5B RID: 36443
		// (get) Token: 0x0601F191 RID: 127377 RVA: 0x004585C5 File Offset: 0x004567C5
		// (set) Token: 0x0601F192 RID: 127378 RVA: 0x004585CD File Offset: 0x004567CD
		public EGender Gender { get; set; }

		// Token: 0x0601F193 RID: 127379 RVA: 0x004585D6 File Offset: 0x004567D6
		public IPreGenderCondtionT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
			this.Gender = EGender.M;
		}
	}
}
