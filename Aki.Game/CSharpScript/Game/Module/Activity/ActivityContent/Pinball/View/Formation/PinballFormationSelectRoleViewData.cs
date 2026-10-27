using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Formation
{
	// Token: 0x02006363 RID: 25443
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballFormationSelectRoleViewData : IPinballFormationSelectRoleViewData
	{
		// Token: 0x17009332 RID: 37682
		// (get) Token: 0x0604002D RID: 262189 RVA: 0x00F7C4C7 File Offset: 0x00F7A6C7
		// (set) Token: 0x0604002E RID: 262190 RVA: 0x00F7C4CF File Offset: 0x00F7A6CF
		public List<int> RoleList { get; set; } = new List<int>();

		// Token: 0x17009333 RID: 37683
		// (get) Token: 0x0604002F RID: 262191 RVA: 0x00F7C4D8 File Offset: 0x00F7A6D8
		// (set) Token: 0x06040030 RID: 262192 RVA: 0x00F7C4E0 File Offset: 0x00F7A6E0
		public List<int> RecommendRoleList { get; set; } = new List<int>();

		// Token: 0x17009334 RID: 37684
		// (get) Token: 0x06040031 RID: 262193 RVA: 0x00F7C4E9 File Offset: 0x00F7A6E9
		// (set) Token: 0x06040032 RID: 262194 RVA: 0x00F7C4F1 File Offset: 0x00F7A6F1
		public Action<List<int>> OnConfirm { get; set; }

		// Token: 0x17009335 RID: 37685
		// (get) Token: 0x06040033 RID: 262195 RVA: 0x00F7C4FA File Offset: 0x00F7A6FA
		// (set) Token: 0x06040034 RID: 262196 RVA: 0x00F7C502 File Offset: 0x00F7A702
		public int? OpenRole { get; set; }
	}
}
