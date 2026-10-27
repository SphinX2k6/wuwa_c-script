using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B0D RID: 27405
	public class IMotorBounceT
	{
		// Token: 0x1700CB82 RID: 52098
		// (get) Token: 0x0603012A RID: 196906 RVA: 0x00688FD7 File Offset: 0x006871D7
		// (set) Token: 0x0603012B RID: 196907 RVA: 0x00688FDF File Offset: 0x006871DF
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700CB83 RID: 52099
		// (get) Token: 0x0603012C RID: 196908 RVA: 0x00688FE8 File Offset: 0x006871E8
		// (set) Token: 0x0603012D RID: 196909 RVA: 0x00688FF0 File Offset: 0x006871F0
		public int Height { get; set; }

		// Token: 0x1700CB84 RID: 52100
		// (get) Token: 0x0603012E RID: 196910 RVA: 0x00688FF9 File Offset: 0x006871F9
		// (set) Token: 0x0603012F RID: 196911 RVA: 0x00689001 File Offset: 0x00687201
		public float Time { get; set; }

		// Token: 0x1700CB85 RID: 52101
		// (get) Token: 0x06030130 RID: 196912 RVA: 0x0068900A File Offset: 0x0068720A
		// (set) Token: 0x06030131 RID: 196913 RVA: 0x00689012 File Offset: 0x00687212
		public string MotionCurve { get; set; }

		// Token: 0x1700CB86 RID: 52102
		// (get) Token: 0x06030132 RID: 196914 RVA: 0x0068901B File Offset: 0x0068721B
		// (set) Token: 0x06030133 RID: 196915 RVA: 0x00689023 File Offset: 0x00687223
		public EMotorBounceSkillType SkillType { get; set; }

		// Token: 0x1700CB87 RID: 52103
		// (get) Token: 0x06030134 RID: 196916 RVA: 0x0068902C File Offset: 0x0068722C
		// (set) Token: 0x06030135 RID: 196917 RVA: 0x00689034 File Offset: 0x00687234
		public byte NullMask { get; set; }

		// Token: 0x06030136 RID: 196918 RVA: 0x0068903D File Offset: 0x0068723D
		public IMotorBounceT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.Height = 0;
			this.Time = 0f;
			this.MotionCurve = null;
			this.SkillType = EMotorBounceSkillType.None;
			this.NullMask = 0;
		}
	}
}
