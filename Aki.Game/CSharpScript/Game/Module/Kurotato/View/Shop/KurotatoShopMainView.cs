using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato.View.AttrSelect;
using CSharpScript.Game.Module.Kurotato.View.Components;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Shop
{
	// Token: 0x020046F5 RID: 18165
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoShopMainView : UiViewBase
	{
		// Token: 0x0602DA3E RID: 186942 RVA: 0x00CC1FF7 File Offset: 0x00CC01F7
		public KurotatoShopMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602DA3F RID: 186943 RVA: 0x00CC2038 File Offset: 0x00CC0238
		protected unsafe override void OnRegisterComponent()
		{
			int num = 17;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickRefresh));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickGo));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602DA40 RID: 186944 RVA: 0x00CC22FC File Offset: 0x00CC04FC
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoShopMainView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoShopMainView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DA41 RID: 186945 RVA: 0x00CC2340 File Offset: 0x00CC0540
		private UniTask CreatePopupPanel()
		{
			KurotatoShopMainView.<CreatePopupPanel>d__9 <CreatePopupPanel>d__;
			<CreatePopupPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreatePopupPanel>d__.<>4__this = this;
			<CreatePopupPanel>d__.<>1__state = -1;
			<CreatePopupPanel>d__.<>t__builder.Start<KurotatoShopMainView.<CreatePopupPanel>d__9>(ref <CreatePopupPanel>d__);
			return <CreatePopupPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0602DA42 RID: 186946 RVA: 0x00CC2383 File Offset: 0x00CC0583
		private void CreateItemSelectLayout()
		{
			this.ItemSelectLayout = new GenericLayout<KurotatoShopSelectCard, IKurotatoShopSelectCardData>(base.GetHorizontalLayout(4), delegate()
			{
				KurotatoShopSelectCard kurotatoShopSelectCard = new KurotatoShopSelectCard();
				kurotatoShopSelectCard.SetConfirmCb(new Action<int>(this.OnClickSelectConfirm));
				kurotatoShopSelectCard.SetBuildTagClickCb(new Action<int, EToggleState>(this.OnClickBuildTag));
				kurotatoShopSelectCard.SetAttrPreviewCb(new Action<int, bool, IReadOnlyList<IKurotatoAttrPreviewDelta>>(this.OnCardAttrPreview));
				return kurotatoShopSelectCard;
			}, null, false, true);
		}

		// Token: 0x0602DA43 RID: 186947 RVA: 0x00CC23A6 File Offset: 0x00CC05A6
		private void CreateItemLayout()
		{
			this.WeaponLayout = new GenericLayout<KurotatoWeaponSmallItemGrid, IKurotatoSmallItemGridData>(base.GetHorizontalLayout(13), delegate()
			{
				KurotatoWeaponSmallItemGrid kurotatoWeaponSmallItemGrid = new KurotatoWeaponSmallItemGrid(true);
				kurotatoWeaponSmallItemGrid.BindCallback(new Action<IKurotatoSmallItemGridData, EToggleState, int>(this.OnClickWeaponGrid));
				return kurotatoWeaponSmallItemGrid;
			}, null, false, true);
		}

		// Token: 0x0602DA44 RID: 186948 RVA: 0x00CC23CC File Offset: 0x00CC05CC
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.KurotatoOnShopDataChanged, new Action(this.OnUpgradeRewardChanged));
			EventSystem.Instance.Add(EEventName.KurotatoOnWeaponUpdate, new Action(this.OnUpdateWeapon));
			EventSystem.Instance.Add<int>(EEventName.KurotatoOnWeaponRefined, new Action<int>(this.OnWeaponRefined));
			EventSystem.Instance.Add<int, bool>(EEventName.KurotatoOnItemUpdate, new Action<int, bool>(this.OnItemUpdate));
			EventSystem.Instance.Add(EEventName.KurotatoOnNextWaveTypeUpdate, new Action(this.OnNextWaveTypeUpdate));
			KurotatoModel.Instance.BattleData.BehaviorDelegate.AddTreeVarUpdateDelegate(EKurotatoSystemVarType.Gold.ToEnumString(), new TTreeVarUpdateDelegate(this.OnCurrencyUpdate));
		}

		// Token: 0x0602DA45 RID: 186949 RVA: 0x00CC248C File Offset: 0x00CC068C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.KurotatoOnShopDataChanged, new Action(this.OnUpgradeRewardChanged));
			EventSystem.Instance.Remove(EEventName.KurotatoOnWeaponUpdate, new Action(this.OnUpdateWeapon));
			EventSystem.Instance.Remove<int>(EEventName.KurotatoOnWeaponRefined, new Action<int>(this.OnWeaponRefined));
			EventSystem.Instance.Remove<int, bool>(EEventName.KurotatoOnItemUpdate, new Action<int, bool>(this.OnItemUpdate));
			EventSystem.Instance.Remove(EEventName.KurotatoOnNextWaveTypeUpdate, new Action(this.OnNextWaveTypeUpdate));
			KurotatoModel.Instance.BattleData.BehaviorDelegate.RemoveTreeVarUpdateDelegate(EKurotatoSystemVarType.Gold.ToEnumString(), new TTreeVarUpdateDelegate(this.OnCurrencyUpdate));
		}

		// Token: 0x0602DA46 RID: 186950 RVA: 0x00CC254B File Offset: 0x00CC074B
		protected override void OnStart()
		{
			this.PendingShopRefreshAnim = true;
			this.RefreshWave();
			this.CommonPopupPanel.SetTitleLocalText("Kurotato_Shop_Title");
		}

		// Token: 0x0602DA47 RID: 186951 RVA: 0x00CC256A File Offset: 0x00CC076A
		protected override void OnBeforeShow()
		{
			this.CommonPopupPanel.HideAttrChangeFx();
			this.OnUpgradeRewardChanged();
		}

		// Token: 0x0602DA48 RID: 186952 RVA: 0x00CC2580 File Offset: 0x00CC0780
		private void RefreshSelectLayout()
		{
			KurotatoModel instance = KurotatoModel.Instance;
			List<KurotatoShopProductPbData> shopData = instance.GetShopData();
			List<IKurotatoShopSelectCardData> list = new List<IKurotatoShopSelectCardData>();
			foreach (KurotatoShopProductPbData kurotatoShopProductPbData in shopData)
			{
				EKurotatoCardType ekurotatoCardType = (kurotatoShopProductPbData.ItemData != null) ? EKurotatoCardType.Item : EKurotatoCardType.Weapon;
				int num = (ekurotatoCardType == EKurotatoCardType.Item) ? kurotatoShopProductPbData.ItemData.ItemId : kurotatoShopProductPbData.WeaponData.WeaponId;
				list.Add(new KurotatoShopSelectCardData
				{
					Id = num,
					SelectionId = kurotatoShopProductPbData.SelectionId,
					OriginalCost = kurotatoShopProductPbData.OriginalCost,
					Cost = kurotatoShopProductPbData.Cost,
					CardType = ekurotatoCardType,
					HasBuy = kurotatoShopProductPbData.IsBought,
					IsRecommend = ((ekurotatoCardType == EKurotatoCardType.Item) ? instance.IsRecommendItem(num) : instance.IsRecommendWeapon(num)),
					IsLock = kurotatoShopProductPbData.IsLocked
				});
			}
			if (this.IsSelectDataSame(list))
			{
				return;
			}
			this.CommonPopupPanel.ClearAttrPreview();
			GenericLayout<KurotatoShopSelectCard, IKurotatoShopSelectCardData> itemSelectLayout = this.ItemSelectLayout;
			foreach (KurotatoShopSelectCard kurotatoShopSelectCard in (((itemSelectLayout != null) ? itemSelectLayout.GetLayoutItemList() : null) ?? new List<KurotatoShopSelectCard>()))
			{
				kurotatoShopSelectCard.CloseBuildInfo();
				kurotatoShopSelectCard.ClearAttrPreviewSelection();
			}
			bool flag = list.Count > 0;
			this.ItemSelectLayout.RefreshByData(list, delegate
			{
				this.RefreshCardsComposeState();
			}, this.PendingShopRefreshAnim && flag);
			if (flag)
			{
				this.PendingShopRefreshAnim = false;
				this.RefreshWeaponLayout(null);
			}
		}

		// Token: 0x0602DA49 RID: 186953 RVA: 0x00CC273C File Offset: 0x00CC093C
		private bool IsSelectDataSame(List<IKurotatoShopSelectCardData> newData)
		{
			IReadOnlyList<IKurotatoShopSelectCardData> datas = this.ItemSelectLayout.GetDatas();
			if (datas.Count != newData.Count)
			{
				return false;
			}
			for (int i = 0; i < newData.Count; i++)
			{
				IKurotatoShopSelectCardData kurotatoShopSelectCardData = datas[i];
				IKurotatoShopSelectCardData kurotatoShopSelectCardData2 = newData[i];
				if (kurotatoShopSelectCardData.Id != kurotatoShopSelectCardData2.Id || kurotatoShopSelectCardData.SelectionId != kurotatoShopSelectCardData2.SelectionId || kurotatoShopSelectCardData.OriginalCost != kurotatoShopSelectCardData2.OriginalCost || kurotatoShopSelectCardData.Cost != kurotatoShopSelectCardData2.Cost || kurotatoShopSelectCardData.CardType != kurotatoShopSelectCardData2.CardType || kurotatoShopSelectCardData.HasBuy != kurotatoShopSelectCardData2.HasBuy || kurotatoShopSelectCardData.IsRecommend != kurotatoShopSelectCardData2.IsRecommend || kurotatoShopSelectCardData.IsLock != kurotatoShopSelectCardData2.IsLock)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0602DA4A RID: 186954 RVA: 0x00CC2800 File Offset: 0x00CC0A00
		private void RefreshWave()
		{
			KurotatoModel instance = KurotatoModel.Instance;
			UUIText text = base.GetText(3);
			if (instance.GetIsSpecialWave())
			{
				text.ShowTextNew("Kurotato_Special_Boss");
				return;
			}
			UUIText uuitext = text;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(instance.BattleData.GetBatch());
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(instance.BattleData.GetMaxBatch());
			uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0602DA4B RID: 186955 RVA: 0x00CC2878 File Offset: 0x00CC0A78
		private void RefreshRefreshInfo()
		{
			KurotatoModel instance = KurotatoModel.Instance;
			int refreshCost = instance.GetRefreshCost();
			UUIText text = base.GetText(7);
			UUIText uuitext = text;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(refreshCost);
			uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			base.GetText(8).SetUIActive(false);
			bool flag = instance.BattleData.GetCurrencyCount() < refreshCost;
			base.GetButton(6).SetSelfInteractive(!flag);
			UUIItem uuiitem = text;
			bool bUseChangeColor = flag;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}

		// Token: 0x0602DA4C RID: 186956 RVA: 0x00CC28FC File Offset: 0x00CC0AFC
		private void RefreshWeaponLayout(int? composeIncId = null)
		{
			List<IKurotatoWeaponData> holdWeaponData = KurotatoModel.Instance.GetHoldWeaponData();
			this.ComposeHighlight = KurotatoModel.Instance.GetComposeHighlight();
			HashSet<int> arrowIncIds = this.ComposeHighlight.ArrowIncIds;
			List<IKurotatoSmallItemGridData> list = new List<IKurotatoSmallItemGridData>();
			foreach (IKurotatoWeaponData kurotatoWeaponData in holdWeaponData)
			{
				list.Add(new KurotatoSmallItemGridData
				{
					Type = EKurotatoCardType.Weapon,
					Id = kurotatoWeaponData.WeaponId,
					IncId = kurotatoWeaponData.IncId,
					Count = 1,
					PlayComposeFx = new bool?(composeIncId != null && kurotatoWeaponData.IncId == composeIncId.Value),
					ShowArrow = new bool?(arrowIncIds.Contains(kurotatoWeaponData.IncId))
				});
			}
			if (composeIncId == null && this.IsWeaponDataSame(list))
			{
				return;
			}
			this.WeaponLayout.RefreshByData(list, null, false);
		}

		// Token: 0x0602DA4D RID: 186957 RVA: 0x00CC2A00 File Offset: 0x00CC0C00
		private bool IsWeaponDataSame(List<IKurotatoSmallItemGridData> newData)
		{
			IReadOnlyList<IKurotatoSmallItemGridData> datas = this.WeaponLayout.GetDatas();
			if (datas.Count != newData.Count)
			{
				return false;
			}
			int i = 0;
			while (i < newData.Count)
			{
				if (datas[i].Id == newData[i].Id && datas[i].IncId == newData[i].IncId)
				{
					bool? showArrow = datas[i].ShowArrow;
					bool? showArrow2 = newData[i].ShowArrow;
					if (showArrow.GetValueOrDefault() == showArrow2.GetValueOrDefault() & showArrow != null == (showArrow2 != null))
					{
						i++;
						continue;
					}
				}
				return false;
			}
			return true;
		}

		// Token: 0x0602DA4E RID: 186958 RVA: 0x00CC2AB0 File Offset: 0x00CC0CB0
		private void RefreshWaveTip()
		{
			KurotatoModel instance = KurotatoModel.Instance;
			KurotatoConfig instance2 = KurotatoConfig.Instance;
			int curLevelId = instance.GetCurLevelId();
			int batch = instance.BattleData.GetBatch();
			List<KurotatoWave> list = instance2.GetWaveByLevelId(curLevelId) ?? new List<KurotatoWave>();
			int nextWaveNum = instance.GetNextWaveNum();
			int num = (nextWaveNum != 0) ? nextWaveNum : (batch + 1);
			KurotatoWave? kurotatoWave = null;
			foreach (KurotatoWave value in list)
			{
				if (value.Wave == num)
				{
					kurotatoWave = new KurotatoWave?(value);
					break;
				}
			}
			bool flag = kurotatoWave != null && instance2.WaveHasRiskType(kurotatoWave.Value, EKurotatoRiskType.BOSS);
			bool isNextWaveSpecial = instance.GetIsNextWaveSpecial();
			int num2 = 0;
			foreach (KurotatoWave kurotatoWave2 in list)
			{
				if (kurotatoWave2.Wave >= num && kurotatoWave2.IsPowerWave)
				{
					num2 = kurotatoWave2.Wave;
					break;
				}
			}
			bool flag2 = num2 == num;
			bool flag3 = num2 > num;
			base.GetItem(15).SetUIActive(isNextWaveSpecial);
			base.GetItem(11).SetUIActive(!isNextWaveSpecial && flag);
			base.GetItem(16).SetUIActive(!isNextWaveSpecial && !flag && flag2);
			base.GetItem(10).SetUIActive(!isNextWaveSpecial && !flag && !flag2 && flag3);
			if (flag3)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(12), "PrefabTextItem_3621275509_Text", new <>z__ReadOnlySingleElementList<object>(num2.ToString()));
			}
		}

		// Token: 0x0602DA4F RID: 186959 RVA: 0x00CC2C74 File Offset: 0x00CC0E74
		private void OnClickSelectConfirm(int selectionId)
		{
			List<KurotatoShopProductPbData> shopData = KurotatoModel.Instance.GetShopData();
			bool flag = false;
			for (int i = 0; i < shopData.Count; i++)
			{
				if (shopData[i].SelectionId == selectionId && shopData[i].IsBought)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				return;
			}
			KurotatoShopProductPbData kurotatoShopProductPbData = null;
			for (int j = 0; j < shopData.Count; j++)
			{
				if (shopData[j].SelectionId == selectionId)
				{
					kurotatoShopProductPbData = shopData[j];
					break;
				}
			}
			if (((kurotatoShopProductPbData != null) ? kurotatoShopProductPbData.ItemData : null) != null && this.IsShopItemQuantityMax(kurotatoShopProductPbData.ItemData.ItemId))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Kurotato_Item_Quantity_Max", Array.Empty<object>());
				return;
			}
			if (((kurotatoShopProductPbData != null) ? kurotatoShopProductPbData.WeaponData : null) != null)
			{
				List<IKurotatoWeaponData> holdWeaponData = KurotatoModel.Instance.GetHoldWeaponData();
				KurotatoActivityConfig? kurotatoActivityConfig;
				int num = (KurotatoModel.Instance.GetActivityConfig() != null) ? kurotatoActivityConfig.GetValueOrDefault().WeaponCount : holdWeaponData.Count;
				int weaponId = kurotatoShopProductPbData.WeaponData.WeaponId;
				if (holdWeaponData.Count >= num && !KurotatoModel.Instance.CanComposeWeapon(weaponId))
				{
					string textId = this.CanComposeAnyHoldWeapon() ? "Kurotato_Weapon_CouldSynthesis" : "Kurotato_Weapon_Quantity_Max";
					ScrollingTipsController.Instance.ShowTipsByTextId(textId, Array.Empty<object>());
					return;
				}
			}
			KurotatoController.Instance.RequestKurotatoShopProductSelect(selectionId).Forget<bool>();
		}

		// Token: 0x0602DA50 RID: 186960 RVA: 0x00CC2DD8 File Offset: 0x00CC0FD8
		private bool IsShopItemQuantityMax(int itemId)
		{
			KurotatoItem? itemConfigByItemId = KurotatoConfig.Instance.GetItemConfigByItemId(itemId);
			return itemConfigByItemId != null && KurotatoModel.Instance.GetHoldItemCount(itemId) >= itemConfigByItemId.Value.MaxStackCount;
		}

		// Token: 0x0602DA51 RID: 186961 RVA: 0x00CC2E1C File Offset: 0x00CC101C
		private bool CanComposeAnyHoldWeapon()
		{
			KurotatoConfig instance = KurotatoConfig.Instance;
			List<IKurotatoWeaponData> holdWeaponData = KurotatoModel.Instance.GetHoldWeaponData();
			for (int i = 0; i < holdWeaponData.Count; i++)
			{
				KurotatoWeapon? weaponConfigByWeaponId = instance.GetWeaponConfigByWeaponId(holdWeaponData[i].WeaponId);
				if (weaponConfigByWeaponId != null)
				{
					int maxQualityByGroupId = instance.GetMaxQualityByGroupId(weaponConfigByWeaponId.Value.GroupId);
					if (weaponConfigByWeaponId.Value.Quality < maxQualityByGroupId)
					{
						for (int j = i + 1; j < holdWeaponData.Count; j++)
						{
							KurotatoWeapon? weaponConfigByWeaponId2 = instance.GetWeaponConfigByWeaponId(holdWeaponData[j].WeaponId);
							if (weaponConfigByWeaponId2 != null && weaponConfigByWeaponId2.Value.GroupId == weaponConfigByWeaponId.Value.GroupId && weaponConfigByWeaponId2.Value.Quality == weaponConfigByWeaponId.Value.Quality)
							{
								return true;
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0602DA52 RID: 186962 RVA: 0x00CC2F18 File Offset: 0x00CC1118
		private void OnUpgradeRewardChanged()
		{
			this.RefreshSelectLayout();
			this.RefreshRefreshInfo();
			this.RefreshWaveTip();
		}

		// Token: 0x0602DA53 RID: 186963 RVA: 0x00CC2F2C File Offset: 0x00CC112C
		private void OnUpdateWeapon()
		{
			this.RefreshWeaponLayout(null);
			this.RefreshSelectLayout();
			this.RefreshCardsComposeState();
			this.RefreshCardsBuildTagLevel();
		}

		// Token: 0x0602DA54 RID: 186964 RVA: 0x00CC2F5A File Offset: 0x00CC115A
		private void OnWeaponRefined(int newWeaponIncId)
		{
			this.RefreshWeaponLayout(new int?(newWeaponIncId));
			this.RefreshCardsComposeState();
		}

		// Token: 0x0602DA55 RID: 186965 RVA: 0x00CC2F70 File Offset: 0x00CC1170
		private void OnItemUpdate(int itemId, bool bIsAdd)
		{
			this.RefreshWaveTip();
			GenericLayout<KurotatoShopSelectCard, IKurotatoShopSelectCardData> itemSelectLayout = this.ItemSelectLayout;
			foreach (KurotatoShopSelectCard kurotatoShopSelectCard in (((itemSelectLayout != null) ? itemSelectLayout.GetLayoutItemList() : null) ?? new List<KurotatoShopSelectCard>()))
			{
				kurotatoShopSelectCard.RefreshHoldNum();
			}
		}

		// Token: 0x0602DA56 RID: 186966 RVA: 0x00CC2FDC File Offset: 0x00CC11DC
		private void OnNextWaveTypeUpdate()
		{
			this.RefreshWaveTip();
		}

		// Token: 0x0602DA57 RID: 186967 RVA: 0x00CC2FE4 File Offset: 0x00CC11E4
		private void RefreshCardsComposeState()
		{
			HashSet<int> upgradeSelectionIds = this.ComposeHighlight.UpgradeSelectionIds;
			GenericLayout<KurotatoShopSelectCard, IKurotatoShopSelectCardData> itemSelectLayout = this.ItemSelectLayout;
			foreach (KurotatoShopSelectCard kurotatoShopSelectCard in (((itemSelectLayout != null) ? itemSelectLayout.GetLayoutItemList() : null) ?? new List<KurotatoShopSelectCard>()))
			{
				kurotatoShopSelectCard.SetComposeUpgradeVisible(upgradeSelectionIds.Contains(kurotatoShopSelectCard.GetSelectionId()));
			}
		}

		// Token: 0x0602DA58 RID: 186968 RVA: 0x00CC3064 File Offset: 0x00CC1264
		private void RefreshCardsBuildTagLevel()
		{
			GenericLayout<KurotatoShopSelectCard, IKurotatoShopSelectCardData> itemSelectLayout = this.ItemSelectLayout;
			foreach (KurotatoShopSelectCard kurotatoShopSelectCard in (((itemSelectLayout != null) ? itemSelectLayout.GetLayoutItemList() : null) ?? new List<KurotatoShopSelectCard>()))
			{
				kurotatoShopSelectCard.RefreshBuildTagLevel();
			}
		}

		// Token: 0x0602DA59 RID: 186969 RVA: 0x00CC30CC File Offset: 0x00CC12CC
		private void OnCurrencyUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
		{
			GenericLayout<KurotatoShopSelectCard, IKurotatoShopSelectCardData> itemSelectLayout = this.ItemSelectLayout;
			foreach (KurotatoShopSelectCard kurotatoShopSelectCard in (((itemSelectLayout != null) ? itemSelectLayout.GetLayoutItemList() : null) ?? new List<KurotatoShopSelectCard>()))
			{
				kurotatoShopSelectCard.RefreshCurrencyState();
			}
			this.RefreshRefreshInfo();
		}

		// Token: 0x0602DA5A RID: 186970 RVA: 0x00CC3138 File Offset: 0x00CC1338
		private void OnClickRefresh()
		{
			KurotatoModel instance = KurotatoModel.Instance;
			List<KurotatoShopProductPbData> shopData = instance.GetShopData();
			bool flag = shopData.Count > 0;
			for (int i = 0; i < shopData.Count; i++)
			{
				if (shopData[i].IsBought || !shopData[i].IsLocked)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_KurotatoShopReflashFail_Text", Array.Empty<object>());
				return;
			}
			if (instance.BattleData.GetCurrencyCount() < instance.GetRefreshCost())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Kurotato_Insufficient_Gold_Coins", Array.Empty<object>());
				return;
			}
			this.PendingShopRefreshAnim = true;
			KurotatoController.Instance.RequestKurotatoShopRewardRefresh().ContinueWith(delegate(bool success)
			{
				if (!success)
				{
					this.PendingShopRefreshAnim = false;
				}
			}).Forget();
		}

		// Token: 0x0602DA5B RID: 186971 RVA: 0x00CC31F4 File Offset: 0x00CC13F4
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length < 2)
			{
				return null;
			}
			string a = configParams[0];
			int num;
			if (!int.TryParse(configParams[1], out num))
			{
				return null;
			}
			int num2 = num - 1;
			if (num2 < 0)
			{
				return null;
			}
			if (a == "WeaponSlot")
			{
				GenericLayout<KurotatoWeaponSmallItemGrid, IKurotatoSmallItemGridData> weaponLayout = this.WeaponLayout;
				KurotatoWeaponSmallItemGrid kurotatoWeaponSmallItemGrid = (weaponLayout != null) ? weaponLayout.GetLayoutItemByIndex(num2) : null;
				UUIItem uuiitem = (kurotatoWeaponSmallItemGrid != null) ? kurotatoWeaponSmallItemGrid.GetRootItem() : null;
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
			else if (a == "ShopCard" || a == "ShopCardLock" || a == "ShopCardDes")
			{
				GenericLayout<KurotatoShopSelectCard, IKurotatoShopSelectCardData> itemSelectLayout = this.ItemSelectLayout;
				KurotatoShopSelectCard kurotatoShopSelectCard = (itemSelectLayout != null) ? itemSelectLayout.GetLayoutItemByIndex(num2) : null;
				if (kurotatoShopSelectCard == null)
				{
					return null;
				}
				if (!(a == "ShopCard"))
				{
					return kurotatoShopSelectCard.GetGuideUiItemAndUiItemForShowEx(configParams);
				}
				UUIItem rootItem = kurotatoShopSelectCard.GetRootItem();
				if (rootItem == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					rootItem,
					rootItem
				};
			}
			else if (a == "ShopRecommend")
			{
				KurotatoShopSelectCard nthRecommendCard = this.GetNthRecommendCard(num2);
				if (nthRecommendCard == null)
				{
					return null;
				}
				return nthRecommendCard.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
			else
			{
				if (!(a == "ShopBuildTag"))
				{
					return null;
				}
				KurotatoShopSelectCard nthBuildTagCard = this.GetNthBuildTagCard(num2);
				if (nthBuildTagCard == null)
				{
					return null;
				}
				return nthBuildTagCard.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
		}

		// Token: 0x0602DA5C RID: 186972 RVA: 0x00CC3324 File Offset: 0x00CC1524
		[NullableContext(2)]
		private KurotatoShopSelectCard GetNthRecommendCard(int idx)
		{
			GenericLayout<KurotatoShopSelectCard, IKurotatoShopSelectCardData> itemSelectLayout = this.ItemSelectLayout;
			List<KurotatoShopSelectCard> list = (itemSelectLayout != null) ? itemSelectLayout.GetLayoutItemList() : null;
			if (list == null)
			{
				return null;
			}
			int num = 0;
			foreach (KurotatoShopSelectCard kurotatoShopSelectCard in list)
			{
				if (kurotatoShopSelectCard.IsRecommend())
				{
					if (num == idx)
					{
						return kurotatoShopSelectCard;
					}
					num++;
				}
			}
			return null;
		}

		// Token: 0x0602DA5D RID: 186973 RVA: 0x00CC33A0 File Offset: 0x00CC15A0
		[NullableContext(2)]
		private KurotatoShopSelectCard GetNthBuildTagCard(int idx)
		{
			GenericLayout<KurotatoShopSelectCard, IKurotatoShopSelectCardData> itemSelectLayout = this.ItemSelectLayout;
			List<KurotatoShopSelectCard> list = (itemSelectLayout != null) ? itemSelectLayout.GetLayoutItemList() : null;
			if (list == null)
			{
				return null;
			}
			int num = 0;
			foreach (KurotatoShopSelectCard kurotatoShopSelectCard in list)
			{
				if (kurotatoShopSelectCard.HasBuildTag())
				{
					if (num == idx)
					{
						return kurotatoShopSelectCard;
					}
					num++;
				}
			}
			return null;
		}

		// Token: 0x0602DA5E RID: 186974 RVA: 0x00CC341C File Offset: 0x00CC161C
		private bool HasAvailableShopItem()
		{
			KurotatoModel instance = KurotatoModel.Instance;
			int currencyCount = instance.BattleData.GetCurrencyCount();
			List<KurotatoShopProductPbData> shopData = instance.GetShopData();
			for (int i = 0; i < shopData.Count; i++)
			{
				if (!shopData[i].IsBought && currencyCount >= shopData[i].Cost)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602DA5F RID: 186975 RVA: 0x00CC3474 File Offset: 0x00CC1674
		private void OpenNotBuyConfirm(bool isEndLess)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.KurotatoNotBuyConfirm);
			confirmBoxDataNew.HasToggle = true;
			confirmBoxDataNew.ToggleTextKey = "Text_ItemRecycleConfirmToggle_text";
			confirmBoxDataNew.SetToggleFunction(new Action<bool>(this.OnToggleNotBuyConfirm));
			Action value = delegate()
			{
				KurotatoModel.Instance.HideShopNotBuyConfirmBox = false;
			};
			confirmBoxDataNew.FunctionMap[0] = value;
			confirmBoxDataNew.FunctionMap[1] = value;
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				KurotatoController.Instance.RequestKurotatoEndShopStep(isEndLess).Forget<bool>();
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602DA60 RID: 186976 RVA: 0x00CC351B File Offset: 0x00CC171B
		private void OnClickGo()
		{
			if (KurotatoModel.Instance.HideShopNotBuyConfirmBox || !this.HasAvailableShopItem())
			{
				KurotatoController.Instance.RequestKurotatoEndShopStep(false).Forget<bool>();
				return;
			}
			this.OpenNotBuyConfirm(false);
		}

		// Token: 0x0602DA61 RID: 186977 RVA: 0x00CC3549 File Offset: 0x00CC1749
		private void OnToggleNotBuyConfirm(bool isSelectedOn)
		{
			KurotatoModel.Instance.HideShopNotBuyConfirmBox = isSelectedOn;
		}

		// Token: 0x0602DA62 RID: 186978 RVA: 0x00CC3558 File Offset: 0x00CC1758
		private void OnClickWeaponGrid(IKurotatoSmallItemGridData data, EToggleState state, int gridIndex)
		{
			KurotatoWeaponSmallItemGrid layoutItemByIndex = this.WeaponLayout.GetLayoutItemByIndex(gridIndex);
			if (layoutItemByIndex != null)
			{
				layoutItemByIndex.SetSelected(false, false);
			}
			List<IKurotatoWeaponData> holdWeaponData = KurotatoModel.Instance.GetHoldWeaponData();
			List<KurotatoCardTip> list = new List<KurotatoCardTip>();
			foreach (IKurotatoWeaponData kurotatoWeaponData in holdWeaponData)
			{
				list.Add(new KurotatoCardTip
				{
					CardType = EKurotatoCardType.Weapon,
					SelectId = kurotatoWeaponData.IncId
				});
			}
			List<int> list2 = new List<int>();
			foreach (IKurotatoWeaponData kurotatoWeaponData2 in holdWeaponData)
			{
				list2.Add(kurotatoWeaponData2.SellPrice);
			}
			int index = 0;
			for (int i = 0; i < holdWeaponData.Count; i++)
			{
				if (holdWeaponData[i].IncId == data.IncId)
				{
					index = i;
					break;
				}
			}
			UiManager.Instance.OpenView(EUiViewName.KurotatoPopupItemDetailView, new KurotatoPopupItemDetailOpenParam
			{
				Index = index,
				CardData = list,
				Price = list2
			}, delegate(bool success, int viewId)
			{
				if (success)
				{
					base.AddChildViewById(viewId);
				}
			});
		}

		// Token: 0x0602DA63 RID: 186979 RVA: 0x00CC369C File Offset: 0x00CC189C
		private void OnClickBuildTag(int selectionId, EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			foreach (KurotatoShopSelectCard kurotatoShopSelectCard in this.ItemSelectLayout.GetLayoutItemList())
			{
				if (kurotatoShopSelectCard.GetSelectionId() != selectionId)
				{
					kurotatoShopSelectCard.ClearBuildTagSelection();
				}
			}
		}

		// Token: 0x0602DA64 RID: 186980 RVA: 0x00CC3704 File Offset: 0x00CC1904
		private void OnCardAttrPreview(int selectionId, bool active, IReadOnlyList<IKurotatoAttrPreviewDelta> deltas)
		{
			if (!active)
			{
				this.CommonPopupPanel.ClearAttrPreview();
				return;
			}
			this.CommonPopupPanel.ShowAttrPreview(deltas);
			GenericLayout<KurotatoShopSelectCard, IKurotatoShopSelectCardData> itemSelectLayout = this.ItemSelectLayout;
			foreach (KurotatoShopSelectCard kurotatoShopSelectCard in (((itemSelectLayout != null) ? itemSelectLayout.GetLayoutItemList() : null) ?? new List<KurotatoShopSelectCard>()))
			{
				if (kurotatoShopSelectCard.GetSelectionId() != selectionId)
				{
					kurotatoShopSelectCard.ClearAttrPreviewSelection();
				}
			}
		}

		// Token: 0x040186BB RID: 100027
		private readonly KurotatoCommonPopupPanel CommonPopupPanel = new KurotatoCommonPopupPanel();

		// Token: 0x040186BC RID: 100028
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoShopSelectCard, IKurotatoShopSelectCardData> ItemSelectLayout;

		// Token: 0x040186BD RID: 100029
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoWeaponSmallItemGrid, IKurotatoSmallItemGridData> WeaponLayout;

		// Token: 0x040186BE RID: 100030
		private bool PendingShopRefreshAnim;

		// Token: 0x040186BF RID: 100031
		private IKurotatoComposeHighlight ComposeHighlight = new KurotatoComposeHighlight
		{
			UpgradeSelectionIds = new HashSet<int>(),
			ArrowIncIds = new HashSet<int>(),
			BagPairArrowIncIds = new HashSet<int>()
		};

		// Token: 0x0200A2F8 RID: 41720
		[NullableContext(0)]
		private class EChildComp
		{
			// Token: 0x040328A6 RID: 207014
			public const int CommonPopupPanel = 0;

			// Token: 0x040328A7 RID: 207015
			public const int TipItem = 1;

			// Token: 0x040328A8 RID: 207016
			public const int PanelWave = 2;

			// Token: 0x040328A9 RID: 207017
			public const int TextWaveNum = 3;

			// Token: 0x040328AA RID: 207018
			public const int HorizontalLayoutCard = 4;

			// Token: 0x040328AB RID: 207019
			public const int CardItem = 5;

			// Token: 0x040328AC RID: 207020
			public const int ButtonRefresh = 6;

			// Token: 0x040328AD RID: 207021
			public const int TextRefreshNum = 7;

			// Token: 0x040328AE RID: 207022
			public const int TextRefreshDiscount = 8;

			// Token: 0x040328AF RID: 207023
			public const int ButtonGo = 9;

			// Token: 0x040328B0 RID: 207024
			public const int PanelTipGoNormal = 10;

			// Token: 0x040328B1 RID: 207025
			public const int PanelTipGoBoss = 11;

			// Token: 0x040328B2 RID: 207026
			public const int TextBtnGoTip = 12;

			// Token: 0x040328B3 RID: 207027
			public const int HorizontalLayoutItem = 13;

			// Token: 0x040328B4 RID: 207028
			public const int ItemBase = 14;

			// Token: 0x040328B5 RID: 207029
			public const int PanelTipSpecial = 15;

			// Token: 0x040328B6 RID: 207030
			public const int PanelTipGoElite = 16;
		}
	}
}
