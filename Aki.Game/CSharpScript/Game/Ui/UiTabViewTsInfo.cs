using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046E2 RID: 18146
	[NullableContext(1)]
	[Nullable(0)]
	public class UiTabViewTsInfo : IUiTabViewTsInfo
	{
		// Token: 0x17007682 RID: 30338
		// (get) Token: 0x0602ECB6 RID: 191670 RVA: 0x00AD57B1 File Offset: 0x00AD39B1
		// (set) Token: 0x0602ECB7 RID: 191671 RVA: 0x00AD57B9 File Offset: 0x00AD39B9
		public TCreateUiTabViewBase CreateUiTabView { get; set; }

		// Token: 0x17007683 RID: 30339
		// (get) Token: 0x0602ECB8 RID: 191672 RVA: 0x00AD57C2 File Offset: 0x00AD39C2
		// (set) Token: 0x0602ECB9 RID: 191673 RVA: 0x00AD57CA File Offset: 0x00AD39CA
		public string ResourceId { get; set; }

		// Token: 0x0602ECBA RID: 191674 RVA: 0x00AD57D3 File Offset: 0x00AD39D3
		public UiTabViewTsInfo(TCreateUiTabViewBase createUiTabView, string resourceId)
		{
			this.CreateUiTabView = createUiTabView;
			this.ResourceId = resourceId;
		}
	}
}
