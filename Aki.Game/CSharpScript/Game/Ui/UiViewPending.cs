using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004641 RID: 17985
	[NullableContext(1)]
	[Nullable(0)]
	public class UiViewPending
	{
		// Token: 0x0602E671 RID: 190065 RVA: 0x00AB927B File Offset: 0x00AB747B
		public UiViewPending(UiViewBase view, EViewPendingType pendingType, [Nullable(2)] UiViewBase nextView = null)
		{
			this.View = view;
			this.PendingType = pendingType;
			this.NextView = nextView;
			this.ExecutePromise = new CustomPromise<bool>();
		}

		// Token: 0x0602E672 RID: 190066 RVA: 0x00AB92AA File Offset: 0x00AB74AA
		public bool Equal(UiViewPending other)
		{
			return this.View.ViewInfo.Name == other.View.ViewInfo.Name && this.PendingType == other.PendingType;
		}

		// Token: 0x0602E673 RID: 190067 RVA: 0x00AB92E4 File Offset: 0x00AB74E4
		public bool IsPairWith(UiViewPending other)
		{
			return !(this.View.ViewInfo.Name != other.View.ViewInfo.Name) && (this.PendingType == EViewPendingType.Open && (other.PendingType == EViewPendingType.Close || other.PendingType == EViewPendingType.CloseSilently));
		}

		// Token: 0x04018DD5 RID: 101845
		public UiViewBase View;

		// Token: 0x04018DD6 RID: 101846
		[Nullable(2)]
		public UiViewBase NextView;

		// Token: 0x04018DD7 RID: 101847
		public readonly EViewPendingType PendingType = EViewPendingType.Open;

		// Token: 0x04018DD8 RID: 101848
		public CustomPromise<bool> ExecutePromise;
	}
}
