using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057CA RID: 22474
	public class IQuickHackComponentT
	{
		// Token: 0x1700A7C2 RID: 42946
		// (get) Token: 0x06025BA0 RID: 154528 RVA: 0x00533F5B File Offset: 0x0053215B
		// (set) Token: 0x06025BA1 RID: 154529 RVA: 0x00533F63 File Offset: 0x00532163
		public bool Disabled { get; set; }

		// Token: 0x1700A7C3 RID: 42947
		// (get) Token: 0x06025BA2 RID: 154530 RVA: 0x00533F6C File Offset: 0x0053216C
		// (set) Token: 0x06025BA3 RID: 154531 RVA: 0x00533F74 File Offset: 0x00532174
		public float Time { get; set; }

		// Token: 0x1700A7C4 RID: 42948
		// (get) Token: 0x06025BA4 RID: 154532 RVA: 0x00533F7D File Offset: 0x0053217D
		// (set) Token: 0x06025BA5 RID: 154533 RVA: 0x00533F85 File Offset: 0x00532185
		public IVectorInfoT IconOffset { get; set; }

		// Token: 0x1700A7C5 RID: 42949
		// (get) Token: 0x06025BA6 RID: 154534 RVA: 0x00533F8E File Offset: 0x0053218E
		// (set) Token: 0x06025BA7 RID: 154535 RVA: 0x00533F96 File Offset: 0x00532196
		public List<IQuickHackSkillT> Skills { get; set; }

		// Token: 0x1700A7C6 RID: 42950
		// (get) Token: 0x06025BA8 RID: 154536 RVA: 0x00533F9F File Offset: 0x0053219F
		// (set) Token: 0x06025BA9 RID: 154537 RVA: 0x00533FA7 File Offset: 0x005321A7
		public EQuickHackAutoCloseType AutoClose { get; set; }

		// Token: 0x1700A7C7 RID: 42951
		// (get) Token: 0x06025BAA RID: 154538 RVA: 0x00533FB0 File Offset: 0x005321B0
		// (set) Token: 0x06025BAB RID: 154539 RVA: 0x00533FB8 File Offset: 0x005321B8
		public IQuickHackLinkEffectT LinkEffect { get; set; }

		// Token: 0x1700A7C8 RID: 42952
		// (get) Token: 0x06025BAC RID: 154540 RVA: 0x00533FC1 File Offset: 0x005321C1
		// (set) Token: 0x06025BAD RID: 154541 RVA: 0x00533FC9 File Offset: 0x005321C9
		public byte NullMask { get; set; }

		// Token: 0x06025BAE RID: 154542 RVA: 0x00533FD2 File Offset: 0x005321D2
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
