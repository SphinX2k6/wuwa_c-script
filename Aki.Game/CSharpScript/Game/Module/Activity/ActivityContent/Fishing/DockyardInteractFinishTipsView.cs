using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065C3 RID: 26051
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardInteractFinishTipsView : UiViewBase
	{
		// Token: 0x0604158F RID: 267663 RVA: 0x00FD5D6E File Offset: 0x00FD3F6E
		public DockyardInteractFinishTipsView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06041590 RID: 267664 RVA: 0x00FD5D77 File Offset: 0x00FD3F77
		protected override void OnRegisterComponent()
		{
			this.Vm = (this.OpenParam as DockyardInteractFinishTipsViewModel);
		}

		// Token: 0x06041591 RID: 267665 RVA: 0x00FD5D8A File Offset: 0x00FD3F8A
		protected override void OnAfterPlayStartSequence()
		{
			Action closeCallback = this.Vm.CloseCallback;
			if (closeCallback != null)
			{
				closeCallback();
			}
			base.CloseMe(null);
		}

		// Token: 0x0402200F RID: 139279
		private DockyardInteractFinishTipsViewModel Vm;
	}
}
