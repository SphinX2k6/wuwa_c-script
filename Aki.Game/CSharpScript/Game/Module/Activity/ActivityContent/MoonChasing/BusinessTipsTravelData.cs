using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x0200647A RID: 25722
	[NullableContext(1)]
	[Nullable(0)]
	public class BusinessTipsTravelData : IBusinessTipsTravelData
	{
		// Token: 0x170094A4 RID: 38052
		// (get) Token: 0x06040A23 RID: 264739 RVA: 0x00FA56E1 File Offset: 0x00FA38E1
		// (set) Token: 0x06040A24 RID: 264740 RVA: 0x00FA56E9 File Offset: 0x00FA38E9
		public List<int> RoleList { get; set; } = new List<int>();

		// Token: 0x170094A5 RID: 38053
		// (get) Token: 0x06040A25 RID: 264741 RVA: 0x00FA56F2 File Offset: 0x00FA38F2
		// (set) Token: 0x06040A26 RID: 264742 RVA: 0x00FA56FA File Offset: 0x00FA38FA
		public List<int> LastLevelList { get; set; } = new List<int>();

		// Token: 0x170094A6 RID: 38054
		// (get) Token: 0x06040A27 RID: 264743 RVA: 0x00FA5703 File Offset: 0x00FA3903
		// (set) Token: 0x06040A28 RID: 264744 RVA: 0x00FA570B File Offset: 0x00FA390B
		public int DelegateId { get; set; }
	}
}
