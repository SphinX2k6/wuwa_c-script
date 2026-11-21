using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005509 RID: 21769
	public class IClientTriggerComponentT
	{
		// Token: 0x17009B91 RID: 39825
		// (get) Token: 0x0602265F RID: 140895 RVA: 0x004BDA42 File Offset: 0x004BBC42
		// (set) Token: 0x06022660 RID: 140896 RVA: 0x004BDA4A File Offset: 0x004BBC4A
		public bool Disabled { get; set; }

		// Token: 0x17009B92 RID: 39826
		// (get) Token: 0x06022661 RID: 140897 RVA: 0x004BDA53 File Offset: 0x004BBC53
		// (set) Token: 0x06022662 RID: 140898 RVA: 0x004BDA5B File Offset: 0x004BBC5B
		public ITriggerMatchConfigT TriggerMatch { get; set; }

		// Token: 0x17009B93 RID: 39827
		// (get) Token: 0x06022663 RID: 140899 RVA: 0x004BDA64 File Offset: 0x004BBC64
		// (set) Token: 0x06022664 RID: 140900 RVA: 0x004BDA6C File Offset: 0x004BBC6C
		public ITriggeredConfigT OnTriggerEnter { get; set; }

		// Token: 0x17009B94 RID: 39828
		// (get) Token: 0x06022665 RID: 140901 RVA: 0x004BDA75 File Offset: 0x004BBC75
		// (set) Token: 0x06022666 RID: 140902 RVA: 0x004BDA7D File Offset: 0x004BBC7D
		public ITriggeredConfigT OnTriggerExit { get; set; }

		// Token: 0x17009B95 RID: 39829
		// (get) Token: 0x06022667 RID: 140903 RVA: 0x004BDA86 File Offset: 0x004BBC86
		// (set) Token: 0x06022668 RID: 140904 RVA: 0x004BDA8E File Offset: 0x004BBC8E
		public byte NullMask { get; set; }

		// Token: 0x06022669 RID: 140905 RVA: 0x004BDA97 File Offset: 0x004BBC97
		public IClientTriggerComponentT()
		{
			this.Disabled = false;
			this.TriggerMatch = null;
			this.OnTriggerEnter = null;
			this.OnTriggerExit = null;
			this.NullMask = 0;
		}
	}
}
