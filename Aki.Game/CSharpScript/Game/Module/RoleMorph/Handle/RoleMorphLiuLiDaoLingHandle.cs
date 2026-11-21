using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.RoleMorph.Handle
{
	// Token: 0x02003D36 RID: 15670
	public class RoleMorphLiuLiDaoLingHandle : RoleMorphHandleBase
	{
		// Token: 0x06028235 RID: 164405 RVA: 0x00B3C345 File Offset: 0x00B3A545
		public override void BeginMorph()
		{
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData == null)
			{
				return;
			}
			childViewData.SetChildrenVisible(EBattleUiVisibleReason.Custom, new List<EBattleUiChild>
			{
				EBattleUiChild.BattleFloat,
				EBattleUiChild.SkillButton,
				EBattleUiChild.GamepadSkillButton
			}, false, true, 0);
		}

		// Token: 0x06028236 RID: 164406 RVA: 0x00B3C37C File Offset: 0x00B3A57C
		public override void EndMorph()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.LiuLiDaoLingView))
			{
				UiManager.Instance.CloseView(EUiViewName.LiuLiDaoLingView, null);
			}
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData == null)
			{
				return;
			}
			childViewData.SetChildrenVisible(EBattleUiVisibleReason.Custom, new List<EBattleUiChild>
			{
				EBattleUiChild.BattleFloat,
				EBattleUiChild.SkillButton,
				EBattleUiChild.GamepadSkillButton
			}, true, true, 0);
		}
	}
}
