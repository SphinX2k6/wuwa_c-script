using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065B3 RID: 26035
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardItemListPanel : UiPanelBase
	{
		// Token: 0x060414C5 RID: 267461 RVA: 0x00FD35E4 File Offset: 0x00FD17E4
		protected unsafe override void OnRegisterComponent()
		{
			this.PanelModel = (this.OpenParam as DockyardItemListPanelModel);
			this.PanelModel.RegisterPanel(this);
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060414C6 RID: 267462 RVA: 0x00FD3774 File Offset: 0x00FD1974
		private UniTask InitLoopScroll()
		{
			DockyardItemListPanel.<InitLoopScroll>d__10 <InitLoopScroll>d__;
			<InitLoopScroll>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLoopScroll>d__.<>4__this = this;
			<InitLoopScroll>d__.<>1__state = -1;
			<InitLoopScroll>d__.<>t__builder.Start<DockyardItemListPanel.<InitLoopScroll>d__10>(ref <InitLoopScroll>d__);
			return <InitLoopScroll>d__.<>t__builder.Task;
		}

		// Token: 0x060414C7 RID: 267463 RVA: 0x00FD37B8 File Offset: 0x00FD19B8
		protected void InitTitle()
		{
			UUIText text = base.GetText(4);
			bool flag = !StringUtils.IsBlank(this.PanelModel.ComponentData.TitleText);
			text.SetUIActive(flag);
			if (flag)
			{
				LguiUtil.Instance.SetLocalTextNew(text, this.PanelModel.ComponentData.TitleText, Array.Empty<object>());
			}
		}

		// Token: 0x060414C8 RID: 267464 RVA: 0x00FD3810 File Offset: 0x00FD1A10
		protected void SetCountText()
		{
			UUIText text = base.GetText(1);
			Func<string> getCountText = this.PanelModel.ComponentData.GetCountText;
			string text2 = (getCountText != null) ? getCountText() : null;
			bool flag = text2 != null && !StringUtils.IsBlank(text2);
			text.SetUIActive(flag);
			if (flag)
			{
				text.SetText(text2, true);
			}
		}

		// Token: 0x060414C9 RID: 267465 RVA: 0x00FD3864 File Offset: 0x00FD1A64
		protected void InitHelpItem()
		{
			UUIExtendButtonComponent uuiextendButtonComponent = base.GetButton(6) as UUIExtendButtonComponent;
			bool flag = this.PanelModel.ComponentData.HelpBtnId != 0;
			uuiextendButtonComponent.RootUIComp.Get().SetUIActive(flag);
			if (flag)
			{
				uuiextendButtonComponent.HelpGroupId = this.PanelModel.ComponentData.HelpBtnId;
			}
		}

		// Token: 0x060414CA RID: 267466 RVA: 0x00FD38C0 File Offset: 0x00FD1AC0
		protected void InitTimeItem()
		{
			UUIItem item = base.GetItem(8);
			bool flag = !StringUtils.IsBlank(this.PanelModel.ComponentData.TimeText);
			item.SetUIActive(flag);
			if (flag)
			{
				UUIText text = base.GetText(9);
				LguiUtil.Instance.SetLocalTextNew(text, "Fishing_CageTime", new <>z__ReadOnlySingleElementList<object>(this.PanelModel.ComponentData.TimeText));
			}
		}

		// Token: 0x060414CB RID: 267467 RVA: 0x00FD3924 File Offset: 0x00FD1B24
		protected override UniTask OnBeforeStartAsync()
		{
			DockyardItemListPanel.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DockyardItemListPanel.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060414CC RID: 267468 RVA: 0x00FD3968 File Offset: 0x00FD1B68
		protected override void OnStart()
		{
			this.DragTipsItem = base.GetItem(7);
			this.DragTipsActive = this.DragTipsItem.bIsUIActive;
			this.SetDragTipsActive(false);
			Transform dragTipsWorldTrans = this.DragTipsWorldTrans;
			FTransform ftransform = this.DragTipsItem.K2_GetComponentToWorld();
			dragTipsWorldTrans.FromUeTransform(ftransform);
			FVector2D pivot = this.DragTipsItem.GetPivot();
			this.ViewportItemRange = new ItemRange
			{
				Left = -pivot.X * this.DragTipsItem.Width,
				Right = (1f - pivot.X) * this.DragTipsItem.Width,
				Top = (1f - pivot.Y) * this.DragTipsItem.Height,
				Bottom = -pivot.Y * this.DragTipsItem.Height
			};
		}

		// Token: 0x060414CD RID: 267469 RVA: 0x00FD3A38 File Offset: 0x00FD1C38
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			DockyardItemListPanel.<OnBeforeShowAsyncImplement>d__17 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<DockyardItemListPanel.<OnBeforeShowAsyncImplement>d__17>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060414CE RID: 267470 RVA: 0x00FD3A7B File Offset: 0x00FD1C7B
		protected override void OnBeforeDestroy()
		{
			this.TipsSequence.Clear();
		}

		// Token: 0x060414CF RID: 267471 RVA: 0x00FD3A88 File Offset: 0x00FD1C88
		private DockyardItemListItem InitGridItem()
		{
			return new DockyardItemListItem
			{
				OpenParam = this.PanelModel
			};
		}

		// Token: 0x060414D0 RID: 267472 RVA: 0x00FD3A9C File Offset: 0x00FD1C9C
		public UniTask RefreshListItem()
		{
			DockyardItemListPanel.<RefreshListItem>d__20 <RefreshListItem>d__;
			<RefreshListItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshListItem>d__.<>4__this = this;
			<RefreshListItem>d__.<>1__state = -1;
			<RefreshListItem>d__.<>t__builder.Start<DockyardItemListPanel.<RefreshListItem>d__20>(ref <RefreshListItem>d__);
			return <RefreshListItem>d__.<>t__builder.Task;
		}

		// Token: 0x060414D1 RID: 267473 RVA: 0x00FD3AE0 File Offset: 0x00FD1CE0
		public bool CheckInViewport()
		{
			ULGUIPointerEventData pointerEventData = LguiEventSystemManager.Instance.GetPointerEventData(0, true);
			this.TempVector.Set((double)pointerEventData.worldPoint.X, 0.0, (double)pointerEventData.worldPoint.Z);
			Transform dragTipsWorldTrans = this.DragTipsWorldTrans;
			FTransform ftransform = this.DragTipsItem.K2_GetComponentToWorld();
			dragTipsWorldTrans.FromUeTransform(ftransform);
			this.DragTipsWorldTrans.InverseTransformPosition(this.TempVector, this.TempVector);
			return this.TempVector.X >= (double)this.ViewportItemRange.Left && this.TempVector.X <= (double)this.ViewportItemRange.Right && this.TempVector.Y >= (double)this.ViewportItemRange.Bottom && this.TempVector.Y <= (double)this.ViewportItemRange.Top;
		}

		// Token: 0x060414D2 RID: 267474 RVA: 0x00FD3BC0 File Offset: 0x00FD1DC0
		private UniTask PlayShowSequence()
		{
			DockyardItemListPanel.<PlayShowSequence>d__22 <PlayShowSequence>d__;
			<PlayShowSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayShowSequence>d__.<>4__this = this;
			<PlayShowSequence>d__.<>1__state = -1;
			<PlayShowSequence>d__.<>t__builder.Start<DockyardItemListPanel.<PlayShowSequence>d__22>(ref <PlayShowSequence>d__);
			return <PlayShowSequence>d__.<>t__builder.Task;
		}

		// Token: 0x060414D3 RID: 267475 RVA: 0x00FD3C04 File Offset: 0x00FD1E04
		private UniTask PlayHideSequence()
		{
			DockyardItemListPanel.<PlayHideSequence>d__23 <PlayHideSequence>d__;
			<PlayHideSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayHideSequence>d__.<>4__this = this;
			<PlayHideSequence>d__.<>1__state = -1;
			<PlayHideSequence>d__.<>t__builder.Start<DockyardItemListPanel.<PlayHideSequence>d__23>(ref <PlayHideSequence>d__);
			return <PlayHideSequence>d__.<>t__builder.Task;
		}

		// Token: 0x060414D4 RID: 267476 RVA: 0x00FD3C48 File Offset: 0x00FD1E48
		public void SetDragTipsActive(bool isActive)
		{
			if (this.DragTipsActive == isActive)
			{
				return;
			}
			this.DragTipsActive = isActive;
			if (isActive)
			{
				this.PlayShowSequence();
			}
			else
			{
				this.PlayHideSequence();
			}
			List<DockyardItemBlockOriginalData> showItemList = this.PanelModel.ShowItemList;
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(showItemList.Count == 0 && !isActive);
		}

		// Token: 0x060414D5 RID: 267477 RVA: 0x00FD3CA8 File Offset: 0x00FD1EA8
		public void RefreshListItemStateByIncId(int incId)
		{
			int num = this.PanelModel.ShowItemList.FindIndex((DockyardItemBlockOriginalData item) => item.IncId == incId);
			if (num >= 0)
			{
				DockyardItemListItem dockyardItemListItem = this.LoopScroll.UnsafeGetGridProxy(num, false);
				if (dockyardItemListItem == null)
				{
					return;
				}
				dockyardItemListItem.RefreshToggleState();
			}
		}

		// Token: 0x060414D6 RID: 267478 RVA: 0x00FD3CFC File Offset: 0x00FD1EFC
		public void RefreshListItemRedDot(int itemId)
		{
			for (int i = 0; i < this.PanelModel.ShowItemList.Count; i++)
			{
				if (this.PanelModel.ShowItemList[i].ItemId == itemId && i >= this.LoopScroll.StartGridIndex && i <= this.LoopScroll.EndGridIndex)
				{
					DockyardItemListItem dockyardItemListItem = this.LoopScroll.UnsafeGetGridProxy(i, false);
					if (dockyardItemListItem != null)
					{
						dockyardItemListItem.RefreshRedDot();
					}
				}
			}
		}

		// Token: 0x060414D7 RID: 267479 RVA: 0x00FD3D74 File Offset: 0x00FD1F74
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (this.PanelModel.ShowItemList.Count <= 0)
			{
				return null;
			}
			UUIItem gridByDisplayIndex = this.LoopScroll.GetGridByDisplayIndex(0);
			if (gridByDisplayIndex == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				gridByDisplayIndex,
				gridByDisplayIndex
			};
		}

		// Token: 0x04021FD5 RID: 139221
		private LoopScrollView<DockyardItemListItem, DockyardItemBlockOriginalData> LoopScroll;

		// Token: 0x04021FD6 RID: 139222
		public DockyardItemListPanelModel PanelModel;

		// Token: 0x04021FD7 RID: 139223
		private readonly Transform DragTipsWorldTrans = Transform.Create();

		// Token: 0x04021FD8 RID: 139224
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x04021FD9 RID: 139225
		private IItemRange ViewportItemRange;

		// Token: 0x04021FDA RID: 139226
		private UUIItem DragTipsItem;

		// Token: 0x04021FDB RID: 139227
		private bool DragTipsActive;

		// Token: 0x04021FDC RID: 139228
		private UiSequencePlayer TipsSequence;

		// Token: 0x0200C7BF RID: 51135
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C563 RID: 247139
			public const int EmptyItem = 0;

			// Token: 0x0403C564 RID: 247140
			public const int Count = 1;

			// Token: 0x0403C565 RID: 247141
			public const int ListItem = 2;

			// Token: 0x0403C566 RID: 247142
			public const int GridItem = 3;

			// Token: 0x0403C567 RID: 247143
			public const int Title = 4;

			// Token: 0x0403C568 RID: 247144
			public const int TitleSprite = 5;

			// Token: 0x0403C569 RID: 247145
			public const int HelpBtn = 6;

			// Token: 0x0403C56A RID: 247146
			public const int DragTips = 7;

			// Token: 0x0403C56B RID: 247147
			public const int TimeItem = 8;

			// Token: 0x0403C56C RID: 247148
			public const int TimeTips = 9;
		}
	}
}
