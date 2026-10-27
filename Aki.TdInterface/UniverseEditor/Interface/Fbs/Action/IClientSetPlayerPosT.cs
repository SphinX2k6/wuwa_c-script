using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063EC RID: 25580
	public class IClientSetPlayerPosT
	{
		// Token: 0x1700BE88 RID: 48776
		// (get) Token: 0x0602C417 RID: 181271 RVA: 0x00613131 File Offset: 0x00611331
		// (set) Token: 0x0602C418 RID: 181272 RVA: 0x00613139 File Offset: 0x00611339
		public TClientTeleportConfigUnion TelePortConfig { get; set; }

		// Token: 0x0602C419 RID: 181273 RVA: 0x00613142 File Offset: 0x00611342
		public IClientSetPlayerPosT()
		{
			this.TelePortConfig = null;
		}
	}
}
