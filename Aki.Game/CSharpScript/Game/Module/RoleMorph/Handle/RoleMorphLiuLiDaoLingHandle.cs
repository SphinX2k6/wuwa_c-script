using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.RoleMorph.Handle
{
	// Token: 0x02004D6D RID: 19821
	public class RoleMorphLiuLiDaoLingHandle : RoleMorphHandleBase
	{
		// Token: 0x060333C7 RID: 209863 RVA: 0x00BF3121 File Offset: 0x00BF1321
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

		// Token: 0x060333C8 RID: 209864 RVA: 0x00BF3158 File Offset: 0x00BF1358
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
