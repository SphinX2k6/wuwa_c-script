using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003612 RID: 13842
	[NullableContext(1)]
	[Nullable(0)]
	public class UiTabViewTsInfo : IUiTabViewTsInfo
	{
		// Token: 0x1700493E RID: 18750
		// (get) Token: 0x060233F1 RID: 144369 RVA: 0x00A03289 File Offset: 0x00A01489
		// (set) Token: 0x060233F2 RID: 144370 RVA: 0x00A03291 File Offset: 0x00A01491
		public TCreateUiTabViewBase CreateUiTabView { get; set; }

		// Token: 0x1700493F RID: 18751
		// (get) Token: 0x060233F3 RID: 144371 RVA: 0x00A0329A File Offset: 0x00A0149A
		// (set) Token: 0x060233F4 RID: 144372 RVA: 0x00A032A2 File Offset: 0x00A014A2
		public string ResourceId { get; set; }

		// Token: 0x060233F5 RID: 144373 RVA: 0x00A032AB File Offset: 0x00A014AB
		public UiTabViewTsInfo(TCreateUiTabViewBase createUiTabView, string resourceId)
		{
			this.CreateUiTabView = createUiTabView;
			this.ResourceId = resourceId;
		}
	}
}
