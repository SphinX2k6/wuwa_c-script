using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007247 RID: 29255
	public class IMotorCatapultT
	{
		// Token: 0x1700D65C RID: 54876
		// (get) Token: 0x06032F20 RID: 208672 RVA: 0x006E0A67 File Offset: 0x006DEC67
		// (set) Token: 0x06032F21 RID: 208673 RVA: 0x006E0A6F File Offset: 0x006DEC6F
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700D65D RID: 54877
		// (get) Token: 0x06032F22 RID: 208674 RVA: 0x006E0A78 File Offset: 0x006DEC78
		// (set) Token: 0x06032F23 RID: 208675 RVA: 0x006E0A80 File Offset: 0x006DEC80
		public IMotorCatapultParamT Param { get; set; }

		// Token: 0x1700D65E RID: 54878
		// (get) Token: 0x06032F24 RID: 208676 RVA: 0x006E0A89 File Offset: 0x006DEC89
		// (set) Token: 0x06032F25 RID: 208677 RVA: 0x006E0A91 File Offset: 0x006DEC91
		public EMotorCatapultSkillType SkillType { get; set; }

		// Token: 0x1700D65F RID: 54879
		// (get) Token: 0x06032F26 RID: 208678 RVA: 0x006E0A9A File Offset: 0x006DEC9A
		// (set) Token: 0x06032F27 RID: 208679 RVA: 0x006E0AA2 File Offset: 0x006DECA2
		public byte NullMask { get; set; }

		// Token: 0x06032F28 RID: 208680 RVA: 0x006E0AAB File Offset: 0x006DECAB
		public IMotorCatapultT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.Param = null;
			this.SkillType = EMotorCatapultSkillType.None;
			this.NullMask = 0;
		}
	}
}
