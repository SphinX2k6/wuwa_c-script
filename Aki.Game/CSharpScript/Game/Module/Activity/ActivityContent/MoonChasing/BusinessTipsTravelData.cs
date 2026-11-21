using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x020053F8 RID: 21496
	[NullableContext(1)]
	[Nullable(0)]
	public class BusinessTipsTravelData : IBusinessTipsTravelData
	{
		// Token: 0x17006806 RID: 26630
		// (get) Token: 0x060356E7 RID: 218855 RVA: 0x00EEC729 File Offset: 0x00EEA929
		// (set) Token: 0x060356E8 RID: 218856 RVA: 0x00EEC731 File Offset: 0x00EEA931
		public List<int> RoleList { get; set; } = new List<int>();

		// Token: 0x17006807 RID: 26631
		// (get) Token: 0x060356E9 RID: 218857 RVA: 0x00EEC73A File Offset: 0x00EEA93A
		// (set) Token: 0x060356EA RID: 218858 RVA: 0x00EEC742 File Offset: 0x00EEA942
		public List<int> LastLevelList { get; set; } = new List<int>();

		// Token: 0x17006808 RID: 26632
		// (get) Token: 0x060356EB RID: 218859 RVA: 0x00EEC74B File Offset: 0x00EEA94B
		// (set) Token: 0x060356EC RID: 218860 RVA: 0x00EEC753 File Offset: 0x00EEA953
		public int DelegateId { get; set; }
	}
}
