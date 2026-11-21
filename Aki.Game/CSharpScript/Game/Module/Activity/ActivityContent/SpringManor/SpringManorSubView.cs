using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x0200500E RID: 20494
	[NullableContext(2)]
	[Nullable(0)]
	public class SpringManorSubView : ActivitySubViewBase
	{
		// Token: 0x170063D9 RID: 25561
		// (get) Token: 0x06033490 RID: 210064 RVA: 0x00E61636 File Offset: 0x00E5F836
		protected new SpringManorData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as SpringManorData;
			}
		}

		// Token: 0x06033491 RID: 210065 RVA: 0x00E61644 File Offset: 0x00E5F844
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIArtText)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUISprite)),
				new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(9, typeof(UUIText)),
				new ValueTuple<int, Type>(10, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(8, new Action(this.OnClickRewardBtn))
			};
		}

		// Token: 0x06033492 RID: 210066 RVA: 0x00E61774 File Offset: 0x00E5F974
		protected override UniTask OnBeforeStartAsync()
		{
			SpringManorSubView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpringManorSubView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033493 RID: 210067 RVA: 0x00E617B7 File Offset: 0x00E5F9B7
		protected override void OnStart()
		{
			ActivitySubViewGeneralInfo infoItem = this.InfoItem;
			if (infoItem != null)
			{
				infoItem.SetClickFunc(new Action<ActivityBaseData>(this.OnClickEnter));
			}
			SpringManorData activityBaseData = this.ActivityBaseData;
			if (activityBaseData == null)
			{
				return;
			}
			activityBaseData.ReadFirstOpenRedDot();
		}

		// Token: 0x06033494 RID: 210068 RVA: 0x00E617E6 File Offset: 0x00E5F9E6
		protected override void OnBeforeShow()
		{
			this.OnRefreshView();
		}

		// Token: 0x06033495 RID: 210069 RVA: 0x00E617EE File Offset: 0x00E5F9EE
		protected override void OnRefreshView()
		{
			this.RefreshAtmosphere();
			this.RefreshReward();
			this.RefreshInfo();
		}

		// Token: 0x06033496 RID: 210070 RVA: 0x00E61802 File Offset: 0x00E5FA02
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
		}

		// Token: 0x06033497 RID: 210071 RVA: 0x00E61820 File Offset: 0x00E5FA20
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
		}

		// Token: 0x06033498 RID: 210072 RVA: 0x00E61840 File Offset: 0x00E5FA40
		private void OnRefreshRedDot(int activityId)
		{
			SpringManorData activityBaseData = this.ActivityBaseData;
			int? num = (activityBaseData != null) ? new int?(activityBaseData.Id) : null;
			if (!(activityId == num.GetValueOrDefault() & num != null))
			{
				return;
			}
			this.RefreshReward();
			this.RefreshInfo();
		}

		// Token: 0x06033499 RID: 210073 RVA: 0x00E61890 File Offset: 0x00E5FA90
		private void RefreshInfo()
		{
			string textId;
			if (this.ActivityBaseData.GetPreGuideQuestFinishState())
			{
				textId = "Spring26_Entrance_Button";
			}
			else
			{
				textId = "JumpToQuestText";
			}
			ActivitySubViewGeneralInfo infoItem = this.InfoItem;
			if (infoItem != null)
			{
				infoItem.SetBtnText(textId, Array.Empty<object>());
			}
			this.RefreshFuncButtonRedDot();
		}

		// Token: 0x0603349A RID: 210074 RVA: 0x00E618DC File Offset: 0x00E5FADC
		private void RefreshAtmosphere()
		{
			SpringManorData activityBaseData = this.ActivityBaseData;
			bool flag = activityBaseData != null && activityBaseData.IsUnLock();
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (!flag)
			{
				return;
			}
			SpringManorModel instance = SpringManorModel.Instance;
			int atmosphereLevel = instance.GetAtmosphereLevel();
			int atmosphere = instance.ActivityData.GetAtmosphere();
			int nextLevel = instance.GetNextLevel();
			int levelNeedExp = instance.GetLevelNeedExp(nextLevel);
			this.RefreshAtmosphereProgressText(atmosphereLevel, atmosphere, levelNeedExp);
			SpringManorConfig instance2 = SpringManorConfig.Instance;
			AtmosphereLevel? atmosphereLevel2 = (instance2 != null) ? instance2.GetLevelConfigById(atmosphereLevel) : null;
			if (atmosphereLevel2 == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module = ELogModule.SpringManor;
				ELogAuthor author = ELogAuthor.LJ;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
				defaultInterpolatedStringHandler.AppendLiteral("获取不到等级配置！");
				defaultInterpolatedStringHandler.AppendFormatted<int>(atmosphereLevel);
				instance3.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			int num = MathUtils.Instance.Clamp((atmosphere - atmosphereLevel2.Value.AtmosphereNeed) / atmosphereLevel2.Value.AtmosphereNext, 0, 1);
			UUISprite sprite = base.GetSprite(7);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount((float)num);
		}

		// Token: 0x0603349B RID: 210075 RVA: 0x00E619F0 File Offset: 0x00E5FBF0
		private void RefreshAtmosphereProgressText(int curLevel, int curProgress, int targetProgress)
		{
			UUIArtText artText = base.GetArtText(4);
			if (artText != null)
			{
				artText.SetText(curLevel.ToString());
			}
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetText(curProgress.ToString(), true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Spring26_Atmosphere_TargetProgress", new <>z__ReadOnlySingleElementList<object>(targetProgress.ToString()));
		}

		// Token: 0x0603349C RID: 210076 RVA: 0x00E61A52 File Offset: 0x00E5FC52
		private void RefreshFuncButtonRedDot()
		{
			SpringManorData activityBaseData = this.ActivityBaseData;
			if (activityBaseData == null || !activityBaseData.IsUnLock())
			{
				return;
			}
			ActivitySubViewGeneralInfo infoItem = this.InfoItem;
			if (infoItem == null)
			{
				return;
			}
			SpringManorData activityBaseData2 = this.ActivityBaseData;
			infoItem.SetFunctionRedDotVisible(activityBaseData2 != null && activityBaseData2.HasActivityRedDot());
		}

		// Token: 0x0603349D RID: 210077 RVA: 0x00E61A90 File Offset: 0x00E5FC90
		private void RefreshReward()
		{
			int currentRewardTaskProgress = this.ActivityBaseData.GetCurrentRewardTaskProgress();
			int totalRewardTaskProgress = this.ActivityBaseData.GetTotalRewardTaskProgress();
			UUIText text = base.GetText(9);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(currentRewardTaskProgress);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(totalRewardTaskProgress);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			UUIItem item = base.GetItem(10);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.ActivityBaseData.HasRewardRedDot());
		}

		// Token: 0x0603349E RID: 210078 RVA: 0x00E61B12 File Offset: 0x00E5FD12
		private void OnClickRewardBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.SpringManorRewardView, null, null);
		}

		// Token: 0x0603349F RID: 210079 RVA: 0x00E61B25 File Offset: 0x00E5FD25
		private void OnClickEnter(ActivityBaseData _)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
				{
					int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
					UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
					return;
				}
				GameModeModel instance = GameModeModel.Instance;
				if (instance != null && instance.IsMulti)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_2000015_Text", Array.Empty<object>());
					return;
				}
				if (QuestNewModel.Instance.IsInFocusMode())
				{
					ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.CloseFocusQuestTips);
					confirmBoxDataNew.FunctionMap.Add(2, delegate
					{
						int curFocusQuestId = QuestNewModel.Instance.GetCurFocusQuestId();
						QuestNewController.Instance.RequestCancelQuestFocusMode(curFocusQuestId, delegate
						{
							SpringManorController instance3 = SpringManorController.Instance;
							if (instance3 == null)
							{
								return;
							}
							instance3.EnterBigWorldInstRequestAndUnTrackQuest();
						});
					});
					ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
					return;
				}
				SpringManorController instance2 = SpringManorController.Instance;
				if (instance2 == null)
				{
					return;
				}
				instance2.EnterBigWorldInstRequestAndUnTrackQuest();
			});
		}

		// Token: 0x060334A0 RID: 210080 RVA: 0x00E61B44 File Offset: 0x00E5FD44
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			if (!(configParams[0] == "Spring_ConfirmBtn"))
			{
				return null;
			}
			ActivitySubViewGeneralInfo infoItem = this.InfoItem;
			UUIItem uuiitem = (infoItem != null) ? infoItem.GetFunctionalButtonItem() : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x0401B468 RID: 111720
		private ActivitySubViewGeneralInfo InfoItem;
	}
}
