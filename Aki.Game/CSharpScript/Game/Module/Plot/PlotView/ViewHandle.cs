using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200403B RID: 16443
	[NullableContext(2)]
	[Nullable(0)]
	public class ViewHandle
	{
		// Token: 0x170053FB RID: 21499
		// (get) Token: 0x06029AB6 RID: 170678 RVA: 0x00BC736E File Offset: 0x00BC556E
		// (set) Token: 0x06029AB7 RID: 170679 RVA: 0x00BC7376 File Offset: 0x00BC5576
		public EUiViewName? ViewName { get; set; }

		// Token: 0x170053FC RID: 21500
		// (get) Token: 0x06029AB8 RID: 170680 RVA: 0x00BC737F File Offset: 0x00BC557F
		// (set) Token: 0x06029AB9 RID: 170681 RVA: 0x00BC7387 File Offset: 0x00BC5587
		public UiParam Param { get; set; }

		// Token: 0x170053FD RID: 21501
		// (get) Token: 0x06029ABA RID: 170682 RVA: 0x00BC7390 File Offset: 0x00BC5590
		// (set) Token: 0x06029ABB RID: 170683 RVA: 0x00BC7398 File Offset: 0x00BC5598
		public TCallback Callback { get; set; }

		// Token: 0x170053FE RID: 21502
		// (get) Token: 0x06029ABC RID: 170684 RVA: 0x00BC73A1 File Offset: 0x00BC55A1
		// (set) Token: 0x06029ABD RID: 170685 RVA: 0x00BC73A9 File Offset: 0x00BC55A9
		public long? OwnerId { get; set; }

		// Token: 0x06029ABE RID: 170686 RVA: 0x00BC73B2 File Offset: 0x00BC55B2
		public ViewHandle(EUiViewName? viewName = null, UiParam param = null, TCallback callback = null, long? ownerId = null)
		{
			this.ViewName = viewName;
			this.Param = param;
			this.Callback = callback;
			this.OwnerId = ownerId;
		}
	}
}
