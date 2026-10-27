using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DE7 RID: 28135
	public class IQiuyuanQinggongExploration3T
	{
		// Token: 0x1700D1B6 RID: 53686
		// (get) Token: 0x06031B21 RID: 203553 RVA: 0x006BAE1A File Offset: 0x006B901A
		// (set) Token: 0x06031B22 RID: 203554 RVA: 0x006BAE22 File Offset: 0x006B9022
		public ELeisureInteract Type { get; set; }

		// Token: 0x06031B23 RID: 203555 RVA: 0x006BAE2B File Offset: 0x006B902B
		public IQiuyuanQinggongExploration3T()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
