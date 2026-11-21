using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x0200560D RID: 22029
	[NullableContext(2)]
	[Nullable(0)]
	public class DropCatchLevelSelectView : UiViewBase
	{
		// Token: 0x060367CA RID: 223178 RVA: 0x00F34F63 File Offset: 0x00F33163
		[NullableContext(1)]
		public DropCatchLevelSelectView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060367CB RID: 223179 RVA: 0x00F34F78 File Offset: 0x00F33178
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIArtText)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUITexture)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUIItem)),
				new ValueTuple<int, Type>(15, typeof(UUIText)),
				new ValueTuple<int, Type>(16, typeof(UUIItem)),
				new ValueTuple<int, Type>(17, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(18, typeof(USpineSkeletonAnimationComponent)),
				new ValueTuple<int, Type>(19, typeof(UUIItem)),
				new ValueTuple<int, Type>(20, typeof(UUITexture)),
				new ValueTuple<int, Type>(21, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(7, new Action(this.OnClickChallenge)),
				new ValueTuple<int, Delegate>(9, new Action(this.OnClickCustom))
			};
		}

		// Token: 0x060367CC RID: 223180 RVA: 0x00F351C0 File Offset: 0x00F333C0
		protected override UniTask OnBeforeStartAsync()
		{
			DropCatchLevelSelectView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DropCatchLevelSelectView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060367CD RID: 223181 RVA: 0x00F35204 File Offset: 0x00F33404
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.InitCaption();
			this.LevelScrollView = new GenericScrollViewNew<DropCatchLevelItem, IDropCatchLevelItemData>(base.GetScrollViewWithScrollbar(17), new Func<DropCatchLevelItem>(this.InitLevelItem), null, false, null);
			this.PreviewLayout = new GenericLayout<DropCatchRewardPreviewItem, IDropCatchRewardPreviewData>(base.GetVerticalLayout(3), new Func<DropCatchRewardPreviewItem>(this.InitPreviewItem), null, false, true);
			base.GetSpine(18).SetAnimation(0, EDropCatchRobotAnimState.IdleRight.ToEnumString(), true);
		}

		// Token: 0x060367CE RID: 223182 RVA: 0x00F35284 File Offset: 0x00F33484
		protected override void OnBeforeShow()
		{
			this.Data = (ActivityModel.Instance.GetActivityById(DropCatchActivityController.Instance.ActivityId) as DropCatchActivityData);
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem != null)
			{
				DropCatchActivityData data = this.Data;
				captionItem.SetTitle((data != null) ? data.GetTitle() : null);
			}
			DropCatchActivityData data2 = this.Data;
			this.CurLevelCfgId = ((data2 != null) ? data2.GetDefaultOpenCfgId() : 0);
			this.RefreshLevelItems();
			this.UpdateCurLevelContent();
			this.UpdateRoleInfo().Forget();
		}

		// Token: 0x060367CF RID: 223183 RVA: 0x00F35302 File Offset: 0x00F33502
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.DropCatchActivityRewardUpdate, new Action(this.UpdateCurLevelContent));
			EventSystem.Instance.Add(EEventName.ActivityCrossDayRefresh, new Action(this.UpdateCurLevelContent));
		}

		// Token: 0x060367D0 RID: 223184 RVA: 0x00F3533C File Offset: 0x00F3353C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.DropCatchActivityRewardUpdate, new Action(this.UpdateCurLevelContent));
			EventSystem.Instance.Remove(EEventName.ActivityCrossDayRefresh, new Action(this.UpdateCurLevelContent));
		}

		// Token: 0x060367D1 RID: 223185 RVA: 0x00F35376 File Offset: 0x00F33576
		protected override void OnBeforeHide()
		{
			this.ClearCountdownTimer();
		}

		// Token: 0x060367D2 RID: 223186 RVA: 0x00F35380 File Offset: 0x00F33580
		private UniTask UpdateRoleInfo()
		{
			DropCatchLevelSelectView.<UpdateRoleInfo>d__18 <UpdateRoleInfo>d__;
			<UpdateRoleInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateRoleInfo>d__.<>4__this = this;
			<UpdateRoleInfo>d__.<>1__state = -1;
			<UpdateRoleInfo>d__.<>t__builder.Start<DropCatchLevelSelectView.<UpdateRoleInfo>d__18>(ref <UpdateRoleInfo>d__);
			return <UpdateRoleInfo>d__.<>t__builder.Task;
		}

		// Token: 0x060367D3 RID: 223187 RVA: 0x00F353C4 File Offset: 0x00F335C4
		private void OnClickChallenge()
		{
			DropCatchActivityData data = this.Data;
			if (data != null && data.CheckIfClose())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_ErrCoinCatchNotOpen", Array.Empty<object>());
				return;
			}
			if (GameModeModel.Instance.IsMulti)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Trapdefence_NoOlineTpye", Array.Empty<object>());
				return;
			}
			DropCatchGameplayController.Instance.StartGameplay(this.CurLevelCfgId);
		}

		// Token: 0x060367D4 RID: 223188 RVA: 0x00F3542C File Offset: 0x00F3362C
		private void OnClickCustom()
		{
			DropCatchGameplay? dropCatchGameplayById = DropCatchConfig.Instance.GetDropCatchGameplayById(this.CurLevelCfgId);
			if (dropCatchGameplayById == null)
			{
				return;
			}
			Dictionary<string, object> param = new Dictionary<string, object>
			{
				{
					"OpenRoleConfigId",
					dropCatchGameplayById.Value.RoleId
				}
			};
			UiManager.Instance.OpenView(EUiViewName.DropCatchRoleDetailView, param, null);
		}

		// Token: 0x060367D5 RID: 223189 RVA: 0x00F3548A File Offset: 0x00F3368A
		private void UpdateCurLevelContent()
		{
			this.RefreshLevelItems();
			this.SwitchContent(this.CurLevelCfgId);
		}

		// Token: 0x060367D6 RID: 223190 RVA: 0x00F354A0 File Offset: 0x00F336A0
		private void InitCaption()
		{
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				this.CaptionItem = new PopupCaptionItem(item);
				this.CaptionItem.SetCloseCallBack(delegate
				{
					base.CloseMe(null);
				});
				PopupCaptionItem captionItem = this.CaptionItem;
				if (captionItem == null)
				{
					return;
				}
				captionItem.SetHelpCallBack(new Action(this.OnClickMoreButton));
			}
		}

		// Token: 0x060367D7 RID: 223191 RVA: 0x00F354F7 File Offset: 0x00F336F7
		[NullableContext(1)]
		private DropCatchLevelItem InitLevelItem()
		{
			DropCatchLevelItem dropCatchLevelItem = new DropCatchLevelItem();
			dropCatchLevelItem.SetClickCallback(new Action<int, int>(this.OnLevelItemClick));
			return dropCatchLevelItem;
		}

		// Token: 0x060367D8 RID: 223192 RVA: 0x00F35510 File Offset: 0x00F33710
		[NullableContext(1)]
		private DropCatchRewardPreviewItem InitPreviewItem()
		{
			DropCatchRewardPreviewItem dropCatchRewardPreviewItem = new DropCatchRewardPreviewItem();
			dropCatchRewardPreviewItem.SetClickCallback(new Action<int>(this.OnPreviewItemClick));
			return dropCatchRewardPreviewItem;
		}

		// Token: 0x060367D9 RID: 223193 RVA: 0x00F3552C File Offset: 0x00F3372C
		private void OnClickMoreButton()
		{
			DropCatchActivityData data = this.Data;
			int? num = (data != null) ? new int?(data.GetHelpId()) : null;
			HelpController.Instance.OpenHelpById(num.GetValueOrDefault());
		}

		// Token: 0x060367DA RID: 223194 RVA: 0x00F3556A File Offset: 0x00F3376A
		private void OnPreviewItemClick(int _)
		{
			DropCatchActivityData data = this.Data;
			if (data != null && data.CheckIfClose())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_ErrCoinCatchNotOpen", Array.Empty<object>());
				return;
			}
			DropCatchActivityController.Instance.RequestLevelReward(this.CurLevelCfgId);
		}

		// Token: 0x060367DB RID: 223195 RVA: 0x00F355A8 File Offset: 0x00F337A8
		private void OnLevelItemClick(int cfgId, int index)
		{
			this.CurLevelCfgId = cfgId;
			this.CurLevelIndex = index;
			GenericScrollViewNew<DropCatchLevelItem, IDropCatchLevelItemData> levelScrollView = this.LevelScrollView;
			if (levelScrollView != null)
			{
				levelScrollView.SelectGridProxy(this.CurLevelIndex, false);
			}
			GenericScrollViewNew<DropCatchLevelItem, IDropCatchLevelItemData> levelScrollView2 = this.LevelScrollView;
			UUIItem uuiitem = (levelScrollView2 != null) ? levelScrollView2.GetItemByIndex(this.CurLevelIndex) : null;
			if (uuiitem != null)
			{
				GenericScrollViewNew<DropCatchLevelItem, IDropCatchLevelItemData> levelScrollView3 = this.LevelScrollView;
				if (levelScrollView3 != null)
				{
					levelScrollView3.LateScrollTo(uuiitem, null, false);
				}
			}
			this.SwitchContent(this.CurLevelCfgId);
			this.SequencePlayer.PlayOrReplaySequenceByName("Switch", false, null);
			this.UpdateRoleInfo().Forget();
		}

		// Token: 0x060367DC RID: 223196 RVA: 0x00F3563C File Offset: 0x00F3383C
		private void RefreshLevelItems()
		{
			IReadOnlyList<DropCatchGameplay> dropCatchGameplayByActivityId = DropCatchConfig.Instance.GetDropCatchGameplayByActivityId(this.Data.Id);
			if (dropCatchGameplayByActivityId == null || dropCatchGameplayByActivityId.Count == 0)
			{
				return;
			}
			this.LevelDataList.Clear();
			this.CurLevelIndex = 0;
			for (int i = 0; i < dropCatchGameplayByActivityId.Count; i++)
			{
				DropCatchGameplay dropCatchGameplay = dropCatchGameplayByActivityId[i];
				DropCatchActivityData data = this.Data;
				DropCatchLevelData dropCatchLevelData = (data != null) ? data.GetLevelData(dropCatchGameplay.Id) : null;
				if (dropCatchLevelData != null)
				{
					EDropCatchLevelState value = EDropCatchLevelState.Lock;
					if (dropCatchLevelData.IsAllRewarded)
					{
						value = EDropCatchLevelState.Rewarded;
					}
					else if (dropCatchLevelData.IsUnlock)
					{
						if (i > 0)
						{
							DropCatchLevelData lastLevelData = this.Data.GetLastLevelData(dropCatchGameplay.Id);
							if (lastLevelData != null && lastLevelData.HasAnyStar)
							{
								value = EDropCatchLevelState.Unlock;
							}
						}
						else
						{
							value = EDropCatchLevelState.Unlock;
						}
					}
					DropCatchLevelItemData item = new DropCatchLevelItemData
					{
						CfgId = dropCatchGameplay.Id,
						HasRedPoint = dropCatchLevelData.CanReceiveReward,
						State = new EDropCatchLevelState?(value)
					};
					if (this.CurLevelCfgId == dropCatchGameplay.Id)
					{
						this.CurLevelIndex = i;
					}
					this.LevelDataList.Add(item);
				}
			}
			GenericScrollViewNew<DropCatchLevelItem, IDropCatchLevelItemData> levelScrollView = this.LevelScrollView;
			if (levelScrollView == null)
			{
				return;
			}
			levelScrollView.RefreshByData(this.LevelDataList, delegate
			{
				GenericScrollViewNew<DropCatchLevelItem, IDropCatchLevelItemData> levelScrollView2 = this.LevelScrollView;
				if (levelScrollView2 != null)
				{
					levelScrollView2.SelectGridProxy(this.CurLevelIndex, false);
				}
				GenericScrollViewNew<DropCatchLevelItem, IDropCatchLevelItemData> levelScrollView3 = this.LevelScrollView;
				UUIItem uuiitem = (levelScrollView3 != null) ? levelScrollView3.GetItemByIndex(this.CurLevelIndex) : null;
				if (uuiitem != null)
				{
					GenericScrollViewNew<DropCatchLevelItem, IDropCatchLevelItemData> levelScrollView4 = this.LevelScrollView;
					if (levelScrollView4 == null)
					{
						return;
					}
					levelScrollView4.LateScrollTo(uuiitem, null, false);
				}
			}, false);
		}

		// Token: 0x060367DD RID: 223197 RVA: 0x00F35774 File Offset: 0x00F33974
		private void SwitchContent(int cfgId)
		{
			this.RefreshCenterContent();
			this.RefreshPreviewContent(cfgId);
		}

		// Token: 0x060367DE RID: 223198 RVA: 0x00F35783 File Offset: 0x00F33983
		private IDropCatchLevelItemData GetCurShowLevelInfo()
		{
			if (this.LevelDataList != null && this.CurLevelIndex < this.LevelDataList.Count)
			{
				return this.LevelDataList[this.CurLevelIndex];
			}
			return null;
		}

		// Token: 0x060367DF RID: 223199 RVA: 0x00F357B4 File Offset: 0x00F339B4
		private void RefreshCenterContent()
		{
			this.ClearCountdownTimer();
			IDropCatchLevelItemData curShowLevelInfo = this.GetCurShowLevelInfo();
			if (curShowLevelInfo == null)
			{
				return;
			}
			DropCatchActivityData data = this.Data;
			DropCatchLevelData dropCatchLevelData = (data != null) ? data.GetLevelData(curShowLevelInfo.CfgId) : null;
			if (dropCatchLevelData == null)
			{
				return;
			}
			base.GetArtText(5).SetText(dropCatchLevelData.HighestScore.ToString().PadLeft(5, '0'));
			EDropCatchLevelState? state = curShowLevelInfo.State;
			EDropCatchLevelState edropCatchLevelState = EDropCatchLevelState.Lock;
			bool flag = state.GetValueOrDefault() == edropCatchLevelState & state != null;
			bool flag2 = curShowLevelInfo.State.GetValueOrDefault() == EDropCatchLevelState.Unlock;
			bool flag3 = curShowLevelInfo.State.GetValueOrDefault() == EDropCatchLevelState.Rewarded;
			base.GetItem(14).SetUIActive(flag2 || flag3);
			base.GetItem(16).SetUIActive(flag);
			base.GetItem(11).SetUIActive(!flag);
			base.GetItem(8).SetUIActive(flag);
			base.GetItem(10).SetUIActive(flag);
			base.GetButton(7).RootUIComp.Get().SetUIActive(!flag);
			DropCatchGameplay? dropCatchGameplayById = DropCatchConfig.Instance.GetDropCatchGameplayById(curShowLevelInfo.CfgId);
			if (flag)
			{
				this.RefreshLockTips(curShowLevelInfo.CfgId);
			}
			if (dropCatchGameplayById != null)
			{
				bool flag4 = DropCatchActivityController.Instance.IsNewRoleClicked(dropCatchGameplayById.Value.RoleId);
				base.GetItem(13).SetUIActive(!flag && flag4);
				base.GetText(15).ShowTextNew(dropCatchGameplayById.Value.Desc);
				DropCatchRole? dropCatchRoleById = DropCatchConfig.Instance.GetDropCatchRoleById(dropCatchGameplayById.Value.RoleId);
				if (dropCatchRoleById != null)
				{
					if (flag)
					{
						base.GetText(6).ShowTextNew("CoinCatch_Character_UnlockName");
					}
					else
					{
						base.GetText(6).ShowTextNew(dropCatchRoleById.Value.Name);
					}
					base.SetTextureByPath(dropCatchRoleById.Value.RoleTexturePath, base.GetTexture(12), null, null);
					base.SetTextureByPath(dropCatchRoleById.Value.SilhouettePath, base.GetTexture(20), null, null);
				}
			}
		}

		// Token: 0x060367E0 RID: 223200 RVA: 0x00F359E4 File Offset: 0x00F33BE4
		private void RefreshPreviewContent(int cfgId)
		{
			DropCatchGameplay? dropCatchGameplayById = DropCatchConfig.Instance.GetDropCatchGameplayById(cfgId);
			if (dropCatchGameplayById == null)
			{
				return;
			}
			DropCatchActivityData data = this.Data;
			DropCatchLevelData dropCatchLevelData = (data != null) ? data.GetLevelData(cfgId) : null;
			if (dropCatchLevelData == null)
			{
				return;
			}
			List<IDropCatchRewardPreviewData> list = new List<IDropCatchRewardPreviewData>();
			for (int i = 0; i < dropCatchGameplayById.Value.RewardIds().Length; i++)
			{
				int id = dropCatchGameplayById.Value.RewardIds(i);
				DropCatchReward? dropCatchRewardById = DropCatchConfig.Instance.GetDropCatchRewardById(id);
				if (dropCatchRewardById == null)
				{
					return;
				}
				list.Add(new DropCatchRewardPreviewData
				{
					CfgId = dropCatchRewardById.Value.Id,
					State = dropCatchLevelData.GetTargetStarState(i),
					IsLast = (i == dropCatchGameplayById.Value.RewardIds().Length - 1)
				});
			}
			GenericLayout<DropCatchRewardPreviewItem, IDropCatchRewardPreviewData> previewLayout = this.PreviewLayout;
			if (previewLayout == null)
			{
				return;
			}
			previewLayout.RefreshByData(list, null, false);
		}

		// Token: 0x060367E1 RID: 223201 RVA: 0x00F35AD0 File Offset: 0x00F33CD0
		private void RefreshLockTips(int configId)
		{
			DropCatchActivityData data = this.Data;
			DropCatchLevelData dropCatchLevelData = (data != null) ? data.GetLevelData(configId) : null;
			if (dropCatchLevelData == null)
			{
				return;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			double num = dropCatchLevelData.UnlockTime - serverTime;
			this.UpdateUnlockText(configId);
			if (num > 0.0)
			{
				this.CountdownTimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
				{
					this.UpdateUnlockText(configId);
				}, 1000f, 1f, null, null, true);
			}
		}

		// Token: 0x060367E2 RID: 223202 RVA: 0x00F35B64 File Offset: 0x00F33D64
		private void UpdateUnlockText(int configId)
		{
			string levelUnlockHintText = this.Data.GetLevelUnlockHintText(configId);
			if (levelUnlockHintText != null)
			{
				base.GetText(21).SetText(levelUnlockHintText, true);
			}
		}

		// Token: 0x060367E3 RID: 223203 RVA: 0x00F35B90 File Offset: 0x00F33D90
		private void ClearCountdownTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.CountdownTimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.CountdownTimerHandle);
			}
			this.CountdownTimerHandle = null;
		}

		// Token: 0x0401CC9C RID: 117916
		protected DropCatchActivityData Data;

		// Token: 0x0401CC9D RID: 117917
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401CC9E RID: 117918
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<DropCatchLevelItem, IDropCatchLevelItemData> LevelScrollView;

		// Token: 0x0401CC9F RID: 117919
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DropCatchRewardPreviewItem, IDropCatchRewardPreviewData> PreviewLayout;

		// Token: 0x0401CCA0 RID: 117920
		private int CurLevelCfgId;

		// Token: 0x0401CCA1 RID: 117921
		private int CurLevelIndex;

		// Token: 0x0401CCA2 RID: 117922
		[Nullable(1)]
		private readonly List<IDropCatchLevelItemData> LevelDataList = new List<IDropCatchLevelItemData>();

		// Token: 0x0401CCA3 RID: 117923
		private TimerHandle CountdownTimerHandle;

		// Token: 0x0401CCA4 RID: 117924
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401CCA5 RID: 117925
		private DropCatchGameplayRoleView RoleView;
	}
}
