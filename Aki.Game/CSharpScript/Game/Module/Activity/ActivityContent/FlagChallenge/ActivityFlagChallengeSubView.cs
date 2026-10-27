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
	// Token: 0x02006579 RID: 25977
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityFlagChallengeSubView : ActivitySubViewBase
	{
		// Token: 0x060411A7 RID: 266663 RVA: 0x00FC73E0 File Offset: 0x00FC55E0
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

		// Token: 0x060411A8 RID: 266664 RVA: 0x00FC74D8 File Offset: 0x00FC56D8
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityFlagChallengeSubView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityFlagChallengeSubView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060411A9 RID: 266665 RVA: 0x00FC751B File Offset: 0x00FC571B
		protected override void OnRefreshView()
		{
			base.GetText(2).ShowTextNew("Morale_32_Activity_DifficultTip");
			this.UpdateGuideQuestState();
			this.UpdateLevelInfo();
			this.UpdateNewLevelTips();
			this.UpdateRemainTime();
			this.UpdateRedDot();
		}

		// Token: 0x060411AA RID: 266666 RVA: 0x00FC754C File Offset: 0x00FC574C
		protected override void OnTimer(float gap)
		{
			this.UpdateRemainTime();
		}

		// Token: 0x060411AB RID: 266667 RVA: 0x00FC7554 File Offset: 0x00FC5754
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnFlagChallengeLevelNewlyUnlock, new Action<int>(this.OnLevelNewlyUnlock));
		}

		// Token: 0x060411AC RID: 266668 RVA: 0x00FC7572 File Offset: 0x00FC5772
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnFlagChallengeLevelNewlyUnlock, new Action<int>(this.OnLevelNewlyUnlock));
		}

		// Token: 0x060411AD RID: 266669 RVA: 0x00FC7590 File Offset: 0x00FC5790
		[NullableContext(2)]
		private void OnCommonInfoClick(ActivityBaseData _)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				ActivityController.Instance.OpenActivityContentView(this.ActivityBaseData);
			});
		}

		// Token: 0x060411AE RID: 266670 RVA: 0x00FC75B0 File Offset: 0x00FC57B0
		private void UpdateLevelInfo()
		{
			int id = this.ActivityBaseData.Id;
			int fixedLevel = FlagChallengeModel.Instance.GetFixedLevel(id);
			base.GetArtText(7).SetText(fixedLevel.ToString());
			FlagChallengeLevel levelConfig = FlagChallengeModel.Instance.GetFlagChallengeData(id).GetLevelData(FlagChallengeModel.Instance.GetRecommendLevel(id, true).Value).LevelConfig;
			base.GetText(6).ShowTextNew(levelConfig.Name);
		}

		// Token: 0x060411AF RID: 266671 RVA: 0x00FC7628 File Offset: 0x00FC5828
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

		// Token: 0x060411B0 RID: 266672 RVA: 0x00FC7718 File Offset: 0x00FC5918
		private void UpdateNewLevelTips()
		{
			bool active = this.IsShowNewLevelTips();
			this.NewLevelTipsSubPanel.SetActive(active);
		}

		// Token: 0x060411B1 RID: 266673 RVA: 0x00FC7738 File Offset: 0x00FC5938
		private bool IsShowNewLevelTips()
		{
			ActivityBaseData activityBaseData = this.ActivityBaseData;
			return activityBaseData.IsUnLock() && activityBaseData.GetPreGuideQuestFinishState() && FlagChallengeModel.Instance.GetFlagChallengeData(activityBaseData.Id).HasLevelNewlyUnlocked();
		}

		// Token: 0x060411B2 RID: 266674 RVA: 0x00FC7778 File Offset: 0x00FC5978
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

		// Token: 0x060411B3 RID: 266675 RVA: 0x00FC77B5 File Offset: 0x00FC59B5
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

		// Token: 0x060411B4 RID: 266676 RVA: 0x00FC77D9 File Offset: 0x00FC59D9
		private void OnLevelNewlyUnlock(int levelId)
		{
			this.UpdateNewLevelTips();
			this.UpdateRedDot();
		}

		// Token: 0x060411B5 RID: 266677 RVA: 0x00FC77E8 File Offset: 0x00FC59E8
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

		// Token: 0x04021EBC RID: 138940
		private ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x04021EBD RID: 138941
		private FlagChallengeActivityRewardEntranceItem RewardEntrance;

		// Token: 0x04021EBE RID: 138942
		private RecommendQuestTipsSubPanel NewLevelTipsSubPanel;

		// Token: 0x04021EBF RID: 138943
		private string RemainTimeFormatText = "";
	}
}
