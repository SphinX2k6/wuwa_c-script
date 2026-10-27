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
	// Token: 0x020051BB RID: 20923
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaChallengeDetailTabView : PhantomArenaChildViewBase
	{
		// Token: 0x170081AE RID: 33198
		// (get) Token: 0x06035935 RID: 219445 RVA: 0x00CB1406 File Offset: 0x00CAF606
		// (set) Token: 0x06035936 RID: 219446 RVA: 0x00CB1413 File Offset: 0x00CAF613
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

		// Token: 0x06035937 RID: 219447 RVA: 0x00CB141C File Offset: 0x00CAF61C
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
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(8, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(11, typeof(UUIText)),
				new ValueTuple<int, Type>(12, typeof(UUISprite)),
				new ValueTuple<int, Type>(13, typeof(UUISprite))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(10, new Action(this.OnConfirmBtnClick))
			};
		}

		// Token: 0x06035938 RID: 219448 RVA: 0x00CB1594 File Offset: 0x00CAF794
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaChallengeDetailTabView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaChallengeDetailTabView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035939 RID: 219449 RVA: 0x00CB15D7 File Offset: 0x00CAF7D7
		protected override void OnStart()
		{
			base.OnStart();
			this.RewardLayout = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(8), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), base.GetItem(9).GetOwner() as AUIBaseActor, false, null);
		}

		// Token: 0x0603593A RID: 219450 RVA: 0x00CB1614 File Offset: 0x00CAF814
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

		// Token: 0x0603593B RID: 219451 RVA: 0x00CB1708 File Offset: 0x00CAF908
		public void RefreshView()
		{
			int challengeId = this.ViewModel.GetChallengeId();
			PhantomBattleChallenge phantomBattleChallenge = PhantomArenaConfig.Instance.GetPhantomBattleChallenge(challengeId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), phantomBattleChallenge.ChallengeName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), phantomBattleChallenge.NpcName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), phantomBattleChallenge.NpcTitle, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), phantomBattleChallenge.PassConditionDesc, Array.Empty<object>());
			base.SetTextureByPath(phantomBattleChallenge.NpcChallengeIcon, base.GetTexture(3), null, null);
			this.SetSpriteByPath(phantomBattleChallenge.NpcLevelBgIcon, base.GetSprite(12), false, null, null);
			this.SetSpriteByPath(phantomBattleChallenge.NpcLevelIcon, base.GetSprite(13), false, null, null);
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
			bool isReChallenge = phantomBattleChallenge.IsReChallenge;
			string textStringId = isReChallenge ? "PhantomBattle_1087" : "PhantomBattle_1088";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), textStringId, Array.Empty<object>());
			List<TItem> list = null;
			if (!isReChallenge)
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

		// Token: 0x0603593C RID: 219452 RVA: 0x00CB1984 File Offset: 0x00CAFB84
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

		// Token: 0x0603593D RID: 219453 RVA: 0x00CB19B0 File Offset: 0x00CAFBB0
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

		// Token: 0x0603593E RID: 219454 RVA: 0x00CB19DC File Offset: 0x00CAFBDC
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0603593F RID: 219455 RVA: 0x00CB19E4 File Offset: 0x00CAFBE4
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

		// Token: 0x06035940 RID: 219456 RVA: 0x00CB1A6C File Offset: 0x00CAFC6C
		private void OnRoleItemClick()
		{
			base.OpenChildView(EPhantomArenaChildViewName.PhantomArenaRoleSelectTabView);
		}

		// Token: 0x06035941 RID: 219457 RVA: 0x00CB1A75 File Offset: 0x00CAFC75
		private void OnMyDeckItemClick()
		{
			this.ViewModel.SelectedDeckIndex = ((this.ViewModel.UsedDeckIndex >= 0) ? this.ViewModel.UsedDeckIndex : 0);
			base.OpenChildView(EPhantomArenaChildViewName.PhantomArenaDeckOverviewTabView);
		}

		// Token: 0x06035942 RID: 219458 RVA: 0x00CB1AA8 File Offset: 0x00CAFCA8
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

		// Token: 0x0401C704 RID: 116484
		private IPhantomArenaRoleOverviewItemData RoleItemData;

		// Token: 0x0401C705 RID: 116485
		private PhantomArenaRoleOverviewItem RoleItem;

		// Token: 0x0401C706 RID: 116486
		private DeckInfo MyDeckItemData;

		// Token: 0x0401C707 RID: 116487
		private PhantomArenaChallengeDetailDeckItem MyDeckItem;

		// Token: 0x0401C708 RID: 116488
		private DeckInfo NpcDeckItemData;

		// Token: 0x0401C709 RID: 116489
		private PhantomArenaChallengeDetailDeckItem NpcDeckItem;

		// Token: 0x0401C70A RID: 116490
		protected GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x0401C70B RID: 116491
		private bool IsRequesting;

		// Token: 0x0200B349 RID: 45897
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0403656E RID: 222574
			public const int RoleItem = 0;

			// Token: 0x0403656F RID: 222575
			public const int MyDeckItem = 1;

			// Token: 0x04036570 RID: 222576
			public const int GymTitleText = 2;

			// Token: 0x04036571 RID: 222577
			public const int NpcTexture = 3;

			// Token: 0x04036572 RID: 222578
			public const int NpcNameText = 4;

			// Token: 0x04036573 RID: 222579
			public const int NpcLevelText = 5;

			// Token: 0x04036574 RID: 222580
			public const int NpcDeckItem = 6;

			// Token: 0x04036575 RID: 222581
			public const int ConditionText = 7;

			// Token: 0x04036576 RID: 222582
			public const int RewardScrollView = 8;

			// Token: 0x04036577 RID: 222583
			public const int RewardItem = 9;

			// Token: 0x04036578 RID: 222584
			public const int ConfirmBtn = 10;

			// Token: 0x04036579 RID: 222585
			public const int RewardTitleText = 11;

			// Token: 0x0403657A RID: 222586
			public const int NpcLevelBgSprite = 12;

			// Token: 0x0403657B RID: 222587
			public const int NpcLevelSprite = 13;
		}
	}
}
