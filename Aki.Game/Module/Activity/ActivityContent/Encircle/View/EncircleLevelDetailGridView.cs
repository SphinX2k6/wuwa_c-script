using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle.View
{
	// Token: 0x0200301A RID: 12314
	public class EncircleLevelDetailGridView : GridProxyAbstract<int>
	{
		// Token: 0x0601D37A RID: 119674 RVA: 0x008EB1E4 File Offset: 0x008E93E4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickedEnterButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0601D37B RID: 119675 RVA: 0x008EB350 File Offset: 0x008E9550
		protected override void OnStart()
		{
			this.AddEventListener();
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnUndeterminedClicked.Add(new Action(this.OnClickToggleOnUndetermined));
		}

		// Token: 0x0601D37C RID: 119676 RVA: 0x008EB37A File Offset: 0x008E957A
		protected void AddEventListener()
		{
			EventSystem.Instance.Add<EncircleChallengePb>(EEventName.EncircleDataUpdate, new Action<EncircleChallengePb>(this.OnEncircleDataUpdate));
		}

		// Token: 0x0601D37D RID: 119677 RVA: 0x008EB398 File Offset: 0x008E9598
		protected void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.EncircleDataUpdate, new Action<EncircleChallengePb>(this.OnEncircleDataUpdate));
		}

		// Token: 0x0601D37E RID: 119678 RVA: 0x008EB3B6 File Offset: 0x008E95B6
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.RefreshView(data);
			this.RefreshDesc();
		}

		// Token: 0x0601D37F RID: 119679 RVA: 0x008EB3C8 File Offset: 0x008E95C8
		public int? GetChallengeDifficulty()
		{
			if (this.ChallengeConfig == null)
			{
				return null;
			}
			return new int?(this.ChallengeConfig.Value.Difficulty);
		}

		// Token: 0x0601D380 RID: 119680 RVA: 0x008EB404 File Offset: 0x008E9604
		private void RefreshDesc()
		{
			string textStringId = "EncircleLevelType_Single";
			if (this.GetChallengeDifficulty().GetValueOrDefault() == 1)
			{
				textStringId = "EncircleLevelType_Couple";
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textStringId, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), textStringId, Array.Empty<object>());
		}

		// Token: 0x0601D381 RID: 119681 RVA: 0x008EB45C File Offset: 0x008E965C
		private void RefreshView(int data)
		{
			this.ChallengeId = data;
			this.ChallengeConfig = ActivityEncircleConfig.Instance.GetEncircleChallengeConfig(this.ChallengeId);
			ActivityEncircleData encircleData = ActivityEncircleController.Instance.GetEncircleData();
			this.IsFinish = encircleData.CheckChallengeComplete(this.ChallengeId);
			this.IsPrevFinish = (this.ChallengeConfig.Value.PreId == 0 || encircleData.CheckChallengeComplete(this.ChallengeConfig.Value.PreId));
			if (this.IsPrevFinish)
			{
				this.SetToggleActive();
			}
			this.RefreshComplete();
			this.RefreshRecord();
		}

		// Token: 0x0601D382 RID: 119682 RVA: 0x008EB4F4 File Offset: 0x008E96F4
		private void RefreshRecord()
		{
			if (this.IsFinish)
			{
				ActivityEncircleData encircleData = ActivityEncircleController.Instance.GetEncircleData();
				UUIText text = base.GetText(4);
				if (text != null)
				{
					text.SetUIActive(true);
				}
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(4), "Encircle_FewestSteps", new <>z__ReadOnlySingleElementList<object>(encircleData.GetChallengeRecord(this.ChallengeId)));
				return;
			}
			UUIText text2 = base.GetText(4);
			if (text2 == null)
			{
				return;
			}
			text2.SetUIActive(false);
		}

		// Token: 0x0601D383 RID: 119683 RVA: 0x008EB568 File Offset: 0x008E9768
		private void RefreshComplete()
		{
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(this.IsFinish);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(this.IsPrevFinish);
			}
			UUIItem item3 = base.GetItem(5);
			if (item3 != null)
			{
				item3.SetUIActive(!this.IsPrevFinish);
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(this.IsPrevFinish ? EToggleState.ETT_Checked : EToggleState.ETT_UnDetermined, false, false, false);
		}

		// Token: 0x0601D384 RID: 119684 RVA: 0x008EB5E1 File Offset: 0x008E97E1
		public void SetToggleActive()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			}
			this.SetClickRedDotState();
		}

		// Token: 0x0601D385 RID: 119685 RVA: 0x008EB600 File Offset: 0x008E9800
		[NullableContext(1)]
		private void OnEncircleDataUpdate(EncircleChallengePb newData)
		{
			this.RefreshView(this.ChallengeId);
		}

		// Token: 0x0601D386 RID: 119686 RVA: 0x008EB610 File Offset: 0x008E9810
		private void OnClickToggleOnUndetermined()
		{
			string levelTitle = ActivityEncircleConfig.Instance.GetEncircleChallengeConfig(this.ChallengeConfig.Value.PreId).Value.LevelTitle;
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(levelTitle, levelTitle);
			ScrollingTipsController.Instance.ShowTipsByTextId("Encirle_DifficultyLockTips_Text", new object[]
			{
				multiTextByKey
			});
		}

		// Token: 0x0601D387 RID: 119687 RVA: 0x008EB674 File Offset: 0x008E9874
		private void OnClickedEnterButton(EToggleState state)
		{
			if (this.ChallengeConfig == null)
			{
				return;
			}
			if (!this.IsPrevFinish)
			{
				return;
			}
			(UiManager.Instance.GetViewByName(EUiViewName.EncircleLevelDetailView) as EncircleLevelDetailView).ChangeDifficultyIndex(this.ChallengeConfig.Value.Difficulty);
			if (state == EToggleState.ETT_Checked)
			{
				this.SetClickRedDotState();
			}
		}

		// Token: 0x0601D388 RID: 119688 RVA: 0x008EB6D0 File Offset: 0x008E98D0
		public void SetClickRedDotState()
		{
			int activityId = ActivityEncircleController.Instance.ActivityId;
			ActivityModel.Instance.SaveActivityData(activityId, 10001, this.ChallengeId, 0, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}

		// Token: 0x0601D389 RID: 119689 RVA: 0x008EB711 File Offset: 0x008E9911
		protected override void OnBeforeDestroy()
		{
			this.RemoveEventListener();
		}

		// Token: 0x0400F5F4 RID: 62964
		private int ChallengeId;

		// Token: 0x0400F5F5 RID: 62965
		private bool IsFinish;

		// Token: 0x0400F5F6 RID: 62966
		private bool IsPrevFinish;

		// Token: 0x0400F5F7 RID: 62967
		private EncircleChallenge? ChallengeConfig;
	}
}
