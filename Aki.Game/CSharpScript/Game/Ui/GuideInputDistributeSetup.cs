using System;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035B5 RID: 13749
	public class GuideInputDistributeSetup : InputDistributeSetup
	{
		// Token: 0x060230D7 RID: 143575 RVA: 0x009F7B10 File Offset: 0x009F5D10
		public override bool OnRefresh()
		{
			if (GuideModel.Instance.IsGuideLockingInput)
			{
				Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "[InputDistribute]引导遮罩中，则设置输入分发tag为 BlockAllInputTag", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.SetInputDistributeTag("BlockAllInputTag");
				return true;
			}
			return false;
		}
	}
}
