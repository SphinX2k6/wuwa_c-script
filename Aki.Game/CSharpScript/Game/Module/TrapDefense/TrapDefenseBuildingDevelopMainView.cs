using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AE2 RID: 19170
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBuildingDevelopMainView : UiViewBase
	{
		// Token: 0x06031A6F RID: 203375 RVA: 0x00B8572C File Offset: 0x00B8392C
		public TrapDefenseBuildingDevelopMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06031A70 RID: 203376 RVA: 0x00B85784 File Offset: 0x00B83984
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickReset));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031A71 RID: 203377 RVA: 0x00B85934 File Offset: 0x00B83B34
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseBuildingDevelopMainView.<OnBeforeStartAsync>d__35 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBuildingDevelopMainView.<OnBeforeStartAsync>d__35>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031A72 RID: 203378 RVA: 0x00B85978 File Offset: 0x00B83B78
		protected override void OnStart()
		{
			this.ScrollView = new GenericScrollViewNew<TrapDefenseBuildingDevelopTypeItem, TrapDefenseBuildingTypeData>(base.GetScrollViewWithScrollbar(1), new Func<TrapDefenseBuildingDevelopTypeItem>(this.CreateItemGrid), null, false, null);
			this.CreateTabListData();
			this.LongPressTime = (float)TrapDefenseConfig.Instance.GetScrollerPressTime();
			this.ScrollerMoveDistance = (float)TrapDefenseConfig.Instance.GetScrollerMoveDistance();
			this.BeforeLongPressTime = (float)TrapDefenseConfig.Instance.GetBeforeScrollerLongPressTime();
			bool uiactive = !this.IsInDungeon && TrapDefenseModel.Instance.ViewModelBuildingDevelop.GetCanAllReset();
			UUIButtonComponent button = base.GetButton(3);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(uiactive);
			}
			if (this.IsInDungeon)
			{
				this.BottomDragLogic = this.BottomItem.InitBottomDragLogic();
				this.BottomItemList = this.BottomItem.InitBottomDragItem();
				for (int i = 0; i < this.BottomDragLogic.Count; i++)
				{
					CommonDragItemLogic<TrapDefenseBuildingDevelopDragDataItem, TrapDefenseBuildingDevelopItemData> commonDragItemLogic = this.BottomDragLogic[i];
					TrapDefenseBuildingDevelopBottomInfoItem @object = this.BottomItemList[i];
					commonDragItemLogic.SetOnDragAnimationStartFunction(new Action<int>(@object.OnDragBegin));
					commonDragItemLogic.SetOnDragAnimationEndFunction(new Action<int>(@object.OnDragEnd));
					commonDragItemLogic.SetOnOverlayCallBack(new Action<int>(@object.OnItemOverlay));
					commonDragItemLogic.SetOnUnOverlayCallBack(new Action<int>(@object.OnItemUnOverlay));
					commonDragItemLogic.SetMoveToScrollViewCallBack(new Action<int>(@object.OnScrollToScrollViewEvent));
					commonDragItemLogic.SetRemoveFromScrollViewCallBack(new Action<int>(@object.OnRemoveFromScrollViewEvent));
				}
				foreach (CommonDragItemLogic<TrapDefenseBuildingDevelopDragDataItem, TrapDefenseBuildingDevelopItemData> commonDragItemLogic2 in this.BottomDragLogic)
				{
					commonDragItemLogic2.SetOnClickCallBack(new Action<int>(this.OnClickAndRefreshView));
					commonDragItemLogic2.SetOnClickFailCallBack(new Action<int>(this.OnClickFail));
					commonDragItemLogic2.SetDragCheckItem(this.BottomDragLogic);
					commonDragItemLogic2.SetDragSuccessCallBack(new Action<TrapDefenseBuildingDevelopDragDataItem, TrapDefenseBuildingDevelopDragDataItem, bool>(this.OnDragEndCallBack));
					commonDragItemLogic2.SetPointerDownCallBack(new Action<int>(this.OnStartDragCallBack));
					commonDragItemLogic2.SetOnBeginDragCall(new Action<int>(this.OnBeginDrag));
					commonDragItemLogic2.SetEndDragWhenOnScrollViewCallBack(new Action<int, TrapDefenseBuildingDevelopItemData>(this.OnMoveToScrollViewDragEndCallBack));
				}
				CommonDragItemLogic<TrapDefenseBuildingDevelopDragDataItem, TrapDefenseBuildingDevelopItemData> dragLogic = this.DragLogic;
				if (dragLogic != null)
				{
					dragLogic.SetDragCheckItem(this.BottomDragLogic);
				}
				ITrapDefenseDevelopOpenParam trapDefenseDevelopOpenParam = this.OpenParam as ITrapDefenseDevelopOpenParam;
				if (TrapDefenseModel.Instance.ViewModelBuildingDevelop.GetSlotData()[trapDefenseDevelopOpenParam.SelectedIndex].GetSlotData() == null)
				{
					this.SetCurrentSelectBottomIndex(trapDefenseDevelopOpenParam.SelectedIndex);
				}
				else
				{
					TrapDefenseBuildingSlotData firstEmptySlot = TrapDefenseModel.Instance.ViewModelBuildingDevelop.GetFirstEmptySlot();
					this.SetCurrentSelectBottomIndex((firstEmptySlot == null) ? trapDefenseDevelopOpenParam.SelectedIndex : firstEmptySlot.GetIndex());
				}
			}
			EventSystem.Instance.Emit<bool>(EEventName.TrapDefenseBuildingDevelopMainViewStart, this.IsInDungeon);
		}

		// Token: 0x06031A73 RID: 203379 RVA: 0x00B85C3C File Offset: 0x00B83E3C
		protected override void OnAfterShow()
		{
			foreach (CommonDragItemLogic<TrapDefenseBuildingDevelopDragDataItem, TrapDefenseBuildingDevelopItemData> commonDragItemLogic in this.BottomDragLogic)
			{
				commonDragItemLogic.SetScrollViewItem(base.GetScrollViewWithScrollbar(1).RootUIComp);
			}
		}

		// Token: 0x06031A74 RID: 203380 RVA: 0x00B85CA0 File Offset: 0x00B83EA0
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<TrapDefenseBuildingDevelopItemData>(EEventName.TrapDefenseBuildingDevelopSelectUpdate, new Action<TrapDefenseBuildingDevelopItemData>(this.OnClickItem));
			EventSystem.Instance.Add<TrapDefenseBuildingDevelopItemData>(EEventName.TrapDefenseBuildingBottomSelectUpdate, new Action<TrapDefenseBuildingDevelopItemData>(this.OnBottomClick));
			EventSystem.Instance.Add<TrapDefenseBuildingDevelopItemData>(EEventName.TrapDefenseBuildingPreviewSelectUpdate, new Action<TrapDefenseBuildingDevelopItemData>(this.OnPreviewClick));
			EventSystem.Instance.Add<TrapDefenseBuildingDevelopItemData>(EEventName.TrapDefenseOnDevelopUpdate, new Action<TrapDefenseBuildingDevelopItemData>(this.OnDataUpdate));
			EventSystem.Instance.Add(EEventName.TrapDefenseOnDevelopResetAll, new Action(this.OnResetAll));
			EventSystem.Instance.Add(EEventName.TrapDefenseOnSlotUpdate, new Action(this.OnUpdateSlot));
			EventSystem.Instance.Add(EEventName.TrapDefenseLevelUpPointUpdate, new Action(this.RefreshCurrency));
			EventSystem.Instance.Add(EEventName.TrapDefenseOnBranchUpdate, new Action(this.OnOrganNetUpdate));
		}

		// Token: 0x06031A75 RID: 203381 RVA: 0x00B85D90 File Offset: 0x00B83F90
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<TrapDefenseBuildingDevelopItemData>(EEventName.TrapDefenseBuildingDevelopSelectUpdate, new Action<TrapDefenseBuildingDevelopItemData>(this.OnClickItem));
			EventSystem.Instance.Remove<TrapDefenseBuildingDevelopItemData>(EEventName.TrapDefenseBuildingBottomSelectUpdate, new Action<TrapDefenseBuildingDevelopItemData>(this.OnBottomClick));
			EventSystem.Instance.Remove<TrapDefenseBuildingDevelopItemData>(EEventName.TrapDefenseBuildingPreviewSelectUpdate, new Action<TrapDefenseBuildingDevelopItemData>(this.OnPreviewClick));
			EventSystem.Instance.Remove<TrapDefenseBuildingDevelopItemData>(EEventName.TrapDefenseOnDevelopUpdate, new Action<TrapDefenseBuildingDevelopItemData>(this.OnDataUpdate));
			EventSystem.Instance.Remove(EEventName.TrapDefenseOnDevelopResetAll, new Action(this.OnResetAll));
			EventSystem.Instance.Remove(EEventName.TrapDefenseOnSlotUpdate, new Action(this.OnUpdateSlot));
			EventSystem.Instance.Remove(EEventName.TrapDefenseLevelUpPointUpdate, new Action(this.RefreshCurrency));
			EventSystem.Instance.Remove(EEventName.TrapDefenseOnBranchUpdate, new Action(this.OnOrganNetUpdate));
		}

		// Token: 0x06031A76 RID: 203382 RVA: 0x00B85E7D File Offset: 0x00B8407D
		protected override void OnBeforeShow()
		{
			this.RefreshCurrency();
			this.RefreshTabListAsync();
		}

		// Token: 0x06031A77 RID: 203383 RVA: 0x00B85E8C File Offset: 0x00B8408C
		protected override void OnBeforeDestroy()
		{
			TrapDefenseModel.Instance.ViewModelBuildingDevelop.SetCurRecommendLevel(null);
			this.ClearDragClickTick();
			this.ClearCheckPointerUpTick();
			this.TabComponent = null;
			this.DetailInfo = null;
			this.BottomItem = null;
			if (this.IsInDungeon)
			{
				TrapDefenseController.Instance.RefreshTrapDefenseMainView();
			}
		}

		// Token: 0x06031A78 RID: 203384 RVA: 0x00B85EDC File Offset: 0x00B840DC
		protected void InitTabComponent()
		{
			this.TabComponent = new TabComponentWithCaptionItem<CommonTabItem>(base.GetItem(0), new CommonTabComponentData<CommonTabItem>(new Func<UUIItem, int?, CommonTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData)), new Action(this.OnCloseClicked), false);
			this.LastClickTime = 0.0;
			this.TabComponent.SetCanChange(new Func<int, bool?, bool>(this.CanToggleChange));
			this.TabComponent.SetHelpButtonShowState(true);
			this.TabComponent.SetHelpButtonCallBack(delegate
			{
				HelpController.Instance.OpenHelpById(403);
			});
		}

		// Token: 0x06031A79 RID: 203385 RVA: 0x00B85F90 File Offset: 0x00B84190
		protected UniTask InitDragItem()
		{
			TrapDefenseBuildingDevelopMainView.<InitDragItem>d__43 <InitDragItem>d__;
			<InitDragItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDragItem>d__.<>4__this = this;
			<InitDragItem>d__.<>1__state = -1;
			<InitDragItem>d__.<>t__builder.Start<TrapDefenseBuildingDevelopMainView.<InitDragItem>d__43>(ref <InitDragItem>d__);
			return <InitDragItem>d__.<>t__builder.Task;
		}

		// Token: 0x06031A7A RID: 203386 RVA: 0x00B85FD4 File Offset: 0x00B841D4
		private void OnGridPointerDown(TrapDefenseBuildingDevelopTypeGridItem item, TrapDefenseBuildingDevelopItemData data)
		{
			if (!this.IsInDungeon)
			{
				return;
			}
			this.ClearDragClickTick();
			this.PressTime = 0f;
			this.FillPressTime = 0f;
			this.CheckState = true;
			this.CurrentPressItem = item;
			FVector worldPointInPlane = LguiEventSystemManager.Instance.GetPointerEventData(0, false).GetWorldPointInPlane();
			this.OnPressPositionX = worldPointInPlane.X;
			this.OnPressPositionY = worldPointInPlane.Z;
			this.AfterLongPressState = false;
			this.DragItem.UpdateItem(data);
			this.DragLogic.Refresh(data);
			this.SetPressItemShowState(true);
			this.SetPressItemAlpha(0f);
			this.SetBarAmount(0f);
			this.DragClickTick = TickSystem.Instance.Add(new Action<float>(this.OnDragTick), "TrapDefenseDevelopDragTick", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
		}

		// Token: 0x06031A7B RID: 203387 RVA: 0x00B860A4 File Offset: 0x00B842A4
		private void OnGridPointerUp(TrapDefenseBuildingDevelopTypeGridItem item, TrapDefenseBuildingDevelopItemData data)
		{
			if (!this.IsInDungeon)
			{
				return;
			}
			this.ClearDragClickTick();
			base.GetScrollViewWithScrollbar(1).SetEnable(true);
			CommonDragItemLogic<TrapDefenseBuildingDevelopDragDataItem, TrapDefenseBuildingDevelopItemData> dragLogic = this.DragLogic;
			if (dragLogic != null)
			{
				dragLogic.ClearStayingItem();
			}
			this.DragItem.SetUiActive(false);
			this.SetPressItemShowState(false);
			this.CurrentDragIndex = 999;
			if (item == null && data == null)
			{
				this.ResetPosition(true);
			}
		}

		// Token: 0x06031A7C RID: 203388 RVA: 0x00B8610C File Offset: 0x00B8430C
		private void RefreshLongPressItemPosition()
		{
			FVector? pointerEventDataPosition = LguiEventSystemManager.Instance.GetPointerEventDataPosition(0);
			Vector2D vector2D = Vector2D.Create((double)pointerEventDataPosition.Value.X, (double)pointerEventDataPosition.Value.Y);
			Vector2D vector2D2 = vector2D;
			ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
			FVector2D fvector2D = vector2D.ToUeVector2D(false);
			vector2D2.FromUeVector2D(canvasScaler.ConvertPositionFromViewportToLGUICanvas(fvector2D));
			float num = TrapDefenseConfig.Instance.GetScrollerOffsetX() * (float)TrapDefenseConfig.Instance.GetScrollerOffsetXDir();
			float num2 = TrapDefenseConfig.Instance.GetScrollerOffsetY() * (float)TrapDefenseConfig.Instance.GetScrollerOffsetYDir();
			double num3 = vector2D.X + (double)num;
			double num4 = vector2D.Y + (double)num2;
			UUIItem item = base.GetItem(7);
			FVector fvector = new FVector((float)num3, (float)num4, 0f);
			item.SetLGUISpaceAbsolutePosition(fvector);
		}

		// Token: 0x06031A7D RID: 203389 RVA: 0x00B861D3 File Offset: 0x00B843D3
		private void ClearDragClickTick()
		{
			if (this.DragClickTick != -1)
			{
				TickSystem.Instance.Remove(this.DragClickTick);
				this.DragClickTick = -1;
			}
		}

		// Token: 0x06031A7E RID: 203390 RVA: 0x00B861F6 File Offset: 0x00B843F6
		private void SetPressItemShowState(bool isShow)
		{
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isShow);
		}

		// Token: 0x06031A7F RID: 203391 RVA: 0x00B8620A File Offset: 0x00B8440A
		private void SetPressItemAlpha(float alpha)
		{
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetAlpha(alpha);
			}
			this.LongPressItemAlpha = alpha;
		}

		// Token: 0x06031A80 RID: 203392 RVA: 0x00B86226 File Offset: 0x00B84426
		private void SetBarAmount(float value)
		{
			UUISprite sprite = base.GetSprite(9);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(value);
		}

		// Token: 0x06031A81 RID: 203393 RVA: 0x00B8623C File Offset: 0x00B8443C
		private void OnDragTick(float _)
		{
			if (!this.IsInDungeon)
			{
				this.ClearDragClickTick();
				return;
			}
			this.PressTime += Time.Instance.DeltaTime;
			if (this.AfterLongPressState)
			{
				this.DragLogic.TickCheckDrag();
			}
			if (!this.CheckState)
			{
				return;
			}
			if (this.PressTime > this.BeforeLongPressTime && this.LongPressItemAlpha == 0f)
			{
				this.RefreshLongPressItemPosition();
				this.SetPressItemAlpha(1f);
				this.FillPressTime = 0f;
			}
			if (this.LongPressItemAlpha > 0f)
			{
				this.FillPressTime += Time.Instance.DeltaTime;
			}
			if (this.CurrentPressItem != null)
			{
				FVector worldPointInPlane = LguiEventSystemManager.Instance.GetPointerEventData(0, false).GetWorldPointInPlane();
				float value = this.OnPressPositionX - worldPointInPlane.X;
				float value2 = this.OnPressPositionY - worldPointInPlane.Z;
				if (Math.Abs(value) + Math.Abs(value2) > this.ScrollerMoveDistance)
				{
					this.SetPressItemShowState(false);
					this.CheckState = false;
				}
			}
			if (this.FillPressTime > this.LongPressTime)
			{
				base.GetScrollViewWithScrollbar(1).SetEnable(false);
				this.SetPressItemShowState(false);
				AudioSystem.Instance.PostEvent("play_ui_tafang_switch_mecha_drag");
				this.CheckState = false;
				this.AfterLongPressState = true;
				this.DragItem.SetUiActive(true);
				this.DragLogic.StartDragState();
				this.DragLogic.SetItemToPointerPosition();
				this.OnStartDragCallBack(0);
				this.DragLogic.SetDragItemHierarchyMax();
				this.CheckPointerUpTick = TickSystem.Instance.Add(new Action<float>(this.CheckPointerItemMove), "TrapDefenseDevelopDragTick", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
				return;
			}
			this.SetBarAmount(this.FillPressTime / this.LongPressTime);
		}

		// Token: 0x06031A82 RID: 203394 RVA: 0x00B863F4 File Offset: 0x00B845F4
		private void CheckPointerItemMove(float _)
		{
			bool flag = LguiEventSystemManager.Instance.IsPressComponentIsValid(0);
			bool flag2 = LguiEventSystemManager.Instance.IsNowTriggerPressed(0);
			TrapDefenseBuildingDevelopDragDataItem stayingItem = this.DragLogic.GetStayingItem();
			if (!flag && !flag2)
			{
				if (stayingItem == null)
				{
					this.OnGridPointerUp(null, null);
				}
				else
				{
					this.OnDragEndCallBack(this.DragLogic.GetItem(), this.DragLogic.GetStayingItem(), false);
					this.OnGridPointerUp(null, null);
				}
				this.ClearCheckPointerUpTick();
			}
		}

		// Token: 0x06031A83 RID: 203395 RVA: 0x00B86461 File Offset: 0x00B84661
		private void ClearCheckPointerUpTick()
		{
			if (this.CheckPointerUpTick != -1)
			{
				TickSystem.Instance.Remove(this.CheckPointerUpTick);
				this.CheckPointerUpTick = -1;
			}
		}

		// Token: 0x06031A84 RID: 203396 RVA: 0x00B86484 File Offset: 0x00B84684
		protected void OnBeginDrag(int index)
		{
			foreach (CommonDragItemLogic<TrapDefenseBuildingDevelopDragDataItem, TrapDefenseBuildingDevelopItemData> commonDragItemLogic in this.BottomDragLogic)
			{
				commonDragItemLogic.StartDragState();
			}
			foreach (CommonDragItemLogic<TrapDefenseBuildingDevelopDragDataItem, TrapDefenseBuildingDevelopItemData> commonDragItemLogic2 in this.BottomDragLogic)
			{
				if (TrapDefenseModel.Instance.ViewModelBuildingDevelop.CheckIfCurrentDragIndex(commonDragItemLogic2.GetCurrentIndex()))
				{
					commonDragItemLogic2.SetDragItemHierarchyMax();
				}
			}
			this.BottomDragLogic[index].SetItemToPointerPosition();
			this.CurrentDragIndex = index;
		}

		// Token: 0x06031A85 RID: 203397 RVA: 0x00B86544 File Offset: 0x00B84744
		protected void OnDragEndCallBack(TrapDefenseBuildingDevelopDragDataItem self, TrapDefenseBuildingDevelopDragDataItem target, bool _)
		{
			if (target == null)
			{
				this.ResetPosition(true);
				return;
			}
			int currentIndex = target.GetCurrentIndex();
			AudioSystem.Instance.PostEvent("play_ui_tafang_switch_mecha_equip");
			if (self.GetCurrentIndex() == -1)
			{
				UUIItem item = base.GetItem(6);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				this.ResetPosition(true);
				List<TrapDefenseBuildingSlotData> slotData = TrapDefenseModel.Instance.ViewModelBuildingDevelop.GetSlotData();
				if (self.GetCurrentData() == slotData[currentIndex].GetSlotData())
				{
					return;
				}
			}
			TrapDefenseModel.Instance.ViewModelBuildingDevelop.EquipOrgan(currentIndex, self.GetCurrentData()).ContinueWith(delegate()
			{
				this.ResetPosition(true);
				UUIItem item2 = base.GetItem(6);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(false);
			});
		}

		// Token: 0x06031A86 RID: 203398 RVA: 0x00B865E4 File Offset: 0x00B847E4
		private void OnMoveToScrollViewDragEndCallBack(int index, TrapDefenseBuildingDevelopItemData data)
		{
			this.PressTime = 0f;
			this.CurrentDragIndex = 999;
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			TrapDefenseModel.Instance.ViewModelBuildingDevelop.EquipOrgan(index, data).ContinueWith(delegate()
			{
				this.ResetPosition(true);
				this.BottomItemList[index].ResetPosition();
			});
		}

		// Token: 0x06031A87 RID: 203399 RVA: 0x00B86658 File Offset: 0x00B84858
		protected void OnStartDragCallBack(int _)
		{
			base.GetItem(6).SetUIActive(true);
			foreach (CommonDragItemLogic<TrapDefenseBuildingDevelopDragDataItem, TrapDefenseBuildingDevelopItemData> commonDragItemLogic in this.BottomDragLogic)
			{
				commonDragItemLogic.StartClickCheckTimer();
			}
		}

		// Token: 0x06031A88 RID: 203400 RVA: 0x00B866B8 File Offset: 0x00B848B8
		protected void OnClickAndRefreshView(int index)
		{
			base.GetItem(6).SetUIActive(false);
			if (this.CurrentSelectedBottomIndex != index)
			{
				AudioSystem.Instance.PostEvent("play_ui_tafang_switch_mecha_click");
			}
			this.SetCurrentSelectBottomIndex(index);
		}

		// Token: 0x06031A89 RID: 203401 RVA: 0x00B866E8 File Offset: 0x00B848E8
		private void SetCurrentSelectBottomIndex(int index)
		{
			if (this.CurrentSelectedBottomIndex == index)
			{
				return;
			}
			this.CurrentSelectedBottomIndex = index;
			this.BottomItemList[this.CurrentSelectedBottomIndex].OnClickedItem();
			for (int i = 0; i < this.BottomItemList.Count; i++)
			{
				this.BottomItemList[i].SetSelected(this.CurrentSelectedBottomIndex == i);
			}
		}

		// Token: 0x06031A8A RID: 203402 RVA: 0x00B8674C File Offset: 0x00B8494C
		protected void OnClickFail(int index)
		{
			this.ResetPosition(true);
		}

		// Token: 0x06031A8B RID: 203403 RVA: 0x00B86758 File Offset: 0x00B84958
		private void ResetPosition(bool playBackToStartPositionAnimation = true)
		{
			foreach (CommonDragItemLogic<TrapDefenseBuildingDevelopDragDataItem, TrapDefenseBuildingDevelopItemData> commonDragItemLogic in this.BottomDragLogic)
			{
				commonDragItemLogic.ResetPosition();
				commonDragItemLogic.SetActive(true);
			}
			foreach (TrapDefenseBuildingDevelopBottomInfoItem trapDefenseBuildingDevelopBottomInfoItem in this.BottomItemList)
			{
				trapDefenseBuildingDevelopBottomInfoItem.ResetPosition();
			}
			base.GetItem(6).SetUIActive(false);
		}

		// Token: 0x06031A8C RID: 203404 RVA: 0x00B86800 File Offset: 0x00B84A00
		protected void UpdateDetail(TrapDefenseBuildingDevelopItemData data, bool needAnim = true)
		{
			if (needAnim)
			{
				base.PlaySequence("Switch", null, false);
			}
			this.DetailInfo.UpdateDetail(data);
		}

		// Token: 0x06031A8D RID: 203405 RVA: 0x00B86820 File Offset: 0x00B84A20
		private void RefreshCurrency()
		{
			TrapDefenseBaseConfig? activityConfig = TrapDefenseConfig.Instance.GetActivityConfig();
			if (activityConfig == null || this.IsInDungeon)
			{
				return;
			}
			int techPointItem = activityConfig.Value.TechPointItem;
			int remainPoints = TrapDefenseModel.Instance.ViewModelBuildingDevelop.RemainPoints;
			CommonCurrencyItem costBtn = this.CostBtn;
			if (costBtn == null)
			{
				return;
			}
			costBtn.RefreshTemp(techPointItem, remainPoints.ToString());
		}

		// Token: 0x06031A8E RID: 203406 RVA: 0x00B86882 File Offset: 0x00B84A82
		private void OnOrganNetUpdate()
		{
			this.UpdateDetail(this.CurSelectedData, true);
		}

		// Token: 0x06031A8F RID: 203407 RVA: 0x00B86891 File Offset: 0x00B84A91
		private void OnCloseClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x06031A90 RID: 203408 RVA: 0x00B8689C File Offset: 0x00B84A9C
		protected bool CanToggleChange(int index, bool? _)
		{
			if (Info.Instance.IsInGamepad())
			{
				return true;
			}
			int? intConfig = ConfigCommonParamById.GetIntConfig("panel_interval_time");
			if (this.LastClickTime != 0.0)
			{
				double num = Time.Instance.Now - this.LastClickTime;
				int? num2 = intConfig;
				double? num3 = (num2 != null) ? new double?((double)num2.GetValueOrDefault()) : null;
				if (!(num >= num3.GetValueOrDefault() & num3 != null))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06031A91 RID: 203409 RVA: 0x00B86921 File Offset: 0x00B84B21
		private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x06031A92 RID: 203410 RVA: 0x00B86928 File Offset: 0x00B84B28
		private void ToggleCallBack(int index)
		{
			this.LastClickTime = Time.Instance.Now;
			this.CurSelectIndex = index;
			List<TrapDefenseBuildingTypeData> dataList = this.DataListMap[(ETrapDefenseBuildingDevelopTab)index];
			foreach (TrapDefenseBuildingTypeData trapDefenseBuildingTypeData in this.DataListMap[ETrapDefenseBuildingDevelopTab.All])
			{
				trapDefenseBuildingTypeData.CurSelectedData = null;
				if (trapDefenseBuildingTypeData.TempSelectedData != null)
				{
					this.CurSelectedData = trapDefenseBuildingTypeData.TempSelectedData;
					trapDefenseBuildingTypeData.TempSelectedData = null;
				}
			}
			if (this.CurSelectedData != null)
			{
				bool flag = false;
				foreach (TrapDefenseBuildingTypeData trapDefenseBuildingTypeData2 in dataList)
				{
					if (trapDefenseBuildingTypeData2.GetDataList().Contains(this.CurSelectedData))
					{
						trapDefenseBuildingTypeData2.CurSelectedData = this.CurSelectedData;
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					this.CurSelectedData = null;
				}
			}
			if (this.CurSelectedData == null && this.IsInDungeon)
			{
				TrapDefenseBuildingDevelopItemData trapDefenseBuildingDevelopItemData = this.BottomItem.CheckCurSlotEmpty();
				if (trapDefenseBuildingDevelopItemData != null)
				{
					foreach (TrapDefenseBuildingTypeData trapDefenseBuildingTypeData3 in dataList)
					{
						if (trapDefenseBuildingTypeData3.GetDataList().Contains(trapDefenseBuildingDevelopItemData))
						{
							trapDefenseBuildingTypeData3.CurSelectedData = trapDefenseBuildingDevelopItemData;
							this.SetCurSelectedData(trapDefenseBuildingDevelopItemData);
						}
					}
				}
			}
			if (this.CurSelectedData == null)
			{
				TrapDefenseBuildingDevelopItemData curSelectedData = dataList[0].GetDataList()[0];
				this.SetCurSelectedData(curSelectedData);
			}
			GenericScrollViewNew<TrapDefenseBuildingDevelopTypeItem, TrapDefenseBuildingTypeData> scrollView = this.ScrollView;
			if (scrollView != null)
			{
				scrollView.RefreshByData(dataList, delegate
				{
					TrapDefenseBuildingDevelopTypeItem selectedTab = null;
					List<TrapDefenseBuildingDevelopTypeItem> scrollItemList = this.ScrollView.GetScrollItemList();
					for (int i = 0; i < scrollItemList.Count; i++)
					{
						TrapDefenseBuildingDevelopTypeItem trapDefenseBuildingDevelopTypeItem = scrollItemList[i];
						TrapDefenseBuildingTypeData trapDefenseBuildingTypeData4 = dataList[i];
						trapDefenseBuildingDevelopTypeItem.SetInitSelect();
						trapDefenseBuildingDevelopTypeItem.SetScrollParent(null);
						if (trapDefenseBuildingTypeData4.CurSelectedData != null)
						{
							selectedTab = trapDefenseBuildingDevelopTypeItem;
						}
					}
					if (selectedTab != null)
					{
						if (!selectedTab.GetChildRefreshed())
						{
							selectedTab.SetScrollParent(this.GetScrollViewWithScrollbar(1));
							return;
						}
						TTimerAction <>9__2;
						TimerSystem.Instance.Next(delegate(float _)
						{
							TimerSystemInstance instance = TimerSystem.Instance;
							TTimerAction action;
							if ((action = <>9__2) == null)
							{
								action = (<>9__2 = delegate(float _)
								{
									FVector2D fvector2D = new FVector2D();
									this.GetScrollViewWithScrollbar(1).ScrollToTop(ref fvector2D, selectedTab.GetRootItem(), false);
								});
							}
							instance.Next(action, null, null);
						}, null, null);
					}
				}, true);
			}
			this.UpdateDetail(this.CurSelectedData, true);
		}

		// Token: 0x06031A93 RID: 203411 RVA: 0x00B86B20 File Offset: 0x00B84D20
		private CommonTabData GetCommonData(int index)
		{
			ITrapDefenseBuildingDevelopTabData trapDefenseBuildingDevelopTabData = this.TabDataList[index];
			return new CommonTabData(trapDefenseBuildingDevelopTabData.Icon, new CommonTabTitleData(trapDefenseBuildingDevelopTabData.TabName, Array.Empty<object>()), null);
		}

		// Token: 0x06031A94 RID: 203412 RVA: 0x00B86B58 File Offset: 0x00B84D58
		private void OnClickItem(TrapDefenseBuildingDevelopItemData data)
		{
			List<TrapDefenseBuildingDevelopTypeItem> scrollItemList = this.ScrollView.GetScrollItemList();
			this.SetCurSelectedData(data);
			foreach (TrapDefenseBuildingDevelopTypeItem trapDefenseBuildingDevelopTypeItem in scrollItemList)
			{
				trapDefenseBuildingDevelopTypeItem.CheckSelectedIsInTypeItem(data);
			}
			this.UpdateDetail(data, true);
			if (this.IsInDungeon)
			{
				this.BottomItem.SetMenuSelectedData(data);
			}
		}

		// Token: 0x06031A95 RID: 203413 RVA: 0x00B86BD4 File Offset: 0x00B84DD4
		private void OnBottomClick(TrapDefenseBuildingDevelopItemData data)
		{
			List<TrapDefenseBuildingDevelopTypeItem> scrollItemList = this.ScrollView.GetScrollItemList();
			this.SetCurSelectedData(null);
			bool flag = false;
			foreach (TrapDefenseBuildingDevelopTypeItem trapDefenseBuildingDevelopTypeItem in scrollItemList)
			{
				if (trapDefenseBuildingDevelopTypeItem.CheckBottomItemIsInTypeItem(data))
				{
					flag = true;
					FVector2D fvector2D = new FVector2D();
					base.GetScrollViewWithScrollbar(1).ScrollToTop(ref fvector2D, trapDefenseBuildingDevelopTypeItem.GetRootItem(), false);
					this.SetCurSelectedData(data);
				}
			}
			this.BottomItem.SetMenuSelectedData(data);
			if (flag)
			{
				this.UpdateDetail(data, true);
				return;
			}
			this.SetCurSelectedData(data);
			TabComponentWithCaptionItem<CommonTabItem> tabComponent = this.TabComponent;
			if (tabComponent == null)
			{
				return;
			}
			tabComponent.SelectToggleByIndex(0, true);
		}

		// Token: 0x06031A96 RID: 203414 RVA: 0x00B86C90 File Offset: 0x00B84E90
		private void OnPreviewClick(TrapDefenseBuildingDevelopItemData data)
		{
			List<TrapDefenseBuildingDevelopTypeItem> scrollItemList = this.ScrollView.GetScrollItemList();
			this.SetCurSelectedData(null);
			foreach (TrapDefenseBuildingDevelopTypeItem trapDefenseBuildingDevelopTypeItem in scrollItemList)
			{
				if (trapDefenseBuildingDevelopTypeItem.CheckBottomItemIsInTypeItem(data))
				{
					FVector2D fvector2D = new FVector2D();
					base.GetScrollViewWithScrollbar(1).ScrollToTop(ref fvector2D, trapDefenseBuildingDevelopTypeItem.GetRootItem(), false);
					this.SetCurSelectedData(data);
					break;
				}
			}
			this.UpdateDetail(data, false);
		}

		// Token: 0x06031A97 RID: 203415 RVA: 0x00B86D20 File Offset: 0x00B84F20
		private void OnDataUpdate(TrapDefenseBuildingDevelopItemData data)
		{
			List<TrapDefenseBuildingTypeData> data2 = this.DataListMap[(ETrapDefenseBuildingDevelopTab)this.CurSelectIndex];
			this.SetCurSelectedData(data);
			GenericScrollViewNew<TrapDefenseBuildingDevelopTypeItem, TrapDefenseBuildingTypeData> scrollView = this.ScrollView;
			if (scrollView != null)
			{
				scrollView.RefreshByData(data2, delegate
				{
					foreach (TrapDefenseBuildingDevelopTypeItem trapDefenseBuildingDevelopTypeItem in this.ScrollView.GetScrollItemList())
					{
						trapDefenseBuildingDevelopTypeItem.SetInitSelect();
					}
				}, true);
			}
			bool uiactive = !this.IsInDungeon && TrapDefenseModel.Instance.ViewModelBuildingDevelop.GetCanAllReset();
			UUIButtonComponent button = base.GetButton(3);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(uiactive);
			}
			this.UpdateDetail(data, true);
		}

		// Token: 0x06031A98 RID: 203416 RVA: 0x00B86DA8 File Offset: 0x00B84FA8
		private void OnResetAll()
		{
			List<TrapDefenseBuildingTypeData> data = this.DataListMap[(ETrapDefenseBuildingDevelopTab)this.CurSelectIndex];
			GenericScrollViewNew<TrapDefenseBuildingDevelopTypeItem, TrapDefenseBuildingTypeData> scrollView = this.ScrollView;
			if (scrollView != null)
			{
				scrollView.RefreshByData(data, delegate
				{
					foreach (TrapDefenseBuildingDevelopTypeItem trapDefenseBuildingDevelopTypeItem in this.ScrollView.GetScrollItemList())
					{
						trapDefenseBuildingDevelopTypeItem.SetInitSelect();
					}
				}, true);
			}
			this.UpdateDetail(this.CurSelectedData, true);
			bool uiactive = !this.IsInDungeon && TrapDefenseModel.Instance.ViewModelBuildingDevelop.GetCanAllReset();
			UUIButtonComponent button = base.GetButton(3);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(uiactive);
		}

		// Token: 0x06031A99 RID: 203417 RVA: 0x00B86E30 File Offset: 0x00B85030
		private void OnUpdateSlot()
		{
			this.BottomItem.UpdateSlot();
			foreach (TrapDefenseBuildingDevelopTypeItem trapDefenseBuildingDevelopTypeItem in this.ScrollView.GetScrollItemList())
			{
				trapDefenseBuildingDevelopTypeItem.UpdateEquipped();
			}
			TrapDefenseBuildingSlotData firstEmptySlot = TrapDefenseModel.Instance.ViewModelBuildingDevelop.GetFirstEmptySlot();
			if (firstEmptySlot != null)
			{
				this.SetCurrentSelectBottomIndex(firstEmptySlot.GetIndex());
			}
			this.BottomItem.UpdateEquipTxt();
		}

		// Token: 0x06031A9A RID: 203418 RVA: 0x00B86EBC File Offset: 0x00B850BC
		private TrapDefenseBuildingDevelopTypeItem CreateItemGrid()
		{
			return new TrapDefenseBuildingDevelopTypeItem
			{
				OnPointerDownCb = new Action<TrapDefenseBuildingDevelopTypeGridItem, TrapDefenseBuildingDevelopItemData>(this.OnGridPointerDown),
				OnPointerUpCb = new Action<TrapDefenseBuildingDevelopTypeGridItem, TrapDefenseBuildingDevelopItemData>(this.OnGridPointerUp)
			};
		}

		// Token: 0x06031A9B RID: 203419 RVA: 0x00B86EE8 File Offset: 0x00B850E8
		private void OnClickReset()
		{
			if (this.IsInDungeon)
			{
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.TrapDefenseOrganResetAll);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				TrapDefenseController.Instance.RequestTrapDefenseDevelopReset();
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06031A9C RID: 203420 RVA: 0x00B86F40 File Offset: 0x00B85140
		private UniTask RefreshTabListAsync()
		{
			TrapDefenseBuildingDevelopMainView.<RefreshTabListAsync>d__78 <RefreshTabListAsync>d__;
			<RefreshTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTabListAsync>d__.<>4__this = this;
			<RefreshTabListAsync>d__.<>1__state = -1;
			<RefreshTabListAsync>d__.<>t__builder.Start<TrapDefenseBuildingDevelopMainView.<RefreshTabListAsync>d__78>(ref <RefreshTabListAsync>d__);
			return <RefreshTabListAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031A9D RID: 203421 RVA: 0x00B86F84 File Offset: 0x00B85184
		private List<CommonTabItemData> GetTabItemData(List<ITrapDefenseBuildingDevelopTabData> tabData)
		{
			int count = tabData.Count;
			List<CommonTabItemData> list = this.TabComponent.CreateTabItemDataByLength(count);
			if (!this.IsInDungeon)
			{
				for (int i = 0; i < count; i++)
				{
					ITrapDefenseBuildingDevelopTabData trapDefenseBuildingDevelopTabData = tabData[i];
					if (trapDefenseBuildingDevelopTabData != null)
					{
						list[i].RedDotName = trapDefenseBuildingDevelopTabData.RedDot;
						list[i].NeedUnBindAllRedDot = false;
					}
				}
			}
			return list;
		}

		// Token: 0x06031A9E RID: 203422 RVA: 0x00B86FE4 File Offset: 0x00B851E4
		private void CreateTabListData()
		{
			List<List<TrapDefenseBuildingDevelopItemData>> haveList = TrapDefenseModel.Instance.ViewModelBuildingDevelop.GetHaveList();
			List<TrapDefenseBuildingTypeData> list = new List<TrapDefenseBuildingTypeData>();
			TrapDefenseBuildingTypeData trapDefenseBuildingTypeData = TrapDefenseBuildingTypeData.Create(ETrapDefenseMachineType.Auxiliary, this.IsInDungeon, haveList[0], null);
			if (trapDefenseBuildingTypeData != null)
			{
				list.Add(trapDefenseBuildingTypeData);
			}
			List<TrapDefenseBuildingTypeData> list2 = new List<TrapDefenseBuildingTypeData>();
			TrapDefenseBuildingTypeData trapDefenseBuildingTypeData2 = TrapDefenseBuildingTypeData.Create(ETrapDefenseMachineType.Building, this.IsInDungeon, haveList[1], new ETrapDefensePlacementType?(ETrapDefensePlacementType.Floor));
			if (trapDefenseBuildingTypeData2 != null)
			{
				list2.Add(trapDefenseBuildingTypeData2);
			}
			TrapDefenseBuildingTypeData trapDefenseBuildingTypeData3 = TrapDefenseBuildingTypeData.Create(ETrapDefenseMachineType.Building, this.IsInDungeon, haveList[2], new ETrapDefensePlacementType?(ETrapDefensePlacementType.Wall));
			if (trapDefenseBuildingTypeData3 != null)
			{
				list2.Add(trapDefenseBuildingTypeData3);
			}
			TrapDefenseBuildingTypeData trapDefenseBuildingTypeData4 = TrapDefenseBuildingTypeData.Create(ETrapDefenseMachineType.Building, this.IsInDungeon, haveList[4], new ETrapDefensePlacementType?(ETrapDefensePlacementType.Ceil));
			if (trapDefenseBuildingTypeData4 != null)
			{
				list2.Add(trapDefenseBuildingTypeData4);
			}
			List<TrapDefenseBuildingTypeData> list3 = new List<TrapDefenseBuildingTypeData>();
			list3.AddRange(list2);
			list3.AddRange(list);
			TrapDefenseModel.Instance.ViewModelBuildingDevelop.SetDevelopTab(list3);
			this.DataListMap[ETrapDefenseBuildingDevelopTab.All] = list3;
			this.DataListMap[ETrapDefenseBuildingDevelopTab.Auxiliary] = list;
			this.DataListMap[ETrapDefenseBuildingDevelopTab.Building] = list2;
		}

		// Token: 0x06031A9F RID: 203423 RVA: 0x00B870FC File Offset: 0x00B852FC
		private void SetCurSelectedData(TrapDefenseBuildingDevelopItemData data)
		{
			this.CurSelectedData = data;
			foreach (TrapDefenseBuildingTypeData trapDefenseBuildingTypeData in this.DataListMap[ETrapDefenseBuildingDevelopTab.All])
			{
				if (data == null)
				{
					trapDefenseBuildingTypeData.CurSelectedData = null;
				}
				else
				{
					trapDefenseBuildingTypeData.CurSelectedData = (trapDefenseBuildingTypeData.GetDataList().Contains(data) ? data : null);
				}
			}
		}

		// Token: 0x06031AA0 RID: 203424 RVA: 0x00B8717C File Offset: 0x00B8537C
		private TrapDefenseBuildingDevelopDragDataItem CreateDragDataItem()
		{
			return new TrapDefenseBuildingDevelopDragDataItem();
		}

		// Token: 0x06031AA1 RID: 203425 RVA: 0x00B87184 File Offset: 0x00B85384
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			string a = configParams[0];
			if (a == "MachineGrid")
			{
				if (configParams.Length < 3)
				{
					return null;
				}
				int index;
				if (!int.TryParse(configParams[1], out index))
				{
					return null;
				}
				GenericScrollViewNew<TrapDefenseBuildingDevelopTypeItem, TrapDefenseBuildingTypeData> scrollView = this.ScrollView;
				TrapDefenseBuildingDevelopTypeItem trapDefenseBuildingDevelopTypeItem = (scrollView != null) ? scrollView.GetScrollItemByIndex(index) : null;
				if (trapDefenseBuildingDevelopTypeItem != null)
				{
					UUIItem rootItem = trapDefenseBuildingDevelopTypeItem.GetRootItem();
					GenericScrollViewNew<TrapDefenseBuildingDevelopTypeItem, TrapDefenseBuildingTypeData> scrollView2 = this.ScrollView;
					if (scrollView2 != null)
					{
						scrollView2.LateScrollTo(rootItem, null, false);
					}
					return trapDefenseBuildingDevelopTypeItem.GetGuideUiItemAndUiItemForShowEx(configParams);
				}
			}
			if (a == "FirstLevelTwoGrid")
			{
				foreach (TrapDefenseBuildingDevelopTypeItem trapDefenseBuildingDevelopTypeItem2 in this.ScrollView.GetScrollItemList())
				{
					UUIItem[] guideUiItemAndUiItemForShowEx = trapDefenseBuildingDevelopTypeItem2.GetGuideUiItemAndUiItemForShowEx(configParams);
					if (guideUiItemAndUiItemForShowEx != null)
					{
						GenericScrollViewNew<TrapDefenseBuildingDevelopTypeItem, TrapDefenseBuildingTypeData> scrollView3 = this.ScrollView;
						if (scrollView3 != null)
						{
							scrollView3.LateScrollTo(trapDefenseBuildingDevelopTypeItem2.GetRootItem(), null, false);
						}
						return guideUiItemAndUiItemForShowEx;
					}
				}
			}
			return null;
		}

		// Token: 0x0401A843 RID: 108611
		internal const int INVALID_INDEX = 999;

		// Token: 0x0401A844 RID: 108612
		internal const int HELP_ID = 403;

		// Token: 0x0401A845 RID: 108613
		protected TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x0401A846 RID: 108614
		private CommonCurrencyItem CostBtn;

		// Token: 0x0401A847 RID: 108615
		protected GenericScrollViewNew<TrapDefenseBuildingDevelopTypeItem, TrapDefenseBuildingTypeData> ScrollView;

		// Token: 0x0401A848 RID: 108616
		protected TrapDefenseBuildingDevelopBottomItem BottomItem;

		// Token: 0x0401A849 RID: 108617
		private double LastClickTime;

		// Token: 0x0401A84A RID: 108618
		protected bool IsInDungeon;

		// Token: 0x0401A84B RID: 108619
		private int CurSelectIndex;

		// Token: 0x0401A84C RID: 108620
		private TrapDefenseBuildingDevelopItemData CurSelectedData;

		// Token: 0x0401A84D RID: 108621
		protected List<ITrapDefenseBuildingDevelopTabData> TabDataList = new List<ITrapDefenseBuildingDevelopTabData>();

		// Token: 0x0401A84E RID: 108622
		protected Dictionary<ETrapDefenseBuildingDevelopTab, List<TrapDefenseBuildingTypeData>> DataListMap = new Dictionary<ETrapDefenseBuildingDevelopTab, List<TrapDefenseBuildingTypeData>>();

		// Token: 0x0401A84F RID: 108623
		protected TrapDefenseBuildingDevelopDetailItem DetailInfo;

		// Token: 0x0401A850 RID: 108624
		private float PressTime;

		// Token: 0x0401A851 RID: 108625
		private float FillPressTime;

		// Token: 0x0401A852 RID: 108626
		private bool CheckState;

		// Token: 0x0401A853 RID: 108627
		private bool AfterLongPressState;

		// Token: 0x0401A854 RID: 108628
		private float OnPressPositionX;

		// Token: 0x0401A855 RID: 108629
		private float OnPressPositionY;

		// Token: 0x0401A856 RID: 108630
		private float LongPressItemAlpha;

		// Token: 0x0401A857 RID: 108631
		private int DragClickTick = -1;

		// Token: 0x0401A858 RID: 108632
		private int CheckPointerUpTick = -1;

		// Token: 0x0401A859 RID: 108633
		private float LongPressTime;

		// Token: 0x0401A85A RID: 108634
		private float BeforeLongPressTime;

		// Token: 0x0401A85B RID: 108635
		private float ScrollerMoveDistance;

		// Token: 0x0401A85C RID: 108636
		protected TrapDefenseBuildingDevelopNormalDragItem DragItem;

		// Token: 0x0401A85D RID: 108637
		protected List<TrapDefenseBuildingDevelopBottomInfoItem> BottomItemList = new List<TrapDefenseBuildingDevelopBottomInfoItem>();

		// Token: 0x0401A85E RID: 108638
		private CommonDragItemLogic<TrapDefenseBuildingDevelopDragDataItem, TrapDefenseBuildingDevelopItemData> DragLogic;

		// Token: 0x0401A85F RID: 108639
		private List<CommonDragItemLogic<TrapDefenseBuildingDevelopDragDataItem, TrapDefenseBuildingDevelopItemData>> BottomDragLogic = new List<CommonDragItemLogic<TrapDefenseBuildingDevelopDragDataItem, TrapDefenseBuildingDevelopItemData>>();

		// Token: 0x0401A860 RID: 108640
		private TrapDefenseBuildingDevelopTypeGridItem CurrentPressItem;

		// Token: 0x0401A861 RID: 108641
		protected int CurrentDragIndex = -1;

		// Token: 0x0401A862 RID: 108642
		protected int CurrentSelectedBottomIndex;

		// Token: 0x0200AC6B RID: 44139
		[NullableContext(0)]
		internal class EChildComponentType
		{
			// Token: 0x04034666 RID: 214630
			public const int CaptionItem = 0;

			// Token: 0x04034667 RID: 214631
			public const int ItemScroll = 1;

			// Token: 0x04034668 RID: 214632
			public const int PanelBuffItemGrid = 2;

			// Token: 0x04034669 RID: 214633
			public const int BtnResetAll = 3;

			// Token: 0x0403466A RID: 214634
			public const int PanelContentLayout = 4;

			// Token: 0x0403466B RID: 214635
			public const int PanelBottomLayout = 5;

			// Token: 0x0403466C RID: 214636
			public const int PanelDrag = 6;

			// Token: 0x0403466D RID: 214637
			public const int PanelLongPress = 7;

			// Token: 0x0403466E RID: 214638
			public const int PanelDragItem = 8;

			// Token: 0x0403466F RID: 214639
			public const int SpriteBar = 9;
		}
	}
}
