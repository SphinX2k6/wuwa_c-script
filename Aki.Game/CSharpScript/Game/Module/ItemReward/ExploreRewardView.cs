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
	// Token: 0x020047CE RID: 18382
	[NullableContext(2)]
	[Nullable(0)]
	public class ExploreRewardView : UiViewBase
	{
		// Token: 0x0602E2F7 RID: 189175 RVA: 0x00CE19EF File Offset: 0x00CDFBEF
		[NullableContext(1)]
		public ExploreRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602E2F8 RID: 189176 RVA: 0x00CE1A04 File Offset: 0x00CDFC04
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

		// Token: 0x0602E2F9 RID: 189177 RVA: 0x00CE1BEC File Offset: 0x00CDFDEC
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

		// Token: 0x0602E2FA RID: 189178 RVA: 0x00CE1CC0 File Offset: 0x00CDFEC0
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

		// Token: 0x0602E2FB RID: 189179 RVA: 0x00CE1D94 File Offset: 0x00CDFF94
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

		// Token: 0x0602E2FC RID: 189180 RVA: 0x00CE1E0C File Offset: 0x00CE000C
		private void OnRefreshFriendList()
		{
			List<IRewardExploreFriendData> exploreFriendDataList = ItemRewardController.Instance.BuildExploreFriendDataList();
			ItemRewardController.Instance.SetExploreFriendDataList(exploreFriendDataList);
			this.RefreshFriendList();
		}

		// Token: 0x0602E2FD RID: 189181 RVA: 0x00CE1E38 File Offset: 0x00CE0038
		private void OnRefreshFriendApply()
		{
			List<int> list = ItemRewardController.Instance.BuildExploreFriendIdList();
			if (FriendController.Instance.CheckHasAnyApplied(list.ToArray()) && !UiManager.Instance.IsViewOpen(EUiViewName.FriendApplyView))
			{
				UiManager.Instance.OpenView(EUiViewName.FriendApplyView, list, null);
			}
		}

		// Token: 0x0602E2FE RID: 189182 RVA: 0x00CE1E84 File Offset: 0x00CE0084
		[NullableContext(1)]
		private void OnRefreshRewardItemList(IReadOnlyList<RewardItemData> itemList)
		{
			if (this.RewardItemList == null)
			{
				return;
			}
			this.RewardItemList.Refresh(this.RewardData.GetItemList(), true);
		}

		// Token: 0x0602E2FF RID: 189183 RVA: 0x00CE1EA8 File Offset: 0x00CE00A8
		protected override UniTask OnBeforeStartAsync()
		{
			ExploreRewardView.<OnBeforeStartAsync>d__31 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ExploreRewardView.<OnBeforeStartAsync>d__31>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E300 RID: 189184 RVA: 0x00CE1EEB File Offset: 0x00CE00EB
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

		// Token: 0x0602E301 RID: 189185 RVA: 0x00CE1F15 File Offset: 0x00CE0115
		protected override void OnAfterShow()
		{
			if (this.ExtendRewardInfo.ExploreFriendDataList != null)
			{
				this.OnRefreshFriendApply();
			}
		}

		// Token: 0x0602E302 RID: 189186 RVA: 0x00CE1F2C File Offset: 0x00CE012C
		protected override void OnAfterPlayStartSequence()
		{
			if (this.RewardData.GetRewardInfo().IsSuccess)
			{
				this.UiViewSequence.PlaySequence("Success", true, null);
				return;
			}
			this.UiViewSequence.PlaySequence("Fail", true, null);
		}

		// Token: 0x0602E303 RID: 189187 RVA: 0x00CE1F80 File Offset: 0x00CE0180
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

		// Token: 0x0602E304 RID: 189188 RVA: 0x00CE210C File Offset: 0x00CE030C
		private bool RefreshTitleVisible()
		{
			UUIItem item = base.GetItem(0);
			bool flag = !StringUtils.IsEmpty(this.RewardInfo.Title);
			item.SetUIActive(flag);
			return flag;
		}

		// Token: 0x0602E305 RID: 189189 RVA: 0x00CE213C File Offset: 0x00CE033C
		private void RefreshTitleText()
		{
			UUIText text = base.GetText(1);
			string title = this.RewardInfo.Title;
			if (!StringUtils.IsEmpty(title))
			{
				LguiUtil.Instance.SetLocalTextNew(text, title, Array.Empty<object>());
			}
		}

		// Token: 0x0602E306 RID: 189190 RVA: 0x00CE2178 File Offset: 0x00CE0378
		private void RefreshTipText()
		{
			base.GetItem(18).SetUIActive(this.RewardInfo.Tip != null);
			if (this.RewardInfo.Tip != null)
			{
				base.GetText(19).SetText(this.RewardInfo.Tip, true);
			}
		}

		// Token: 0x0602E307 RID: 189191 RVA: 0x00CE21C8 File Offset: 0x00CE03C8
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

		// Token: 0x0602E308 RID: 189192 RVA: 0x00CE2248 File Offset: 0x00CE0448
		private bool RefreshTitleTextureVisible()
		{
			UUIItem texture = base.GetTexture(2);
			bool flag = !StringUtils.IsEmpty(this.RewardInfo.TitleIconPath);
			texture.SetUIActive(flag);
			return flag;
		}

		// Token: 0x0602E309 RID: 189193 RVA: 0x00CE2278 File Offset: 0x00CE0478
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

		// Token: 0x0602E30A RID: 189194 RVA: 0x00CE2300 File Offset: 0x00CE0500
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

		// Token: 0x0602E30B RID: 189195 RVA: 0x00CE2330 File Offset: 0x00CE0530
		private UniTask NewExploreRecord()
		{
			ExploreRewardView.<NewExploreRecord>d__43 <NewExploreRecord>d__;
			<NewExploreRecord>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewExploreRecord>d__.<>4__this = this;
			<NewExploreRecord>d__.<>1__state = -1;
			<NewExploreRecord>d__.<>t__builder.Start<ExploreRewardView.<NewExploreRecord>d__43>(ref <NewExploreRecord>d__);
			return <NewExploreRecord>d__.<>t__builder.Task;
		}

		// Token: 0x0602E30C RID: 189196 RVA: 0x00CE2374 File Offset: 0x00CE0574
		private UniTask NewRewardItemList()
		{
			ExploreRewardView.<NewRewardItemList>d__44 <NewRewardItemList>d__;
			<NewRewardItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewRewardItemList>d__.<>4__this = this;
			<NewRewardItemList>d__.<>1__state = -1;
			<NewRewardItemList>d__.<>t__builder.Start<ExploreRewardView.<NewRewardItemList>d__44>(ref <NewRewardItemList>d__);
			return <NewRewardItemList>d__.<>t__builder.Task;
		}

		// Token: 0x0602E30D RID: 189197 RVA: 0x00CE23B8 File Offset: 0x00CE05B8
		private UniTask NewBagFullTip()
		{
			ExploreRewardView.<NewBagFullTip>d__45 <NewBagFullTip>d__;
			<NewBagFullTip>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewBagFullTip>d__.<>4__this = this;
			<NewBagFullTip>d__.<>1__state = -1;
			<NewBagFullTip>d__.<>t__builder.Start<ExploreRewardView.<NewBagFullTip>d__45>(ref <NewBagFullTip>d__);
			return <NewBagFullTip>d__.<>t__builder.Task;
		}

		// Token: 0x0602E30E RID: 189198 RVA: 0x00CE23FC File Offset: 0x00CE05FC
		private UniTask NewExploreBarList()
		{
			ExploreRewardView.<NewExploreBarList>d__46 <NewExploreBarList>d__;
			<NewExploreBarList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewExploreBarList>d__.<>4__this = this;
			<NewExploreBarList>d__.<>1__state = -1;
			<NewExploreBarList>d__.<>t__builder.Start<ExploreRewardView.<NewExploreBarList>d__46>(ref <NewExploreBarList>d__);
			return <NewExploreBarList>d__.<>t__builder.Task;
		}

		// Token: 0x0602E30F RID: 189199 RVA: 0x00CE2440 File Offset: 0x00CE0640
		private UniTask NewExploreDescription()
		{
			ExploreRewardView.<NewExploreDescription>d__47 <NewExploreDescription>d__;
			<NewExploreDescription>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewExploreDescription>d__.<>4__this = this;
			<NewExploreDescription>d__.<>1__state = -1;
			<NewExploreDescription>d__.<>t__builder.Start<ExploreRewardView.<NewExploreDescription>d__47>(ref <NewExploreDescription>d__);
			return <NewExploreDescription>d__.<>t__builder.Task;
		}

		// Token: 0x0602E310 RID: 189200 RVA: 0x00CE2484 File Offset: 0x00CE0684
		private UniTask NewTargetReachedList()
		{
			ExploreRewardView.<NewTargetReachedList>d__48 <NewTargetReachedList>d__;
			<NewTargetReachedList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewTargetReachedList>d__.<>4__this = this;
			<NewTargetReachedList>d__.<>1__state = -1;
			<NewTargetReachedList>d__.<>t__builder.Start<ExploreRewardView.<NewTargetReachedList>d__48>(ref <NewTargetReachedList>d__);
			return <NewTargetReachedList>d__.<>t__builder.Task;
		}

		// Token: 0x0602E311 RID: 189201 RVA: 0x00CE24C8 File Offset: 0x00CE06C8
		private UniTask NewScoreSubTitle()
		{
			ExploreRewardView.<NewScoreSubTitle>d__49 <NewScoreSubTitle>d__;
			<NewScoreSubTitle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewScoreSubTitle>d__.<>4__this = this;
			<NewScoreSubTitle>d__.<>1__state = -1;
			<NewScoreSubTitle>d__.<>t__builder.Start<ExploreRewardView.<NewScoreSubTitle>d__49>(ref <NewScoreSubTitle>d__);
			return <NewScoreSubTitle>d__.<>t__builder.Task;
		}

		// Token: 0x0602E312 RID: 189202 RVA: 0x00CE250C File Offset: 0x00CE070C
		private UniTask NewOnlineChallengePlayer()
		{
			ExploreRewardView.<NewOnlineChallengePlayer>d__50 <NewOnlineChallengePlayer>d__;
			<NewOnlineChallengePlayer>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewOnlineChallengePlayer>d__.<>4__this = this;
			<NewOnlineChallengePlayer>d__.<>1__state = -1;
			<NewOnlineChallengePlayer>d__.<>t__builder.Start<ExploreRewardView.<NewOnlineChallengePlayer>d__50>(ref <NewOnlineChallengePlayer>d__);
			return <NewOnlineChallengePlayer>d__.<>t__builder.Task;
		}

		// Token: 0x0602E313 RID: 189203 RVA: 0x00CE2550 File Offset: 0x00CE0750
		private UniTask NewStateToggle()
		{
			ExploreRewardView.<NewStateToggle>d__51 <NewStateToggle>d__;
			<NewStateToggle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewStateToggle>d__.<>4__this = this;
			<NewStateToggle>d__.<>1__state = -1;
			<NewStateToggle>d__.<>t__builder.Start<ExploreRewardView.<NewStateToggle>d__51>(ref <NewStateToggle>d__);
			return <NewStateToggle>d__.<>t__builder.Task;
		}

		// Token: 0x0602E314 RID: 189204 RVA: 0x00CE2594 File Offset: 0x00CE0794
		private UniTask NewScoreReach()
		{
			ExploreRewardView.<NewScoreReach>d__52 <NewScoreReach>d__;
			<NewScoreReach>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewScoreReach>d__.<>4__this = this;
			<NewScoreReach>d__.<>1__state = -1;
			<NewScoreReach>d__.<>t__builder.Start<ExploreRewardView.<NewScoreReach>d__52>(ref <NewScoreReach>d__);
			return <NewScoreReach>d__.<>t__builder.Task;
		}

		// Token: 0x0602E315 RID: 189205 RVA: 0x00CE25D8 File Offset: 0x00CE07D8
		private UniTask NewAccumulatedScoreItem()
		{
			ExploreRewardView.<NewAccumulatedScoreItem>d__53 <NewAccumulatedScoreItem>d__;
			<NewAccumulatedScoreItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAccumulatedScoreItem>d__.<>4__this = this;
			<NewAccumulatedScoreItem>d__.<>1__state = -1;
			<NewAccumulatedScoreItem>d__.<>t__builder.Start<ExploreRewardView.<NewAccumulatedScoreItem>d__53>(ref <NewAccumulatedScoreItem>d__);
			return <NewAccumulatedScoreItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602E316 RID: 189206 RVA: 0x00CE261C File Offset: 0x00CE081C
		private UniTask NewFriendList()
		{
			ExploreRewardView.<NewFriendList>d__54 <NewFriendList>d__;
			<NewFriendList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewFriendList>d__.<>4__this = this;
			<NewFriendList>d__.<>1__state = -1;
			<NewFriendList>d__.<>t__builder.Start<ExploreRewardView.<NewFriendList>d__54>(ref <NewFriendList>d__);
			return <NewFriendList>d__.<>t__builder.Task;
		}

		// Token: 0x0602E317 RID: 189207 RVA: 0x00CE2660 File Offset: 0x00CE0860
		private UniTask NewBabelTowerSuccessItem()
		{
			ExploreRewardView.<NewBabelTowerSuccessItem>d__55 <NewBabelTowerSuccessItem>d__;
			<NewBabelTowerSuccessItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewBabelTowerSuccessItem>d__.<>4__this = this;
			<NewBabelTowerSuccessItem>d__.<>1__state = -1;
			<NewBabelTowerSuccessItem>d__.<>t__builder.Start<ExploreRewardView.<NewBabelTowerSuccessItem>d__55>(ref <NewBabelTowerSuccessItem>d__);
			return <NewBabelTowerSuccessItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602E318 RID: 189208 RVA: 0x00CE26A4 File Offset: 0x00CE08A4
		private UniTask NewDangoAbyssSuccessItem()
		{
			ExploreRewardView.<NewDangoAbyssSuccessItem>d__56 <NewDangoAbyssSuccessItem>d__;
			<NewDangoAbyssSuccessItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewDangoAbyssSuccessItem>d__.<>4__this = this;
			<NewDangoAbyssSuccessItem>d__.<>1__state = -1;
			<NewDangoAbyssSuccessItem>d__.<>t__builder.Start<ExploreRewardView.<NewDangoAbyssSuccessItem>d__56>(ref <NewDangoAbyssSuccessItem>d__);
			return <NewDangoAbyssSuccessItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602E319 RID: 189209 RVA: 0x00CE26E8 File Offset: 0x00CE08E8
		private UniTask NewHonamiTowerSuccessItem()
		{
			ExploreRewardView.<NewHonamiTowerSuccessItem>d__57 <NewHonamiTowerSuccessItem>d__;
			<NewHonamiTowerSuccessItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewHonamiTowerSuccessItem>d__.<>4__this = this;
			<NewHonamiTowerSuccessItem>d__.<>1__state = -1;
			<NewHonamiTowerSuccessItem>d__.<>t__builder.Start<ExploreRewardView.<NewHonamiTowerSuccessItem>d__57>(ref <NewHonamiTowerSuccessItem>d__);
			return <NewHonamiTowerSuccessItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602E31A RID: 189210 RVA: 0x00CE272C File Offset: 0x00CE092C
		private UniTask NewRoguelikeBossChallengeItem()
		{
			ExploreRewardView.<NewRoguelikeBossChallengeItem>d__58 <NewRoguelikeBossChallengeItem>d__;
			<NewRoguelikeBossChallengeItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewRoguelikeBossChallengeItem>d__.<>4__this = this;
			<NewRoguelikeBossChallengeItem>d__.<>1__state = -1;
			<NewRoguelikeBossChallengeItem>d__.<>t__builder.Start<ExploreRewardView.<NewRoguelikeBossChallengeItem>d__58>(ref <NewRoguelikeBossChallengeItem>d__);
			return <NewRoguelikeBossChallengeItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602E31B RID: 189211 RVA: 0x00CE2770 File Offset: 0x00CE0970
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

		// Token: 0x0602E31C RID: 189212 RVA: 0x00CE27C0 File Offset: 0x00CE09C0
		[NullableContext(1)]
		private RewardExploreFriendItem CreateFriendGrid()
		{
			return new RewardExploreFriendItem();
		}

		// Token: 0x0602E31D RID: 189213 RVA: 0x00CE27C8 File Offset: 0x00CE09C8
		public EToggleState? GetBottomToggleState()
		{
			RewardExploreToggle rewardExploreToggle = this.RewardExploreToggle;
			if (rewardExploreToggle == null)
			{
				return null;
			}
			return rewardExploreToggle.GetToggleState();
		}

		// Token: 0x0602E31E RID: 189214 RVA: 0x00CE27EE File Offset: 0x00CE09EE
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

		// Token: 0x040189AE RID: 100782
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private RewardData<IExploreRewardInfo> RewardData;

		// Token: 0x040189AF RID: 100783
		private IExploreRewardInfo RewardInfo;

		// Token: 0x040189B0 RID: 100784
		private IExtendRewardInfo ExtendRewardInfo;

		// Token: 0x040189B1 RID: 100785
		private RewardExploreRecord RewardExploreRecord;

		// Token: 0x040189B2 RID: 100786
		private RewardItemList RewardItemList;

		// Token: 0x040189B3 RID: 100787
		private RewardExploreBarList RewardExploreBarList;

		// Token: 0x040189B4 RID: 100788
		private RewardExploreDescription RewardExploreDescription;

		// Token: 0x040189B5 RID: 100789
		private RewardExploreTargetReachedList RewardExploreTargetReachedList;

		// Token: 0x040189B6 RID: 100790
		private RewardExploreScoreSubTitle RewardExploreScoreSubTitle;

		// Token: 0x040189B7 RID: 100791
		private RewardExploreOnlineChallengePlayer RewardExploreOnlineChallengePlayer;

		// Token: 0x040189B8 RID: 100792
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RewardExploreFriendItem, IRewardExploreFriendData> RewardExploreFriendList;

		// Token: 0x040189B9 RID: 100793
		private BagFullTip BagFullTip;

		// Token: 0x040189BA RID: 100794
		private RewardExploreToggle RewardExploreToggle;

		// Token: 0x040189BB RID: 100795
		private RewardExploreScore RewardExploreScore;

		// Token: 0x040189BC RID: 100796
		private RewardExploreAccumulatedScoreItem RewardExploreAccumulatedScoreItem;

		// Token: 0x040189BD RID: 100797
		private RewardExploreBabelSuccessItem RewardExploreBabelSuccessItem;

		// Token: 0x040189BE RID: 100798
		private RewardExploreDangoAbyssSuccessItem RewardExploreDangoAbyssSuccessItem;

		// Token: 0x040189BF RID: 100799
		private RewardExploreHonamiTowerSuccessItem RewardExploreHonamiTowerSuccessItem;

		// Token: 0x040189C0 RID: 100800
		private RewardExploreRoguelikeBossChallengeItem RewardExploreRoguelikeBossChallengeItem;

		// Token: 0x040189C1 RID: 100801
		[Nullable(1)]
		private readonly List<RewardExploreConfirmButton> ButtonList = new List<RewardExploreConfirmButton>();

		// Token: 0x040189C2 RID: 100802
		[Nullable(1)]
		private const string SUCCESS_OUTLINE_COLOR = "C48B29FF";

		// Token: 0x040189C3 RID: 100803
		[Nullable(1)]
		private const string FAIL_OUTLINE_COLOR = "B33100FF";

		// Token: 0x0200A3EB RID: 41963
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04032CD4 RID: 208084
			public const int TitleItem = 0;

			// Token: 0x04032CD5 RID: 208085
			public const int TitleText = 1;

			// Token: 0x04032CD6 RID: 208086
			public const int TitleTexture = 2;

			// Token: 0x04032CD7 RID: 208087
			public const int ContentItem = 3;

			// Token: 0x04032CD8 RID: 208088
			public const int ButtonHorizontalItem = 4;

			// Token: 0x04032CD9 RID: 208089
			public const int ButtonItem = 5;

			// Token: 0x04032CDA RID: 208090
			public const int ToggleItem = 6;

			// Token: 0x04032CDB RID: 208091
			public const int DoubleTip = 18;

			// Token: 0x04032CDC RID: 208092
			public const int DoubleTipTxt = 19;

			// Token: 0x04032CDD RID: 208093
			public const int Content = 20;

			// Token: 0x04032CDE RID: 208094
			public const int FriendItem = 21;

			// Token: 0x04032CDF RID: 208095
			public const int FriendGrid = 22;

			// Token: 0x04032CE0 RID: 208096
			public const int ItemTeam = 23;
		}
	}
}
