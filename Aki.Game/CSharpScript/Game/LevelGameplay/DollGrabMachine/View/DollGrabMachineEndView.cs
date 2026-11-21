using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006069 RID: 24681
	public class DollGrabMachineEndView : UiViewBase
	{
		// Token: 0x0603B419 RID: 242713 RVA: 0x010C46F2 File Offset: 0x010C28F2
		[NullableContext(1)]
		public DollGrabMachineEndView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B41A RID: 242714 RVA: 0x010C46FB File Offset: 0x010C28FB
		protected override void OnAfterPlayStartSequence()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603B41B RID: 242715 RVA: 0x010C4704 File Offset: 0x010C2904
		protected override void OnBeforeDestroy()
		{
			UiManager.Instance.OpenView(EUiViewName.DollGrabMachineSeltView, null, null);
		}
	}
}
