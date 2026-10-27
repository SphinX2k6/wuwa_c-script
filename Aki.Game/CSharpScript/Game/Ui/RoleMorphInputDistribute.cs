using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.BattleUi;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200468D RID: 18061
	public class RoleMorphInputDistribute : InputDistributeSetup
	{
		// Token: 0x0602E9A6 RID: 190886 RVA: 0x00ACA7A8 File Offset: 0x00AC89A8
		public unsafe override bool OnRefresh()
		{
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			if (curRoleData != null && curRoleData.OnlyBattleInput)
			{
				Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "[InputDistribute]尝试刷新战斗输入时，处于OnlyBattleInput，只允许战斗输入", default(ReadOnlySpan<ValueTuple<string, object>>));
				int num = 2;
				List<string> list = new List<string>(num);
				CollectionsMarshal.SetCount<string>(list, num);
				Span<string> span = CollectionsMarshal.AsSpan<string>(list);
				int num2 = 0;
				*span[num2] = "FightInputRoot";
				num2++;
				*span[num2] = "UiInputRoot";
				base.SetInputDistributeTags(list);
				return true;
			}
			return false;
		}
	}
}
