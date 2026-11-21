using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.BattleUi;

namespace CSharpScript.Game.Module.RoleMorph.Handle
{
	// Token: 0x02003D34 RID: 15668
	public class RoleMorphGuYingXiongKaiHandle : RoleMorphHandleBase
	{
		// Token: 0x0602822F RID: 164399 RVA: 0x00B3C2BC File Offset: 0x00B3A4BC
		public override void BeginMorph()
		{
			TrackModel.Instance.SetForceCloseTracked(true);
			List<int> list = new List<int>
			{
				GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.古英雄铠.模式标识.蓄力模式"],
				GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.古英雄铠.模式标识.隐藏瞄准UI"]
			};
			BattleUiModel.Instance.SetTagIdJoystickStaticVisible(list.ToArray());
			BattleUiModel.Instance.SetTagIdMoveCursorVisible(list.ToArray());
		}

		// Token: 0x06028230 RID: 164400 RVA: 0x00B3C324 File Offset: 0x00B3A524
		public override void EndMorph()
		{
			TrackModel.Instance.SetForceCloseTracked(false);
		}
	}
}
