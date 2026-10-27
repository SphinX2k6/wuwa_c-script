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
	// Token: 0x02006338 RID: 25400
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballMainView : PinballMainChildViewBase<PinballMainViewModel>
	{
		// Token: 0x0603FE80 RID: 261760 RVA: 0x00F759B4 File Offset: 0x00F73BB4
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

		// Token: 0x0603FE81 RID: 261761 RVA: 0x00F75BF0 File Offset: 0x00F73DF0
		protected override UniTask OnBeforeStartAsync()
		{
			PinballMainView.<OnBeforeStartAsync>d__41 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballMainView.<OnBeforeStartAsync>d__41>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FE82 RID: 261762 RVA: 0x00F75C33 File Offset: 0x00F73E33
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

		// Token: 0x0603FE83 RID: 261763 RVA: 0x00F75C72 File Offset: 0x00F73E72
		protected override void OnBeforeHide()
		{
			this.StopScrollTick();
			this.ScrollProgressTween.KillTween();
		}

		// Token: 0x0603FE84 RID: 261764 RVA: 0x00F75C88 File Offset: 0x00F73E88
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

		// Token: 0x0603FE85 RID: 261765 RVA: 0x00F75D04 File Offset: 0x00F73F04
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

		// Token: 0x0603FE86 RID: 261766 RVA: 0x00F75E90 File Offset: 0x00F74090
		private UniTask LoadCurveResource()
		{
			PinballMainView.<LoadCurveResource>d__46 <LoadCurveResource>d__;
			<LoadCurveResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadCurveResource>d__.<>4__this = this;
			<LoadCurveResource>d__.<>1__state = -1;
			<LoadCurveResource>d__.<>t__builder.Start<PinballMainView.<LoadCurveResource>d__46>(ref <LoadCurveResource>d__);
			return <LoadCurveResource>d__.<>t__builder.Task;
		}

		// Token: 0x0603FE87 RID: 261767 RVA: 0x00F75ED4 File Offset: 0x00F740D4
		private UniTask CreateButtons()
		{
			PinballMainView.<CreateButtons>d__47 <CreateButtons>d__;
			<CreateButtons>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateButtons>d__.<>4__this = this;
			<CreateButtons>d__.<>1__state = -1;
			<CreateButtons>d__.<>t__builder.Start<PinballMainView.<CreateButtons>d__47>(ref <CreateButtons>d__);
			return <CreateButtons>d__.<>t__builder.Task;
		}

		// Token: 0x0603FE88 RID: 261768 RVA: 0x00F75F18 File Offset: 0x00F74118
		private UUIItem CreateChapterUiItem(bool isTower = false)
		{
			UUIItem item = isTower ? base.GetItem(2) : base.GetItem(1);
			UUIItem uiitem = base.GetScrollViewWithScrollbar(0).Content.Get().GetUIItem();
			return LguiUtil.Instance.CopyItem(item, uiitem);
		}

		// Token: 0x0603FE89 RID: 261769 RVA: 0x00F75F60 File Offset: 0x00F74160
		private UniTask CreateAllChapterItems()
		{
			PinballMainView.<CreateAllChapterItems>d__49 <CreateAllChapterItems>d__;
			<CreateAllChapterItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateAllChapterItems>d__.<>4__this = this;
			<CreateAllChapterItems>d__.<>1__state = -1;
			<CreateAllChapterItems>d__.<>t__builder.Start<PinballMainView.<CreateAllChapterItems>d__49>(ref <CreateAllChapterItems>d__);
			return <CreateAllChapterItems>d__.<>t__builder.Task;
		}

		// Token: 0x0603FE8A RID: 261770 RVA: 0x00F75FA4 File Offset: 0x00F741A4
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

		// Token: 0x0603FE8B RID: 261771 RVA: 0x00F76058 File Offset: 0x00F74258
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

		// Token: 0x0603FE8C RID: 261772 RVA: 0x00F760BC File Offset: 0x00F742BC
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

		// Token: 0x0603FE8D RID: 261773 RVA: 0x00F760F4 File Offset: 0x00F742F4
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

		// Token: 0x0603FE8E RID: 261774 RVA: 0x00F761F8 File Offset: 0x00F743F8
		private void BindAllButtonRedDot()
		{
			foreach (PinballMainButtonItem pinballMainButtonItem in this.ButtonItems.Values)
			{
				pinballMainButtonItem.BindRedDot();
			}
		}

		// Token: 0x0603FE8F RID: 261775 RVA: 0x00F76250 File Offset: 0x00F74450
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

		// Token: 0x0603FE90 RID: 261776 RVA: 0x00F763B0 File Offset: 0x00F745B0
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

		// Token: 0x0603FE91 RID: 261777 RVA: 0x00F7643C File Offset: 0x00F7463C
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

		// Token: 0x0603FE92 RID: 261778 RVA: 0x00F764D4 File Offset: 0x00F746D4
		private void AddScrollTick()
		{
			this.ScrollTickId = TickSystem.Instance.Add(new Action<float>(this.OnScrollTick), "PinballMainViewChapterScroll", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
		}

		// Token: 0x0603FE93 RID: 261779 RVA: 0x00F76500 File Offset: 0x00F74700
		private void StartScrollTick()
		{
			if (this.ScrollTickId != -1)
			{
				TickSystem.Instance.Resume(this.ScrollTickId);
			}
		}

		// Token: 0x0603FE94 RID: 261780 RVA: 0x00F7651C File Offset: 0x00F7471C
		private void StopScrollTick()
		{
			if (this.ScrollTickId != -1)
			{
				TickSystem.Instance.Pause(this.ScrollTickId);
			}
		}

		// Token: 0x0603FE95 RID: 261781 RVA: 0x00F76538 File Offset: 0x00F74738
		private void RemoveScrollTick()
		{
			if (this.ScrollTickId != -1)
			{
				TickSystem.Instance.Remove(this.ScrollTickId);
				this.ScrollTickId = -1;
			}
		}

		// Token: 0x0603FE96 RID: 261782 RVA: 0x00F7655C File Offset: 0x00F7475C
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

		// Token: 0x0603FE97 RID: 261783 RVA: 0x00F765B3 File Offset: 0x00F747B3
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

		// Token: 0x0603FE98 RID: 261784 RVA: 0x00F765E8 File Offset: 0x00F747E8
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

		// Token: 0x0603FE99 RID: 261785 RVA: 0x00F7667C File Offset: 0x00F7487C
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

		// Token: 0x0603FE9A RID: 261786 RVA: 0x00F76708 File Offset: 0x00F74908
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

		// Token: 0x0603FE9B RID: 261787 RVA: 0x00F7676C File Offset: 0x00F7496C
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

		// Token: 0x0603FE9C RID: 261788 RVA: 0x00F7684D File Offset: 0x00F74A4D
		[NullableContext(2)]
		private void PlayScrollProgressTween(float startProgress, float endProgress, float duration, Action finishedCallBack = null)
		{
			this.ScrollProgressTween.PlayTween(startProgress, endProgress, duration, null);
			this.ScrollTweenCallback = finishedCallBack;
		}

		// Token: 0x0603FE9D RID: 261789 RVA: 0x00F76868 File Offset: 0x00F74A68
		private void BindScrollProgressTween()
		{
			this.ScrollProgressTween.BindStartTween(new Action(this.OnScrollProgressTweenStart));
			this.ScrollProgressTween.BindUpdateTween(new Action<float>(this.OnScrollProgressTweenUpdate));
			this.ScrollProgressTween.BindCompleteTween(new Action(this.OnScrollProgressTweenComplete));
		}

		// Token: 0x0603FE9E RID: 261790 RVA: 0x00F768BA File Offset: 0x00F74ABA
		private void OnScrollProgressTweenStart()
		{
			this.IsScrollAnimating = true;
			this.ViewMask.SetMask("PinballMainScrollMoveTween", true);
		}

		// Token: 0x0603FE9F RID: 261791 RVA: 0x00F768D4 File Offset: 0x00F74AD4
		private void OnScrollProgressTweenUpdate(float value)
		{
			this.DisplayScrollProgress = value;
			if (this.IsScrollAnimating)
			{
				this.SyncScrollProgress(value);
			}
			this.UpdateChapterItemsByCurve(this.DisplayScrollProgress);
		}

		// Token: 0x0603FEA0 RID: 261792 RVA: 0x00F768F8 File Offset: 0x00F74AF8
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

		// Token: 0x0603FEA1 RID: 261793 RVA: 0x00F7692C File Offset: 0x00F74B2C
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

		// Token: 0x0603FEA2 RID: 261794 RVA: 0x00F76978 File Offset: 0x00F74B78
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

		// Token: 0x0603FEA3 RID: 261795 RVA: 0x00F769F8 File Offset: 0x00F74BF8
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

		// Token: 0x0603FEA4 RID: 261796 RVA: 0x00F76A75 File Offset: 0x00F74C75
		private void OnBtnPermanentReward()
		{
			UiManager.Instance.OpenView(EUiViewName.PinballPermanentRewardView, this.ActivityData, null);
		}

		// Token: 0x0603FEA5 RID: 261797 RVA: 0x00F76A8D File Offset: 0x00F74C8D
		private void OnBtnLimitReward()
		{
			UiManager.Instance.OpenView(EUiViewName.PinballLimitedRewardView, this.ActivityData, null);
		}

		// Token: 0x0603FEA6 RID: 261798 RVA: 0x00F76AA5 File Offset: 0x00F74CA5
		private void OnBtnShop()
		{
			UiManager.Instance.OpenView(EUiViewName.PinballShopView, null, null);
		}

		// Token: 0x0603FEA7 RID: 261799 RVA: 0x00F76AB8 File Offset: 0x00F74CB8
		private void OnBtnRole()
		{
			UiManager.Instance.OpenView(EUiViewName.PinballRoleView, null, null);
		}

		// Token: 0x0603FEA8 RID: 261800 RVA: 0x00F76ACC File Offset: 0x00F74CCC
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

		// Token: 0x0603FEA9 RID: 261801 RVA: 0x00F76B28 File Offset: 0x00F74D28
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

		// Token: 0x0603FEAA RID: 261802 RVA: 0x00F76B84 File Offset: 0x00F74D84
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

		// Token: 0x0603FEAB RID: 261803 RVA: 0x00F76BE4 File Offset: 0x00F74DE4
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

		// Token: 0x0603FEAC RID: 261804 RVA: 0x00F76C54 File Offset: 0x00F74E54
		private bool OnShowLimitRewardButton()
		{
			PinballActivityData activityData = this.ActivityData;
			return activityData != null && activityData.CheckIfInRewardTime();
		}

		// Token: 0x0603FEAD RID: 261805 RVA: 0x00F76C67 File Offset: 0x00F74E67
		private bool OnShowShopRedDot()
		{
			PinballActivityData activityData = this.ActivityData;
			return activityData != null && activityData.IsShopEntranceHasRedDot();
		}

		// Token: 0x0603FEAE RID: 261806 RVA: 0x00F76C7A File Offset: 0x00F74E7A
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

		// Token: 0x0603FEAF RID: 261807 RVA: 0x00F76CB7 File Offset: 0x00F74EB7
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

		// Token: 0x0603FEB0 RID: 261808 RVA: 0x00F76CF4 File Offset: 0x00F74EF4
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

		// Token: 0x0603FEB1 RID: 261809 RVA: 0x00F76D7C File Offset: 0x00F74F7C
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

		// Token: 0x0603FEB2 RID: 261810 RVA: 0x00F76DD4 File Offset: 0x00F74FD4
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

		// Token: 0x0603FEB3 RID: 261811 RVA: 0x00F76E36 File Offset: 0x00F75036
		private void OnBtnDailyLevelClick()
		{
			base.OpenChildView("PinballDailyLevelView");
		}

		// Token: 0x0603FEB4 RID: 261812 RVA: 0x00F76E43 File Offset: 0x00F75043
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

		// Token: 0x0603FEB5 RID: 261813 RVA: 0x00F76E67 File Offset: 0x00F75067
		private void OnBtnBackClick()
		{
			base.BackToLastView();
		}

		// Token: 0x0603FEB6 RID: 261814 RVA: 0x00F76E70 File Offset: 0x00F75070
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

		// Token: 0x0402154D RID: 136525
		private const int ITEM_OFFSET_X = 95;

		// Token: 0x0402154E RID: 136526
		private const int ITEM_OFFSET_Y = 100;

		// Token: 0x0402154F RID: 136527
		private const float CHAPTER_CURVE_PROGRESS_MIN = 0.1f;

		// Token: 0x04021550 RID: 136528
		private const float CHAPTER_CURVE_PROGRESS_MAX = 0.9f;

		// Token: 0x04021551 RID: 136529
		private const float CHAPTER_ITEM_X_SPACING_SCALE = 1f;

		// Token: 0x04021552 RID: 136530
		private const float CHAPTER_LAST_ITEM_X_GAP_RATIO = 1.125f;

		// Token: 0x04021553 RID: 136531
		private const float CHAPTER_INITIAL_SCROLL_TWEEN_DURATION = 1f;

		// Token: 0x04021554 RID: 136532
		private const float CHAPTER_GAMEPAD_SCROLL_TWEEN_DURATION = 0.3f;

		// Token: 0x04021555 RID: 136533
		private const int CHAPTER_LAST_ITEM_RIGHT_MARGIN = 80;

		// Token: 0x04021556 RID: 136534
		private const int AUTO_REFRESH_CHAPTER_ITEMS_INTERVAL = 1000;

		// Token: 0x04021557 RID: 136535
		[Nullable(2)]
		private PinballActivityData ActivityData;

		// Token: 0x04021558 RID: 136536
		private List<IPinballMainButtonConfig> ButtonConfigList = new List<IPinballMainButtonConfig>();

		// Token: 0x04021559 RID: 136537
		private readonly Dictionary<EPinballMainButtonFunctionType, PinballMainButtonItem> ButtonItems = new Dictionary<EPinballMainButtonFunctionType, PinballMainButtonItem>();

		// Token: 0x0402155A RID: 136538
		private readonly List<PinballMainChapterItem> ChapterItemList = new List<PinballMainChapterItem>();

		// Token: 0x0402155B RID: 136539
		private readonly Dictionary<IPinballChapterItem, PinballChapterData> NeedPlayTweenChapterItemMap = new Dictionary<IPinballChapterItem, PinballChapterData>();

		// Token: 0x0402155C RID: 136540
		[Nullable(2)]
		private PinballTowerChapterItem TowerChapterItem;

		// Token: 0x0402155D RID: 136541
		private readonly List<UUIItem> ChapterUiItemList = new List<UUIItem>();

		// Token: 0x0402155E RID: 136542
		[Nullable(2)]
		private UUIItem ContentItem;

		// Token: 0x0402155F RID: 136543
		private readonly Vector2D UiOffset = Vector2D.Create();

		// Token: 0x04021560 RID: 136544
		[Nullable(2)]
		private UCurveFloat ChapterScrollCurve;

		// Token: 0x04021561 RID: 136545
		[Nullable(2)]
		private UUIInturnAnimController ScrollAnimController;

		// Token: 0x04021562 RID: 136546
		private readonly LguiFloatTween ScrollProgressTween = new LguiFloatTween();

		// Token: 0x04021563 RID: 136547
		protected UiMask ViewMask = new UiMask();

		// Token: 0x04021564 RID: 136548
		[Nullable(2)]
		private Action ScrollTweenCallback;

		// Token: 0x04021565 RID: 136549
		private float ViewPortStretchLeft;

		// Token: 0x04021566 RID: 136550
		private float ContentWidth;

		// Token: 0x04021567 RID: 136551
		private float ContentHeight;

		// Token: 0x04021568 RID: 136552
		private float ViewportWidth;

		// Token: 0x04021569 RID: 136553
		private float TotalCurveWidth;

		// Token: 0x0402156A RID: 136554
		private float HorizontalOffsetOriX;

		// Token: 0x0402156B RID: 136555
		private float HorizontalOffsetOriY;

		// Token: 0x0402156C RID: 136556
		private bool IsInitialChapterScroll;

		// Token: 0x0402156D RID: 136557
		private bool IsScrollAnimating;

		// Token: 0x0402156E RID: 136558
		private float DisplayScrollProgress;

		// Token: 0x0402156F RID: 136559
		private int LastGamepadChapterIndex;

		// Token: 0x04021570 RID: 136560
		private int ScrollTickId;

		// Token: 0x04021571 RID: 136561
		private float AllChaptersRefreshTime;

		// Token: 0x04021572 RID: 136562
		private float LimitRewardButtonRefreshTime;

		// Token: 0x04021573 RID: 136563
		private string OldPlanetPath = "";

		// Token: 0x0200C543 RID: 50499
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403B88D RID: 243853
			ChapterScroll,
			// Token: 0x0403B88E RID: 243854
			ChapterItem,
			// Token: 0x0403B88F RID: 243855
			TowerChapterItem,
			// Token: 0x0403B890 RID: 243856
			PermanentRewardItem,
			// Token: 0x0403B891 RID: 243857
			LimitRewardItem,
			// Token: 0x0403B892 RID: 243858
			ShopItem,
			// Token: 0x0403B893 RID: 243859
			RoleItem,
			// Token: 0x0403B894 RID: 243860
			BtnDailyLevel,
			// Token: 0x0403B895 RID: 243861
			DailyRewardProgressLayout,
			// Token: 0x0403B896 RID: 243862
			DailyRewardCheckMarkItem,
			// Token: 0x0403B897 RID: 243863
			TxtDailyRewardProgress,
			// Token: 0x0403B898 RID: 243864
			DailyRewardItem,
			// Token: 0x0403B899 RID: 243865
			BtnNewTowerLevel,
			// Token: 0x0403B89A RID: 243866
			TxtDailyTitle
		}
	}
}
