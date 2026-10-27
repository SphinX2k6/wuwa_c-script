using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065B2 RID: 26034
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DockyardItemListItem : GridProxyAbstract<DockyardItemBlockOriginalData>
	{
		// Token: 0x060414AD RID: 267437 RVA: 0x00FD2DD0 File Offset: 0x00FD0FD0
		protected unsafe override void OnRegisterComponent()
		{
			this.ParentModel = (this.OpenParam as DockyardItemListPanelModel);
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060414AE RID: 267438 RVA: 0x00FD2F34 File Offset: 0x00FD1134
		private void InitDrag()
		{
			this.ExtendToggle = base.GetExtendToggle(0);
			if (!this.NeedInteract)
			{
				this.ExtendToggle.SetSelfInteractive(false);
				this.ExtendToggle.SetCanClickWhenDisable(false);
				return;
			}
			this.ExtendToggle.OnPointDownCallBack.Bind(new Action<EToggleState>(this.OnPointerDown));
			this.ExtendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
			this.ExtendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnPointerClick));
			this.ExtendToggle.OnPointerBeginDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnDragBegin));
			this.ExtendToggle.OnPointerDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnDrag));
		}

		// Token: 0x060414AF RID: 267439 RVA: 0x00FD2FFC File Offset: 0x00FD11FC
		private UniTask InitListLayout(int tag, UUIItem layoutItem)
		{
			DockyardItemListItem.<InitListLayout>d__14 <InitListLayout>d__;
			<InitListLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitListLayout>d__.<>4__this = this;
			<InitListLayout>d__.tag = tag;
			<InitListLayout>d__.layoutItem = layoutItem;
			<InitListLayout>d__.<>1__state = -1;
			<InitListLayout>d__.<>t__builder.Start<DockyardItemListItem.<InitListLayout>d__14>(ref <InitListLayout>d__);
			return <InitListLayout>d__.<>t__builder.Task;
		}

		// Token: 0x060414B0 RID: 267440 RVA: 0x00FD3050 File Offset: 0x00FD1250
		private void RefreshDelegateItem(int itemId)
		{
			bool uiactive = FishingQuestModel.Instance.IsUnDeliverableByItemId(itemId);
			base.GetItem(8).SetUIActive(uiactive);
		}

		// Token: 0x060414B1 RID: 267441 RVA: 0x00FD3078 File Offset: 0x00FD1278
		private void SetToggleState(bool isActive)
		{
			EToggleState state = isActive ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x060414B2 RID: 267442 RVA: 0x00FD30A0 File Offset: 0x00FD12A0
		protected override UniTask OnBeforeStartAsync()
		{
			DockyardItemListItem.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DockyardItemListItem.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060414B3 RID: 267443 RVA: 0x00FD30E3 File Offset: 0x00FD12E3
		protected override void OnStart()
		{
			EventSystem.Instance.Add(EEventName.FishingBackpackDeliverableRefresh, new Action(this.RefreshCurrentDelegateItem));
		}

		// Token: 0x060414B4 RID: 267444 RVA: 0x00FD3101 File Offset: 0x00FD1301
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.FishingBackpackDeliverableRefresh, new Action(this.RefreshCurrentDelegateItem));
		}

		// Token: 0x060414B5 RID: 267445 RVA: 0x00FD3120 File Offset: 0x00FD1320
		private void HideListLayout()
		{
			foreach (ListLayout listLayout in this.ListLayoutMap.Values)
			{
				listLayout.GetRootItem().SetUIActive(false);
			}
		}

		// Token: 0x060414B6 RID: 267446 RVA: 0x00FD317C File Offset: 0x00FD137C
		private UniTask RefreshTexture(int itemId)
		{
			DockyardItemListItem.<RefreshTexture>d__21 <RefreshTexture>d__;
			<RefreshTexture>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTexture>d__.<>4__this = this;
			<RefreshTexture>d__.itemId = itemId;
			<RefreshTexture>d__.<>1__state = -1;
			<RefreshTexture>d__.<>t__builder.Start<DockyardItemListItem.<RefreshTexture>d__21>(ref <RefreshTexture>d__);
			return <RefreshTexture>d__.<>t__builder.Task;
		}

		// Token: 0x060414B7 RID: 267447 RVA: 0x00FD31C8 File Offset: 0x00FD13C8
		private void ShowListLayout(List<List<int>> dataDoublyList, int qualityId)
		{
			int count = dataDoublyList[0].Count;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Dockyard;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "列表格子显示长度";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tag", count);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			int key = Math.Max(count, 3);
			ListLayout listLayout = this.ListLayoutMap[key];
			this.TempLayout = listLayout.GetRootItem();
			this.TempLayout.SetUIActive(true);
			listLayout.RefreshAsync(dataDoublyList, qualityId);
		}

		// Token: 0x060414B8 RID: 267448 RVA: 0x00FD3248 File Offset: 0x00FD1448
		private void RefreshCup(int cup, int itemId)
		{
			bool flag = FishingConfig.Instance.GetFishingItemConfig(itemId).Value.Type == 1;
			UUITexture texture = base.GetTexture(1);
			string texturePathByCup = DockyardPanelUtil.GetTexturePathByCup(cup);
			bool flag2 = !StringUtils.IsBlank(texturePathByCup) && flag;
			texture.SetUIActive(flag2);
			if (flag2)
			{
				base.SetTextureByPath(texturePathByCup, texture, null, null);
			}
		}

		// Token: 0x060414B9 RID: 267449 RVA: 0x00FD32B0 File Offset: 0x00FD14B0
		private void RefreshPrice(int price)
		{
			base.GetText(2).SetText(price.ToString(), true);
		}

		// Token: 0x060414BA RID: 267450 RVA: 0x00FD32C6 File Offset: 0x00FD14C6
		private void OnPointerClick(EToggleState state)
		{
			DockyardItemListPanelModel parentModel = this.ParentModel;
			if (parentModel == null)
			{
				return;
			}
			parentModel.DragClick(this.ItemData);
		}

		// Token: 0x060414BB RID: 267451 RVA: 0x00FD32E0 File Offset: 0x00FD14E0
		private void OnPointerDown(EToggleState state)
		{
			ULGUIPointerEventData pointerEventData = LguiEventSystemManager.Instance.GetPointerEventData(0, false);
			if (pointerEventData != null)
			{
				this.MoveDistance = 0.0;
				Vector lastPosition = this.LastPosition;
				FVector pointerPosition = pointerEventData.pointerPosition;
				FVectorDouble fvectorDouble = pointerPosition;
				lastPosition.DeepCopy(fvectorDouble);
				this.IsCanDrag = true;
			}
		}

		// Token: 0x060414BC RID: 267452 RVA: 0x00FD332F File Offset: 0x00FD152F
		private bool CanExecuteChange()
		{
			return this.ParentModel == null || this.ParentModel.InSelectedBlockId != this.ItemData.IncId;
		}

		// Token: 0x060414BD RID: 267453 RVA: 0x00FD3358 File Offset: 0x00FD1558
		private bool OnDragBegin(ULGUIPointerEventData eventData)
		{
			Vector currentPosition = this.CurrentPosition;
			FVector pointerPosition = eventData.pointerPosition;
			FVectorDouble fvectorDouble = pointerPosition;
			currentPosition.DeepCopy(fvectorDouble);
			double angleByVector2D = MathUtils.Instance.GetAngleByVector2D(this.CurrentPosition.SubtractionEqual(this.LastPosition));
			if (Math.Abs(angleByVector2D) < 45.0 || Math.Abs(angleByVector2D) > 135.0)
			{
				return false;
			}
			this.IsCanDrag = false;
			return true;
		}

		// Token: 0x060414BE RID: 267454 RVA: 0x00FD33C9 File Offset: 0x00FD15C9
		private void RefreshCurrentDelegateItem()
		{
			if (this.ItemData != null)
			{
				this.RefreshDelegateItem(this.ItemData.ItemId);
			}
		}

		// Token: 0x060414BF RID: 267455 RVA: 0x00FD33E4 File Offset: 0x00FD15E4
		private bool OnDrag(ULGUIPointerEventData eventData)
		{
			if (!this.IsCanDrag)
			{
				return true;
			}
			Vector currentPosition = this.CurrentPosition;
			FVector pointerPosition = eventData.pointerPosition;
			FVectorDouble fvectorDouble = pointerPosition;
			currentPosition.DeepCopy(fvectorDouble);
			double num = this.CurrentPosition.X - this.LastPosition.X;
			this.MoveDistance += num;
			this.LastPosition.DeepCopy(this.CurrentPosition);
			if (Math.Abs(this.MoveDistance) > 50.0)
			{
				DockyardItemListPanelModel parentModel = this.ParentModel;
				if (parentModel != null)
				{
					parentModel.DragBegin(this.ItemData);
				}
				this.IsCanDrag = false;
			}
			return true;
		}

		// Token: 0x060414C0 RID: 267456 RVA: 0x00FD3484 File Offset: 0x00FD1684
		public override void Refresh(DockyardItemBlockOriginalData data, bool isSelected, int gridIndex)
		{
			this.HideListLayout();
			this.ItemData = data;
			this.RefreshRedDot();
			this.RefreshPrice(data.Price);
			this.RefreshCup(data.Cup, data.ItemId);
			this.ShowListLayout(data.ValidDoublyList, data.Quality);
			this.RefreshTexture(data.ItemId);
			this.RefreshDelegateItem(data.ItemId);
			this.RefreshToggleState();
		}

		// Token: 0x060414C1 RID: 267457 RVA: 0x00FD34F4 File Offset: 0x00FD16F4
		public void RefreshRedDot()
		{
			bool flag = DockyardModel.Instance.CheckListItemReadFlag(this.ItemData.ItemId);
			base.GetItem(3).SetUIActive(!flag);
		}

		// Token: 0x060414C2 RID: 267458 RVA: 0x00FD3528 File Offset: 0x00FD1728
		public void RefreshToggleState()
		{
			if (this.ParentModel != null)
			{
				bool toggleState = this.ParentModel.InSelectedBlockId == this.ItemData.IncId;
				this.SetToggleState(toggleState);
				return;
			}
			this.SetToggleState(false);
		}

		// Token: 0x060414C3 RID: 267459 RVA: 0x00FD3565 File Offset: 0x00FD1765
		public override object GetKey(DockyardItemBlockOriginalData data, int displayIndex)
		{
			return this.ItemData;
		}

		// Token: 0x04021FCA RID: 139210
		private const int MOVE_DISTANCE = 50;

		// Token: 0x04021FCB RID: 139211
		protected DockyardItemBlockOriginalData ItemData;

		// Token: 0x04021FCC RID: 139212
		protected DockyardItemListPanelModel ParentModel;

		// Token: 0x04021FCD RID: 139213
		protected Dictionary<int, ListLayout> ListLayoutMap = new Dictionary<int, ListLayout>();

		// Token: 0x04021FCE RID: 139214
		private UUIItem TempLayout;

		// Token: 0x04021FCF RID: 139215
		private double MoveDistance;

		// Token: 0x04021FD0 RID: 139216
		private readonly Vector LastPosition = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x04021FD1 RID: 139217
		private readonly Vector CurrentPosition = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x04021FD2 RID: 139218
		private bool IsCanDrag;

		// Token: 0x04021FD3 RID: 139219
		private UUIExtendToggle ExtendToggle;

		// Token: 0x04021FD4 RID: 139220
		public bool NeedInteract = true;

		// Token: 0x0200C7BB RID: 51131
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C549 RID: 247113
			public const int DraggableItem = 0;

			// Token: 0x0403C54A RID: 247114
			public const int CupIcon = 1;

			// Token: 0x0403C54B RID: 247115
			public const int TxtPrice = 2;

			// Token: 0x0403C54C RID: 247116
			public const int NewItem = 3;

			// Token: 0x0403C54D RID: 247117
			public const int FirstLayoutItem = 4;

			// Token: 0x0403C54E RID: 247118
			public const int SecondLayoutItem = 5;

			// Token: 0x0403C54F RID: 247119
			public const int ThirdLayoutItem = 6;

			// Token: 0x0403C550 RID: 247120
			public const int Texture = 7;

			// Token: 0x0403C551 RID: 247121
			public const int DelegateItem = 8;
		}
	}
}
