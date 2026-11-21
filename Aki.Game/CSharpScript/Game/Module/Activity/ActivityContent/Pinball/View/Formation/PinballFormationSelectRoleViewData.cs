using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Formation
{
	// Token: 0x020052E1 RID: 21217
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballFormationSelectRoleViewData : IPinballFormationSelectRoleViewData
	{
		// Token: 0x17006694 RID: 26260
		// (get) Token: 0x06034CEE RID: 216302 RVA: 0x00EC3427 File Offset: 0x00EC1627
		// (set) Token: 0x06034CEF RID: 216303 RVA: 0x00EC342F File Offset: 0x00EC162F
		public List<int> RoleList { get; set; } = new List<int>();

		// Token: 0x17006695 RID: 26261
		// (get) Token: 0x06034CF0 RID: 216304 RVA: 0x00EC3438 File Offset: 0x00EC1638
		// (set) Token: 0x06034CF1 RID: 216305 RVA: 0x00EC3440 File Offset: 0x00EC1640
		public List<int> RecommendRoleList { get; set; } = new List<int>();

		// Token: 0x17006696 RID: 26262
		// (get) Token: 0x06034CF2 RID: 216306 RVA: 0x00EC3449 File Offset: 0x00EC1649
		// (set) Token: 0x06034CF3 RID: 216307 RVA: 0x00EC3451 File Offset: 0x00EC1651
		public Action<List<int>> OnConfirm { get; set; }

		// Token: 0x17006697 RID: 26263
		// (get) Token: 0x06034CF4 RID: 216308 RVA: 0x00EC345A File Offset: 0x00EC165A
		// (set) Token: 0x06034CF5 RID: 216309 RVA: 0x00EC3462 File Offset: 0x00EC1662
		public int? OpenRole { get; set; }
	}
}
