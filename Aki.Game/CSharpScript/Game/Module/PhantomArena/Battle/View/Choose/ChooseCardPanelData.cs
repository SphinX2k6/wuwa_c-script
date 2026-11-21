using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Choose
{
	// Token: 0x0200423B RID: 16955
	[NullableContext(1)]
	[Nullable(0)]
	public class ChooseCardPanelData : IChooseCardPanelData
	{
		// Token: 0x17005634 RID: 22068
		// (get) Token: 0x0602AE24 RID: 175652 RVA: 0x00C10CEC File Offset: 0x00C0EEEC
		// (set) Token: 0x0602AE25 RID: 175653 RVA: 0x00C10CF4 File Offset: 0x00C0EEF4
		public Func<List<int>, UniTask> ConfirmFunc { get; set; }

		// Token: 0x17005635 RID: 22069
		// (get) Token: 0x0602AE26 RID: 175654 RVA: 0x00C10CFD File Offset: 0x00C0EEFD
		// (set) Token: 0x0602AE27 RID: 175655 RVA: 0x00C10D05 File Offset: 0x00C0EF05
		public int LimitCount { get; set; }

		// Token: 0x17005636 RID: 22070
		// (get) Token: 0x0602AE28 RID: 175656 RVA: 0x00C10D0E File Offset: 0x00C0EF0E
		// (set) Token: 0x0602AE29 RID: 175657 RVA: 0x00C10D16 File Offset: 0x00C0EF16
		public List<PhantomCardData> CardDataList { get; set; }

		// Token: 0x17005637 RID: 22071
		// (get) Token: 0x0602AE2A RID: 175658 RVA: 0x00C10D1F File Offset: 0x00C0EF1F
		// (set) Token: 0x0602AE2B RID: 175659 RVA: 0x00C10D27 File Offset: 0x00C0EF27
		public EBvbPlayerOperationType? GuideType { get; set; }
	}
}
