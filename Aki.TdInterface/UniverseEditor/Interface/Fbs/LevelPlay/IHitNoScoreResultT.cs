using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004939 RID: 18745
	public class IHitNoScoreResultT
	{
		// Token: 0x17008297 RID: 33431
		// (get) Token: 0x0601BD21 RID: 113953 RVA: 0x003EE712 File Offset: 0x003EC912
		// (set) Token: 0x0601BD22 RID: 113954 RVA: 0x003EE71A File Offset: 0x003EC91A
		public EDartSkillResultType Type { get; set; }

		// Token: 0x0601BD23 RID: 113955 RVA: 0x003EE723 File Offset: 0x003EC923
		public IHitNoScoreResultT()
		{
			this.Type = EDartSkillResultType.NoBust;
		}
	}
}
