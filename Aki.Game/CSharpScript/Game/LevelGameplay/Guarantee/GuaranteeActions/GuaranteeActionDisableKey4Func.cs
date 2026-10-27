using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.BattleUi;

namespace CSharpScript.Game.LevelGamePlay.Guarantee.GuaranteeActions
{
	// Token: 0x02006E0F RID: 28175
	public class GuaranteeActionDisableKey4Func : GuaranteeActionBase
	{
		// Token: 0x06044B63 RID: 281443 RVA: 0x010F595B File Offset: 0x010F3B5B
		[NullableContext(2)]
		protected override void OnExecute(ActionParams @params = null)
		{
			BattleUiModel.Instance.SetTimeDilationSkillButtonEnable(false);
		}
	}
}
