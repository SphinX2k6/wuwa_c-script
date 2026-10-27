using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C9A RID: 23706
	public class BattleUiOnlyAllowFightInputHandle
	{
		// Token: 0x0603BE56 RID: 245334 RVA: 0x00E4F41D File Offset: 0x00E4D61D
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

		// Token: 0x0603BE57 RID: 245335 RVA: 0x00E4F457 File Offset: 0x00E4D657
		public bool GetEnable()
		{
			return this.IsEnable;
		}

		// Token: 0x0401F3E1 RID: 127969
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

		// Token: 0x0401F3E2 RID: 127970
		private bool IsEnable;
	}
}
