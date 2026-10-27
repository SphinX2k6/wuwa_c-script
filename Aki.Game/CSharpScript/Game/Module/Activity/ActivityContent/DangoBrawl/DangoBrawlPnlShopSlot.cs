using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067F6 RID: 26614
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlPnlShopSlot : UiPanelBase
	{
		// Token: 0x1700971A RID: 38682
		// (get) Token: 0x060425A6 RID: 271782 RVA: 0x0101C857 File Offset: 0x0101AA57
		public int MySlotIndex
		{
			get
			{
				return this.SlotIndex;
			}
		}

		// Token: 0x060425A7 RID: 271783 RVA: 0x0101C860 File Offset: 0x0101AA60
		public int GetConfigId()
		{
			DangoBrawlShopSlotInfo slot = this.GetSlot();
			int? num;
			if (slot == null)
			{
				num = null;
			}
			else
			{
				DangoBrawlBaseItemInfo item = slot.Item;
				num = ((item != null) ? new int?(item.ConfigId) : null);
			}
			int? num2 = num;
			return num2.GetValueOrDefault();
		}

		// Token: 0x060425A8 RID: 271784 RVA: 0x0101C8A8 File Offset: 0x0101AAA8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickLock));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060425A9 RID: 271785 RVA: 0x0101CAE0 File Offset: 0x0101ACE0
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlPnlShopSlot.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlPnlShopSlot.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060425AA RID: 271786 RVA: 0x0101CB23 File Offset: 0x0101AD23
		protected override void OnBeforeDestroy()
		{
			this.UnBindEvents();
			this.ClearSequencePlayer();
		}

		// Token: 0x060425AB RID: 271787 RVA: 0x0101CB34 File Offset: 0x0101AD34
		private void BineEvents()
		{
			EventSystem.Instance.Add(EEventName.OnDangoBrawlLayerModeChanged, new Action<bool>(this.OnDangoBrawlLayerModeChanged));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlCoinUpdated, new Action(this.OnDangoBrawlCoinUpdated));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlItemGiveCoinNotify, new Action<DangoBrawlItemGiveCoinNotify>(this.OnDangoBrawlItemGiveCoinNotify));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlShopRefreshed, new Action(this.OnDangoBrawlShopRefreshed));
		}

		// Token: 0x060425AC RID: 271788 RVA: 0x0101CBB4 File Offset: 0x0101ADB4
		private void UnBindEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlLayerModeChanged, new Action<bool>(this.OnDangoBrawlLayerModeChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlCoinUpdated, new Action(this.OnDangoBrawlCoinUpdated));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlItemGiveCoinNotify, new Action<DangoBrawlItemGiveCoinNotify>(this.OnDangoBrawlItemGiveCoinNotify));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopRefreshed, new Action(this.OnDangoBrawlShopRefreshed));
		}

		// Token: 0x060425AD RID: 271789 RVA: 0x0101CC34 File Offset: 0x0101AE34
		public void BindShopSlot(int slotIndex, ActivityDangoBrawlData actData)
		{
			this.ActData = actData;
			this.SlotIndex = slotIndex;
			DangoBrawlShopSlotInfo slot = this.GetSlot();
			int? num;
			if (slot == null)
			{
				num = null;
			}
			else
			{
				DangoBrawlBaseItemInfo item = slot.Item;
				num = ((item != null) ? new int?(item.Uid) : null);
			}
			int? num2 = num;
			this.SlotUid = num2.GetValueOrDefault(-1);
			this.RefreshView();
		}

		// Token: 0x060425AE RID: 271790 RVA: 0x0101CC98 File Offset: 0x0101AE98
		private void InitSequencePlayer()
		{
			this.ClearSequencePlayer();
			UUIItem rootItem = base.GetRootItem();
			if (rootItem == null)
			{
				return;
			}
			this.SequencePlayer = new UiSequencePlayer(rootItem);
			this.SequencePlayer.BindOnStartSequenceEvent(new Action<string>(this.OnStartSequenceEvent));
			this.SequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnEndSequenceEvent));
		}

		// Token: 0x060425AF RID: 271791 RVA: 0x0101CCF0 File Offset: 0x0101AEF0
		private void ClearSequencePlayer()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x060425B0 RID: 271792 RVA: 0x0101CD0A File Offset: 0x0101AF0A
		public void SetSelected(bool selected)
		{
			DangoBrawlPnlShopSlotIcon iconPanel = this.IconPanel;
			if (iconPanel == null)
			{
				return;
			}
			iconPanel.SetSelected(selected);
		}

		// Token: 0x060425B1 RID: 271793 RVA: 0x0101CD1D File Offset: 0x0101AF1D
		private void OnDangoBrawlLayerModeChanged(bool isLayerMode)
		{
			DangoBrawlPnlShopSlotIcon iconPanel = this.IconPanel;
			if (iconPanel == null)
			{
				return;
			}
			iconPanel.ApplyLayerMode(isLayerMode);
		}

		// Token: 0x060425B2 RID: 271794 RVA: 0x0101CD30 File Offset: 0x0101AF30
		[NullableContext(2)]
		private DangoBrawlShopSlotInfo GetSlot()
		{
			RepeatedField<DangoBrawlShopSlotInfo> shopSlots = this.ActData.ShopSlots;
			if (this.SlotIndex < 0 || this.SlotIndex >= shopSlots.Count)
			{
				return null;
			}
			return shopSlots[this.SlotIndex];
		}

		// Token: 0x060425B3 RID: 271795 RVA: 0x0101CD70 File Offset: 0x0101AF70
		private UniTask CreateIconPanel()
		{
			DangoBrawlPnlShopSlot.<CreateIconPanel>d__23 <CreateIconPanel>d__;
			<CreateIconPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateIconPanel>d__.<>4__this = this;
			<CreateIconPanel>d__.<>1__state = -1;
			<CreateIconPanel>d__.<>t__builder.Start<DangoBrawlPnlShopSlot.<CreateIconPanel>d__23>(ref <CreateIconPanel>d__);
			return <CreateIconPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060425B4 RID: 271796 RVA: 0x0101CDB4 File Offset: 0x0101AFB4
		public void TryToggleLock()
		{
			DangoBrawlShopSlotInfo slot = this.GetSlot();
			if (((slot != null) ? slot.Item : null) == null)
			{
				return;
			}
			this.OnToggleLockAsync(!slot.Locked).Forget();
		}

		// Token: 0x060425B5 RID: 271797 RVA: 0x0101CDEC File Offset: 0x0101AFEC
		private UniTask CreateWeightPanel()
		{
			DangoBrawlPnlShopSlot.<CreateWeightPanel>d__25 <CreateWeightPanel>d__;
			<CreateWeightPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateWeightPanel>d__.<>4__this = this;
			<CreateWeightPanel>d__.<>1__state = -1;
			<CreateWeightPanel>d__.<>t__builder.Start<DangoBrawlPnlShopSlot.<CreateWeightPanel>d__25>(ref <CreateWeightPanel>d__);
			return <CreateWeightPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060425B6 RID: 271798 RVA: 0x0101CE30 File Offset: 0x0101B030
		private void RefreshView()
		{
			DangoBrawlShopSlotInfo slot = this.GetSlot();
			DangoBrawlBaseItemInfo dangoBrawlBaseItemInfo = (slot != null) ? slot.Item : null;
			bool flag = dangoBrawlBaseItemInfo != null && dangoBrawlBaseItemInfo.ConfigId > 0;
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			if (!flag || slot == null)
			{
				DangoBrawlPnlShopSlotIcon iconPanel = this.IconPanel;
				if (iconPanel == null)
				{
					return;
				}
				iconPanel.OnSell();
				return;
			}
			else
			{
				DangoBrawlPnlShopSlotIcon iconPanel2 = this.IconPanel;
				if (iconPanel2 != null)
				{
					iconPanel2.BindData(dangoBrawlBaseItemInfo.ConfigId, this.SlotIndex, this.ActData);
				}
				this.RefreshLock(slot.Locked);
				this.RefreshCost(slot.Price, dangoBrawlBaseItemInfo.ConfigId);
				this.RefreshQuality(dangoBrawlBaseItemInfo.ConfigId);
				this.RefreshRecommend(dangoBrawlBaseItemInfo.ConfigId);
				DangoBrawlViewCost weightPanel = this.WeightPanel;
				if (weightPanel == null)
				{
					return;
				}
				weightPanel.BindData(dangoBrawlBaseItemInfo.ConfigId);
				return;
			}
		}

		// Token: 0x060425B7 RID: 271799 RVA: 0x0101CF10 File Offset: 0x0101B110
		private void RefreshCostView()
		{
			DangoBrawlShopSlotInfo slot = this.GetSlot();
			if (slot != null && slot.Item != null && slot.Item.ConfigId > 0)
			{
				this.RefreshCost(slot.Price, slot.Item.ConfigId);
			}
		}

		// Token: 0x060425B8 RID: 271800 RVA: 0x0101CF54 File Offset: 0x0101B154
		private void RefreshLock(bool locked)
		{
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(locked);
			}
			UUIItem item2 = base.GetItem(14);
			if (item2 != null)
			{
				item2.SetUIActive(locked);
			}
			UUIItem item3 = base.GetItem(13);
			if (item3 != null)
			{
				item3.SetUIActive(!locked);
			}
			if (locked && !this.IsLocked)
			{
				UiSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer != null)
				{
					sequencePlayer.PlaySequencePurely("Lock", false, false);
				}
			}
			this.IsLocked = locked;
		}

		// Token: 0x060425B9 RID: 271801 RVA: 0x0101CFCC File Offset: 0x0101B1CC
		private void RefreshCost(int price, int configId)
		{
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIText text = base.GetText(6);
			if (text != null)
			{
				text.SetText(price.ToString(), true);
			}
			DangoBrawlInstBaseNotify instBase = this.ActData.InstBase;
			int num = (instBase != null) ? instBase.Coin : 0;
			DangoBrawlItem? dangoBrawlItem;
			int num2 = (DangoBrawlConfig.Instance.GetItemConfigById(configId) != null) ? dangoBrawlItem.GetValueOrDefault().Price : 0;
			bool flag = num2 > 0 && price < num2;
			string hexStr;
			if (num < price)
			{
				hexStr = "FF6767FF";
			}
			else if (flag)
			{
				hexStr = "FFF77EFF";
			}
			else
			{
				hexStr = "FFFFFFFF";
			}
			UUIText text2 = base.GetText(6);
			if (text2 != null)
			{
				text2.SetColor(FColor.FromHex(hexStr));
			}
			UUIText text3 = base.GetText(12);
			if (text3 != null)
			{
				text3.SetUIActive(flag);
			}
			if (text3 == null)
			{
				return;
			}
			text3.SetText(num2.ToString(), true);
		}

		// Token: 0x060425BA RID: 271802 RVA: 0x0101D0B0 File Offset: 0x0101B2B0
		private void RefreshRecommend(int configId)
		{
			int roleId = this.ActData.GetRoleId();
			DangoBrawlInstBaseNotify instBase = this.ActData.InstBase;
			bool uiactive = DangoBrawlRecommendUtil.IsItemRecommended(configId, roleId, (instBase != null) ? instBase.ChallengeId : 0, this.ActData.GetShopRound());
			UUIItem item = base.GetItem(9);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x060425BB RID: 271803 RVA: 0x0101D104 File Offset: 0x0101B304
		private void RefreshQuality(int configId)
		{
			DangoBrawlItem? itemConfigById = DangoBrawlConfig.Instance.GetItemConfigById(configId);
			if (itemConfigById == null)
			{
				return;
			}
			DangoBrawlItemQuality? itemQualityConfigById = DangoBrawlConfig.Instance.GetItemQualityConfigById(itemConfigById.Value.Quality);
			string text = (itemQualityConfigById != null) ? itemQualityConfigById.GetValueOrDefault().ShopBackgroundColor : null;
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			UUISprite sprite = base.GetSprite(2);
			if (sprite == null)
			{
				return;
			}
			sprite.SetColor(FColor.FromHex(text));
		}

		// Token: 0x060425BC RID: 271804 RVA: 0x0101D17E File Offset: 0x0101B37E
		private void OnStartSequenceEvent(string sequenceStartEvent)
		{
		}

		// Token: 0x060425BD RID: 271805 RVA: 0x0101D180 File Offset: 0x0101B380
		private void OnEndSequenceEvent(string sequenceStartEvent)
		{
			if (sequenceStartEvent == "Refresh")
			{
				this.IsRefreshFxPlaying = false;
			}
		}

		// Token: 0x060425BE RID: 271806 RVA: 0x0101D198 File Offset: 0x0101B398
		private void OnClickLock()
		{
			DangoBrawlShopSlotInfo slot = this.GetSlot();
			if (((slot != null) ? slot.Item : null) == null)
			{
				return;
			}
			this.OnToggleLockAsync(!slot.Locked).Forget();
		}

		// Token: 0x060425BF RID: 271807 RVA: 0x0101D1CF File Offset: 0x0101B3CF
		private void OnDangoBrawlCoinUpdated()
		{
			this.RefreshCostView();
		}

		// Token: 0x060425C0 RID: 271808 RVA: 0x0101D1D7 File Offset: 0x0101B3D7
		private void OnDangoBrawlItemGiveCoinNotify(DangoBrawlItemGiveCoinNotify message)
		{
			this.RefreshCostView();
		}

		// Token: 0x060425C1 RID: 271809 RVA: 0x0101D1E0 File Offset: 0x0101B3E0
		private void OnDangoBrawlShopRefreshed()
		{
			DangoBrawlShopSlotInfo slot = this.GetSlot();
			if (slot != null && slot.Locked)
			{
				return;
			}
			DangoBrawlShopSlotInfo slot2 = this.GetSlot();
			int? num;
			if (slot2 == null)
			{
				num = null;
			}
			else
			{
				DangoBrawlBaseItemInfo item = slot2.Item;
				num = ((item != null) ? new int?(item.Uid) : null);
			}
			int? num2 = num;
			if (num2.GetValueOrDefault(-1) != this.SlotUid)
			{
				this.IsRefreshFxPlaying = true;
				UiSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer == null)
				{
					return;
				}
				sequencePlayer.PlaySequencePurely("Refresh", false, false);
			}
		}

		// Token: 0x060425C2 RID: 271810 RVA: 0x0101D264 File Offset: 0x0101B464
		private UniTask OnToggleLockAsync(bool isOn)
		{
			DangoBrawlPnlShopSlot.<OnToggleLockAsync>d__38 <OnToggleLockAsync>d__;
			<OnToggleLockAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnToggleLockAsync>d__.<>4__this = this;
			<OnToggleLockAsync>d__.isOn = isOn;
			<OnToggleLockAsync>d__.<>1__state = -1;
			<OnToggleLockAsync>d__.<>t__builder.Start<DangoBrawlPnlShopSlot.<OnToggleLockAsync>d__38>(ref <OnToggleLockAsync>d__);
			return <OnToggleLockAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04022998 RID: 141720
		private ActivityDangoBrawlData ActData;

		// Token: 0x04022999 RID: 141721
		private int SlotIndex = -1;

		// Token: 0x0402299A RID: 141722
		private int SlotUid = -1;

		// Token: 0x0402299B RID: 141723
		private bool IsLocked;

		// Token: 0x0402299C RID: 141724
		private bool IsRefreshFxPlaying;

		// Token: 0x0402299D RID: 141725
		[Nullable(2)]
		private DangoBrawlPnlShopSlotIcon IconPanel;

		// Token: 0x0402299E RID: 141726
		[Nullable(2)]
		private DangoBrawlViewCost WeightPanel;

		// Token: 0x0402299F RID: 141727
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200C958 RID: 51544
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403CCB8 RID: 249016
			PnlEmpty,
			// Token: 0x0403CCB9 RID: 249017
			PnlNor,
			// Token: 0x0403CCBA RID: 249018
			SprQuality,
			// Token: 0x0403CCBB RID: 249019
			PnlItem,
			// Token: 0x0403CCBC RID: 249020
			BtnLock,
			// Token: 0x0403CCBD RID: 249021
			PnlCost,
			// Token: 0x0403CCBE RID: 249022
			TxtCost,
			// Token: 0x0403CCBF RID: 249023
			TemplateWeight,
			// Token: 0x0403CCC0 RID: 249024
			ItemFxLock,
			// Token: 0x0403CCC1 RID: 249025
			SprRecommend,
			// Token: 0x0403CCC2 RID: 249026
			TemplateIcon,
			// Token: 0x0403CCC3 RID: 249027
			ItemSelf,
			// Token: 0x0403CCC4 RID: 249028
			TxtPreCost,
			// Token: 0x0403CCC5 RID: 249029
			SprUnLock,
			// Token: 0x0403CCC6 RID: 249030
			SprLock
		}
	}
}
