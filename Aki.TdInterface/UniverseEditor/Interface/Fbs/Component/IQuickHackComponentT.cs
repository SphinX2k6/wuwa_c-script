using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DD1 RID: 24017
	public class IQuickHackComponentT
	{
		// Token: 0x1700B0E6 RID: 45286
		// (get) Token: 0x060280C0 RID: 164032 RVA: 0x0057A0E7 File Offset: 0x005782E7
		// (set) Token: 0x060280C1 RID: 164033 RVA: 0x0057A0EF File Offset: 0x005782EF
		public bool Disabled { get; set; }

		// Token: 0x1700B0E7 RID: 45287
		// (get) Token: 0x060280C2 RID: 164034 RVA: 0x0057A0F8 File Offset: 0x005782F8
		// (set) Token: 0x060280C3 RID: 164035 RVA: 0x0057A100 File Offset: 0x00578300
		public float Time { get; set; }

		// Token: 0x1700B0E8 RID: 45288
		// (get) Token: 0x060280C4 RID: 164036 RVA: 0x0057A109 File Offset: 0x00578309
		// (set) Token: 0x060280C5 RID: 164037 RVA: 0x0057A111 File Offset: 0x00578311
		public IVectorInfoT IconOffset { get; set; }

		// Token: 0x1700B0E9 RID: 45289
		// (get) Token: 0x060280C6 RID: 164038 RVA: 0x0057A11A File Offset: 0x0057831A
		// (set) Token: 0x060280C7 RID: 164039 RVA: 0x0057A122 File Offset: 0x00578322
		public List<IQuickHackSkillT> Skills { get; set; }

		// Token: 0x1700B0EA RID: 45290
		// (get) Token: 0x060280C8 RID: 164040 RVA: 0x0057A12B File Offset: 0x0057832B
		// (set) Token: 0x060280C9 RID: 164041 RVA: 0x0057A133 File Offset: 0x00578333
		public EQuickHackAutoCloseType AutoClose { get; set; }

		// Token: 0x1700B0EB RID: 45291
		// (get) Token: 0x060280CA RID: 164042 RVA: 0x0057A13C File Offset: 0x0057833C
		// (set) Token: 0x060280CB RID: 164043 RVA: 0x0057A144 File Offset: 0x00578344
		public IQuickHackLinkEffectT LinkEffect { get; set; }

		// Token: 0x1700B0EC RID: 45292
		// (get) Token: 0x060280CC RID: 164044 RVA: 0x0057A14D File Offset: 0x0057834D
		// (set) Token: 0x060280CD RID: 164045 RVA: 0x0057A155 File Offset: 0x00578355
		public byte NullMask { get; set; }

		// Token: 0x060280CE RID: 164046 RVA: 0x0057A15E File Offset: 0x0057835E
		public IQuickHackComponentT()
		{
			this.Disabled = false;
			this.Time = 0f;
			this.IconOffset = null;
			this.Skills = null;
			this.AutoClose = EQuickHackAutoCloseType.OnSkillSelected;
			this.LinkEffect = null;
			this.NullMask = 0;
		}
	}
}
