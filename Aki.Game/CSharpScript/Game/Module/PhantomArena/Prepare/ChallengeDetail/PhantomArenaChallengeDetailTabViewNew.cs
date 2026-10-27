using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckDetail;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.ChallengeDetail
{
	// Token: 0x020051BC RID: 20924
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaChallengeDetailTabViewNew : PhantomArenaChildViewBase
	{
		// Token: 0x170081AF RID: 33199
		// (get) Token: 0x06035945 RID: 219461 RVA: 0x00CB1B1D File Offset: 0x00CAFD1D
		// (set) Token: 0x06035946 RID: 219462 RVA: 0x00CB1B2A File Offset: 0x00CAFD2A
		public new IPhantomArenaChallengeDetailTabViewModel ViewModel
		{
			get
			{
				return this.ViewModel as IPhantomArenaChallengeDetailTabViewModel;
			}
			set
			{
				this.ViewModel = value;
			}
		}

		// Token: 0x06035947 RID: 219463 RVA: 0x00CB1B34 File Offset: 0x00CAFD34
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(12, typeof(UUIText)),
				new ValueTuple<int, Type>(13, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(11, new Action(this.OnConfirmBtnClick)),
				new ValueTuple<int, Delegate>(13, new Action(this.OnRecommendBtnClick))
			};
		}

		// Token: 0x06035948 RID: 219464 RVA: 0x00CB1CC4 File Offset: 0x00CAFEC4
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaChallengeDetailTabViewNew.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaChallengeDetailTabViewNew.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035949 RID: 219465 RVA: 0x00CB1D07 File Offset: 0x00CAFF07
		protected override void OnStart()
		{
			base.OnStart();
			this.RewardLayout = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(9), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), base.GetItem(10).GetOwner() as AUIBaseActor, false, null);
		}

		// Token: 0x0603594A RID: 219466 RVA: 0x00CB1D44 File Offset: 0x00CAFF44
		protected override void OnBeforeShow()
		{
			this.ViewModel.SetViewTitle("PhantomArenaEntranceLevelTabView_Name");
			this.ViewModel.SetViewHelpBtnActive(false);
			this.ViewModel.SetViewIcon("SP_IconSoundRemnantArena4");
			if (this.ViewModel.SelectedCardRoleId == 0)
			{
				this.ViewModel.TextureCardRoleId = this.ViewModel.SelectedCardRoleId;
				this.ViewModel.HideRoleTexture(true);
			}
			else if (this.ViewModel.RoleTextureActive)
			{
				if (this.ViewModel.TextureCardRoleId != this.ViewModel.SelectedCardRoleId)
				{
					this.ViewModel.ChangeRoleTexture(this.ViewModel.SelectedCardRoleId, true);
				}
			}
			else
			{
				this.ViewModel.ShowRoleTexture(true);
				this.ViewModel.RefreshRoleTexture();
			}
			this.CheckAndPlayRoleSelectAnim();
			this.CheckAndPlayDeckSelectAnim();
			this.RefreshView();
		}

		// Token: 0x0603594B RID: 219467 RVA: 0x00CB1E38 File Offset: 0x00CB0038
		public void RefreshView()
		{
			int challengeId = this.ViewModel.GetChallengeId();
			PhantomBattleChallenge phantomBattleChallenge = PhantomArenaConfig.Instance.GetPhantomBattleChallenge(challengeId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), phantomBattleChallenge.ChallengeName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), phantomBattleChallenge.NpcName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), phantomBattleChallenge.NpcTitle, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), phantomBattleChallenge.PassConditionDesc, Array.Empty<object>());
			UUIText text = base.GetText(6);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Lv.");
				defaultInterpolatedStringHandler.AppendFormatted<int>(phantomBattleChallenge.NpcLevel);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			base.SetTextureByPath(phantomBattleChallenge.NpcChallengeIcon, base.GetTexture(3), null, null);
			this.RoleItemData = new PhantomArenaRoleOverviewItemData
			{
				CardRoleId = this.ViewModel.SelectedCardRoleId
			};
			this.RoleItem.Refresh(this.RoleItemData);
			this.MyDeckItemData = this.ViewModel.GetUsedDeck();
			if (this.MyDeckItemData != null)
			{
				this.MyDeckItem.Refresh(this.MyDeckItemData, false, 0);
			}
			else
			{
				this.MyDeckItem.Refresh(null, false, 0);
			}
			this.NpcDeckItemData = PhantomArenaModel.Instance.CreateDeckInfoFromDeckConfigId(this.ViewModel.NpcDeckConfigId);
			if (this.NpcDeckItemData != null)
			{
				this.NpcDeckItem.Refresh(this.NpcDeckItemData, false, 0);
			}
			else
			{
				this.NpcDeckItem.Refresh(null, false, 0);
			}
			int recommendCardGroupId = phantomBattleChallenge.RecommendCardGroupId;
			if (!FunctionModel.Instance.IsOpen(EFunctionType.PermanentPhantomArenaRecommend) || recommendCardGroupId == 0)
			{
				UUIButtonComponent button = base.GetButton(13);
				if (button != null)
				{
					button.RootUIComp.Get().SetUIActive(false);
				}
			}
			else
			{
				UUIButtonComponent button2 = base.GetButton(13);
				if (button2 != null)
				{
					button2.RootUIComp.Get().SetUIActive(true);
				}
				this.RecommendDeckInfo = PhantomArenaModel.Instance.CreateDeckInfoFromDeckConfigId(recommendCardGroupId);
			}
			bool flag = PhantomArenaModel.Instance.GetChallengeStateById(challengeId) == EChallengeState.Finish;
			string textStringId = flag ? "PhantomBattle_1087" : "PhantomBattle_1088";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(12), textStringId, Array.Empty<object>());
			List<TItem> list = null;
			if (!flag)
			{
				list = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(phantomBattleChallenge.FirstPassDropId);
			}
			else
			{
				list = new List<TItem>();
				if (phantomBattleChallenge.PassDropId() != null)
				{
					foreach (KeyValuePair<int, int> keyValuePair in phantomBattleChallenge.PassDropId())
					{
						int key = keyValuePair.Key;
						int value = keyValuePair.Value;
						InventoryDefine.GetItemData itemData = new InventoryDefine.GetItemData(key, 0);
						TItem item = new TItem(itemData, value);
						list.Add(item);
					}
				}
			}
			this.RewardLayout.RefreshByData(list, null, false);
		}

		// Token: 0x0603594C RID: 219468 RVA: 0x00CB212C File Offset: 0x00CB032C
		private void CheckAndPlayRoleSelectAnim()
		{
			if (this.ViewModel.RoleSelectedConfirmFlag)
			{
				PhantomArenaRoleOverviewItem roleItem = this.RoleItem;
				if (roleItem != null)
				{
					roleItem.PlaySelectAnim();
				}
				this.ViewModel.RoleSelectedConfirmFlag = false;
			}
		}

		// Token: 0x0603594D RID: 219469 RVA: 0x00CB2158 File Offset: 0x00CB0358
		private void CheckAndPlayDeckSelectAnim()
		{
			if (this.ViewModel.DeckSelectedConfirmFlag)
			{
				PhantomArenaChallengeDetailDeckItem myDeckItem = this.MyDeckItem;
				if (myDeckItem != null)
				{
					myDeckItem.PlaySelectAnim();
				}
				this.ViewModel.DeckSelectedConfirmFlag = false;
			}
		}

		// Token: 0x0603594E RID: 219470 RVA: 0x00CB2184 File Offset: 0x00CB0384
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0603594F RID: 219471 RVA: 0x00CB218C File Offset: 0x00CB038C
		private void OnConfirmBtnClick()
		{
			if (this.IsRequesting)
			{
				return;
			}
			DeckInfo usedDeck = this.ViewModel.GetUsedDeck();
			int selectedCardRoleId = this.ViewModel.SelectedCardRoleId;
			if (selectedCardRoleId <= 0 || usedDeck == null || !usedDeck.CanDeckBeUsed())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomBattleGym_Not_Ready", Array.Empty<object>());
				return;
			}
			int challengeId = this.ViewModel.GetChallengeId();
			int deckServerId = usedDeck.GetDeckServerId();
			this.IsRequesting = true;
			PhantomArenaBattleController.RequestEnterPhantomArenaBattleAsync(challengeId, selectedCardRoleId, deckServerId).ContinueWith(delegate()
			{
				this.IsRequesting = false;
			}).Forget();
		}

		// Token: 0x06035950 RID: 219472 RVA: 0x00CB2214 File Offset: 0x00CB0414
		private void OnRoleItemClick()
		{
			base.OpenChildView(EPhantomArenaChildViewName.PhantomArenaRoleSelectTabView);
		}

		// Token: 0x06035951 RID: 219473 RVA: 0x00CB221D File Offset: 0x00CB041D
		private void OnMyDeckItemClick()
		{
			this.ViewModel.SelectedDeckIndex = ((this.ViewModel.UsedDeckIndex >= 0) ? this.ViewModel.UsedDeckIndex : 0);
			base.OpenChildView(EPhantomArenaChildViewName.PhantomArenaDeckOverviewTabView);
		}

		// Token: 0x06035952 RID: 219474 RVA: 0x00CB2250 File Offset: 0x00CB0450
		private void OnNpcDeckItemClick()
		{
			DeckInfo npcDeckItemData = this.NpcDeckItemData;
			if (npcDeckItemData == null)
			{
				return;
			}
			PhantomArenaDeckDetailViewData param = new PhantomArenaDeckDetailViewData
			{
				DeckInfo = npcDeckItemData,
				ShowLocked = false,
				ActivityId = base.ActivityId
			};
			EUiViewName name = PhantomArenaModel.Instance.IsNewPhantomArenaActivity(base.ActivityId) ? EUiViewName.PhantomArenaDeckDetailViewNew : EUiViewName.PhantomArenaDeckDetailView;
			UiManager.Instance.OpenView(name, param, null);
		}

		// Token: 0x06035953 RID: 219475 RVA: 0x00CB22B4 File Offset: 0x00CB04B4
		private void OnRecommendBtnClick()
		{
			DeckInfo recommendDeckInfo = this.RecommendDeckInfo;
			if (recommendDeckInfo == null)
			{
				return;
			}
			PhantomArenaDeckDetailViewData param = new PhantomArenaDeckDetailViewData
			{
				DeckInfo = recommendDeckInfo,
				ShowLocked = true,
				ActivityId = base.ActivityId,
				IsRecommend = new bool?(true),
				SaveRecommendDeckCallback = new Action<DeckInfo>(this.OpenDeckOverviewTabView)
			};
			EUiViewName name = PhantomArenaModel.Instance.IsNewPhantomArenaActivity(base.ActivityId) ? EUiViewName.PhantomArenaDeckDetailViewNew : EUiViewName.PhantomArenaDeckDetailView;
			UiManager.Instance.OpenView(name, param, null);
		}

		// Token: 0x06035954 RID: 219476 RVA: 0x00CB2336 File Offset: 0x00CB0536
		private void OpenDeckOverviewTabView(DeckInfo deckInfo)
		{
			this.ViewModel.SelectedDeckIndex = ((this.ViewModel.UsedDeckIndex >= 0) ? this.ViewModel.UsedDeckIndex : 0);
			this.ViewModel.RecommendDeck = deckInfo;
			base.OpenChildView(EPhantomArenaChildViewName.PhantomArenaDeckOverviewTabView);
		}

		// Token: 0x0401C70C RID: 116492
		private IPhantomArenaRoleOverviewItemData RoleItemData;

		// Token: 0x0401C70D RID: 116493
		private PhantomArenaRoleOverviewItem RoleItem;

		// Token: 0x0401C70E RID: 116494
		private DeckInfo MyDeckItemData;

		// Token: 0x0401C70F RID: 116495
		private PhantomArenaChallengeDetailDeckItem MyDeckItem;

		// Token: 0x0401C710 RID: 116496
		private DeckInfo NpcDeckItemData;

		// Token: 0x0401C711 RID: 116497
		private PhantomArenaChallengeDetailDeckItem NpcDeckItem;

		// Token: 0x0401C712 RID: 116498
		private DeckInfo RecommendDeckInfo;

		// Token: 0x0401C713 RID: 116499
		protected GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x0401C714 RID: 116500
		private bool IsRequesting;

		// Token: 0x0200B34B RID: 45899
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04036581 RID: 222593
			public const int RoleItem = 0;

			// Token: 0x04036582 RID: 222594
			public const int MyDeckItem = 1;

			// Token: 0x04036583 RID: 222595
			public const int GymTitleText = 2;

			// Token: 0x04036584 RID: 222596
			public const int NpcTexture = 3;

			// Token: 0x04036585 RID: 222597
			public const int NpcNameText = 4;

			// Token: 0x04036586 RID: 222598
			public const int NpcLevelNameText = 5;

			// Token: 0x04036587 RID: 222599
			public const int NpcLevelText = 6;

			// Token: 0x04036588 RID: 222600
			public const int NpcDeckItem = 7;

			// Token: 0x04036589 RID: 222601
			public const int ConditionText = 8;

			// Token: 0x0403658A RID: 222602
			public const int RewardScrollView = 9;

			// Token: 0x0403658B RID: 222603
			public const int RewardItem = 10;

			// Token: 0x0403658C RID: 222604
			public const int ConfirmBtn = 11;

			// Token: 0x0403658D RID: 222605
			public const int RewardTitleText = 12;

			// Token: 0x0403658E RID: 222606
			public const int BtnRecommend = 13;
		}
	}
}
