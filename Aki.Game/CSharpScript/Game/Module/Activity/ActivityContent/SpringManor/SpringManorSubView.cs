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
	// Token: 0x02006090 RID: 24720
	[NullableContext(2)]
	[Nullable(0)]
	public class SpringManorSubView : ActivitySubViewBase
	{
		// Token: 0x17009077 RID: 36983
		// (get) Token: 0x0603E7CC RID: 255948 RVA: 0x00F1A872 File Offset: 0x00F18A72
		protected new SpringManorData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as SpringManorData;
			}
		}

		// Token: 0x0603E7CD RID: 255949 RVA: 0x00F1A880 File Offset: 0x00F18A80
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

		// Token: 0x0603E7CE RID: 255950 RVA: 0x00F1A9B0 File Offset: 0x00F18BB0
		protected override UniTask OnBeforeStartAsync()
		{
			SpringManorSubView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpringManorSubView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E7CF RID: 255951 RVA: 0x00F1A9F3 File Offset: 0x00F18BF3
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

		// Token: 0x0603E7D0 RID: 255952 RVA: 0x00F1AA22 File Offset: 0x00F18C22
		protected override void OnBeforeShow()
		{
			this.OnRefreshView();
		}

		// Token: 0x0603E7D1 RID: 255953 RVA: 0x00F1AA2A File Offset: 0x00F18C2A
		protected override void OnRefreshView()
		{
			this.RefreshAtmosphere();
			this.RefreshReward();
			this.RefreshInfo();
		}

		// Token: 0x0603E7D2 RID: 255954 RVA: 0x00F1AA3E File Offset: 0x00F18C3E
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
		}

		// Token: 0x0603E7D3 RID: 255955 RVA: 0x00F1AA5C File Offset: 0x00F18C5C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
		}

		// Token: 0x0603E7D4 RID: 255956 RVA: 0x00F1AA7C File Offset: 0x00F18C7C
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

		// Token: 0x0603E7D5 RID: 255957 RVA: 0x00F1AACC File Offset: 0x00F18CCC
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

		// Token: 0x0603E7D6 RID: 255958 RVA: 0x00F1AB18 File Offset: 0x00F18D18
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

		// Token: 0x0603E7D7 RID: 255959 RVA: 0x00F1AC2C File Offset: 0x00F18E2C
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

		// Token: 0x0603E7D8 RID: 255960 RVA: 0x00F1AC8E File Offset: 0x00F18E8E
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

		// Token: 0x0603E7D9 RID: 255961 RVA: 0x00F1ACCC File Offset: 0x00F18ECC
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

		// Token: 0x0603E7DA RID: 255962 RVA: 0x00F1AD4E File Offset: 0x00F18F4E
		private void OnClickRewardBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.SpringManorRewardView, null, null);
		}

		// Token: 0x0603E7DB RID: 255963 RVA: 0x00F1AD61 File Offset: 0x00F18F61
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

		// Token: 0x0603E7DC RID: 255964 RVA: 0x00F1AD80 File Offset: 0x00F18F80
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

		// Token: 0x04020B3B RID: 133947
		private ActivitySubViewGeneralInfo InfoItem;
	}
}
