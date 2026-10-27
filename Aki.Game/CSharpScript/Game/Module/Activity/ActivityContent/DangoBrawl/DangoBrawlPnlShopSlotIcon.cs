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
	// Token: 0x020067F7 RID: 26615
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlPnlShopSlotIcon : UiPanelBase, IDangoBrawlDraggableView, ICombineLineOwner
	{
		// Token: 0x1700971B RID: 38683
		// (get) Token: 0x060425C4 RID: 271812 RVA: 0x0101D2C5 File Offset: 0x0101B4C5
		private bool RefreshFxBlocking
		{
			get
			{
				Func<bool> isRefreshFxPlaying = this.IsRefreshFxPlaying;
				return isRefreshFxPlaying != null && isRefreshFxPlaying();
			}
		}

		// Token: 0x1700971C RID: 38684
		// (get) Token: 0x060425C5 RID: 271813 RVA: 0x0101D2D8 File Offset: 0x0101B4D8
		private DangoBrawlTouchController Touch
		{
			get
			{
				return DangoBrawlModel.Instance.GetTouchController();
			}
		}

		// Token: 0x1700971D RID: 38685
		// (get) Token: 0x060425C6 RID: 271814 RVA: 0x0101D2E4 File Offset: 0x0101B4E4
		private DangoBrawlItemViewRegistry Registry
		{
			get
			{
				return DangoBrawlModel.Instance.GetViewRegistry();
			}
		}

		// Token: 0x1700971E RID: 38686
		// (get) Token: 0x060425C7 RID: 271815 RVA: 0x0101D2F0 File Offset: 0x0101B4F0
		private UUITexture SprIconMask
		{
			get
			{
				return base.GetTexture(10);
			}
		}

		// Token: 0x060425C8 RID: 271816 RVA: 0x0101D2FC File Offset: 0x0101B4FC
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

		// Token: 0x060425C9 RID: 271817 RVA: 0x0101D491 File Offset: 0x0101B691
		protected override void OnStart()
		{
			this.BindEvents();
			this.StartLineTick();
		}

		// Token: 0x060425CA RID: 271818 RVA: 0x0101D49F File Offset: 0x0101B69F
		protected override void OnBeforeDestroy()
		{
			this.StopLineTick();
			this.UnbindEvents();
			this.ClearCombineGuideLines();
			this.ClearSequencePlayer();
		}

		// Token: 0x060425CB RID: 271819 RVA: 0x0101D4BC File Offset: 0x0101B6BC
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

		// Token: 0x060425CC RID: 271820 RVA: 0x0101D5F8 File Offset: 0x0101B7F8
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

		// Token: 0x060425CD RID: 271821 RVA: 0x0101D6EC File Offset: 0x0101B8EC
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

		// Token: 0x060425CE RID: 271822 RVA: 0x0101D748 File Offset: 0x0101B948
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

		// Token: 0x060425CF RID: 271823 RVA: 0x0101D7F9 File Offset: 0x0101B9F9
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

		// Token: 0x060425D0 RID: 271824 RVA: 0x0101D838 File Offset: 0x0101BA38
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

		// Token: 0x060425D1 RID: 271825 RVA: 0x0101D890 File Offset: 0x0101BA90
		private void ClearSequencePlayer()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x060425D2 RID: 271826 RVA: 0x0101D8AC File Offset: 0x0101BAAC
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

		// Token: 0x060425D3 RID: 271827 RVA: 0x0101D904 File Offset: 0x0101BB04
		private void SetStarContainerActive(bool val)
		{
			if (val)
			{
				PanelPos[] starPosList = DangoBrawlUtil.RotateStarPanelPosList(this.ItemId, EDangoBrawlRotate.Direction0);
				this.RefreshStars(starPosList);
			}
			base.GetItem(5).SetUIActive(val);
		}

		// Token: 0x060425D4 RID: 271828 RVA: 0x0101D935 File Offset: 0x0101BB35
		private float GetGridSize()
		{
			return base.GetItem(2).GetHeight();
		}

		// Token: 0x060425D5 RID: 271829 RVA: 0x0101D944 File Offset: 0x0101BB44
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

		// Token: 0x060425D6 RID: 271830 RVA: 0x0101DA28 File Offset: 0x0101BC28
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

		// Token: 0x060425D7 RID: 271831 RVA: 0x0101DB80 File Offset: 0x0101BD80
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

		// Token: 0x060425D8 RID: 271832 RVA: 0x0101DBD4 File Offset: 0x0101BDD4
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

		// Token: 0x060425D9 RID: 271833 RVA: 0x0101DCA8 File Offset: 0x0101BEA8
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

		// Token: 0x060425DA RID: 271834 RVA: 0x0101DD2A File Offset: 0x0101BF2A
		public void ApplyLayerMode(bool isLayerMode)
		{
			DangoBrawlCombineGuideLineHost guideLineHost = this.GuideLineHost;
			if (guideLineHost == null)
			{
				return;
			}
			guideLineHost.SetReason(ECombineLineShowReason.Always, !isLayerMode);
		}

		// Token: 0x060425DB RID: 271835 RVA: 0x0101DD44 File Offset: 0x0101BF44
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

		// Token: 0x060425DC RID: 271836 RVA: 0x0101DDA4 File Offset: 0x0101BFA4
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

		// Token: 0x060425DD RID: 271837 RVA: 0x0101DE3C File Offset: 0x0101C03C
		public void OnSell()
		{
			this.ClearCombineGuideLines();
			this.ClearSequencePlayer();
		}

		// Token: 0x060425DE RID: 271838 RVA: 0x0101DE4A File Offset: 0x0101C04A
		[NullableContext(1)]
		private void OnStartSequenceEvent(string sequenceStartEvent)
		{
		}

		// Token: 0x060425DF RID: 271839 RVA: 0x0101DE4C File Offset: 0x0101C04C
		[NullableContext(1)]
		private void OnEndSequenceEvent(string sequenceStartEvent)
		{
		}

		// Token: 0x060425E0 RID: 271840 RVA: 0x0101DE50 File Offset: 0x0101C050
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

		// Token: 0x060425E1 RID: 271841 RVA: 0x0101DECC File Offset: 0x0101C0CC
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

		// Token: 0x060425E2 RID: 271842 RVA: 0x0101DF4F File Offset: 0x0101C14F
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

		// Token: 0x060425E3 RID: 271843 RVA: 0x0101DF7D File Offset: 0x0101C17D
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

		// Token: 0x060425E4 RID: 271844 RVA: 0x0101DFB8 File Offset: 0x0101C1B8
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

		// Token: 0x060425E5 RID: 271845 RVA: 0x0101E058 File Offset: 0x0101C258
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

		// Token: 0x060425E6 RID: 271846 RVA: 0x0101E0D4 File Offset: 0x0101C2D4
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

		// Token: 0x060425E7 RID: 271847 RVA: 0x0101E178 File Offset: 0x0101C378
		private void StartLineTick()
		{
			this.StopLineTick();
			this.GuideLineTickHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnLineTick), 20f, 1f, null, null, true);
		}

		// Token: 0x060425E8 RID: 271848 RVA: 0x0101E1A9 File Offset: 0x0101C3A9
		private void StopLineTick()
		{
			if (this.GuideLineTickHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.GuideLineTickHandle);
				this.GuideLineTickHandle = null;
			}
		}

		// Token: 0x060425E9 RID: 271849 RVA: 0x0101E1CC File Offset: 0x0101C3CC
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

		// Token: 0x060425EA RID: 271850 RVA: 0x0101E23A File Offset: 0x0101C43A
		private void OnLineDataDirty()
		{
			DangoBrawlCombineGuideLineHost guideLineHost = this.GuideLineHost;
			if (guideLineHost == null)
			{
				return;
			}
			guideLineHost.RebuildShowing();
		}

		// Token: 0x060425EB RID: 271851 RVA: 0x0101E24C File Offset: 0x0101C44C
		private void OnLineBackpackModified(EDangoBrawlModifyType type, int uid)
		{
			DangoBrawlCombineGuideLineHost guideLineHost = this.GuideLineHost;
			if (guideLineHost == null)
			{
				return;
			}
			guideLineHost.RebuildShowing();
		}

		// Token: 0x060425EC RID: 271852 RVA: 0x0101E25E File Offset: 0x0101C45E
		private void OnLineBagOperated(EBagOpKind kind, int uid)
		{
			DangoBrawlCombineGuideLineHost guideLineHost = this.GuideLineHost;
			if (guideLineHost == null)
			{
				return;
			}
			guideLineHost.RebuildShowing();
		}

		// Token: 0x1700971F RID: 38687
		// (get) Token: 0x060425ED RID: 271853 RVA: 0x0101E270 File Offset: 0x0101C470
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

		// Token: 0x17009720 RID: 38688
		// (get) Token: 0x060425EE RID: 271854 RVA: 0x0101E29C File Offset: 0x0101C49C
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

		// Token: 0x17009721 RID: 38689
		// (get) Token: 0x060425EF RID: 271855 RVA: 0x0101E2C7 File Offset: 0x0101C4C7
		public EDangoBrawlTemplateType MyType
		{
			get
			{
				return EDangoBrawlTemplateType.Item;
			}
		}

		// Token: 0x17009722 RID: 38690
		// (get) Token: 0x060425F0 RID: 271856 RVA: 0x0101E2CA File Offset: 0x0101C4CA
		public DangoBrawlItemBase MyItemData
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060425F1 RID: 271857 RVA: 0x0101E2CD File Offset: 0x0101C4CD
		[NullableContext(1)]
		public UUIItem GetDraggableRootItem()
		{
			return base.GetRootItem();
		}

		// Token: 0x060425F2 RID: 271858 RVA: 0x0101E2D5 File Offset: 0x0101C4D5
		public void SetDraggableRotation(EDangoBrawlRotate rotate)
		{
		}

		// Token: 0x060425F3 RID: 271859 RVA: 0x0101E2D7 File Offset: 0x0101C4D7
		public void SetDraggableActive(bool enabled)
		{
		}

		// Token: 0x060425F4 RID: 271860 RVA: 0x0101E2D9 File Offset: 0x0101C4D9
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

		// Token: 0x060425F5 RID: 271861 RVA: 0x0101E308 File Offset: 0x0101C508
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

		// Token: 0x060425F6 RID: 271862 RVA: 0x0101E369 File Offset: 0x0101C569
		public int GetOwnerUid()
		{
			return this.MyUid;
		}

		// Token: 0x060425F7 RID: 271863 RVA: 0x0101E371 File Offset: 0x0101C571
		public int GetOwnerConfigId()
		{
			return this.MyConfigId;
		}

		// Token: 0x060425F8 RID: 271864 RVA: 0x0101E379 File Offset: 0x0101C579
		public UUIItem GetOwnerRootItem()
		{
			return base.GetRootItem();
		}

		// Token: 0x060425F9 RID: 271865 RVA: 0x0101E381 File Offset: 0x0101C581
		public void NotifyAsPartner(int requesterUid, bool show)
		{
			DangoBrawlCombineGuideLineHost guideLineHost = this.GuideLineHost;
			if (guideLineHost == null)
			{
				return;
			}
			guideLineHost.SetPartnerReason(requesterUid, show);
		}

		// Token: 0x060425FA RID: 271866 RVA: 0x0101E395 File Offset: 0x0101C595
		public void RefreshLineAngles()
		{
			DangoBrawlCombineGuideLineHost guideLineHost = this.GuideLineHost;
			if (guideLineHost == null)
			{
				return;
			}
			guideLineHost.RefreshAngles();
		}

		// Token: 0x040229A0 RID: 141728
		[Nullable(1)]
		private ActivityDangoBrawlData ActData;

		// Token: 0x040229A1 RID: 141729
		private int ItemId = -1;

		// Token: 0x040229A2 RID: 141730
		private int SlotIndex = -1;

		// Token: 0x040229A3 RID: 141731
		private bool IsSelected;

		// Token: 0x040229A4 RID: 141732
		private bool IsDragProxyActive;

		// Token: 0x040229A5 RID: 141733
		private bool IsDragging;

		// Token: 0x040229A6 RID: 141734
		[Nullable(1)]
		private readonly List<UUIItem> GridItems = new List<UUIItem>();

		// Token: 0x040229A7 RID: 141735
		[Nullable(1)]
		private readonly List<DangoBrawlGeneralStar> StarPanels = new List<DangoBrawlGeneralStar>();

		// Token: 0x040229A8 RID: 141736
		private UiSequencePlayer SequencePlayer;

		// Token: 0x040229A9 RID: 141737
		private TimerHandle GuideLineTickHandle;

		// Token: 0x040229AA RID: 141738
		private DangoBrawlCombineGuideLineHost GuideLineHost;

		// Token: 0x040229AB RID: 141739
		public Func<bool> IsRefreshFxPlaying;

		// Token: 0x040229AC RID: 141740
		public Action OnDragBegin;

		// Token: 0x040229AD RID: 141741
		public Action OnDragEnd;

		// Token: 0x0200C95E RID: 51550
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403CCDE RID: 249054
			TogSelf,
			// Token: 0x0403CCDF RID: 249055
			ContentGrid,
			// Token: 0x0403CCE0 RID: 249056
			TemplatePnlGrid,
			// Token: 0x0403CCE1 RID: 249057
			SprIcon,
			// Token: 0x0403CCE2 RID: 249058
			Dragable,
			// Token: 0x0403CCE3 RID: 249059
			ContentStar,
			// Token: 0x0403CCE4 RID: 249060
			TemplateStar,
			// Token: 0x0403CCE5 RID: 249061
			ContentLine,
			// Token: 0x0403CCE6 RID: 249062
			TemplateLine,
			// Token: 0x0403CCE7 RID: 249063
			PnlSelect,
			// Token: 0x0403CCE8 RID: 249064
			SprIconMask
		}
	}
}
