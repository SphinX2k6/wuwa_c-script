using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C7C RID: 19580
	public class BattleUiOnlyAllowFightInputHandle
	{
		// Token: 0x06030DA9 RID: 200105 RVA: 0x00D9FAA5 File Offset: 0x00D9DCA5
		public void SetEnable(bool isEnable)
		{
			if (this.IsEnable == isEnable)
			{
				return;
			}
			this.IsEnable = isEnable;
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.SpecialSkill, this.HideBattleUiChildren, !isEnable, true, 0);
			InputDistributeController.Instance.RefreshInputTag();
		}

		// Token: 0x06030DAA RID: 200106 RVA: 0x00D9FADF File Offset: 0x00D9DCDF
		public bool GetEnable()
		{
			return this.IsEnable;
		}

		// Token: 0x04019E9A RID: 106138
		[Nullable(1)]
		private readonly EBattleUiChild[] HideBattleUiChildren = new EBattleUiChild[]
		{
			EBattleUiChild.Common,
			EBattleUiChild.ExitButton,
			EBattleUiChild.HomeButton,
			EBattleUiChild.TopButton,
			EBattleUiChild.MiniMap,
			EBattleUiChild.Mission,
			EBattleUiChild.Chat,
			EBattleUiChild.Formation,
			EBattleUiChild.GamepadFormation,
			EBattleUiChild.InteractionHint,
			EBattleUiChild.SilentAreaView,
			EBattleUiChild.SilentAreaInfoPanel,
			EBattleUiChild.Score
		};

		// Token: 0x04019E9B RID: 106139
		private bool IsEnable;
	}
}
