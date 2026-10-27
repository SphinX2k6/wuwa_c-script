using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.BattleUi;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200469D RID: 18077
	public class ViewHotKeyHandleFunctionMenu : ViewHotKeyHandle
	{
		// Token: 0x0602E9DA RID: 190938 RVA: 0x00ACAFBA File Offset: 0x00AC91BA
		[NullableContext(1)]
		public ViewHotKeyHandleFunctionMenu(IOpenAndCloseViewHotKey parameters) : base(parameters)
		{
		}

		// Token: 0x0602E9DB RID: 190939 RVA: 0x00ACAFC3 File Offset: 0x00AC91C3
		protected override bool SpecialConditionCheck()
		{
			if (GameModeController.Instance.IsInInstance() || !BattleUiModel.Instance.ChildViewData.GetChildVisible(EBattleUiChild.HomeButton))
			{
				EventSystem.Instance.Emit<string>(EEventName.InputDistribute, this.ActionName);
				return false;
			}
			return true;
		}

		// Token: 0x0602E9DC RID: 190940 RVA: 0x00ACAFFC File Offset: 0x00AC91FC
		protected override bool CheckHasInputLimit()
		{
			return !GameModeController.Instance.IsInInstance() && LevelEventLockInputState.Instance.InputLimitView.Contains(this.ViewName.Value);
		}
	}
}
