using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057F7 RID: 22519
	[NullableContext(2)]
	[Nullable(0)]
	public class ExploreRewardView : UiViewBase
	{
		// Token: 0x060393E3 RID: 234467 RVA: 0x00D92BA7 File Offset: 0x00D90DA7
		[NullableContext(1)]
		public ExploreRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060393E4 RID: 234468 RVA: 0x00D92BBC File Offset: 0x00D90DBC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x060393E5 RID: 234469 RVA: 0x00D92DA4 File Offset: 0x00D90FA4
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IReadOnlyList<RewardItemData>>(EEventName.OnRefreshRewardViewItemList, new Action<IReadOnlyList<RewardItemData>>(this.OnRefreshRewardItemList));
			EventSystem.Instance.Add(EEventName.OnRefreshRewardButton, new Action(this.OnRefreshRewardButton));
			EventSystem.Instance.Add(EEventName.FriendApplyReceived, new Action(this.OnRefreshFriendApply));
			EventSystem.Instance.Add(EEventName.FriendApplicationListUpdate, new Action(this.OnRefreshFriendList));
			EventSystem.Instance.Add(EEventName.FriendAdded, new Action(this.OnRefreshFriendList));
			this.UiViewSequence.AddSequenceFinishEvent("Success", new Action<string>(this.OnRewardSequenceEnd), false);
			this.UiViewSequence.AddSequenceFinishEvent("Fail", new Action<string>(this.OnRewardSequenceEnd), false);
		}

		// Token: 0x060393E6 RID: 234470 RVA: 0x00D92E78 File Offset: 0x00D91078
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnRefreshRewardViewItemList, new Action<IReadOnlyList<RewardItemData>>(this.OnRefreshRewardItemList));
			EventSystem.Instance.Remove(EEventName.OnRefreshRewardButton, new Action(this.OnRefreshRewardButton));
			EventSystem.Instance.Remove(EEventName.FriendApplyReceived, new Action(this.OnRefreshFriendApply));
			EventSystem.Instance.Remove(EEventName.FriendApplicationListUpdate, new Action(this.OnRefreshFriendList));
			EventSystem.Instance.Remove(EEventName.FriendAdded, new Action(this.OnRefreshFriendList));
			this.UiViewSequence.RemoveSequenceFinishEvent("Success", new Action<string>(this.OnRewardSequenceEnd));
			this.UiViewSequence.RemoveSequenceFinishEvent("Fail", new Action<string>(this.OnRewardSequenceEnd));
		}

		// Token: 0x060393E7 RID: 234471 RVA: 0x00D92F4C File Offset: 0x00D9114C
		private void OnRefreshRewardButton()
		{
			List<IRewardExploreConfirmButton> buttonInfoList = this.ExtendRewardInfo.ButtonInfoList;
			if (buttonInfoList != null && buttonInfoList.Count > 0)
			{
				int num = 0;
				foreach (IRewardExploreConfirmButton buttonData in buttonInfoList)
				{
					this.ButtonList[num].Refresh(buttonData);
					num++;
				}
			}
		}

		// Token: 0x060393E8 RID: 234472 RVA: 0x00D92FC4 File Offset: 0x00D911C4
		private void OnRefreshFriendList()
		{
			List<IRewardExploreFriendData> exploreFriendDataList = ItemRewardController.Instance.BuildExploreFriendDataList();
			ItemRewardController.Instance.SetExploreFriendDataList(exploreFriendDataList);
			this.RefreshFriendList();
		}

		// Token: 0x060393E9 RID: 234473 RVA: 0x00D92FF0 File Offset: 0x00D911F0
		private void OnRefreshFriendApply()
		{
			List<int> list = ItemRewardController.Instance.BuildExploreFriendIdList();
			if (FriendController.Instance.CheckHasAnyApplied(list.ToArray()) && !UiManager.Instance.IsViewOpen(EUiViewName.FriendApplyView))
			{
				UiManager.Instance.OpenView(EUiViewName.FriendApplyView, list, null);
			}
		}

		// Token: 0x060393EA RID: 234474 RVA: 0x00D9303C File Offset: 0x00D9123C
		[NullableContext(1)]
		private void OnRefreshRewardItemList(IReadOnlyList<RewardItemData> itemList)
		{
			if (this.RewardItemList == null)
			{
				return;
			}
			this.RewardItemList.Refresh(this.RewardData.GetItemList(), true);
		}

		// Token: 0x060393EB RID: 234475 RVA: 0x00D93060 File Offset: 0x00D91260
		protected override UniTask OnBeforeStartAsync()
		{
			ExploreRewardView.<OnBeforeStartAsync>d__31 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ExploreRewardView.<OnBeforeStartAsync>d__31>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060393EC RID: 234476 RVA: 0x00D930A3 File Offset: 0x00D912A3
		protected override void OnStart()
		{
			this.RefreshTipText();
			if (this.RefreshTitleVisible())
			{
				this.RefreshTitleText();
				this.RefreshTitleColor();
			}
			if (this.RefreshTitleTextureVisible())
			{
				this.RefreshTitleTexture();
			}
		}

		// Token: 0x060393ED RID: 234477 RVA: 0x00D930CD File Offset: 0x00D912CD
		protected override void OnAfterShow()
		{
			if (this.ExtendRewardInfo.ExploreFriendDataList != null)
			{
				this.OnRefreshFriendApply();
			}
		}

		// Token: 0x060393EE RID: 234478 RVA: 0x00D930E4 File Offset: 0x00D912E4
		protected override void OnAfterPlayStartSequence()
		{
			if (this.RewardData.GetRewardInfo().IsSuccess)
			{
				this.UiViewSequence.PlaySequence("Success", true, null);
				return;
			}
			this.UiViewSequence.PlaySequence("Fail", true, null);
		}

		// Token: 0x060393EF RID: 234479 RVA: 0x00D93138 File Offset: 0x00D91338
		protected override void OnBeforeDestroy()
		{
			Action onCloseCallback = this.RewardInfo.OnCloseCallback;
			if (onCloseCallback != null)
			{
				onCloseCallback();
			}
			this.RewardData = null;
			this.RewardInfo = null;
			RewardExploreRecord rewardExploreRecord = this.RewardExploreRecord;
			if (rewardExploreRecord != null)
			{
				rewardExploreRecord.Destroy(null);
			}
			this.RewardExploreRecord = null;
			RewardItemList rewardItemList = this.RewardItemList;
			if (rewardItemList != null)
			{
				rewardItemList.Destroy(null);
			}
			this.RewardItemList = null;
			RewardExploreBarList rewardExploreBarList = this.RewardExploreBarList;
			if (rewardExploreBarList != null)
			{
				rewardExploreBarList.Destroy(null);
			}
			this.RewardExploreBarList = null;
			RewardExploreTargetReachedList rewardExploreTargetReachedList = this.RewardExploreTargetReachedList;
			if (rewardExploreTargetReachedList != null)
			{
				rewardExploreTargetReachedList.Destroy(null);
			}
			this.RewardExploreTargetReachedList = null;
			RewardExploreScoreSubTitle rewardExploreScoreSubTitle = this.RewardExploreScoreSubTitle;
			if (rewardExploreScoreSubTitle != null)
			{
				rewardExploreScoreSubTitle.Destroy(null);
			}
			this.RewardExploreScoreSubTitle = null;
			RewardExploreToggle rewardExploreToggle = this.RewardExploreToggle;
			if (rewardExploreToggle != null)
			{
				rewardExploreToggle.Destroy(null);
			}
			this.RewardExploreToggle = null;
			RewardExploreDescription rewardExploreDescription = this.RewardExploreDescription;
			if (rewardExploreDescription != null)
			{
				rewardExploreDescription.Destroy(null);
			}
			this.RewardExploreDescription = null;
			RewardExploreRoguelikeBossChallengeItem rewardExploreRoguelikeBossChallengeItem = this.RewardExploreRoguelikeBossChallengeItem;
			if (rewardExploreRoguelikeBossChallengeItem != null)
			{
				rewardExploreRoguelikeBossChallengeItem.Destroy(null);
			}
			this.RewardExploreRoguelikeBossChallengeItem = null;
			BagFullTip bagFullTip = this.BagFullTip;
			if (bagFullTip != null)
			{
				bagFullTip.Destroy(null);
			}
			this.BagFullTip = null;
			foreach (RewardExploreConfirmButton rewardExploreConfirmButton in this.ButtonList)
			{
				rewardExploreConfirmButton.Destroy(null);
			}
			this.ButtonList.Clear();
			ItemRewardModel.Instance.ClearCurrentRewardData();
			if (UiManager.Instance.IsViewOpen(EUiViewName.FriendApplyView))
			{
				UiManager.Instance.CloseView(EUiViewName.FriendApplyView, null);
			}
		}

		// Token: 0x060393F0 RID: 234480 RVA: 0x00D932C4 File Offset: 0x00D914C4
		private bool RefreshTitleVisible()
		{
			UUIItem item = base.GetItem(0);
			bool flag = !StringUtils.IsEmpty(this.RewardInfo.Title);
			item.SetUIActive(flag);
			return flag;
		}

		// Token: 0x060393F1 RID: 234481 RVA: 0x00D932F4 File Offset: 0x00D914F4
		private void RefreshTitleText()
		{
			UUIText text = base.GetText(1);
			string title = this.RewardInfo.Title;
			if (!StringUtils.IsEmpty(title))
			{
				LguiUtil.Instance.SetLocalTextNew(text, title, Array.Empty<object>());
			}
		}

		// Token: 0x060393F2 RID: 234482 RVA: 0x00D93330 File Offset: 0x00D91530
		private void RefreshTipText()
		{
			base.GetItem(18).SetUIActive(this.RewardInfo.Tip != null);
			if (this.RewardInfo.Tip != null)
			{
				base.GetText(19).SetText(this.RewardInfo.Tip, true);
			}
		}

		// Token: 0x060393F3 RID: 234483 RVA: 0x00D93380 File Offset: 0x00D91580
		private void RefreshTitleColor()
		{
			UUIText text = base.GetText(1);
			UUIEffectOutline uuieffectOutline = text.GetOwner().GetComponentByClass(UUIEffectOutline.StaticClass()) as UUIEffectOutline;
			string titleHexColor = this.RewardInfo.TitleHexColor;
			if (!StringUtils.IsEmpty(titleHexColor))
			{
				text.SetColor(FColor.FromHex(titleHexColor));
			}
			if (this.RewardInfo.IsSuccess)
			{
				uuieffectOutline.SetOutlineColor(FColor.FromHex("C48B29FF"));
				return;
			}
			uuieffectOutline.SetOutlineColor(FColor.FromHex("B33100FF"));
		}

		// Token: 0x060393F4 RID: 234484 RVA: 0x00D93400 File Offset: 0x00D91600
		private bool RefreshTitleTextureVisible()
		{
			UUIItem texture = base.GetTexture(2);
			bool flag = !StringUtils.IsEmpty(this.RewardInfo.TitleIconPath);
			texture.SetUIActive(flag);
			return flag;
		}

		// Token: 0x060393F5 RID: 234485 RVA: 0x00D93430 File Offset: 0x00D91630
		private void RefreshTitleTexture()
		{
			UUITexture titleTexture = base.GetTexture(2);
			string titleIconPath = this.RewardInfo.TitleIconPath;
			string titleIconHexColor = this.RewardInfo.TitleIconHexColor;
			if (!StringUtils.IsEmpty(titleIconPath))
			{
				titleTexture.SetUIActive(false);
				base.SetTextureByPath(titleIconPath, titleTexture, null, delegate(bool _)
				{
					titleTexture.SetUIActive(true);
				});
			}
			if (!StringUtils.IsEmpty(titleIconHexColor))
			{
				titleTexture.SetColor(FColor.FromHex(titleIconHexColor));
			}
		}

		// Token: 0x060393F6 RID: 234486 RVA: 0x00D934B8 File Offset: 0x00D916B8
		private void RefreshFriendList()
		{
			List<IRewardExploreFriendData> exploreFriendDataList = this.ExtendRewardInfo.ExploreFriendDataList;
			if (exploreFriendDataList != null)
			{
				GenericLayout<RewardExploreFriendItem, IRewardExploreFriendData> rewardExploreFriendList = this.RewardExploreFriendList;
				if (rewardExploreFriendList == null)
				{
					return;
				}
				rewardExploreFriendList.RefreshByData(exploreFriendDataList, null, false);
			}
		}

		// Token: 0x060393F7 RID: 234487 RVA: 0x00D934E8 File Offset: 0x00D916E8
		private UniTask NewExploreRecord()
		{
			ExploreRewardView.<NewExploreRecord>d__43 <NewExploreRecord>d__;
			<NewExploreRecord>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewExploreRecord>d__.<>4__this = this;
			<NewExploreRecord>d__.<>1__state = -1;
			<NewExploreRecord>d__.<>t__builder.Start<ExploreRewardView.<NewExploreRecord>d__43>(ref <NewExploreRecord>d__);
			return <NewExploreRecord>d__.<>t__builder.Task;
		}

		// Token: 0x060393F8 RID: 234488 RVA: 0x00D9352C File Offset: 0x00D9172C
		private UniTask NewRewardItemList()
		{
			ExploreRewardView.<NewRewardItemList>d__44 <NewRewardItemList>d__;
			<NewRewardItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewRewardItemList>d__.<>4__this = this;
			<NewRewardItemList>d__.<>1__state = -1;
			<NewRewardItemList>d__.<>t__builder.Start<ExploreRewardView.<NewRewardItemList>d__44>(ref <NewRewardItemList>d__);
			return <NewRewardItemList>d__.<>t__builder.Task;
		}

		// Token: 0x060393F9 RID: 234489 RVA: 0x00D93570 File Offset: 0x00D91770
		private UniTask NewBagFullTip()
		{
			ExploreRewardView.<NewBagFullTip>d__45 <NewBagFullTip>d__;
			<NewBagFullTip>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewBagFullTip>d__.<>4__this = this;
			<NewBagFullTip>d__.<>1__state = -1;
			<NewBagFullTip>d__.<>t__builder.Start<ExploreRewardView.<NewBagFullTip>d__45>(ref <NewBagFullTip>d__);
			return <NewBagFullTip>d__.<>t__builder.Task;
		}

		// Token: 0x060393FA RID: 234490 RVA: 0x00D935B4 File Offset: 0x00D917B4
		private UniTask NewExploreBarList()
		{
			ExploreRewardView.<NewExploreBarList>d__46 <NewExploreBarList>d__;
			<NewExploreBarList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewExploreBarList>d__.<>4__this = this;
			<NewExploreBarList>d__.<>1__state = -1;
			<NewExploreBarList>d__.<>t__builder.Start<ExploreRewardView.<NewExploreBarList>d__46>(ref <NewExploreBarList>d__);
			return <NewExploreBarList>d__.<>t__builder.Task;
		}

		// Token: 0x060393FB RID: 234491 RVA: 0x00D935F8 File Offset: 0x00D917F8
		private UniTask NewExploreDescription()
		{
			ExploreRewardView.<NewExploreDescription>d__47 <NewExploreDescription>d__;
			<NewExploreDescription>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewExploreDescription>d__.<>4__this = this;
			<NewExploreDescription>d__.<>1__state = -1;
			<NewExploreDescription>d__.<>t__builder.Start<ExploreRewardView.<NewExploreDescription>d__47>(ref <NewExploreDescription>d__);
			return <NewExploreDescription>d__.<>t__builder.Task;
		}

		// Token: 0x060393FC RID: 234492 RVA: 0x00D9363C File Offset: 0x00D9183C
		private UniTask NewTargetReachedList()
		{
			ExploreRewardView.<NewTargetReachedList>d__48 <NewTargetReachedList>d__;
			<NewTargetReachedList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewTargetReachedList>d__.<>4__this = this;
			<NewTargetReachedList>d__.<>1__state = -1;
			<NewTargetReachedList>d__.<>t__builder.Start<ExploreRewardView.<NewTargetReachedList>d__48>(ref <NewTargetReachedList>d__);
			return <NewTargetReachedList>d__.<>t__builder.Task;
		}

		// Token: 0x060393FD RID: 234493 RVA: 0x00D93680 File Offset: 0x00D91880
		private UniTask NewScoreSubTitle()
		{
			ExploreRewardView.<NewScoreSubTitle>d__49 <NewScoreSubTitle>d__;
			<NewScoreSubTitle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewScoreSubTitle>d__.<>4__this = this;
			<NewScoreSubTitle>d__.<>1__state = -1;
			<NewScoreSubTitle>d__.<>t__builder.Start<ExploreRewardView.<NewScoreSubTitle>d__49>(ref <NewScoreSubTitle>d__);
			return <NewScoreSubTitle>d__.<>t__builder.Task;
		}

		// Token: 0x060393FE RID: 234494 RVA: 0x00D936C4 File Offset: 0x00D918C4
		private UniTask NewOnlineChallengePlayer()
		{
			ExploreRewardView.<NewOnlineChallengePlayer>d__50 <NewOnlineChallengePlayer>d__;
			<NewOnlineChallengePlayer>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewOnlineChallengePlayer>d__.<>4__this = this;
			<NewOnlineChallengePlayer>d__.<>1__state = -1;
			<NewOnlineChallengePlayer>d__.<>t__builder.Start<ExploreRewardView.<NewOnlineChallengePlayer>d__50>(ref <NewOnlineChallengePlayer>d__);
			return <NewOnlineChallengePlayer>d__.<>t__builder.Task;
		}

		// Token: 0x060393FF RID: 234495 RVA: 0x00D93708 File Offset: 0x00D91908
		private UniTask NewStateToggle()
		{
			ExploreRewardView.<NewStateToggle>d__51 <NewStateToggle>d__;
			<NewStateToggle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewStateToggle>d__.<>4__this = this;
			<NewStateToggle>d__.<>1__state = -1;
			<NewStateToggle>d__.<>t__builder.Start<ExploreRewardView.<NewStateToggle>d__51>(ref <NewStateToggle>d__);
			return <NewStateToggle>d__.<>t__builder.Task;
		}

		// Token: 0x06039400 RID: 234496 RVA: 0x00D9374C File Offset: 0x00D9194C
		private UniTask NewScoreReach()
		{
			ExploreRewardView.<NewScoreReach>d__52 <NewScoreReach>d__;
			<NewScoreReach>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewScoreReach>d__.<>4__this = this;
			<NewScoreReach>d__.<>1__state = -1;
			<NewScoreReach>d__.<>t__builder.Start<ExploreRewardView.<NewScoreReach>d__52>(ref <NewScoreReach>d__);
			return <NewScoreReach>d__.<>t__builder.Task;
		}

		// Token: 0x06039401 RID: 234497 RVA: 0x00D93790 File Offset: 0x00D91990
		private UniTask NewAccumulatedScoreItem()
		{
			ExploreRewardView.<NewAccumulatedScoreItem>d__53 <NewAccumulatedScoreItem>d__;
			<NewAccumulatedScoreItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAccumulatedScoreItem>d__.<>4__this = this;
			<NewAccumulatedScoreItem>d__.<>1__state = -1;
			<NewAccumulatedScoreItem>d__.<>t__builder.Start<ExploreRewardView.<NewAccumulatedScoreItem>d__53>(ref <NewAccumulatedScoreItem>d__);
			return <NewAccumulatedScoreItem>d__.<>t__builder.Task;
		}

		// Token: 0x06039402 RID: 234498 RVA: 0x00D937D4 File Offset: 0x00D919D4
		private UniTask NewFriendList()
		{
			ExploreRewardView.<NewFriendList>d__54 <NewFriendList>d__;
			<NewFriendList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewFriendList>d__.<>4__this = this;
			<NewFriendList>d__.<>1__state = -1;
			<NewFriendList>d__.<>t__builder.Start<ExploreRewardView.<NewFriendList>d__54>(ref <NewFriendList>d__);
			return <NewFriendList>d__.<>t__builder.Task;
		}

		// Token: 0x06039403 RID: 234499 RVA: 0x00D93818 File Offset: 0x00D91A18
		private UniTask NewBabelTowerSuccessItem()
		{
			ExploreRewardView.<NewBabelTowerSuccessItem>d__55 <NewBabelTowerSuccessItem>d__;
			<NewBabelTowerSuccessItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewBabelTowerSuccessItem>d__.<>4__this = this;
			<NewBabelTowerSuccessItem>d__.<>1__state = -1;
			<NewBabelTowerSuccessItem>d__.<>t__builder.Start<ExploreRewardView.<NewBabelTowerSuccessItem>d__55>(ref <NewBabelTowerSuccessItem>d__);
			return <NewBabelTowerSuccessItem>d__.<>t__builder.Task;
		}

		// Token: 0x06039404 RID: 234500 RVA: 0x00D9385C File Offset: 0x00D91A5C
		private UniTask NewDangoAbyssSuccessItem()
		{
			ExploreRewardView.<NewDangoAbyssSuccessItem>d__56 <NewDangoAbyssSuccessItem>d__;
			<NewDangoAbyssSuccessItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewDangoAbyssSuccessItem>d__.<>4__this = this;
			<NewDangoAbyssSuccessItem>d__.<>1__state = -1;
			<NewDangoAbyssSuccessItem>d__.<>t__builder.Start<ExploreRewardView.<NewDangoAbyssSuccessItem>d__56>(ref <NewDangoAbyssSuccessItem>d__);
			return <NewDangoAbyssSuccessItem>d__.<>t__builder.Task;
		}

		// Token: 0x06039405 RID: 234501 RVA: 0x00D938A0 File Offset: 0x00D91AA0
		private UniTask NewHonamiTowerSuccessItem()
		{
			ExploreRewardView.<NewHonamiTowerSuccessItem>d__57 <NewHonamiTowerSuccessItem>d__;
			<NewHonamiTowerSuccessItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewHonamiTowerSuccessItem>d__.<>4__this = this;
			<NewHonamiTowerSuccessItem>d__.<>1__state = -1;
			<NewHonamiTowerSuccessItem>d__.<>t__builder.Start<ExploreRewardView.<NewHonamiTowerSuccessItem>d__57>(ref <NewHonamiTowerSuccessItem>d__);
			return <NewHonamiTowerSuccessItem>d__.<>t__builder.Task;
		}

		// Token: 0x06039406 RID: 234502 RVA: 0x00D938E4 File Offset: 0x00D91AE4
		private UniTask NewRoguelikeBossChallengeItem()
		{
			ExploreRewardView.<NewRoguelikeBossChallengeItem>d__58 <NewRoguelikeBossChallengeItem>d__;
			<NewRoguelikeBossChallengeItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewRoguelikeBossChallengeItem>d__.<>4__this = this;
			<NewRoguelikeBossChallengeItem>d__.<>1__state = -1;
			<NewRoguelikeBossChallengeItem>d__.<>t__builder.Start<ExploreRewardView.<NewRoguelikeBossChallengeItem>d__58>(ref <NewRoguelikeBossChallengeItem>d__);
			return <NewRoguelikeBossChallengeItem>d__.<>t__builder.Task;
		}

		// Token: 0x06039407 RID: 234503 RVA: 0x00D93928 File Offset: 0x00D91B28
		[NullableContext(1)]
		private RewardExploreConfirmButton NewButton(IRewardExploreConfirmButton buttonData, int buttonIndex)
		{
			UUIItem item = base.GetItem(5);
			UUIItem item2 = base.GetItem(4);
			RewardExploreConfirmButton rewardExploreConfirmButton = new RewardExploreConfirmButton(LguiUtil.Instance.DuplicateActor(item.GetOwner(), item2), buttonIndex);
			rewardExploreConfirmButton.Refresh(buttonData);
			rewardExploreConfirmButton.SetActive(true);
			this.ButtonList.Add(rewardExploreConfirmButton);
			return rewardExploreConfirmButton;
		}

		// Token: 0x06039408 RID: 234504 RVA: 0x00D93978 File Offset: 0x00D91B78
		[NullableContext(1)]
		private RewardExploreFriendItem CreateFriendGrid()
		{
			return new RewardExploreFriendItem();
		}

		// Token: 0x06039409 RID: 234505 RVA: 0x00D93980 File Offset: 0x00D91B80
		public EToggleState? GetBottomToggleState()
		{
			RewardExploreToggle rewardExploreToggle = this.RewardExploreToggle;
			if (rewardExploreToggle == null)
			{
				return null;
			}
			return rewardExploreToggle.GetToggleState();
		}

		// Token: 0x0603940A RID: 234506 RVA: 0x00D939A6 File Offset: 0x00D91BA6
		[NullableContext(1)]
		private void OnRewardSequenceEnd(string seqName)
		{
			RewardExploreOnlineChallengePlayer rewardExploreOnlineChallengePlayer = this.RewardExploreOnlineChallengePlayer;
			if (rewardExploreOnlineChallengePlayer == null)
			{
				return;
			}
			rewardExploreOnlineChallengePlayer.FullRefresh();
		}

		// Token: 0x0401DF17 RID: 122647
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private RewardData<IExploreRewardInfo> RewardData;

		// Token: 0x0401DF18 RID: 122648
		private IExploreRewardInfo RewardInfo;

		// Token: 0x0401DF19 RID: 122649
		private IExtendRewardInfo ExtendRewardInfo;

		// Token: 0x0401DF1A RID: 122650
		private RewardExploreRecord RewardExploreRecord;

		// Token: 0x0401DF1B RID: 122651
		private RewardItemList RewardItemList;

		// Token: 0x0401DF1C RID: 122652
		private RewardExploreBarList RewardExploreBarList;

		// Token: 0x0401DF1D RID: 122653
		private RewardExploreDescription RewardExploreDescription;

		// Token: 0x0401DF1E RID: 122654
		private RewardExploreTargetReachedList RewardExploreTargetReachedList;

		// Token: 0x0401DF1F RID: 122655
		private RewardExploreScoreSubTitle RewardExploreScoreSubTitle;

		// Token: 0x0401DF20 RID: 122656
		private RewardExploreOnlineChallengePlayer RewardExploreOnlineChallengePlayer;

		// Token: 0x0401DF21 RID: 122657
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RewardExploreFriendItem, IRewardExploreFriendData> RewardExploreFriendList;

		// Token: 0x0401DF22 RID: 122658
		private BagFullTip BagFullTip;

		// Token: 0x0401DF23 RID: 122659
		private RewardExploreToggle RewardExploreToggle;

		// Token: 0x0401DF24 RID: 122660
		private RewardExploreScore RewardExploreScore;

		// Token: 0x0401DF25 RID: 122661
		private RewardExploreAccumulatedScoreItem RewardExploreAccumulatedScoreItem;

		// Token: 0x0401DF26 RID: 122662
		private RewardExploreBabelSuccessItem RewardExploreBabelSuccessItem;

		// Token: 0x0401DF27 RID: 122663
		private RewardExploreDangoAbyssSuccessItem RewardExploreDangoAbyssSuccessItem;

		// Token: 0x0401DF28 RID: 122664
		private RewardExploreHonamiTowerSuccessItem RewardExploreHonamiTowerSuccessItem;

		// Token: 0x0401DF29 RID: 122665
		private RewardExploreRoguelikeBossChallengeItem RewardExploreRoguelikeBossChallengeItem;

		// Token: 0x0401DF2A RID: 122666
		[Nullable(1)]
		private readonly List<RewardExploreConfirmButton> ButtonList = new List<RewardExploreConfirmButton>();

		// Token: 0x0401DF2B RID: 122667
		[Nullable(1)]
		private const string SUCCESS_OUTLINE_COLOR = "C48B29FF";

		// Token: 0x0401DF2C RID: 122668
		[Nullable(1)]
		private const string FAIL_OUTLINE_COLOR = "B33100FF";

		// Token: 0x0200B9D5 RID: 47573
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040382E7 RID: 230119
			public const int TitleItem = 0;

			// Token: 0x040382E8 RID: 230120
			public const int TitleText = 1;

			// Token: 0x040382E9 RID: 230121
			public const int TitleTexture = 2;

			// Token: 0x040382EA RID: 230122
			public const int ContentItem = 3;

			// Token: 0x040382EB RID: 230123
			public const int ButtonHorizontalItem = 4;

			// Token: 0x040382EC RID: 230124
			public const int ButtonItem = 5;

			// Token: 0x040382ED RID: 230125
			public const int ToggleItem = 6;

			// Token: 0x040382EE RID: 230126
			public const int DoubleTip = 18;

			// Token: 0x040382EF RID: 230127
			public const int DoubleTipTxt = 19;

			// Token: 0x040382F0 RID: 230128
			public const int Content = 20;

			// Token: 0x040382F1 RID: 230129
			public const int FriendItem = 21;

			// Token: 0x040382F2 RID: 230130
			public const int FriendGrid = 22;

			// Token: 0x040382F3 RID: 230131
			public const int ItemTeam = 23;
		}
	}
}
