using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005761 RID: 22369
	public class IExploreSkillPullGiantT
	{
		// Token: 0x1700A1B4 RID: 41396
		// (get) Token: 0x06024112 RID: 147730 RVA: 0x004F6059 File Offset: 0x004F4259
		// (set) Token: 0x06024113 RID: 147731 RVA: 0x004F6061 File Offset: 0x004F4261
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x1700A1B5 RID: 41397
		// (get) Token: 0x06024114 RID: 147732 RVA: 0x004F606A File Offset: 0x004F426A
		// (set) Token: 0x06024115 RID: 147733 RVA: 0x004F6072 File Offset: 0x004F4272
		public float PullTime { get; set; }

		// Token: 0x1700A1B6 RID: 41398
		// (get) Token: 0x06024116 RID: 147734 RVA: 0x004F607B File Offset: 0x004F427B
		// (set) Token: 0x06024117 RID: 147735 RVA: 0x004F6083 File Offset: 0x004F4283
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x06024118 RID: 147736 RVA: 0x004F608C File Offset: 0x004F428C
		public IExploreSkillPullGiantT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
			this.PullTime = 0f;
			this.Actions = null;
		}
	}
}
