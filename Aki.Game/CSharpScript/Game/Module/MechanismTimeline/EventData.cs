using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MechanismTimeline
{
	// Token: 0x02004461 RID: 17505
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class EventData : IEventData
	{
		// Token: 0x1700582E RID: 22574
		// (get) Token: 0x0602C250 RID: 180816 RVA: 0x00C659B9 File Offset: 0x00C63BB9
		// (set) Token: 0x0602C251 RID: 180817 RVA: 0x00C659C1 File Offset: 0x00C63BC1
		[RequiredMember]
		public string EventName { get; set; }

		// Token: 0x1700582F RID: 22575
		// (get) Token: 0x0602C252 RID: 180818 RVA: 0x00C659CA File Offset: 0x00C63BCA
		// (set) Token: 0x0602C253 RID: 180819 RVA: 0x00C659D2 File Offset: 0x00C63BD2
		[RequiredMember]
		public string EventType { get; set; }

		// Token: 0x17005830 RID: 22576
		// (get) Token: 0x0602C254 RID: 180820 RVA: 0x00C659DB File Offset: 0x00C63BDB
		// (set) Token: 0x0602C255 RID: 180821 RVA: 0x00C659E3 File Offset: 0x00C63BE3
		public bool IsAnimNotifyState { get; set; }

		// Token: 0x17005831 RID: 22577
		// (get) Token: 0x0602C256 RID: 180822 RVA: 0x00C659EC File Offset: 0x00C63BEC
		// (set) Token: 0x0602C257 RID: 180823 RVA: 0x00C659F4 File Offset: 0x00C63BF4
		public int StartFrame { get; set; }

		// Token: 0x17005832 RID: 22578
		// (get) Token: 0x0602C258 RID: 180824 RVA: 0x00C659FD File Offset: 0x00C63BFD
		// (set) Token: 0x0602C259 RID: 180825 RVA: 0x00C65A05 File Offset: 0x00C63C05
		public int EndFrame { get; set; }

		// Token: 0x17005833 RID: 22579
		// (get) Token: 0x0602C25A RID: 180826 RVA: 0x00C65A0E File Offset: 0x00C63C0E
		// (set) Token: 0x0602C25B RID: 180827 RVA: 0x00C65A16 File Offset: 0x00C63C16
		public int RowIndex { get; set; }

		// Token: 0x0602C25C RID: 180828 RVA: 0x00C65A1F File Offset: 0x00C63C1F
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public EventData()
		{
		}
	}
}
