using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.Kurotato.View.Components;
using CSharpScript.Game.Module.Kurotato.View.Settlement;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.KurotatoLevelSelect
{
	// Token: 0x0200575B RID: 22363
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoLevelSelectView : UiTickViewBase
	{
		// Token: 0x06038D22 RID: 232738 RVA: 0x00D7EFB4 File Offset: 0x00D7D1B4
		public KurotatoLevelSelectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038D23 RID: 232739 RVA: 0x00D7EFD0 File Offset: 0x00D7D1D0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 27;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIMultiTemplateScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnMonsterHandbookBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038D24 RID: 232740 RVA: 0x00D7F3C4 File Offset: 0x00D7D5C4
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoLevelSelectView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoLevelSelectView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038D25 RID: 232741 RVA: 0x00D7F408 File Offset: 0x00D7D608
		protected override void OnBeforeShow()
		{
			this.RefreshRecordInfo();
			this.InitScrollViewData();
			this.SelectedIndex = this.GetSelectedLevelIndex();
			MultiTemplateScrollViewRefreshContext multiTemplateScrollViewRefreshContext = new MultiTemplateScrollViewRefreshContext(this.ScrollDataList);
			multiTemplateScrollViewRefreshContext.ScrollToGridIndex = this.SelectedIndex;
			multiTemplateScrollViewRefreshContext.GridAnimName = "Start";
			multiTemplateScrollViewRefreshContext.PlayGridAnim = true;
			this.LevelMultiTemplateScrollView.RefreshByData(multiTemplateScrollViewRefreshContext);
			KurotatoLevelItem kurotatoLevelItem = this.LevelMultiTemplateScrollView.GetProxyByGridIndex(this.SelectedIndex) as KurotatoLevelItem;
			if (kurotatoLevelItem != null)
			{
				this.OnItemClick(kurotatoLevelItem.Id, this.SelectedIndex);
			}
			this.RefreshArchiveItem();
			KurotatoLevelGroup? levelGroupConfig = KurotatoConfig.Instance.GetLevelGroupConfig((int)this.LevelSelectViewData.LevelMode);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(22), levelGroupConfig.Value.Name, Array.Empty<object>());
		}

		// Token: 0x06038D26 RID: 232742 RVA: 0x00D7F4D1 File Offset: 0x00D7D6D1
		protected override void OnTick(float delta)
		{
			this.RefreshLockText();
		}

		// Token: 0x06038D27 RID: 232743 RVA: 0x00D7F4DC File Offset: 0x00D7D6DC
		private void RefreshRecordInfo()
		{
			bool flag = this.LevelSelectViewData.LevelMode == EKurotatoLevelMode.Endless;
			UUIItem item = base.GetItem(23);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(12);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!flag);
		}

		// Token: 0x06038D28 RID: 232744 RVA: 0x00D7F524 File Offset: 0x00D7D724
		private void InitScrollViewData()
		{
			this.ScrollDataList = new List<IMultiTemplateGridData>();
			foreach (int num in KurotatoConfig.Instance.GetLevelGroupConfig((int)this.LevelSelectViewData.LevelMode).Value.SecondGroupIter())
			{
				KurotatoLevelSecondGroup? levelSecondGroupConfig = KurotatoConfig.Instance.GetLevelSecondGroupConfig(num);
				KurotatoLevelTitleItemData data = new KurotatoLevelTitleItemData
				{
					TextId = levelSecondGroupConfig.Value.Name,
					BgPath = levelSecondGroupConfig.Value.TitleBg
				};
				KurotatoLevelTitleItemTemplateData kurotatoLevelTitleItemTemplateData = new KurotatoLevelTitleItemTemplateData();
				kurotatoLevelTitleItemTemplateData.Data = data;
				this.ScrollDataList.Add(kurotatoLevelTitleItemTemplateData);
				foreach (KurotatoLevel kurotatoLevel in KurotatoConfig.Instance.GetLevelListBySecondGroup(num))
				{
					KurotatoLevelItemTemplateData kurotatoLevelItemTemplateData = new KurotatoLevelItemTemplateData();
					kurotatoLevelItemTemplateData.Data = kurotatoLevel.Id;
					kurotatoLevelItemTemplateData.OnClickCb = new Action<int, int>(this.OnItemClick);
					kurotatoLevelItemTemplateData.IsSelected = new Func<int, bool>(this.IsSelected);
					this.ScrollDataList.Add(kurotatoLevelItemTemplateData);
				}
			}
		}

		// Token: 0x06038D29 RID: 232745 RVA: 0x00D7F680 File Offset: 0x00D7D880
		private int GetSelectedLevelIndex()
		{
			for (int i = 0; i < this.ScrollDataList.Count; i++)
			{
				KurotatoLevelItemTemplateData kurotatoLevelItemTemplateData = this.ScrollDataList[i] as KurotatoLevelItemTemplateData;
				if (kurotatoLevelItemTemplateData != null && kurotatoLevelItemTemplateData.Data == this.LevelSelectViewData.LevelId)
				{
					return i;
				}
			}
			return 1;
		}

		// Token: 0x06038D2A RID: 232746 RVA: 0x00D7F6CE File Offset: 0x00D7D8CE
		private void RefreshView()
		{
			this.RefreshLevelBasicInfo();
			this.RefreshTargetList();
			this.RefreshRewardPanel();
			this.RefreshUnlockRolePanel();
			this.RefreshLimitRolePanel();
			this.RefreshEndlessInfo();
			this.RefreshBottomInfo();
		}

		// Token: 0x06038D2B RID: 232747 RVA: 0x00D7F6FC File Offset: 0x00D7D8FC
		private void RefreshLevelBasicInfo()
		{
			KurotatoLevel? levelConfig = KurotatoConfig.Instance.GetLevelConfig(this.SelectedLevelData.Id);
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.SetText(this.SelectedLevelData.Number, true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), this.SelectedLevelData.Name, Array.Empty<object>());
			base.SetTextureByPath(levelConfig.Value.Picture, base.GetTexture(6), null, null);
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), levelConfig.Value.DetailDesc, new <>z__ReadOnlySingleElementList<object>(levelConfig.Value.DetailDescParamsIter()));
		}

		// Token: 0x06038D2C RID: 232748 RVA: 0x00D7F7CC File Offset: 0x00D7D9CC
		private void RefreshTargetList()
		{
			KurotatoLevel? levelConfig = KurotatoConfig.Instance.GetLevelConfig(this.SelectedLevelData.Id);
			List<KurotatoLevelTargetItemData> list = new List<KurotatoLevelTargetItemData>();
			foreach (string text in levelConfig.Value.TargetDescIter())
			{
				KurotatoLevelTargetItemData item = new KurotatoLevelTargetItemData
				{
					Text = text,
					IsFinish = (this.SelectedLevelData.IsFinished && !this.SelectedLevelData.IsEndless),
					IsEndless = this.SelectedLevelData.IsEndless
				};
				list.Add(item);
			}
			GenericScrollViewNew<KurotatoLevelTargetItem, KurotatoLevelTargetItemData> targetScroll = this.TargetScroll;
			if (targetScroll == null)
			{
				return;
			}
			targetScroll.RefreshByData(list, delegate
			{
				GenericScrollViewNew<KurotatoLevelTargetItem, KurotatoLevelTargetItemData> targetScroll2 = this.TargetScroll;
				if (targetScroll2 == null)
				{
					return;
				}
				targetScroll2.ScrollToTop(0);
			}, true);
		}

		// Token: 0x06038D2D RID: 232749 RVA: 0x00D7F8A4 File Offset: 0x00D7DAA4
		private void RefreshRewardPanel()
		{
			List<IKurotatoSmallItemGridData> sortedRewardList = this.GetSortedRewardList(KurotatoConfig.Instance.GetLevelConfig(this.SelectedLevelData.Id).Value);
			UUIItem item = base.GetItem(21);
			if (item != null)
			{
				item.SetUIActive(sortedRewardList.Count > 0);
			}
			if (sortedRewardList.Count > 0)
			{
				GenericScrollViewNew<KurotatoWeaponSmallItemGrid, IKurotatoSmallItemGridData> rewardScroll = this.RewardScroll;
				if (rewardScroll == null)
				{
					return;
				}
				rewardScroll.RefreshByData(sortedRewardList, delegate
				{
					GenericScrollViewNew<KurotatoWeaponSmallItemGrid, IKurotatoSmallItemGridData> rewardScroll2 = this.RewardScroll;
					if (rewardScroll2 == null)
					{
						return;
					}
					rewardScroll2.ScrollToLeft(0);
				}, true);
			}
		}

		// Token: 0x06038D2E RID: 232750 RVA: 0x00D7F918 File Offset: 0x00D7DB18
		private List<IKurotatoSmallItemGridData> GetSortedRewardList(KurotatoLevel levelConfig)
		{
			List<IKurotatoSmallItemGridData> list = new List<IKurotatoSmallItemGridData>();
			list.AddRange(this.SortRewardByQuality(levelConfig.UnLockedWeaponsIter().ToList<int>(), EKurotatoCardType.Weapon));
			list.AddRange(this.SortRewardByQuality(levelConfig.UnLockedItemsIter().ToList<int>(), EKurotatoCardType.Item));
			return list;
		}

		// Token: 0x06038D2F RID: 232751 RVA: 0x00D7F954 File Offset: 0x00D7DB54
		private List<IKurotatoSmallItemGridData> SortRewardByQuality(List<int> ids, EKurotatoCardType cardType)
		{
			KurotatoConfig kurotatoConfig = KurotatoConfig.Instance;
			List<int> list = new List<int>(ids);
			list.Sort(delegate(int a, int b)
			{
				int num = base.<SortRewardByQuality>g__GetQuality|0(a);
				int num2 = base.<SortRewardByQuality>g__GetQuality|0(b);
				if (num != num2)
				{
					return num2 - num;
				}
				return a - b;
			});
			return (from id in list
			select new KurotatoSmallItemGridData
			{
				Type = cardType,
				Id = id,
				IncId = 0,
				Count = 1,
				IsReceived = new bool?(this.SelectedLevelData.IsFinished)
			}).ToList<IKurotatoSmallItemGridData>();
		}

		// Token: 0x06038D30 RID: 232752 RVA: 0x00D7F9B0 File Offset: 0x00D7DBB0
		private void RefreshUnlockRolePanel()
		{
			List<int> list = KurotatoConfig.Instance.GetLevelConfig(this.SelectedLevelData.Id).Value.UnlockCharactersIter().ToList<int>();
			int? num = (list.Count > 0) ? new int?(list[0]) : null;
			KurotatoLevelUnlockRolePanel unlockRolePanel = this.UnlockRolePanel;
			if (unlockRolePanel != null)
			{
				unlockRolePanel.SetUiActive(num != null && !this.SelectedLevelData.IsEndless);
			}
			if (num != null && num.Value != 0)
			{
				KurotatoLevelUnlockRolePanel unlockRolePanel2 = this.UnlockRolePanel;
				if (unlockRolePanel2 == null)
				{
					return;
				}
				unlockRolePanel2.Refresh(num.Value);
			}
		}

		// Token: 0x06038D31 RID: 232753 RVA: 0x00D7FA60 File Offset: 0x00D7DC60
		private void RefreshLimitRolePanel()
		{
			int limitRoleId = this.GetLimitRoleId(KurotatoConfig.Instance.GetLevelConfig(this.SelectedLevelData.Id).Value.CharactersIter().ToList<int>());
			UUIItem item = base.GetItem(24);
			if (item != null)
			{
				item.SetUIActive(limitRoleId != 0);
			}
			if (limitRoleId == 0)
			{
				return;
			}
			KurotatoRoleData kurotatoRoleData = this.ActivityData.GetKurotatoRoleData(limitRoleId);
			base.SetTextureByPath(SkinConfig.Instance.GetRoleSkinConfig(kurotatoRoleData.RealRoleSkinId).Value.RoleHeadIconLarge, base.GetTexture(25), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(26), kurotatoRoleData.Name, Array.Empty<object>());
		}

		// Token: 0x06038D32 RID: 232754 RVA: 0x00D7FB20 File Offset: 0x00D7DD20
		private int GetLimitRoleId(IReadOnlyList<int> characters)
		{
			if (characters.Count == 0)
			{
				return 0;
			}
			if (characters.Count == 1)
			{
				return characters[0];
			}
			List<KurotatoRoleData> kurotatoRoleList = this.ActivityData.GetKurotatoRoleList();
			using (IEnumerator<int> enumerator = characters.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int id = enumerator.Current;
					if (kurotatoRoleList.Any((KurotatoRoleData data) => data.Id == id))
					{
						return id;
					}
				}
			}
			return characters[0];
		}

		// Token: 0x06038D33 RID: 232755 RVA: 0x00D7FBBC File Offset: 0x00D7DDBC
		private void RefreshEndlessInfo()
		{
			if (!this.SelectedLevelData.IsEndless)
			{
				return;
			}
			KurotatoEndlessHistoryPanel endlessHistoryPanel = this.EndlessHistoryPanel;
			if (endlessHistoryPanel == null)
			{
				return;
			}
			endlessHistoryPanel.Refresh(this.SelectedLevelData);
		}

		// Token: 0x06038D34 RID: 232756 RVA: 0x00D7FBE4 File Offset: 0x00D7DDE4
		private void RefreshBottomInfo()
		{
			bool hasArchivedData = this.SelectedLevelData.HasArchivedData;
			UUIItem item = base.GetItem(14);
			if (item != null)
			{
				item.SetUIActive(this.SelectedLevelData.IsUnLock);
			}
			UUIItem item2 = base.GetItem(19);
			if (item2 != null)
			{
				item2.SetUIActive(!this.SelectedLevelData.IsUnLock);
			}
			UUIItem item3 = base.GetItem(16);
			if (item3 != null)
			{
				item3.SetUIActive(hasArchivedData);
			}
			UUIItem item4 = base.GetItem(18);
			if (item4 != null)
			{
				item4.SetUIActive(!hasArchivedData);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(17), this.SelectedLevelData.IsArchiveSpecialWave ? "Kurotato_Special_Boss_Prograss" : "Kurotato_Level_Select_Progress", new <>z__ReadOnlyArray<object>(new object[]
			{
				this.SelectedLevelData.ArchiveWave,
				this.SelectedLevelData.TotalWave
			}));
			string textId = hasArchivedData ? "Kurotato_Level_Select_Continue" : "Kurotato_Level_Select_Start";
			ButtonItem gotoBtn = this.GotoBtn;
			if (gotoBtn == null)
			{
				return;
			}
			gotoBtn.SetLocalTextNew(textId, Array.Empty<object>());
		}

		// Token: 0x06038D35 RID: 232757 RVA: 0x00D7FCEC File Offset: 0x00D7DEEC
		private void RefreshLockText()
		{
			if (this.SelectedLevelData == null || this.SelectedLevelData.IsUnLock)
			{
				return;
			}
			if (this.SelectedLevelData.IsReachUnlockTime())
			{
				KurotatoLevel? levelConfig = KurotatoConfig.Instance.GetLevelConfig(this.SelectedLevelData.PreId);
				string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(levelConfig.Value.Name);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(20), "Kurotato_Level_Select_UnlockTip", new <>z__ReadOnlySingleElementList<object>(multiTextByKey));
				return;
			}
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("Kurotato_Level_Select_UnlockTip2", null);
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.SelectedLevelData.UnlockTime, localTextNew);
			UUIText text = base.GetText(20);
			if (text == null)
			{
				return;
			}
			text.SetText(remainTimeText, true);
		}

		// Token: 0x06038D36 RID: 232758 RVA: 0x00D7FDA4 File Offset: 0x00D7DFA4
		private void OnItemClick(int id, int index)
		{
			this.LevelSelectViewData.LevelId = id;
			this.SelectedLevelData = this.ActivityData.GetKurotatoLevelData(id);
			this.LevelMultiTemplateScrollView.RefreshProxyDirectly(this.SelectedIndex);
			this.SelectedIndex = index;
			this.LevelMultiTemplateScrollView.RefreshProxyDirectly(index);
			this.RefreshView();
			this.RefreshArchiveItem();
			base.PlayOrReplaySequence("Switch", false, null);
		}

		// Token: 0x06038D37 RID: 232759 RVA: 0x00D7FE16 File Offset: 0x00D7E016
		private bool IsSelected(int id)
		{
			return this.LevelSelectViewData.LevelId == id;
		}

		// Token: 0x06038D38 RID: 232760 RVA: 0x00D7FE28 File Offset: 0x00D7E028
		private void OnRewardToggleClickCallback(IKurotatoSmallItemGridData cardData)
		{
			List<IKurotatoSmallItemGridData> sortedRewardList = this.GetSortedRewardList(KurotatoConfig.Instance.GetLevelConfig(this.LevelSelectViewData.LevelId).Value);
			List<KurotatoCardTip> cardData2 = (from entry in sortedRewardList
			select new KurotatoCardTip
			{
				CardType = entry.Type,
				SelectId = entry.Id,
				IsConfigId = new bool?(true)
			}).ToList<KurotatoCardTip>();
			UiManager.Instance.OpenView(EUiViewName.KurotatoPopupWeaponDetailView, new KurotatoPopupItemDetailOpenParam
			{
				Index = sortedRewardList.FindIndex((IKurotatoSmallItemGridData entry) => entry.Type == cardData.Type && entry.Id == cardData.Id),
				CardData = cardData2,
				IsOutSide = new bool?(true)
			}, null);
		}

		// Token: 0x06038D39 RID: 232761 RVA: 0x00D7FED4 File Offset: 0x00D7E0D4
		private KurotatoWeaponSmallItemGrid CreateRewardItem()
		{
			KurotatoWeaponSmallItemGrid item = new KurotatoWeaponSmallItemGrid(false);
			item.BindCallback(delegate(IKurotatoSmallItemGridData data, EToggleState state, int gridIndex)
			{
				if (state != EToggleState.ETT_Checked)
				{
					return;
				}
				item.SetSelected(false, false);
				this.OnRewardToggleClickCallback(data);
			});
			return item;
		}

		// Token: 0x06038D3A RID: 232762 RVA: 0x00D7FF17 File Offset: 0x00D7E117
		private KurotatoLevelTargetItem CreateTargetItem()
		{
			return new KurotatoLevelTargetItem();
		}

		// Token: 0x06038D3B RID: 232763 RVA: 0x00D7FF20 File Offset: 0x00D7E120
		private void OnUnlockRoleBtnClick(int roleId)
		{
			List<int> list = KurotatoConfig.Instance.GetLevelConfig(this.SelectedLevelData.Id).Value.UnlockCharactersIter().ToList<int>();
			int index = list.IndexOf(roleId);
			KurotatoPopupUnlockRoleOpenParam param = new KurotatoPopupUnlockRoleOpenParam
			{
				RoleIds = list,
				Index = index
			};
			UiManager.Instance.OpenView(EUiViewName.KurotatoPopupUnlockRoleView, param, null);
		}

		// Token: 0x06038D3C RID: 232764 RVA: 0x00D7FF88 File Offset: 0x00D7E188
		private void OnMonsterHandbookBtnClick()
		{
			KurotatoEnemyDetailBookMainViewOpenParam param = new KurotatoEnemyDetailBookMainViewOpenParam
			{
				TargetLevel = this.SelectedLevelData.Id,
				TargetWave = 0
			};
			UiManager.Instance.OpenView(EUiViewName.KurotatoEnemyDetailBookMainView, param, null);
		}

		// Token: 0x06038D3D RID: 232765 RVA: 0x00D7FFC4 File Offset: 0x00D7E1C4
		private void OnClickArchiveBtn()
		{
			HelpController.Instance.OpenHelpById(630);
		}

		// Token: 0x06038D3E RID: 232766 RVA: 0x00D7FFD8 File Offset: 0x00D7E1D8
		private void RefreshArchiveItem()
		{
			KurotatoLevelData selectedLevelData = this.SelectedLevelData;
			bool flag = selectedLevelData != null && selectedLevelData.HasArchivedData;
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem != null)
			{
				captionItem.SetCaptionStateActive(true);
			}
			PopupCaptionItem captionItem2 = this.CaptionItem;
			if (captionItem2 != null)
			{
				captionItem2.SetCaptionStateTip(flag ? "Kurotato_Has_Archive" : "Kurotato_Can_Archive");
			}
			PopupCaptionItem captionItem3 = this.CaptionItem;
			if (captionItem3 == null)
			{
				return;
			}
			captionItem3.SetCaptionChangeColor(flag);
		}

		// Token: 0x06038D3F RID: 232767 RVA: 0x00D8003B File Offset: 0x00D7E23B
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06038D40 RID: 232768 RVA: 0x00D80044 File Offset: 0x00D7E244
		private void OnHelpBtnClick()
		{
			int helpGroupId = (this.LevelSelectViewData.LevelMode == EKurotatoLevelMode.Endless) ? 614 : 573;
			HelpController.Instance.OpenHelpById(helpGroupId);
		}

		// Token: 0x06038D41 RID: 232769 RVA: 0x00D8007C File Offset: 0x00D7E27C
		private void OnGotoBtnClick(int data)
		{
			if (this.SelectedLevelData.ArchiveWave != -1)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.KurotatoArchiveConfirm);
				confirmBoxDataNew.IsEscViewTriggerCallBack = false;
				confirmBoxDataNew.FunctionMap[1] = delegate()
				{
					KurotatoController.Instance.RequestKurotatoLevelRecordDelete(this.LevelSelectViewData.LevelId).ContinueWith(delegate(bool isSuccess)
					{
						if (!isSuccess)
						{
							return;
						}
						UiManager.Instance.OpenView(EUiViewName.KurotatoRoleSelectView, this.LevelSelectViewData, null);
					}).Forget();
				};
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					KurotatoController.Instance.RequestEnterInst(this.LevelSelectViewData.LevelId, 0, true);
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.KurotatoRoleSelectView, this.LevelSelectViewData, null);
		}

		// Token: 0x0401DCE5 RID: 122085
		[Nullable(2)]
		private KurotatoLevelSelectViewData LevelSelectViewData;

		// Token: 0x0401DCE6 RID: 122086
		private KurotatoActivityData ActivityData;

		// Token: 0x0401DCE7 RID: 122087
		private List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0401DCE8 RID: 122088
		private int SelectedIndex = 1;

		// Token: 0x0401DCE9 RID: 122089
		private KurotatoLevelData SelectedLevelData;

		// Token: 0x0401DCEA RID: 122090
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401DCEB RID: 122091
		[Nullable(2)]
		private MultiTemplateScrollView LevelMultiTemplateScrollView;

		// Token: 0x0401DCEC RID: 122092
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<KurotatoLevelTargetItem, KurotatoLevelTargetItemData> TargetScroll;

		// Token: 0x0401DCED RID: 122093
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<KurotatoWeaponSmallItemGrid, IKurotatoSmallItemGridData> RewardScroll;

		// Token: 0x0401DCEE RID: 122094
		[Nullable(2)]
		private KurotatoLevelUnlockRolePanel UnlockRolePanel;

		// Token: 0x0401DCEF RID: 122095
		[Nullable(2)]
		private KurotatoEndlessHistoryPanel EndlessHistoryPanel;

		// Token: 0x0401DCF0 RID: 122096
		[Nullable(2)]
		private ButtonItem GotoBtn;
	}
}
