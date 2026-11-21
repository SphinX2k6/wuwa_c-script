using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Google.Protobuf.Collections;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005747 RID: 22343
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlPnlShopSlotIcon : UiPanelBase, IDangoBrawlDraggableView, ICombineLineOwner
	{
		// Token: 0x17006A5C RID: 27228
		// (get) Token: 0x06037119 RID: 225561 RVA: 0x00F5E809 File Offset: 0x00F5CA09
		private bool RefreshFxBlocking
		{
			get
			{
				Func<bool> isRefreshFxPlaying = this.IsRefreshFxPlaying;
				return isRefreshFxPlaying != null && isRefreshFxPlaying();
			}
		}

		// Token: 0x17006A5D RID: 27229
		// (get) Token: 0x0603711A RID: 225562 RVA: 0x00F5E81C File Offset: 0x00F5CA1C
		private DangoBrawlTouchController Touch
		{
			get
			{
				return DangoBrawlModel.Instance.GetTouchController();
			}
		}

		// Token: 0x17006A5E RID: 27230
		// (get) Token: 0x0603711B RID: 225563 RVA: 0x00F5E828 File Offset: 0x00F5CA28
		private DangoBrawlItemViewRegistry Registry
		{
			get
			{
				return DangoBrawlModel.Instance.GetViewRegistry();
			}
		}

		// Token: 0x17006A5F RID: 27231
		// (get) Token: 0x0603711C RID: 225564 RVA: 0x00F5E834 File Offset: 0x00F5CA34
		private UUITexture SprIconMask
		{
			get
			{
				return base.GetTexture(10);
			}
		}

		// Token: 0x0603711D RID: 225565 RVA: 0x00F5E840 File Offset: 0x00F5CA40
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIDraggableComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603711E RID: 225566 RVA: 0x00F5E9D5 File Offset: 0x00F5CBD5
		protected override void OnStart()
		{
			this.BindEvents();
			this.StartLineTick();
		}

		// Token: 0x0603711F RID: 225567 RVA: 0x00F5E9E3 File Offset: 0x00F5CBE3
		protected override void OnBeforeDestroy()
		{
			this.StopLineTick();
			this.UnbindEvents();
			this.ClearCombineGuideLines();
			this.ClearSequencePlayer();
		}

		// Token: 0x06037120 RID: 225568 RVA: 0x00F5EA00 File Offset: 0x00F5CC00
		private void BindEvents()
		{
			EventSystem.Instance.Add(EEventName.OnDangoBrawlBagUpdated, new Action(this.OnLineDataDirty));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlBackpackModified, new Action<EDangoBrawlModifyType, int>(this.OnLineBackpackModified));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlBenchModified, new Action<EDangoBrawlModifyType, int>(this.OnLineBackpackModified));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlBagOperated, new Action<EBagOpKind, int>(this.OnLineBagOperated));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlShopRefreshed, new Action(this.OnLineDataDirty));
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.OnPointEnterCallBack.Bind(new Action<EToggleState>(this.OnPointerEnter));
				extendToggle.OnPointExitCallBack.Bind(new Action<EToggleState>(this.OnPointerExit));
			}
			UUIDraggableComponent draggable = base.GetDraggable(4);
			if (draggable != null)
			{
				draggable.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
				draggable.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnBeginDrag));
				draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDrag));
				draggable.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnEndDrag));
			}
		}

		// Token: 0x06037121 RID: 225569 RVA: 0x00F5EB3C File Offset: 0x00F5CD3C
		private void UnbindEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlBagUpdated, new Action(this.OnLineDataDirty));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlBackpackModified, new Action<EDangoBrawlModifyType, int>(this.OnLineBackpackModified));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlBenchModified, new Action<EDangoBrawlModifyType, int>(this.OnLineBackpackModified));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlBagOperated, new Action<EBagOpKind, int>(this.OnLineBagOperated));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopRefreshed, new Action(this.OnLineDataDirty));
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.OnPointEnterCallBack.Unbind();
				extendToggle.OnPointExitCallBack.Unbind();
			}
			UUIDraggableComponent draggable = base.GetDraggable(4);
			if (draggable != null)
			{
				draggable.OnPointerUpCallBack.Unbind();
				draggable.OnPointerBeginDragCallBack.Unbind();
				draggable.OnPointerDragCallBack.Unbind();
				draggable.OnPointerEndDragCallBack.Unbind();
			}
		}

		// Token: 0x06037122 RID: 225570 RVA: 0x00F5EC30 File Offset: 0x00F5CE30
		[NullableContext(1)]
		public void BindData(int itemId, int slotIndex, ActivityDangoBrawlData actData)
		{
			if (itemId <= 0)
			{
				return;
			}
			this.ItemId = itemId;
			this.SlotIndex = slotIndex;
			this.ActData = actData;
			PanelPos[] posList = DangoBrawlUtil.RotatePanelPosList(itemId, EDangoBrawlRotate.Direction0);
			this.RefreshGrids(posList);
			this.RefreshSize(posList);
			this.RefreshIcon();
			this.RefreshShadow();
			this.InitCombineGuideLines();
			this.InitSequencePlayer();
			this.SetSelected(false);
		}

		// Token: 0x06037123 RID: 225571 RVA: 0x00F5EC8C File Offset: 0x00F5CE8C
		private void InitCombineGuideLines()
		{
			this.ClearCombineGuideLines();
			UUIItem item = base.GetItem(8);
			UUIItem item2 = base.GetItem(7);
			if (item == null || item2 == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.LSH;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(66, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[ShopSlotIcon] InitCombineLines template or container null itemId=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.ItemId);
				instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.GuideLineHost = new DangoBrawlCombineGuideLineHost(this, EDragSourceKind.Shop, this.ActData, item, item2);
			DangoBrawlItemViewRegistry registry = this.Registry;
			if (registry != null)
			{
				registry.RegisterLineOwner(this.MyUid, this);
			}
			this.GuideLineHost.SetReason(ECombineLineShowReason.Always, !DangoBrawlViewManager.TryBlockIfLayerMode(false));
		}

		// Token: 0x06037124 RID: 225572 RVA: 0x00F5ED3D File Offset: 0x00F5CF3D
		private void ClearCombineGuideLines()
		{
			DangoBrawlItemViewRegistry registry = this.Registry;
			if (registry != null)
			{
				DangoBrawlCombineGuideLineHost guideLineHost = this.GuideLineHost;
				registry.UnregisterLineOwner((guideLineHost != null) ? guideLineHost.GetCachedUid() : 0, this);
			}
			DangoBrawlCombineGuideLineHost guideLineHost2 = this.GuideLineHost;
			if (guideLineHost2 != null)
			{
				guideLineHost2.Destroy();
			}
			this.GuideLineHost = null;
		}

		// Token: 0x06037125 RID: 225573 RVA: 0x00F5ED7C File Offset: 0x00F5CF7C
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

		// Token: 0x06037126 RID: 225574 RVA: 0x00F5EDD4 File Offset: 0x00F5CFD4
		private void ClearSequencePlayer()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x06037127 RID: 225575 RVA: 0x00F5EDF0 File Offset: 0x00F5CFF0
		public void SetSelected(bool selected)
		{
			if (selected)
			{
				UiSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer != null)
				{
					sequencePlayer.PlaySequencePurely("Drop", false, false);
				}
			}
			else if (this.IsSelected)
			{
				UiSequencePlayer sequencePlayer2 = this.SequencePlayer;
				if (sequencePlayer2 != null)
				{
					sequencePlayer2.PlaySequencePurely("Unselected", false, false);
				}
			}
			this.SetStarContainerActive(selected);
			this.IsSelected = selected;
		}

		// Token: 0x06037128 RID: 225576 RVA: 0x00F5EE48 File Offset: 0x00F5D048
		private void SetStarContainerActive(bool val)
		{
			if (val)
			{
				PanelPos[] starPosList = DangoBrawlUtil.RotateStarPanelPosList(this.ItemId, EDangoBrawlRotate.Direction0);
				this.RefreshStars(starPosList);
			}
			base.GetItem(5).SetUIActive(val);
		}

		// Token: 0x06037129 RID: 225577 RVA: 0x00F5EE79 File Offset: 0x00F5D079
		private float GetGridSize()
		{
			return base.GetItem(2).GetHeight();
		}

		// Token: 0x0603712A RID: 225578 RVA: 0x00F5EE88 File Offset: 0x00F5D088
		[NullableContext(1)]
		private void RefreshGrids(PanelPos[] posList)
		{
			UUIItem item = base.GetItem(2);
			UUIItem item2 = base.GetItem(1);
			float gridSize = this.GetGridSize();
			item.SetUIActive(false);
			for (int i = 0; i < posList.Length; i++)
			{
				PanelPos panelPos = posList[i];
				FVector uirelativeLocation = new FVector((float)panelPos.ColIndex * gridSize, (float)(-(float)panelPos.RowIndex) * gridSize, 0f);
				UUIItem uuiitem = (i < this.GridItems.Count) ? this.GridItems[i] : null;
				if (uuiitem == null)
				{
					uuiitem = LguiUtil.Instance.CopyItem(item, item2);
					this.GridItems.Add(uuiitem);
				}
				uuiitem.SetUIActive(true);
				uuiitem.SetUIRelativeLocation(uirelativeLocation);
			}
			for (int j = posList.Length; j < this.GridItems.Count; j++)
			{
				this.GridItems[j].SetUIActive(false);
			}
		}

		// Token: 0x0603712B RID: 225579 RVA: 0x00F5EF6C File Offset: 0x00F5D16C
		[NullableContext(1)]
		private void RefreshStars(PanelPos[] starPosList)
		{
			UUIItem item = base.GetItem(6);
			UUIItem item2 = base.GetItem(5);
			float gridSize = this.GetGridSize();
			item.SetUIActive(false);
			for (int i = 0; i < starPosList.Length; i++)
			{
				PanelPos panelPos = starPosList[i];
				FVector2D location = new FVector2D((float)panelPos.ColIndex * gridSize, (float)(-(float)panelPos.RowIndex) * gridSize);
				DangoBrawlGeneralStar dangoBrawlGeneralStar = (i < this.StarPanels.Count) ? this.StarPanels[i] : null;
				if (dangoBrawlGeneralStar == null)
				{
					UUIItem uuiitem = LguiUtil.Instance.CopyItem(item, item2);
					uuiitem.SetUIActive(true);
					DangoBrawlGeneralStar created = new DangoBrawlGeneralStar();
					created.CreateThenShowByActorAsync(uuiitem.GetOwner(), null, false).ContinueWith(delegate()
					{
						created.SetUiRelativeLocation(location);
						created.SetStarVisible(false);
					}).Forget();
					this.StarPanels.Add(created);
				}
				else
				{
					UUIItem rootItem = dangoBrawlGeneralStar.GetRootItem();
					if (rootItem != null)
					{
						rootItem.SetUIActive(true);
					}
					dangoBrawlGeneralStar.SetUiRelativeLocation(location);
					dangoBrawlGeneralStar.SetStarVisible(false);
				}
			}
			for (int j = starPosList.Length; j < this.StarPanels.Count; j++)
			{
				UUIItem rootItem2 = this.StarPanels[j].GetRootItem();
				if (rootItem2 != null)
				{
					rootItem2.SetUIActive(false);
				}
			}
		}

		// Token: 0x0603712C RID: 225580 RVA: 0x00F5F0C4 File Offset: 0x00F5D2C4
		private void RefreshShadow()
		{
			UUITexture texture = base.GetTexture(3);
			object obj;
			if (texture == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = texture.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(UUIEffectShadow.StaticClass()) : null);
			}
			UUIEffectShadow uuieffectShadow = obj as UUIEffectShadow;
			if (uuieffectShadow == null || !uuieffectShadow.IsValid())
			{
				return;
			}
			uuieffectShadow.shadowOffset = DangoBrawlUtil.GetShadowOffset(EDangoBrawlRotate.Direction0);
		}

		// Token: 0x0603712D RID: 225581 RVA: 0x00F5F118 File Offset: 0x00F5D318
		private void RefreshIcon()
		{
			UUITexture texture = base.GetTexture(3);
			UUIDraggableComponent draggable = base.GetDraggable(4);
			if (texture == null || draggable == null)
			{
				return;
			}
			DangoBrawlItem? dangoBrawlItemById = DangoBrawlConfig.Instance.GetDangoBrawlItemById(this.ItemId);
			if (dangoBrawlItemById == null)
			{
				return;
			}
			int loadId = this.ItemId;
			float iconShopScale = dangoBrawlItemById.Value.IconShopScale;
			texture.SetRelativeScale3D(new FVector(iconShopScale, iconShopScale, iconShopScale));
			UUITexture sprIconMask = this.SprIconMask;
			if (sprIconMask != null)
			{
				sprIconMask.SetRelativeScale3D(new FVector(iconShopScale, iconShopScale, iconShopScale));
			}
			string iconRaycast = dangoBrawlItemById.Value.IconRaycast;
			if (!string.IsNullOrEmpty(iconRaycast))
			{
				Action<bool> <>9__1;
				Action<bool> <>9__2;
				ResourceSystem.Instance.LoadAsync<ULGUIVertsData>(iconRaycast, delegate([Nullable(2)] ULGUIVertsData vertsData, string _)
				{
					if (vertsData == null || !vertsData.IsValid() || loadId != this.ItemId)
					{
						return;
					}
					string text = (vertsData.SourceAsset == null) ? "" : vertsData.SourceAsset.GetPathName();
					UiPanelBase <>4__this = this;
					string path = text;
					UUITexture texture2 = this.GetTexture(3);
					EUiViewName? syncLoadViewName = null;
					Action<bool> callback;
					if ((callback = <>9__1) == null)
					{
						callback = (<>9__1 = delegate(bool suc)
						{
							if (!suc || loadId != this.ItemId)
							{
								return;
							}
							UUITexture texture3 = this.GetTexture(3);
							if (texture3 == null)
							{
								return;
							}
							texture3.SetSizeFromTexture();
						});
					}
					<>4__this.SetTextureByPath(path, texture2, syncLoadViewName, callback);
					UiPanelBase <>4__this2 = this;
					string path2 = text;
					UUITexture sprIconMask2 = this.SprIconMask;
					EUiViewName? syncLoadViewName2 = null;
					Action<bool> callback2;
					if ((callback2 = <>9__2) == null)
					{
						callback2 = (<>9__2 = delegate(bool suc)
						{
							if (!suc || loadId != this.ItemId)
							{
								return;
							}
							UUITexture sprIconMask3 = this.SprIconMask;
							if (sprIconMask3 == null)
							{
								return;
							}
							sprIconMask3.SetSizeFromTexture();
						});
					}
					<>4__this2.SetTextureByPath(path2, sprIconMask2, syncLoadViewName2, callback2);
				}, 100, "js_undefined");
			}
		}

		// Token: 0x0603712E RID: 225582 RVA: 0x00F5F1EC File Offset: 0x00F5D3EC
		[NullableContext(1)]
		private void RefreshSize(PanelPos[] posList)
		{
			int num = 0;
			int num2 = 0;
			foreach (PanelPos panelPos in posList)
			{
				if (panelPos.ColIndex > num)
				{
					num = panelPos.ColIndex;
				}
				if (panelPos.RowIndex > num2)
				{
					num2 = panelPos.RowIndex;
				}
			}
			float gridSize = this.GetGridSize();
			UUIItem rootItem = base.GetRootItem();
			if (rootItem != null)
			{
				rootItem.SetWidth((float)(num + 1) * gridSize);
			}
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetHeight((float)(num2 + 1) * gridSize);
		}

		// Token: 0x0603712F RID: 225583 RVA: 0x00F5F26E File Offset: 0x00F5D46E
		public void ApplyLayerMode(bool isLayerMode)
		{
			DangoBrawlCombineGuideLineHost guideLineHost = this.GuideLineHost;
			if (guideLineHost == null)
			{
				return;
			}
			guideLineHost.SetReason(ECombineLineShowReason.Always, !isLayerMode);
		}

		// Token: 0x06037130 RID: 225584 RVA: 0x00F5F288 File Offset: 0x00F5D488
		private DangoBrawlShopSlotInfo GetSlot()
		{
			ActivityDangoBrawlData actData = this.ActData;
			RepeatedField<DangoBrawlShopSlotInfo> repeatedField;
			if (actData == null)
			{
				repeatedField = null;
			}
			else
			{
				DangoBrawlShopServerData shopServerData = actData.ShopServerData;
				if (shopServerData == null)
				{
					repeatedField = null;
				}
				else
				{
					DangoBrawlShopInfo myShopInfo = shopServerData.MyShopInfo;
					repeatedField = ((myShopInfo != null) ? myShopInfo.Slots : null);
				}
			}
			RepeatedField<DangoBrawlShopSlotInfo> repeatedField2 = repeatedField;
			if (repeatedField2 == null || this.SlotIndex < 0 || this.SlotIndex >= repeatedField2.Count)
			{
				return null;
			}
			return repeatedField2[this.SlotIndex];
		}

		// Token: 0x06037131 RID: 225585 RVA: 0x00F5F2E8 File Offset: 0x00F5D4E8
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"Uid",
			"ConfigId"
		})]
		private ValueTuple<int, int>? GetSlotItem()
		{
			ActivityDangoBrawlData actData = this.ActData;
			RepeatedField<DangoBrawlShopSlotInfo> repeatedField;
			if (actData == null)
			{
				repeatedField = null;
			}
			else
			{
				DangoBrawlShopServerData shopServerData = actData.ShopServerData;
				if (shopServerData == null)
				{
					repeatedField = null;
				}
				else
				{
					DangoBrawlShopInfo myShopInfo = shopServerData.MyShopInfo;
					repeatedField = ((myShopInfo != null) ? myShopInfo.Slots : null);
				}
			}
			RepeatedField<DangoBrawlShopSlotInfo> repeatedField2 = repeatedField;
			if (repeatedField2 == null || this.SlotIndex < 0 || this.SlotIndex >= repeatedField2.Count)
			{
				return null;
			}
			DangoBrawlShopSlotInfo dangoBrawlShopSlotInfo = repeatedField2[this.SlotIndex];
			DangoBrawlBaseItemInfo dangoBrawlBaseItemInfo = (dangoBrawlShopSlotInfo != null) ? dangoBrawlShopSlotInfo.Item : null;
			if (dangoBrawlBaseItemInfo == null)
			{
				return null;
			}
			return new ValueTuple<int, int>?(new ValueTuple<int, int>(dangoBrawlBaseItemInfo.Uid, dangoBrawlBaseItemInfo.ConfigId));
		}

		// Token: 0x06037132 RID: 225586 RVA: 0x00F5F380 File Offset: 0x00F5D580
		public void OnSell()
		{
			this.ClearCombineGuideLines();
			this.ClearSequencePlayer();
		}

		// Token: 0x06037133 RID: 225587 RVA: 0x00F5F38E File Offset: 0x00F5D58E
		[NullableContext(1)]
		private void OnStartSequenceEvent(string sequenceStartEvent)
		{
		}

		// Token: 0x06037134 RID: 225588 RVA: 0x00F5F390 File Offset: 0x00F5D590
		[NullableContext(1)]
		private void OnEndSequenceEvent(string sequenceStartEvent)
		{
		}

		// Token: 0x06037135 RID: 225589 RVA: 0x00F5F394 File Offset: 0x00F5D594
		private void OnPointerUp(ULGUIPointerEventData eventData)
		{
			if (eventData != null && eventData.inputType == ELGUIPointerInputType.Navigation)
			{
				DangoBrawlShopSlotInfo slot = this.GetSlot();
				if (slot == null)
				{
					return;
				}
				if (DangoBrawlViewManager.TryBlockIfLayerMode(true) || DangoBrawlViewManager.TryBlockIfHolding(new int?(this.MyUid)) || DangoBrawlViewManager.TryBlockIfNoEnoughtCoin(slot.Price, true))
				{
					return;
				}
				DangoBrawlTouchController touch = this.Touch;
				if (touch == null)
				{
					return;
				}
				touch.OnPointerClick(EDragSourceKind.Shop, this, eventData.pointerPosition).Forget();
				return;
			}
			else
			{
				if (this.IsDragging)
				{
					return;
				}
				this.OnLeftClick(eventData);
				return;
			}
		}

		// Token: 0x06037136 RID: 225590 RVA: 0x00F5F410 File Offset: 0x00F5D610
		private void OnBeginDrag(ULGUIPointerEventData eventData)
		{
			DangoBrawlShopSlotInfo slot = this.GetSlot();
			if (eventData == null)
			{
				return;
			}
			if (!DangoBrawlUtil.IsValidDragInput(eventData))
			{
				return;
			}
			if (this.RefreshFxBlocking)
			{
				return;
			}
			if (slot == null)
			{
				return;
			}
			if (DangoBrawlViewManager.TryBlockIfLayerMode(true) || DangoBrawlViewManager.TryBlockIfHolding(new int?(this.MyUid)) || DangoBrawlViewManager.TryBlockIfNoEnoughtCoin(slot.Price, true) || DangoBrawlViewManager.TryBlockIfThreeChoose(true))
			{
				return;
			}
			this.IsDragging = true;
			DangoBrawlTouchController touch = this.Touch;
			if (touch == null)
			{
				return;
			}
			touch.OnPointerBeginDrag(EDragSourceKind.Shop, this, eventData.pointerPosition).Forget();
		}

		// Token: 0x06037137 RID: 225591 RVA: 0x00F5F493 File Offset: 0x00F5D693
		private void OnDrag(ULGUIPointerEventData eventData)
		{
			if (eventData == null)
			{
				return;
			}
			if (!DangoBrawlUtil.IsValidDragInput(eventData))
			{
				return;
			}
			if (DangoBrawlViewManager.TryBlockIfThreeChoose(true))
			{
				return;
			}
			DangoBrawlTouchController touch = this.Touch;
			if (touch == null)
			{
				return;
			}
			touch.OnPointerDrag(eventData.pointerPosition);
		}

		// Token: 0x06037138 RID: 225592 RVA: 0x00F5F4C1 File Offset: 0x00F5D6C1
		private void OnEndDrag(ULGUIPointerEventData eventData)
		{
			this.IsDragging = false;
			if (eventData == null)
			{
				return;
			}
			if (!DangoBrawlUtil.IsValidDragInput(eventData))
			{
				return;
			}
			if (DangoBrawlViewManager.TryBlockIfThreeChoose(true))
			{
				return;
			}
			DangoBrawlTouchController touch = this.Touch;
			if (touch == null)
			{
				return;
			}
			touch.OnPointerEndDrag(eventData.pointerPosition).Forget();
		}

		// Token: 0x06037139 RID: 225593 RVA: 0x00F5F4FC File Offset: 0x00F5D6FC
		private void OnPointerEnter(EToggleState _)
		{
			DangoBrawlTouchController touch = this.Touch;
			DragContext dragContext = (touch != null) ? touch.GetContext() : null;
			DangoBrawlTouchController touch2 = this.Touch;
			EInputPlatform? einputPlatform = (touch2 != null) ? new EInputPlatform?(touch2.GetInputPlatform()) : null;
			if (this.RefreshFxBlocking)
			{
				return;
			}
			EInputPlatform? einputPlatform2 = einputPlatform;
			EInputPlatform einputPlatform3 = EInputPlatform.Mobile;
			if (einputPlatform2.GetValueOrDefault() == einputPlatform3 & einputPlatform2 != null)
			{
				return;
			}
			if (DangoBrawlViewManager.TryBlockHoverEffect())
			{
				return;
			}
			DangoBrawlCombineGuideLineHost guideLineHost = this.GuideLineHost;
			if (guideLineHost != null)
			{
				guideLineHost.SetReason(ECombineLineShowReason.Hover, true);
			}
			if (this.MyUid <= 0)
			{
				return;
			}
			if (dragContext != null)
			{
				dragContext.SetHoveredItem(EDragSourceKind.Shop, this.MyUid);
			}
			this.SetStarContainerActive(true);
		}

		// Token: 0x0603713A RID: 225594 RVA: 0x00F5F59C File Offset: 0x00F5D79C
		private void OnPointerExit(EToggleState _)
		{
			DangoBrawlTouchController touch = this.Touch;
			DragContext dragContext = (touch != null) ? touch.GetContext() : null;
			if (this.RefreshFxBlocking)
			{
				return;
			}
			DangoBrawlCombineGuideLineHost guideLineHost = this.GuideLineHost;
			if (guideLineHost != null)
			{
				guideLineHost.SetReason(ECombineLineShowReason.Hover, false);
			}
			if (dragContext != null)
			{
				dragContext.ClearHoveredItemIfMatch(EDragSourceKind.Shop, this.MyUid);
			}
			DangoBrawlSelection dangoBrawlSelection = (dragContext != null) ? dragContext.GetSelection() : null;
			if (dangoBrawlSelection == null || dangoBrawlSelection.Source != EDragSourceKind.Shop || dangoBrawlSelection.Id != this.MyUid)
			{
				this.SetStarContainerActive(false);
			}
		}

		// Token: 0x0603713B RID: 225595 RVA: 0x00F5F618 File Offset: 0x00F5D818
		private void OnLeftClick(ULGUIPointerEventData eventData)
		{
			bool flag = false;
			DangoBrawlTouchController touch = this.Touch;
			EInputPlatform? einputPlatform = (touch != null) ? new EInputPlatform?(touch.GetInputPlatform()) : null;
			if (einputPlatform != null)
			{
				EInputPlatform valueOrDefault = einputPlatform.GetValueOrDefault();
				if (valueOrDefault != EInputPlatform.Mobile)
				{
					if (valueOrDefault == EInputPlatform.Pc)
					{
						flag = (eventData != null && eventData.mouseButtonType == EMouseButtonType.Left);
					}
				}
				else
				{
					flag = (eventData != null && eventData.pointerID == 0);
				}
			}
			if (!flag)
			{
				return;
			}
			if (DangoBrawlViewManager.TryBlockIfLayerMode(true) || DangoBrawlViewManager.TryBlockIfHolding(new int?(this.MyUid)))
			{
				return;
			}
			DangoBrawlTouchController touch2 = this.Touch;
			if (touch2 == null)
			{
				return;
			}
			touch2.GetContext().ToggleSelection(EDragSourceKind.Shop, this.MyUid);
		}

		// Token: 0x0603713C RID: 225596 RVA: 0x00F5F6BC File Offset: 0x00F5D8BC
		private void StartLineTick()
		{
			this.StopLineTick();
			this.GuideLineTickHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnLineTick), 20f, 1f, null, null, true);
		}

		// Token: 0x0603713D RID: 225597 RVA: 0x00F5F6ED File Offset: 0x00F5D8ED
		private void StopLineTick()
		{
			if (this.GuideLineTickHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.GuideLineTickHandle);
				this.GuideLineTickHandle = null;
			}
		}

		// Token: 0x0603713E RID: 225598 RVA: 0x00F5F710 File Offset: 0x00F5D910
		private void OnLineTick(float _)
		{
			if (this.IsDragProxyActive)
			{
				return;
			}
			int myUid = this.MyUid;
			if (myUid > 0 && this.GuideLineHost != null)
			{
				if (this.GuideLineHost.IsShowing)
				{
					DangoBrawlItemViewRegistry registry = this.Registry;
					if (registry != null)
					{
						registry.RegisterLineOwner(myUid, this);
					}
				}
				else
				{
					DangoBrawlItemViewRegistry registry2 = this.Registry;
					if (registry2 != null)
					{
						registry2.UnregisterLineOwner(myUid, this);
					}
				}
			}
			DangoBrawlCombineGuideLineHost guideLineHost = this.GuideLineHost;
			if (guideLineHost == null)
			{
				return;
			}
			guideLineHost.RefreshAnglesAndPartners();
		}

		// Token: 0x0603713F RID: 225599 RVA: 0x00F5F77E File Offset: 0x00F5D97E
		private void OnLineDataDirty()
		{
			DangoBrawlCombineGuideLineHost guideLineHost = this.GuideLineHost;
			if (guideLineHost == null)
			{
				return;
			}
			guideLineHost.RebuildShowing();
		}

		// Token: 0x06037140 RID: 225600 RVA: 0x00F5F790 File Offset: 0x00F5D990
		private void OnLineBackpackModified(EDangoBrawlModifyType type, int uid)
		{
			DangoBrawlCombineGuideLineHost guideLineHost = this.GuideLineHost;
			if (guideLineHost == null)
			{
				return;
			}
			guideLineHost.RebuildShowing();
		}

		// Token: 0x06037141 RID: 225601 RVA: 0x00F5F7A2 File Offset: 0x00F5D9A2
		private void OnLineBagOperated(EBagOpKind kind, int uid)
		{
			DangoBrawlCombineGuideLineHost guideLineHost = this.GuideLineHost;
			if (guideLineHost == null)
			{
				return;
			}
			guideLineHost.RebuildShowing();
		}

		// Token: 0x17006A60 RID: 27232
		// (get) Token: 0x06037142 RID: 225602 RVA: 0x00F5F7B4 File Offset: 0x00F5D9B4
		public int MyUid
		{
			get
			{
				if (this.GetSlotItem() == null)
				{
					return 0;
				}
				ValueTuple<int, int>? valueTuple;
				return valueTuple.GetValueOrDefault().Item1;
			}
		}

		// Token: 0x17006A61 RID: 27233
		// (get) Token: 0x06037143 RID: 225603 RVA: 0x00F5F7E0 File Offset: 0x00F5D9E0
		public int MyConfigId
		{
			get
			{
				if (this.GetSlotItem() == null)
				{
					return 0;
				}
				ValueTuple<int, int>? valueTuple;
				return valueTuple.GetValueOrDefault().Item2;
			}
		}

		// Token: 0x17006A62 RID: 27234
		// (get) Token: 0x06037144 RID: 225604 RVA: 0x00F5F80B File Offset: 0x00F5DA0B
		public EDangoBrawlTemplateType MyType
		{
			get
			{
				return EDangoBrawlTemplateType.Item;
			}
		}

		// Token: 0x17006A63 RID: 27235
		// (get) Token: 0x06037145 RID: 225605 RVA: 0x00F5F80E File Offset: 0x00F5DA0E
		public DangoBrawlItemBase MyItemData
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06037146 RID: 225606 RVA: 0x00F5F811 File Offset: 0x00F5DA11
		[NullableContext(1)]
		public UUIItem GetDraggableRootItem()
		{
			return base.GetRootItem();
		}

		// Token: 0x06037147 RID: 225607 RVA: 0x00F5F819 File Offset: 0x00F5DA19
		public void SetDraggableRotation(EDangoBrawlRotate rotate)
		{
		}

		// Token: 0x06037148 RID: 225608 RVA: 0x00F5F81B File Offset: 0x00F5DA1B
		public void SetDraggableActive(bool enabled)
		{
		}

		// Token: 0x06037149 RID: 225609 RVA: 0x00F5F81D File Offset: 0x00F5DA1D
		public void OnDragSourceBegin()
		{
			Action onDragBegin = this.OnDragBegin;
			if (onDragBegin != null)
			{
				onDragBegin();
			}
			this.IsDragProxyActive = true;
			DangoBrawlCombineGuideLineHost guideLineHost = this.GuideLineHost;
			if (guideLineHost == null)
			{
				return;
			}
			guideLineHost.SetReason(ECombineLineShowReason.Always, false);
		}

		// Token: 0x0603714A RID: 225610 RVA: 0x00F5F84C File Offset: 0x00F5DA4C
		public void OnDragSourceEnd()
		{
			this.IsDragProxyActive = false;
			if (this.MyUid > 0)
			{
				DangoBrawlItemViewRegistry registry = this.Registry;
				if (registry != null)
				{
					registry.RegisterLineOwner(this.MyUid, this);
				}
				DangoBrawlCombineGuideLineHost guideLineHost = this.GuideLineHost;
				if (guideLineHost != null)
				{
					guideLineHost.SetReason(ECombineLineShowReason.Always, !DangoBrawlViewManager.TryBlockIfLayerMode(false));
				}
			}
			Action onDragEnd = this.OnDragEnd;
			if (onDragEnd == null)
			{
				return;
			}
			onDragEnd();
		}

		// Token: 0x0603714B RID: 225611 RVA: 0x00F5F8AD File Offset: 0x00F5DAAD
		public int GetOwnerUid()
		{
			return this.MyUid;
		}

		// Token: 0x0603714C RID: 225612 RVA: 0x00F5F8B5 File Offset: 0x00F5DAB5
		public int GetOwnerConfigId()
		{
			return this.MyConfigId;
		}

		// Token: 0x0603714D RID: 225613 RVA: 0x00F5F8BD File Offset: 0x00F5DABD
		public UUIItem GetOwnerRootItem()
		{
			return base.GetRootItem();
		}

		// Token: 0x0603714E RID: 225614 RVA: 0x00F5F8C5 File Offset: 0x00F5DAC5
		public void NotifyAsPartner(int requesterUid, bool show)
		{
			DangoBrawlCombineGuideLineHost guideLineHost = this.GuideLineHost;
			if (guideLineHost == null)
			{
				return;
			}
			guideLineHost.SetPartnerReason(requesterUid, show);
		}

		// Token: 0x0603714F RID: 225615 RVA: 0x00F5F8D9 File Offset: 0x00F5DAD9
		public void RefreshLineAngles()
		{
			DangoBrawlCombineGuideLineHost guideLineHost = this.GuideLineHost;
			if (guideLineHost == null)
			{
				return;
			}
			guideLineHost.RefreshAngles();
		}

		// Token: 0x0401D1FD RID: 119293
		[Nullable(1)]
		private ActivityDangoBrawlData ActData;

		// Token: 0x0401D1FE RID: 119294
		private int ItemId = -1;

		// Token: 0x0401D1FF RID: 119295
		private int SlotIndex = -1;

		// Token: 0x0401D200 RID: 119296
		private bool IsSelected;

		// Token: 0x0401D201 RID: 119297
		private bool IsDragProxyActive;

		// Token: 0x0401D202 RID: 119298
		private bool IsDragging;

		// Token: 0x0401D203 RID: 119299
		[Nullable(1)]
		private readonly List<UUIItem> GridItems = new List<UUIItem>();

		// Token: 0x0401D204 RID: 119300
		[Nullable(1)]
		private readonly List<DangoBrawlGeneralStar> StarPanels = new List<DangoBrawlGeneralStar>();

		// Token: 0x0401D205 RID: 119301
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401D206 RID: 119302
		private TimerHandle GuideLineTickHandle;

		// Token: 0x0401D207 RID: 119303
		private DangoBrawlCombineGuideLineHost GuideLineHost;

		// Token: 0x0401D208 RID: 119304
		public Func<bool> IsRefreshFxPlaying;

		// Token: 0x0401D209 RID: 119305
		public Action OnDragBegin;

		// Token: 0x0401D20A RID: 119306
		public Action OnDragEnd;

		// Token: 0x0200B32B RID: 45867
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x040375CB RID: 226763
			TogSelf,
			// Token: 0x040375CC RID: 226764
			ContentGrid,
			// Token: 0x040375CD RID: 226765
			TemplatePnlGrid,
			// Token: 0x040375CE RID: 226766
			SprIcon,
			// Token: 0x040375CF RID: 226767
			Dragable,
			// Token: 0x040375D0 RID: 226768
			ContentStar,
			// Token: 0x040375D1 RID: 226769
			TemplateStar,
			// Token: 0x040375D2 RID: 226770
			ContentLine,
			// Token: 0x040375D3 RID: 226771
			TemplateLine,
			// Token: 0x040375D4 RID: 226772
			PnlSelect,
			// Token: 0x040375D5 RID: 226773
			SprIconMask
		}
	}
}
