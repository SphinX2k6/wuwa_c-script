using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x0200666A RID: 26218
	public class EncircleLevelDetailGridView : GridProxyAbstract<int>
	{
		// Token: 0x06041B52 RID: 269138 RVA: 0x00FEF378 File Offset: 0x00FED578
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickedEnterButton))
			};
		}

		// Token: 0x06041B53 RID: 269139 RVA: 0x00FEF463 File Offset: 0x00FED663
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

		// Token: 0x06041B54 RID: 269140 RVA: 0x00FEF48D File Offset: 0x00FED68D
		protected void AddEventListener()
		{
			EventSystem.Instance.Add<EncircleChallengePb>(EEventName.EncircleDataUpdate, new Action<EncircleChallengePb>(this.OnEncircleDataUpdate));
		}

		// Token: 0x06041B55 RID: 269141 RVA: 0x00FEF4AB File Offset: 0x00FED6AB
		protected void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.EncircleDataUpdate, new Action<EncircleChallengePb>(this.OnEncircleDataUpdate));
		}

		// Token: 0x06041B56 RID: 269142 RVA: 0x00FEF4C9 File Offset: 0x00FED6C9
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.RefreshView(data);
			this.RefreshDesc();
		}

		// Token: 0x06041B57 RID: 269143 RVA: 0x00FEF4D8 File Offset: 0x00FED6D8
		public int? GetChallengeDifficulty()
		{
			if (this.ChallengeConfig == null)
			{
				return null;
			}
			return new int?(this.ChallengeConfig.Value.Difficulty);
		}

		// Token: 0x06041B58 RID: 269144 RVA: 0x00FEF514 File Offset: 0x00FED714
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

		// Token: 0x06041B59 RID: 269145 RVA: 0x00FEF56C File Offset: 0x00FED76C
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

		// Token: 0x06041B5A RID: 269146 RVA: 0x00FEF604 File Offset: 0x00FED804
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

		// Token: 0x06041B5B RID: 269147 RVA: 0x00FEF678 File Offset: 0x00FED878
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

		// Token: 0x06041B5C RID: 269148 RVA: 0x00FEF6F1 File Offset: 0x00FED8F1
		public void SetToggleActive()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			}
			this.SetClickRedDotState();
		}

		// Token: 0x06041B5D RID: 269149 RVA: 0x00FEF710 File Offset: 0x00FED910
		[NullableContext(1)]
		private void OnEncircleDataUpdate(EncircleChallengePb newData)
		{
			this.RefreshView(this.ChallengeId);
		}

		// Token: 0x06041B5E RID: 269150 RVA: 0x00FEF720 File Offset: 0x00FED920
		private void OnClickToggleOnUndetermined()
		{
			string levelTitle = ActivityEncircleConfig.Instance.GetEncircleChallengeConfig(this.ChallengeConfig.Value.PreId).Value.LevelTitle;
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(levelTitle, levelTitle);
			ScrollingTipsController.Instance.ShowTipsByTextId("Encirle_DifficultyLockTips_Text", new object[]
			{
				multiTextByKey
			});
		}

		// Token: 0x06041B5F RID: 269151 RVA: 0x00FEF784 File Offset: 0x00FED984
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

		// Token: 0x06041B60 RID: 269152 RVA: 0x00FEF7E0 File Offset: 0x00FED9E0
		public void SetClickRedDotState()
		{
			int activityId = ActivityEncircleController.Instance.ActivityId;
			ActivityModel.Instance.SaveActivityData(activityId, 10001, this.ChallengeId, 0, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}

		// Token: 0x06041B61 RID: 269153 RVA: 0x00FEF821 File Offset: 0x00FEDA21
		protected override void OnBeforeDestroy()
		{
			this.RemoveEventListener();
		}

		// Token: 0x040222EA RID: 140010
		private int ChallengeId;

		// Token: 0x040222EB RID: 140011
		private bool IsFinish;

		// Token: 0x040222EC RID: 140012
		private bool IsPrevFinish;

		// Token: 0x040222ED RID: 140013
		private EncircleChallenge? ChallengeConfig;
	}
}
