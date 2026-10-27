using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x020059AA RID: 22954
	public class PrepareCountdownFloatTips : UiViewBase
	{
		// Token: 0x0603A38A RID: 238474 RVA: 0x00DD65D4 File Offset: 0x00DD47D4
		[NullableContext(1)]
		public PrepareCountdownFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A38B RID: 238475 RVA: 0x00DD65DD File Offset: 0x00DD47DD
		protected override void OnAfterPlayStartSequence()
		{
			CustomPromise closePromise = this.ClosePromise;
			if (closePromise != null && closePromise.IsPending)
			{
				return;
			}
			base.CloseMe(null);
		}
	}
}
