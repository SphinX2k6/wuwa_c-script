using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003572 RID: 13682
	[NullableContext(1)]
	[Nullable(0)]
	public class UiViewPending
	{
		// Token: 0x06022DBB RID: 142779 RVA: 0x009E68AB File Offset: 0x009E4AAB
		public UiViewPending(UiViewBase view, EViewPendingType pendingType, [Nullable(2)] UiViewBase nextView = null)
		{
			this.View = view;
			this.PendingType = pendingType;
			this.NextView = nextView;
			this.ExecutePromise = new CustomPromise<bool>();
		}

		// Token: 0x06022DBC RID: 142780 RVA: 0x009E68DA File Offset: 0x009E4ADA
		public bool Equal(UiViewPending other)
		{
			return this.View.ViewInfo.Name == other.View.ViewInfo.Name && this.PendingType == other.PendingType;
		}

		// Token: 0x06022DBD RID: 142781 RVA: 0x009E6914 File Offset: 0x009E4B14
		public bool IsPairWith(UiViewPending other)
		{
			return !(this.View.ViewInfo.Name != other.View.ViewInfo.Name) && (this.PendingType == EViewPendingType.Open && (other.PendingType == EViewPendingType.Close || other.PendingType == EViewPendingType.CloseSilently));
		}

		// Token: 0x0401342E RID: 78894
		public UiViewBase View;

		// Token: 0x0401342F RID: 78895
		[Nullable(2)]
		public UiViewBase NextView;

		// Token: 0x04013430 RID: 78896
		public readonly EViewPendingType PendingType = EViewPendingType.Open;

		// Token: 0x04013431 RID: 78897
		public CustomPromise<bool> ExecutePromise;
	}
}
