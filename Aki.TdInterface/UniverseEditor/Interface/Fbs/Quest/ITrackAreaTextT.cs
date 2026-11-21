using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004641 RID: 17985
	public class ITrackAreaTextT
	{
		// Token: 0x17007DDF RID: 32223
		// (get) Token: 0x0601A562 RID: 107874 RVA: 0x003BF94F File Offset: 0x003BDB4F
		// (set) Token: 0x0601A563 RID: 107875 RVA: 0x003BF957 File Offset: 0x003BDB57
		public bool Show { get; set; }

		// Token: 0x17007DE0 RID: 32224
		// (get) Token: 0x0601A564 RID: 107876 RVA: 0x003BF960 File Offset: 0x003BDB60
		// (set) Token: 0x0601A565 RID: 107877 RVA: 0x003BF968 File Offset: 0x003BDB68
		public string Tid { get; set; }

		// Token: 0x0601A566 RID: 107878 RVA: 0x003BF971 File Offset: 0x003BDB71
		public ITrackAreaTextT()
		{
			this.Show = false;
			this.Tid = null;
		}
	}
}
