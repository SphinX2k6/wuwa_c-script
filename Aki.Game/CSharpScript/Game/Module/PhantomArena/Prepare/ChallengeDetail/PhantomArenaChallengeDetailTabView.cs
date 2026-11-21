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
	// Token: 0x0200418B RID: 16779
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaChallengeDetailTabView : PhantomArenaChildViewBase
	{
		// Token: 0x1700556E RID: 21870
		// (get) Token: 0x0602A830 RID: 174128 RVA: 0x00BFEA42 File Offset: 0x00BFCC42
		// (set) Token: 0x0602A831 RID: 174129 RVA: 0x00BFEA4F File Offset: 0x00BFCC4F
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

		// Token: 0x0602A832 RID: 174130 RVA: 0x00BFEA58 File Offset: 0x00BFCC58
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

		// Token: 0x0602A833 RID: 174131 RVA: 0x00BFEBD0 File Offset: 0x00BFCDD0
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaChallengeDetailTabView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaChallengeDetailTabView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A834 RID: 174132 RVA: 0x00BFEC13 File Offset: 0x00BFCE13
		protected override void OnStart()
		{
			base.OnStart();
			this.RewardLayout = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(8), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), base.GetItem(9).GetOwner() as AUIBaseActor, false, null);
		}

		// Token: 0x0602A835 RID: 174133 RVA: 0x00BFEC50 File Offset: 0x00BFCE50
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

		// Token: 0x0602A836 RID: 174134 RVA: 0x00BFED44 File Offset: 0x00BFCF44
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

		// Token: 0x0602A837 RID: 174135 RVA: 0x00BFEFC0 File Offset: 0x00BFD1C0
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

		// Token: 0x0602A838 RID: 174136 RVA: 0x00BFEFEC File Offset: 0x00BFD1EC
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

		// Token: 0x0602A839 RID: 174137 RVA: 0x00BFF018 File Offset: 0x00BFD218
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0602A83A RID: 174138 RVA: 0x00BFF020 File Offset: 0x00BFD220
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

		// Token: 0x0602A83B RID: 174139 RVA: 0x00BFF0A8 File Offset: 0x00BFD2A8
		private void OnRoleItemClick()
		{
			base.OpenChildView(EPhantomArenaChildViewName.PhantomArenaRoleSelectTabView);
		}

		// Token: 0x0602A83C RID: 174140 RVA: 0x00BFF0B1 File Offset: 0x00BFD2B1
		private void OnMyDeckItemClick()
		{
			this.ViewModel.SelectedDeckIndex = ((this.ViewModel.UsedDeckIndex >= 0) ? this.ViewModel.UsedDeckIndex : 0);
			base.OpenChildView(EPhantomArenaChildViewName.PhantomArenaDeckOverviewTabView);
		}

		// Token: 0x0602A83D RID: 174141 RVA: 0x00BFF0E4 File Offset: 0x00BFD2E4
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

		// Token: 0x04017139 RID: 94521
		private IPhantomArenaRoleOverviewItemData RoleItemData;

		// Token: 0x0401713A RID: 94522
		private PhantomArenaRoleOverviewItem RoleItem;

		// Token: 0x0401713B RID: 94523
		private DeckInfo MyDeckItemData;

		// Token: 0x0401713C RID: 94524
		private PhantomArenaChallengeDetailDeckItem MyDeckItem;

		// Token: 0x0401713D RID: 94525
		private DeckInfo NpcDeckItemData;

		// Token: 0x0401713E RID: 94526
		private PhantomArenaChallengeDetailDeckItem NpcDeckItem;

		// Token: 0x0401713F RID: 94527
		protected GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x04017140 RID: 94528
		private bool IsRequesting;

		// Token: 0x02009D81 RID: 40321
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030FC1 RID: 200641
			public const int RoleItem = 0;

			// Token: 0x04030FC2 RID: 200642
			public const int MyDeckItem = 1;

			// Token: 0x04030FC3 RID: 200643
			public const int GymTitleText = 2;

			// Token: 0x04030FC4 RID: 200644
			public const int NpcTexture = 3;

			// Token: 0x04030FC5 RID: 200645
			public const int NpcNameText = 4;

			// Token: 0x04030FC6 RID: 200646
			public const int NpcLevelText = 5;

			// Token: 0x04030FC7 RID: 200647
			public const int NpcDeckItem = 6;

			// Token: 0x04030FC8 RID: 200648
			public const int ConditionText = 7;

			// Token: 0x04030FC9 RID: 200649
			public const int RewardScrollView = 8;

			// Token: 0x04030FCA RID: 200650
			public const int RewardItem = 9;

			// Token: 0x04030FCB RID: 200651
			public const int ConfirmBtn = 10;

			// Token: 0x04030FCC RID: 200652
			public const int RewardTitleText = 11;

			// Token: 0x04030FCD RID: 200653
			public const int NpcLevelBgSprite = 12;

			// Token: 0x04030FCE RID: 200654
			public const int NpcLevelSprite = 13;
		}
	}
}
