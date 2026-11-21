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
	// Token: 0x02005410 RID: 21520
	public class MatchThreeDifficultyTabItem : GridProxyAbstract<MatchThreeLevel>
	{
		// Token: 0x06035748 RID: 218952 RVA: 0x00EED234 File Offset: 0x00EEB434
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

		// Token: 0x06035749 RID: 218953 RVA: 0x00EED33D File Offset: 0x00EEB53D
		protected override void OnStart()
		{
			EventSystem.Instance.Add<int>(EEventName.OnMatchThreeChallengeStateUpdate, new Action<int>(this.OnChallengeStateUpdate));
		}

		// Token: 0x0603574A RID: 218954 RVA: 0x00EED35B File Offset: 0x00EEB55B
		public void SetNormalLevelId(int normalLevelId)
		{
			this.NormalLevelId = normalLevelId;
		}

		// Token: 0x0603574B RID: 218955 RVA: 0x00EED364 File Offset: 0x00EEB564
		public override void Refresh(MatchThreeLevel data, bool isSelected, int gridIndex)
		{
			this.LevelConfig = new MatchThreeLevel?(data);
			this.RefreshTitle();
			this.RefreshLockAndComplete();
		}

		// Token: 0x0603574C RID: 218956 RVA: 0x00EED37E File Offset: 0x00EEB57E
		public void SetToggleActive(bool selected)
		{
			this.IsSelected = selected;
			this.RefreshToggleState();
		}

		// Token: 0x0603574D RID: 218957 RVA: 0x00EED390 File Offset: 0x00EEB590
		private void RefreshTitle()
		{
			string textStringId = (this.LevelConfig != null && this.LevelConfig.GetValueOrDefault().Difficulty == 0) ? "Tetristext_06" : "Tetristext_07";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
		}

		// Token: 0x0603574E RID: 218958 RVA: 0x00EED3E8 File Offset: 0x00EEB5E8
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

		// Token: 0x0603574F RID: 218959 RVA: 0x00EED4B4 File Offset: 0x00EEB6B4
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

		// Token: 0x06035750 RID: 218960 RVA: 0x00EED4EF File Offset: 0x00EEB6EF
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

		// Token: 0x06035751 RID: 218961 RVA: 0x00EED527 File Offset: 0x00EEB727
		private void OnChallengeStateUpdate(int challengeId)
		{
			this.RefreshLockAndComplete();
		}

		// Token: 0x06035752 RID: 218962 RVA: 0x00EED52F File Offset: 0x00EEB72F
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnMatchThreeChallengeStateUpdate, new Action<int>(this.OnChallengeStateUpdate));
		}

		// Token: 0x0401C359 RID: 115545
		private MatchThreeLevel? LevelConfig;

		// Token: 0x0401C35A RID: 115546
		private bool IsSelected;

		// Token: 0x0401C35B RID: 115547
		private bool IsPrevFinish = true;

		// Token: 0x0401C35C RID: 115548
		private int NormalLevelId;
	}
}
