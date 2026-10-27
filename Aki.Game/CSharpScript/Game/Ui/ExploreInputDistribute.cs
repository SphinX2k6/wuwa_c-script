using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004682 RID: 18050
	public class ExploreInputDistribute : InputDistributeSetup
	{
		// Token: 0x0602E988 RID: 190856 RVA: 0x00AC9B5C File Offset: 0x00AC7D5C
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
