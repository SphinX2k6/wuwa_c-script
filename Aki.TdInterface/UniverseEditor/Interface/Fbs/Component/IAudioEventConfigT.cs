using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004ED2 RID: 20178
	public class IAudioEventConfigT
	{
		// Token: 0x170090D7 RID: 37079
		// (get) Token: 0x0601FCD3 RID: 130259 RVA: 0x0046D175 File Offset: 0x0046B375
		// (set) Token: 0x0601FCD4 RID: 130260 RVA: 0x0046D17D File Offset: 0x0046B37D
		public string CollectAkEvent { get; set; }

		// Token: 0x0601FCD5 RID: 130261 RVA: 0x0046D186 File Offset: 0x0046B386
		public IAudioEventConfigT()
		{
			this.CollectAkEvent = null;
		}
	}
}
