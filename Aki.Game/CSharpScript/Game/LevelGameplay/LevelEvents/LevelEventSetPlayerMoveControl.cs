using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.LevelGamePlay.Guarantee;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CF0 RID: 23792
	public class LevelEventSetPlayerMoveControl : LevelEventBase
	{
		// Token: 0x0603A3A4 RID: 238500 RVA: 0x01073C84 File Offset: 0x01071E84
		public LevelEventSetPlayerMoveControl(int id) : base(id)
		{
		}

		// Token: 0x0603A3A5 RID: 238501 RVA: 0x01073C90 File Offset: 0x01071E90
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

		// Token: 0x0603A3A6 RID: 238502 RVA: 0x01073D04 File Offset: 0x01071F04
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

		// Token: 0x0401EBF7 RID: 125943
		private bool AllEnabled;
	}
}
