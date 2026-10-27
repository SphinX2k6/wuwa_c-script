using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006EE9 RID: 28393
	public class DollGrabMachineEndView : UiViewBase
	{
		// Token: 0x06045270 RID: 283248 RVA: 0x0111A962 File Offset: 0x01118B62
		[NullableContext(1)]
		public DollGrabMachineEndView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06045271 RID: 283249 RVA: 0x0111A96B File Offset: 0x01118B6B
		protected override void OnAfterPlayStartSequence()
		{
			base.CloseMe(null);
		}

		// Token: 0x06045272 RID: 283250 RVA: 0x0111A974 File Offset: 0x01118B74
		protected override void OnBeforeDestroy()
		{
			UiManager.Instance.OpenView(EUiViewName.DollGrabMachineSeltView, null, null);
		}
	}
}
