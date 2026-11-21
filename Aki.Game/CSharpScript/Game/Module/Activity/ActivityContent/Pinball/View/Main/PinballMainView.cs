using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main
{
	// Token: 0x020052B6 RID: 21174
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballMainView : PinballMainChildViewBase<PinballMainViewModel>
	{
		// Token: 0x06034B41 RID: 215873 RVA: 0x00EBC910 File Offset: 0x00EBAB10
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnBtnDailyLevelClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnBtnNewTowerLevelClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06034B42 RID: 215874 RVA: 0x00EBCB4C File Offset: 0x00EBAD4C
		protected override UniTask OnBeforeStartAsync()
		{
			PinballMainView.<OnBeforeStartAsync>d__41 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballMainView.<OnBeforeStartAsync>d__41>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034B43 RID: 215875 RVA: 0x00EBCB8F File Offset: 0x00EBAD8F
		protected override void OnBeforeShow()
		{
			this.LastGamepadChapterIndex = -1;
			this.SetCaptionInfo();
			this.RefreshAllChapterItems();
			this.RefreshNormalButtonStates();
			this.InitChapterScrollTween();
			UUIInturnAnimController scrollAnimController = this.ScrollAnimController;
			if (scrollAnimController != null)
			{
				scrollAnimController.Play("", -1, false);
			}
			this.StartScrollTick();
		}

		// Token: 0x06034B44 RID: 215876 RVA: 0x00EBCBCE File Offset: 0x00EBADCE
		protected override void OnBeforeHide()
		{
			this.StopScrollTick();
			this.ScrollProgressTween.KillTween();
		}

		// Token: 0x06034B45 RID: 215877 RVA: 0x00EBCBE4 File Offset: 0x00EBADE4
		protected override void OnBeforeDestroy()
		{
			this.RemoveScrollTick();
			this.ScrollProgressTween.Destroy();
			foreach (PinballMainButtonItem pinballMainButtonItem in this.ButtonItems.Values)
			{
				pinballMainButtonItem.Clear();
			}
			this.ButtonItems.Clear();
			this.ButtonConfigList = new List<IPinballMainButtonConfig>();
		}

		// Token: 0x06034B46 RID: 215878 RVA: 0x00EBCC60 File Offset: 0x00EBAE60
		private void InitButtonConfigs()
		{
			if (this.ButtonConfigList.Count > 0)
			{
				return;
			}
			this.ButtonConfigList = new List<IPinballMainButtonConfig>();
			PinballMainButtonConfig item = new PinballMainButtonConfig
			{
				Type = EPinballMainButtonFunctionType.PermanentReward,
				UiRegisterId = 3,
				OnClickCallback = new Action(this.OnBtnPermanentReward),
				SetTextCallback = new Action<UUIText>(this.OnBtnPermanentRewardProgress),
				ShowRedDot = new Func<bool>(this.OnShowPermanentRewardRedDot)
			};
			PinballMainButtonConfig item2 = new PinballMainButtonConfig
			{
				Type = EPinballMainButtonFunctionType.LimitReward,
				UiRegisterId = 4,
				OnClickCallback = new Action(this.OnBtnLimitReward),
				SetTextCallback = new Action<UUIText>(this.OnBtnLimitRewardProgress),
				ShowRedDot = new Func<bool>(this.OnShowLimitRewardRedDot),
				ShowCallback = new Func<bool>(this.OnShowLimitRewardButton)
			};
			PinballMainButtonConfig item3 = new PinballMainButtonConfig
			{
				FunctionId = new int?(10153),
				Type = EPinballMainButtonFunctionType.Shop,
				UiRegisterId = 5,
				OnClickCallback = new Action(this.OnBtnShop),
				ShowRedDot = new Func<bool>(this.OnShowShopRedDot)
			};
			PinballMainButtonConfig item4 = new PinballMainButtonConfig
			{
				FunctionId = new int?(10152),
				Type = EPinballMainButtonFunctionType.Role,
				UiRegisterId = 6,
				OnClickCallback = new Action(this.OnBtnRole),
				RedDotName = new ERedDotName?(ERedDotName.RedDotPinballRoleFunction)
			};
			this.ButtonConfigList.Add(item);
			this.ButtonConfigList.Add(item2);
			this.ButtonConfigList.Add(item3);
			this.ButtonConfigList.Add(item4);
		}

		// Token: 0x06034B47 RID: 215879 RVA: 0x00EBCDEC File Offset: 0x00EBAFEC
		private UniTask LoadCurveResource()
		{
			PinballMainView.<LoadCurveResource>d__46 <LoadCurveResource>d__;
			<LoadCurveResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadCurveResource>d__.<>4__this = this;
			<LoadCurveResource>d__.<>1__state = -1;
			<LoadCurveResource>d__.<>t__builder.Start<PinballMainView.<LoadCurveResource>d__46>(ref <LoadCurveResource>d__);
			return <LoadCurveResource>d__.<>t__builder.Task;
		}

		// Token: 0x06034B48 RID: 215880 RVA: 0x00EBCE30 File Offset: 0x00EBB030
		private UniTask CreateButtons()
		{
			PinballMainView.<CreateButtons>d__47 <CreateButtons>d__;
			<CreateButtons>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateButtons>d__.<>4__this = this;
			<CreateButtons>d__.<>1__state = -1;
			<CreateButtons>d__.<>t__builder.Start<PinballMainView.<CreateButtons>d__47>(ref <CreateButtons>d__);
			return <CreateButtons>d__.<>t__builder.Task;
		}

		// Token: 0x06034B49 RID: 215881 RVA: 0x00EBCE74 File Offset: 0x00EBB074
		private UUIItem CreateChapterUiItem(bool isTower = false)
		{
			UUIItem item = isTower ? base.GetItem(2) : base.GetItem(1);
			UUIItem uiitem = base.GetScrollViewWithScrollbar(0).Content.Get().GetUIItem();
			return LguiUtil.Instance.CopyItem(item, uiitem);
		}

		// Token: 0x06034B4A RID: 215882 RVA: 0x00EBCEBC File Offset: 0x00EBB0BC
		private UniTask CreateAllChapterItems()
		{
			PinballMainView.<CreateAllChapterItems>d__49 <CreateAllChapterItems>d__;
			<CreateAllChapterItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateAllChapterItems>d__.<>4__this = this;
			<CreateAllChapterItems>d__.<>1__state = -1;
			<CreateAllChapterItems>d__.<>t__builder.Start<PinballMainView.<CreateAllChapterItems>d__49>(ref <CreateAllChapterItems>d__);
			return <CreateAllChapterItems>d__.<>t__builder.Task;
		}

		// Token: 0x06034B4B RID: 215883 RVA: 0x00EBCF00 File Offset: 0x00EBB100
		private void SetChapterItemOffset(UUIItem item, int index, int totalCount, float stepOffset = 0f, float contentOffsetX = 0f)
		{
			int num = totalCount - 1;
			float num2 = 0.79999995f / (float)num;
			float num3 = this.HorizontalOffsetOriX + 95f;
			float num4 = 0.1f + ((float)index - stepOffset) * num2;
			float num5 = (num > 0 && index == num) ? (num2 * 0.125f) : 0f;
			float num6 = num4 + num5;
			float floatValue = this.ChapterScrollCurve.GetFloatValue(num4);
			float num7 = num6 * this.TotalCurveWidth * 1f;
			float num8 = num3 + num7 - contentOffsetX;
			float num9 = this.ContentHeight * floatValue - this.HorizontalOffsetOriY - 100f;
			this.UiOffset.Set((double)num8, (double)num9);
			item.SetAnchorOffset(this.UiOffset.ToUeVector2D(false));
		}

		// Token: 0x06034B4C RID: 215884 RVA: 0x00EBCFB4 File Offset: 0x00EBB1B4
		private void SetCaptionInfo()
		{
			if (base.ViewModel != null)
			{
				Action<string> setViewTitle = base.ViewModel.SetViewTitle;
				if (setViewTitle != null)
				{
					setViewTitle("Pinball_Main_Ttile");
				}
				Action<int> setViewHelpId = base.ViewModel.SetViewHelpId;
				if (setViewHelpId != null)
				{
					setViewHelpId(555);
				}
				base.ViewModel.SetOverrideCloseFunc(new Action(this.OnBtnBackClick));
			}
		}

		// Token: 0x06034B4D RID: 215885 RVA: 0x00EBD018 File Offset: 0x00EBB218
		private void RefreshLimitRewardMainButton()
		{
			PinballMainButtonItem pinballMainButtonItem;
			this.ButtonItems.TryGetValue(EPinballMainButtonFunctionType.LimitReward, out pinballMainButtonItem);
			if (pinballMainButtonItem != null)
			{
				pinballMainButtonItem.SetButtonState();
			}
			if (pinballMainButtonItem != null)
			{
				pinballMainButtonItem.SetProgressText();
			}
			if (pinballMainButtonItem != null)
			{
				pinballMainButtonItem.SetRedDot();
			}
		}

		// Token: 0x06034B4E RID: 215886 RVA: 0x00EBD050 File Offset: 0x00EBB250
		private void RefreshNormalButtonStates()
		{
			foreach (PinballMainButtonItem pinballMainButtonItem in this.ButtonItems.Values)
			{
				pinballMainButtonItem.SetButtonState();
				pinballMainButtonItem.SetProgressText();
				pinballMainButtonItem.SetRedDot();
			}
			PinballActivity? pinballActivityConfigByActivityId = PinballConfig.Instance.GetPinballActivityConfigByActivityId(this.ActivityData.Id);
			bool uiactive = FunctionModel.Instance.IsOpen(pinballActivityConfigByActivityId.Value.DailyLevelFuncId);
			base.GetItem(11).SetUIActive(uiactive);
			base.GetItem(9).SetUIActive(false);
			base.GetText(10).SetUIActive(false);
			PinballChapterData dailyChapterData = this.ActivityData.GetDailyChapterData();
			if (dailyChapterData != null)
			{
				PinballChapterConfig? pinballChapterConfigById = PinballConfig.Instance.GetPinballChapterConfigById(dailyChapterData.ChapterId);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(13), pinballChapterConfigById.Value.Name, Array.Empty<object>());
			}
		}

		// Token: 0x06034B4F RID: 215887 RVA: 0x00EBD154 File Offset: 0x00EBB354
		private void BindAllButtonRedDot()
		{
			foreach (PinballMainButtonItem pinballMainButtonItem in this.ButtonItems.Values)
			{
				pinballMainButtonItem.BindRedDot();
			}
		}

		// Token: 0x06034B50 RID: 215888 RVA: 0x00EBD1AC File Offset: 0x00EBB3AC
		private void RefreshAllChapterItems()
		{
			this.NeedPlayTweenChapterItemMap.Clear();
			List<PinballChapterData> mainChapterList = this.ActivityData.GetMainChapterList();
			for (int i = 0; i < mainChapterList.Count; i++)
			{
				PinballChapterData pinballChapterData = mainChapterList[i];
				PinballMainChapterItem pinballMainChapterItem = this.ChapterItemList[i];
				bool flag = this.ActivityData.IsNewChapterUnlocked(pinballChapterData.ChapterId);
				pinballMainChapterItem.Refresh(pinballChapterData, flag);
				if (flag)
				{
					this.NeedPlayTweenChapterItemMap[pinballMainChapterItem] = pinballChapterData;
				}
			}
			PinballChapterData towerChapterData = this.ActivityData.GetTowerChapterData();
			if (towerChapterData != null)
			{
				bool flag2 = this.ActivityData.IsNewChapterUnlocked(towerChapterData.ChapterId);
				this.TowerChapterItem.Refresh(towerChapterData, flag2);
				if (flag2)
				{
					this.NeedPlayTweenChapterItemMap[this.TowerChapterItem] = towerChapterData;
				}
				bool flag3 = false;
				if (this.ActivityData.GetChapterLockStatus(towerChapterData.ChapterId) == EPinballChapterLevelLockStatus.Activated)
				{
					foreach (int levelId in towerChapterData.LevelIds)
					{
						int num = this.ActivityData.IsLevelPassed(levelId) ? 1 : 0;
						bool flag4 = this.ActivityData.GetLevelLockStatus(levelId) == EPinballChapterLevelLockStatus.Activated;
						if (num == 0 && flag4)
						{
							flag3 = true;
							break;
						}
					}
				}
				base.GetButton(12).RootUIComp.Get().SetUIActive(flag3);
				if (flag3)
				{
					EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "PinballNewTowerLevelBtn");
				}
			}
		}

		// Token: 0x06034B51 RID: 215889 RVA: 0x00EBD30C File Offset: 0x00EBB50C
		private void InitChapterScrollTween()
		{
			if (this.IsInitialChapterScroll || this.ChapterUiItemList.Count <= 0)
			{
				return;
			}
			if (base.GetScrollViewWithScrollbar(0) == null)
			{
				return;
			}
			int targetIndex = this.GetLatestUnlockedChapterIndex();
			float scrollProgressByIndex = this.GetScrollProgressByIndex(targetIndex);
			float entranceProgress = this.GetEntranceProgress();
			this.DisplayScrollProgress = entranceProgress;
			this.SyncScrollProgress(entranceProgress);
			this.UpdateChapterItemsByCurve(entranceProgress);
			this.PlayScrollProgressTween(entranceProgress, scrollProgressByIndex, 1f, delegate
			{
				if (Info.Instance.IsInGamepad())
				{
					UUIItem uuiitem = (targetIndex == this.ChapterUiItemList.Count - 1) ? this.TowerChapterItem.GetChapterButtonUiItem() : this.ChapterItemList[targetIndex].GetChapterButtonUiItem();
					if (uuiitem != null)
					{
						UiNavigationNewController.Instance.SetNavigationFocusForView(uuiitem, false, false, false);
					}
				}
				this.PlayChapterUnlockTween();
			});
		}

		// Token: 0x06034B52 RID: 215890 RVA: 0x00EBD398 File Offset: 0x00EBB598
		private void PlayChapterUnlockTween()
		{
			if (this.NeedPlayTweenChapterItemMap.Count <= 0)
			{
				return;
			}
			List<UniTask> list = new List<UniTask>();
			foreach (KeyValuePair<IPinballChapterItem, PinballChapterData> keyValuePair in this.NeedPlayTweenChapterItemMap)
			{
				IPinballChapterItem pinballChapterItem;
				PinballChapterData pinballChapterData;
				keyValuePair.Deconstruct(out pinballChapterItem, out pinballChapterData);
				IPinballChapterItem pinballChapterItem2 = pinballChapterItem;
				PinballChapterData data = pinballChapterData;
				pinballChapterItem2.Refresh(data);
				list.Add(pinballChapterItem2.PlayUnlockTweenAsync());
			}
			UniTask.WhenAll(list.ToArray()).Forget();
		}

		// Token: 0x06034B53 RID: 215891 RVA: 0x00EBD430 File Offset: 0x00EBB630
		private void AddScrollTick()
		{
			this.ScrollTickId = TickSystem.Instance.Add(new Action<float>(this.OnScrollTick), "PinballMainViewChapterScroll", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
		}

		// Token: 0x06034B54 RID: 215892 RVA: 0x00EBD45C File Offset: 0x00EBB65C
		private void StartScrollTick()
		{
			if (this.ScrollTickId != -1)
			{
				TickSystem.Instance.Resume(this.ScrollTickId);
			}
		}

		// Token: 0x06034B55 RID: 215893 RVA: 0x00EBD478 File Offset: 0x00EBB678
		private void StopScrollTick()
		{
			if (this.ScrollTickId != -1)
			{
				TickSystem.Instance.Pause(this.ScrollTickId);
			}
		}

		// Token: 0x06034B56 RID: 215894 RVA: 0x00EBD494 File Offset: 0x00EBB694
		private void RemoveScrollTick()
		{
			if (this.ScrollTickId != -1)
			{
				TickSystem.Instance.Remove(this.ScrollTickId);
				this.ScrollTickId = -1;
			}
		}

		// Token: 0x06034B57 RID: 215895 RVA: 0x00EBD4B8 File Offset: 0x00EBB6B8
		private void OnScrollTick(float deltaTime)
		{
			this.LimitRewardButtonRefreshTime += deltaTime;
			if (this.LimitRewardButtonRefreshTime >= 1000f)
			{
				this.LimitRewardButtonRefreshTime = 0f;
				this.RefreshLimitRewardMainButton();
			}
			if (!this.IsInitialChapterScroll || this.ChapterUiItemList.Count <= 0)
			{
				return;
			}
			this.OnRefreshAllChapterItemsTick(deltaTime);
		}

		// Token: 0x06034B58 RID: 215896 RVA: 0x00EBD50F File Offset: 0x00EBB70F
		private void OnRefreshAllChapterItemsTick(float deltaTime)
		{
			this.AllChaptersRefreshTime += deltaTime;
			if (this.AllChaptersRefreshTime >= 1000f)
			{
				this.AllChaptersRefreshTime = 0f;
				this.RefreshAllChapterItems();
				this.PlayChapterUnlockTween();
			}
		}

		// Token: 0x06034B59 RID: 215897 RVA: 0x00EBD544 File Offset: 0x00EBB744
		private int GetLatestUnlockedChapterIndex()
		{
			List<PinballChapterData> mainChapterList = this.ActivityData.GetMainChapterList();
			PinballActivityData activityData = this.ActivityData;
			int result = 0;
			bool flag = true;
			for (int i = 0; i < mainChapterList.Count; i++)
			{
				if (activityData.GetChapterLockStatus(mainChapterList[i].ChapterId) == EPinballChapterLevelLockStatus.Activated)
				{
					result = i;
				}
				if (!activityData.IsChapterPassed(mainChapterList[i].ChapterId))
				{
					flag = false;
				}
			}
			if (flag)
			{
				PinballChapterData towerChapterData = activityData.GetTowerChapterData();
				if (activityData.GetChapterLockStatus(towerChapterData.ChapterId) == EPinballChapterLevelLockStatus.Activated)
				{
					result = this.ChapterUiItemList.Count - 1;
				}
			}
			return result;
		}

		// Token: 0x06034B5A RID: 215898 RVA: 0x00EBD5D8 File Offset: 0x00EBB7D8
		private float GetEntranceProgress()
		{
			int num = this.ChapterUiItemList.Count - 1;
			if (num <= 0)
			{
				return 0f;
			}
			float maxStepOffset = this.GetMaxStepOffset(num);
			float num2 = this.HorizontalOffsetOriX + 95f;
			UUIItem uuiitem = this.ChapterUiItemList[0];
			float num3 = (uuiitem != null) ? (uuiitem.GetWidth() / 2f) : 0f;
			float num4 = this.ViewportWidth / 2f + num3;
			float num5 = this.TotalCurveWidth * 1f;
			float num6 = (num4 - num2) / num5;
			return (float)(-(float)num) * num6 / maxStepOffset;
		}

		// Token: 0x06034B5B RID: 215899 RVA: 0x00EBD664 File Offset: 0x00EBB864
		private float GetScrollProgressByIndex(int targetIndex)
		{
			int num = this.ChapterUiItemList.Count - 1;
			float num2 = this.HorizontalOffsetOriX + 95f;
			float num3 = this.TotalCurveWidth * 1f;
			float num4 = -num2 / num3;
			float num5 = (float)targetIndex - (float)num * num4;
			float maxStepOffset = this.GetMaxStepOffset(num);
			return MathUtils.Instance.Clamp(num5 / maxStepOffset, 0f, 1f);
		}

		// Token: 0x06034B5C RID: 215900 RVA: 0x00EBD6C8 File Offset: 0x00EBB8C8
		private float GetMaxStepOffset(int totalStepCount)
		{
			float num = 0.79999995f / (float)totalStepCount;
			float num2 = this.HorizontalOffsetOriX + 95f;
			float num3 = this.TotalCurveWidth * 1f;
			float num4 = this.ChapterUiItemList[this.ChapterUiItemList.Count - 1].GetWidth() / 2f;
			float num5 = Math.Max(0f, (this.ContentWidth - this.ViewportWidth) / 2f);
			float currentValue = (this.ViewportWidth / 2f - num4 + 80f + num5 - num2) / num3;
			float num6 = MathUtils.Instance.Clamp(currentValue, 0.1f, 1f);
			float num7 = (totalStepCount > 0) ? (num * 0.125f) : 0f;
			float num8 = num6 - num7;
			float currentValue2 = (float)totalStepCount - (num8 - 0.1f) / num;
			return MathUtils.Instance.Clamp(currentValue2, 0f, (float)totalStepCount);
		}

		// Token: 0x06034B5D RID: 215901 RVA: 0x00EBD7A9 File Offset: 0x00EBB9A9
		[NullableContext(2)]
		private void PlayScrollProgressTween(float startProgress, float endProgress, float duration, Action finishedCallBack = null)
		{
			this.ScrollProgressTween.PlayTween(startProgress, endProgress, duration, null);
			this.ScrollTweenCallback = finishedCallBack;
		}

		// Token: 0x06034B5E RID: 215902 RVA: 0x00EBD7C4 File Offset: 0x00EBB9C4
		private void BindScrollProgressTween()
		{
			this.ScrollProgressTween.BindStartTween(new Action(this.OnScrollProgressTweenStart));
			this.ScrollProgressTween.BindUpdateTween(new Action<float>(this.OnScrollProgressTweenUpdate));
			this.ScrollProgressTween.BindCompleteTween(new Action(this.OnScrollProgressTweenComplete));
		}

		// Token: 0x06034B5F RID: 215903 RVA: 0x00EBD816 File Offset: 0x00EBBA16
		private void OnScrollProgressTweenStart()
		{
			this.IsScrollAnimating = true;
			this.ViewMask.SetMask("PinballMainScrollMoveTween", true);
		}

		// Token: 0x06034B60 RID: 215904 RVA: 0x00EBD830 File Offset: 0x00EBBA30
		private void OnScrollProgressTweenUpdate(float value)
		{
			this.DisplayScrollProgress = value;
			if (this.IsScrollAnimating)
			{
				this.SyncScrollProgress(value);
			}
			this.UpdateChapterItemsByCurve(this.DisplayScrollProgress);
		}

		// Token: 0x06034B61 RID: 215905 RVA: 0x00EBD854 File Offset: 0x00EBBA54
		private void OnScrollProgressTweenComplete()
		{
			this.IsScrollAnimating = false;
			this.ViewMask.SetMask("PinballMainScrollMoveTween", false);
			this.IsInitialChapterScroll = true;
			Action scrollTweenCallback = this.ScrollTweenCallback;
			if (scrollTweenCallback == null)
			{
				return;
			}
			scrollTweenCallback();
		}

		// Token: 0x06034B62 RID: 215906 RVA: 0x00EBD888 File Offset: 0x00EBBA88
		private void SyncScrollProgress(float scrollProgress)
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(0);
			if (scrollViewWithScrollbar == null)
			{
				return;
			}
			float num = MathUtils.Instance.Clamp(scrollProgress, 0f, 1f);
			float scrollProgress2 = scrollViewWithScrollbar.Horizontal ? (1f - num) : num;
			scrollViewWithScrollbar.SetScrollProgress(scrollProgress2);
		}

		// Token: 0x06034B63 RID: 215907 RVA: 0x00EBD8D4 File Offset: 0x00EBBAD4
		private void OnScrollValueChange(FVector2D progress)
		{
			if (this.ChapterScrollCurve == null || this.ChapterUiItemList.Count <= 0)
			{
				return;
			}
			if (Info.Instance.IsInGamepad())
			{
				return;
			}
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(0);
			if (scrollViewWithScrollbar == null)
			{
				return;
			}
			float num = MathUtils.Instance.Clamp(scrollViewWithScrollbar.Horizontal ? progress.X : progress.Y, 0f, 1f);
			float num2 = 1f - num;
			this.DisplayScrollProgress = num2;
			this.UpdateChapterItemsByCurve(num2);
		}

		// Token: 0x06034B64 RID: 215908 RVA: 0x00EBD954 File Offset: 0x00EBBB54
		private void UpdateChapterItemsByCurve(float scrollProgress)
		{
			int totalStepCount = this.ChapterUiItemList.Count - 1;
			float maxStepOffset = this.GetMaxStepOffset(totalStepCount);
			float stepOffset = scrollProgress * Math.Max(maxStepOffset, 0f);
			float anchorOffsetX = this.ContentItem.GetAnchorOffsetX();
			for (int i = 0; i < this.ChapterUiItemList.Count; i++)
			{
				UUIItem item = this.ChapterUiItemList[i];
				this.SetChapterItemOffset(item, i, this.ChapterUiItemList.Count, stepOffset, anchorOffsetX);
			}
		}

		// Token: 0x06034B65 RID: 215909 RVA: 0x00EBD9D1 File Offset: 0x00EBBBD1
		private void OnBtnPermanentReward()
		{
			UiManager.Instance.OpenView(EUiViewName.PinballPermanentRewardView, this.ActivityData, null);
		}

		// Token: 0x06034B66 RID: 215910 RVA: 0x00EBD9E9 File Offset: 0x00EBBBE9
		private void OnBtnLimitReward()
		{
			UiManager.Instance.OpenView(EUiViewName.PinballLimitedRewardView, this.ActivityData, null);
		}

		// Token: 0x06034B67 RID: 215911 RVA: 0x00EBDA01 File Offset: 0x00EBBC01
		private void OnBtnShop()
		{
			UiManager.Instance.OpenView(EUiViewName.PinballShopView, null, null);
		}

		// Token: 0x06034B68 RID: 215912 RVA: 0x00EBDA14 File Offset: 0x00EBBC14
		private void OnBtnRole()
		{
			UiManager.Instance.OpenView(EUiViewName.PinballRoleView, null, null);
		}

		// Token: 0x06034B69 RID: 215913 RVA: 0x00EBDA28 File Offset: 0x00EBBC28
		[NullableContext(2)]
		private void OnBtnPermanentRewardProgress(UUIText item)
		{
			ValueTuple<int, int> permanentTaskProgress = this.ActivityData.GetPermanentTaskProgress();
			int item2 = permanentTaskProgress.Item1;
			int item3 = permanentTaskProgress.Item2;
			if (item != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(item3);
				item.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
		}

		// Token: 0x06034B6A RID: 215914 RVA: 0x00EBDA84 File Offset: 0x00EBBC84
		[NullableContext(2)]
		private void OnBtnLimitRewardProgress(UUIText item)
		{
			ValueTuple<int, int> timeLimitTaskProgress = this.ActivityData.GetTimeLimitTaskProgress();
			int item2 = timeLimitTaskProgress.Item1;
			int item3 = timeLimitTaskProgress.Item2;
			if (item != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(item3);
				item.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
		}

		// Token: 0x06034B6B RID: 215915 RVA: 0x00EBDAE0 File Offset: 0x00EBBCE0
		private bool OnShowPermanentRewardRedDot()
		{
			using (List<PinballTaskData>.Enumerator enumerator = this.ActivityData.GetPermanentTaskList().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsUnclaimed)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06034B6C RID: 215916 RVA: 0x00EBDB40 File Offset: 0x00EBBD40
		private bool OnShowLimitRewardRedDot()
		{
			if (!this.ActivityData.CheckIfInRewardTime())
			{
				return false;
			}
			using (List<PinballTaskData>.Enumerator enumerator = this.ActivityData.GetTimeLimitTaskList().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsUnclaimed)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06034B6D RID: 215917 RVA: 0x00EBDBB0 File Offset: 0x00EBBDB0
		private bool OnShowLimitRewardButton()
		{
			PinballActivityData activityData = this.ActivityData;
			return activityData != null && activityData.CheckIfInRewardTime();
		}

		// Token: 0x06034B6E RID: 215918 RVA: 0x00EBDBC3 File Offset: 0x00EBBDC3
		private bool OnShowShopRedDot()
		{
			PinballActivityData activityData = this.ActivityData;
			return activityData != null && activityData.IsShopEntranceHasRedDot();
		}

		// Token: 0x06034B6F RID: 215919 RVA: 0x00EBDBD6 File Offset: 0x00EBBDD6
		private void OnClickChapterBack(PinballChapterData chapterData, List<PinballLevelRecordData> levelDataList)
		{
			PinballActivityData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.CheckToSetChapterRedDotAsRead(chapterData.ChapterId);
			}
			base.ViewModel.SetLevelDataList(levelDataList);
			base.ViewModel.SetChapterData(chapterData);
			base.OpenChildView("PinballLevelView");
		}

		// Token: 0x06034B70 RID: 215920 RVA: 0x00EBDC13 File Offset: 0x00EBBE13
		private void OnClickTowerBack(PinballChapterData chapterData, List<PinballLevelRecordData> levelDataList)
		{
			PinballActivityData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.CheckToSetChapterRedDotAsRead(chapterData.ChapterId);
			}
			base.ViewModel.SetLevelDataList(levelDataList);
			base.ViewModel.SetChapterData(chapterData);
			base.OpenChildView("PinballTowerLevelView");
		}

		// Token: 0x06034B71 RID: 215921 RVA: 0x00EBDC50 File Offset: 0x00EBBE50
		private void OnPointEnterChapterBack(string planetPath, string planetMaskPath, int chapterId)
		{
			if (Info.Instance.IsInGamepad())
			{
				this.OnGamepadEnterChapter(chapterId);
			}
			if (this.OldPlanetPath == planetPath)
			{
				return;
			}
			Action<string> changePlanetTexture = base.ViewModel.ChangePlanetTexture;
			if (changePlanetTexture != null)
			{
				changePlanetTexture(planetPath);
			}
			Action<string> changePlanetMaskTexture = base.ViewModel.ChangePlanetMaskTexture;
			if (changePlanetMaskTexture != null)
			{
				changePlanetMaskTexture(planetMaskPath);
			}
			Action<string> changePlanetSwitchTexture = base.ViewModel.ChangePlanetSwitchTexture;
			if (changePlanetSwitchTexture != null)
			{
				changePlanetSwitchTexture(planetPath);
			}
			base.PlayRootSequence("Switch");
			this.OldPlanetPath = planetPath;
		}

		// Token: 0x06034B72 RID: 215922 RVA: 0x00EBDCD8 File Offset: 0x00EBBED8
		private void OnGamepadEnterChapter(int chapterId)
		{
			if (!this.IsInitialChapterScroll || this.ActivityData == null)
			{
				return;
			}
			int chapterIndexById = this.GetChapterIndexById(chapterId);
			if (chapterIndexById < 0 || chapterIndexById == this.LastGamepadChapterIndex)
			{
				return;
			}
			this.LastGamepadChapterIndex = chapterIndexById;
			float scrollProgressByIndex = this.GetScrollProgressByIndex(chapterIndexById);
			this.PlayScrollProgressTween(this.DisplayScrollProgress, scrollProgressByIndex, 0.3f, null);
		}

		// Token: 0x06034B73 RID: 215923 RVA: 0x00EBDD30 File Offset: 0x00EBBF30
		private int GetChapterIndexById(int chapterId)
		{
			List<PinballChapterData> mainChapterList = this.ActivityData.GetMainChapterList();
			for (int i = 0; i < mainChapterList.Count; i++)
			{
				if (mainChapterList[i].ChapterId == chapterId)
				{
					return i;
				}
			}
			PinballChapterData towerChapterData = this.ActivityData.GetTowerChapterData();
			if (towerChapterData != null && towerChapterData.ChapterId == chapterId)
			{
				return this.ChapterUiItemList.Count - 1;
			}
			return -1;
		}

		// Token: 0x06034B74 RID: 215924 RVA: 0x00EBDD92 File Offset: 0x00EBBF92
		private void OnBtnDailyLevelClick()
		{
			base.OpenChildView("PinballDailyLevelView");
		}

		// Token: 0x06034B75 RID: 215925 RVA: 0x00EBDD9F File Offset: 0x00EBBF9F
		private void OnBtnNewTowerLevelClick()
		{
			this.PlayScrollProgressTween(this.DisplayScrollProgress, 1f, 1f, delegate
			{
				if (Info.Instance.IsInGamepad())
				{
					UUIItem chapterButtonUiItem = this.TowerChapterItem.GetChapterButtonUiItem();
					if (chapterButtonUiItem != null)
					{
						UiNavigationNewController.Instance.SetNavigationFocusForView(chapterButtonUiItem, false, false, false);
					}
				}
				PinballChapterData towerChapterData = this.ActivityData.GetTowerChapterData();
				List<PinballLevelRecordData> list = new List<PinballLevelRecordData>();
				foreach (int levelId in towerChapterData.LevelIds)
				{
					list.Add(this.ActivityData.GetLevelData(levelId));
				}
				base.ViewModel.SetLevelDataList(list);
				base.ViewModel.SetChapterData(towerChapterData);
				PinballActivityData activityData = this.ActivityData;
				if (activityData != null)
				{
					activityData.CheckToSetChapterRedDotAsRead(towerChapterData.ChapterId);
				}
				base.OpenChildView("PinballTowerLevelView");
			});
		}

		// Token: 0x06034B76 RID: 215926 RVA: 0x00EBDDC3 File Offset: 0x00EBBFC3
		private void OnBtnBackClick()
		{
			base.BackToLastView();
		}

		// Token: 0x06034B77 RID: 215927 RVA: 0x00EBDDCC File Offset: 0x00EBBFCC
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams[0] != "ChapterBtn")
			{
				return null;
			}
			if (configParams.Length < 2)
			{
				return null;
			}
			int num;
			if (!int.TryParse(configParams[1], out num))
			{
				return null;
			}
			if (num < 0 || num >= this.ChapterItemList.Count)
			{
				return null;
			}
			PinballMainChapterItem pinballMainChapterItem = this.ChapterItemList[num];
			UUIItem uuiitem = (pinballMainChapterItem != null) ? pinballMainChapterItem.GetChapterButtonUiItem() : null;
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

		// Token: 0x0401BE7C RID: 114300
		private const int ITEM_OFFSET_X = 95;

		// Token: 0x0401BE7D RID: 114301
		private const int ITEM_OFFSET_Y = 100;

		// Token: 0x0401BE7E RID: 114302
		private const float CHAPTER_CURVE_PROGRESS_MIN = 0.1f;

		// Token: 0x0401BE7F RID: 114303
		private const float CHAPTER_CURVE_PROGRESS_MAX = 0.9f;

		// Token: 0x0401BE80 RID: 114304
		private const float CHAPTER_ITEM_X_SPACING_SCALE = 1f;

		// Token: 0x0401BE81 RID: 114305
		private const float CHAPTER_LAST_ITEM_X_GAP_RATIO = 1.125f;

		// Token: 0x0401BE82 RID: 114306
		private const float CHAPTER_INITIAL_SCROLL_TWEEN_DURATION = 1f;

		// Token: 0x0401BE83 RID: 114307
		private const float CHAPTER_GAMEPAD_SCROLL_TWEEN_DURATION = 0.3f;

		// Token: 0x0401BE84 RID: 114308
		private const int CHAPTER_LAST_ITEM_RIGHT_MARGIN = 80;

		// Token: 0x0401BE85 RID: 114309
		private const int AUTO_REFRESH_CHAPTER_ITEMS_INTERVAL = 1000;

		// Token: 0x0401BE86 RID: 114310
		[Nullable(2)]
		private PinballActivityData ActivityData;

		// Token: 0x0401BE87 RID: 114311
		private List<IPinballMainButtonConfig> ButtonConfigList = new List<IPinballMainButtonConfig>();

		// Token: 0x0401BE88 RID: 114312
		private readonly Dictionary<EPinballMainButtonFunctionType, PinballMainButtonItem> ButtonItems = new Dictionary<EPinballMainButtonFunctionType, PinballMainButtonItem>();

		// Token: 0x0401BE89 RID: 114313
		private readonly List<PinballMainChapterItem> ChapterItemList = new List<PinballMainChapterItem>();

		// Token: 0x0401BE8A RID: 114314
		private readonly Dictionary<IPinballChapterItem, PinballChapterData> NeedPlayTweenChapterItemMap = new Dictionary<IPinballChapterItem, PinballChapterData>();

		// Token: 0x0401BE8B RID: 114315
		[Nullable(2)]
		private PinballTowerChapterItem TowerChapterItem;

		// Token: 0x0401BE8C RID: 114316
		private readonly List<UUIItem> ChapterUiItemList = new List<UUIItem>();

		// Token: 0x0401BE8D RID: 114317
		[Nullable(2)]
		private UUIItem ContentItem;

		// Token: 0x0401BE8E RID: 114318
		private readonly Vector2D UiOffset = Vector2D.Create();

		// Token: 0x0401BE8F RID: 114319
		[Nullable(2)]
		private UCurveFloat ChapterScrollCurve;

		// Token: 0x0401BE90 RID: 114320
		[Nullable(2)]
		private UUIInturnAnimController ScrollAnimController;

		// Token: 0x0401BE91 RID: 114321
		private readonly LguiFloatTween ScrollProgressTween = new LguiFloatTween();

		// Token: 0x0401BE92 RID: 114322
		protected UiMask ViewMask = new UiMask();

		// Token: 0x0401BE93 RID: 114323
		[Nullable(2)]
		private Action ScrollTweenCallback;

		// Token: 0x0401BE94 RID: 114324
		private float ViewPortStretchLeft;

		// Token: 0x0401BE95 RID: 114325
		private float ContentWidth;

		// Token: 0x0401BE96 RID: 114326
		private float ContentHeight;

		// Token: 0x0401BE97 RID: 114327
		private float ViewportWidth;

		// Token: 0x0401BE98 RID: 114328
		private float TotalCurveWidth;

		// Token: 0x0401BE99 RID: 114329
		private float HorizontalOffsetOriX;

		// Token: 0x0401BE9A RID: 114330
		private float HorizontalOffsetOriY;

		// Token: 0x0401BE9B RID: 114331
		private bool IsInitialChapterScroll;

		// Token: 0x0401BE9C RID: 114332
		private bool IsScrollAnimating;

		// Token: 0x0401BE9D RID: 114333
		private float DisplayScrollProgress;

		// Token: 0x0401BE9E RID: 114334
		private int LastGamepadChapterIndex;

		// Token: 0x0401BE9F RID: 114335
		private int ScrollTickId;

		// Token: 0x0401BEA0 RID: 114336
		private float AllChaptersRefreshTime;

		// Token: 0x0401BEA1 RID: 114337
		private float LimitRewardButtonRefreshTime;

		// Token: 0x0401BEA2 RID: 114338
		private string OldPlanetPath = "";

		// Token: 0x0200AF2A RID: 44842
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x040361EF RID: 221679
			ChapterScroll,
			// Token: 0x040361F0 RID: 221680
			ChapterItem,
			// Token: 0x040361F1 RID: 221681
			TowerChapterItem,
			// Token: 0x040361F2 RID: 221682
			PermanentRewardItem,
			// Token: 0x040361F3 RID: 221683
			LimitRewardItem,
			// Token: 0x040361F4 RID: 221684
			ShopItem,
			// Token: 0x040361F5 RID: 221685
			RoleItem,
			// Token: 0x040361F6 RID: 221686
			BtnDailyLevel,
			// Token: 0x040361F7 RID: 221687
			DailyRewardProgressLayout,
			// Token: 0x040361F8 RID: 221688
			DailyRewardCheckMarkItem,
			// Token: 0x040361F9 RID: 221689
			TxtDailyRewardProgress,
			// Token: 0x040361FA RID: 221690
			DailyRewardItem,
			// Token: 0x040361FB RID: 221691
			BtnNewTowerLevel,
			// Token: 0x040361FC RID: 221692
			TxtDailyTitle
		}
	}
}
