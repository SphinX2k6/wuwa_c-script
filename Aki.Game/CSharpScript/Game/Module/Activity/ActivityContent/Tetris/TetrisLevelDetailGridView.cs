using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02006002 RID: 24578
	public class TetrisLevelDetailGridView : GridProxyAbstract<Tetris>
	{
		// Token: 0x0603E411 RID: 254993 RVA: 0x00F07B74 File Offset: 0x00F05D74
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickedEnterButton))
			};
		}

		// Token: 0x0603E412 RID: 254994 RVA: 0x00F07C1D File Offset: 0x00F05E1D
		protected override void OnStart()
		{
			this.AddEventListener();
		}

		// Token: 0x0603E413 RID: 254995 RVA: 0x00F07C25 File Offset: 0x00F05E25
		protected void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnTetrisChallengeStateUpdate, new Action<int>(this.OnTetrisChallengeStateUpdate));
		}

		// Token: 0x0603E414 RID: 254996 RVA: 0x00F07C43 File Offset: 0x00F05E43
		protected void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnTetrisChallengeStateUpdate, new Action<int>(this.OnTetrisChallengeStateUpdate));
		}

		// Token: 0x0603E415 RID: 254997 RVA: 0x00F07C61 File Offset: 0x00F05E61
		public override void Refresh(Tetris data, bool isSelected, int gridIndex)
		{
			this.ChallengeConfig = new Tetris?(data);
			this.RefreshTitle();
			this.RefreshLockAndComplete();
		}

		// Token: 0x0603E416 RID: 254998 RVA: 0x00F07C7C File Offset: 0x00F05E7C
		public int? GetChallengeDifficulty()
		{
			if (this.ChallengeConfig == null)
			{
				return null;
			}
			return new int?(this.ChallengeConfig.Value.Mode);
		}

		// Token: 0x0603E417 RID: 254999 RVA: 0x00F07CB8 File Offset: 0x00F05EB8
		private void RefreshLockAndComplete()
		{
			ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
			if (tetrisData == null || this.ChallengeConfig == null)
			{
				return;
			}
			bool flag = tetrisData.CheckPreChallengeComplete(this.ChallengeConfig.Value.Id);
			bool uiactive = tetrisData.CheckChallengeComplete(this.ChallengeConfig.Value.Id);
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIItem item2 = base.GetItem(4);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(uiactive);
		}

		// Token: 0x0603E418 RID: 255000 RVA: 0x00F07D40 File Offset: 0x00F05F40
		private void RefreshTitle()
		{
			string textStringId = (this.ChallengeConfig != null && this.ChallengeConfig.GetValueOrDefault().Mode == 0) ? "Tetristext_06" : "Tetristext_07";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
		}

		// Token: 0x0603E419 RID: 255001 RVA: 0x00F07D95 File Offset: 0x00F05F95
		public void SetToggleActive(bool selected)
		{
			this.IsSelected = selected;
			this.RefreshToggleState();
			this.SetClickRedDotState();
		}

		// Token: 0x0603E41A RID: 255002 RVA: 0x00F07DAC File Offset: 0x00F05FAC
		private void RefreshToggleState()
		{
			if (ActivityTetrisController.Instance.GetTetrisData() == null || this.ChallengeConfig == null)
			{
				return;
			}
			EToggleState state = EToggleState.ETT_UnChecked;
			if (this.IsSelected)
			{
				state = EToggleState.ETT_Checked;
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(state, false, false, false);
		}

		// Token: 0x0603E41B RID: 255003 RVA: 0x00F07DF5 File Offset: 0x00F05FF5
		private void OnTetrisChallengeStateUpdate(int challengeId)
		{
			this.RefreshLockAndComplete();
			this.RefreshToggleState();
		}

		// Token: 0x0603E41C RID: 255004 RVA: 0x00F07E04 File Offset: 0x00F06004
		private void OnClickedEnterButton(EToggleState state)
		{
			if (this.ChallengeConfig == null)
			{
				return;
			}
			if (ActivityTetrisController.Instance.GetTetrisData() == null)
			{
				return;
			}
			(UiManager.Instance.GetViewByName(EUiViewName.TetrisLevelDetailView) as TetrisLevelDetailView).ChangeDifficultyIndex(this.ChallengeConfig.Value.Mode);
			if (state == EToggleState.ETT_Checked)
			{
				this.SetClickRedDotState();
			}
		}

		// Token: 0x0603E41D RID: 255005 RVA: 0x00F07E64 File Offset: 0x00F06064
		public void SetClickRedDotState()
		{
			int activityId = ActivityTetrisController.Instance.ActivityId;
			ActivityModel.Instance.SaveActivityData(activityId, 10001, this.ChallengeConfig.Value.Id, 0, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}

		// Token: 0x0603E41E RID: 255006 RVA: 0x00F07EB2 File Offset: 0x00F060B2
		protected override void OnBeforeDestroy()
		{
			this.RemoveEventListener();
		}

		// Token: 0x04020852 RID: 133202
		private Tetris? ChallengeConfig;

		// Token: 0x04020853 RID: 133203
		private bool IsSelected;
	}
}
