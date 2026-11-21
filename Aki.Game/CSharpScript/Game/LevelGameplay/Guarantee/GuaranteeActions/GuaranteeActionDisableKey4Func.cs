using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.BattleUi;

namespace CSharpScript.Game.LevelGamePlay.Guarantee.GuaranteeActions
{
	// Token: 0x02005F8F RID: 24463
	public class GuaranteeActionDisableKey4Func : GuaranteeActionBase
	{
		// Token: 0x0603ACC9 RID: 240841 RVA: 0x0109FD1B File Offset: 0x0109DF1B
		[NullableContext(2)]
		protected override void OnExecute(ActionParams @params = null)
		{
			BattleUiModel.Instance.SetTimeDilationSkillButtonEnable(false);
		}
	}
}
