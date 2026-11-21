using System;
using CSharpScript.Game.Module.Plot;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035BC RID: 13756
	public class PlotInputDistribute : InputDistributeSetup
	{
		// Token: 0x060230EA RID: 143594 RVA: 0x009F830C File Offset: 0x009F650C
		public override bool OnRefresh()
		{
			PlotModel instance = PlotModel.Instance;
			if (!PlotController.Instance.NeedInputRefresh())
			{
				return false;
			}
			if (instance.TimeLimitedOptionTag)
			{
				Log.Instance.Info(ELogModule.Input, ELogAuthor.FZX, "[InputDistribute] 剧情限时选项仅允许移动输入", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.SetInputDistributeTags(new string[]
				{
					"FightInputRoot.FightInput.AxisInput.CameraInput",
					"FightInputRoot.FightInput.AxisInput.MoveInput",
					"UiInputRoot.MouseInputTag"
				});
				return true;
			}
			if (instance.EntitySequenceInteractTag)
			{
				Log.Instance.Info(ELogModule.Input, ELogAuthor.FZX, "[InputDistribute] 实体剧情输入分发", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.SetInputDistributeTags(new string[]
				{
					"FightInputRoot.FightInput.AxisInput.CameraInput",
					"FightInputRoot.FightInput.AxisInput.MoveInput",
					"UiInputRoot.MouseInputTag",
					"UiInputRoot.Navigation",
					"UiInputRoot.ShortcutKeyTag"
				});
				return true;
			}
			if (instance.PlotConfig.DisableInput || PlotModel.Instance.IsBlendProcessing)
			{
				Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "[InputDistribute]刷新剧情输入Tag时，除了视角旋转和鼠标输入,其他输入都会被禁止", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.SetInputDistributeTags(new string[]
				{
					"UiInputRoot.MouseInputTag",
					"UiInputRoot.Navigation"
				});
				return true;
			}
			return false;
		}
	}
}
