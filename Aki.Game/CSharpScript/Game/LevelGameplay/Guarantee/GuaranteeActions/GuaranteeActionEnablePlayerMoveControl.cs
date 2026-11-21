using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.LevelGamePlay.Guarantee.GuaranteeActions
{
	// Token: 0x02005F91 RID: 24465
	public class GuaranteeActionEnablePlayerMoveControl : GuaranteeActionBase
	{
		// Token: 0x0603ACCE RID: 240846 RVA: 0x0109FEA2 File Offset: 0x0109E0A2
		[NullableContext(2)]
		protected override void OnExecute(ActionParams @params)
		{
			InputController.Instance.SetMoveControlEnabled(true, true, true, true);
		}
	}
}
