using System;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004684 RID: 18052
	public class GuideInputDistributeSetup : InputDistributeSetup
	{
		// Token: 0x0602E98D RID: 190861 RVA: 0x00AC9DDC File Offset: 0x00AC7FDC
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
