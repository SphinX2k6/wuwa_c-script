using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato.View.Components;
using CSharpScript.Game.Module.Kurotato.View.Overview;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.PopupItemDetail
{
	// Token: 0x02005737 RID: 22327
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoPopupItemDetailView : UiViewBase
	{
		// Token: 0x06038C27 RID: 232487 RVA: 0x00D79610 File Offset: 0x00D77810
		public KurotatoPopupItemDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038C28 RID: 232488 RVA: 0x00D79674 File Offset: 0x00D77874
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickClose));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038C29 RID: 232489 RVA: 0x00D79804 File Offset: 0x00D77A04
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoPopupItemDetailView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoPopupItemDetailView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038C2A RID: 232490 RVA: 0x00D79848 File Offset: 0x00D77A48
		private UniTask CreateCaptionAsync()
		{
			KurotatoPopupItemDetailView.<CreateCaptionAsync>d__14 <CreateCaptionAsync>d__;
			<CreateCaptionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaptionAsync>d__.<>4__this = this;
			<CreateCaptionAsync>d__.<>1__state = -1;
			<CreateCaptionAsync>d__.<>t__builder.Start<KurotatoPopupItemDetailView.<CreateCaptionAsync>d__14>(ref <CreateCaptionAsync>d__);
			return <CreateCaptionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038C2B RID: 232491 RVA: 0x00D7988C File Offset: 0x00D77A8C
		private UniTask CreateWeaponTipAsync()
		{
			KurotatoPopupItemDetailView.<CreateWeaponTipAsync>d__15 <CreateWeaponTipAsync>d__;
			<CreateWeaponTipAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateWeaponTipAsync>d__.<>4__this = this;
			<CreateWeaponTipAsync>d__.<>1__state = -1;
			<CreateWeaponTipAsync>d__.<>t__builder.Start<KurotatoPopupItemDetailView.<CreateWeaponTipAsync>d__15>(ref <CreateWeaponTipAsync>d__);
			return <CreateWeaponTipAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038C2C RID: 232492 RVA: 0x00D798D0 File Offset: 0x00D77AD0
		private UniTask CreateBtnComposeAsync()
		{
			KurotatoPopupItemDetailView.<CreateBtnComposeAsync>d__16 <CreateBtnComposeAsync>d__;
			<CreateBtnComposeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBtnComposeAsync>d__.<>4__this = this;
			<CreateBtnComposeAsync>d__.<>1__state = -1;
			<CreateBtnComposeAsync>d__.<>t__builder.Start<KurotatoPopupItemDetailView.<CreateBtnComposeAsync>d__16>(ref <CreateBtnComposeAsync>d__);
			return <CreateBtnComposeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038C2D RID: 232493 RVA: 0x00D79914 File Offset: 0x00D77B14
		private UniTask CreateBtnSellAsync()
		{
			KurotatoPopupItemDetailView.<CreateBtnSellAsync>d__17 <CreateBtnSellAsync>d__;
			<CreateBtnSellAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBtnSellAsync>d__.<>4__this = this;
			<CreateBtnSellAsync>d__.<>1__state = -1;
			<CreateBtnSellAsync>d__.<>t__builder.Start<KurotatoPopupItemDetailView.<CreateBtnSellAsync>d__17>(ref <CreateBtnSellAsync>d__);
			return <CreateBtnSellAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038C2E RID: 232494 RVA: 0x00D79958 File Offset: 0x00D77B58
		private UniTask CreateCurrencyAsync()
		{
			KurotatoPopupItemDetailView.<CreateCurrencyAsync>d__18 <CreateCurrencyAsync>d__;
			<CreateCurrencyAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCurrencyAsync>d__.<>4__this = this;
			<CreateCurrencyAsync>d__.<>1__state = -1;
			<CreateCurrencyAsync>d__.<>t__builder.Start<KurotatoPopupItemDetailView.<CreateCurrencyAsync>d__18>(ref <CreateCurrencyAsync>d__);
			return <CreateCurrencyAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038C2F RID: 232495 RVA: 0x00D7999B File Offset: 0x00D77B9B
		private void CreateItemLayout()
		{
			this.ItemLayout = new GenericLayout<KurotatoWeaponSmallItemGrid, IKurotatoSmallItemGridData>(base.GetHorizontalLayout(4), delegate()
			{
				KurotatoWeaponSmallItemGrid kurotatoWeaponSmallItemGrid = new KurotatoWeaponSmallItemGrid(true);
				kurotatoWeaponSmallItemGrid.BindCallback(new Action<IKurotatoSmallItemGridData, EToggleState, int>(this.OnClickGrid));
				return kurotatoWeaponSmallItemGrid;
			}, null, false, true);
		}

		// Token: 0x06038C30 RID: 232496 RVA: 0x00D799BE File Offset: 0x00D77BBE
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.KurotatoOnWeaponUpdate, new Action(this.OnUpdateWeapon));
			EventSystem.Instance.Add<int>(EEventName.KurotatoOnWeaponRefined, new Action<int>(this.OnWeaponRefined));
		}

		// Token: 0x06038C31 RID: 232497 RVA: 0x00D799F8 File Offset: 0x00D77BF8
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.KurotatoOnWeaponUpdate, new Action(this.OnUpdateWeapon));
			EventSystem.Instance.Remove<int>(EEventName.KurotatoOnWeaponRefined, new Action<int>(this.OnWeaponRefined));
		}

		// Token: 0x06038C32 RID: 232498 RVA: 0x00D79A34 File Offset: 0x00D77C34
		protected override void OnStart()
		{
			IKurotatoPopupItemDetailOpenParam kurotatoPopupItemDetailOpenParam = (IKurotatoPopupItemDetailOpenParam)this.OpenParam;
			this.CardData = new List<IKurotatoCardTip>(kurotatoPopupItemDetailOpenParam.CardData);
			this.Index = kurotatoPopupItemDetailOpenParam.Index;
			this.Price = (kurotatoPopupItemDetailOpenParam.Price ?? new List<int>());
			this.RefreshItemLayout(null);
			this.RefreshBtn();
		}

		// Token: 0x06038C33 RID: 232499 RVA: 0x00D79A94 File Offset: 0x00D77C94
		private void SyncWeaponDataAndRefresh(int? composeIncId = null)
		{
			List<IKurotatoWeaponData> holdWeaponData = KurotatoModel.Instance.GetHoldWeaponData();
			List<IKurotatoCardTip> list = new List<IKurotatoCardTip>();
			List<int> list2 = new List<int>();
			foreach (IKurotatoWeaponData kurotatoWeaponData in holdWeaponData)
			{
				list.Add(new KurotatoCardTip
				{
					CardType = EKurotatoCardType.Weapon,
					SelectId = kurotatoWeaponData.IncId
				});
				list2.Add(kurotatoWeaponData.SellPrice);
			}
			if (composeIncId == null && this.IsCardDataSame(list) && this.IsPriceSame(list2))
			{
				return;
			}
			this.CardData = list;
			this.Price = list2;
			if (composeIncId != null)
			{
				int num = this.CardData.FindIndex((IKurotatoCardTip card) => card.CardType == EKurotatoCardType.Weapon && card.SelectId == composeIncId.Value);
				if (num >= 0)
				{
					this.Index = num;
				}
			}
			this.Index = Math.Min(this.Index, Math.Max(this.CardData.Count - 1, 0));
			this.RefreshItemLayout(composeIncId);
		}

		// Token: 0x06038C34 RID: 232500 RVA: 0x00D79BBC File Offset: 0x00D77DBC
		private bool IsCardDataSame(List<IKurotatoCardTip> newCardData)
		{
			if (this.CardData.Count != newCardData.Count)
			{
				return false;
			}
			for (int i = 0; i < newCardData.Count; i++)
			{
				if (this.CardData[i].CardType != newCardData[i].CardType || this.CardData[i].SelectId != newCardData[i].SelectId)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06038C35 RID: 232501 RVA: 0x00D79C30 File Offset: 0x00D77E30
		private bool IsPriceSame(List<int> newPrice)
		{
			if (this.Price.Count != newPrice.Count)
			{
				return false;
			}
			for (int i = 0; i < newPrice.Count; i++)
			{
				if (this.Price[i] != newPrice[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06038C36 RID: 232502 RVA: 0x00D79C7C File Offset: 0x00D77E7C
		private void RefreshBtn()
		{
			if (((IKurotatoPopupItemDetailOpenParam)this.OpenParam).IsOutSide.GetValueOrDefault())
			{
				this.BtnComposeItem.GetRootItem().SetUIActive(false);
				this.BtnSellItem.GetRootItem().SetUIActive(false);
				return;
			}
			string str = (this.Index < this.Price.Count) ? this.Price[this.Index].ToString() : "0";
			this.BtnSellItem.SetLocalTextNew("PrefabTextItem_3275109564_Text", new object[]
			{
				"+" + str
			});
			if (this.Index < 0 || this.Index >= this.CardData.Count)
			{
				return;
			}
			IKurotatoCardTip kurotatoCardTip = this.CardData[this.Index];
			if (kurotatoCardTip == null || kurotatoCardTip.CardType != EKurotatoCardType.Weapon)
			{
				return;
			}
			this.BtnComposeItem.SetEnableClick(this.CanCompose(kurotatoCardTip.SelectId));
			List<IKurotatoWeaponData> holdWeaponData = KurotatoModel.Instance.GetHoldWeaponData();
			this.BtnSellItem.SetEnableClick(holdWeaponData.Count > 1);
		}

		// Token: 0x06038C37 RID: 232503 RVA: 0x00D79D90 File Offset: 0x00D77F90
		private bool CanCompose(int weaponIncId)
		{
			IKurotatoWeaponData weaponDataByIncId = KurotatoModel.Instance.GetWeaponDataByIncId(weaponIncId);
			if (weaponDataByIncId == null)
			{
				return false;
			}
			KurotatoConfig instance = KurotatoConfig.Instance;
			KurotatoWeapon? weaponConfigByWeaponId = instance.GetWeaponConfigByWeaponId(weaponDataByIncId.WeaponId);
			if (weaponConfigByWeaponId == null)
			{
				return false;
			}
			int maxQualityByGroupId = instance.GetMaxQualityByGroupId(weaponConfigByWeaponId.Value.GroupId);
			if (weaponConfigByWeaponId.Value.Quality >= maxQualityByGroupId)
			{
				return false;
			}
			foreach (IKurotatoWeaponData kurotatoWeaponData in KurotatoModel.Instance.GetHoldWeaponData())
			{
				if (kurotatoWeaponData.IncId != weaponDataByIncId.IncId)
				{
					KurotatoWeapon? weaponConfigByWeaponId2 = instance.GetWeaponConfigByWeaponId(kurotatoWeaponData.WeaponId);
					if (weaponConfigByWeaponId2 != null && weaponConfigByWeaponId2.Value.GroupId == weaponConfigByWeaponId.Value.GroupId && weaponConfigByWeaponId2.Value.Quality == weaponConfigByWeaponId.Value.Quality)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06038C38 RID: 232504 RVA: 0x00D79EB4 File Offset: 0x00D780B4
		private void RefreshItemLayout(int? composeIncId = null)
		{
			KurotatoModel instance = KurotatoModel.Instance;
			HashSet<int> bagPairArrowIncIds = instance.GetComposeHighlight().BagPairArrowIncIds;
			List<IKurotatoSmallItemGridData> list = new List<IKurotatoSmallItemGridData>();
			foreach (IKurotatoCardTip kurotatoCardTip in this.CardData)
			{
				int id = kurotatoCardTip.IsConfigId.GetValueOrDefault() ? kurotatoCardTip.SelectId : instance.GetWeaponDataByIncId(kurotatoCardTip.SelectId).WeaponId;
				list.Add(new KurotatoSmallItemGridData
				{
					Type = kurotatoCardTip.CardType,
					Id = id,
					IncId = kurotatoCardTip.SelectId,
					Count = 0,
					PlayComposeFx = new bool?(composeIncId != null && kurotatoCardTip.CardType == EKurotatoCardType.Weapon && kurotatoCardTip.SelectId == composeIncId.Value),
					ShowArrow = new bool?(!kurotatoCardTip.IsConfigId.GetValueOrDefault() && kurotatoCardTip.CardType == EKurotatoCardType.Weapon && bagPairArrowIncIds.Contains(kurotatoCardTip.SelectId))
				});
			}
			this.ItemLayout.RefreshByData(list, delegate
			{
				this.RefreshItemTip();
				UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirty();
			}, false);
		}

		// Token: 0x06038C39 RID: 232505 RVA: 0x00D7A004 File Offset: 0x00D78204
		private void RefreshItemTip()
		{
			this.Index = Math.Max(0, Math.Min(this.Index, this.CardData.Count - 1));
			if (this.CardData.Count == 0)
			{
				return;
			}
			KurotatoWeaponSmallItemGrid selectItem = this.SelectItem;
			if (selectItem != null)
			{
				selectItem.SetSelected(false, false);
			}
			this.SelectItem = this.ItemLayout.GetLayoutItemByIndex(this.Index);
			this.ItemTip.Refresh(this.CardData[this.Index].CardType, this.CardData[this.Index].SelectId, false, false, null);
			KurotatoWeaponSmallItemGrid selectItem2 = this.SelectItem;
			if (selectItem2 != null)
			{
				selectItem2.SetSelected(true, false);
			}
			this.RefreshBtn();
		}

		// Token: 0x06038C3A RID: 232506 RVA: 0x00D7A0C8 File Offset: 0x00D782C8
		private void OnClickCompose()
		{
			IKurotatoCardTip kurotatoCardTip = this.CardData[this.Index];
			if (kurotatoCardTip.CardType != EKurotatoCardType.Weapon)
			{
				return;
			}
			IKurotatoWeaponData weaponDataByIncId = KurotatoModel.Instance.GetWeaponDataByIncId(kurotatoCardTip.SelectId);
			if (weaponDataByIncId == null)
			{
				return;
			}
			KurotatoConfig instance = KurotatoConfig.Instance;
			KurotatoWeapon? weaponConfigByWeaponId = instance.GetWeaponConfigByWeaponId(weaponDataByIncId.WeaponId);
			if (weaponConfigByWeaponId == null)
			{
				return;
			}
			int maxQualityByGroupId = instance.GetMaxQualityByGroupId(weaponConfigByWeaponId.Value.GroupId);
			if (weaponConfigByWeaponId.Value.Quality >= maxQualityByGroupId)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Kurotato_Weapon_Level_Max", Array.Empty<object>());
				return;
			}
			List<IKurotatoWeaponData> holdWeaponData = KurotatoModel.Instance.GetHoldWeaponData();
			bool flag = false;
			foreach (IKurotatoWeaponData kurotatoWeaponData in holdWeaponData)
			{
				if (kurotatoWeaponData.IncId != weaponDataByIncId.IncId)
				{
					KurotatoWeapon? weaponConfigByWeaponId2 = instance.GetWeaponConfigByWeaponId(kurotatoWeaponData.WeaponId);
					if (weaponConfigByWeaponId2 != null && weaponConfigByWeaponId2.Value.GroupId == weaponConfigByWeaponId.Value.GroupId && weaponConfigByWeaponId2.Value.Quality == weaponConfigByWeaponId.Value.Quality)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Kurotato_Weapon_Synthesis_Failed", Array.Empty<object>());
				return;
			}
			KurotatoController.Instance.RequestKurotatoRefineWeapon(kurotatoCardTip.SelectId).Forget<bool>();
		}

		// Token: 0x06038C3B RID: 232507 RVA: 0x00D7A24C File Offset: 0x00D7844C
		private void OnClickSell()
		{
			IKurotatoCardTip kurotatoCardTip = this.CardData[this.Index];
			if (KurotatoModel.Instance.GetHoldWeaponData().Count <= 1)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Kurotato_Weapon_Quantity_Min", Array.Empty<object>());
				return;
			}
			if (kurotatoCardTip.CardType == EKurotatoCardType.Weapon)
			{
				if (KurotatoModel.Instance.HideSellWeaponConfirmBox)
				{
					this.DoSellWeapon(kurotatoCardTip.SelectId).Forget();
					return;
				}
				this.OpenSellWeaponConfirm(kurotatoCardTip.SelectId);
			}
		}

		// Token: 0x06038C3C RID: 232508 RVA: 0x00D7A2C4 File Offset: 0x00D784C4
		private void OpenSellWeaponConfirm(int weaponIncId)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.KurotatoSellWeaponConfirm);
			string text = (this.Index < this.Price.Count) ? this.Price[this.Index].ToString() : "0";
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				text ?? ""
			});
			confirmBoxDataNew.HasToggle = true;
			confirmBoxDataNew.ToggleTextKey = "Text_ItemRecycleConfirmToggle_text";
			confirmBoxDataNew.SetToggleFunction(new Action<bool>(this.OnToggleSellWeaponConfirm));
			Action value = delegate()
			{
				KurotatoModel.Instance.HideSellWeaponConfirmBox = false;
			};
			confirmBoxDataNew.FunctionMap[0] = value;
			confirmBoxDataNew.FunctionMap[1] = value;
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				this.DoSellWeapon(weaponIncId).Forget();
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06038C3D RID: 232509 RVA: 0x00D7A3C0 File Offset: 0x00D785C0
		private void OnToggleSellWeaponConfirm(bool isSelectedOn)
		{
			KurotatoModel.Instance.HideSellWeaponConfirmBox = isSelectedOn;
		}

		// Token: 0x06038C3E RID: 232510 RVA: 0x00D7A3CD File Offset: 0x00D785CD
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06038C3F RID: 232511 RVA: 0x00D7A3D8 File Offset: 0x00D785D8
		private UniTask DoSellWeapon(int weaponIncId)
		{
			KurotatoPopupItemDetailView.<DoSellWeapon>d__35 <DoSellWeapon>d__;
			<DoSellWeapon>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DoSellWeapon>d__.weaponIncId = weaponIncId;
			<DoSellWeapon>d__.<>1__state = -1;
			<DoSellWeapon>d__.<>t__builder.Start<KurotatoPopupItemDetailView.<DoSellWeapon>d__35>(ref <DoSellWeapon>d__);
			return <DoSellWeapon>d__.<>t__builder.Task;
		}

		// Token: 0x06038C40 RID: 232512 RVA: 0x00D7A41C File Offset: 0x00D7861C
		private void OnUpdateWeapon()
		{
			this.SyncWeaponDataAndRefresh(null);
		}

		// Token: 0x06038C41 RID: 232513 RVA: 0x00D7A438 File Offset: 0x00D78638
		private void OnWeaponRefined(int newWeaponIncId)
		{
			this.SyncWeaponDataAndRefresh(new int?(newWeaponIncId));
		}

		// Token: 0x06038C42 RID: 232514 RVA: 0x00D7A446 File Offset: 0x00D78646
		private void OnClickGrid(IKurotatoSmallItemGridData data, EToggleState state, int gridIndex)
		{
			if (state == EToggleState.ETT_Checked)
			{
				KurotatoWeaponSmallItemGrid selectItem = this.SelectItem;
				if (selectItem != null)
				{
					selectItem.SetSelected(false, false);
				}
				this.Index = gridIndex;
				this.RefreshItemTip();
			}
		}

		// Token: 0x0401DC72 RID: 121970
		private readonly PopupCaptionItem CaptionItem = new PopupCaptionItem(null);

		// Token: 0x0401DC73 RID: 121971
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoWeaponSmallItemGrid, IKurotatoSmallItemGridData> ItemLayout;

		// Token: 0x0401DC74 RID: 121972
		[Nullable(2)]
		private KurotatoWeaponSmallItemGrid SelectItem;

		// Token: 0x0401DC75 RID: 121973
		private readonly KurotatoItemInfoTipPanel ItemTip = new KurotatoItemInfoTipPanel();

		// Token: 0x0401DC76 RID: 121974
		private readonly ButtonItem BtnComposeItem = new ButtonItem(null);

		// Token: 0x0401DC77 RID: 121975
		private readonly ButtonItem BtnSellItem = new ButtonItem(null);

		// Token: 0x0401DC78 RID: 121976
		private readonly KurotatoCurrencyItem CurrencyItem = new KurotatoCurrencyItem();

		// Token: 0x0401DC79 RID: 121977
		private List<IKurotatoCardTip> CardData = new List<IKurotatoCardTip>();

		// Token: 0x0401DC7A RID: 121978
		private List<int> Price = new List<int>();

		// Token: 0x0401DC7B RID: 121979
		private int Index;

		// Token: 0x0200B90E RID: 47374
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04037F8B RID: 229259
			Caption,
			// Token: 0x04037F8C RID: 229260
			PanelCost,
			// Token: 0x04037F8D RID: 229261
			BtnBack,
			// Token: 0x04037F8E RID: 229262
			TipItem,
			// Token: 0x04037F8F RID: 229263
			HorizontalLayout,
			// Token: 0x04037F90 RID: 229264
			WeaponItem,
			// Token: 0x04037F91 RID: 229265
			BtnCompose,
			// Token: 0x04037F92 RID: 229266
			BtnSell,
			// Token: 0x04037F93 RID: 229267
			BtnClose
		}
	}
}
