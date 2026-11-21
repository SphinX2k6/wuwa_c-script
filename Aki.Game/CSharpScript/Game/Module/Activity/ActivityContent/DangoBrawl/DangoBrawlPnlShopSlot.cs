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
	// Token: 0x02005746 RID: 22342
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlPnlShopSlot : UiPanelBase
	{
		// Token: 0x17006A5B RID: 27227
		// (get) Token: 0x060370FB RID: 225531 RVA: 0x00F5DD9B File Offset: 0x00F5BF9B
		public int MySlotIndex
		{
			get
			{
				return this.SlotIndex;
			}
		}

		// Token: 0x060370FC RID: 225532 RVA: 0x00F5DDA4 File Offset: 0x00F5BFA4
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

		// Token: 0x060370FD RID: 225533 RVA: 0x00F5DDEC File Offset: 0x00F5BFEC
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

		// Token: 0x060370FE RID: 225534 RVA: 0x00F5E024 File Offset: 0x00F5C224
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlPnlShopSlot.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlPnlShopSlot.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060370FF RID: 225535 RVA: 0x00F5E067 File Offset: 0x00F5C267
		protected override void OnBeforeDestroy()
		{
			this.UnBindEvents();
			this.ClearSequencePlayer();
		}

		// Token: 0x06037100 RID: 225536 RVA: 0x00F5E078 File Offset: 0x00F5C278
		private void BineEvents()
		{
			EventSystem.Instance.Add(EEventName.OnDangoBrawlLayerModeChanged, new Action<bool>(this.OnDangoBrawlLayerModeChanged));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlCoinUpdated, new Action(this.OnDangoBrawlCoinUpdated));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlItemGiveCoinNotify, new Action<DangoBrawlItemGiveCoinNotify>(this.OnDangoBrawlItemGiveCoinNotify));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlShopRefreshed, new Action(this.OnDangoBrawlShopRefreshed));
		}

		// Token: 0x06037101 RID: 225537 RVA: 0x00F5E0F8 File Offset: 0x00F5C2F8
		private void UnBindEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlLayerModeChanged, new Action<bool>(this.OnDangoBrawlLayerModeChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlCoinUpdated, new Action(this.OnDangoBrawlCoinUpdated));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlItemGiveCoinNotify, new Action<DangoBrawlItemGiveCoinNotify>(this.OnDangoBrawlItemGiveCoinNotify));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopRefreshed, new Action(this.OnDangoBrawlShopRefreshed));
		}

		// Token: 0x06037102 RID: 225538 RVA: 0x00F5E178 File Offset: 0x00F5C378
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

		// Token: 0x06037103 RID: 225539 RVA: 0x00F5E1DC File Offset: 0x00F5C3DC
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

		// Token: 0x06037104 RID: 225540 RVA: 0x00F5E234 File Offset: 0x00F5C434
		private void ClearSequencePlayer()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x06037105 RID: 225541 RVA: 0x00F5E24E File Offset: 0x00F5C44E
		public void SetSelected(bool selected)
		{
			DangoBrawlPnlShopSlotIcon iconPanel = this.IconPanel;
			if (iconPanel == null)
			{
				return;
			}
			iconPanel.SetSelected(selected);
		}

		// Token: 0x06037106 RID: 225542 RVA: 0x00F5E261 File Offset: 0x00F5C461
		private void OnDangoBrawlLayerModeChanged(bool isLayerMode)
		{
			DangoBrawlPnlShopSlotIcon iconPanel = this.IconPanel;
			if (iconPanel == null)
			{
				return;
			}
			iconPanel.ApplyLayerMode(isLayerMode);
		}

		// Token: 0x06037107 RID: 225543 RVA: 0x00F5E274 File Offset: 0x00F5C474
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

		// Token: 0x06037108 RID: 225544 RVA: 0x00F5E2B4 File Offset: 0x00F5C4B4
		private UniTask CreateIconPanel()
		{
			DangoBrawlPnlShopSlot.<CreateIconPanel>d__23 <CreateIconPanel>d__;
			<CreateIconPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateIconPanel>d__.<>4__this = this;
			<CreateIconPanel>d__.<>1__state = -1;
			<CreateIconPanel>d__.<>t__builder.Start<DangoBrawlPnlShopSlot.<CreateIconPanel>d__23>(ref <CreateIconPanel>d__);
			return <CreateIconPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06037109 RID: 225545 RVA: 0x00F5E2F8 File Offset: 0x00F5C4F8
		public void TryToggleLock()
		{
			DangoBrawlShopSlotInfo slot = this.GetSlot();
			if (((slot != null) ? slot.Item : null) == null)
			{
				return;
			}
			this.OnToggleLockAsync(!slot.Locked).Forget();
		}

		// Token: 0x0603710A RID: 225546 RVA: 0x00F5E330 File Offset: 0x00F5C530
		private UniTask CreateWeightPanel()
		{
			DangoBrawlPnlShopSlot.<CreateWeightPanel>d__25 <CreateWeightPanel>d__;
			<CreateWeightPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateWeightPanel>d__.<>4__this = this;
			<CreateWeightPanel>d__.<>1__state = -1;
			<CreateWeightPanel>d__.<>t__builder.Start<DangoBrawlPnlShopSlot.<CreateWeightPanel>d__25>(ref <CreateWeightPanel>d__);
			return <CreateWeightPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0603710B RID: 225547 RVA: 0x00F5E374 File Offset: 0x00F5C574
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

		// Token: 0x0603710C RID: 225548 RVA: 0x00F5E454 File Offset: 0x00F5C654
		private void RefreshCostView()
		{
			DangoBrawlShopSlotInfo slot = this.GetSlot();
			if (slot != null && slot.Item != null && slot.Item.ConfigId > 0)
			{
				this.RefreshCost(slot.Price, slot.Item.ConfigId);
			}
		}

		// Token: 0x0603710D RID: 225549 RVA: 0x00F5E498 File Offset: 0x00F5C698
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

		// Token: 0x0603710E RID: 225550 RVA: 0x00F5E510 File Offset: 0x00F5C710
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

		// Token: 0x0603710F RID: 225551 RVA: 0x00F5E5F4 File Offset: 0x00F5C7F4
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

		// Token: 0x06037110 RID: 225552 RVA: 0x00F5E648 File Offset: 0x00F5C848
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

		// Token: 0x06037111 RID: 225553 RVA: 0x00F5E6C2 File Offset: 0x00F5C8C2
		private void OnStartSequenceEvent(string sequenceStartEvent)
		{
		}

		// Token: 0x06037112 RID: 225554 RVA: 0x00F5E6C4 File Offset: 0x00F5C8C4
		private void OnEndSequenceEvent(string sequenceStartEvent)
		{
			if (sequenceStartEvent == "Refresh")
			{
				this.IsRefreshFxPlaying = false;
			}
		}

		// Token: 0x06037113 RID: 225555 RVA: 0x00F5E6DC File Offset: 0x00F5C8DC
		private void OnClickLock()
		{
			DangoBrawlShopSlotInfo slot = this.GetSlot();
			if (((slot != null) ? slot.Item : null) == null)
			{
				return;
			}
			this.OnToggleLockAsync(!slot.Locked).Forget();
		}

		// Token: 0x06037114 RID: 225556 RVA: 0x00F5E713 File Offset: 0x00F5C913
		private void OnDangoBrawlCoinUpdated()
		{
			this.RefreshCostView();
		}

		// Token: 0x06037115 RID: 225557 RVA: 0x00F5E71B File Offset: 0x00F5C91B
		private void OnDangoBrawlItemGiveCoinNotify(DangoBrawlItemGiveCoinNotify message)
		{
			this.RefreshCostView();
		}

		// Token: 0x06037116 RID: 225558 RVA: 0x00F5E724 File Offset: 0x00F5C924
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

		// Token: 0x06037117 RID: 225559 RVA: 0x00F5E7A8 File Offset: 0x00F5C9A8
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

		// Token: 0x0401D1F5 RID: 119285
		private ActivityDangoBrawlData ActData;

		// Token: 0x0401D1F6 RID: 119286
		private int SlotIndex = -1;

		// Token: 0x0401D1F7 RID: 119287
		private int SlotUid = -1;

		// Token: 0x0401D1F8 RID: 119288
		private bool IsLocked;

		// Token: 0x0401D1F9 RID: 119289
		private bool IsRefreshFxPlaying;

		// Token: 0x0401D1FA RID: 119290
		[Nullable(2)]
		private DangoBrawlPnlShopSlotIcon IconPanel;

		// Token: 0x0401D1FB RID: 119291
		[Nullable(2)]
		private DangoBrawlViewCost WeightPanel;

		// Token: 0x0401D1FC RID: 119292
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200B325 RID: 45861
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x040375A5 RID: 226725
			PnlEmpty,
			// Token: 0x040375A6 RID: 226726
			PnlNor,
			// Token: 0x040375A7 RID: 226727
			SprQuality,
			// Token: 0x040375A8 RID: 226728
			PnlItem,
			// Token: 0x040375A9 RID: 226729
			BtnLock,
			// Token: 0x040375AA RID: 226730
			PnlCost,
			// Token: 0x040375AB RID: 226731
			TxtCost,
			// Token: 0x040375AC RID: 226732
			TemplateWeight,
			// Token: 0x040375AD RID: 226733
			ItemFxLock,
			// Token: 0x040375AE RID: 226734
			SprRecommend,
			// Token: 0x040375AF RID: 226735
			TemplateIcon,
			// Token: 0x040375B0 RID: 226736
			ItemSelf,
			// Token: 0x040375B1 RID: 226737
			TxtPreCost,
			// Token: 0x040375B2 RID: 226738
			SprUnLock,
			// Token: 0x040375B3 RID: 226739
			SprLock
		}
	}
}
