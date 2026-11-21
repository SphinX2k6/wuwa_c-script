using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CE4 RID: 31972
	public class IUsePhantomSkillT
	{
		// Token: 0x1700EF51 RID: 61265
		// (get) Token: 0x06039B02 RID: 236290 RVA: 0x007C86A4 File Offset: 0x007C68A4
		// (set) Token: 0x06039B03 RID: 236291 RVA: 0x007C86AC File Offset: 0x007C68AC
		public EPhantomSkillType SkillType { get; set; }

		// Token: 0x1700EF52 RID: 61266
		// (get) Token: 0x06039B04 RID: 236292 RVA: 0x007C86B5 File Offset: 0x007C68B5
		// (set) Token: 0x06039B05 RID: 236293 RVA: 0x007C86BD File Offset: 0x007C68BD
		public ISkillBlackboardVectorT BlackboardPos { get; set; }

		// Token: 0x1700EF53 RID: 61267
		// (get) Token: 0x06039B06 RID: 236294 RVA: 0x007C86C6 File Offset: 0x007C68C6
		// (set) Token: 0x06039B07 RID: 236295 RVA: 0x007C86CE File Offset: 0x007C68CE
		public ISkillBlackboardVectorT BlackboardRot { get; set; }

		// Token: 0x06039B08 RID: 236296 RVA: 0x007C86D7 File Offset: 0x007C68D7
		public IUsePhantomSkillT()
		{
			this.SkillType = EPhantomSkillType.ChallengeSuccess;
			this.BlackboardPos = null;
			this.BlackboardRot = null;
		}
	}
}
