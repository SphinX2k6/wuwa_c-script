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
	// Token: 0x0200418C RID: 16780
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaChallengeDetailTabViewNew : PhantomArenaChildViewBase
	{
		// Token: 0x1700556F RID: 21871
		// (get) Token: 0x0602A840 RID: 174144 RVA: 0x00BFF159 File Offset: 0x00BFD359
		// (set) Token: 0x0602A841 RID: 174145 RVA: 0x00BFF166 File Offset: 0x00BFD366
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

		// Token: 0x0602A842 RID: 174146 RVA: 0x00BFF170 File Offset: 0x00BFD370
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

		// Token: 0x0602A843 RID: 174147 RVA: 0x00BFF300 File Offset: 0x00BFD500
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaChallengeDetailTabViewNew.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaChallengeDetailTabViewNew.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A844 RID: 174148 RVA: 0x00BFF343 File Offset: 0x00BFD543
		protected override void OnStart()
		{
			base.OnStart();
			this.RewardLayout = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(9), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), base.GetItem(10).GetOwner() as AUIBaseActor, false, null);
		}

		// Token: 0x0602A845 RID: 174149 RVA: 0x00BFF380 File Offset: 0x00BFD580
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

		// Token: 0x0602A846 RID: 174150 RVA: 0x00BFF474 File Offset: 0x00BFD674
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

		// Token: 0x0602A847 RID: 174151 RVA: 0x00BFF768 File Offset: 0x00BFD968
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

		// Token: 0x0602A848 RID: 174152 RVA: 0x00BFF794 File Offset: 0x00BFD994
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

		// Token: 0x0602A849 RID: 174153 RVA: 0x00BFF7C0 File Offset: 0x00BFD9C0
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0602A84A RID: 174154 RVA: 0x00BFF7C8 File Offset: 0x00BFD9C8
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

		// Token: 0x0602A84B RID: 174155 RVA: 0x00BFF850 File Offset: 0x00BFDA50
		private void OnRoleItemClick()
		{
			base.OpenChildView(EPhantomArenaChildViewName.PhantomArenaRoleSelectTabView);
		}

		// Token: 0x0602A84C RID: 174156 RVA: 0x00BFF859 File Offset: 0x00BFDA59
		private void OnMyDeckItemClick()
		{
			this.ViewModel.SelectedDeckIndex = ((this.ViewModel.UsedDeckIndex >= 0) ? this.ViewModel.UsedDeckIndex : 0);
			base.OpenChildView(EPhantomArenaChildViewName.PhantomArenaDeckOverviewTabView);
		}

		// Token: 0x0602A84D RID: 174157 RVA: 0x00BFF88C File Offset: 0x00BFDA8C
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

		// Token: 0x0602A84E RID: 174158 RVA: 0x00BFF8F0 File Offset: 0x00BFDAF0
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

		// Token: 0x0602A84F RID: 174159 RVA: 0x00BFF972 File Offset: 0x00BFDB72
		private void OpenDeckOverviewTabView(DeckInfo deckInfo)
		{
			this.ViewModel.SelectedDeckIndex = ((this.ViewModel.UsedDeckIndex >= 0) ? this.ViewModel.UsedDeckIndex : 0);
			this.ViewModel.RecommendDeck = deckInfo;
			base.OpenChildView(EPhantomArenaChildViewName.PhantomArenaDeckOverviewTabView);
		}

		// Token: 0x04017141 RID: 94529
		private IPhantomArenaRoleOverviewItemData RoleItemData;

		// Token: 0x04017142 RID: 94530
		private PhantomArenaRoleOverviewItem RoleItem;

		// Token: 0x04017143 RID: 94531
		private DeckInfo MyDeckItemData;

		// Token: 0x04017144 RID: 94532
		private PhantomArenaChallengeDetailDeckItem MyDeckItem;

		// Token: 0x04017145 RID: 94533
		private DeckInfo NpcDeckItemData;

		// Token: 0x04017146 RID: 94534
		private PhantomArenaChallengeDetailDeckItem NpcDeckItem;

		// Token: 0x04017147 RID: 94535
		private DeckInfo RecommendDeckInfo;

		// Token: 0x04017148 RID: 94536
		protected GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x04017149 RID: 94537
		private bool IsRequesting;

		// Token: 0x02009D83 RID: 40323
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030FD4 RID: 200660
			public const int RoleItem = 0;

			// Token: 0x04030FD5 RID: 200661
			public const int MyDeckItem = 1;

			// Token: 0x04030FD6 RID: 200662
			public const int GymTitleText = 2;

			// Token: 0x04030FD7 RID: 200663
			public const int NpcTexture = 3;

			// Token: 0x04030FD8 RID: 200664
			public const int NpcNameText = 4;

			// Token: 0x04030FD9 RID: 200665
			public const int NpcLevelNameText = 5;

			// Token: 0x04030FDA RID: 200666
			public const int NpcLevelText = 6;

			// Token: 0x04030FDB RID: 200667
			public const int NpcDeckItem = 7;

			// Token: 0x04030FDC RID: 200668
			public const int ConditionText = 8;

			// Token: 0x04030FDD RID: 200669
			public const int RewardScrollView = 9;

			// Token: 0x04030FDE RID: 200670
			public const int RewardItem = 10;

			// Token: 0x04030FDF RID: 200671
			public const int ConfirmBtn = 11;

			// Token: 0x04030FE0 RID: 200672
			public const int RewardTitleText = 12;

			// Token: 0x04030FE1 RID: 200673
			public const int BtnRecommend = 13;
		}
	}
}
