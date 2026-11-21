using System;
using System.Collections.Generic;
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
	// Token: 0x02004732 RID: 18226
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoLevelSelectView : UiTickViewBase
	{
		// Token: 0x0602DC32 RID: 187442 RVA: 0x00CCD98C File Offset: 0x00CCBB8C
		public KurotatoLevelSelectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602DC33 RID: 187443 RVA: 0x00CCD9A8 File Offset: 0x00CCBBA8
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

		// Token: 0x0602DC34 RID: 187444 RVA: 0x00CCDD9C File Offset: 0x00CCBF9C
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoLevelSelectView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoLevelSelectView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DC35 RID: 187445 RVA: 0x00CCDDE0 File Offset: 0x00CCBFE0
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

		// Token: 0x0602DC36 RID: 187446 RVA: 0x00CCDEA9 File Offset: 0x00CCC0A9
		protected override void OnTick(float delta)
		{
			this.RefreshLockText();
		}

		// Token: 0x0602DC37 RID: 187447 RVA: 0x00CCDEB4 File Offset: 0x00CCC0B4
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

		// Token: 0x0602DC38 RID: 187448 RVA: 0x00CCDEFC File Offset: 0x00CCC0FC
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

		// Token: 0x0602DC39 RID: 187449 RVA: 0x00CCE058 File Offset: 0x00CCC258
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

		// Token: 0x0602DC3A RID: 187450 RVA: 0x00CCE0A6 File Offset: 0x00CCC2A6
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

		// Token: 0x0602DC3B RID: 187451 RVA: 0x00CCE0D4 File Offset: 0x00CCC2D4
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

		// Token: 0x0602DC3C RID: 187452 RVA: 0x00CCE1A4 File Offset: 0x00CCC3A4
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

		// Token: 0x0602DC3D RID: 187453 RVA: 0x00CCE27C File Offset: 0x00CCC47C
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

		// Token: 0x0602DC3E RID: 187454 RVA: 0x00CCE2F0 File Offset: 0x00CCC4F0
		private List<IKurotatoSmallItemGridData> GetSortedRewardList(KurotatoLevel levelConfig)
		{
			List<IKurotatoSmallItemGridData> list = new List<IKurotatoSmallItemGridData>();
			list.AddRange(this.SortRewardByQuality(new List<int>(levelConfig.UnLockedWeaponsIter()), EKurotatoCardType.Weapon));
			list.AddRange(this.SortRewardByQuality(new List<int>(levelConfig.UnLockedItemsIter()), EKurotatoCardType.Item));
			return list;
		}

		// Token: 0x0602DC3F RID: 187455 RVA: 0x00CCE32C File Offset: 0x00CCC52C
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
			List<IKurotatoSmallItemGridData> list2 = new List<IKurotatoSmallItemGridData>(list.Count);
			foreach (int id in list)
			{
				list2.Add(new KurotatoSmallItemGridData
				{
					Type = cardType,
					Id = id,
					IncId = 0,
					Count = 1,
					IsReceived = new bool?(this.SelectedLevelData.IsFinished)
				});
			}
			return list2;
		}

		// Token: 0x0602DC40 RID: 187456 RVA: 0x00CCE3F4 File Offset: 0x00CCC5F4
		private void RefreshUnlockRolePanel()
		{
			List<int> list = new List<int>(KurotatoConfig.Instance.GetLevelConfig(this.SelectedLevelData.Id).Value.UnlockCharactersIter());
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

		// Token: 0x0602DC41 RID: 187457 RVA: 0x00CCE4A4 File Offset: 0x00CCC6A4
		private void RefreshLimitRolePanel()
		{
			int limitRoleId = this.GetLimitRoleId(new List<int>(KurotatoConfig.Instance.GetLevelConfig(this.SelectedLevelData.Id).Value.CharactersIter()));
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

		// Token: 0x0602DC42 RID: 187458 RVA: 0x00CCE564 File Offset: 0x00CCC764
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
			foreach (int num in characters)
			{
				using (List<KurotatoRoleData>.Enumerator enumerator2 = kurotatoRoleList.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current.Id == num)
						{
							return num;
						}
					}
				}
			}
			return characters[0];
		}

		// Token: 0x0602DC43 RID: 187459 RVA: 0x00CCE618 File Offset: 0x00CCC818
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

		// Token: 0x0602DC44 RID: 187460 RVA: 0x00CCE640 File Offset: 0x00CCC840
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

		// Token: 0x0602DC45 RID: 187461 RVA: 0x00CCE748 File Offset: 0x00CCC948
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

		// Token: 0x0602DC46 RID: 187462 RVA: 0x00CCE800 File Offset: 0x00CCCA00
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

		// Token: 0x0602DC47 RID: 187463 RVA: 0x00CCE872 File Offset: 0x00CCCA72
		private bool IsSelected(int id)
		{
			return this.LevelSelectViewData.LevelId == id;
		}

		// Token: 0x0602DC48 RID: 187464 RVA: 0x00CCE884 File Offset: 0x00CCCA84
		private void OnRewardToggleClickCallback(IKurotatoSmallItemGridData cardData)
		{
			List<IKurotatoSmallItemGridData> sortedRewardList = this.GetSortedRewardList(KurotatoConfig.Instance.GetLevelConfig(this.LevelSelectViewData.LevelId).Value);
			List<KurotatoCardTip> list = new List<KurotatoCardTip>(sortedRewardList.Count);
			foreach (IKurotatoSmallItemGridData kurotatoSmallItemGridData in sortedRewardList)
			{
				list.Add(new KurotatoCardTip
				{
					CardType = kurotatoSmallItemGridData.Type,
					SelectId = kurotatoSmallItemGridData.Id,
					IsConfigId = new bool?(true)
				});
			}
			UiManager.Instance.OpenView(EUiViewName.KurotatoPopupWeaponDetailView, new KurotatoPopupItemDetailOpenParam
			{
				Index = sortedRewardList.FindIndex((IKurotatoSmallItemGridData entry) => entry.Type == cardData.Type && entry.Id == cardData.Id),
				CardData = list,
				IsOutSide = new bool?(true)
			}, null);
		}

		// Token: 0x0602DC49 RID: 187465 RVA: 0x00CCE97C File Offset: 0x00CCCB7C
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

		// Token: 0x0602DC4A RID: 187466 RVA: 0x00CCE9BF File Offset: 0x00CCCBBF
		private KurotatoLevelTargetItem CreateTargetItem()
		{
			return new KurotatoLevelTargetItem();
		}

		// Token: 0x0602DC4B RID: 187467 RVA: 0x00CCE9C8 File Offset: 0x00CCCBC8
		private void OnUnlockRoleBtnClick(int roleId)
		{
			List<int> list = new List<int>(KurotatoConfig.Instance.GetLevelConfig(this.SelectedLevelData.Id).Value.UnlockCharactersIter());
			int index = list.IndexOf(roleId);
			KurotatoPopupUnlockRoleOpenParam param = new KurotatoPopupUnlockRoleOpenParam
			{
				RoleIds = list,
				Index = index
			};
			UiManager.Instance.OpenView(EUiViewName.KurotatoPopupUnlockRoleView, param, null);
		}

		// Token: 0x0602DC4C RID: 187468 RVA: 0x00CCEA30 File Offset: 0x00CCCC30
		private void OnMonsterHandbookBtnClick()
		{
			KurotatoEnemyDetailBookMainViewOpenParam param = new KurotatoEnemyDetailBookMainViewOpenParam
			{
				TargetLevel = this.SelectedLevelData.Id,
				TargetWave = 0
			};
			UiManager.Instance.OpenView(EUiViewName.KurotatoEnemyDetailBookMainView, param, null);
		}

		// Token: 0x0602DC4D RID: 187469 RVA: 0x00CCEA6C File Offset: 0x00CCCC6C
		private void OnClickArchiveBtn()
		{
			HelpController.Instance.OpenHelpById(630);
		}

		// Token: 0x0602DC4E RID: 187470 RVA: 0x00CCEA80 File Offset: 0x00CCCC80
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

		// Token: 0x0602DC4F RID: 187471 RVA: 0x00CCEAE3 File Offset: 0x00CCCCE3
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602DC50 RID: 187472 RVA: 0x00CCEAEC File Offset: 0x00CCCCEC
		private void OnHelpBtnClick()
		{
			int helpGroupId = (this.LevelSelectViewData.LevelMode == EKurotatoLevelMode.Endless) ? 614 : 573;
			HelpController.Instance.OpenHelpById(helpGroupId);
		}

		// Token: 0x0602DC51 RID: 187473 RVA: 0x00CCEB24 File Offset: 0x00CCCD24
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

		// Token: 0x0401877B RID: 100219
		[Nullable(2)]
		private KurotatoLevelSelectViewData LevelSelectViewData;

		// Token: 0x0401877C RID: 100220
		private KurotatoActivityData ActivityData;

		// Token: 0x0401877D RID: 100221
		private List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0401877E RID: 100222
		private int SelectedIndex = 1;

		// Token: 0x0401877F RID: 100223
		private KurotatoLevelData SelectedLevelData;

		// Token: 0x04018780 RID: 100224
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04018781 RID: 100225
		[Nullable(2)]
		private MultiTemplateScrollView LevelMultiTemplateScrollView;

		// Token: 0x04018782 RID: 100226
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<KurotatoLevelTargetItem, KurotatoLevelTargetItemData> TargetScroll;

		// Token: 0x04018783 RID: 100227
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<KurotatoWeaponSmallItemGrid, IKurotatoSmallItemGridData> RewardScroll;

		// Token: 0x04018784 RID: 100228
		[Nullable(2)]
		private KurotatoLevelUnlockRolePanel UnlockRolePanel;

		// Token: 0x04018785 RID: 100229
		[Nullable(2)]
		private KurotatoEndlessHistoryPanel EndlessHistoryPanel;

		// Token: 0x04018786 RID: 100230
		[Nullable(2)]
		private ButtonItem GotoBtn;
	}
}
