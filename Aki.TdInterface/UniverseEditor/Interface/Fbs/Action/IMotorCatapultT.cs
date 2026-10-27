using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B10 RID: 27408
	public class IMotorCatapultT
	{
		// Token: 0x1700CB8D RID: 52109
		// (get) Token: 0x0603014C RID: 196940 RVA: 0x006893AF File Offset: 0x006875AF
		// (set) Token: 0x0603014D RID: 196941 RVA: 0x006893B7 File Offset: 0x006875B7
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700CB8E RID: 52110
		// (get) Token: 0x0603014E RID: 196942 RVA: 0x006893C0 File Offset: 0x006875C0
		// (set) Token: 0x0603014F RID: 196943 RVA: 0x006893C8 File Offset: 0x006875C8
		public IMotorCatapultParamT Param { get; set; }

		// Token: 0x1700CB8F RID: 52111
		// (get) Token: 0x06030150 RID: 196944 RVA: 0x006893D1 File Offset: 0x006875D1
		// (set) Token: 0x06030151 RID: 196945 RVA: 0x006893D9 File Offset: 0x006875D9
		public EMotorCatapultSkillType SkillType { get; set; }

		// Token: 0x1700CB90 RID: 52112
		// (get) Token: 0x06030152 RID: 196946 RVA: 0x006893E2 File Offset: 0x006875E2
		// (set) Token: 0x06030153 RID: 196947 RVA: 0x006893EA File Offset: 0x006875EA
		public byte NullMask { get; set; }

		// Token: 0x06030154 RID: 196948 RVA: 0x006893F3 File Offset: 0x006875F3
		public IMotorCatapultT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.Param = null;
			this.SkillType = EMotorCatapultSkillType.None;
			this.NullMask = 0;
		}
	}
}
