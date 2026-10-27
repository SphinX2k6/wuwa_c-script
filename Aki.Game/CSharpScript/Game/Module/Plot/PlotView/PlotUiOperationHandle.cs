using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200506A RID: 20586
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class PlotUiOperationHandle
	{
		// Token: 0x06034BBC RID: 215996 RVA: 0x00C7A00D File Offset: 0x00C7820D
		public PlotUiOperationHandle(string name, EUiViewName targetView, PlotUiAsyncOperation operation, CustomPromise<bool> resultPromise, [Nullable(2)] Action onCancel = null)
		{
			this.Name = name;
			this.TargetView = targetView;
			this.Operation = operation;
			this.ResultPromise = resultPromise;
			this.OnCancel = onCancel;
		}

		// Token: 0x17008036 RID: 32822
		// (get) Token: 0x06034BBD RID: 215997 RVA: 0x00C7A03A File Offset: 0x00C7823A
		public string Name { get; }

		// Token: 0x17008037 RID: 32823
		// (get) Token: 0x06034BBE RID: 215998 RVA: 0x00C7A042 File Offset: 0x00C78242
		public EUiViewName TargetView { get; }

		// Token: 0x17008038 RID: 32824
		// (get) Token: 0x06034BBF RID: 215999 RVA: 0x00C7A04A File Offset: 0x00C7824A
		public PlotUiAsyncOperation Operation { get; }

		// Token: 0x17008039 RID: 32825
		// (get) Token: 0x06034BC0 RID: 216000 RVA: 0x00C7A052 File Offset: 0x00C78252
		public CustomPromise<bool> ResultPromise { get; }

		// Token: 0x1700803A RID: 32826
		// (get) Token: 0x06034BC1 RID: 216001 RVA: 0x00C7A05A File Offset: 0x00C7825A
		[Nullable(2)]
		public Action OnCancel { [NullableContext(2)] get; }
	}
}
