using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Game.Module.Activity.ActivityContent.Tetris.Activity;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FC9 RID: 12233
	public class TetrisLevelDetailGridView : GridProxyAbstract<Tetris>
	{
		// Token: 0x0601D097 RID: 118935 RVA: 0x008DEB60 File Offset: 0x008DCD60
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickedEnterButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0601D098 RID: 118936 RVA: 0x008DEC69 File Offset: 0x008DCE69
		protected override void OnStart()
		{
			this.AddEventListener();
		}

		// Token: 0x0601D099 RID: 118937 RVA: 0x008DEC71 File Offset: 0x008DCE71
		protected void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnTetrisChallengeStateUpdate, new Action<int>(this.OnTetrisChallengeStateUpdate));
		}

		// Token: 0x0601D09A RID: 118938 RVA: 0x008DEC8F File Offset: 0x008DCE8F
		protected void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnTetrisChallengeStateUpdate, new Action<int>(this.OnTetrisChallengeStateUpdate));
		}

		// Token: 0x0601D09B RID: 118939 RVA: 0x008DECAD File Offset: 0x008DCEAD
		public override void Refresh(Tetris data, bool isSelected, int gridIndex)
		{
			this.ChallengeConfig = new Tetris?(data);
			this.RefreshTitle();
			this.RefreshLockAndComplete();
		}

		// Token: 0x0601D09C RID: 118940 RVA: 0x008DECC8 File Offset: 0x008DCEC8
		public int? GetChallengeDifficulty()
		{
			if (this.ChallengeConfig == null)
			{
				return null;
			}
			return new int?(this.ChallengeConfig.Value.Mode);
		}

		// Token: 0x0601D09D RID: 118941 RVA: 0x008DED04 File Offset: 0x008DCF04
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

		// Token: 0x0601D09E RID: 118942 RVA: 0x008DED8C File Offset: 0x008DCF8C
		private void RefreshTitle()
		{
			string textStringId = (this.ChallengeConfig != null && this.ChallengeConfig.GetValueOrDefault().Mode == 0) ? "Tetristext_06" : "Tetristext_07";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
		}

		// Token: 0x0601D09F RID: 118943 RVA: 0x008DEDE1 File Offset: 0x008DCFE1
		public void SetToggleActive(bool selected)
		{
			this.IsSelected = selected;
			this.RefreshToggleState();
			this.SetClickRedDotState();
		}

		// Token: 0x0601D0A0 RID: 118944 RVA: 0x008DEDF8 File Offset: 0x008DCFF8
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

		// Token: 0x0601D0A1 RID: 118945 RVA: 0x008DEE41 File Offset: 0x008DD041
		private void OnTetrisChallengeStateUpdate(int challengeId)
		{
			this.RefreshLockAndComplete();
			this.RefreshToggleState();
		}

		// Token: 0x0601D0A2 RID: 118946 RVA: 0x008DEE50 File Offset: 0x008DD050
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

		// Token: 0x0601D0A3 RID: 118947 RVA: 0x008DEEB0 File Offset: 0x008DD0B0
		public void SetClickRedDotState()
		{
			int activityId = ActivityTetrisController.Instance.ActivityId;
			ActivityModel.Instance.SaveActivityData(activityId, 10001, this.ChallengeConfig.Value.Id, 0, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}

		// Token: 0x0601D0A4 RID: 118948 RVA: 0x008DEEFE File Offset: 0x008DD0FE
		protected override void OnBeforeDestroy()
		{
			this.RemoveEventListener();
		}

		// Token: 0x0400F49F RID: 62623
		private Tetris? ChallengeConfig;

		// Token: 0x0400F4A0 RID: 62624
		private bool IsSelected;
	}
}
