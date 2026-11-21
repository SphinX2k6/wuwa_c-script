using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200493F RID: 18751
	public class IHitRemainScoreZoneResultT
	{
		// Token: 0x170082A0 RID: 33440
		// (get) Token: 0x0601BD4B RID: 113995 RVA: 0x003EEAEC File Offset: 0x003ECCEC
		// (set) Token: 0x0601BD4C RID: 113996 RVA: 0x003EEAF4 File Offset: 0x003ECCF4
		public EDartSkillResultType Type { get; set; }

		// Token: 0x170082A1 RID: 33441
		// (get) Token: 0x0601BD4D RID: 113997 RVA: 0x003EEAFD File Offset: 0x003ECCFD
		// (set) Token: 0x0601BD4E RID: 113998 RVA: 0x003EEB05 File Offset: 0x003ECD05
		public int Probability { get; set; }

		// Token: 0x0601BD4F RID: 113999 RVA: 0x003EEB0E File Offset: 0x003ECD0E
		public IHitRemainScoreZoneResultT()
		{
			this.Type = EDartSkillResultType.NoBust;
			this.Probability = 0;
		}
	}
}
