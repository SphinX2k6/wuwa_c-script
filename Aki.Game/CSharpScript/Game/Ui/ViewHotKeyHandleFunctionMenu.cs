using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.BattleUi;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035CE RID: 13774
	public class ViewHotKeyHandleFunctionMenu : ViewHotKeyHandle
	{
		// Token: 0x06023126 RID: 143654 RVA: 0x009F988E File Offset: 0x009F7A8E
		[NullableContext(1)]
		public ViewHotKeyHandleFunctionMenu(IOpenAndCloseViewHotKey parameters) : base(parameters)
		{
		}

		// Token: 0x06023127 RID: 143655 RVA: 0x009F9897 File Offset: 0x009F7A97
		protected override bool SpecialConditionCheck()
		{
			if (GameModeController.Instance.IsInInstance() || !BattleUiModel.Instance.ChildViewData.GetChildVisible(EBattleUiChild.HomeButton))
			{
				EventSystem.Instance.Emit<string>(EEventName.InputDistribute, this.ActionName);
				return false;
			}
			return true;
		}

		// Token: 0x06023128 RID: 143656 RVA: 0x009F98D0 File Offset: 0x009F7AD0
		protected override bool CheckHasInputLimit()
		{
			return !GameModeController.Instance.IsInInstance() && LevelEventLockInputState.Instance.InputLimitView.Contains(this.ViewName.Value);
		}
	}
}
