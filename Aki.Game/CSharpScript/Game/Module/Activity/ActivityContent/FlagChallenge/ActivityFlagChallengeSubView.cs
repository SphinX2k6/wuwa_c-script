using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.FlagChallenge;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FlagChallenge
{
	// Token: 0x020054F7 RID: 21751
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityFlagChallengeSubView : ActivitySubViewBase
	{
		// Token: 0x06035E6C RID: 220780 RVA: 0x00F0E3C4 File Offset: 0x00F0C5C4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIArtText)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIText))
			};
		}

		// Token: 0x06035E6D RID: 220781 RVA: 0x00F0E4BC File Offset: 0x00F0C6BC
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityFlagChallengeSubView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityFlagChallengeSubView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035E6E RID: 220782 RVA: 0x00F0E4FF File Offset: 0x00F0C6FF
		protected override void OnRefreshView()
		{
			base.GetText(2).ShowTextNew("Morale_32_Activity_DifficultTip");
			this.UpdateGuideQuestState();
			this.UpdateLevelInfo();
			this.UpdateNewLevelTips();
			this.UpdateRemainTime();
			this.UpdateRedDot();
		}

		// Token: 0x06035E6F RID: 220783 RVA: 0x00F0E530 File Offset: 0x00F0C730
		protected override void OnTimer(float gap)
		{
			this.UpdateRemainTime();
		}

		// Token: 0x06035E70 RID: 220784 RVA: 0x00F0E538 File Offset: 0x00F0C738
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnFlagChallengeLevelNewlyUnlock, new Action<int>(this.OnLevelNewlyUnlock));
		}

		// Token: 0x06035E71 RID: 220785 RVA: 0x00F0E556 File Offset: 0x00F0C756
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnFlagChallengeLevelNewlyUnlock, new Action<int>(this.OnLevelNewlyUnlock));
		}

		// Token: 0x06035E72 RID: 220786 RVA: 0x00F0E574 File Offset: 0x00F0C774
		[NullableContext(2)]
		private void OnCommonInfoClick(ActivityBaseData _)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				ActivityController.Instance.OpenActivityContentView(this.ActivityBaseData);
			});
		}

		// Token: 0x06035E73 RID: 220787 RVA: 0x00F0E594 File Offset: 0x00F0C794
		private void UpdateLevelInfo()
		{
			int id = this.ActivityBaseData.Id;
			int fixedLevel = FlagChallengeModel.Instance.GetFixedLevel(id);
			base.GetArtText(7).SetText(fixedLevel.ToString());
			FlagChallengeLevel levelConfig = FlagChallengeModel.Instance.GetFlagChallengeData(id).GetLevelData(FlagChallengeModel.Instance.GetRecommendLevel(id, true).Value).LevelConfig;
			base.GetText(6).ShowTextNew(levelConfig.Name);
		}

		// Token: 0x06035E74 RID: 220788 RVA: 0x00F0E60C File Offset: 0x00F0C80C
		private void UpdateGuideQuestState()
		{
			ActivityFunctionalTypeA functional = this.CommonInfoPanel.GetFunctional();
			if (!this.ActivityBaseData.IsUnLock())
			{
				ActivityButtonItem functionButton = functional.FunctionButton;
				if (functionButton != null)
				{
					functionButton.SetUiActive(false);
				}
				functional.SetPerformanceConditionLock(this.ActivityBaseData.ConditionGroupId, this.ActivityBaseData.Id);
				return;
			}
			bool preGuideQuestFinishState = this.ActivityBaseData.GetPreGuideQuestFinishState();
			if (functional != null)
			{
				functional.SetPanelConditionVisible(false);
			}
			if (preGuideQuestFinishState)
			{
				this.CommonInfoPanel.SetBtnText("Morale_32_Activity_EnterButt", Array.Empty<object>());
				return;
			}
			this.CommonInfoPanel.SetBtnText("Morale_title_36", Array.Empty<object>());
			string preShowGuideQuestName = this.ActivityBaseData.GetPreShowGuideQuestName();
			if (functional != null)
			{
				ActivityButtonItem functionButton2 = functional.FunctionButton;
				if (functionButton2 != null)
				{
					functionButton2.SetUiActive(true);
				}
			}
			if (functional != null)
			{
				functional.SetPanelConditionVisible(true);
			}
			if (functional != null)
			{
				functional.SetLockSpriteVisible(false);
			}
			if (functional != null)
			{
				functional.SetLockConditionButtonVisible(false);
			}
			if (functional != null)
			{
				functional.SetLockTextByTextId("Morale_title_35", new string[]
				{
					preShowGuideQuestName
				});
			}
		}

		// Token: 0x06035E75 RID: 220789 RVA: 0x00F0E6FC File Offset: 0x00F0C8FC
		private void UpdateNewLevelTips()
		{
			bool active = this.IsShowNewLevelTips();
			this.NewLevelTipsSubPanel.SetActive(active);
		}

		// Token: 0x06035E76 RID: 220790 RVA: 0x00F0E71C File Offset: 0x00F0C91C
		private bool IsShowNewLevelTips()
		{
			ActivityBaseData activityBaseData = this.ActivityBaseData;
			return activityBaseData.IsUnLock() && activityBaseData.GetPreGuideQuestFinishState() && FlagChallengeModel.Instance.GetFlagChallengeData(activityBaseData.Id).HasLevelNewlyUnlocked();
		}

		// Token: 0x06035E77 RID: 220791 RVA: 0x00F0E75C File Offset: 0x00F0C95C
		private void UpdateRemainTime()
		{
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.ActivityBaseData.EndShowTime, this.RemainTimeFormatText);
			UUIText text = base.GetText(9);
			if (text == null)
			{
				return;
			}
			text.SetText(remainTimeText, true);
		}

		// Token: 0x06035E78 RID: 220792 RVA: 0x00F0E799 File Offset: 0x00F0C999
		private void UpdateRedDot()
		{
			ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
			ActivityFunctionalTypeA activityFunctionalTypeA = (commonInfoPanel != null) ? commonInfoPanel.GetFunctional() : null;
			if (activityFunctionalTypeA == null)
			{
				return;
			}
			activityFunctionalTypeA.SetFunctionRedDotVisible(this.IsShowNewLevelTips());
		}

		// Token: 0x06035E79 RID: 220793 RVA: 0x00F0E7BD File Offset: 0x00F0C9BD
		private void OnLevelNewlyUnlock(int levelId)
		{
			this.UpdateNewLevelTips();
			this.UpdateRedDot();
		}

		// Token: 0x06035E7A RID: 220794 RVA: 0x00F0E7CC File Offset: 0x00F0C9CC
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (!(configParams[0] == "Chaqi_ConfirmBtn"))
			{
				return null;
			}
			UUIItem functionalButtonItem = this.CommonInfoPanel.GetFunctionalButtonItem();
			if (functionalButtonItem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				functionalButtonItem,
				functionalButtonItem
			};
		}

		// Token: 0x0401C7ED RID: 116717
		private ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x0401C7EE RID: 116718
		private FlagChallengeActivityRewardEntranceItem RewardEntrance;

		// Token: 0x0401C7EF RID: 116719
		private RecommendQuestTipsSubPanel NewLevelTipsSubPanel;

		// Token: 0x0401C7F0 RID: 116720
		private string RemainTimeFormatText = "";
	}
}
