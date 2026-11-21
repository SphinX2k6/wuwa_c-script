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
	// Token: 0x02005530 RID: 21808
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DockyardItemListItem : GridProxyAbstract<DockyardItemBlockOriginalData>
	{
		// Token: 0x06036172 RID: 221554 RVA: 0x00F19DD4 File Offset: 0x00F17FD4
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

		// Token: 0x06036173 RID: 221555 RVA: 0x00F19F38 File Offset: 0x00F18138
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

		// Token: 0x06036174 RID: 221556 RVA: 0x00F1A000 File Offset: 0x00F18200
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

		// Token: 0x06036175 RID: 221557 RVA: 0x00F1A054 File Offset: 0x00F18254
		private void RefreshDelegateItem(int itemId)
		{
			bool uiactive = FishingQuestModel.Instance.IsUnDeliverableByItemId(itemId);
			base.GetItem(8).SetUIActive(uiactive);
		}

		// Token: 0x06036176 RID: 221558 RVA: 0x00F1A07C File Offset: 0x00F1827C
		private void SetToggleState(bool isActive)
		{
			EToggleState state = isActive ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x06036177 RID: 221559 RVA: 0x00F1A0A4 File Offset: 0x00F182A4
		protected override UniTask OnBeforeStartAsync()
		{
			DockyardItemListItem.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DockyardItemListItem.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036178 RID: 221560 RVA: 0x00F1A0E7 File Offset: 0x00F182E7
		protected override void OnStart()
		{
			EventSystem.Instance.Add(EEventName.FishingBackpackDeliverableRefresh, new Action(this.RefreshCurrentDelegateItem));
		}

		// Token: 0x06036179 RID: 221561 RVA: 0x00F1A105 File Offset: 0x00F18305
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.FishingBackpackDeliverableRefresh, new Action(this.RefreshCurrentDelegateItem));
		}

		// Token: 0x0603617A RID: 221562 RVA: 0x00F1A124 File Offset: 0x00F18324
		private void HideListLayout()
		{
			foreach (ListLayout listLayout in this.ListLayoutMap.Values)
			{
				listLayout.GetRootItem().SetUIActive(false);
			}
		}

		// Token: 0x0603617B RID: 221563 RVA: 0x00F1A180 File Offset: 0x00F18380
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

		// Token: 0x0603617C RID: 221564 RVA: 0x00F1A1CC File Offset: 0x00F183CC
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

		// Token: 0x0603617D RID: 221565 RVA: 0x00F1A24C File Offset: 0x00F1844C
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

		// Token: 0x0603617E RID: 221566 RVA: 0x00F1A2B4 File Offset: 0x00F184B4
		private void RefreshPrice(int price)
		{
			base.GetText(2).SetText(price.ToString(), true);
		}

		// Token: 0x0603617F RID: 221567 RVA: 0x00F1A2CA File Offset: 0x00F184CA
		private void OnPointerClick(EToggleState state)
		{
			DockyardItemListPanelModel parentModel = this.ParentModel;
			if (parentModel == null)
			{
				return;
			}
			parentModel.DragClick(this.ItemData);
		}

		// Token: 0x06036180 RID: 221568 RVA: 0x00F1A2E4 File Offset: 0x00F184E4
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

		// Token: 0x06036181 RID: 221569 RVA: 0x00F1A333 File Offset: 0x00F18533
		private bool CanExecuteChange()
		{
			return this.ParentModel == null || this.ParentModel.InSelectedBlockId != this.ItemData.IncId;
		}

		// Token: 0x06036182 RID: 221570 RVA: 0x00F1A35C File Offset: 0x00F1855C
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

		// Token: 0x06036183 RID: 221571 RVA: 0x00F1A3CD File Offset: 0x00F185CD
		private void RefreshCurrentDelegateItem()
		{
			if (this.ItemData != null)
			{
				this.RefreshDelegateItem(this.ItemData.ItemId);
			}
		}

		// Token: 0x06036184 RID: 221572 RVA: 0x00F1A3E8 File Offset: 0x00F185E8
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

		// Token: 0x06036185 RID: 221573 RVA: 0x00F1A488 File Offset: 0x00F18688
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

		// Token: 0x06036186 RID: 221574 RVA: 0x00F1A4F8 File Offset: 0x00F186F8
		public void RefreshRedDot()
		{
			bool flag = DockyardModel.Instance.CheckListItemReadFlag(this.ItemData.ItemId);
			base.GetItem(3).SetUIActive(!flag);
		}

		// Token: 0x06036187 RID: 221575 RVA: 0x00F1A52C File Offset: 0x00F1872C
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

		// Token: 0x06036188 RID: 221576 RVA: 0x00F1A569 File Offset: 0x00F18769
		public override object GetKey(DockyardItemBlockOriginalData data, int displayIndex)
		{
			return this.ItemData;
		}

		// Token: 0x0401C8FB RID: 116987
		private const int MOVE_DISTANCE = 50;

		// Token: 0x0401C8FC RID: 116988
		protected DockyardItemBlockOriginalData ItemData;

		// Token: 0x0401C8FD RID: 116989
		protected DockyardItemListPanelModel ParentModel;

		// Token: 0x0401C8FE RID: 116990
		protected Dictionary<int, ListLayout> ListLayoutMap = new Dictionary<int, ListLayout>();

		// Token: 0x0401C8FF RID: 116991
		private UUIItem TempLayout;

		// Token: 0x0401C900 RID: 116992
		private double MoveDistance;

		// Token: 0x0401C901 RID: 116993
		private readonly Vector LastPosition = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x0401C902 RID: 116994
		private readonly Vector CurrentPosition = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x0401C903 RID: 116995
		private bool IsCanDrag;

		// Token: 0x0401C904 RID: 116996
		private UUIExtendToggle ExtendToggle;

		// Token: 0x0401C905 RID: 116997
		public bool NeedInteract = true;

		// Token: 0x0200B19F RID: 45471
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036E98 RID: 224920
			public const int DraggableItem = 0;

			// Token: 0x04036E99 RID: 224921
			public const int CupIcon = 1;

			// Token: 0x04036E9A RID: 224922
			public const int TxtPrice = 2;

			// Token: 0x04036E9B RID: 224923
			public const int NewItem = 3;

			// Token: 0x04036E9C RID: 224924
			public const int FirstLayoutItem = 4;

			// Token: 0x04036E9D RID: 224925
			public const int SecondLayoutItem = 5;

			// Token: 0x04036E9E RID: 224926
			public const int ThirdLayoutItem = 6;

			// Token: 0x04036E9F RID: 224927
			public const int Texture = 7;

			// Token: 0x04036EA0 RID: 224928
			public const int DelegateItem = 8;
		}
	}
}
