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
	// Token: 0x02005531 RID: 21809
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardItemListPanel : UiPanelBase
	{
		// Token: 0x0603618A RID: 221578 RVA: 0x00F1A5E8 File Offset: 0x00F187E8
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

		// Token: 0x0603618B RID: 221579 RVA: 0x00F1A778 File Offset: 0x00F18978
		private UniTask InitLoopScroll()
		{
			DockyardItemListPanel.<InitLoopScroll>d__10 <InitLoopScroll>d__;
			<InitLoopScroll>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLoopScroll>d__.<>4__this = this;
			<InitLoopScroll>d__.<>1__state = -1;
			<InitLoopScroll>d__.<>t__builder.Start<DockyardItemListPanel.<InitLoopScroll>d__10>(ref <InitLoopScroll>d__);
			return <InitLoopScroll>d__.<>t__builder.Task;
		}

		// Token: 0x0603618C RID: 221580 RVA: 0x00F1A7BC File Offset: 0x00F189BC
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

		// Token: 0x0603618D RID: 221581 RVA: 0x00F1A814 File Offset: 0x00F18A14
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

		// Token: 0x0603618E RID: 221582 RVA: 0x00F1A868 File Offset: 0x00F18A68
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

		// Token: 0x0603618F RID: 221583 RVA: 0x00F1A8C4 File Offset: 0x00F18AC4
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

		// Token: 0x06036190 RID: 221584 RVA: 0x00F1A928 File Offset: 0x00F18B28
		protected override UniTask OnBeforeStartAsync()
		{
			DockyardItemListPanel.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DockyardItemListPanel.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036191 RID: 221585 RVA: 0x00F1A96C File Offset: 0x00F18B6C
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

		// Token: 0x06036192 RID: 221586 RVA: 0x00F1AA3C File Offset: 0x00F18C3C
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			DockyardItemListPanel.<OnBeforeShowAsyncImplement>d__17 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<DockyardItemListPanel.<OnBeforeShowAsyncImplement>d__17>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06036193 RID: 221587 RVA: 0x00F1AA7F File Offset: 0x00F18C7F
		protected override void OnBeforeDestroy()
		{
			this.TipsSequence.Clear();
		}

		// Token: 0x06036194 RID: 221588 RVA: 0x00F1AA8C File Offset: 0x00F18C8C
		private DockyardItemListItem InitGridItem()
		{
			return new DockyardItemListItem
			{
				OpenParam = this.PanelModel
			};
		}

		// Token: 0x06036195 RID: 221589 RVA: 0x00F1AAA0 File Offset: 0x00F18CA0
		public UniTask RefreshListItem()
		{
			DockyardItemListPanel.<RefreshListItem>d__20 <RefreshListItem>d__;
			<RefreshListItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshListItem>d__.<>4__this = this;
			<RefreshListItem>d__.<>1__state = -1;
			<RefreshListItem>d__.<>t__builder.Start<DockyardItemListPanel.<RefreshListItem>d__20>(ref <RefreshListItem>d__);
			return <RefreshListItem>d__.<>t__builder.Task;
		}

		// Token: 0x06036196 RID: 221590 RVA: 0x00F1AAE4 File Offset: 0x00F18CE4
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

		// Token: 0x06036197 RID: 221591 RVA: 0x00F1ABC4 File Offset: 0x00F18DC4
		private UniTask PlayShowSequence()
		{
			DockyardItemListPanel.<PlayShowSequence>d__22 <PlayShowSequence>d__;
			<PlayShowSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayShowSequence>d__.<>4__this = this;
			<PlayShowSequence>d__.<>1__state = -1;
			<PlayShowSequence>d__.<>t__builder.Start<DockyardItemListPanel.<PlayShowSequence>d__22>(ref <PlayShowSequence>d__);
			return <PlayShowSequence>d__.<>t__builder.Task;
		}

		// Token: 0x06036198 RID: 221592 RVA: 0x00F1AC08 File Offset: 0x00F18E08
		private UniTask PlayHideSequence()
		{
			DockyardItemListPanel.<PlayHideSequence>d__23 <PlayHideSequence>d__;
			<PlayHideSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayHideSequence>d__.<>4__this = this;
			<PlayHideSequence>d__.<>1__state = -1;
			<PlayHideSequence>d__.<>t__builder.Start<DockyardItemListPanel.<PlayHideSequence>d__23>(ref <PlayHideSequence>d__);
			return <PlayHideSequence>d__.<>t__builder.Task;
		}

		// Token: 0x06036199 RID: 221593 RVA: 0x00F1AC4C File Offset: 0x00F18E4C
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

		// Token: 0x0603619A RID: 221594 RVA: 0x00F1ACAC File Offset: 0x00F18EAC
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

		// Token: 0x0603619B RID: 221595 RVA: 0x00F1AD00 File Offset: 0x00F18F00
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

		// Token: 0x0603619C RID: 221596 RVA: 0x00F1AD78 File Offset: 0x00F18F78
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

		// Token: 0x0401C906 RID: 116998
		private LoopScrollView<DockyardItemListItem, DockyardItemBlockOriginalData> LoopScroll;

		// Token: 0x0401C907 RID: 116999
		public DockyardItemListPanelModel PanelModel;

		// Token: 0x0401C908 RID: 117000
		private readonly Transform DragTipsWorldTrans = Transform.Create();

		// Token: 0x0401C909 RID: 117001
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x0401C90A RID: 117002
		private IItemRange ViewportItemRange;

		// Token: 0x0401C90B RID: 117003
		private UUIItem DragTipsItem;

		// Token: 0x0401C90C RID: 117004
		private bool DragTipsActive;

		// Token: 0x0401C90D RID: 117005
		private UiSequencePlayer TipsSequence;

		// Token: 0x0200B1A3 RID: 45475
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036EB2 RID: 224946
			public const int EmptyItem = 0;

			// Token: 0x04036EB3 RID: 224947
			public const int Count = 1;

			// Token: 0x04036EB4 RID: 224948
			public const int ListItem = 2;

			// Token: 0x04036EB5 RID: 224949
			public const int GridItem = 3;

			// Token: 0x04036EB6 RID: 224950
			public const int Title = 4;

			// Token: 0x04036EB7 RID: 224951
			public const int TitleSprite = 5;

			// Token: 0x04036EB8 RID: 224952
			public const int HelpBtn = 6;

			// Token: 0x04036EB9 RID: 224953
			public const int DragTips = 7;

			// Token: 0x04036EBA RID: 224954
			public const int TimeItem = 8;

			// Token: 0x04036EBB RID: 224955
			public const int TimeTips = 9;
		}
	}
}
