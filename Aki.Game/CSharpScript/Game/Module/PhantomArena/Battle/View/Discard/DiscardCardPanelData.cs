using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Discard
{
	// Token: 0x02004236 RID: 16950
	[NullableContext(1)]
	[Nullable(0)]
	public class DiscardCardPanelData : IDiscardCardPanelData
	{
		// Token: 0x1700562A RID: 22058
		// (get) Token: 0x0602ADE2 RID: 175586 RVA: 0x00C10248 File Offset: 0x00C0E448
		// (set) Token: 0x0602ADE3 RID: 175587 RVA: 0x00C10250 File Offset: 0x00C0E450
		public Func<List<int>, UniTask> ConfirmFunc { get; set; }

		// Token: 0x1700562B RID: 22059
		// (get) Token: 0x0602ADE4 RID: 175588 RVA: 0x00C10259 File Offset: 0x00C0E459
		// (set) Token: 0x0602ADE5 RID: 175589 RVA: 0x00C10261 File Offset: 0x00C0E461
		public int LimitCount { get; set; }

		// Token: 0x1700562C RID: 22060
		// (get) Token: 0x0602ADE6 RID: 175590 RVA: 0x00C1026A File Offset: 0x00C0E46A
		// (set) Token: 0x0602ADE7 RID: 175591 RVA: 0x00C10272 File Offset: 0x00C0E472
		public List<PhantomCardData> CardDataList { get; set; }

		// Token: 0x1700562D RID: 22061
		// (get) Token: 0x0602ADE8 RID: 175592 RVA: 0x00C1027B File Offset: 0x00C0E47B
		// (set) Token: 0x0602ADE9 RID: 175593 RVA: 0x00C10283 File Offset: 0x00C0E483
		public string TitleTips { get; set; }

		// Token: 0x1700562E RID: 22062
		// (get) Token: 0x0602ADEA RID: 175594 RVA: 0x00C1028C File Offset: 0x00C0E48C
		// (set) Token: 0x0602ADEB RID: 175595 RVA: 0x00C10294 File Offset: 0x00C0E494
		public string SelectedTips { get; set; }

		// Token: 0x1700562F RID: 22063
		// (get) Token: 0x0602ADEC RID: 175596 RVA: 0x00C1029D File Offset: 0x00C0E49D
		// (set) Token: 0x0602ADED RID: 175597 RVA: 0x00C102A5 File Offset: 0x00C0E4A5
		public EBvbPlayerOperationType? GuideType { get; set; }
	}
}
