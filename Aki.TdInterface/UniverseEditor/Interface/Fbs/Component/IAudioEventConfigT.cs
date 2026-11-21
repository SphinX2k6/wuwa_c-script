using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005401 RID: 21505
	public class IAudioEventConfigT
	{
		// Token: 0x1700984A RID: 38986
		// (get) Token: 0x06021A17 RID: 137751 RVA: 0x004A2F45 File Offset: 0x004A1145
		// (set) Token: 0x06021A18 RID: 137752 RVA: 0x004A2F4D File Offset: 0x004A114D
		public string CollectAkEvent { get; set; }

		// Token: 0x06021A19 RID: 137753 RVA: 0x004A2F56 File Offset: 0x004A1156
		public IAudioEventConfigT()
		{
			this.CollectAkEvent = null;
		}
	}
}
