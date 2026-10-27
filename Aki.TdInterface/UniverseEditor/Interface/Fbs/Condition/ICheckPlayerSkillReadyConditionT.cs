using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B00 RID: 19200
	public class ICheckPlayerSkillReadyConditionT
	{
		// Token: 0x17008B44 RID: 35652
		// (get) Token: 0x0601E304 RID: 123652 RVA: 0x0043BC8F File Offset: 0x00439E8F
		// (set) Token: 0x0601E305 RID: 123653 RVA: 0x0043BC97 File Offset: 0x00439E97
		public ECondition Type { get; set; }

		// Token: 0x17008B45 RID: 35653
		// (get) Token: 0x0601E306 RID: 123654 RVA: 0x0043BCA0 File Offset: 0x00439EA0
		// (set) Token: 0x0601E307 RID: 123655 RVA: 0x0043BCA8 File Offset: 0x00439EA8
		public TSkillReadyOptionUnion SkillOption { get; set; }

		// Token: 0x0601E308 RID: 123656 RVA: 0x0043BCB1 File Offset: 0x00439EB1
		public ICheckPlayerSkillReadyConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.SkillOption = null;
		}
	}
}
