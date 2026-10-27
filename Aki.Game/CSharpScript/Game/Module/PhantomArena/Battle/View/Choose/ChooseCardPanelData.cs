using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Choose
{
	// Token: 0x0200526B RID: 21099
	[NullableContext(1)]
	[Nullable(0)]
	public class ChooseCardPanelData : IChooseCardPanelData
	{
		// Token: 0x17008274 RID: 33396
		// (get) Token: 0x06035F29 RID: 220969 RVA: 0x00CC3624 File Offset: 0x00CC1824
		// (set) Token: 0x06035F2A RID: 220970 RVA: 0x00CC362C File Offset: 0x00CC182C
		public Func<List<int>, UniTask> ConfirmFunc { get; set; }

		// Token: 0x17008275 RID: 33397
		// (get) Token: 0x06035F2B RID: 220971 RVA: 0x00CC3635 File Offset: 0x00CC1835
		// (set) Token: 0x06035F2C RID: 220972 RVA: 0x00CC363D File Offset: 0x00CC183D
		public int LimitCount { get; set; }

		// Token: 0x17008276 RID: 33398
		// (get) Token: 0x06035F2D RID: 220973 RVA: 0x00CC3646 File Offset: 0x00CC1846
		// (set) Token: 0x06035F2E RID: 220974 RVA: 0x00CC364E File Offset: 0x00CC184E
		public List<PhantomCardData> CardDataList { get; set; }

		// Token: 0x17008277 RID: 33399
		// (get) Token: 0x06035F2F RID: 220975 RVA: 0x00CC3657 File Offset: 0x00CC1857
		// (set) Token: 0x06035F30 RID: 220976 RVA: 0x00CC365F File Offset: 0x00CC185F
		public EBvbPlayerOperationType? GuideType { get; set; }
	}
}
