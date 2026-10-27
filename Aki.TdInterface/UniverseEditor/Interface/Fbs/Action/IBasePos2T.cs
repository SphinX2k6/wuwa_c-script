using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061E3 RID: 25059
	public class IBasePos2T
	{
		// Token: 0x1700BAD8 RID: 47832
		// (get) Token: 0x0602B31D RID: 176925 RVA: 0x005F3FC6 File Offset: 0x005F21C6
		// (set) Token: 0x0602B31E RID: 176926 RVA: 0x005F3FCE File Offset: 0x005F21CE
		public EPos2 Type { get; set; }

		// Token: 0x0602B31F RID: 176927 RVA: 0x005F3FD7 File Offset: 0x005F21D7
		public IBasePos2T()
		{
			this.Type = EPos2.Player;
		}
	}
}
