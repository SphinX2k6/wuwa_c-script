using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200625E RID: 25182
	public class IBvbSendAiEventT
	{
		// Token: 0x1700BBAF RID: 48047
		// (get) Token: 0x0602B724 RID: 177956 RVA: 0x005FB169 File Offset: 0x005F9369
		// (set) Token: 0x0602B725 RID: 177957 RVA: 0x005FB171 File Offset: 0x005F9371
		public TBvbEventDataUnion EventData { get; set; }

		// Token: 0x0602B726 RID: 177958 RVA: 0x005FB17A File Offset: 0x005F937A
		public IBvbSendAiEventT()
		{
			this.EventData = null;
		}
	}
}
