using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036CE RID: 14030
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityListItemData : IActivityListItemData
	{
		// Token: 0x17004AB3 RID: 19123
		// (get) Token: 0x060246DE RID: 149214 RVA: 0x00A49C2A File Offset: 0x00A47E2A
		// (set) Token: 0x060246DF RID: 149215 RVA: 0x00A49C32 File Offset: 0x00A47E32
		public EMapPeriodicActivityId Id { get; set; }

		// Token: 0x17004AB4 RID: 19124
		// (get) Token: 0x060246E0 RID: 149216 RVA: 0x00A49C3B File Offset: 0x00A47E3B
		// (set) Token: 0x060246E1 RID: 149217 RVA: 0x00A49C43 File Offset: 0x00A47E43
		public double LeftTime { get; set; }

		// Token: 0x17004AB5 RID: 19125
		// (get) Token: 0x060246E2 RID: 149218 RVA: 0x00A49C4C File Offset: 0x00A47E4C
		// (set) Token: 0x060246E3 RID: 149219 RVA: 0x00A49C54 File Offset: 0x00A47E54
		public string LeftTimeText { get; set; }

		// Token: 0x17004AB6 RID: 19126
		// (get) Token: 0x060246E4 RID: 149220 RVA: 0x00A49C5D File Offset: 0x00A47E5D
		// (set) Token: 0x060246E5 RID: 149221 RVA: 0x00A49C65 File Offset: 0x00A47E65
		public int CurrentNum { get; set; }

		// Token: 0x17004AB7 RID: 19127
		// (get) Token: 0x060246E6 RID: 149222 RVA: 0x00A49C6E File Offset: 0x00A47E6E
		// (set) Token: 0x060246E7 RID: 149223 RVA: 0x00A49C76 File Offset: 0x00A47E76
		public int TotalNum { get; set; }

		// Token: 0x17004AB8 RID: 19128
		// (get) Token: 0x060246E8 RID: 149224 RVA: 0x00A49C7F File Offset: 0x00A47E7F
		// (set) Token: 0x060246E9 RID: 149225 RVA: 0x00A49C87 File Offset: 0x00A47E87
		public bool IsFinish { get; set; }

		// Token: 0x17004AB9 RID: 19129
		// (get) Token: 0x060246EA RID: 149226 RVA: 0x00A49C90 File Offset: 0x00A47E90
		// (set) Token: 0x060246EB RID: 149227 RVA: 0x00A49C98 File Offset: 0x00A47E98
		public bool RedPoint { get; set; }

		// Token: 0x17004ABA RID: 19130
		// (get) Token: 0x060246EC RID: 149228 RVA: 0x00A49CA1 File Offset: 0x00A47EA1
		// (set) Token: 0x060246ED RID: 149229 RVA: 0x00A49CA9 File Offset: 0x00A47EA9
		public Action OnClickCb { get; set; }

		// Token: 0x17004ABB RID: 19131
		// (get) Token: 0x060246EE RID: 149230 RVA: 0x00A49CB2 File Offset: 0x00A47EB2
		// (set) Token: 0x060246EF RID: 149231 RVA: 0x00A49CBA File Offset: 0x00A47EBA
		public Action<IActivityListItemData> OnLeftTimeRefreshCb { get; set; }
	}
}
