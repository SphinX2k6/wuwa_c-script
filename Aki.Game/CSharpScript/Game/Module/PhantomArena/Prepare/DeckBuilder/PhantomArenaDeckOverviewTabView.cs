using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x0200417A RID: 16762
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaDeckOverviewTabView : PhantomArenaChildViewBase
	{
		// Token: 0x17005566 RID: 21862
		// (get) Token: 0x0602A72F RID: 173871 RVA: 0x00BF97F9 File Offset: 0x00BF79F9
		// (set) Token: 0x0602A730 RID: 173872 RVA: 0x00BF9806 File Offset: 0x00BF7A06
		public new IPhantomArenaDeckOverviewTabViewModel ViewModel
		{
			get
			{
				return this.ViewModel as IPhantomArenaDeckOverviewTabViewModel;
			}
			set
			{
				this.ViewModel = value;
			}
		}

		// Token: 0x0602A731 RID: 173873 RVA: 0x00BF9810 File Offset: 0x00BF7A10
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(2, new Action(this.OnDeleteBtnClick)),
				new ValueTuple<int, Delegate>(3, new Action(this.OnEditDeckBtnClick)),
				new ValueTuple<int, Delegate>(4, new Action(this.OnConfirmBtnClick))
			};
		}

		// Token: 0x0602A732 RID: 173874 RVA: 0x00BF992B File Offset: 0x00BF7B2B
		protected override void OnStart()
		{
			base.OnStart();
			this.DeckLoopScroll = new LoopScrollView<PhantomArenaDeckOverviewItem, DeckInfo>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<PhantomArenaDeckOverviewItem>(this.CreateDeckItem), true);
		}

		// Token: 0x0602A733 RID: 173875 RVA: 0x00BF9964 File Offset: 0x00BF7B64
		protected override void OnBeforeShow()
		{
			this.ViewModel.SetViewTitle("PhantomArenaDeckOverviewTabView_Name");
			int obj = PhantomArenaModel.Instance.IsNewPhantomArenaActivity(base.ActivityId) ? 481 : 336;
			this.ViewModel.SetViewHelpId(obj);
			this.ViewModel.SetViewHelpBtnActive(true);
			this.ViewModel.SetViewIcon("SP_IconSoundRemnantArena3");
			IPhantomArenaDeckOverviewTabViewModel viewModel = this.ViewModel;
			if (viewModel != null)
			{
				viewModel.HideRoleTexture(true);
			}
			this.RefreshDeckInfoLayout();
			this.RefreshButtonAndTip();
			if (this.ViewModel != null)
			{
				this.ViewModel.SetOverrideCloseFunc(new Action(this.OnCloseBtnClick));
			}
		}

		// Token: 0x0602A734 RID: 173876 RVA: 0x00BF9A1E File Offset: 0x00BF7C1E
		protected void RefreshDeckInfoLayout()
		{
			this.DeckLoopScroll.RefreshByData(this.ViewModel.EditableDeckList, false, delegate
			{
				this.DeckLoopScroll.ScrollToGridIndex(this.ViewModel.SelectedDeckIndex, false);
				this.DeckLoopScroll.SelectGridProxy(this.ViewModel.SelectedDeckIndex, false);
			}, false);
		}

		// Token: 0x0602A735 RID: 173877 RVA: 0x00BF9A44 File Offset: 0x00BF7C44
		protected void RefreshButtonAndTip()
		{
			IPhantomArenaDeckOverviewTabViewModel viewModel = this.ViewModel;
			bool flag = ((viewModel != null) ? viewModel.RecommendDeck : null) != null;
			UUIItem uuiitem = base.GetButton(4).RootUIComp.Get();
			IPhantomArenaDeckOverviewTabViewModel viewModel2 = this.ViewModel;
			uuiitem.SetUIActive(viewModel2 != null && viewModel2.CanShowSelectBtnInDeckOverviewTabView && !flag);
			string textStringId = flag ? "PhantomBattle_1140" : "PrefabTextItem_1635688567_Text";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), textStringId, Array.Empty<object>());
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(flag);
		}

		// Token: 0x0602A736 RID: 173878 RVA: 0x00BF9AEA File Offset: 0x00BF7CEA
		protected void SelectDeckByIndex(int index)
		{
			if (index < 0 || index >= this.ViewModel.EditableDeckList.Count)
			{
				return;
			}
			this.ViewModel.SelectedDeckIndex = index;
			this.DeckLoopScroll.SelectGridProxy(index, false);
		}

		// Token: 0x0602A737 RID: 173879 RVA: 0x00BF9B1D File Offset: 0x00BF7D1D
		private PhantomArenaDeckOverviewItem CreateDeckItem()
		{
			return new PhantomArenaDeckOverviewItem
			{
				OnToggleSelect = new Action<int>(this.OnItemToggleSelect),
				ActivityId = base.ActivityId
			};
		}

		// Token: 0x0602A738 RID: 173880 RVA: 0x00BF9B42 File Offset: 0x00BF7D42
		private void OnItemToggleSelect(int gridIndex)
		{
			this.SelectDeckByIndex(gridIndex);
		}

		// Token: 0x0602A739 RID: 173881 RVA: 0x00BF9B4C File Offset: 0x00BF7D4C
		private void OnDeleteBtnClick()
		{
			DeckInfo selectedDeck = this.ViewModel.EditableDeckList[this.ViewModel.SelectedDeckIndex];
			if (selectedDeck.GetDeckServerId() < 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomBattle_1070", Array.Empty<object>());
				return;
			}
			if (this.ViewModel == null)
			{
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhantomArenaDeleteDeckConfirm);
			Action<int> <>9__1;
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				int deckServerId = selectedDeck.GetDeckServerId();
				PhantomArenaController instance = PhantomArenaController.Instance;
				int deckServerId2 = deckServerId;
				int activityId = this.ActivityId;
				Action<int> successCallBack;
				if ((successCallBack = <>9__1) == null)
				{
					successCallBack = (<>9__1 = delegate(int deleteIndex)
					{
						int usedDeckIndex = this.ViewModel.UsedDeckIndex;
						if (usedDeckIndex >= 0)
						{
							if (usedDeckIndex == deleteIndex)
							{
								this.ViewModel.UsedDeckIndex = -1;
							}
							else if (usedDeckIndex > deleteIndex)
							{
								IPhantomArenaDeckOverviewTabViewModel viewModel = this.ViewModel;
								int usedDeckIndex2 = viewModel.UsedDeckIndex;
								viewModel.UsedDeckIndex = usedDeckIndex2 - 1;
							}
						}
						IPhantomArenaDeckOverviewTabViewModel viewModel2 = this.ViewModel;
						if (viewModel2 != null)
						{
							viewModel2.UpdateEditableDeckList();
						}
						this.RefreshDeckInfoLayout();
						this.ViewModel.ReportDeckDelete(selectedDeck);
					});
				}
				instance.CardGroupDeleteRequest(deckServerId2, activityId, successCallBack);
			};
			bool isNew = PhantomArenaModel.Instance.IsNewPhantomArenaActivity(base.ActivityId);
			PhantomArenaController.Instance.OpenPhantomArenaConfirmBoxView(confirmBoxDataNew, isNew);
		}

		// Token: 0x0602A73A RID: 173882 RVA: 0x00BF9BF4 File Offset: 0x00BF7DF4
		private void OnEditDeckBtnClick()
		{
			IPhantomArenaDeckOverviewTabViewModel viewModel = this.ViewModel;
			if (((viewModel != null) ? viewModel.RecommendDeck : null) != null)
			{
				this.SaveRecommendDeck(this.ViewModel.RecommendDeck);
				return;
			}
			EPhantomArenaChildViewName viewName = PhantomArenaModel.Instance.IsNewPhantomArenaActivity(base.ActivityId) ? EPhantomArenaChildViewName.PhantomArenaNewDeckBuilderTabView : EPhantomArenaChildViewName.PhantomArenaDeckBuilderTabView;
			DeckInfo deckInfo = this.ViewModel.EditableDeckList[this.ViewModel.SelectedDeckIndex];
			if (deckInfo == null)
			{
				IPhantomArenaDeckOverviewTabViewModel viewModel2 = this.ViewModel;
				DeckInfo deckInfo2 = (viewModel2 != null) ? viewModel2.CreateEmptyTempDeck() : null;
				if (deckInfo2 != null)
				{
					IPhantomArenaDeckOverviewTabViewModel viewModel3 = this.ViewModel;
					if (viewModel3 != null)
					{
						viewModel3.StartEditDeck(deckInfo2);
					}
					base.OpenChildView(viewName);
				}
				return;
			}
			IPhantomArenaDeckOverviewTabViewModel viewModel4 = this.ViewModel;
			DeckInfo deckInfo3 = (viewModel4 != null) ? viewModel4.CreateTempDeckFromDeck(deckInfo) : null;
			if (deckInfo3 != null)
			{
				IPhantomArenaDeckOverviewTabViewModel viewModel5 = this.ViewModel;
				if (viewModel5 != null)
				{
					viewModel5.StartEditDeck(deckInfo3);
				}
				base.OpenChildView(viewName);
			}
		}

		// Token: 0x0602A73B RID: 173883 RVA: 0x00BF9CC0 File Offset: 0x00BF7EC0
		private void SaveRecommendDeck(DeckInfo deckInfo)
		{
			DeckInfo deckInfo2 = this.ViewModel.EditableDeckList[this.ViewModel.SelectedDeckIndex];
			int deckServerId = deckInfo2.GetDeckServerId();
			if (deckServerId >= 0)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhantomArenaRecommendOverrideOriginal);
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					this.SaveDeckInternal(deckInfo, deckServerId);
				};
				bool isNew = PhantomArenaModel.Instance.IsNewPhantomArenaActivity(base.ActivityId);
				PhantomArenaController.Instance.OpenPhantomArenaConfirmBoxView(confirmBoxDataNew, isNew);
				return;
			}
			this.SaveDeckInternal(deckInfo, deckServerId);
		}

		// Token: 0x0602A73C RID: 173884 RVA: 0x00BF9D68 File Offset: 0x00BF7F68
		private void SaveDeckInternal(DeckInfo deckInfo, int deckServerId)
		{
			Action callback = delegate()
			{
				IPhantomArenaDeckOverviewTabViewModel viewModel = this.ViewModel;
				if (viewModel != null)
				{
					viewModel.UpdateEditableDeckList();
				}
				this.ViewModel.RecommendDeck = null;
				this.RefreshDeckInfoLayout();
				this.RefreshButtonAndTip();
			};
			if (deckServerId < 0)
			{
				PhantomArenaController.Instance.CardGroupAddRequest(deckInfo.GetName(), deckInfo.CoverToCardIdList().ToArray(), base.ActivityId, delegate(int _)
				{
					callback();
					if (deckInfo != null)
					{
						this.ViewModel.ReportDeckCreate(deckInfo);
					}
				});
				return;
			}
			List<int> list = deckInfo.CoverToCardIdList();
			PhantomArenaController.Instance.CardGroupUpdateRequest(deckServerId, list.ToArray(), base.ActivityId, delegate(int _)
			{
				callback();
				if (deckInfo != null)
				{
					this.ViewModel.ReportDeckCover(deckInfo);
				}
			});
		}

		// Token: 0x0602A73D RID: 173885 RVA: 0x00BF9E08 File Offset: 0x00BF8008
		private void OnConfirmBtnClick()
		{
			DeckInfo deckInfo = this.ViewModel.EditableDeckList[this.ViewModel.SelectedDeckIndex];
			if (deckInfo.GetDeckServerId() < 0 || deckInfo.GetTotalCardCount() <= 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomBattle_1069", Array.Empty<object>());
				return;
			}
			this.ViewModel.DeckSelectedConfirmFlag = true;
			this.ViewModel.UsedDeckIndex = this.ViewModel.SelectedDeckIndex;
			base.CloseMe();
		}

		// Token: 0x0602A73E RID: 173886 RVA: 0x00BF9E80 File Offset: 0x00BF8080
		private void OnCloseBtnClick()
		{
			this.ViewModel.RecommendDeck = null;
			base.BackToLastView();
			this.ViewModel.ResetOverrideCloseFunc();
		}

		// Token: 0x0602A73F RID: 173887 RVA: 0x00BF9EA0 File Offset: 0x00BF80A0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams == null || configParams.Length == 0)
			{
				return null;
			}
			if (!(configParams[0] == "FirstDeck"))
			{
				return null;
			}
			LoopScrollView<PhantomArenaDeckOverviewItem, DeckInfo> deckLoopScroll = this.DeckLoopScroll;
			UUIItem uuiitem = (deckLoopScroll != null) ? deckLoopScroll.GetGridByDisplayIndex(0) : null;
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

		// Token: 0x040170E4 RID: 94436
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<PhantomArenaDeckOverviewItem, DeckInfo> DeckLoopScroll;

		// Token: 0x02009D5C RID: 40284
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030F09 RID: 200457
			public const int DeckLoopScrollView = 0;

			// Token: 0x04030F0A RID: 200458
			public const int DeckItem = 1;

			// Token: 0x04030F0B RID: 200459
			public const int DeleteBtn = 2;

			// Token: 0x04030F0C RID: 200460
			public const int EditDeckBtn = 3;

			// Token: 0x04030F0D RID: 200461
			public const int ConfirmBtn = 4;

			// Token: 0x04030F0E RID: 200462
			public const int ItemDeletePanel = 5;

			// Token: 0x04030F0F RID: 200463
			public const int ItemSaveTip = 6;

			// Token: 0x04030F10 RID: 200464
			public const int TextButton = 7;
		}
	}
}
