using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.View
{
	// Token: 0x02006492 RID: 25746
	public class MatchThreeDifficultyTabItem : GridProxyAbstract<MatchThreeLevel>
	{
		// Token: 0x06040A84 RID: 264836 RVA: 0x00FA61EC File Offset: 0x00FA43EC
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

		// Token: 0x06040A85 RID: 264837 RVA: 0x00FA62F5 File Offset: 0x00FA44F5
		protected override void OnStart()
		{
			EventSystem.Instance.Add<int>(EEventName.OnMatchThreeChallengeStateUpdate, new Action<int>(this.OnChallengeStateUpdate));
		}

		// Token: 0x06040A86 RID: 264838 RVA: 0x00FA6313 File Offset: 0x00FA4513
		public void SetNormalLevelId(int normalLevelId)
		{
			this.NormalLevelId = normalLevelId;
		}

		// Token: 0x06040A87 RID: 264839 RVA: 0x00FA631C File Offset: 0x00FA451C
		public override void Refresh(MatchThreeLevel data, bool isSelected, int gridIndex)
		{
			this.LevelConfig = new MatchThreeLevel?(data);
			this.RefreshTitle();
			this.RefreshLockAndComplete();
		}

		// Token: 0x06040A88 RID: 264840 RVA: 0x00FA6336 File Offset: 0x00FA4536
		public void SetToggleActive(bool selected)
		{
			this.IsSelected = selected;
			this.RefreshToggleState();
		}

		// Token: 0x06040A89 RID: 264841 RVA: 0x00FA6348 File Offset: 0x00FA4548
		private void RefreshTitle()
		{
			string textStringId = (this.LevelConfig != null && this.LevelConfig.GetValueOrDefault().Difficulty == 0) ? "Tetristext_06" : "Tetristext_07";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
		}

		// Token: 0x06040A8A RID: 264842 RVA: 0x00FA63A0 File Offset: 0x00FA45A0
		private void RefreshLockAndComplete()
		{
			ActivityMatchThreeData matchThreeData = ActivityMatchThreeController.Instance.GetMatchThreeData();
			if (matchThreeData == null || this.LevelConfig == null)
			{
				return;
			}
			this.IsPrevFinish = (this.LevelConfig.Value.Difficulty <= 0 || this.NormalLevelId <= 0 || matchThreeData.CheckChallengeComplete(this.NormalLevelId));
			bool flag = matchThreeData.CheckChallengeComplete(this.LevelConfig.Value.Id);
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(!this.IsPrevFinish);
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 != null)
			{
				item2.SetUIActive(flag && this.IsPrevFinish);
			}
			UUIItem item3 = base.GetItem(4);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			this.RefreshToggleState();
		}

		// Token: 0x06040A8B RID: 264843 RVA: 0x00FA646C File Offset: 0x00FA466C
		private void RefreshToggleState()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.bLockStateOnSelect = this.IsPrevFinish;
			extendToggle.SetToggleState(this.IsSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06040A8C RID: 264844 RVA: 0x00FA64A7 File Offset: 0x00FA46A7
		private void OnClickedEnterButton(EToggleState state)
		{
			if (this.LevelConfig == null || state != EToggleState.ETT_Checked)
			{
				return;
			}
			MatchThreeLevelDetailView matchThreeLevelDetailView = UiManager.Instance.GetViewByName(EUiViewName.MatchThreeLevelDetailView) as MatchThreeLevelDetailView;
			if (matchThreeLevelDetailView == null)
			{
				return;
			}
			matchThreeLevelDetailView.ChangeDifficultyIndex(base.GridIndex);
		}

		// Token: 0x06040A8D RID: 264845 RVA: 0x00FA64DF File Offset: 0x00FA46DF
		private void OnChallengeStateUpdate(int challengeId)
		{
			this.RefreshLockAndComplete();
		}

		// Token: 0x06040A8E RID: 264846 RVA: 0x00FA64E7 File Offset: 0x00FA46E7
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnMatchThreeChallengeStateUpdate, new Action<int>(this.OnChallengeStateUpdate));
		}

		// Token: 0x04021A28 RID: 137768
		private MatchThreeLevel? LevelConfig;

		// Token: 0x04021A29 RID: 137769
		private bool IsSelected;

		// Token: 0x04021A2A RID: 137770
		private bool IsPrevFinish = true;

		// Token: 0x04021A2B RID: 137771
		private int NormalLevelId;
	}
}
