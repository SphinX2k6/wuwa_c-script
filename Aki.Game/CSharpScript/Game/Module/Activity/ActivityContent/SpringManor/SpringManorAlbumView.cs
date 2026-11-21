using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FF6 RID: 20470
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorAlbumView : UiViewBase
	{
		// Token: 0x060333EE RID: 209902 RVA: 0x00E5D63A File Offset: 0x00E5B83A
		public SpringManorAlbumView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060333EF RID: 209903 RVA: 0x00E5D66C File Offset: 0x00E5B86C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(2, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUITexture)),
				new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(9, typeof(UUITexture)),
				new ValueTuple<int, Type>(10, typeof(UUIText)),
				new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(15, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(16, typeof(UUIItem)),
				new ValueTuple<int, Type>(17, typeof(UUITexture))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickTogAlbum1)),
				new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnClickTogAlbum2)),
				new ValueTuple<int, Delegate>(8, new Action(this.OnClickPicAmplifier)),
				new ValueTuple<int, Delegate>(11, new Action(this.OnClickBtnSecConfirmB))
			};
		}

		// Token: 0x060333F0 RID: 209904 RVA: 0x00E5D888 File Offset: 0x00E5BA88
		protected override UniTask OnBeforeStartAsync()
		{
			SpringManorAlbumView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpringManorAlbumView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060333F1 RID: 209905 RVA: 0x00E5D8CC File Offset: 0x00E5BACC
		protected override void OnStart()
		{
			this.CacheCharacterLockTexturePath = (ConfigCommonParamById.GetStringConfig("Spring26CharacterLockTexPath") ?? "");
			this.CacheEasterEggLockTexturePath = (ConfigCommonParamById.GetStringConfig("Spring26EasterEggLockTexPath") ?? "");
			this.AnimationController = (base.GetVerticalLayout(4).GetOwner().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController);
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetHelpBtnActive(false);
			this.CaptionItem.SetCloseCallBack(delegate
			{
				UiManager.Instance.ResetToBattleView(null);
			});
			this.ScrollList = new GenericScrollViewNew<SpringManorAlbumTaskItem, AlbumTaskData>(base.GetScrollViewWithScrollbar(3), new Func<SpringManorAlbumTaskItem>(this.InitDeTermItem), null, false, null);
			this.ScrollViewComponent = base.GetScrollViewWithScrollbar(3);
			this.ItemLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(15), new Func<CommonItemSmallItemGrid>(this.InitGridItem), null, false, true);
		}

		// Token: 0x060333F2 RID: 209906 RVA: 0x00E5D9DC File Offset: 0x00E5BBDC
		protected override void OnBeforeShow()
		{
			SpringManorData activityData = SpringManorModel.Instance.ActivityData;
			this.ActivityId = ((activityData != null) ? activityData.Id : 0);
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem != null)
			{
				captionItem.SetTitleByTextIdAndArgNew("PictureAlbum_ActivityName", Array.Empty<object>());
			}
			PopupCaptionItem captionItem2 = this.CaptionItem;
			if (captionItem2 != null)
			{
				captionItem2.SetHelpCallBack(new Action(this.OnClickMoreButton));
			}
			this.InitBrochureData(EBrochureType.Character);
			this.InitBrochureData(EBrochureType.EasterEggBook);
			this.InitTabItem(this.TogCharacterTab, EBrochureType.Character);
			this.InitTabItem(this.TogEasterEggTab, EBrochureType.EasterEggBook);
			this.CheckDefaultParam();
			this.RefreshTabItem(this.CurTabType, true);
		}

		// Token: 0x060333F3 RID: 209907 RVA: 0x00E5DA78 File Offset: 0x00E5BC78
		private void CheckDefaultParam()
		{
			this.CurrentTaskItemIndex = 0;
			this.CurrentTaskItemCfgId = 0;
			SpringManorAlbumView.Params @params = this.OpenParam as SpringManorAlbumView.Params;
			this.CurTabType = ((@params != null) ? @params.OpenTab : EBrochureType.Character);
			int latestUnlockBookItemId = SpringManorController.Instance.LatestUnlockBookItemId;
			if (latestUnlockBookItemId > 0)
			{
				SpringManorConfig instance = SpringManorConfig.Instance;
				Brochure? brochure = (instance != null) ? instance.GetSpringManorBrochureById(SpringManorController.Instance.LatestUnlockBrochureId) : null;
				if (brochure != null)
				{
					this.CurTabType = (EBrochureType)brochure.Value.Type;
					this.CurrentTaskItemCfgId = latestUnlockBookItemId;
					return;
				}
			}
			foreach (KeyValuePair<EBrochureType, List<AlbumTaskData>> keyValuePair in this.AlbumTaskDataMap)
			{
				List<AlbumTaskData> value = keyValuePair.Value;
				if (value != null)
				{
					AlbumTaskData albumTaskData;
					if (value == null)
					{
						albumTaskData = null;
					}
					else
					{
						albumTaskData = value.Find((AlbumTaskData data) => data.State == EBrochureState.Unlock);
					}
					AlbumTaskData albumTaskData2 = albumTaskData;
					if (albumTaskData2 != null)
					{
						this.CurrentTaskItemCfgId = albumTaskData2.ConfigId;
						this.CurTabType = keyValuePair.Key;
						break;
					}
				}
			}
		}

		// Token: 0x060333F4 RID: 209908 RVA: 0x00E5DBA8 File Offset: 0x00E5BDA8
		private void OnPlaySequenceEvent(string sequenceName, string eventName)
		{
			if (eventName == "Sequence_Switch_Top")
			{
				this.RefreshTabItem(this.CurTabType, true);
				return;
			}
			if (eventName == "Sequence_Switch_List")
			{
				AlbumTaskData curBookItemData = this.GetCurBookItemData();
				if (curBookItemData != null)
				{
					this.SetDetailInfo(curBookItemData);
					return;
				}
			}
			else if (eventName == "List_Sequence_In")
			{
				UUIInturnAnimController animationController = this.AnimationController;
				if (animationController == null)
				{
					return;
				}
				animationController.Play("Start", -1, false);
				return;
			}
			else if (eventName == "Sequence_Start_Unlock" || eventName == "Sequence_Switch_Top_Unlock" || eventName == "Sequence_Switch_List_Unlock")
			{
				this.CheckPlayUnlockSequence();
				AlbumTaskData curBookItemData2 = this.GetCurBookItemData();
				if (curBookItemData2 != null)
				{
					this.SetDetailInfo(curBookItemData2);
				}
			}
		}

		// Token: 0x060333F5 RID: 209909 RVA: 0x00E5DC52 File Offset: 0x00E5BE52
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnBrochureBookItemStateUpdate, new Action(this.OnBrochureBookItemStateUpdate));
		}

		// Token: 0x060333F6 RID: 209910 RVA: 0x00E5DC70 File Offset: 0x00E5BE70
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnBrochureBookItemStateUpdate, new Action(this.OnBrochureBookItemStateUpdate));
		}

		// Token: 0x060333F7 RID: 209911 RVA: 0x00E5DC90 File Offset: 0x00E5BE90
		private void OnBrochureBookItemStateUpdate()
		{
			if (this.AlbumTaskDataMap.ContainsKey(this.CurTabType))
			{
				foreach (AlbumTaskData albumTaskData in this.AlbumTaskDataMap[this.CurTabType])
				{
					SpringManorData activityData = SpringManorModel.Instance.ActivityData;
					albumTaskData.State = ((activityData != null) ? activityData.GetBookItemStateById(albumTaskData.ConfigId) : EBrochureState.Lock);
				}
			}
			this.RefreshTabItem(this.CurTabType, false);
			this.RefreshTabItemProgress(this.TogCharacterTab, EBrochureType.Character);
			this.RefreshTabItemProgress(this.TogEasterEggTab, EBrochureType.EasterEggBook);
		}

		// Token: 0x060333F8 RID: 209912 RVA: 0x00E5DD44 File Offset: 0x00E5BF44
		[NullableContext(2)]
		private void InitTabItem(SpringManorAlbumTabItem tab, EBrochureType tabType)
		{
			if (tab == null)
			{
				return;
			}
			this.RefreshTabItemProgress(tab, tabType);
		}

		// Token: 0x060333F9 RID: 209913 RVA: 0x00E5DD52 File Offset: 0x00E5BF52
		private SpringManorAlbumTaskItem InitDeTermItem()
		{
			SpringManorAlbumTaskItem springManorAlbumTaskItem = new SpringManorAlbumTaskItem();
			springManorAlbumTaskItem.SetToggleCallBack(new Action<AlbumTaskData, int>(this.ClickTaskItem));
			return springManorAlbumTaskItem;
		}

		// Token: 0x060333FA RID: 209914 RVA: 0x00E5DD6C File Offset: 0x00E5BF6C
		private void OnClickMoreButton()
		{
			int helpId = ActivityModel.Instance.GetActivityById(this.ActivityId).GetHelpId();
			HelpController.Instance.OpenHelpById(helpId);
		}

		// Token: 0x060333FB RID: 209915 RVA: 0x00E5DD9C File Offset: 0x00E5BF9C
		private void OnClickTogAlbum1(EToggleState state)
		{
			this.CurrentTaskItemIndex = 0;
			bool flag = this.CurTabType > EBrochureType.Character;
			this.CurTabType = EBrochureType.Character;
			if (flag)
			{
				this.SequencePlayer.PlayLevelSequenceByName("Switch_Top", false, null, false);
			}
		}

		// Token: 0x060333FC RID: 209916 RVA: 0x00E5DDE0 File Offset: 0x00E5BFE0
		private void OnClickTogAlbum2(EToggleState state)
		{
			this.CurrentTaskItemIndex = 0;
			bool flag = this.CurTabType != EBrochureType.EasterEggBook;
			this.CurTabType = EBrochureType.EasterEggBook;
			if (flag)
			{
				this.SequencePlayer.PlayLevelSequenceByName("Switch_Top", false, null, false);
			}
		}

		// Token: 0x060333FD RID: 209917 RVA: 0x00E5DE24 File Offset: 0x00E5C024
		private void RefreshTabItem(EBrochureType targetType, bool needSort)
		{
			SpringManorAlbumTabItem togCharacterTab = this.TogCharacterTab;
			if (togCharacterTab != null)
			{
				togCharacterTab.SetSelected(targetType == EBrochureType.Character);
			}
			SpringManorAlbumTabItem togEasterEggTab = this.TogEasterEggTab;
			if (togEasterEggTab != null)
			{
				togEasterEggTab.SetSelected(targetType == EBrochureType.EasterEggBook);
			}
			this.RefreshBrochureItem(needSort);
			AlbumTaskData curBookItemData = this.GetCurBookItemData();
			if (curBookItemData != null)
			{
				this.SetDetailInfo(curBookItemData);
			}
		}

		// Token: 0x060333FE RID: 209918 RVA: 0x00E5DE74 File Offset: 0x00E5C074
		[NullableContext(2)]
		private void RefreshTabItemProgress(SpringManorAlbumTabItem tab, EBrochureType tabType)
		{
			if (tab == null)
			{
				return;
			}
			Brochure? springManorBrochureByActivityAndType = SpringManorConfig.Instance.GetSpringManorBrochureByActivityAndType(this.ActivityId, tabType);
			int maxNum = (springManorBrochureByActivityAndType != null) ? springManorBrochureByActivityAndType.GetValueOrDefault().BookItemIdsLength : 0;
			int num = 0;
			bool redDotActive = false;
			if (this.AlbumTaskDataMap.ContainsKey(tabType))
			{
				foreach (AlbumTaskData albumTaskData in this.AlbumTaskDataMap[tabType])
				{
					if (albumTaskData.State == EBrochureState.Rewarded)
					{
						num++;
					}
					else if (albumTaskData.State == EBrochureState.Unlock)
					{
						redDotActive = true;
					}
				}
			}
			tab.SetRedDotActive(redDotActive);
			tab.InitProgress(num, maxNum);
		}

		// Token: 0x060333FF RID: 209919 RVA: 0x00E5DF38 File Offset: 0x00E5C138
		private void OnClickPicAmplifier()
		{
			if (this.CacheInformationTexturePath != null && this.CacheInformationTexturePath.Length > 0)
			{
				InfoDisplayModel.Instance.SetCurrentOpenInformationTexture(this.CacheInformationTexturePath);
				InfoDisplayController.Instance.OpenInfoDisplayImgView();
			}
		}

		// Token: 0x06033400 RID: 209920 RVA: 0x00E5DF6C File Offset: 0x00E5C16C
		[NullableContext(2)]
		private AlbumTaskData GetCurBookItemData()
		{
			if (this.AlbumTaskDataMap.ContainsKey(this.CurTabType))
			{
				List<AlbumTaskData> list = this.AlbumTaskDataMap[this.CurTabType];
				if (list != null && list.Count > 0 && this.CurrentTaskItemIndex >= 0)
				{
					return list[this.CurrentTaskItemIndex];
				}
			}
			return null;
		}

		// Token: 0x06033401 RID: 209921 RVA: 0x00E5DFC4 File Offset: 0x00E5C1C4
		private void OnClickBtnSecConfirmB()
		{
			AlbumTaskData curBookItemData = this.GetCurBookItemData();
			if (curBookItemData != null)
			{
				if (curBookItemData.State == EBrochureState.Unlock)
				{
					SpringManorController.Instance.RequestBrochureReward(this.ActivityId, this.CurTabType, curBookItemData.ConfigId, false);
					return;
				}
				BookItem? springManorBookItemById = SpringManorConfig.Instance.GetSpringManorBookItemById(curBookItemData.ConfigId);
				if (springManorBookItemById != null)
				{
					bool flag = SpringManorModel.Instance.IsQuestTracking(springManorBookItemById.Value.ConditionGroup);
					int conditionGroupQuestId = SpringManorConfig.Instance.GetConditionGroupQuestId(springManorBookItemById.Value.ConditionGroup);
					if (conditionGroupQuestId <= 0)
					{
						return;
					}
					SpringManorController instance = SpringManorController.Instance;
					if (instance != null)
					{
						instance.RequestTrackQuest(conditionGroupQuestId, !flag);
					}
					if (flag)
					{
						curBookItemData.IsFollowing = !flag;
						this.RefreshTabItem(this.CurTabType, false);
						return;
					}
					UiManager.Instance.ResetToBattleView(null);
				}
			}
		}

		// Token: 0x06033402 RID: 209922 RVA: 0x00E5E098 File Offset: 0x00E5C298
		public void ClickTaskItem(AlbumTaskData tabData, int index)
		{
			if (tabData != null)
			{
				this.CurrentTaskItemIndex = index;
				GenericScrollViewNew<SpringManorAlbumTaskItem, AlbumTaskData> scrollList = this.ScrollList;
				if (scrollList != null)
				{
					scrollList.SelectGridProxy(index, false);
				}
			}
			GenericScrollViewNew<SpringManorAlbumTaskItem, AlbumTaskData> scrollList2 = this.ScrollList;
			SpringManorAlbumTaskItem springManorAlbumTaskItem = (scrollList2 != null) ? scrollList2.GetScrollItemByIndex(index) : null;
			if (springManorAlbumTaskItem != null)
			{
				UUIScrollViewWithScrollbarComponent scrollViewComponent = this.ScrollViewComponent;
				if (scrollViewComponent != null)
				{
					scrollViewComponent.ScrollTo(springManorAlbumTaskItem.GetRootItem(), true);
				}
				UiNavigationNewController.Instance.SetNavigationFocusForView(springManorAlbumTaskItem.GetRootItem(), true, false, false);
			}
			this.SequencePlayer.PlayLevelSequenceByName("Switch_List", false, null, false);
		}

		// Token: 0x06033403 RID: 209923 RVA: 0x00E5E120 File Offset: 0x00E5C320
		private void InitBrochureData(EBrochureType tab)
		{
			if (!this.AlbumTaskDataMap.ContainsKey(tab))
			{
				Brochure? springManorBrochureByActivityAndType = SpringManorConfig.Instance.GetSpringManorBrochureByActivityAndType(this.ActivityId, tab);
				if (springManorBrochureByActivityAndType != null)
				{
					List<AlbumTaskData> list = new List<AlbumTaskData>();
					SpringManorData activityData = SpringManorModel.Instance.ActivityData;
					for (int i = 0; i < springManorBrochureByActivityAndType.Value.BookItemIdsLength; i++)
					{
						int num = springManorBrochureByActivityAndType.Value.BookItemIds(i);
						BookItem? springManorBookItemById = SpringManorConfig.Instance.GetSpringManorBookItemById(num);
						if (springManorBookItemById != null)
						{
							AlbumTaskData albumTaskData = new AlbumTaskData();
							albumTaskData.ConfigId = num;
							albumTaskData.IsFollowing = SpringManorModel.Instance.IsQuestTracking(springManorBookItemById.Value.ConditionGroup);
							int conditionGroupQuestId = SpringManorConfig.Instance.GetConditionGroupQuestId(springManorBookItemById.Value.ConditionGroup);
							albumTaskData.IsMainQuest = (conditionGroupQuestId > 0 && SpringManorModel.Instance.IsMainQuest(conditionGroupQuestId));
							albumTaskData.State = activityData.GetBookItemStateById(num);
							list.Add(albumTaskData);
						}
					}
					this.AlbumTaskDataMap.Add(tab, list);
				}
			}
		}

		// Token: 0x06033404 RID: 209924 RVA: 0x00E5E244 File Offset: 0x00E5C444
		private void RefreshBrochureItem(bool needSort)
		{
			if (!this.AlbumTaskDataMap.ContainsKey(this.CurTabType))
			{
				return;
			}
			List<AlbumTaskData> list;
			this.AlbumTaskDataMap.TryGetValue(this.CurTabType, out list);
			if (needSort && list != null)
			{
				list.Sort(new Comparison<AlbumTaskData>(this.SortFunc));
			}
			if (this.CurrentTaskItemCfgId > 0)
			{
				int num = (list != null) ? list.FindIndex((AlbumTaskData data) => data.ConfigId == this.CurrentTaskItemCfgId) : 0;
				this.CurrentTaskItemIndex = ((num >= 0) ? num : 0);
				this.CurrentTaskItemCfgId = 0;
			}
			if (list != null)
			{
				GenericScrollViewNew<SpringManorAlbumTaskItem, AlbumTaskData> scrollList = this.ScrollList;
				if (scrollList == null)
				{
					return;
				}
				scrollList.RefreshByData(list, delegate
				{
					GenericScrollViewNew<SpringManorAlbumTaskItem, AlbumTaskData> scrollList2 = this.ScrollList;
					if (scrollList2 != null)
					{
						scrollList2.SelectGridProxy(this.CurrentTaskItemIndex, false);
					}
					if (needSort)
					{
						UUIInturnAnimController animationController = this.AnimationController;
						if (animationController != null)
						{
							animationController.Play("Start", -1, false);
						}
						GenericScrollViewNew<SpringManorAlbumTaskItem, AlbumTaskData> scrollList3 = this.ScrollList;
						SpringManorAlbumTaskItem springManorAlbumTaskItem = (scrollList3 != null) ? scrollList3.GetScrollItemByIndex(this.CurrentTaskItemIndex) : null;
						if (springManorAlbumTaskItem != null)
						{
							UUIScrollViewWithScrollbarComponent scrollViewComponent = this.ScrollViewComponent;
							if (scrollViewComponent != null)
							{
								scrollViewComponent.ScrollTo(springManorAlbumTaskItem.GetRootItem(), true);
							}
							UiNavigationNewController.Instance.SetNavigationFocusForView(springManorAlbumTaskItem.GetRootItem(), true, false, false);
						}
					}
				}, true);
			}
		}

		// Token: 0x06033405 RID: 209925 RVA: 0x00E5E304 File Offset: 0x00E5C504
		private int SortFunc(AlbumTaskData a, AlbumTaskData b)
		{
			if (a.IsFollowing || b.IsFollowing)
			{
				if (!a.IsFollowing)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				if (a.State == b.State)
				{
					return a.ConfigId - b.ConfigId;
				}
				int stateSort = this.GetStateSort(b.State);
				int stateSort2 = this.GetStateSort(a.State);
				return stateSort - stateSort2;
			}
		}

		// Token: 0x06033406 RID: 209926 RVA: 0x00E5E364 File Offset: 0x00E5C564
		private int GetStateSort(EBrochureState state)
		{
			switch (state)
			{
			case EBrochureState.Lock:
				return 2;
			case EBrochureState.Unlock:
				return 3;
			case EBrochureState.Rewarded:
				return 1;
			default:
				return 0;
			}
		}

		// Token: 0x06033407 RID: 209927 RVA: 0x00E5E381 File Offset: 0x00E5C581
		private CommonItemSmallItemGrid InitGridItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = ((TItem _) => this.IsRewarded)
			};
		}

		// Token: 0x06033408 RID: 209928 RVA: 0x00E5E39C File Offset: 0x00E5C59C
		private void SetDetailInfo(AlbumTaskData data)
		{
			this.CacheInformationTexturePath = null;
			EBrochureState showState = data.State;
			if (data.State == EBrochureState.Unlock && this.IsNeedPlayUnlockSequence(data.ConfigId))
			{
				showState = EBrochureState.Lock;
			}
			this.SetGenericDetailInfo(data.ConfigId, data.State);
			if (this.CurTabType == EBrochureType.Character)
			{
				this.SetCharacterDetailInfo(data, showState);
				return;
			}
			this.SetEasterEggDetailInfo(data, showState);
		}

		// Token: 0x06033409 RID: 209929 RVA: 0x00E5E400 File Offset: 0x00E5C600
		private void SetEasterEggDetailInfo(AlbumTaskData data, EBrochureState showState)
		{
			bool flag = showState == EBrochureState.Lock;
			bool flag2 = showState == EBrochureState.Unlock;
			bool uiactive = flag || flag2;
			UUITexture texture = base.GetTexture(7);
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			UUIButtonComponent button = base.GetButton(8);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(!flag);
				}
			}
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(uiactive);
			}
			UUITexture texture2 = base.GetTexture(9);
			if (texture2 != null)
			{
				texture2.SetUIActive(true);
			}
			SpringManorConfig instance = SpringManorConfig.Instance;
			BookItem? bookItem = (instance != null) ? instance.GetSpringManorBookItemById(data.ConfigId) : null;
			if (bookItem != null)
			{
				this.CacheInformationTexturePath = (flag ? this.CacheEasterEggLockTexturePath : bookItem.Value.PohtoPath);
				base.SetTextureByPath(this.CacheEasterEggLockTexturePath, base.GetTexture(17), null, null);
				base.SetTextureByPath(this.CacheInformationTexturePath ?? "", base.GetTexture(9), null, null);
			}
		}

		// Token: 0x0603340A RID: 209930 RVA: 0x00E5E514 File Offset: 0x00E5C714
		private void SetCharacterDetailInfo(AlbumTaskData data, EBrochureState showState)
		{
			bool flag = showState == EBrochureState.Lock;
			UUIButtonComponent button = base.GetButton(8);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(!flag);
				}
			}
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUITexture texture = base.GetTexture(9);
			if (texture != null)
			{
				texture.SetUIActive(!flag);
			}
			SpringManorConfig instance = SpringManorConfig.Instance;
			BookItem? bookItem = (instance != null) ? instance.GetSpringManorBookItemById(data.ConfigId) : null;
			if (bookItem != null)
			{
				bool flag2 = flag && !StringUtils.IsBlank(bookItem.Value.IllustrationPath);
				UUITexture texture2 = base.GetTexture(7);
				if (texture2 != null)
				{
					texture2.SetUIActive(flag2);
				}
				string text = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male) ? bookItem.Value.PohtoPath : bookItem.Value.GirlPohtoPath;
				this.CacheInformationTexturePath = (flag ? null : text);
				if (flag2)
				{
					base.SetTextureByPath(bookItem.Value.IllustrationPath, base.GetTexture(7), null, null);
				}
				base.SetTextureByPath(flag ? this.CacheCharacterLockTexturePath : text, base.GetTexture(9), null, null);
				base.SetTextureByPath(this.CacheCharacterLockTexturePath, base.GetTexture(17), null, null);
			}
		}

		// Token: 0x0603340B RID: 209931 RVA: 0x00E5E68C File Offset: 0x00E5C88C
		private void SetGenericDetailInfo(int cfgId, EBrochureState state)
		{
			bool flag = state == EBrochureState.Lock;
			bool flag2 = state == EBrochureState.Unlock;
			bool flag3 = state == EBrochureState.Rewarded;
			UUIItem item = base.GetItem(12);
			if (item != null)
			{
				item.SetUIActive(flag3);
			}
			SpringManorConfig instance = SpringManorConfig.Instance;
			BookItem? bookItem = (instance != null) ? instance.GetSpringManorBookItemById(cfgId) : null;
			if (bookItem != null)
			{
				SpringManorAlbumConfirmItem btnConfirmItem = this.BtnConfirmItem;
				if (btnConfirmItem != null)
				{
					btnConfirmItem.SetState(state, bookItem.Value.ConditionGroup);
				}
				UUIText text = base.GetText(10);
				if (text != null)
				{
					text.ShowTextNew(flag ? bookItem.Value.GuideText : bookItem.Value.DescriptionText);
				}
				List<TItem> rewardItem = SpringManorConfig.Instance.GetRewardItem(bookItem.Value.DroptId);
				this.SetRewardItems(rewardItem, flag3);
			}
			if (this.CurTabType == EBrochureType.Character)
			{
				UUIItem uuiitem = base.GetButton(11).RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(flag || flag2);
				}
				UUIItem item2 = base.GetItem(13);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(false);
				return;
			}
			else
			{
				UUIItem uuiitem2 = base.GetButton(11).RootUIComp.Get();
				if (uuiitem2 != null)
				{
					uuiitem2.SetUIActive(flag2);
				}
				UUIItem item3 = base.GetItem(13);
				if (item3 == null)
				{
					return;
				}
				item3.SetUIActive(flag);
				return;
			}
		}

		// Token: 0x0603340C RID: 209932 RVA: 0x00E5E7D8 File Offset: 0x00E5C9D8
		[NullableContext(2)]
		public void SetRewardItems(List<TItem> rewardItems, bool isRewarded)
		{
			this.IsRewarded = isRewarded;
			bool flag = rewardItems != null && rewardItems.Count > 0;
			GenericLayout<CommonItemSmallItemGrid, TItem> itemLayout = this.ItemLayout;
			if (itemLayout != null)
			{
				itemLayout.SetActive(flag);
			}
			if (flag)
			{
				GenericLayout<CommonItemSmallItemGrid, TItem> itemLayout2 = this.ItemLayout;
				if (itemLayout2 == null)
				{
					return;
				}
				itemLayout2.RefreshByData(rewardItems, null, false);
			}
		}

		// Token: 0x0603340D RID: 209933 RVA: 0x00E5E824 File Offset: 0x00E5CA24
		private bool IsNeedPlayUnlockSequence(int configId)
		{
			HashSet<int> player = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.SpringManorBrochureUnlockSequencePlayed, null);
			return player == null || !player.Contains(configId);
		}

		// Token: 0x0603340E RID: 209934 RVA: 0x00E5E84C File Offset: 0x00E5CA4C
		public void CheckPlayUnlockSequence()
		{
			AlbumTaskData curBookItemData = this.GetCurBookItemData();
			if (curBookItemData == null || curBookItemData.State != EBrochureState.Unlock)
			{
				return;
			}
			int configId = curBookItemData.ConfigId;
			HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.SpringManorBrochureUnlockSequencePlayed, null) ?? new HashSet<int>();
			if (hashSet == null || !hashSet.Contains(configId))
			{
				hashSet.Add(configId);
				LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.SpringManorBrochureUnlockSequencePlayed, hashSet);
				LevelSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer == null)
				{
					return;
				}
				sequencePlayer.PlayLevelSequenceByName("Unlock", true, null, false);
			}
		}

		// Token: 0x0401B3B0 RID: 111536
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B3B1 RID: 111537
		[Nullable(2)]
		private SpringManorAlbumTabItem TogCharacterTab;

		// Token: 0x0401B3B2 RID: 111538
		[Nullable(2)]
		private SpringManorAlbumTabItem TogEasterEggTab;

		// Token: 0x0401B3B3 RID: 111539
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<SpringManorAlbumTaskItem, AlbumTaskData> ScrollList;

		// Token: 0x0401B3B4 RID: 111540
		[Nullable(2)]
		private SpringManorAlbumConfirmItem BtnConfirmItem;

		// Token: 0x0401B3B5 RID: 111541
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> ItemLayout;

		// Token: 0x0401B3B6 RID: 111542
		[Nullable(2)]
		private UUIScrollViewWithScrollbarComponent ScrollViewComponent;

		// Token: 0x0401B3B7 RID: 111543
		private EBrochureType CurTabType = EBrochureType.Brochure;

		// Token: 0x0401B3B8 RID: 111544
		private int ActivityId;

		// Token: 0x0401B3B9 RID: 111545
		private bool IsRewarded;

		// Token: 0x0401B3BA RID: 111546
		private int CurrentTaskItemIndex;

		// Token: 0x0401B3BB RID: 111547
		private int CurrentTaskItemCfgId;

		// Token: 0x0401B3BC RID: 111548
		private readonly Dictionary<EBrochureType, List<AlbumTaskData>> AlbumTaskDataMap = new Dictionary<EBrochureType, List<AlbumTaskData>>();

		// Token: 0x0401B3BD RID: 111549
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401B3BE RID: 111550
		[Nullable(2)]
		private UUIInturnAnimController AnimationController;

		// Token: 0x0401B3BF RID: 111551
		[Nullable(2)]
		private string CacheInformationTexturePath;

		// Token: 0x0401B3C0 RID: 111552
		private string CacheCharacterLockTexturePath = "";

		// Token: 0x0401B3C1 RID: 111553
		private string CacheEasterEggLockTexturePath = "";

		// Token: 0x0200ACCA RID: 44234
		[NullableContext(0)]
		[RequiredMember]
		public class Params
		{
			// Token: 0x06046C1A RID: 289818 RVA: 0x0155D966 File Offset: 0x0155BB66
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public Params()
			{
			}

			// Token: 0x040356F6 RID: 218870
			[RequiredMember]
			public EBrochureType OpenTab;
		}
	}
}
