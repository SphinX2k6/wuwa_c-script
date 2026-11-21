using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005767 RID: 22375
	public class IExploreSkillQuantumDiffusionT
	{
		// Token: 0x1700A1C3 RID: 41411
		// (get) Token: 0x0602414E RID: 147790 RVA: 0x004F680F File Offset: 0x004F4A0F
		// (set) Token: 0x0602414F RID: 147791 RVA: 0x004F6817 File Offset: 0x004F4A17
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x1700A1C4 RID: 41412
		// (get) Token: 0x06024150 RID: 147792 RVA: 0x004F6820 File Offset: 0x004F4A20
		// (set) Token: 0x06024151 RID: 147793 RVA: 0x004F6828 File Offset: 0x004F4A28
		public bool NeedFollowShooter { get; set; }

		// Token: 0x1700A1C5 RID: 41413
		// (get) Token: 0x06024152 RID: 147794 RVA: 0x004F6831 File Offset: 0x004F4A31
		// (set) Token: 0x06024153 RID: 147795 RVA: 0x004F6839 File Offset: 0x004F4A39
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700A1C6 RID: 41414
		// (get) Token: 0x06024154 RID: 147796 RVA: 0x004F6842 File Offset: 0x004F4A42
		// (set) Token: 0x06024155 RID: 147797 RVA: 0x004F684A File Offset: 0x004F4A4A
		public byte NullMask { get; set; }

		// Token: 0x06024156 RID: 147798 RVA: 0x004F6853 File Offset: 0x004F4A53
		public IExploreSkillQuantumDiffusionT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
			this.NeedFollowShooter = false;
			this.Actions = null;
			this.NullMask = 0;
		}
	}
}
