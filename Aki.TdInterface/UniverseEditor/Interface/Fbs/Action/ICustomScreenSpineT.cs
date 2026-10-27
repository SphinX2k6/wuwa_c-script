using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200650B RID: 25867
	public class ICustomScreenSpineT
	{
		// Token: 0x1700C05A RID: 49242
		// (get) Token: 0x0602CDF1 RID: 183793 RVA: 0x00629D10 File Offset: 0x00627F10
		// (set) Token: 0x0602CDF2 RID: 183794 RVA: 0x00629D18 File Offset: 0x00627F18
		public ECustomScreenType Type { get; set; }

		// Token: 0x1700C05B RID: 49243
		// (get) Token: 0x0602CDF3 RID: 183795 RVA: 0x00629D21 File Offset: 0x00627F21
		// (set) Token: 0x0602CDF4 RID: 183796 RVA: 0x00629D29 File Offset: 0x00627F29
		public int SpineId { get; set; }

		// Token: 0x0602CDF5 RID: 183797 RVA: 0x00629D32 File Offset: 0x00627F32
		public ICustomScreenSpineT()
		{
			this.Type = ECustomScreenType.Spine;
			this.SpineId = 0;
		}
	}
}
