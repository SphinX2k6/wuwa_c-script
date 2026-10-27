using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074EE RID: 29934
	public class IUsePhantomSkillT
	{
		// Token: 0x1700E327 RID: 58151
		// (get) Token: 0x060366ED RID: 222957 RVA: 0x00765454 File Offset: 0x00763654
		// (set) Token: 0x060366EE RID: 222958 RVA: 0x0076545C File Offset: 0x0076365C
		public EPhantomSkillType SkillType { get; set; }

		// Token: 0x1700E328 RID: 58152
		// (get) Token: 0x060366EF RID: 222959 RVA: 0x00765465 File Offset: 0x00763665
		// (set) Token: 0x060366F0 RID: 222960 RVA: 0x0076546D File Offset: 0x0076366D
		public ISkillBlackboardVectorT BlackboardPos { get; set; }

		// Token: 0x1700E329 RID: 58153
		// (get) Token: 0x060366F1 RID: 222961 RVA: 0x00765476 File Offset: 0x00763676
		// (set) Token: 0x060366F2 RID: 222962 RVA: 0x0076547E File Offset: 0x0076367E
		public ISkillBlackboardVectorT BlackboardRot { get; set; }

		// Token: 0x060366F3 RID: 222963 RVA: 0x00765487 File Offset: 0x00763687
		public IUsePhantomSkillT()
		{
			this.SkillType = EPhantomSkillType.ChallengeSuccess;
			this.BlackboardPos = null;
			this.BlackboardRot = null;
		}
	}
}
