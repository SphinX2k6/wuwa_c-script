using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.BattleUi;

namespace CSharpScript.Game.Module.RoleMorph.Handle
{
	// Token: 0x02004D6B RID: 19819
	public class RoleMorphGuYingXiongKaiHandle : RoleMorphHandleBase
	{
		// Token: 0x060333C1 RID: 209857 RVA: 0x00BF3098 File Offset: 0x00BF1298
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

		// Token: 0x060333C2 RID: 209858 RVA: 0x00BF3100 File Offset: 0x00BF1300
		public override void EndMorph()
		{
			TrackModel.Instance.SetForceCloseTracked(false);
		}
	}
}
