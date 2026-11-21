using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035B3 RID: 13747
	public class ExploreInputDistribute : InputDistributeSetup
	{
		// Token: 0x060230D2 RID: 143570 RVA: 0x009F7890 File Offset: 0x009F5A90
		public unsafe override bool OnRefresh()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.PhantomExploreView))
			{
				Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "[InputDistribute]PhantomExploreView轮盘界面打开,Input输入检测，刷新战斗输入时设置输入分发Tag为 MoveInputTag", default(ReadOnlySpan<ValueTuple<string, object>>));
				int num = 2;
				List<string> list = new List<string>(num);
				CollectionsMarshal.SetCount<string>(list, num);
				Span<string> span = CollectionsMarshal.AsSpan<string>(list);
				int num2 = 0;
				*span[num2] = "FightInputRoot.FightInput.AxisInput.MoveInput";
				num2++;
				*span[num2] = "UiInputRoot";
				base.SetInputDistributeTags(list);
				return true;
			}
			return false;
		}
	}
}
