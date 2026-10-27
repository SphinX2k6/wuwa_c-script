using System;
using CSharpScript.Core.Common;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004687 RID: 18055
	public class LevelEventInputDistribute : InputDistributeSetup
	{
		// Token: 0x0602E997 RID: 190871 RVA: 0x00ACA2E8 File Offset: 0x00AC84E8
		public override bool OnRefresh()
		{
			if (LevelEventLockInputState.Instance.IsLockInput())
			{
				if (InputManager.Instance.IsAltPress && Info.Instance.IsInKeyBoard() && LevelEventLockInputState.Instance.IsInputTagHasUiInputRoot)
				{
					Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "[InputDistribute]刷新关卡事件输入Tag时，处于键鼠设备并且通过Alt显示鼠标，设置输入分发Tag为 UiInputRootTag", default(ReadOnlySpan<ValueTuple<string, object>>));
					base.SetInputDistributeTag("UiInputRoot");
				}
				else
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Input;
					ELogAuthor author = ELogAuthor.XXJ;
					string message = "[InputDistribute]刷新关卡事件输入Tag时";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("输入TAG", LevelEventLockInputState.Instance.InputTagNames);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					base.SetInputDistributeTags(LevelEventLockInputState.Instance.InputTagNames);
				}
				return true;
			}
			return false;
		}
	}
}
