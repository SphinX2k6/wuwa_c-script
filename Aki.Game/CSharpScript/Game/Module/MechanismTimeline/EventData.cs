using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MechanismTimeline
{
	// Token: 0x0200547E RID: 21630
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class EventData : IEventData
	{
		// Token: 0x17008462 RID: 33890
		// (get) Token: 0x06037307 RID: 226055 RVA: 0x00D16561 File Offset: 0x00D14761
		// (set) Token: 0x06037308 RID: 226056 RVA: 0x00D16569 File Offset: 0x00D14769
		[RequiredMember]
		public string EventName { get; set; }

		// Token: 0x17008463 RID: 33891
		// (get) Token: 0x06037309 RID: 226057 RVA: 0x00D16572 File Offset: 0x00D14772
		// (set) Token: 0x0603730A RID: 226058 RVA: 0x00D1657A File Offset: 0x00D1477A
		[RequiredMember]
		public string EventType { get; set; }

		// Token: 0x17008464 RID: 33892
		// (get) Token: 0x0603730B RID: 226059 RVA: 0x00D16583 File Offset: 0x00D14783
		// (set) Token: 0x0603730C RID: 226060 RVA: 0x00D1658B File Offset: 0x00D1478B
		public bool IsAnimNotifyState { get; set; }

		// Token: 0x17008465 RID: 33893
		// (get) Token: 0x0603730D RID: 226061 RVA: 0x00D16594 File Offset: 0x00D14794
		// (set) Token: 0x0603730E RID: 226062 RVA: 0x00D1659C File Offset: 0x00D1479C
		public int StartFrame { get; set; }

		// Token: 0x17008466 RID: 33894
		// (get) Token: 0x0603730F RID: 226063 RVA: 0x00D165A5 File Offset: 0x00D147A5
		// (set) Token: 0x06037310 RID: 226064 RVA: 0x00D165AD File Offset: 0x00D147AD
		public int EndFrame { get; set; }

		// Token: 0x17008467 RID: 33895
		// (get) Token: 0x06037311 RID: 226065 RVA: 0x00D165B6 File Offset: 0x00D147B6
		// (set) Token: 0x06037312 RID: 226066 RVA: 0x00D165BE File Offset: 0x00D147BE
		public int RowIndex { get; set; }

		// Token: 0x06037313 RID: 226067 RVA: 0x00D165C7 File Offset: 0x00D147C7
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public EventData()
		{
		}
	}
}
