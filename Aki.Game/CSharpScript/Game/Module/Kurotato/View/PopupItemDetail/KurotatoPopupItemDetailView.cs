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
	// Token: 0x0200470E RID: 18190
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoPopupItemDetailView : UiViewBase
	{
		// Token: 0x0602DB37 RID: 187191 RVA: 0x00CC7CC0 File Offset: 0x00CC5EC0
		public KurotatoPopupItemDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602DB38 RID: 187192 RVA: 0x00CC7D24 File Offset: 0x00CC5F24
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

		// Token: 0x0602DB39 RID: 187193 RVA: 0x00CC7EB4 File Offset: 0x00CC60B4
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoPopupItemDetailView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoPopupItemDetailView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DB3A RID: 187194 RVA: 0x00CC7EF8 File Offset: 0x00CC60F8
		private UniTask CreateCaptionAsync()
		{
			KurotatoPopupItemDetailView.<CreateCaptionAsync>d__14 <CreateCaptionAsync>d__;
			<CreateCaptionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaptionAsync>d__.<>4__this = this;
			<CreateCaptionAsync>d__.<>1__state = -1;
			<CreateCaptionAsync>d__.<>t__builder.Start<KurotatoPopupItemDetailView.<CreateCaptionAsync>d__14>(ref <CreateCaptionAsync>d__);
			return <CreateCaptionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DB3B RID: 187195 RVA: 0x00CC7F3C File Offset: 0x00CC613C
		private UniTask CreateWeaponTipAsync()
		{
			KurotatoPopupItemDetailView.<CreateWeaponTipAsync>d__15 <CreateWeaponTipAsync>d__;
			<CreateWeaponTipAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateWeaponTipAsync>d__.<>4__this = this;
			<CreateWeaponTipAsync>d__.<>1__state = -1;
			<CreateWeaponTipAsync>d__.<>t__builder.Start<KurotatoPopupItemDetailView.<CreateWeaponTipAsync>d__15>(ref <CreateWeaponTipAsync>d__);
			return <CreateWeaponTipAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DB3C RID: 187196 RVA: 0x00CC7F80 File Offset: 0x00CC6180
		private UniTask CreateBtnComposeAsync()
		{
			KurotatoPopupItemDetailView.<CreateBtnComposeAsync>d__16 <CreateBtnComposeAsync>d__;
			<CreateBtnComposeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBtnComposeAsync>d__.<>4__this = this;
			<CreateBtnComposeAsync>d__.<>1__state = -1;
			<CreateBtnComposeAsync>d__.<>t__builder.Start<KurotatoPopupItemDetailView.<CreateBtnComposeAsync>d__16>(ref <CreateBtnComposeAsync>d__);
			return <CreateBtnComposeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DB3D RID: 187197 RVA: 0x00CC7FC4 File Offset: 0x00CC61C4
		private UniTask CreateBtnSellAsync()
		{
			KurotatoPopupItemDetailView.<CreateBtnSellAsync>d__17 <CreateBtnSellAsync>d__;
			<CreateBtnSellAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBtnSellAsync>d__.<>4__this = this;
			<CreateBtnSellAsync>d__.<>1__state = -1;
			<CreateBtnSellAsync>d__.<>t__builder.Start<KurotatoPopupItemDetailView.<CreateBtnSellAsync>d__17>(ref <CreateBtnSellAsync>d__);
			return <CreateBtnSellAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DB3E RID: 187198 RVA: 0x00CC8008 File Offset: 0x00CC6208
		private UniTask CreateCurrencyAsync()
		{
			KurotatoPopupItemDetailView.<CreateCurrencyAsync>d__18 <CreateCurrencyAsync>d__;
			<CreateCurrencyAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCurrencyAsync>d__.<>4__this = this;
			<CreateCurrencyAsync>d__.<>1__state = -1;
			<CreateCurrencyAsync>d__.<>t__builder.Start<KurotatoPopupItemDetailView.<CreateCurrencyAsync>d__18>(ref <CreateCurrencyAsync>d__);
			return <CreateCurrencyAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DB3F RID: 187199 RVA: 0x00CC804B File Offset: 0x00CC624B
		private void CreateItemLayout()
		{
			this.ItemLayout = new GenericLayout<KurotatoWeaponSmallItemGrid, IKurotatoSmallItemGridData>(base.GetHorizontalLayout(4), delegate()
			{
				KurotatoWeaponSmallItemGrid kurotatoWeaponSmallItemGrid = new KurotatoWeaponSmallItemGrid(true);
				kurotatoWeaponSmallItemGrid.BindCallback(new Action<IKurotatoSmallItemGridData, EToggleState, int>(this.OnClickGrid));
				return kurotatoWeaponSmallItemGrid;
			}, null, false, true);
		}

		// Token: 0x0602DB40 RID: 187200 RVA: 0x00CC806E File Offset: 0x00CC626E
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.KurotatoOnWeaponUpdate, new Action(this.OnUpdateWeapon));
			EventSystem.Instance.Add<int>(EEventName.KurotatoOnWeaponRefined, new Action<int>(this.OnWeaponRefined));
		}

		// Token: 0x0602DB41 RID: 187201 RVA: 0x00CC80A8 File Offset: 0x00CC62A8
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.KurotatoOnWeaponUpdate, new Action(this.OnUpdateWeapon));
			EventSystem.Instance.Remove<int>(EEventName.KurotatoOnWeaponRefined, new Action<int>(this.OnWeaponRefined));
		}

		// Token: 0x0602DB42 RID: 187202 RVA: 0x00CC80E4 File Offset: 0x00CC62E4
		protected override void OnStart()
		{
			IKurotatoPopupItemDetailOpenParam kurotatoPopupItemDetailOpenParam = (IKurotatoPopupItemDetailOpenParam)this.OpenParam;
			this.CardData = new List<IKurotatoCardTip>(kurotatoPopupItemDetailOpenParam.CardData);
			this.Index = kurotatoPopupItemDetailOpenParam.Index;
			this.Price = (kurotatoPopupItemDetailOpenParam.Price ?? new List<int>());
			this.RefreshItemLayout(null);
			this.RefreshBtn();
		}

		// Token: 0x0602DB43 RID: 187203 RVA: 0x00CC8144 File Offset: 0x00CC6344
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

		// Token: 0x0602DB44 RID: 187204 RVA: 0x00CC826C File Offset: 0x00CC646C
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

		// Token: 0x0602DB45 RID: 187205 RVA: 0x00CC82E0 File Offset: 0x00CC64E0
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

		// Token: 0x0602DB46 RID: 187206 RVA: 0x00CC832C File Offset: 0x00CC652C
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

		// Token: 0x0602DB47 RID: 187207 RVA: 0x00CC8440 File Offset: 0x00CC6640
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

		// Token: 0x0602DB48 RID: 187208 RVA: 0x00CC8564 File Offset: 0x00CC6764
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

		// Token: 0x0602DB49 RID: 187209 RVA: 0x00CC86B4 File Offset: 0x00CC68B4
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

		// Token: 0x0602DB4A RID: 187210 RVA: 0x00CC8778 File Offset: 0x00CC6978
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

		// Token: 0x0602DB4B RID: 187211 RVA: 0x00CC88FC File Offset: 0x00CC6AFC
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

		// Token: 0x0602DB4C RID: 187212 RVA: 0x00CC8974 File Offset: 0x00CC6B74
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

		// Token: 0x0602DB4D RID: 187213 RVA: 0x00CC8A70 File Offset: 0x00CC6C70
		private void OnToggleSellWeaponConfirm(bool isSelectedOn)
		{
			KurotatoModel.Instance.HideSellWeaponConfirmBox = isSelectedOn;
		}

		// Token: 0x0602DB4E RID: 187214 RVA: 0x00CC8A7D File Offset: 0x00CC6C7D
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602DB4F RID: 187215 RVA: 0x00CC8A88 File Offset: 0x00CC6C88
		private UniTask DoSellWeapon(int weaponIncId)
		{
			KurotatoPopupItemDetailView.<DoSellWeapon>d__35 <DoSellWeapon>d__;
			<DoSellWeapon>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DoSellWeapon>d__.weaponIncId = weaponIncId;
			<DoSellWeapon>d__.<>1__state = -1;
			<DoSellWeapon>d__.<>t__builder.Start<KurotatoPopupItemDetailView.<DoSellWeapon>d__35>(ref <DoSellWeapon>d__);
			return <DoSellWeapon>d__.<>t__builder.Task;
		}

		// Token: 0x0602DB50 RID: 187216 RVA: 0x00CC8ACC File Offset: 0x00CC6CCC
		private void OnUpdateWeapon()
		{
			this.SyncWeaponDataAndRefresh(null);
		}

		// Token: 0x0602DB51 RID: 187217 RVA: 0x00CC8AE8 File Offset: 0x00CC6CE8
		private void OnWeaponRefined(int newWeaponIncId)
		{
			this.SyncWeaponDataAndRefresh(new int?(newWeaponIncId));
		}

		// Token: 0x0602DB52 RID: 187218 RVA: 0x00CC8AF6 File Offset: 0x00CC6CF6
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

		// Token: 0x04018708 RID: 100104
		private readonly PopupCaptionItem CaptionItem = new PopupCaptionItem(null);

		// Token: 0x04018709 RID: 100105
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoWeaponSmallItemGrid, IKurotatoSmallItemGridData> ItemLayout;

		// Token: 0x0401870A RID: 100106
		[Nullable(2)]
		private KurotatoWeaponSmallItemGrid SelectItem;

		// Token: 0x0401870B RID: 100107
		private readonly KurotatoItemInfoTipPanel ItemTip = new KurotatoItemInfoTipPanel();

		// Token: 0x0401870C RID: 100108
		private readonly ButtonItem BtnComposeItem = new ButtonItem(null);

		// Token: 0x0401870D RID: 100109
		private readonly ButtonItem BtnSellItem = new ButtonItem(null);

		// Token: 0x0401870E RID: 100110
		private readonly KurotatoCurrencyItem CurrencyItem = new KurotatoCurrencyItem();

		// Token: 0x0401870F RID: 100111
		private List<IKurotatoCardTip> CardData = new List<IKurotatoCardTip>();

		// Token: 0x04018710 RID: 100112
		private List<int> Price = new List<int>();

		// Token: 0x04018711 RID: 100113
		private int Index;

		// Token: 0x0200A32F RID: 41775
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403299B RID: 207259
			Caption,
			// Token: 0x0403299C RID: 207260
			PanelCost,
			// Token: 0x0403299D RID: 207261
			BtnBack,
			// Token: 0x0403299E RID: 207262
			TipItem,
			// Token: 0x0403299F RID: 207263
			HorizontalLayout,
			// Token: 0x040329A0 RID: 207264
			WeaponItem,
			// Token: 0x040329A1 RID: 207265
			BtnCompose,
			// Token: 0x040329A2 RID: 207266
			BtnSell,
			// Token: 0x040329A3 RID: 207267
			BtnClose
		}
	}
}
