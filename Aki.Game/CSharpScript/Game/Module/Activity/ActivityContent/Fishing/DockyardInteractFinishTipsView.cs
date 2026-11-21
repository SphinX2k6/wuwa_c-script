using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005541 RID: 21825
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardInteractFinishTipsView : UiViewBase
	{
		// Token: 0x06036254 RID: 221780 RVA: 0x00F1CDAE File Offset: 0x00F1AFAE
		public DockyardInteractFinishTipsView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06036255 RID: 221781 RVA: 0x00F1CDB7 File Offset: 0x00F1AFB7
		protected override void OnRegisterComponent()
		{
			this.Vm = (this.OpenParam as DockyardInteractFinishTipsViewModel);
		}

		// Token: 0x06036256 RID: 221782 RVA: 0x00F1CDCA File Offset: 0x00F1AFCA
		protected override void OnAfterPlayStartSequence()
		{
			Action closeCallback = this.Vm.CloseCallback;
			if (closeCallback != null)
			{
				closeCallback();
			}
			base.CloseMe(null);
		}

		// Token: 0x0401C940 RID: 117056
		private DockyardInteractFinishTipsViewModel Vm;
	}
}
