using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.LevelGamePlay.Guarantee.GuaranteeActions
{
	// Token: 0x02006E11 RID: 28177
	public class GuaranteeActionEnablePlayerMoveControl : GuaranteeActionBase
	{
		// Token: 0x06044B67 RID: 281447 RVA: 0x010F5A6E File Offset: 0x010F3C6E
		[NullableContext(2)]
		protected override void OnExecute(ActionParams @params)
		{
			InputController.Instance.SetMoveControlEnabled(true, true, true, true);
		}
	}
}
