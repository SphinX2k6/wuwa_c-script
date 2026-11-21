using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200403A RID: 16442
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class PlotUiOperationHandle
	{
		// Token: 0x06029AB0 RID: 170672 RVA: 0x00BC7319 File Offset: 0x00BC5519
		public PlotUiOperationHandle(string name, EUiViewName targetView, PlotUiAsyncOperation operation, CustomPromise<bool> resultPromise, [Nullable(2)] Action onCancel = null)
		{
			this.Name = name;
			this.TargetView = targetView;
			this.Operation = operation;
			this.ResultPromise = resultPromise;
			this.OnCancel = onCancel;
		}

		// Token: 0x170053F6 RID: 21494
		// (get) Token: 0x06029AB1 RID: 170673 RVA: 0x00BC7346 File Offset: 0x00BC5546
		public string Name { get; }

		// Token: 0x170053F7 RID: 21495
		// (get) Token: 0x06029AB2 RID: 170674 RVA: 0x00BC734E File Offset: 0x00BC554E
		public EUiViewName TargetView { get; }

		// Token: 0x170053F8 RID: 21496
		// (get) Token: 0x06029AB3 RID: 170675 RVA: 0x00BC7356 File Offset: 0x00BC5556
		public PlotUiAsyncOperation Operation { get; }

		// Token: 0x170053F9 RID: 21497
		// (get) Token: 0x06029AB4 RID: 170676 RVA: 0x00BC735E File Offset: 0x00BC555E
		public CustomPromise<bool> ResultPromise { get; }

		// Token: 0x170053FA RID: 21498
		// (get) Token: 0x06029AB5 RID: 170677 RVA: 0x00BC7366 File Offset: 0x00BC5566
		[Nullable(2)]
		public Action OnCancel { [NullableContext(2)] get; }
	}
}
