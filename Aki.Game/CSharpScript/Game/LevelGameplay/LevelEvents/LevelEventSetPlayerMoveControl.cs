using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.LevelGamePlay.Guarantee;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B78 RID: 27512
	public class LevelEventSetPlayerMoveControl : LevelEventBase
	{
		// Token: 0x06044252 RID: 279122 RVA: 0x010CA010 File Offset: 0x010C8210
		public LevelEventSetPlayerMoveControl(int id) : base(id)
		{
		}

		// Token: 0x06044253 RID: 279123 RVA: 0x010CA01C File Offset: 0x010C821C
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				return;
			}
			SetPlayerMoveControl setPlayerMoveControl = inParams as SetPlayerMoveControl;
			this.AllEnabled = (setPlayerMoveControl.Forward == 1 && setPlayerMoveControl.Back == 1 && setPlayerMoveControl.Left == 1 && setPlayerMoveControl.Right == 1);
			InputController.Instance.SetMoveControlEnabled(setPlayerMoveControl.Forward == 1, setPlayerMoveControl.Back == 1, setPlayerMoveControl.Left == 1, setPlayerMoveControl.Right == 1);
		}

		// Token: 0x06044254 RID: 279124 RVA: 0x010CA090 File Offset: 0x010C8290
		protected override void OnUpdateGuarantee()
		{
			GuaranteeActionInfo p = new GuaranteeActionInfo
			{
				Name = EGuaranteeAction.EnablePlayerMoveControl
			};
			if (this.AllEnabled)
			{
				EventSystem.Instance.Emit<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.RemGuaranteeAction, this.Type, this.BaseContext, p, null);
				return;
			}
			EventSystem.Instance.Emit<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.AddGuaranteeAction, this.Type, this.BaseContext, p, null);
		}

		// Token: 0x04023955 RID: 145749
		private bool AllEnabled;
	}
}
