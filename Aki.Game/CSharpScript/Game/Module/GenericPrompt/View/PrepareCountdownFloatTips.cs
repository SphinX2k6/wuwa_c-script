using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x02004983 RID: 18819
	public class PrepareCountdownFloatTips : UiViewBase
	{
		// Token: 0x0602F2B0 RID: 193200 RVA: 0x00D25A64 File Offset: 0x00D23C64
		[NullableContext(1)]
		public PrepareCountdownFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F2B1 RID: 193201 RVA: 0x00D25A6D File Offset: 0x00D23C6D
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
