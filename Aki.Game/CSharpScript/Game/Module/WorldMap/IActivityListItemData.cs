using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036CD RID: 14029
	[NullableContext(1)]
	public interface IActivityListItemData
	{
		// Token: 0x17004AAA RID: 19114
		// (get) Token: 0x060246CC RID: 149196
		// (set) Token: 0x060246CD RID: 149197
		EMapPeriodicActivityId Id { get; set; }

		// Token: 0x17004AAB RID: 19115
		// (get) Token: 0x060246CE RID: 149198
		// (set) Token: 0x060246CF RID: 149199
		double LeftTime { get; set; }

		// Token: 0x17004AAC RID: 19116
		// (get) Token: 0x060246D0 RID: 149200
		// (set) Token: 0x060246D1 RID: 149201
		string LeftTimeText { get; set; }

		// Token: 0x17004AAD RID: 19117
		// (get) Token: 0x060246D2 RID: 149202
		// (set) Token: 0x060246D3 RID: 149203
		int CurrentNum { get; set; }

		// Token: 0x17004AAE RID: 19118
		// (get) Token: 0x060246D4 RID: 149204
		// (set) Token: 0x060246D5 RID: 149205
		int TotalNum { get; set; }

		// Token: 0x17004AAF RID: 19119
		// (get) Token: 0x060246D6 RID: 149206
		// (set) Token: 0x060246D7 RID: 149207
		bool IsFinish { get; set; }

		// Token: 0x17004AB0 RID: 19120
		// (get) Token: 0x060246D8 RID: 149208
		// (set) Token: 0x060246D9 RID: 149209
		bool RedPoint { get; set; }

		// Token: 0x17004AB1 RID: 19121
		// (get) Token: 0x060246DA RID: 149210
		// (set) Token: 0x060246DB RID: 149211
		Action OnClickCb { get; set; }

		// Token: 0x17004AB2 RID: 19122
		// (get) Token: 0x060246DC RID: 149212
		// (set) Token: 0x060246DD RID: 149213
		Action<IActivityListItemData> OnLeftTimeRefreshCb { get; set; }
	}
}
