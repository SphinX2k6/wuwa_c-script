using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x0200571E RID: 22302
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoShopMainView : UiViewBase
	{
		// Token: 0x06038B2F RID: 232239 RVA: 0x00D73A17 File Offset: 0x00D71C17
		public KurotatoShopMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038B30 RID: 232240 RVA: 0x00D73A58 File Offset: 0x00D71C58
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

		// Token: 0x06038B31 RID: 232241 RVA: 0x00D73D1C File Offset: 0x00D71F1C
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoShopMainView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoShopMainView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038B32 RID: 232242 RVA: 0x00D73D60 File Offset: 0x00D71F60
		private UniTask CreatePopupPanel()
		{
			KurotatoShopMainView.<CreatePopupPanel>d__9 <CreatePopupPanel>d__;
			<CreatePopupPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreatePopupPanel>d__.<>4__this = this;
			<CreatePopupPanel>d__.<>1__state = -1;
			<CreatePopupPanel>d__.<>t__builder.Start<KurotatoShopMainView.<CreatePopupPanel>d__9>(ref <CreatePopupPanel>d__);
			return <CreatePopupPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06038B33 RID: 232243 RVA: 0x00D73DA3 File Offset: 0x00D71FA3
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

		// Token: 0x06038B34 RID: 232244 RVA: 0x00D73DC6 File Offset: 0x00D71FC6
		private void CreateItemLayout()
		{
			this.WeaponLayout = new GenericLayout<KurotatoWeaponSmallItemGrid, IKurotatoSmallItemGridData>(base.GetHorizontalLayout(13), delegate()
			{
				KurotatoWeaponSmallItemGrid kurotatoWeaponSmallItemGrid = new KurotatoWeaponSmallItemGrid(true);
				kurotatoWeaponSmallItemGrid.BindCallback(new Action<IKurotatoSmallItemGridData, EToggleState, int>(this.OnClickWeaponGrid));
				return kurotatoWeaponSmallItemGrid;
			}, null, false, true);
		}

		// Token: 0x06038B35 RID: 232245 RVA: 0x00D73DEC File Offset: 0x00D71FEC
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.KurotatoOnShopDataChanged, new Action(this.OnUpgradeRewardChanged));
			EventSystem.Instance.Add(EEventName.KurotatoOnWeaponUpdate, new Action(this.OnUpdateWeapon));
			EventSystem.Instance.Add<int>(EEventName.KurotatoOnWeaponRefined, new Action<int>(this.OnWeaponRefined));
			EventSystem.Instance.Add<int, bool>(EEventName.KurotatoOnItemUpdate, new Action<int, bool>(this.OnItemUpdate));
			EventSystem.Instance.Add(EEventName.KurotatoOnNextWaveTypeUpdate, new Action(this.OnNextWaveTypeUpdate));
			KurotatoModel.Instance.BattleData.BehaviorDelegate.AddTreeVarUpdateDelegate(EKurotatoSystemVarType.Gold.ToEnumString(), new TTreeVarUpdateDelegate(this.OnCurrencyUpdate));
		}

		// Token: 0x06038B36 RID: 232246 RVA: 0x00D73EAC File Offset: 0x00D720AC
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.KurotatoOnShopDataChanged, new Action(this.OnUpgradeRewardChanged));
			EventSystem.Instance.Remove(EEventName.KurotatoOnWeaponUpdate, new Action(this.OnUpdateWeapon));
			EventSystem.Instance.Remove<int>(EEventName.KurotatoOnWeaponRefined, new Action<int>(this.OnWeaponRefined));
			EventSystem.Instance.Remove<int, bool>(EEventName.KurotatoOnItemUpdate, new Action<int, bool>(this.OnItemUpdate));
			EventSystem.Instance.Remove(EEventName.KurotatoOnNextWaveTypeUpdate, new Action(this.OnNextWaveTypeUpdate));
			KurotatoModel.Instance.BattleData.BehaviorDelegate.RemoveTreeVarUpdateDelegate(EKurotatoSystemVarType.Gold.ToEnumString(), new TTreeVarUpdateDelegate(this.OnCurrencyUpdate));
		}

		// Token: 0x06038B37 RID: 232247 RVA: 0x00D73F6B File Offset: 0x00D7216B
		protected override void OnStart()
		{
			this.PendingShopRefreshAnim = true;
			this.RefreshWave();
			this.CommonPopupPanel.SetTitleLocalText("Kurotato_Shop_Title");
		}

		// Token: 0x06038B38 RID: 232248 RVA: 0x00D73F8A File Offset: 0x00D7218A
		protected override void OnBeforeShow()
		{
			this.CommonPopupPanel.HideAttrChangeFx();
			this.OnUpgradeRewardChanged();
		}

		// Token: 0x06038B39 RID: 232249 RVA: 0x00D73FA0 File Offset: 0x00D721A0
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

		// Token: 0x06038B3A RID: 232250 RVA: 0x00D7415C File Offset: 0x00D7235C
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

		// Token: 0x06038B3B RID: 232251 RVA: 0x00D74220 File Offset: 0x00D72420
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

		// Token: 0x06038B3C RID: 232252 RVA: 0x00D74298 File Offset: 0x00D72498
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

		// Token: 0x06038B3D RID: 232253 RVA: 0x00D7431C File Offset: 0x00D7251C
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

		// Token: 0x06038B3E RID: 232254 RVA: 0x00D74420 File Offset: 0x00D72620
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

		// Token: 0x06038B3F RID: 232255 RVA: 0x00D744D0 File Offset: 0x00D726D0
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

		// Token: 0x06038B40 RID: 232256 RVA: 0x00D74694 File Offset: 0x00D72894
		private void OnClickSelectConfirm(int selectionId)
		{
			List<KurotatoShopProductPbData> shopData = KurotatoModel.Instance.GetShopData();
			if (shopData.Any((KurotatoShopProductPbData item) => item.SelectionId == selectionId && item.IsBought))
			{
				return;
			}
			KurotatoShopProductPbData kurotatoShopProductPbData = shopData.FirstOrDefault((KurotatoShopProductPbData item) => item.SelectionId == selectionId);
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

		// Token: 0x06038B41 RID: 232257 RVA: 0x00D747C4 File Offset: 0x00D729C4
		private bool IsShopItemQuantityMax(int itemId)
		{
			KurotatoItem? itemConfigByItemId = KurotatoConfig.Instance.GetItemConfigByItemId(itemId);
			return itemConfigByItemId != null && KurotatoModel.Instance.GetHoldItemCount(itemId) >= itemConfigByItemId.Value.MaxStackCount;
		}

		// Token: 0x06038B42 RID: 232258 RVA: 0x00D74808 File Offset: 0x00D72A08
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

		// Token: 0x06038B43 RID: 232259 RVA: 0x00D74904 File Offset: 0x00D72B04
		private void OnUpgradeRewardChanged()
		{
			this.RefreshSelectLayout();
			this.RefreshRefreshInfo();
			this.RefreshWaveTip();
		}

		// Token: 0x06038B44 RID: 232260 RVA: 0x00D74918 File Offset: 0x00D72B18
		private void OnUpdateWeapon()
		{
			this.RefreshWeaponLayout(null);
			this.RefreshSelectLayout();
			this.RefreshCardsComposeState();
			this.RefreshCardsBuildTagLevel();
		}

		// Token: 0x06038B45 RID: 232261 RVA: 0x00D74946 File Offset: 0x00D72B46
		private void OnWeaponRefined(int newWeaponIncId)
		{
			this.RefreshWeaponLayout(new int?(newWeaponIncId));
			this.RefreshCardsComposeState();
		}

		// Token: 0x06038B46 RID: 232262 RVA: 0x00D7495C File Offset: 0x00D72B5C
		private void OnItemUpdate(int itemId, bool bIsAdd)
		{
			this.RefreshWaveTip();
			GenericLayout<KurotatoShopSelectCard, IKurotatoShopSelectCardData> itemSelectLayout = this.ItemSelectLayout;
			foreach (KurotatoShopSelectCard kurotatoShopSelectCard in (((itemSelectLayout != null) ? itemSelectLayout.GetLayoutItemList() : null) ?? new List<KurotatoShopSelectCard>()))
			{
				kurotatoShopSelectCard.RefreshHoldNum();
			}
		}

		// Token: 0x06038B47 RID: 232263 RVA: 0x00D749C8 File Offset: 0x00D72BC8
		private void OnNextWaveTypeUpdate()
		{
			this.RefreshWaveTip();
		}

		// Token: 0x06038B48 RID: 232264 RVA: 0x00D749D0 File Offset: 0x00D72BD0
		private void RefreshCardsComposeState()
		{
			HashSet<int> upgradeSelectionIds = this.ComposeHighlight.UpgradeSelectionIds;
			GenericLayout<KurotatoShopSelectCard, IKurotatoShopSelectCardData> itemSelectLayout = this.ItemSelectLayout;
			foreach (KurotatoShopSelectCard kurotatoShopSelectCard in (((itemSelectLayout != null) ? itemSelectLayout.GetLayoutItemList() : null) ?? new List<KurotatoShopSelectCard>()))
			{
				kurotatoShopSelectCard.SetComposeUpgradeVisible(upgradeSelectionIds.Contains(kurotatoShopSelectCard.GetSelectionId()));
			}
		}

		// Token: 0x06038B49 RID: 232265 RVA: 0x00D74A50 File Offset: 0x00D72C50
		private void RefreshCardsBuildTagLevel()
		{
			GenericLayout<KurotatoShopSelectCard, IKurotatoShopSelectCardData> itemSelectLayout = this.ItemSelectLayout;
			foreach (KurotatoShopSelectCard kurotatoShopSelectCard in (((itemSelectLayout != null) ? itemSelectLayout.GetLayoutItemList() : null) ?? new List<KurotatoShopSelectCard>()))
			{
				kurotatoShopSelectCard.RefreshBuildTagLevel();
			}
		}

		// Token: 0x06038B4A RID: 232266 RVA: 0x00D74AB8 File Offset: 0x00D72CB8
		private void OnCurrencyUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
		{
			GenericLayout<KurotatoShopSelectCard, IKurotatoShopSelectCardData> itemSelectLayout = this.ItemSelectLayout;
			foreach (KurotatoShopSelectCard kurotatoShopSelectCard in (((itemSelectLayout != null) ? itemSelectLayout.GetLayoutItemList() : null) ?? new List<KurotatoShopSelectCard>()))
			{
				kurotatoShopSelectCard.RefreshCurrencyState();
			}
			this.RefreshRefreshInfo();
		}

		// Token: 0x06038B4B RID: 232267 RVA: 0x00D74B24 File Offset: 0x00D72D24
		private void OnClickRefresh()
		{
			KurotatoModel instance = KurotatoModel.Instance;
			List<KurotatoShopProductPbData> shopData = instance.GetShopData();
			if (shopData.Count > 0)
			{
				if (shopData.All((KurotatoShopProductPbData item) => !item.IsBought && item.IsLocked))
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_KurotatoShopReflashFail_Text", Array.Empty<object>());
					return;
				}
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

		// Token: 0x06038B4C RID: 232268 RVA: 0x00D74BD4 File Offset: 0x00D72DD4
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

		// Token: 0x06038B4D RID: 232269 RVA: 0x00D74D04 File Offset: 0x00D72F04
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

		// Token: 0x06038B4E RID: 232270 RVA: 0x00D74D80 File Offset: 0x00D72F80
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

		// Token: 0x06038B4F RID: 232271 RVA: 0x00D74DFC File Offset: 0x00D72FFC
		private bool HasAvailableShopItem()
		{
			KurotatoModel instance = KurotatoModel.Instance;
			int currencyCount = instance.BattleData.GetCurrencyCount();
			return instance.GetShopData().Any((KurotatoShopProductPbData item) => !item.IsBought && currencyCount >= item.Cost);
		}

		// Token: 0x06038B50 RID: 232272 RVA: 0x00D74E40 File Offset: 0x00D73040
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

		// Token: 0x06038B51 RID: 232273 RVA: 0x00D74EE7 File Offset: 0x00D730E7
		private void OnClickGo()
		{
			if (KurotatoModel.Instance.HideShopNotBuyConfirmBox || !this.HasAvailableShopItem())
			{
				KurotatoController.Instance.RequestKurotatoEndShopStep(false).Forget<bool>();
				return;
			}
			this.OpenNotBuyConfirm(false);
		}

		// Token: 0x06038B52 RID: 232274 RVA: 0x00D74F15 File Offset: 0x00D73115
		private void OnToggleNotBuyConfirm(bool isSelectedOn)
		{
			KurotatoModel.Instance.HideShopNotBuyConfirmBox = isSelectedOn;
		}

		// Token: 0x06038B53 RID: 232275 RVA: 0x00D74F24 File Offset: 0x00D73124
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

		// Token: 0x06038B54 RID: 232276 RVA: 0x00D75068 File Offset: 0x00D73268
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

		// Token: 0x06038B55 RID: 232277 RVA: 0x00D750D0 File Offset: 0x00D732D0
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

		// Token: 0x0401DC25 RID: 121893
		private readonly KurotatoCommonPopupPanel CommonPopupPanel = new KurotatoCommonPopupPanel();

		// Token: 0x0401DC26 RID: 121894
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoShopSelectCard, IKurotatoShopSelectCardData> ItemSelectLayout;

		// Token: 0x0401DC27 RID: 121895
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoWeaponSmallItemGrid, IKurotatoSmallItemGridData> WeaponLayout;

		// Token: 0x0401DC28 RID: 121896
		private bool PendingShopRefreshAnim;

		// Token: 0x0401DC29 RID: 121897
		private IKurotatoComposeHighlight ComposeHighlight = new KurotatoComposeHighlight
		{
			UpgradeSelectionIds = new HashSet<int>(),
			ArrowIncIds = new HashSet<int>(),
			BagPairArrowIncIds = new HashSet<int>()
		};

		// Token: 0x0200B8D4 RID: 47316
		[NullableContext(0)]
		private class EChildComp
		{
			// Token: 0x04037E91 RID: 229009
			public const int CommonPopupPanel = 0;

			// Token: 0x04037E92 RID: 229010
			public const int TipItem = 1;

			// Token: 0x04037E93 RID: 229011
			public const int PanelWave = 2;

			// Token: 0x04037E94 RID: 229012
			public const int TextWaveNum = 3;

			// Token: 0x04037E95 RID: 229013
			public const int HorizontalLayoutCard = 4;

			// Token: 0x04037E96 RID: 229014
			public const int CardItem = 5;

			// Token: 0x04037E97 RID: 229015
			public const int ButtonRefresh = 6;

			// Token: 0x04037E98 RID: 229016
			public const int TextRefreshNum = 7;

			// Token: 0x04037E99 RID: 229017
			public const int TextRefreshDiscount = 8;

			// Token: 0x04037E9A RID: 229018
			public const int ButtonGo = 9;

			// Token: 0x04037E9B RID: 229019
			public const int PanelTipGoNormal = 10;

			// Token: 0x04037E9C RID: 229020
			public const int PanelTipGoBoss = 11;

			// Token: 0x04037E9D RID: 229021
			public const int TextBtnGoTip = 12;

			// Token: 0x04037E9E RID: 229022
			public const int HorizontalLayoutItem = 13;

			// Token: 0x04037E9F RID: 229023
			public const int ItemBase = 14;

			// Token: 0x04037EA0 RID: 229024
			public const int PanelTipSpecial = 15;

			// Token: 0x04037EA1 RID: 229025
			public const int PanelTipGoElite = 16;
		}
	}
}
